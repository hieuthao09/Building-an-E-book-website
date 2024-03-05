using Accord.MachineLearning;
using CsvHelper;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;

public class Book
{
    public string TenSach { get; set; }
    public string MoTa { get; set; }
}

public class BookRecommender
{
    private List<Book> books;
    private double[][] inputs;

    public BookRecommender(string csvFilePath)
    {
        using (var reader = new StreamReader(csvFilePath))
        using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
        {
            books = csv.GetRecords<Book>().ToList();
        }
        tokenizedDescriptions = books.Select(book => TokenizeContent(book.MoTa)).ToList();
        vocabulary = BuildVocabulary(tokenizedDescriptions);
        inputs = TransformContents(tokenizedDescriptions, vocabulary);
    }

    public string Recommend(string content)
    {
        // Chuyển đổi nội dung nhập vào thành vector đầu vào
        double[] input = TransformContent(content, vocabulary);

        // Sử dụng KMeans để gom cụm
        KMeans kmeans = new KMeans(k: 25);
        int[] labels = kmeans.Compute(inputs);

        // Dự đoán nhãn của nội dung nhập vào
        int predictedLabel = kmeans.Clusters.Decide(input);

        // Trả về sách thuộc cụm đã dự đoán
        return books.Where((book, index) => labels[index] == predictedLabel).Select(book => book.TenSach).FirstOrDefault();
    }
    private string[] TokenizeContent(string content)
    {
        return content.Split(' ');
    }
    private List<string[]> tokenizedDescriptions;
    private List<string> vocabulary;
    private List<string> BuildVocabulary(List<string[]> tokenizedDescriptions)
    {
        var vocabulary = new HashSet<string>();

        foreach (var tokens in tokenizedDescriptions)
        {
            vocabulary.UnionWith(tokens);
        }

        return vocabulary.ToList();
    }

    private double[] TransformContent(string content, List<string> vocabulary)
    {
        var words = TokenizeContent(content);

        var featureVector = new double[vocabulary.Count];

        foreach (var word in words)
        {
            if (vocabulary.Contains(word))
            {
                featureVector[vocabulary.IndexOf(word)]++;
            }
        }

        return featureVector;
    }

    private double[][] TransformContents(List<string[]> tokenizedDescriptions, List<string> vocabulary)
    {
        return tokenizedDescriptions.Select(tokens => TransformContent(string.Join(" ", tokens), vocabulary)).ToArray();
    }
}

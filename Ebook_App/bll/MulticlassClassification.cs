using dll;
using dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Microsoft.ML;
using Microsoft.ML.Data;
using System.Runtime.Remoting.Contexts;

namespace bll
{
    public class Sach_ML
    {
        public string TenSach { get; set; }
        public string MoTa { get; set; }
    }
    public class MulticlassClassification
    {
        Sach_bll s_bll = new Sach_bll();
        MLContext mlContext;
        public MulticlassClassification() {
            mlContext =  new MLContext();
        }
        private ITransformer TrainModel(MLContext mlContext)
        {
            // Load dữ liệu đào tạo từ nguồn dữ liệu (như cơ sở dữ liệu, tệp tin CSV, ...)
            var trainDataPath = "D:\\Sach.csv";

            // Đọc nội dung file CSV
          
            var dataView = mlContext.Data.LoadFromTextFile<Sach_ML>(trainDataPath, separatorChar: ';');

            // Define data preparation pipeline and train the model

            var dataSplit = mlContext.Data.TrainTestSplit(dataView, testFraction: 0.2);
            var pipeline = mlContext.Transforms.Text.FeaturizeText("Features", nameof(Sach_ML.MoTa))
            .Append(mlContext.Transforms.Conversion.MapValueToKey("Label", nameof(Sach_ML.TenSach)));

            var model = pipeline.Fit(dataSplit.TrainSet);
            return model;
        }
        static void SaveModel(MLContext mlContext, ITransformer model, string filePath)
        {
            // Save the model to a file
            mlContext.Model.Save(model, null, filePath);
            Console.WriteLine($"Model saved to: {filePath}");
        }

        static ITransformer LoadModel(MLContext mlContext, string filePath)
        {
            if (File.Exists(filePath))
            {
                var loadedModel = mlContext.Model.Load(filePath, out var modelSchema);
                Console.WriteLine($"Model loaded from: {filePath}");
                return loadedModel;
            }

            return null;
        }
        
        public  string Train(string motasachmoi)
        {

           
            // Sử dụng mô hình đã lưu
            ITransformer loadedModel = LoadModel(mlContext, "D:\\model.zip");

            // Dự đoán sách gợi ý cho mô tả sITransformer model = LoadModel(mlContext, "model.zip");

            if (loadedModel == null)
            {
                // Huấn luyện mô hình (nếu chưa có mô hình đã lưu)
                ITransformer model = TrainModel(mlContext);
                // Lưu mô hình vào tệp tin
                SaveModel(mlContext, model, "D:\\model.zip");
                loadedModel = LoadModel(mlContext, "D:\\model.zip");
            }
            var predictionEngine = mlContext.Model.CreatePredictionEngine<Sach_ML, SachGoiY>(loadedModel);



            // Thực hiện dự đoán
            var prediction = predictionEngine.Predict(new Sach_ML { MoTa = motasachmoi });

            return prediction.PredictedLabels;
        }
       
    }
    public class SachGoiY
    {
        [ColumnName("PredictedLabel")]
        public string PredictedLabels;
    }
    
}

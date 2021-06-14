using IVision.Learning.Core.Recognition;
using System;
using System.Threading;

namespace IVisiong.Learning.Core.Training
{
    class Program
    {
        private static string Input = @"D:\Git\IVision\IVisiong.Learning.Core.Training\Hands";
        private static string Output = @"D:\Git\IVision\IVisiong.Learning.Core.Training\model.zip";
        static void Main(string[] args)
        {
            ImageRecognition.TrainDataSet(Input, Output);
        }
    }
}

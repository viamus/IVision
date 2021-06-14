using Microsoft.ML.Data;

namespace IVision.Learning.Core.Image
{
    public class ImageStream
    {
        [LoadColumn(0)]
        public string ImagePath { get;  set; }

        [LoadColumn(1)]
        public string Label { get;  set; }
    }
}

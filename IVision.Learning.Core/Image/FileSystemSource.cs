using System.Collections.Generic;
using System.IO;

namespace IVision.Learning.Core.Image
{
    public class FileSystemSource 
    {
        public static IEnumerable<ImageStream> GetImages(string inputPath)
        {
            var files = Directory.GetFiles(inputPath, "*", searchOption: SearchOption.AllDirectories);

            foreach (var file in files)
            {
                if ((Path.GetExtension(file) != ".jpg") && (Path.GetExtension(file) != ".png"))
                {
                    continue;
                }

                yield return new ImageStream
                {
                    ImagePath = file,
                    Label = Directory.GetParent(file).Name
                };
            }
        }
    }
}

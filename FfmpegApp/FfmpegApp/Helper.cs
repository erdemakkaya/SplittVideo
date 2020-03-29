using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FfmpegApp
{
    public static class Helper
    {
        public static List<double> ConvertToSeconds(List<string> secondLines)
        {
            var seconds = new List<double>();
            for (int i = 0; i < secondLines.Count; i++)
            {
                var value = secondLines[i].Split(':');
                var minute = int.Parse(value[1]);
                var second = int.Parse(value[2]);
                var milisecond = Convert.ToDouble(value[3]);
                milisecond = milisecond / 100000;
                double total = 60 * minute + second + milisecond;
                seconds.Add(total);
            }
            return seconds;
        }

        public static List<int> checkOutputFolderForExistFiles(string outputFolder, string extensionName)
        {
            var existingFileNameValues = new List<int>();

            var fileNames = Directory.GetFiles(outputFolder, "*" + extensionName)
                                            .Select(Path.GetFileNameWithoutExtension)
                                            .ToList();
            fileNames.ForEach(x => existingFileNameValues.Add(int.Parse(x)));
            return existingFileNameValues;
        }
    }
}

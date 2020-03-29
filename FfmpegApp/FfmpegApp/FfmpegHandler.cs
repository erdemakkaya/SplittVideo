using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FfmpegApp.Models;
using MediaToolkit;
using MediaToolkit.Model;

namespace FfmpegApp
{
    public class FfmpegHandler
    {
        public static void ExecuteFFMpeg(string command)
        {
            Process process = new Process();
            process.StartInfo.FileName = "cmd.exe";
            process.StartInfo.Arguments = $@"/c  ffmpeg.exe {command}";
            process.StartInfo.UseShellExecute = false;
            process.Start();
            process.WaitForExit();
            System.Threading.Thread.Sleep(10000);
        }

        public static string ConvertFile(ConvertFileDetails convertFileDetails,
            EventHandler<ConvertProgressEventArgs> convertProgressEvent, EventHandler<ConversionCompleteEventArgs> conversionCompleteEvent)
        {
            try
            {
                using (var engine = new Engine())
                {
                    var inputFile = new MediaFile { Filename = convertFileDetails.InputFilePath };
                    var outputFile = new MediaFile { Filename = convertFileDetails.OutputFilePath };

                    
                    engine.ConvertProgressEvent += convertProgressEvent;
                    engine.ConversionCompleteEvent += conversionCompleteEvent;

                    engine.Convert(inputFile, outputFile);

                    Process.Start("explorer.exe", "/select, \"" + convertFileDetails.OutputFilePath + "\"");
                    return "Success";

                }
            }
            catch
            {
                return "Error";
            }

        }

    }
}

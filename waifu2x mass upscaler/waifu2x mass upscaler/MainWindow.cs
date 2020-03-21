using System;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;

namespace waifu2x_mass_upscaler
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void UpscaleButton_Click(object sender, EventArgs e)
        {
            string[] fileEntries = Directory.GetFiles(@"..\to upscale");
            UpscaleProgressBar.Maximum = fileEntries.Length;
            UpscaleProgressBar.Value = 0;
            foreach (string fileName in fileEntries)
            {
                if (fileName.EndsWith(".jpg") || fileName.EndsWith(".jpeg") || fileName.EndsWith(".png"))
                {
                    Upscale(@"..\to upscale\" + fileName, 3, 2);
                }
                UpscaleProgressBar.PerformStep();
            }
        }

        static void Upscale(string filePath, int noiseReductionLevel, int scaleLevel)
        {
            ProcessStartInfo startInfo = new ProcessStartInfo();
            startInfo.CreateNoWindow = false;
            startInfo.UseShellExecute = false;
            startInfo.FileName = @"waifu2x-ncnn-vulkan.exe";
            startInfo.WindowStyle = ProcessWindowStyle.Hidden;
            startInfo.Arguments = $"-i \"{filePath}\" -o \"{filePath.Substring(0, filePath.LastIndexOf(".")) + " upscaled.png"}\" -n {noiseReductionLevel} -s {scaleLevel}";
            Debug.WriteLine(startInfo.Arguments);

            try
            {
                using (Process exeProcess = Process.Start(startInfo))
                {
                    exeProcess.WaitForExit();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }
    }
}

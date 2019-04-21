using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDK_of_PythonOpenCV_for_CsharpDevelopers.OpencvSDK
{
    public class OpencvSdk
    {
        //if you use anaconda :
        //C:\Users\{your user name}\Anaconda3\python.exe
        //C:\Users\Options\Anaconda3\python.exe
        private string PythonExePath;
        
     

        public OpencvSdk(string pythonExePath)
        {
            this.PythonExePath = pythonExePath;
        }

        public void EdgeDetection(string imageFullPath)
        {
            ///////////////////////////////////
            /// connect c# to python
            /// ///////////////////////////////
            // 1. Create Process Info with Configration it
            var psi = CreateProcess();

            // 2. determin full path of the the required python script and its arguments
            var script = @"D:\_Programming\SDK-Idea-Demo-for-Nyuad-Hackathon-2019\SDK_of_PythonOpenCV_for_CsharpDevelopers\SDK_of_PythonOpenCV_for_CsharpDevelopers\OpencvSDK\EdgeDetection.py";
            psi.Arguments = $"\"{script}\" \"{imageFullPath}\" ";

            // 3. Execute process and get output
            var errors = "";
            var results = "";

            using (var process = Process.Start(psi))
            {
                errors = process.StandardError.ReadToEnd();
                results = process.StandardOutput.ReadToEnd();
            }
        }

        //connect c# to python
        private ProcessStartInfo CreateProcess()
        {
            // 1) Create Process Info
            var psi = new ProcessStartInfo();
            psi.FileName = this.PythonExePath;

            // 2) Process configuration
            psi.UseShellExecute = false;
            psi.CreateNoWindow = true;
            psi.RedirectStandardOutput = true;
            psi.RedirectStandardError = true;

            return psi;
        }
    }
}

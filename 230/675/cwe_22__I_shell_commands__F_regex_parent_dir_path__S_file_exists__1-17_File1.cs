
/*
input : shell commands
filtering : remove first "../" in path
sink : check if a file exists
*/
/*
Copyright 2016 Bertrand STIVALET

Permission is hereby granted, without written agreement or royalty fee, to
use, copy, modify, and distribute this software and its documentation for
any purpose, provided that the above copyright notice and the following
three paragraphs appear in all copies of this software.

IN NO EVENT SHALL AUTHORS BE LIABLE TO ANY PARTY FOR DIRECT,
INDIRECT, SPECIAL, INCIDENTAL, OR CONSEQUENTIAL DAMAGES ARISING OUT OF THE
USE OF THIS SOFTWARE AND ITS DOCUMENTATION, EVEN IF AUTHORS HAVE
BEEN ADVISED OF THE POSSIBILITY OF SUCH DAMAGE.

AUTHORS SPECIFICALLY DISCLAIM ANY WARRANTIES INCLUDING, BUT NOT
LIMITED TO THE IMPLIED WARRANTIES OF MERCHANTABILITY, FITNESS FOR A
PARTICULAR PURPOSE, AND NON-INFRINGEMENT.

THE SOFTWARE IS PROVIDED ON AN "AS-IS" BASIS AND AUTHORS HAVE NO
OBLIGATION TO PROVIDE MAINTENANCE, SUPPORT, UPDATES, ENHANCEMENTS, OR
MODIFICATIONS.

*/
using System;
using System.Text.RegularExpressions;
using System.IO;
using System.Diagnostics;

namespace default_namespace{
    class MainClass3135{
        public static void Main(string[] args){
            string tainted_0 = null;
string tainted_5 = null;

            
                Process process = new Process();
                process.StartInfo.FileName = "/bin/bash";
                process.StartInfo.Arguments = "-c 'cat /tmp/tainted.txt'";
                process.StartInfo.UseShellExecute = false;
                process.StartInfo.RedirectStandardOutput = true;
                process.Start();

                using(StreamReader reader = process.StandardOutput) {
                    tainted_0 = reader.ReadToEnd();
                    process.WaitForExit();
                    process.Close();
                }
            
tainted_5 = tainted_0;
            tainted_5 = function_3134(tainted_0);
            
                //flaw

                File.Exists(tainted_5);
            
            
        }
        
                public static string function_3134(string param_3134 ){
                    string tainted_2 = null;
string tainted_3 = null;

                    tainted_2 = param_3134;
                    
                string pattern = "^\\.\\.\\/";
                Regex r = new Regex(pattern);
                tainted_3 = r.Replace(tainted_2, "");
            
                    return tainted_3;
                }
    }
}
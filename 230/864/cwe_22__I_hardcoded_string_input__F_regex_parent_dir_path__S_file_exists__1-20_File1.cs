
/*
Hardcoded string input
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

namespace default_namespace{
    class MainClass3511{
        public static void Main(string[] args){
            string tainted_0 = null;
string tainted_5 = null;

            
                tainted_0 = "hardcoded";
            
tainted_5 = tainted_0;
            
                Class_3510 var_3510 = new Class_3510(tainted_0);
                tainted_5 = var_3510.get_var_3510();
            
                
                File.Exists(tainted_5);
            
            
        }
        
    }
}
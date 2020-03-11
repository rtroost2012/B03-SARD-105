
/*
Hardcoded string input
filtering : remove all "../" in path
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
    class MainClass4255{
        public static void Main(string[] args){
            string tainted_2 = null;
string tainted_3 = null;
string tainted_4 = null;

            
                tainted_2 = "hardcoded";
            
tainted_4 = tainted_2;
            
                
                string pattern = "^[\\.\\.\\/]+";
                Regex r = new Regex(pattern);
                tainted_3 = r.Replace(tainted_2, "");
            
                Class_4254 var_4254 = new Class_4254(tainted_3);
                tainted_4 = var_4254.get_var_4254();
            
                
                File.Exists(tainted_4);
            
            
        }
        
    }
}
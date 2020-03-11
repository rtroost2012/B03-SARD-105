
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
                using System.Text.RegularExpressions;
                namespace default_namespace{
                    class Class_3140{
                        string var_3140;
                        public Class_3140(string tainted_2_3140){
                            var_3140 = tainted_2_3140;
                        }
                        public string get_var_3140(){
                            string tainted_2 = null;
string tainted_3 = null;

                            tainted_2 = var_3140;
                            
                string pattern = "^\\.\\.\\/";
                Regex r = new Regex(pattern);
                tainted_3 = r.Replace(tainted_2, "");
            
                            return tainted_3;
                        }
                        
                    }
                }
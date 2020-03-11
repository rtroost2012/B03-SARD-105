
                /*
                input : shell commands
filtering : remove semi-colon and all invalid filenames and chars in paths
sink : XPATH prepared
exec_query : xpath prepared statement
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
using System.IO;
                namespace default_namespace{
                    class Class_61608{
                        string var_61608;
                        public Class_61608(string tainted_2_61608){
                            var_61608 = tainted_2_61608;
                        }
                        public string get_var_61608(){
                            string tainted_2 = null;
string tainted_3 = null;

                            tainted_2 = var_61608;
                            
                string regexSearch = new string(Path.GetInvalidFileNameChars()) + new string(Path.GetInvalidPathChars()) + ";";
                Regex r = new Regex(string.Format("[{0}]", Regex.Escape(regexSearch)));
                tainted_3 = r.Replace(tainted_2, "");
            
                            return tainted_3;
                        }
                        
                    }
                }

                /*
                input : direct user input in string
filtering : check if there is only numbers
construction : concatenation with simple quote
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
                    class Class_9245{
                        string var_9245;
                        public Class_9245(string tainted_2_9245){
                            var_9245 = tainted_2_9245;
                        }
                        public string get_var_9245(){
                            string tainted_2 = null;
string tainted_3 = null;

                            tainted_2 = var_9245;
                            
                string pattern = @"/^[0-9]*$/";
                Regex r = new Regex(pattern);
                Match m = r.Match(tainted_2);
                if(!m.Success){
                    tainted_3 = "";
                }else{
                    tainted_3 = tainted_2;
                }
            
                            return tainted_3;
                        }
                        
                    }
                }
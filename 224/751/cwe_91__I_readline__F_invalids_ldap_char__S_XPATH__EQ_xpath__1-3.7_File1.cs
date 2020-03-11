
/*
input : direct user input in string
filtering : remove all '\', '*', '(', ')', 'u0000', '/' in parameter
sink : XPATH Query
exec_query : xpath
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
using System.Text;
using System.Xml.XPath;
using System.Xml;

namespace default_namespace{
    class MainClass55000{
        public static void Main(string[] args){
            string tainted_2 = null;
string tainted_3 = null;

            
                tainted_2 = Console.ReadLine();
            
tainted_3 = tainted_2;
            
                if((Math.Sqrt(42)<=42)){
                    {}
                }else{
                    
                StringBuilder escape = new StringBuilder();
                for (int i = 0; i < tainted_2.Length; ++i){
                    char current = tainted_2[i];
                    switch (current){
                        case '\\':
                            escape.Append(@"\5c");
                            break;
                        case '*':
                            escape.Append(@"\2a");
                            break;
                        case '(':
                            escape.Append(@"\28");
                            break;
                        case ')':
                            escape.Append(@"\29");
                            break;
                        case '\u0000':
                            escape.Append(@"\00");
                            break;
                        case '/':
                            escape.Append(@"\2f");
                            break;
                        default:
                            escape.Append(current);
                            break;
                    }
                }
                tainted_3 = escape.ToString();
            
                }
            
                //flaw

                string query = "//user[@name='" + tainted_3 + "']";
            
            
            string filename = "file.xml";
            XmlDocument document = new XmlDocument( );
            document.Load(filename);
            XmlTextWriter writer = new XmlTextWriter(Console.Out);
            writer.Formatting = Formatting.Indented;

            XmlNode node = document.SelectSingleNode(query);
            node.WriteTo(writer);

            writer.Close( );
        
        }
        
    }
}

/*
input : direct user input in string
no filtering
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
using System.Linq;
using System;
using System.Xml.Linq;
using System.Xml;

namespace default_namespace{
    class MainClass60314{
        public static void Main(string[] args){
            string tainted_0 = null;
string tainted_5 = null;

            
                tainted_0 = Console.ReadLine();
            
tainted_5 = tainted_0;
            
                Class_60313 var_60313 = new Class_60313(tainted_0);
                tainted_5 = var_60313.get_var_60313();
            
                
                string query = tainted_5;
            
            
            string filename = "file.xml";
            XDocument document = XDocument.Load(filename);
            XmlTextWriter writer = new XmlTextWriter(Console.Out);
            writer.Formatting = Formatting.Indented;
            var node = document.Root.Elements("foo")
                   .Where(x => (string) x.Element("bar") == query)
                   .SingleOrDefault();
            node.WriteTo(writer);
            writer.Close( );
        
        }
        
    }
}
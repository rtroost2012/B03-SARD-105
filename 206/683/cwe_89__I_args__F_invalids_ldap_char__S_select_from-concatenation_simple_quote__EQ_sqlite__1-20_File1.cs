
/*
Command line args
filtering : remove all '\', '*', '(', ')', 'u0000', '/' in parameter
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
using System;
using System.Text;
using System.Data;
using System.Data.SQLite;

namespace default_namespace{
    class MainClass19051{
        public static void Main(string[] args){
            string tainted_0 = null;
string tainted_5 = null;

            
                tainted_0 = args[1];
            
tainted_5 = tainted_0;
            
                Class_19050 var_19050 = new Class_19050(tainted_0);
                tainted_5 = var_19050.get_var_19050();
            
                //flaw

                string query = "SELECT * FROM '" + tainted_5 + "'";
            
            
            SQLiteConnection dbConnection = null;
            try{
                dbConnection = new SQLiteConnection("data source=C:\\data");
                SQLiteCommand command = new SQLiteCommand(query, dbConnection);
                SQLiteDataReader reader = command.ExecuteReader();
                while (reader.Read()){
                    Console.WriteLine(reader.ToString());
                }
                dbConnection.Close();
            }catch(Exception e){
                Console.WriteLine(e.ToString());
            }
        
        }
        
    }
}
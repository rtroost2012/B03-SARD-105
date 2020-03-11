
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
using System;
using MySql.Data.MySqlClient;
using System.Text.RegularExpressions;

namespace default_namespace{
    class MainClass9240{
        public static void Main(string[] args){
            string tainted_0 = null;
string tainted_5 = null;

            
                tainted_0 = Console.ReadLine();
            
tainted_5 = tainted_0;
            tainted_5 = function_9239(tainted_0);
            
                
                string query = "SELECT * FROM '" + tainted_5 + "'";
            
            
            string connectionString = @"server=localhost;uid=mysql_user;password=mysql_password;database=dbname";
            MySqlConnection dbConnection = null;
            try {
                dbConnection = new MySqlConnection(connectionString);
                dbConnection.Open();
                MySqlCommand cmd = dbConnection.CreateCommand();
                cmd.CommandText = query;
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read()){
                    Console.WriteLine(reader.ToString());
                }
                dbConnection.Close();
            } catch (Exception e) {
                Console.WriteLine(e.ToString());
            }
        
        }
        
                public static string function_9239(string param_9239 ){
                    string tainted_2 = null;
string tainted_3 = null;

                    tainted_2 = param_9239;
                    
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
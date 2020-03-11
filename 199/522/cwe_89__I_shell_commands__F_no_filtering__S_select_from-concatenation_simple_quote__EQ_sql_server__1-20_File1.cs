
/*
input : shell commands
no filtering
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
using System.Data.SqlClient;
using System;
using System.IO;
using System.Diagnostics;

namespace default_namespace{
    class MainClass4806{
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
            
                Class_4805 var_4805 = new Class_4805(tainted_0);
                tainted_5 = var_4805.get_var_4805();
            
                //flaw

                string query = "SELECT * FROM '" + tainted_5 + "'";
            
            
            string connectionString =  @"server=localhost;uid=sql_user;password=sql_password;database=dbname";
            SqlConnection dbConnection = null;
            try {
                dbConnection = new SqlConnection(connectionString);
                dbConnection.Open();
                SqlCommand cmd = dbConnection.CreateCommand();
                cmd.CommandText = query;
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read()){
                    Console.WriteLine(reader.ToString());
                }
                dbConnection.Close();
            } catch (Exception e) {
                Console.WriteLine(e.ToString());
            }
        
        }
        
    }
}
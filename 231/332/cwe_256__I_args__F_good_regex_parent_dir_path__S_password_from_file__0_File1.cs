
/*
Command line args
filtering : remove all "../" in path
sink : connection to a database using hardcoded password in a file
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
using System.Reflection;
using MySql.Data.MySqlClient;
using System.IO;
using System.Linq;
using System.Collections.Generic;

namespace default_namespace{
    class MainClass63650{
        public static void Main(string[] args){
            
            
            
            
                var data = new Dictionary<string, string>();
                foreach (var row in File.ReadAllLines("./config.properties"))
                    data.Add(row.Split('=')[0], string.Join("=",row.Split('=').Skip(1).ToArray()));

                Console.WriteLine(data["username"]);
                //flaw

                Console.WriteLine(data["password"]);
                string connectionString = @"server=localhost;uid=" + data["username"] + ";password=" + data["password"] + ";database=dbname";
                MySqlConnection dbConnection = null;

                try {
                    dbConnection = new MySqlConnection(connectionString);
                    dbConnection.Open();

                    dbConnection.Close();

                } catch (Exception e) {
                    Console.WriteLine(e.ToString());
                }
            
            
        }
        
    }
}
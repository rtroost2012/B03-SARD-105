
/*
Command line args
no filtering
sink : LDAP Query
LDAP Query
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
using System.DirectoryServices;

namespace default_namespace{
    class MainClass49582{
        public static void Main(string[] args){
            string tainted_2 = null;
string tainted_3 = null;
string tainted_4 = null;

            
                tainted_2 = args[1];
            
tainted_4 = tainted_2;
            
                
                //No filtering (sanitization)
                tainted_3 = tainted_2;
            
                tainted_4 = function_49581(tainted_3);
            
                //flaw

                string query = "(&(objectClass=person)(sn=" + tainted_4 + "))";
            
            
            string strConnect = "LDAP://my.site.com/o=site,c=com";
            using (System.DirectoryServices.DirectoryEntry CN_Main = new System.DirectoryServices.DirectoryEntry(strConnect)){
                string strResult = "";
                System.DirectoryServices.DirectorySearcher DirSearcher = new System.DirectoryServices.DirectorySearcher(CN_Main, query);
                System.DirectoryServices.DirectoryEntry CN_Result;
                CN_Main.AuthenticationType = AuthenticationTypes.None;
                foreach (System.DirectoryServices.SearchResult ResultSearch in DirSearcher.FindAll()){
                    if (ResultSearch != null){
                        CN_Result = ResultSearch.GetDirectoryEntry();
                        if ((string)CN_Result.Properties["userclass"][0] == "noname"){
                            strResult = strResult + "Name : " + CN_Result.InvokeGet("sn");
                        }
                    }
                }
                Console.WriteLine(strResult);
            }
        
        }
        
                public static string function_49581(string param_49581 ){
                    return param_49581 ;
                }


    }
}
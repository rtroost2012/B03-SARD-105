
/*
Command line args
filtering : remove all "../" in path
sink : print exception
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

namespace default_namespace{
    class MainClass63651{
        public static void Main(string[] args){
            
            
            
            
                int num, sum = 0, r;
                System.Console.WriteLine("Hello, World!");
                int[] intArray = new int[7] { 2,37,849,24,42,-10,93 };
                Array.Sort(intArray);
                foreach (int nb in intArray){
                    r = nb + 3;
                    num = r / 10;
                    sum = num + nb;
                    Console.WriteLine("Current sum : "+sum);
                }
                try{
                    int a = 0;
                	int b = 1;
                    throw new System.DivideByZeroException();
                	for (int i = 0; i < sum; i++){
                	    int temp = a;
                	    a = b;
                	    b = temp + b;
                	}
                    Console.WriteLine("Fib : "+a);
                }catch (DivideByZeroException e){
                    //flaw

                    Console.WriteLine(e.Message);
                }
            
            
        }
        
    }
}
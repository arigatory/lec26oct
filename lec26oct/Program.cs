﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lec26oct
{
    class Program
    {
        static void Main(string[] args)
        {
            // class    value   ref
            // struct   value   ref
            int[] ar = new[] {4, 5, 6};
            
            int i = Add(0,ar);
            Console.WriteLine(Add(Add(4),Add(4)));
            
            //demo params


            //demo string

            
            

            Console.ReadLine();
        }

        static int Add(int x, params int[] others)
        {
            int result = x;
            for (int i = 0; i < others.Length; i++)
            {
                result+= others[i];
            }
            return result;
        }

        static string CreateSqlQuery(int[] ids)
        {
            string result = "select * from Orders where ID=";

            for (int i = 0; i < ids.Length; i++)
            {
                result += ids[i] + ", ";
            }

            result = result.Remove(result.Length - 2, 2);
            return result;
        }

    }
}


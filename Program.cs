using System.Collections.Generic;
using System;
using System.Collections;
using System.Linq;
using System.Text;


namespace AddressBook
{
    class program
    {
        public static void Main(string[] args)
        {
            int[] a = new int[6];

            ArrayList arraylist = new ArrayList();


            arraylist.Add("Riyas");
            arraylist.Add("Khan");
            arraylist.Add("NO 9,Saint thererasa street");
            arraylist.Add("Pondicherry");
            arraylist.Add("PH : 9876543210");
            arraylist.Add("email : abcdefgh@gmail.com");

            foreach(var ele in arraylist)
            {
                Console.WriteLine(ele);
            }

            arraylist.RemoveAt(1);           //Delete person name//
            arraylist.RemoveAt(2);

            Console.WriteLine("----------");

            foreach (var ele in arraylist)
            {
                Console.WriteLine(ele);
            }
        }
    }
}
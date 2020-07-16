using System;
using System.Collections.Generic;
using System.Linq;

namespace Assessment
{
    class MainClass
    {
        public void First()
        {
            int ele;
            List<int> x = new List<int>();
            string numb = "1-2-3-4-5";
                foreach(var c in numb)
            {
                if (c != '-')
                 {
                    ele = int.Parse(c.ToString());
                    x.Add(ele);
         
                 }
                //Console.WriteLine(c);
                
            }
            int fint = 0;
            bool status;

            for(int i=0;i<=x.Count;i++)
            {
                if (i + 1 == x.Count) break;

                int diff = x[i + 1] - x[i];
                    if (i > 2)
                {
                    if(fint.Equals(diff))
                    {
                        fint = diff;
                    }
                    else
                    {
                        status = false;
                        Console.WriteLine(status);
                        return;
                    }
                }
                else
                {
                    fint = diff;
                }
                      
            }
            status = true;
            Console.WriteLine(status);
           
        }



        public void Second()
        {
            int[] arry = { 2, 8, 15, 20, 34 };
            int k = 4;

            arry = arry.Select(x => Math.Abs(x)).ToArray();
            List<String> myList = new List<String>();


            for (int i = 0; i < arry.Length; i++)
            {
                for (int m = i + 1; m < arry.Length; m++)
                {
                    int diff = arry[i] - arry[m];
                    myList.Add(Math.Abs(diff).ToString());
                }

            }
            myList.Distinct();
           if (k<myList.Count)
                Console.WriteLine(myList[k]);
           else
                Console.WriteLine("-1");
        }   

        public void Third()
        { 
                Console.WriteLine("ENter name");
                string name = Console.ReadLine();
                int cnt;
                string outp=null;

            while (name.Length>0)
            {
                cnt = 0;
                for (int i = 0; i < name.Length; i++)
                {
                    if (name[0] == name[i])
                    {
                        cnt++;
                    }
                }

                  outp += name[0] + ":" + cnt + "\n";
                name = name.Replace(name[0].ToString(),null);
                
            }
            Console.WriteLine(outp);
        }
        public static void Main(string[] args)
        {
            var mc = new MainClass();
            try
            {
                mc.Second();
            }catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
            Console.ReadKey();
        }
    }
}

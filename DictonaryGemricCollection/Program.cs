using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DictonaryGemricCollection
{
    class Program
    {
        static void Main(string[] args)
        {
            //Dictionary<string, string> mydict = new Dictionary<string, string>();
            //mydict.Add("position", "location/places/situation/spot/site/locality/posture..");
            //mydict.Add("respond", "answer/reply/riposte/rejoin/relitate..");
            //mydict.Add("smile", "grin/gently laugh/giggle..");
            //mydict.Add("someone else", "another man who is unkown..");
            //mydict.Add("confide", "tell someone about a secret or private matter while trusting..");
            //Console.WriteLine(mydict["position"]);
            //foreach (KeyValuePair<string, string> item in mydict)
            //{
            //    Console.WriteLine("key is:" + item.Key + "value is:" + item.Value);
            //}

            //Dictionary<float, string> mydict2 = new Dictionary<float, string>();
            //mydict2.Add(6.00f, "social study book..");
            //mydict2.Add(6.30f, "computer book..");
            //mydict2.Add(7.10f, "english book..");
            //mydict2.Add(7.40f, "nepali book..");
            //mydict2.Add(8.10f, "science book..");
            //mydict2.Add(8.40f, "opt math book..");
            //mydict2.Add(9.10f, "Math book..");
            //foreach (var item in mydict2)
            //{
            //    Console.WriteLine(item);
            //}

            //foreach ( string key in mydict.Keys)
            //{
            //    Console.WriteLine(key);
            //}
            //Console.WriteLine("_________________________________________________________________");
            //foreach (string value in mydict.Values)
            //{
            //    Console.WriteLine(value);
            //}

            Dictionary<TimeSpan, string> mydict2 = new Dictionary<TimeSpan, string>();
            mydict2.Add(new TimeSpan(6, 0, 0), "social study book");
            mydict2.Add(new TimeSpan(6, 35, 0), "computer book");
            mydict2.Add(new TimeSpan(7, 5, 0), "english book");
            mydict2.Add(new TimeSpan(7, 35, 0), "nepali book");
            mydict2.Add(new TimeSpan(8, 5, 0), "science book");
            mydict2.Add(new TimeSpan(8, 35, 0), "opt math  book");
            mydict2.Add(new TimeSpan(9, 5, 0), "math book");
            Console.WriteLine("class subject routine...");
            Console.WriteLine("---------------------------------");
            foreach (var item in mydict2)
            {
                Console.WriteLine($"{item.Key:hh\\:mm} AM - {item.Value}");
            }


            Console.ReadLine();
        }
    }
}

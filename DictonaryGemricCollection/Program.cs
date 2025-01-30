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
            Dictionary<string, string> mydict = new Dictionary<string, string>();
            mydict.Add("position", "location/places/situation/spot/site/locality/posture..");
            mydict.Add("respond", "answer/reply/riposte/rejoin/relitate..");
            mydict.Add("smile", "grin/gently laugh/giggle..");
            mydict.Add("someone else", "another man who is unkown..");
            mydict.Add("confide", "tell someone about a secret or private matter while trusting..");
            //Console.WriteLine(mydict["position"]);
            //foreach (KeyValuePair<string,string> item in mydict)
            //{
            //    Console.WriteLine("key is:"+item.Key+"value is:"+item.Value);
            //}
            foreach ( string key in mydict.Keys)
            {
                Console.WriteLine(key);
            }
            Console.WriteLine("_________________________________________________________________");
            foreach (string value in mydict.Values)
            {
                Console.WriteLine(value);
            }
            Console.ReadLine();
        }
    }
}

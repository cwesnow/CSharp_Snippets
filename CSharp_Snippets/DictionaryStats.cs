using System;
using System.Collections.Generic;

namespace CSharp_Snippets
{
    public class AbstractStat
    {
        public string name { get; set; }
        public int min { get; set; }
        public int current { get; set; }
        public int max { get; set; }
    }

    enum Stats { Height, Weight, Age, Blood, Speed, Learning, }

    class DictionaryStats : Play
    {
        public void Play()
        {
            Dictionary<Stats, AbstractStat> statsDic = new Dictionary<Stats, AbstractStat>();

            foreach (Stats entry in Enum.GetValues(typeof(Stats)))
            {
                statsDic.Add(entry, new AbstractStat());
            }

            foreach (System.Collections.Generic.KeyValuePair<Stats, AbstractStat> x in statsDic)
            {
                x.Value.name = x.Key.ToString();
                x.Value.min = 0;
                x.Value.max = 10;
                x.Value.current = DateTime.Now.Millisecond % 11;

                Console.WriteLine("Name: {1}{0}  Range: {2} to {3}{0}  Current {4}{0}",
                    Environment.NewLine, x.Value.name, x.Value.min, x.Value.max, x.Value.current);
            }

            Console.ReadKey();
        }
    }
}

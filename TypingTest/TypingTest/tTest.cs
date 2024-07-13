using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Timers;
using System.Diagnostics;
using Microsoft.VisualBasic;

namespace TypingTest
{
    internal class tTest
    {
        private long totalTime;
        private Stopwatch timer;
        public List<string> test;
        private string text;
        StreamReader testReader;
        
        public tTest() { text = "F:\\Projects\\SuperWord\\TypingTest\\TypingTest\\TextFile1.txt";  testReader = new StreamReader(text); }
        
        //public tTest(int time) { timer = new Timer(time); }

        public void testWords()
        {
            try
            {

                string line = testReader.ReadLine();
                timer = new Stopwatch();
                timer.Start();
                string userLine;
                int i = 0;
                test = new List<string>();
                while (line != null && i <= 100)
                {
                    Console.WriteLine(line);
                    userLine = Console.ReadLine();
                    try
                    {
                        test.Add(userLine);
                        i ++;
                    }
                    catch { }

                    line = testReader.ReadLine();
                }
                totalTime = timer.ElapsedMilliseconds;
                timer.Stop();
                //Console.WriteLine(totalTime);
                testReader.Close();
                testAvg();
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);
            }
        }
        public float testAvg()
        {
            int diff = 0;
            int total = 0;
            try
            {
                testReader = new StreamReader(text);
                string line = testReader.ReadLine();

                int d = 0;

                while (line != null)
                {
                    int i = 0;
                    
                    foreach (char c in line)
                    {
                        char a;
                        total++;
                        try
                        {
                            a = test[d][i];
                        }
                        catch 
                        { 
                            if (c == '-')
                            {
                                a = '_';
                            }
                            else
                            {
                                a = '-';
                            }
                        }
                        if (c != a)
                        {
                            diff++;
                        }
                        i++;
                    }
                    line = testReader.ReadLine();
                    d++;
                }
                double percent = (Math.Abs((((double)diff / (double)total) - (double)1)) * 100);
                double time = (double)totalTime / (double)60000;
                if ((total - diff) == 0)
                {
                    //Console.WriteLine("fish");
                    return (0);
                }
                else
                {
                    Console.WriteLine("Elapsed Time : " + time + "Minutes");
                    Console.WriteLine("Percent Right : " + percent + "%");
                    Console.WriteLine(((total * (percent / 100)) / 5.1) / time);
                }
                testReader.Close();
                Console.ReadLine();
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);
            }
            
            return ((total - diff) / 100);
        }
    }
}

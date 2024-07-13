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
        
        public tTest() 
        {
            try { text = "F:\\Projects\\SuperWord\\TypingTest\\TypingTest\\TextFile1.txt"; }
            catch (Exception e) { Console.WriteLine("There is no text file." + e.Message); } 
        }
        
        public tTest(string address) { text = address; }

        public void testWords() // conducts and gathers the information from the test
        {
            try
            {
                testReader = new StreamReader(text);
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
                testReader.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);
            }
        }

        public double testAvg() //calculates and returns the words per minute
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
                double wpm = ((total * (percent / 100)) / 5.1) / time;
                Console.WriteLine("Elapsed Time : " + time + "Minutes");
                Console.WriteLine("Percent Right : " + percent + "%");
                Console.WriteLine("Words Per Minute : " + ((total * (percent / 100)) / 5.1) / time);
                testReader.Close();
                return (wpm);
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);
            }
            return 0;
        }
    }
}

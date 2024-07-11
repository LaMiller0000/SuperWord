using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace TypingTest
{
    internal class tTest
    {
        private Timer timer;
        public List<string> test;
        StreamReader testReader = new StreamReader("F:\\Projects\\SuperWord\\TypingTest\\TypingTest\\TextFile1.txt");
        
        public tTest() { }
        
        public tTest(int time) { timer = new Timer(time); }

        public void testWords()
        {
            try
            {
                string line = testReader.ReadLine();
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
                testReader.Close();
                Console.ReadLine();

            }
            catch (Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);
            }

        }
        public float testAvg()
        {
            return (0);
        }
    }
}

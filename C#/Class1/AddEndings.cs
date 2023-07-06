using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class1
{
    internal class AddEndings
    {
        private string[] words;
        private string endings;

        public string[] Words { get => words; set => words = value; }
        public string Endings { get => endings; set => endings = value; }
        public AddEndings(string[] words, string endings) 
        {
            this.words = words;
            this.endings = endings;
        }
        public void Output()
        {
            for (int i = 0; i < this.words.Length; i++)
            {
                this.words[i] = this.words[i] + this.endings;
            }
            for (int i = 0; i < this.words.Length; i++)
            {
                Console.Write(this.words[i] + " ");
            }

        }
    }
}

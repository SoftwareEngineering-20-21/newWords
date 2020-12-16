using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NewWords.Models
{
    class GameContext
    {
        public class words {
            public string orig { get; set; }
            public string t1 { get; set; }
            public string t2 { get; set; }
            public string t3 { get; set; }
            public string t4 { get; set; }
            public string definition { get; set; }
            public string right { get; set; }
            public words(string orig, string t1, string t2, string t3, string t4, string definition, string right)
            {
                this.orig = orig;
                this.t1 = t1;
                this.t2 = t2;
                this.t3 = t3;
                this.t4 = t4;
                this.definition = definition;
                this.orig = orig;

            }
        }
        
        public List<words> GetWords()
        {
            List<words> wordslist = new List<words>();
            wordslist.Add(new words("apple", "банан", "колесо", "квадрат", "яблуко", "Something you may eat, green", "яблуко"));
            wordslist.Add(new words("banana", "банан", "мабуть", "тринадцять", "кіт", "Something you may eat, yellow", "банан"));
            wordslist.Add(new words("cat", "дошка", "школа", "ноутбук", "кіт", "Sweet little pet", "кіт"));
            wordslist.Add(new words("dog", "собака", "шлюз", "круг", "поляк", "Pet, likes to bark", "собака"));
            wordslist.Add(new words("existance", "університет", "цегла", "існування", "яблук", "If you live you....", "існування"));
            return wordslist;
        }
        int Counter { get; set; }
        int RightAnswersCounter { get; set; }
        int CurrentCardId { get; set; }

        int Correct;
        public int GetCurrentSuccess(){
            return this.RightAnswersCounter;
            }
        public void Guess() {
            this.RightAnswersCounter += 1;
        }
        public List<Word> GenerateCards()
        {
            var words = new List<Word>();
            using (var context = new AppContext())
            {
                
                
                List<Word> list = new List<Word>();

                
                return words;
            }
        }

    }
}

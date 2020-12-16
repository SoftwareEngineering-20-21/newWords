using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NewWords.Models
{
    public class GameContext
    {
        public List<Card> Vocab = new List<Card>();
        public int Counter { get; set; }
        public int RightAnswersCounter { get; set; }
        int CurrentCardId { get; set; }
        
        public GameContext()
        {
            Counter = 0;
            RightAnswersCounter = 0;
            Vocab.Add(new Card("apple", "банан", "колесо", "квадрат", "яблуко", "Something you may eat, green", "яблуко"));
            Vocab.Add(new Card("banana", "банан", "мабуть", "тринадцять", "кіт", "Something you may eat, yellow", "банан"));
            Vocab.Add(new Card("cat", "дошка", "школа", "ноутбук", "кіт", "Sweet little pet", "кіт"));
            Vocab.Add(new Card("dog", "собака", "шлюз", "круг", "поляк", "Pet, likes to bark", "собака"));
            Vocab.Add(new Card("existance", "університет", "цегла", "існування", "яблук", "If you live you....", "існування"));
        }

        public int GetCurrentSuccess(){
            return this.RightAnswersCounter;
            }
        public bool Guess(string guess)
        {
            bool result = Vocab[Counter].right == guess;
            if (result)
            {
                RightAnswersCounter++;
            }

            Counter++;
            return result;

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

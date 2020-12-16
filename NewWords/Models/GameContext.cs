using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NewWords.Models
{
    class GameContext
    {
        AppContext AppContext = new AppContext(); 
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
                for(int i = 0; i < 10; i++)
                {
                    words.Add(context.Words.ToList()[i]);
                }
                return words;
            }
        }

    }
}

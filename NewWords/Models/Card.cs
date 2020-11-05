using System;
using System.Collections.Generic;
using System.Text;

namespace NewWords.Models
{
    class Card
    {
        Word Origin { get; set; }
        List<Word> Translates { get; set; }
        int Correct;
    }
}

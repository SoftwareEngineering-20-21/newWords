using System;
using System.Collections.Generic;
using System.Text;

namespace NewWords.Models
{
    public class Card {
        public string orig { get; set; }
        public string t1 { get; set; }
        public string t2 { get; set; }
        public string t3 { get; set; }
        public string t4 { get; set; }
        public string definition { get; set; }
        public string right { get; set; }
        public Card(string orig, string t1, string t2, string t3, string t4, string definition, string right)
        {
            this.orig = orig;
            this.t1 = t1;
            this.t2 = t2;
            this.t3 = t3;
            this.t4 = t4;
            this.definition = definition;
            this.right = right;

        }
    }
}

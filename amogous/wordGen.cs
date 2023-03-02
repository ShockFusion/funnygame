using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace amogous
{
    public class wordGen
    {
        public string[] nouns = { "area", "book", "case", "dog", "cat", "day", "hand", "dude", "job", "story", "student", "room", "time", "word", "water", "amongus", "Jon", "Garfield", "Odie", "system" };
        public string[] verbs = { "needed", "did", "used", "had", "saw", "found", "gave", "told", "asked", "worked", "became" };
        public string[] nounsPl = { "areas", "books", "cases", "dogs", "cats", "days", "hands", "dudes", "jobs", "stories", "students", "rooms", "time", "words", "water", "amongus", "Jon", "Garfield", "Odie", "systems" };

        public string findSentence()
        {


            string Firstnoun = nouns[1];
            string verbb = verbs[1];
            string Secondnoun = nounsPl[1];

            string sentence = "The " + Firstnoun + " " + verbb + " " + Secondnoun;

          //  Random rand = new Random();
           // int enemyMoveNum = rand.Next(0, 4);

            return sentence;
        }
    }
}


// gen random num put in x

// currentNoun = nouns[x] 
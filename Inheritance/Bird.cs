using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{
    class Bird:Animal
    {
        public string FeatherColor { get; set; }
        public string Birdtype { get; set; } 
        public int WingLength { get; set; }
        public bool IsBirdofPrey { get; set; }

        public Bird(int age, int legs, bool isextinct, string noisemade, string feathercolor, string birdtype, int winglength, bool isbirdofprey)
        {
            Age = age;
            Legs = legs;
            IsExtinct = isextinct;
            NoiseMade = noisemade;
            FeatherColor = feathercolor;
            Birdtype = birdtype;
            WingLength = winglength;
            IsBirdofPrey = isbirdofprey;

            
        }
        public Bird()
        {
        }
        public void printDetail()
        {
            Console.WriteLine($"This bird  is {Age} years old, has {Legs} legs, is this bird still around {IsExtinct}, and it makes a {NoiseMade} sound.");
            Console.WriteLine($"This bird also has {FeatherColor} feathers, a wing length of {WingLength}, is a {Birdtype}, and is it considered a bird of prey {IsBirdofPrey}. ");
        }

    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{
    class Reptile : Animal
    {
        public string ScaleColor { get; set; }
        public int EggBatchSize { get; set; }
        public bool IsPoisonous { get; set; }
        public bool IsCarnivorius { get; set; }

        public Reptile(int age, int legs, bool isextinct, string noisemade, string scalecolor, int eggbatchsize,bool ispoisonous, bool iscarnivorius)
        {
            Age = age;
            Legs = legs;
            IsExtinct = isextinct;
            NoiseMade = noisemade;
            ScaleColor = scalecolor;
            EggBatchSize = eggbatchsize;
            IsPoisonous = ispoisonous;
            IsCarnivorius = iscarnivorius;
        }
        public Reptile()
        {

        }
        public void printDetail()
        {
            Console.WriteLine($"This reptile  is {Age} years old, has {Legs} legs, is this reptile still around {IsExtinct}, and it makes a {NoiseMade} sound.");
            Console.WriteLine($"This reptile also has {ScaleColor} scales, an egg batch size of {EggBatchSize}, is it poisonous {IsPoisonous}, and is it carnivorius {IsCarnivorius}. ");
        }


    }
}

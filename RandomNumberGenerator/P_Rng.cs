using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*  Random number generation using Linear Congruential Generator(LCG)
    Formula: (aX+c) mod m
    Example values [a,c,m]:
        1664525, 1013904223, 2^32
*/
namespace RandomNumberGenerator
{
    class P_Rng
    {
        public double Seed;
        public double Multiplier;
        public double Modulus;
        public double Increment;

        // Generates next number using existing seed
        public double NextNumber()
        {
            Seed = (Multiplier * Seed + Increment) % Modulus;
            return Seed;
        }

        // Generates next number using a new seed
        public double NextNumber(double seed)
        {
            Seed = (Multiplier * seed + Increment) % Modulus;
            return Seed;
        }

        //Constructor for base object
        public P_Rng(double seed, double mod, double inc, double mult)
        {
            Seed = seed;
            Modulus = mod;
            Multiplier = mult;
            Increment = inc;
        }
    }
}

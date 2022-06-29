using System;
using System.Collections.Generic;
using System.Text;

namespace prak16._1
{
    public class str
    {
        public string country { get; set; }
        public int people { get; set; }
    }
    public class Countries
    {
        string Countrie;
        int Population;

        public string countrie
        {
            get { return Countrie; }
            set { Countrie = value; }
        }
        public int population
        {
            get { return Population; }
            set { Population = value; }
        }
        public static bool examination(string countrie, string population, string n)
        {
            for (int i = 0; i < countrie.Length; i++)
            {
                if (char.IsDigit(countrie[i]))
                {
                    return false;
                }
            }
            for (int i = 0; i < population.Length; i++)
            {
                if (char.IsLetter(population[i]))
                {
                    return false;
                }
            }
            try
            {
                int.Parse(n);
                return true;
            }
            catch
            {

                return false;
            }
            return true;
        }
    }
}

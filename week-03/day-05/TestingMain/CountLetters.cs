using System;
using System.Collections.Generic;
using System.Linq;

namespace TestingMain
{
    public class CountLetters
    {
        
        public string myString;
        public CountLetters(string myString)
        {
            this.myString = myString;
        }

        public Dictionary<string, int> LettersCount()
        {
            char[] myStringSliced = myString.ToCharArray();             //slicing to char array

            string[] myStringSlicedStrings = new string[myString.Length];

            for (int i = 0; i < myStringSliced.Length; i++)             //converting into an array of strings
            {
                myStringSlicedStrings[i] = myStringSliced[i].ToString();
            }

            Dictionary<string, int> myDictionary = new Dictionary<string, int>();

            for (int i = 0; i < myStringSliced.Length; i++)
            {

                if (myDictionary.TryGetValue(myStringSlicedStrings[i], out int value))
                {
                    value++;
                    myDictionary.Remove(myStringSlicedStrings[i]);
                    myDictionary.Add(myStringSlicedStrings[i], value);
                    //myDictionary[myStringSlicedStrings[i]]++;            also possible to access values like this

                }
                else
                {
                    myDictionary.Add(myStringSlicedStrings[i], 1);
                }
            }


            return myDictionary;
        }
        public Dictionary<char, int> LettersCountEasy(string myString)
        {
            Dictionary<char, int> myDictionary = new Dictionary<char, int>();

            for (int i = 0; i < myString.Length; i++)
            {
                if (myDictionary.ContainsKey(myString[i]))
                {
                    myDictionary[myString[i]]++;
                }
                else
                {
                    myDictionary.Add(myString[i], 1);
                }
            }
            return myDictionary;
        }
    }
}

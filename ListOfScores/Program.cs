using System;
using System.Collections.Generic;

namespace ListOfScores
{
    class Program
    {
        static void Main(string[] args)
        {
            static void RunSimFields()
            {
                var accounts = new Dictionary<int, Account>();

                var acct1 = new Account
                {
                    AccountNumber = 1,
                    Description = "1st Account",
                    Balance = 1000
                };
                var acct2 = new Account
                {
                    AccountNumber = 2,
                    Description = "2nd Account",
                    Balance = 2000
                }; var acct3 = new Account
                {
                    AccountNumber = 3,
                    Description = "3rd Account",
                    Balance = 3000
                };
                //fuzzy what this is doing, adding to dictionary?
                accounts.Add(acct1.AccountNumber, acct1);
                accounts.Add(acct2.AccountNumber, acct2); 
                accounts.Add(acct3.AccountNumber, acct3);

                var selectedAccount = accounts[3];
            }
        static void RunListOfNumbers() {

            var scores = new List<int>();
            //generic list of type-int... calling constructors?
            scores.Add(42);
            scores.Add(98);
            scores.Add(66);
            scores.Add(5);
            scores.Add(100);
            // we want to add all the ints of the generic list

            var fixedScores = scores.ToArray();
            var genericFixedScore = new List<int>(fixedScores);

            var Total = 0;
            //make a variable first!
            //foreach for when we have a collection of things and we want to look at some of them
            //need 'var' and 'in' in foreach loop. make up var and put the collection after 'in'
            foreach (var item in scores)
            {
                Total += item;
                //have to put cw on outside because we want all of the items. 
                //Put cw on inside of loop if we want individual items to show.
            }
            Console.WriteLine($"Total is {Total}.");

        }
        }
    }
}

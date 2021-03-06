﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBasic
    {
    class CollectionsExample
        {
        public static void ArrayExample ()
            {
            int[] testInts = new int[] { 101, 102, 103, 104, 105 };
            for (int i = 0; i<testInts.Length; i++)
                Console.WriteLine ("The value of "+i+" is "+testInts[i]);

            string[] testNames = new string[] { "Login", "UserForm", "Selenium", "Hover" };
            foreach (var testName in testNames)
                {
                Console.WriteLine (testName);
                }
            }
        public static void NonGenericCollection ()
            {
            Hashtable table = new Hashtable ();
            table.Add ("UserName", "ea");
            table.Add ("Password", "ea123");
            table.Add ("Button", "Submit");

            foreach (var key in table.Keys)
                {
                Console.WriteLine ("The value for "+key+" is : "+table[key]);
                }
            }
        public static void GenericCollections ()
            {
            string[] user1 = new string[] { "Karthik", "30", "kk@kk.com", "23121" };
            string[] user2 = new string[] { "Sam", "21", "sam@sam.com", "5214" };
            string[] user3 = new string[] { "Jacob", "27", "jacob@jacob.com", "9524" };

            Dictionary<int, string[]> dict = new Dictionary<int, string[]> ();
            dict.Add (1, user1);
            dict.Add (2, user2);
            dict.Add (3, user3);

            foreach (var value in dict)
                {
                string[] userInfo = value.Value;
                foreach (var user in userInfo)
                    {
                    Console.WriteLine (user);
                    }
                }
            }

        public static void GenericCollectionsWithCustomClass ()
            {

            List<User> users = new List<User> ();

            users.Add (
                new User
                    {
                    UserId=1,
                    Name="Karthik",
                    Age=30,
                    Email="kk@kk.com",
                    Phone=23121,
                    Addresses=new List<Address> ()
                        {
                        new Address
                            {
                            Street="Demostreet_1",
                            Country="India",
                            FlatName="Panorama"
                            },
                        new Address ()
                            {
                            Street="Demostreet_1_1",
                            Country="Malaysia",
                            FlatName="Panorama_x"
                            }
                        }
                    }
                );
            //users.Add (new User { UserId=2, Name="Sam", Age=21, Email="sam@sam.com", Phone=5214, Addresses=new Address { Street="Demostreet_2", Country="USA", FlatName="Panorama" } });
            //users.Add (new User { UserId=3, Name="Jacob", Age=27, Email="jacob@jacob.com", Phone=9524, Addresses=new Address { Street="Demostreet_2", Country="Malaysia", FlatName="Panorama" } });

            //foreach (var user in users)
            //    {
            //    Console.WriteLine (
            //        String.Format ("The User {0} with Age {1} has Email {2} and Phone {3}",
            //            user.Name, user.Age, user.Email, user.Phone));
            //    }

            var userList = from user in users
                           from address in user.Addresses
                           where user.Age<=30
                           select new
                               {
                               FirstName = user.Name,
                               PhoneNumber = user.Phone,
                               Address = address
                               };

            var addresses = users.Where (x => x.Age==30).SelectMany (x => x.Addresses);

            foreach (var user in userList)
                {
                Console.WriteLine ("User {0} has Phone number {1} with country {2}", user.FirstName, user.PhoneNumber, user.Address.Country);
                }

            //List<User> users = new List<User> ()
            //    {
            //    new User
            //        {
            //        UserId=1, Name="Karthik", Age=30, Email="kk@kk.com", Phone=23121
            //        },
            //    new User
            //        {
            //        UserId=2, Name="Sam", Age=21, Email="sam@sam.com", Phone=5214
            //        },
            //    new User
            //        {
            //        UserId=3, Name="Jacob", Age=27, Email="jacob@jacob.com", Phone=9524
            //        }
            //    };
            }

        }
    public class User
        {
        public int UserId { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public string Email { get; set; }
        public Int64 Phone { get; set; }
        public List<Address> Addresses { get; set; }
        }

    public class Address
        {
        public string FlatName { get; set; }
        public string Street { get; set; }
        public string Country { get; set; }
        }
    }


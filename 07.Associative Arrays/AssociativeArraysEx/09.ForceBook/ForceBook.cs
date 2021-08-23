using System;
using System.Collections.Generic;
using System.Linq;

namespace _09.ForceBook
{
    class ForceBook
    {
        static void Main(string[] args)
        {
            //Test 8 Runtime error
          
            string command = Console.ReadLine();
          
            Dictionary<string, List<string>> sides = new Dictionary<string, List<string>>();

            while (command != "Lumpawaroo")
            {
                string separator = string.Empty;
                string forceSide = string.Empty;
                string forceUser = string.Empty;
                string[] commandArgs = null;
                
                if (command.Contains(" | "))
                {
                    separator = " | ";
                    commandArgs = command
                        .Split(separator, StringSplitOptions.RemoveEmptyEntries);

                    forceSide = commandArgs[0];
                    forceUser = commandArgs[1];

                    string existingUser = FindUser(sides, forceUser);

                    if (existingUser == null)
                    {
                        AddUserToSide(sides, forceSide, forceUser);
                    }
                }
                else if (command.Contains(" -> "))
                {
                    separator = " -> ";
                    commandArgs = command
                        .Split(separator, StringSplitOptions.RemoveEmptyEntries);

                    forceSide = commandArgs[1];
                    forceUser = commandArgs[0];

                    string existingUser = FindUser(sides, forceUser);

                    if (existingUser == null)
                    {
                        AddUserToSide(sides, forceSide, forceUser);
                        Console.WriteLine($"{forceUser} joins the {forceSide} side!");
                    }
                    else
                    {
                        string userSide = UserSide(existingUser, sides);
                        
                        if (sides.ContainsKey(forceSide))
                        {
                            ChangeUserSide(sides, existingUser, userSide, forceSide);
                        }
                        else
                        {
                            sides.Add(forceSide, new List<string>());
                            ChangeUserSide(sides, existingUser, userSide, forceSide);
                        }
                    }
                }

                command = Console.ReadLine();
            }

            List<KeyValuePair<string, List<string>>> orderedSides = sides.
               OrderByDescending(s => s.Value.Count).
               ThenBy(n => n.Key).
               ToList();

            foreach (KeyValuePair<string, List<string>> side in orderedSides)
            {
                if (side.Value.Count > 0)
                {
                    Console.WriteLine($"Side: {side.Key}, Members: {side.Value.Count}");
                    foreach (string user in side.Value.OrderBy(n => n))
                    {
                        Console.WriteLine($"! {user}");
                    }
                }
            }
        }

        static void ChangeUserSide(Dictionary<string, List<string>> sides, string existingUser, string userside, string forceSide)
        {
            if (userside != forceSide)
            {
                sides[userside].Remove(existingUser);
                sides[forceSide].Add(existingUser);
                Console.WriteLine($"{existingUser} joins the {forceSide} side!");
            }
        }

        static string UserSide(string existingUser, Dictionary<string, List<string>> sides)
        {
            foreach (var side in sides)
            {
                if (side.Value.Contains(existingUser))
                {
                    return side.Key;
                }
            }

            return null;
        }

        static void AddUserToSide(Dictionary<string, List<string>> sides, string side, string user)
        {
            if (!sides.ContainsKey(side))
            {
                sides.Add(side, new List<string>());
                sides[side].Add(user);
            }
            else
            {
                sides[side].Add(user);
            }
        }

        static string FindUser(Dictionary<string, List<string>> sides, string user)
        {
            foreach (List<string> side in sides.Values)
            {
                if (side.Contains(user))
                {
                    return user;
                }
            }

            return null;
        }
    }
}

using System;
using System.Collections.Generic;

namespace Adv3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Exercise 1

            //List<int> grades = new List<int> { 85, 92, 78, 95, 88, 70, 100, 65 };

            //Console.WriteLine("Exercise 1: Student Grade Manager");

            //Console.WriteLine("Grades:");
            //foreach (int grade in grades)
            //{
            //    Console.Write(grade + " ");
            //}

            //Console.WriteLine();
            //Console.WriteLine("Count: " + grades.Count);
            //Console.WriteLine("First Grade: " + grades[0]);
            //Console.WriteLine("Last Grade: " + grades[grades.Count - 1]);

            //grades.Sort();

            //Console.WriteLine("Sorted Grades:");
            //foreach (int grade in grades)
            //{
            //    Console.Write(grade + " ");
            //}

            //Console.WriteLine();

            //int firstAbove90 = 0;

            //foreach (int grade in grades)
            //{
            //    if (grade > 90)
            //    {
            //        firstAbove90 = grade;
            //        break;
            //    }
            //}

            //Console.WriteLine("First Grade Above 90: " + firstAbove90);

            //List<int> failingGrades = new List<int>();

            //foreach (int grade in grades)
            //{
            //    if (grade < 75)
            //    {
            //        failingGrades.Add(grade);
            //    }
            //}

            //Console.WriteLine("Failing Grades:");

            //foreach (int grade in failingGrades)
            //{
            //    Console.Write(grade + " ");
            //}

            //Console.WriteLine();

            //grades.RemoveAll(grade => grade < 75);

            //Console.WriteLine("Grades After Removing Failing Grades:");

            //foreach (int grade in grades)
            //{
            //    Console.Write(grade + " ");
            //}

            //Console.WriteLine();

            //bool has100 = false;

            //foreach (int grade in grades)
            //{
            //    if (grade == 100)
            //    {
            //        has100 = true;
            //        break;
            //    }
            //}

            //Console.WriteLine("Any Grade Equals 100: " + has100);

            //List<string> gradeStrings = new List<string>();

            //foreach (int grade in grades)
            //{
            //    gradeStrings.Add("Grade: " + grade);
            //}

            //Console.WriteLine("Grade Strings:");

            //foreach (string grade in gradeStrings)
            //{
            //    Console.WriteLine(grade);
            //}

            //Console.WriteLine();

            #endregion

            #region Exercise 2

            //SortedDictionary<int, string> leaderboard = new SortedDictionary<int, string>();

            //leaderboard.Add(500, "Ahmed");
            //leaderboard.Add(200, "Sara");
            //leaderboard.Add(800, "Ali");
            //leaderboard.Add(350, "Mona");

            //Console.WriteLine("Exercise 2: Leaderboard");

            //foreach (KeyValuePair<int, string> player in leaderboard)
            //{
            //    Console.WriteLine(player.Key + " = " + player.Value);
            //}

            //int firstKey = 0;
            //string firstValue = "";

            //foreach (KeyValuePair<int, string> player in leaderboard)
            //{
            //    firstKey = player.Key;
            //    firstValue = player.Value;
            //    break;
            //}

            //Console.WriteLine("First Key: " + firstKey);
            //Console.WriteLine("First Value: " + firstValue);

            //Console.WriteLine("Score 500 Exists: " + leaderboard.ContainsKey(500));

            //string player999;

            //if (leaderboard.TryGetValue(999, out player999))
            //{
            //    Console.WriteLine("Player with Score 999: " + player999);
            //}
            //else
            //{
            //    Console.WriteLine("Player with Score 999: Not Found");
            //}

            //leaderboard.Remove(200);

            //Console.WriteLine("Updated Leaderboard:");

            //foreach (KeyValuePair<int, string> player in leaderboard)
            //{
            //    Console.WriteLine(player.Key + " = " + player.Value);
            //}

            //Console.WriteLine();

            #endregion

            #region Exercise 3

            //Dictionary<string, string> phoneBook = new Dictionary<string, string>();

            //phoneBook.Add("Ahmed", "01011111111");
            //phoneBook.Add("Sara", "01122222222");
            //phoneBook.Add("Ali", "01233333333");
            //phoneBook.Add("Mona", "01544444444");

            //Console.WriteLine("Exercise 3: Phone Book");

            //phoneBook["Hassan"] = "01055555555";

            //Console.WriteLine("Contacts:");

            //foreach (KeyValuePair<string, string> contact in phoneBook)
            //{
            //    Console.WriteLine(contact.Key + " = " + contact.Value);
            //}

            //try
            //{
            //    phoneBook.Add("Ahmed", "01099999999");
            //}
            //catch (ArgumentException ex)
            //{
            //    Console.WriteLine("Add Exception: " + ex.Message);
            //}

            //bool tryAddResult = phoneBook.TryAdd("Ahmed", "01088888888");

            //Console.WriteLine("TryAdd Result: " + tryAddResult);

            //bool contactExists = phoneBook.ContainsKey("Omar");

            //Console.WriteLine("Omar Exists: " + contactExists);

            //string phoneNumber;

            //if (phoneBook.TryGetValue("Omar", out phoneNumber))
            //{
            //    Console.WriteLine("Omar Phone: " + phoneNumber);
            //}
            //else
            //{
            //    Console.WriteLine("Omar Phone: Not Found");
            //}

            //Console.WriteLine("Keys:");

            //foreach (string key in phoneBook.Keys)
            //{
            //    Console.Write(key + " ");
            //}

            //Console.WriteLine();

            //Console.WriteLine("Values:");

            //foreach (string value in phoneBook.Values)
            //{
            //    Console.Write(value + " ");
            //}

            //Console.WriteLine();
            //Console.WriteLine();

            #endregion

            #region Exercise 4

            //HashSet<string> emails = new HashSet<string>(StringComparer.OrdinalIgnoreCase);

            //emails.Add("ahmed@test.com");
            //emails.Add("AHMED@test.com");
            //emails.Add("sara@test.com");
            //emails.Add("Sara@Test.Com");

            //Console.WriteLine("Exercise 4: Unique Email Validator");

            //Console.WriteLine("Emails:");

            //foreach (string email in emails)
            //{
            //    Console.WriteLine(email);
            //}

            //Console.WriteLine("Count: " + emails.Count);

            //HashSet<int> setA = new HashSet<int> { 1, 2, 3, 4, 5 };
            //HashSet<int> setB = new HashSet<int> { 4, 5, 6, 7, 8 };

            //HashSet<int> unionSet = new HashSet<int>(setA);
            //unionSet.UnionWith(setB);

            //Console.WriteLine("UnionWith Result:");

            //foreach (int number in unionSet)
            //{
            //    Console.Write(number + " ");
            //}

            //Console.WriteLine();

            //HashSet<int> intersectSet = new HashSet<int>(setA);
            //intersectSet.IntersectWith(setB);

            //Console.WriteLine("IntersectWith Result:");

            //foreach (int number in intersectSet)
            //{
            //    Console.Write(number + " ");
            //}

            //Console.WriteLine();

            //HashSet<int> exceptSet = new HashSet<int>(setA);
            //exceptSet.ExceptWith(setB);

            //Console.WriteLine("ExceptWith Result:");

            //foreach (int number in exceptSet)
            //{
            //    Console.Write(number + " ");
            //}

            //Console.WriteLine();

            //HashSet<int> subset = new HashSet<int> { 1, 2 };

            //bool isSubset = subset.IsSubsetOf(setA);

            //Console.WriteLine("{1, 2} Is Subset Of Set A: " + isSubset);

            //Console.WriteLine();

            #endregion

            #region Exercise 5

            //Queue<string> printQueue = new Queue<string>();

            //printQueue.Enqueue("Report.pdf");
            //printQueue.Enqueue("Invoice.pdf");
            //printQueue.Enqueue("Letter.docx");
            //printQueue.Enqueue("Resume.pdf");
            //printQueue.Enqueue("Photo.jpg");

            //Console.WriteLine("Exercise 5: Print Queue Simulator");

            //Console.WriteLine("Queue Contents:");

            //foreach (string document in printQueue)
            //{
            //    Console.Write(document + " ");
            //}

            //Console.WriteLine();
            //Console.WriteLine("Count: " + printQueue.Count);

            //Console.WriteLine("Next Document: " + printQueue.Peek());

            //while (printQueue.Count > 0)
            //{
            //    string document = printQueue.Dequeue();
            //    Console.WriteLine("Printing: " + document);
            //}

            //string remainingDocument;

            //bool tryDequeueResult = printQueue.TryDequeue(out remainingDocument);

            //Console.WriteLine("TryDequeue Result: " + tryDequeueResult);

            //if (tryDequeueResult)
            //{
            //    Console.WriteLine("Document: " + remainingDocument);
            //}
            //else
            //{
            //    Console.WriteLine("Queue is empty.");
            //}

            //Console.WriteLine();

            #endregion

            #region Exercise 6

            //Stack<string> browserHistory = new Stack<string>();

            //browserHistory.Push("google.com");
            //browserHistory.Push("github.com");
            //browserHistory.Push("stackoverflow.com");
            //browserHistory.Push("youtube.com");
            //browserHistory.Push("claude.ai");

            //Console.WriteLine("Exercise 6: Browser History");

            //Console.WriteLine("Current Page: " + browserHistory.Peek());

            //Console.WriteLine("Going Back:");

            //for (int i = 0; i < 3; i++)
            //{
            //    string page = browserHistory.Pop();
            //    Console.WriteLine("Leaving: " + page);
            //}

            //Console.WriteLine("Current Page After Going Back: " + browserHistory.Peek());

            //string poppedPage;

            //bool tryPopResult = browserHistory.TryPop(out poppedPage);

            //Console.WriteLine("TryPop Result: " + tryPopResult);

            //if (tryPopResult)
            //{
            //    Console.WriteLine("Popped Page: " + poppedPage);
            //}
            //else
            //{
            //    Console.WriteLine("Stack is empty.");
            //}

            //Console.WriteLine();

            #endregion
        }
    }
}
```

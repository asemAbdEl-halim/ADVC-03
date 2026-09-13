namespace ADVC_03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Exercise01

            //    // 1. Create collection
            //    List<int> grades = new List<int>
            //{
            //    85, 92, 78, 95, 88, 70, 100, 65
            //};

            //    // 2. Print collection, Count, first and last grade
            //    Console.WriteLine("Grades:");

            //    foreach (int grade in grades)
            //    {
            //        Console.WriteLine(grade);
            //    }

            //    Console.WriteLine("Count: " + grades.Count);
            //    Console.WriteLine("First Grade: " + grades[0]);
            //    Console.WriteLine("Last Grade: " + grades[grades.Count - 1]);


            //    // 3. Sort ascending
            //    grades.Sort();

            //    Console.WriteLine("\nSorted Grades:");

            //    foreach (int grade in grades)
            //    {
            //        Console.WriteLine(grade);
            //    }


            //    // 4. Get first grade above 90
            //    int firstAbove90 = grades.First(grade => grade > 90);

            //    Console.WriteLine("\nFirst grade above 90: " + firstAbove90);


            //    // 5. Get all grades below 75
            //    List<int> failingGrades = grades
            //        .Where(grade => grade < 75)
            //        .ToList();

            //    Console.WriteLine("\nFailing Grades:");

            //    foreach (int grade in failingGrades)
            //    {
            //        Console.WriteLine(grade);
            //    }


            //    // 6. Remove all failing grades
            //    grades.RemoveAll(grade => grade < 75);

            //    Console.WriteLine("\nGrades after removing failing grades:");

            //    foreach (int grade in grades)
            //    {
            //        Console.WriteLine(grade);
            //    }


            //    // 7. Check if any grade equals 100
            //    bool has100 = grades.Contains(100);

            //    Console.WriteLine("\nAny grade equals 100: " + has100);


            //    // 8. Create List<string>
            //    List<string> gradeMessages = new List<string>();

            //    foreach (int grade in grades)
            //    {
            //        gradeMessages.Add("Grade: " + grade);
            //    }

            //    Console.WriteLine("\nGrade Messages:");

            //    foreach (string message in gradeMessages)
            //    {
            //        Console.WriteLine(message);
            //    }

            #endregion

            #region Exercise02

            //// 1. Create leaderboard
            //SortedDictionary<int, string> leaderboard = new SortedDictionary<int, string>();

            //leaderboard.Add(500, "Ahmed");
            //leaderboard.Add(200, "Sara");
            //leaderboard.Add(800, "Ali");
            //leaderboard.Add(350, "Mona");


            //// 2. Print all entries
            //Console.WriteLine("--- Leaderboard ---");

            //foreach (var player in leaderboard)
            //{
            //    Console.WriteLine(player.Key + " = " + player.Value);
            //}


            //// 3. Access first key and first value
            //int firstKey = 0;
            //string firstValue = "";

            //foreach (var player in leaderboard)
            //{
            //    firstKey = player.Key;
            //    firstValue = player.Value;
            //    break;
            //}

            //Console.WriteLine("\nFirst Key: " + firstKey);
            //Console.WriteLine("First Value: " + firstValue);


            //// 4. Check if score 500 exists
            //bool exists = leaderboard.ContainsKey(500);

            //Console.WriteLine("\nScore 500 exists: " + exists);


            //// 5. Safely get player with score 999
            //if (leaderboard.TryGetValue(999, out string playerName))
            //{
            //    Console.WriteLine("Player with score 999: " + playerName);
            //}
            //else
            //{
            //    Console.WriteLine("No player with score 999");
            //}


            //// 6. Remove score 200
            //leaderboard.Remove(200);

            //Console.WriteLine("\n--- Updated Leaderboard ---");

            //foreach (var player in leaderboard)
            //{
            //    Console.WriteLine(player.Key + " = " + player.Value);
            //}

            #endregion

            #region Exercise03

            //// 1. Create a phone book with 4 contacts
            //Dictionary<string, string> phoneBook = new Dictionary<string, string>();

            //phoneBook.Add("Ahmed", "01011111111");
            //phoneBook.Add("Sara", "01022222222");
            //phoneBook.Add("Ali", "01033333333");
            //phoneBook.Add("Mona", "01044444444");


            //// 2. Add a new contact using [] syntax
            //phoneBook["Omar"] = "01055555555";


            //// 3. Try adding a duplicate using Add()
            //try
            //{
            //    phoneBook.Add("Ahmed", "01199999999");
            //}
            //catch (ArgumentException ex)
            //{
            //    Console.WriteLine("Add Error: " + ex.Message);
            //}


            //// 4. Try adding a duplicate using TryAdd()
            //bool added = phoneBook.TryAdd("Ahmed", "01188888888");

            //Console.WriteLine("TryAdd succeeded: " + added);


            //// 5. Search for a contact that doesn't exist
            //bool exists = phoneBook.ContainsKey("Khaled");

            //Console.WriteLine("Khaled exists: " + exists);


            //// 6. Get a contact with a fallback
            //string phoneNumber;

            //if (phoneBook.TryGetValue("Khaled", out phoneNumber))
            //{
            //    Console.WriteLine("Khaled: " + phoneNumber);
            //}
            //else
            //{
            //    Console.WriteLine("Khaled: Not Found");
            //}


            //// 7. Print all Keys
            //Console.WriteLine("\nKeys:");

            //foreach (string name in phoneBook.Keys)
            //{
            //    Console.Write(name + " ");
            //}

            //// Print all Values
            //Console.WriteLine("\n\nValues:");

            //foreach (string phone in phoneBook.Values)
            //{
            //    Console.Write(phone + " ");
            //}

            #endregion

            #region Exercise04

        //    // 1. Create HashSet with case-insensitive comparer
        //    HashSet<string> emails =
        //        new HashSet<string>(StringComparer.OrdinalIgnoreCase);

        //    // 2. Add emails
        //    emails.Add("ahmed@test.com");
        //    emails.Add("AHMED@test.com");
        //    emails.Add("sara@test.com");
        //    emails.Add("Sara@Test.Com");


        //    // 3. Print Count
        //    Console.WriteLine("Email Count: " + emails.Count);


        //    // 4. Create Set A and Set B
        //    HashSet<int> setA = new HashSet<int>
        //{
        //    1, 2, 3, 4, 5
        //};

        //    HashSet<int> setB = new HashSet<int>
        //{
        //    4, 5, 6, 7, 8
        //};


        //    // UnionWith
        //    HashSet<int> union = new HashSet<int>(setA);
        //    union.UnionWith(setB);

        //    Console.WriteLine("\nUnion:");
        //    foreach (int number in union)
        //    {
        //        Console.Write(number + " ");
        //    }


        //    // IntersectWith
        //    HashSet<int> intersect = new HashSet<int>(setA);
        //    intersect.IntersectWith(setB);

        //    Console.WriteLine("\n\nIntersection:");
        //    foreach (int number in intersect)
        //    {
        //        Console.Write(number + " ");
        //    }


        //    // ExceptWith
        //    HashSet<int> except = new HashSet<int>(setA);
        //    except.ExceptWith(setB);

        //    Console.WriteLine("\n\nExcept:");
        //    foreach (int number in except)
        //    {
        //        Console.Write(number + " ");
        //    }


        //    // 6. IsSubsetOf
        //    HashSet<int> smallSet = new HashSet<int>
        //{
        //    1, 2
        //};

        //    bool isSubset = smallSet.IsSubsetOf(setA);

        //    Console.WriteLine("\n\nIs {1, 2} a subset of Set A? " + isSubset);

            #endregion
        }
    }
}

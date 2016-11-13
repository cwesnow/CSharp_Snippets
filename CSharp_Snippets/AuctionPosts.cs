using System;
using System.Collections.Generic;

namespace CSharp_Snippets
{
    class AuctionPosts
    {
        static List<Post> allListings = new List<Post>();
        static string userID = null;

        /// <summary>
        /// Similar to a static void main() Method for this class.
        /// </summary>
        public static void play()
        {
            // Populate some random data
            setupListings();

            while (userID == null || userID == "") login();

            do
            {
                Console.WriteLine("User #{0} \n [D] Display Posts \n [N] New Post \n [E] Edit Posts \n [X] Exit",
                    userID);
                string input = Console.ReadLine().ToUpper();

                if (input == "D") displayPosts();
                if (input == "N") newPost();
                if (input == "E") editPost();
                if (input == "X") userID = null;
            }
            while (userID != null);

            Console.ReadLine();
        }

        /// <summary>
        /// Loads up Test Data to verify operation
        /// </summary>
        private static void setupListings()
        {
            for (int x = 0; x < 10; x++)
            {
                Post myPost = new Post();
                myPost.userID = "1";
                myPost.title = "Title " + x.ToString();
                if (x % 2 == 0) myPost.category = "F";
                else if (x % 3 == 0) myPost.category = "R";
                else myPost.category = "S";

                if (x % 2 == 0) myPost.price = x / 100;
                else if (x % 3 == 0) myPost.price = x + (5000 / 3.14);
                else myPost.price = x * 100; ;


                allListings.Add(myPost);
            }

        }

        /// <summary>
        /// User inputs their ID, No security methods
        /// </summary>
        private static void login()
        {
            Console.WriteLine("Login ID");
            userID = Console.ReadLine();
        }

        /// <summary>
        /// Creates a new Post with user edits and adds it to the List: allListings"
        /// </summary>
        private static void newPost()
        {
            Post post = new Post();
            post.userID = userID;
            post.title = editTitle();
            post.category = editCategory();
            post.description = editDescription();
            post.price = editPrice();

            allListings.Add(post);
        }

        /// <summary>
        /// Loops through all Postings, reviews matched userID and Title.
        /// Multiple Posts can be found with same userID and TItle.
        /// </summary>
        private static void editPost()
        {
            string title = editTitle();
            string input = "";

            foreach (var post in allListings)
            {
                if (post.userID == userID && post.title.ToUpper() == title.ToUpper())
                {
                    input = "";
                    while (input != "X")
                    {
                        Console.WriteLine(
                        "Edit Post: \n[T]itle: {0} \n[C]ategory: {1} \n[D]escription: {2}\n[P]rice: {3:C}\n",
                        post.title, post.category, post.description, post.price);

                        Console.WriteLine("Options: T, C, D, P, or X to stop editing this post");
                        input = Console.ReadLine().ToUpper();

                        if (input == "T")
                        {
                            post.title = editTitle();
                        }

                        if (input == "C")
                        {
                            post.category = editCategory();
                        }

                        if (input == "D")
                        {
                            post.description = editDescription();
                        }
                        if (input == "P")
                        {
                            post.price = editPrice();
                        }
                    }
                }
            }
        }

        /// <summary>
        /// Displays all Posts that userID has made
        /// </summary>
        private static void displayPosts()
        {
            int x = 0;
            Console.WriteLine("Displaying all Posts for user# {0}\n", userID);
            foreach (var post in allListings)
            {
                if (post.userID == userID)
                {
                    x++;
                    Console.WriteLine(
                        "Post #{0} \n\t {1} \n\t {2} \n\t {3} \n\t {4:C}", x, post.title, post.category, post.description, post.price);
                }
            }
            Console.WriteLine();
        }

        /// <summary>
        /// Prompts user for Title name and validates input before returning it
        /// </summary>
        /// <returns>String between 3 and 25 characters long</returns>
        private static string editTitle()
        {
            string result;
            do
            {
                Console.WriteLine("Enter Post Title");
                result = Console.ReadLine();
                if (result.Length > 25)
                    Console.WriteLine("Titles have a 25 character limit");
                else if (result.Length < 3)
                    Console.WriteLine("Titles must have 3 or more characters");

            } while (result.Length < 3 || result.Length > 25);
            return result;
        }

        /// <summary>
        /// Prompts user for Category input, validates before returning it
        /// </summary>
        /// <returns>String equal to S, R, or F</returns>
        private static string editCategory()
        {
            string result;
            do
            {
                Console.WriteLine("Enter Post Category \n S for Sell \n R for Rent \n F for Free");
                result = Console.ReadLine().ToUpper();
            } while (!(result == "S" || result == "R" || result == "F"));
            return result;
        }

        /// <summary>
        /// Prompts user for a Description, validates before returning it
        /// </summary>
        /// <returns>String with Length at or below 160 characters</returns>
        private static string editDescription()
        {
            string result;
            do
            {
                Console.WriteLine("Enter Post Description");
                result = Console.ReadLine();
                if (result.Length > 160)
                    Console.WriteLine("Descriptions have a 160 character limit");
            } while (result.Length > 160);
            return result;
        }

        /// <summary>
        /// Prompts user for a Price, validates before returning it
        /// </summary>
        /// <returns>double between double.minValue and double.maxValue</returns>
        private static double editPrice()
        {
            bool validInput = false;
            double result = 0;
            do
            {
                Console.WriteLine("Enter Post Price");
                validInput = double.TryParse(Console.ReadLine(), out result);
            } while (!validInput);
            return result;
        }
    }
}

/// <summary>
/// Represents a Post containing: userID, title, category, description, and price
/// </summary>
class Post
{
    public string userID { get; set; }
    public string title { get; set; }
    public string category { get; set; }
    public string description { get; set; }
    public double price { get; set; }
}
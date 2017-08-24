using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackOverflow_Post
{
    class Program
    {
        static void Main(string[] args)
        {
            var post = new Post()
            {
                Title = "This is the Post Title",
                Description = "And this is the description text"
            };

            Console.WriteLine("Title: {0}\nDescription: {1}\nDate created: {2}\nTotal votes: {3}", post.Title, post.Description, post.DateCreated, post.Votes);

            // Down-vote
            post.DownVote();
            Console.WriteLine("Down-vote\nTotal Votes: {0}", post.Votes);

            // Three Up-votes
            post.UpVote();
            post.UpVote();
            post.UpVote();
            Console.WriteLine("Three Up-votes\nTotal Votes: {0}", post.Votes);

            // Down-vote
            post.DownVote();
            Console.WriteLine("Down-vote\nTotal Votes: {0}", post.Votes);

            // Try to modify the Created date
            Console.WriteLine("Date created: {0}", post.DateCreated);
            System.Threading.Thread.Sleep(2000); // wait a few seconds
            //post.DateCreated = DateTime.Now;
            Console.WriteLine("Date created: {0}", post.DateCreated);

        }
    }
}

using System;

namespace StackOverflow_Post
{
    public class Post
    {
        public enum State { posted }

        private DateTime _dateCreated;
        private int _votes;

        // Getters and Setters
        public string Title { get; set; }
        public string Description { get; set; }

        public DateTime DateCreated
        {
            get { return _dateCreated; }
            private set { _dateCreated = DateTime.Now; }
        }

        public int Votes
        {
            get { return _votes; }
        }

        // Default Constructor (parameterless)
        public Post()
        {
            _votes = 0;
            DateCreated = DateCreated; 
        }


        // Public Methods
        public void UpVote()
        {
            _votes++;
        }

        public void DownVote()
        {
            if (_votes > 0)
                _votes--;
        }


    }
}

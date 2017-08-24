using System;

namespace StackOverflow_Post
{
    public class Post
    {
        // Valid state options
        public enum State { posted }

        // Declarations
        private DateTime _dateCreated;
        private int _votes;
        private State _state;

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
            _state = State.posted;
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

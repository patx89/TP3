using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Server
{
    class Message
    {
        private int _id;
        private String _content;
        private User _sender;
        private int _likes;
        private int _dislike;
        private bool _isDeleted;

        public Message(User aUser, String aContent)
        {
            //TODO: incremented id
            _sender = aUser;
            _content = aContent;
            _likes = 0;
            _dislike = 0;
            _isDeleted = false;
        }

        //TODO method
    }
}

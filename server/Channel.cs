using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Server
{
    class Channel
    {
        private int _id;
        private String _name;
        private String _description;
        private List<User> _connectedUser;
        private Dictionary<User, List<Message>> _message;

        public Channel(String aName, String aDescription)
        {
            //TODO incremented Id
            _name = aName;
            _description = aDescription;
        }

        //TODO method
    }
}

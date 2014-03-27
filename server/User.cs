using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
//using System.Drawing;

namespace Server
{
    class User
    {
        private int _id;
        private String _username;
        private String _surName;
        private String _firstName;
        //private Bitmap _avatar; not find
        private bool _isOnline;
        private int _totalLike;
        private int _totalDislike;
        private int _currentChannelId;

        public User(String aUsername, String aSurname , String aFirstName, int aAvatar, int aTotalLike, int aTotalDislike)
        {
            //TODO increment ID;
            _username = aUsername;
            _surName = aSurname;
            _firstName = aFirstName;
            _totalLike = aTotalLike;
            _totalDislike = aTotalDislike;
            _currentChannelId = -1;
            _isOnline = false;
        }

        //TODO method

    }
}

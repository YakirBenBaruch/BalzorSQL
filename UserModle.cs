namespace BalzorSQL
{
    public class UserModle
    {
        private int userId;
        private string username;
        private string userpassword;
        private string useremail;
        private string usernickname;

        public UserModle(int userId, string username, string userpassword, string useremail, string usernickname)
        {
            this.userId = userId;
            this.username = username;
            this.userpassword = userpassword;
            this.useremail = useremail;
            this.usernickname = usernickname;
        }

        public void SetUserId(int userId)
        {
            this.userId = userId;
        }
        public int GetUserId()
        {
            return this.userId;
        }

        public void SetUsername(string username)
        {
            this.username = username;
        }
        public string GetUsername()
        {
            return this.username;
        }

        public void SetUserPassword(string userpassword)
        {
            this.userpassword = userpassword;
        }
        public string GetUserPassword()
        {
            return this.userpassword;
        }

        public void SetUserEmail(string useremail)
        {
            this.useremail = useremail;
        }
        public string GetUserEmail()
        {
            return this.useremail;
        }

        public void SetUserNickname(string usernickname)
        {
            this.usernickname = usernickname;
        }
        public string GetUserNickname()
        {
            return this.usernickname;
        }
    }
}

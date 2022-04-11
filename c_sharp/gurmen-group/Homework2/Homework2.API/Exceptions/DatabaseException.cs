using System;

namespace Homework2.API.Exceptions
{
    public class DatabaseException : Exception
    {
        public DatabaseException(): base()
        {

        }

        public DatabaseException(string Message) : base(Message)
        {

        }

        public DatabaseException(String Message, Exception InnerException) : base(Message, InnerException)
        {

        }

    }
}

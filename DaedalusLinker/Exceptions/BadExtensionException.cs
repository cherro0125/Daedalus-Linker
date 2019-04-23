using System;

namespace DaedalusLinker.Exceptions
{
    public class BadExtensionException : Exception
    {
        public BadExtensionException() : base("Not supported source extension")
        {

        }
    }
}
using System;

namespace Cartel
{
    class Cartel
    {
        public int age { get; set; }
        public string role { get; set; }
        public string realname { get; set; }

        public Cartel(int aage, string arole, string arealname)
        {
            this.age = aage;
            this.role = arole;
            this.realname = arealname;

        }

        public virtual void drugAddiction()
        {
            Console.WriteLine();
        }

        public virtual void drugKnownledge()
        {
            Console.WriteLine();
        }

        public virtual void cartelName()
        {
            Console.WriteLine();
        }

        public virtual void realName()
        {
            Console.WriteLine($"The {role}s real name is {realname}. ");
        }

        public virtual void Age()
        {
            Console.WriteLine($"The {role} is {age} years old.");
        }
    }
}

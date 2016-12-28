using System;

namespace CSharpOOP_DefiningClasses_Part2
{
    class Startup
    {
        static void Main()
        {
            // test the Version Attribute at startup
            var currentVersion = typeof(Startup).GetCustomAttributes(false);

            foreach (var item in currentVersion)
            {
                var version = (VersionAttribute)item;
                Console.WriteLine(version.Version);
            }
        }
    }
}
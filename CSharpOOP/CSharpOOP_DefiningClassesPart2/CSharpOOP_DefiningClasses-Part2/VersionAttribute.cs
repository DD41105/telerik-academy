using System;

namespace CSharpOOP_DefiningClasses_Part2
{
    [AttributeUsage(AttributeTargets.All, AllowMultiple =true)]
    public sealed class VersionAttribute : Attribute
    {
        public VersionAttribute(string version)
        {
            this.Version = version;
        }

        public string Version { get; set; }
    }
}
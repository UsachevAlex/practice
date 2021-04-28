using System.Collections.Generic;

namespace ConsoleApp3
{
    internal interface IPrefix
    {

        int Count { get; }

        int this[string key] { set; get; }

        bool ContainsKey(string key);

        void Add(string key, int value);

        List<string> SamePrefixWords(string prefix);
    }
}
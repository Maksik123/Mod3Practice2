using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Mod3Practice2.Models;
using System.Collections;

namespace Mod3Practice2.Services
{
    public class TestingLinqService
    {
        public void TestLINQ()
        {
            ContactList contactList = new();
            var contacts = contactList.contacts;
            foreach (var i in contacts)
            {
                Console.WriteLine($"{i.Age}, {i.Name}" );
            }
            Console.WriteLine("----------------");
            var LinqWhereandStarsWith = contacts.Where(x => x.Age >= 100).Where(x => x.Name.StartsWith ("a"));
            foreach (var i in LinqWhereandStarsWith)
            {
                Console.WriteLine($"{i.Age}, {i.Name}");
            }
            Console.WriteLine("----------------");
            var LinqSelect = contacts.Select(x => x.Age * 2);
            foreach (var i in LinqSelect)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("----------------");
            var LinqOrderby = contacts.OrderBy(x => x.Age).ThenBy(x => x.Name);
            foreach (var i in LinqOrderby)
            {
                Console.WriteLine($"{i.Age}, {i.Name}");
            }
            Console.WriteLine("----------------");
            var LinqAny = contacts.Any(x => x.Name.StartsWith("f"));
            Console.WriteLine(LinqAny);
            Console.WriteLine("----------------");
            var linqFirstOrDefalut = contacts.FirstOrDefault();
            Console.WriteLine($"{linqFirstOrDefalut?.Age}, {linqFirstOrDefalut?.Name}");
            Console.WriteLine("----------------");
            var linqCount = contacts.Count();
            Console.WriteLine(linqCount);
            Console.WriteLine("----------------");



        }
    }
}

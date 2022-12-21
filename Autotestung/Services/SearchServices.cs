using Autotestung.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Autotestung.Services
{
    internal static class SearchServices
    {
        private static String SearchTest = "Iphone";
        private static String SearchTest2 = "Iphone SE";

        private static String SearchTestErrors = "вчсапмиртоль";
        
        public static Search WithSearchFromProperty()
        {
            return new Search(SearchTest, true);
        }
        public static Search WithSearchFromPropertySE()
        {
            return new Search(SearchTest2, true);
        }
        public static Search WithSearchErrorsFromProperty()
        {
            return new Search(SearchTestErrors, true);
        }
        public static Search WithEmptySearch()
        {
            return new Search("", true);
        }
    }
}

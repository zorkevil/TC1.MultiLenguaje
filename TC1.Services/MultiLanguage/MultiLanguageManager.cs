using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Resources;
using System.Reflection;
using System.Threading;
using System.Globalization;

namespace TC1.Services
{
    public static class MultiLanguageManager
    {
        public static void SetCulture()
        {
            Thread.CurrentThread.CurrentUICulture = new CultureInfo("en-US");
        }

        public static void SetCulture(string culture)
        {
            Thread.CurrentThread.CurrentUICulture = new CultureInfo(culture);
        }

        public static string Localize(string elemento)
        {
            ResourceManager rm = new ResourceManager("TC1.Services.MultiLanguage.Languages.language", Assembly.GetExecutingAssembly());
            return rm.GetString(elemento);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Windows_Forms_Controls
{
    public sealed class Settings  //Singleton
    {
        private static readonly Settings Instance = new Settings();
        public string Font;

        static Settings() { }
        private Settings() {
            Font = "Bahnschrift Condensed";
        }
        public static Settings GetInstance()
        {
            return Instance;
        }
    }
}

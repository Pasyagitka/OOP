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
        public float FontSize;

        static Settings() { }
        private Settings() {
            FontSize = 15.2F;
        }
        public static Settings GetInstance()
        {
            return Instance;
        }
    }
}

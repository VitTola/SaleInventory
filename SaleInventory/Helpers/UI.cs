using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SaleInventory.Helpers
{
    public static class UI
    {
        static InputLanguage _primaryLanguage = null;
        static InputLanguage _englishLanguage = null;
        /// <summary>
        /// Get Khmer Keyboard
        /// </summary>
        public static InputLanguage Primary
        {
            get
            {
                if (_primaryLanguage == null)
                {
                    _primaryLanguage = InputLanguage.InstalledInputLanguages[0];
                    for (int i = 0; i < InputLanguage.InstalledInputLanguages.Count; i++)
                    {
                        if (InputLanguage.InstalledInputLanguages[i].LayoutName.ToLower().Contains("khmer") || InputLanguage.InstalledInputLanguages[i].LayoutName.ToLower().Contains("cambodian"))
                        {
                            _primaryLanguage = InputLanguage.InstalledInputLanguages[i];
                            break;
                        }
                    }
                }
                return _primaryLanguage;
            }
        }

        /// <summary>
        /// Get English Keyboard
        /// </summary>
        public static InputLanguage English
        {
            get
            {
                if (_englishLanguage == null)
                {
                    _englishLanguage = InputLanguage.InstalledInputLanguages[0];
                    for (int i = 0; i < InputLanguage.InstalledInputLanguages.Count; i++)
                    {
                        if (InputLanguage.InstalledInputLanguages[i].LayoutName.ToLower().Contains("us") || InputLanguage.InstalledInputLanguages[i].LayoutName.ToLower().Contains("united states"))
                        {
                            _englishLanguage = InputLanguage.InstalledInputLanguages[i];
                            break;
                        }
                    }
                }
                return _englishLanguage;
            }
        }
    }
}

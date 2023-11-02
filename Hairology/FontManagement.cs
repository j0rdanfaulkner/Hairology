using System;
using System.Collections.Generic;
using System.DirectoryServices;
using System.Drawing.Drawing2D;
using System.Drawing.Text;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Hairology
{
    public class FontManagement
    {
        private PrivateFontCollection _pfc = new PrivateFontCollection();
        public static Font buttons = default!;
        public static Font columnHeaders = default!;
        public static Font dateTimeSubtitles = default!;
        public static Font departmentSubtitle = default!;
        public static Font labels = default!;
        public static Font menuBar = default!;
        public static Font textInput = default!;
        public static Font titles = default!;
        public static Font subtitles = default!;
        // constructor
        public FontManagement()
        {
            // add fonts from resources to font collection
            // 1 = "Eurostile LT W03 Extended 2.ttf"
            // 0 = "Eurostile LT W03 Condensed.ttf"
            _pfc.AddFontFile(Path.Combine(Application.StartupPath + "\\Resources\\", "Eurostile LT W03 Extended 2.ttf"));
            _pfc.AddFontFile(Path.Combine(Application.StartupPath + "\\Resources\\", "Eurostile LT W03 Condensed.ttf"));
        }
        public void SetFonts()
        {
            // set fonts
            textInput = new Font(_pfc.Families[1], 14, FontStyle.Bold);
            buttons = new Font(_pfc.Families[1], 16, FontStyle.Bold);
            labels = new Font(_pfc.Families[1], 16, FontStyle.Bold);
            columnHeaders = new Font(_pfc.Families[1], 12, FontStyle.Bold);
            titles = new Font(_pfc.Families[1], 22, FontStyle.Bold);
            subtitles = new Font(_pfc.Families[1], 12, FontStyle.Regular);
            departmentSubtitle = new Font(_pfc.Families[1], 14, FontStyle.Regular);
            dateTimeSubtitles = new Font(_pfc.Families[1], 16, FontStyle.Bold);
            menuBar = new Font(_pfc.Families[1], 14, FontStyle.Bold);
        }
    }
}

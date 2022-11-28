using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gyumolcsok_forms
{
    internal static class Program
    {
        static public gyumolcs_insert gyumolcs_Insert = null;
        static public gyumolcs_delete gyumolcs_Delete = null;
        static public gyumolcs_update gyumolcs_Update = null;
        static public Form_Nyito form_Nyito = null;
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            gyumolcs_Delete = new gyumolcs_delete();
            gyumolcs_Insert = new gyumolcs_insert();
            gyumolcs_Update = new gyumolcs_update();
            form_Nyito = new Form_Nyito();
            Application.Run(form_Nyito);

        }
    }
}

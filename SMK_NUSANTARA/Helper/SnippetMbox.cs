using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMK_NUSANTARA.Helper
{
    public static class SnippetMbox
    {
        public static void Error(string title, string msg)
        {
            System.Windows.Forms.MessageBox.Show(
                msg,
                title,
                System.Windows.Forms.MessageBoxButtons.OK,
                System.Windows.Forms.MessageBoxIcon.Error              
                );
        }

        public static void Information(string title, string msg)
        {
            System.Windows.Forms.MessageBox.Show(
                msg,
                title,
                System.Windows.Forms.MessageBoxButtons.OK,
                System.Windows.Forms.MessageBoxIcon.Information
                );
        }
    }
}

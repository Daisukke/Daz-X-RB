using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Meep_X_RB
{
    class Functions
    {
        public static OpenFileDialog openfiledialog = new OpenFileDialog
        {
            Filter = "Lua Script Txt (*.txt)|*.txt|All files (*.*)|*.*",
            FilterIndex = 1,
            RestoreDirectory = true,
            Title = "Meep-X RB"
        };

        public static void PopulateListBox(ListBox lsb, string Folder, string FileType)
        {
            DirectoryInfo dinfo = new DirectoryInfo(Folder);
            FileInfo[] Files = dinfo.GetFiles(FileType);
            foreach (FileInfo file in Files)
            {
                lsb.Items.Add(file.Name);
            }
        }
    }
}

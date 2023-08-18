using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using XML_AutoUpdater;


class XMLAutoUpdater
{
    [STAThread]
    static void Main(string[] args)
    {

        Application.Run(new MainForm());
    }


}
static class Debugging
{
    public static bool Testing = false;
}
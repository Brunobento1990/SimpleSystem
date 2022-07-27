using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleSystem.Classes
{
    public class clsMenssage
    {
        public void Alerta(string texto)
        {
            MessageBox.Show(texto,"Simple System",MessageBoxButtons.OK,MessageBoxIcon.Error);
        }
    }
}

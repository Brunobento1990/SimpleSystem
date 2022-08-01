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
            MessageBox.Show(texto,"Simple System",MessageBoxButtons.OK,MessageBoxIcon.Warning);
        }
        public bool Excluir(string texto)
        {
            bool retorno = true;
            DialogResult result = new DialogResult();
            result = MessageBox.Show(texto, "Simple System", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                return retorno;
            }
            else
            {
                retorno = false;
                return retorno;
            }
        }
    }
}

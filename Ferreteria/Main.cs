using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ferreteria
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            OpenNotaPedido();
        }

        #region Private Methods
        
        private void OpenNotaPedido()
        {
            Nota_de_Pedido notaPedido = new Nota_de_Pedido();
            notaPedido.ShowDialog();
        }

        #endregion
    }
}

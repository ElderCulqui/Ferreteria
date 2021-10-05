using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Ferreteria
{
    public partial class Nota_de_Pedido : Form
    {
        private BusinessLogicLayer _businessLogicLayer;
        public Nota_de_Pedido()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            NotaPedidoModel notaPedidoModel = new NotaPedidoModel();
            notaPedidoModel.Cliente = txtCliente.Text;
            notaPedidoModel.DireccionCliente = txtDireccionCliente.Text;
            notaPedidoModel.FormaPago = txtFormaPago.Text;
            // notaPedidoModel.Cantidad = txtCantidad.text;
            // notaPedidoModel.PrecioUnitario = txtPrecioUnitario.Text;
            // notaPedidoModel.Envio = txtEnvio.Text;
            notaPedidoModel.Direccion = txtDireccion.Text;
            notaPedidoModel.Observaciones = txtObservaciones.Text;
        }
    }
}

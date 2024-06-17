using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SysContatos
{
    public partial class ListaContatos : Form
    {
        public ListaContatos()
        {
            InitializeComponent();
            ContatoDAO contatoDAO = new ContatoDAO();
            List<Contato> listaContatos = contatoDAO.ObterContatos();

            tblListaContatos.DataSource = listaContatos;
        }
    }
}

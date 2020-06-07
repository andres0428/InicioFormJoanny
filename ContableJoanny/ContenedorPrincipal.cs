﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ContableJoanny
{
    public partial class ContenedorPrincipal : Form
    {
        private int childFormNumber = 0;

        public ContenedorPrincipal()
        {
            InitializeComponent();
        }

        private void ShowNewForm(object sender, EventArgs e)
        {
            Form childForm = new Form();
            childForm.MdiParent = this;
            childForm.Text = "Window " + childFormNumber++;
            childForm.Show();
        }

        private void OpenFile(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            openFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = openFileDialog.FileName;
            }
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            saveFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = saveFileDialog.FileName;
            }
        }

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CutToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

    
     

        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }

       

        private void optionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MantenimientoCliente mantenimiento = new MantenimientoCliente();
            mantenimiento.MdiParent = this;
            mantenimiento.Show();
        }

        private void productosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MantenimientoProductos mantenimiento = new MantenimientoProductos();
            mantenimiento.MdiParent = this;
            mantenimiento.Show();
        }

        private void contentsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConsultaClientes consultas = new ConsultaClientes();
            consultas.MdiParent = this;
            consultas.Show();
        }

        private void indexToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConsultaProductos consultas = new ConsultaProductos();
            consultas.MdiParent = this;
            consultas.Show();
        }

        private void ContenedorPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void facturacionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Facturacion facturacion = new Facturacion();
            facturacion.MdiParent = this;
            facturacion.Show();
        }
    }
}

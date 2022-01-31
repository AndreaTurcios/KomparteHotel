using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Komparte
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
            hideSubMenu();
        }
        private void showSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                hideSubMenu();
                subMenu.Visible = true;
            }
            else
                subMenu.Visible = false;
        }

        private void hideSubMenu()
        {
            panelBotones.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            showSubMenu(panelBotones);
        }
    }
}

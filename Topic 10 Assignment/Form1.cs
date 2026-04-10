using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Topic_10_Assignment
{
    public partial class FormAssignment10 : Form
    {
        Random generator = new Random();

        public FormAssignment10()
        {
            InitializeComponent();
        }

        private void btnCPU_Click(object sender, EventArgs e)
        {
            imgComputerComponants.Visible = true;
            imgComputerComponants.Image = Properties.Resources.CPU;
            lblDesc.Text = "The CPU is ";
        }

        private void btnRAM_Click(object sender, EventArgs e)
        {
            imgComputerComponants.Visible = true;
            imgComputerComponants.Image = Properties.Resources.RAM;
            lblDesc.Text = "The RAM is ";
        }

        private void btnSSD_Click(object sender, EventArgs e)
        {
            imgComputerComponants.Visible = true;
            imgComputerComponants.Image = Properties.Resources.SSD;
            lblDesc.Text = "The SSD is ";
        }

        private void btnPowerS_Click(object sender, EventArgs e)
        {
            imgComputerComponants.Visible = true;
            imgComputerComponants.Image = Properties.Resources.PowerS;
            lblDesc.Text = "The Power Supply is ";
        }

        private void btnInput_Click(object sender, EventArgs e)
        {
            generator.Next(3);
            if (generator.Next(3) == 1)
            {
                imgComputerComponants.Visible = true;
                imgComputerComponants.Image = Properties.Resources.Mouse;
                lblDesc.Text = "An Input Peripheral can be ";
            }
            else if (generator.Next(3) == 2)
            {
                imgComputerComponants.Visible = true;
                imgComputerComponants.Image = Properties.Resources.KeyB;
                lblDesc.Text = "An Input Peripheral can be ";
            }
            
        }

        private void btnOutput_Click(object sender, EventArgs e)
        {
            generator.Next(3);
            if (generator.Next(3) == 1)
            {
                imgComputerComponants.Visible = true;
                imgComputerComponants.Image = Properties.Resources.Speakers;
                lblDesc.Text = "An Output Peripheral can be ";
            }
            else if (generator.Next(3) == 2)
            {
                imgComputerComponants.Visible = true;
                imgComputerComponants.Image = Properties.Resources.Screen;
                lblDesc.Text = "An Output Peripheral can be ";
            }
        }
    }
}

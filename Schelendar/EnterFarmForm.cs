using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Sunny.UI;

namespace Schelendar
{
    public partial class EnterFarmForm : UIForm
    {
        public EnterFarmForm()
        {
            InitializeComponent();
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            FarmForm farmForm = new FarmForm();
            farmForm.ShowDialog();
            farmForm.Dispose();
        }
    }
}

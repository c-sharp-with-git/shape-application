using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ShapeLibrary;

namespace DesktopShapeApplication
{
    public partial class AreaOfCircleForm : Form
    {
        public AreaOfCircleForm()
        {
            InitializeComponent();
        }

        private void calculateButton_Click(object sender, 
            EventArgs e)
        {
            ep.Clear();
            try
            {
                double radius = Convert.ToDouble(
                    radiusTextBox.Text);
                Circle c = new Circle(radius);
                areaTextBox.Text = c.Area().ToString();
            }
            catch
            {
                ep.SetError(radiusTextBox,
                    "radius must be a positive number.");
            }
        }

        private void radiusTextBox_TextChanged(object sender, EventArgs e)
        {
            areaTextBox.Text = string.Empty;
            ep.Clear();
        }
    }
}

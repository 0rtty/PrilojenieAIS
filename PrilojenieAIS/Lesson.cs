using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrilojenieAIS
{
    public partial class Lesson : UserControl
    {
        public Lesson()
        {
            InitializeComponent();
        }
        public void SetImage(string imagePath)
        {
            readingZone.ImageLocation = imagePath;
        }
    }
}

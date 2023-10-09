using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Compression;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pract_1
{
    public partial class Zip : Form
    {
        public Zip()
        {
            InitializeComponent();

        }

        void Metod()
        {


            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (MemoryStream fileOut = new MemoryStream(Properties.Resources.Mass))
            using (GZipStream gz = new GZipStream(fileOut, CompressionMode.Decompress))
                new SoundPlayer(gz).Play();

            //using (FileStream fileIn = File.OpenRead(@"E:\Mass.wav"))
            //using (FileStream fileOut = File.Create(@"E:\Mass.gz"))
            //using (GZipStream gz = new GZipStream(fileOut, CompressionLevel.Optimal))
            //    fileIn.CopyTo(gz);
        }
    }
}

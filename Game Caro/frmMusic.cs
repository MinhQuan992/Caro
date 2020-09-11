using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Game_Caro
{
    public partial class frmMusic : Form
    {
        public frmMusic()
        {
            InitializeComponent();
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog() { Multiselect = true, Filter = "WMV|*.wmv|WAV|*.wav|MP3|*.mp3|MP4|*.mp4|MKV|*.mkv" })
            {
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    List<MediaFile> files = new List<MediaFile>();
                    foreach (string fileName in ofd.FileNames)
                    {
                        FileInfo fi = new FileInfo(fileName);
                        files.Add(new MediaFile() { FileName = Path.GetFileNameWithoutExtension(fi.FullName), Path = fi.FullName });
                    }
                    libMusic.DataSource = files;
                }
            }
        }

        private void FrmMusic_Load(object sender, EventArgs e)
        {
            libMusic.ValueMember = "Path";
            libMusic.DisplayMember = "FileName";
        }

        private void LibMusic_SelectedIndexChanged(object sender, EventArgs e)
        {
            MediaFile mediaFile = libMusic.SelectedItem as MediaFile;
            if (mediaFile != null)
            {
                axWindowsMediaPlayer1.URL = mediaFile.Path;
                axWindowsMediaPlayer1.Ctlcontrols.play();
            }
        }
    }
}

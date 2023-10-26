using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Windows.Forms;

namespace ConversorImagens
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSelecionarPastaOrigem_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dialog = new FolderBrowserDialog();

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                txtPastaOrigem.Text = dialog.SelectedPath;
            }
        }

        private void btnSelecionarPastaDestino_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dialog = new FolderBrowserDialog();

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                txtPastaDestino.Text = dialog.SelectedPath;
            }
        }

        private void btnConverter_Click(object sender, EventArgs e)
        {
            string pastaOrigem = txtPastaOrigem.Text;
            string pastaDestino = txtPastaDestino.Text;

            if (!Directory.Exists(pastaOrigem) || !Directory.Exists(pastaDestino))
            {
                MessageBox.Show("A pasta de origem ou destino não existe.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string[] arquivosJpg = Directory.GetFiles(pastaOrigem, "*.jpg");

            progressBar1.Maximum = arquivosJpg.Length;
            progressBar1.Value = 0;

            foreach (string arquivo in arquivosJpg)
            {
                string nomeArquivo = Path.GetFileNameWithoutExtension(arquivo);
                string arquivoTiff = Path.Combine(pastaDestino, $"{nomeArquivo}.tiff");

                using (Bitmap imagem = new Bitmap(arquivo))
                {
                    imagem.Save(arquivoTiff, ImageFormat.Tiff);
                }

                progressBar1.Value++;
            }

            MessageBox.Show("Conversão concluída!", "Concluído", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}

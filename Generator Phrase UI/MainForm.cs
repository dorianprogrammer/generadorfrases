using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Generator_Phrase_UI
{
    public partial class MainForn : Form
    {
        public MainForn()
        {
            InitializeComponent();
        }

        private void generateButton_Click(object sender, EventArgs e)
        {
            string frase = phraseTxt.Text.ToLower();
            Generator_Pharses.SeparatorPhrase separatorPhrase = new Generator_Pharses.SeparatorPhrase(frase);
            generatedPhraseTxt.Text = separatorPhrase.getGeneratePhrase();
        }
    }
}

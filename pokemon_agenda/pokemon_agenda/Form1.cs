using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pokemon_agenda
{
    public partial class fnCadastroPokemon : Form
    {
        public fnCadastroPokemon()
        {
            InitializeComponent();
        }

        private void fnLimpar()
        {  
            txtNome.Clear();
            cbTipo.SelectedIndex = -1;
            numNivel.Value = 1;

            txtNome.Focus();


        }
        private void txtSalvar_Click(object sender, EventArgs e)
        {
            string nomePokemon = txtNome.Text;  //textBox    
            string tipoPokemon = cbTipo.Text;   //comboBox
            int nivelPokemon = (int)numNivel.Value; //numericUpDown


            MessageBox.Show($"O pokémon {nomePokemon} do tipo {tipoPokemon} " +
                $"foi cadastrado com o nivel {nivelPokemon}");

            fnLimpar();
        }


        private void txtLimpar_Click(object sender, EventArgs e)
        {
            fnLimpar();
        }
    }
}

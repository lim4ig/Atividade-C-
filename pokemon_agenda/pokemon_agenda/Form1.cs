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

        // disponibilidade retorno nome (funções) a função serve para reaproveitar codigos, definindo uma função eu posso reutilizar o codigo
        private void fnLimpar()
        {
            txtNome.Clear();
            cbTipo.SelectedIndex = -1;
            numNivel.Value = 1;

            txtNome.Focus();

        }
        /* objetivo da aula: aprender a criar e utilizar objetos
         * mini game pokemon
         * 1- montar meu time pokemon (6 pokemon) -> listas
         * 2- treinar esse meu time pokemon (a cada treinamento ele recebe 2 nivel)
         * 3- batalhar com esse pokemon de forma randonica
         * sistema vai sortear 1 a 6 pokemon (somente os 151 primeiros)
         */
        private void btnSalvar_Click(object sender, EventArgs e)
        {

            string nomePokemon = txtNome.Text; //textBox
            string tipoPokemon = cbTipo.Text; //comboBox
            int nivelPokemon = (int)numNivel.Value; //numericUpDown

            Pokemon poke = new Pokemon(nomePokemon, tipoPokemon, nivelPokemon);

            poke.fnDescricao();

            //MessageBox.Show($"o Pokémon {nomePokemon} do tipo {tipoPokemon} " +
            //    $"foi cadastrado com o nivel {nivelPokemon}");

            fnLimpar();

        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            fnLimpar();
        }
    } 
}
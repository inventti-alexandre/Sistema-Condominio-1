﻿using MetroFramework.Forms;
using Sistema_Condominio.Dao;
using Sistema_Condominio.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_Condominio.View
{
    public partial class VeiculoCadastro : MetroForm
    {
        private int morador_id;
        private veiculo veiculo;
        public VeiculoCadastro()
        {
            InitializeComponent();
        }

        private void VeiculoCadastro_Load(object sender, EventArgs e)
        {

        }

        private void btPesquisar_Click(object sender, EventArgs e)
        {
            MoradorPesquisar moradorPesquisar = new MoradorPesquisar();
            moradorPesquisar.ShowDialog();
            metroTextBoxMoradorNome.Text = moradorPesquisar.retornarMorador().pessoa.NOME;
            morador_id = moradorPesquisar.retornarMorador().ID;
        }

        private void metroTextBoxMoradorNome_Click(object sender, EventArgs e)
        {

        }
        private void carregaVeiculo()
        {
            veiculo.MORADOR_ID   = morador_id;
            veiculo.MARCA        = textBoxMarca.Text;
            veiculo.MODELO       = textBoxModelo.Text;
            veiculo.COR          = textBoxCor.Text;
            veiculo.N_PLACA      = textBoxNrPlaca.Text;
            veiculo.VAGA_ALUGADA = Convert.ToInt32(textBoxVagaAlugada.Text);
        }

        private void textButtonCadastrar_Click(object sender, EventArgs e)
        {
            try
            {
                veiculo = new veiculo();
                carregaVeiculo();
                VeiculoDAO veiculoDao = new VeiculoDAO();
                veiculoDao.cadastrarVeiculo(veiculo);

                MessageBox.Show("Veiculo Salvo");
                Index index = new Index();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
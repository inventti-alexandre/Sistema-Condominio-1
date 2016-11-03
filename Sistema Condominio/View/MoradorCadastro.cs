﻿using Sistema_Condominio.Dao;
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
    public partial class MoradorCadastro : Form
    {
        private morador morador;
        public MoradorCadastro()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            try
            {
                morador = new morador();
                carregaMorador();
                MoradorDAO moradorDao = new MoradorDAO();
                moradorDao.cadastrarMorador(morador);

                MessageBox.Show("Salvei");
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }

        }

        private void carregaMorador()
        {
            morador.DATA_INI                    = dateTimeDataInicio.Value;
            morador.pessoa.NOME                 = textNome.Text;
            morador.pessoa.CPF                  = textCPF.Text;
            morador.pessoa.RG                   = textRG.Text;
            morador.pessoa.TELEFONE_RESIDENCIAL = textTResidencial.Text;
            morador.pessoa.TEL_COMERC           = textTComercial.Text;
            morador.pessoa.CELULAR              = textTCelular.Text;
            morador.pessoa.EMAIL                = textEmail.Text;
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}

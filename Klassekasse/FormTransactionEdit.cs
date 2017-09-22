﻿using System;
using System.Globalization;
using System.Windows.Forms;

namespace Klassekasse
{
    public partial class FormTransactionEdit : Form
    {
        public static string Description;
        public static decimal? Diffrence;

        public FormTransactionEdit()
        {
            InitializeComponent();
            Description = null;
            Diffrence = null;
        }

        public FormTransactionEdit(string description, decimal? diffrence)
        {
            InitializeComponent();
            Description = null;
            Diffrence = null;
            textBoxDescription.Text = description;
            textBoxDiffrence.Text = diffrence.ToString();
        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            if (decimal.TryParse(textBoxDiffrence.Text.Replace(',', Convert.ToChar(CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)).Replace('.', Convert.ToChar(CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator)), out decimal result))
            {
                Description = textBoxDescription.Text;
                Diffrence = result;
                Close();
            }
            
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            Description = null;
            Diffrence = null;
            Close();
        }

        private void textBoxDescription_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
            }
        }
    }
}

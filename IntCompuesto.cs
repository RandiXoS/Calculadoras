﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Calculadoras
{
    public partial class IntCompuesto : Form
    {
        public IntCompuesto()
        {
            InitializeComponent();
        }

        private void IntCompuesto_FormClosed(object sender, FormClosedEventArgs e)
        {
            Aux.scalc.Show();
        }
    }
}

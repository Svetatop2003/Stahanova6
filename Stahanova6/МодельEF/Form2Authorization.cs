﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Stahanova6.МодельEF; 

namespace Stahanova6.МодельEF
{
    public partial class Form2Authorization : Form
    {
        public Form2Authorization()
        {
            InitializeComponent();
        }

        private void buttonCome_Click(object sender, EventArgs e)
        {
            ModelEF model = new ModelEF();
            if (model.UsersHash.ToList().Any(x =>
            x.Login == textBoxLog.Text &&
            x.Password == SHA256Builder.ConvertToHash(textBoxPas.Text) ) )
            {
                MessageBox.Show("Пользователь найден!");
                return;

            }
            MessageBox.Show("Пользователь не найден!");
        }
    }
}

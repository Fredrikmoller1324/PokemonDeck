﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pokemon
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            using (var db = new PokemonContext())
            {
                if(db.Database.CanConnect())
                {
                    MessageBox.Show("Connected");
                }
                else
                {
                    MessageBox.Show("failed to connected");
                }
            }
        }
    }
}

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace SistemaAlumnos
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                String res = Conexion.comprobarPw(txUsuario.Text, txPassword.Text);
                if (res.Equals("contraseña correcta"))
                {
                    Alta w = new Alta();
                    w.Show();
                    this.Close();
                }

                else
                    MessageBox.Show(res);
            }
            catch (Exception)
            {
                MessageBox.Show("OCURRIÓ UN ERROR");
            }
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            txPassword.Text = "ana";
            txUsuario.Text = "ana";
        }
    }
}

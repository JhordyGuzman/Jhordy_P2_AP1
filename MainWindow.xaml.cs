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
using Jhordy_P2_AP1.UI.Registros;
using Jhordy_P2_AP1.UI.Consultas;

namespace Jhordy_P2_AP1
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

        private void RegistroProyectos_Click(object sender, RoutedEventArgs e)
        {
            rProyectos ventana = new rProyectos();
            ventana.Show();
            
        }

        private void ConsultaProyectos_Click(object sender, RoutedEventArgs e)
        {
             cProyectos ventana = new cProyectos();
             ventana.Show();
        }

    }
}

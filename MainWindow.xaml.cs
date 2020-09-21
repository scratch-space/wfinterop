using System;
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

namespace wfinterop
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            DataContext = this;

            winformsPanel.Controls.Add(new System.Windows.Forms.NumericUpDown()
            {
                AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit,
                AutoSize = false,
                BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D,
                Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left,
                Dock = System.Windows.Forms.DockStyle.Fill
            });

            winformsPanel.Controls.Add(new System.Windows.Forms.Button() 
            { 
                Text = "WinForms Button",
                AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowOnly,
                Dock = System.Windows.Forms.DockStyle.Fill
            });

        }

        public string TargetFramework
        {
            get
            {
#if NETFRAMEWORK
                return ".NETFramework";
#elif NETCOREAPP
                return ".NETCore";
#else
#error "Unsupported TFM"
#endif
            }
        }
    }
}

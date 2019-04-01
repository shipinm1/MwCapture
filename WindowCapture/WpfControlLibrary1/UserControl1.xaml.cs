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
using WpfControlLibrary1.Utils;
using System.Diagnostics;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace WpfControlLibrary1
{
    /// <summary>
    /// Interaction logic for UserControl1.xaml
    /// </summary>
    public partial class UserControl1 : UserControl
    {
        private bool _isOpen = false;
        public bool IsOpen
        {
            get
            {
                return _isOpen;
            }
            set
            {
                _isOpen = value;
            }
        }
        

        ICommand OpenMenu
        {
            get
            {
                return new RelayCommand(() => { IsOpen = true; });
            }
        }

        public ICommand Command1
        {
            get
            {
                
                return new RelayCommand(() => Debug.WriteLine("1"));
            }
        }

        public ICommand Command2
        {
            get
            {
                return new RelayCommand(() => Debug.WriteLine("2"));
            }
        }

        public ICommand Command3
        {
            get
            {
                return new RelayCommand(() => Debug.WriteLine("3"));
            }
        }

        public ICommand Command4
        {
            get
            {
                return new RelayCommand(() => Debug.WriteLine("4"));
            }
        }

        public ICommand Command5
        {
            get
            {
                return new RelayCommand(() => Debug.WriteLine("5"));
            }
        }

        public ICommand Command6
        {
            get
            {
                return new RelayCommand(() => Debug.WriteLine("6"));
            }
        }

        public ICommand Command7
        {
            get
            {
                return new RelayCommand(() => Debug.WriteLine("7"));
            }
        }

        public ICommand Command8
        {
            get
            {
                return new RelayCommand(() => Debug.WriteLine("8"));
            }
        }

        public ICommand Command9
        {
            get
            {
                return new RelayCommand(() => Debug.WriteLine("9"));
            }
        }

        public ICommand Command10
        {
            get
            {
                return new RelayCommand(() => Debug.WriteLine("10"));
            }
        }

        public ICommand Command11
        {
            get
            {
                return new RelayCommand(() => Debug.WriteLine("11"));
            }
        }

        public ICommand Command12
        {
            get
            {
                return new RelayCommand(() => Debug.WriteLine("12"));
            }
        }

        public UserControl1()
        {
            InitializeComponent();
        }

        private void OnMouseDown(object sender, MouseButtonEventArgs e)
        {
            Point pnt = e.GetPosition(mrRec);
            
            TranslateTransform newlocation = new TranslateTransform();
            newlocation.X = pnt.X - 148;
            newlocation.Y = pnt.Y - 148;
            redCircle.RenderTransform = newlocation;
            //Point relativePoint = redCircle.TransformToAncestor(mrRec).Transform(new Point(0, 0));
            //Debug.WriteLine("circle position: " + relativePoint.ToString());
            //Debug.WriteLine("mouse position: " + pnt.ToString());
        }


        public event PropertyChangedEventHandler PropertyChanged;


        void RaisePropertyChanged([CallerMemberName]string propertyName = null)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
}

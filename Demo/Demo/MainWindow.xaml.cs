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
using System.Runtime.InteropServices;

namespace Demo
{
    /// <summary>
    /// MainWindow.xaml 的互動邏輯
    /// </summary>
    public partial class MainWindow : Window
    {
        [DllImport("MyDLL.dll", EntryPoint = "add", CallingConvention = CallingConvention.Cdecl)]
        public static extern int add(int a, int b);

        [DllImport("MyDLL.dll", EntryPoint = "subtract", CallingConvention = CallingConvention.Cdecl)]
        public static extern int sub(int a, int b);

        public MainWindow()
        {
            InitializeComponent();
            int ans = add(20,10);
            Console.WriteLine(ans);
            label_add.Content = "相加的答案是  " + ans;
            ans = sub(20, 10);
            Console.WriteLine(ans);
            label_sub.Content = "相減的答案是  " + ans;

        }
    }
}

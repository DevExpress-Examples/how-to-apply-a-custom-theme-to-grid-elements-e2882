using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;
using System.Windows.Data;
using DevExpress.Xpf.Data;
using DevExpress.Xpf.Grid;
using System.Collections.ObjectModel;
using DevExpress.Xpf.Core;

namespace Q223568ConditionalFormattingInSL {
    public partial class MainPage : UserControl {
        public MainPage() {
            InitializeComponent();

            Random random = new Random();

            ObservableCollection<TestData> list = new ObservableCollection<TestData>();
            for(int i = 0; i < 10; i++)
                list.Add(new TestData() { Text = "Row" + i%2, Red = random.Next(255), Green = random.Next(255), Blue = random.Next(255) });
            grid.DataSource = list;

            Theme theme = new Theme("LightGrayBasedTheme") { IsStandard = false, FullName = "Light Gray Based Theme" };
            ThemeManager.ApplicationTheme = theme;
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            DXVisualizer.DXVisualTreeVisualizer.Show();
        }

    }
    public class TestData {
        public int Red { get; set; }
        public int Green { get; set; }
        public int Blue { get; set; }
        public string Text { get; set; }
    }
    public class NumberToColorConverter : IValueConverter {
        IValueConverter rowPropertyValueConverter = new RowPropertyValueConverter();
        #region IValueConverter Members
        object IValueConverter.Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture) {
            byte red = Convert.ToByte(((TestData)value).Red);
            byte green = Convert.ToByte(((TestData)value).Green);
            byte blue = Convert.ToByte(((TestData)value).Blue);
            return new SolidColorBrush(Color.FromArgb(255, red, green, blue));
        }

        object IValueConverter.ConvertBack(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture) {
            throw new NotImplementedException();
        }

        #endregion
    }

            


}

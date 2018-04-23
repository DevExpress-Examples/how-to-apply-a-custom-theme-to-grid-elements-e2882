using System;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;
using System.Collections.ObjectModel;

namespace Q223568ConditionalFormattingInSL {
    public class TestData {
        public ObservableCollection<TestDataItem> List { get; private set; }
        public TestData() {
            List = GetTestData();
        }
        ObservableCollection<TestDataItem> GetTestData() {
            Random random = new Random();
            ObservableCollection<TestDataItem> list = new ObservableCollection<TestDataItem>();
            for(int i = 0; i < 10; i++)
                list.Add(new TestDataItem() { Text = "Row" + i % 2, Red = random.Next(255), Green = random.Next(255), Blue = random.Next(255) });
            return list;
        }
    }
    public class TestDataItem {
        public int Red { get; set; }
        public int Green { get; set; }
        public int Blue { get; set; }
        public string Text { get; set; }
    }
}

using OnlineCinema;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace Desktop
{
    public class ViewModel
    {
        public ICommand Query { get; set; }
        public ViewModel()
        {
            Query = new Command(Order, canExecute);
        }

        bool canExecute(object parametr)
        {
            return true;
        }

        private async void Order(object paramater)
        {
           var values = (object[])paramater;
           int count = Convert.ToInt32(values[0]);
           int id = Convert.ToInt32(values[1]);
           await Helper.Order(id, count);
           MessageBox.Show($"{count} билетов заказано");
        }
    }
}

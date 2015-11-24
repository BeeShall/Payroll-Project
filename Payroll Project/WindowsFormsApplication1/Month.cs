using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Payroll
{
    public class Month
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string NumberOfDays { get; set; }

        public List<Month> GetMonths()
        {
            List<Month> listOfMonth = new List<Month>();
            Month obj = new Month();
            obj.Id = "1";
            obj.Name = "January";
            obj.NumberOfDays = "31";
            listOfMonth.Add(obj);
            obj = new Month();
            obj.Id = "2";
            obj.Name = "February";
            obj.NumberOfDays = "28";
            listOfMonth.Add(obj);
            obj = new Month();
            obj.Id = "3";
            obj.Name = "March";
            obj.NumberOfDays = "31";
            listOfMonth.Add(obj);
            obj = new Month();
            obj.Id = "4";
            obj.Name = "April";
            obj.NumberOfDays = "30";
            listOfMonth.Add(obj);
            obj = new Month();
            obj.Id = "5";
            obj.Name = "May";
            obj.NumberOfDays = "31";
            listOfMonth.Add(obj);
            obj = new Month();
            obj.Id = "6";
            obj.Name = "June";
            obj.NumberOfDays = "30";
            listOfMonth.Add(obj);
            obj = new Month();
            obj.Id = "7";
            obj.Name = "July";
            obj.NumberOfDays = "31";
            listOfMonth.Add(obj);
            obj = new Month();
            obj.Id = "8";
            obj.Name = "August";
            obj.NumberOfDays = "30";
            listOfMonth.Add(obj);
            obj = new Month();
            obj.Id = "9";
            obj.Name = "September";
            obj.NumberOfDays = "31";
            listOfMonth.Add(obj);
            obj = new Month();
            obj.Id = "10";
            obj.Name = "October";
            obj.NumberOfDays = "30";
            listOfMonth.Add(obj);
            obj = new Month();
            obj.Id = "11";
            obj.Name = "November";
            obj.NumberOfDays = "31";
            listOfMonth.Add(obj);
            obj = new Month();
            obj.Id = "12";
            obj.Name = "December";
            obj.NumberOfDays = "30";
            listOfMonth.Add(obj);
            return listOfMonth;
        }
    }
}

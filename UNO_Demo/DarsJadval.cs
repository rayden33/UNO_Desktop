using System;
using System.IO;
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
using System.Windows.Shapes;
using System.Globalization;
using System.Data.Entity;
using System.Net;
using System.Web.Script.Serialization;
using System.Windows.Threading;

namespace UNO_Demo
{
    class DarsJadval
    {
        public DarsPara[] Dushanba;
        public DarsPara[] Seshanba;
        public DarsPara[] Chorshanba;
        public DarsPara[] Payshanba;
        public DarsPara[] Juma;
        public DarsPara[] Shanba;

        public void Cheg1(int n)
        {
            Dushanba = new DarsPara[n];
        }
        public void Cheg2(int n)
        {
            Seshanba = new DarsPara[n];
        }
        public void Cheg3(int n)
        {
            Chorshanba = new DarsPara[n];
        }
        public void Cheg4(int n)
        {
            Payshanba = new DarsPara[n];
        }
        public void Cheg5(int n)
        {
            Juma = new DarsPara[n];
        }
        public void Cheg6(int n)
        {
            Shanba = new DarsPara[n];
        }
    }
}

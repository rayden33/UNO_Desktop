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
    class Syncronization
    {
        JavaScriptSerializer serializer = new JavaScriptSerializer();
        public string personalDataFilePath = @"" + AppDomain.CurrentDomain.BaseDirectory + "\\Resources\\UNOProfile.txt";
        DarsPara[] dars = new DarsPara[100];
        DarsJadval darslar = new DarsJadval();
        User user = new User();
        public string user_json, dars_json;
        private string darsJadvalFilePath = "Resources\\g_id_";
        private int n = 0, d = 0, s = 0, c = 0, p = 0, j = 0, sh = 0, 
            dt = 0, st = 0, ct = 0, pt = 0, jt = 0, sht = 0;

        private void ZeroSync()
        {
            user_json = File.ReadAllText(personalDataFilePath);
            user = serializer.Deserialize<User>(user_json);
            darsJadvalFilePath = darsJadvalFilePath + user.guruh_id + ".txt";
        }
        public DarsJadval jadval()
        {
            ZeroSync();
            dars_json = File.ReadAllText(darsJadvalFilePath);
            dars = serializer.Deserialize<DarsPara[]>(dars_json);
            n = dars.Length;
            for (int i = 0; i < n; i++)
            {
                switch (dars[i].day)
                {
                    case "1":
                        dt++;
                        break;
                    case "2":
                        st++;
                        break;
                    case "3":
                        ct++;
                        break;
                    case "4":
                        pt++;
                        break;
                    case "5":
                        jt++;
                        break;
                    case "6":
                        sht++;
                        break;
                }
            }
            darslar.Cheg1(dt);
            darslar.Cheg2(st);
            darslar.Cheg3(ct);
            darslar.Cheg4(pt);
            darslar.Cheg5(jt);
            darslar.Cheg6(sht);

            for (int i = 0; i < n; i++)
            {
                switch (dars[i].day)
                {
                    case "1":
                        darslar.Dushanba[d] = dars[i];
                        d++;
                        break;
                    case "2":
                        darslar.Seshanba[s] = dars[i];
                        s++;
                        break;
                    case "3":
                        darslar.Chorshanba[c] = dars[i];
                        c++;
                        break;
                    case "4":
                        darslar.Payshanba[p] = dars[i];
                        p++;
                        break;
                    case "5":
                        darslar.Juma[j] = dars[i];
                        j++;
                        break;
                    case "6":
                        darslar.Shanba[sh] = dars[i];
                        sh++;
                        break;
                }
            }
            
            return darslar;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MotorBoot
{
    public static class Common
    {
        public static List<car> PopulateCars()
        {
            string mfg;
            List<car> cars = new List<car>();

            Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);

            mfg = "acura";
            cars.Add(new car { Mfg = mfg, Address = config.AppSettings.Settings[mfg].Value });

            mfg = "audi";
            cars.Add(new car { Mfg = mfg, Address = config.AppSettings.Settings[mfg].Value });

            mfg = "bentley";
            cars.Add(new car { Mfg = mfg, Address = config.AppSettings.Settings[mfg].Value });

            mfg = "benz";
            cars.Add(new car { Mfg = mfg, Address = config.AppSettings.Settings[mfg].Value });

            mfg = "bmw";
            cars.Add(new car { Mfg = mfg, Address = config.AppSettings.Settings[mfg].Value });

            mfg = "chrysler";
            cars.Add(new car { Mfg = mfg, Address = config.AppSettings.Settings[mfg].Value });

            mfg = "daewoo";
            cars.Add(new car { Mfg = mfg, Address = config.AppSettings.Settings[mfg].Value });

            mfg = "ducatti";
            cars.Add(new car { Mfg = mfg, Address = config.AppSettings.Settings[mfg].Value });

            mfg = "fiat";
            cars.Add(new car { Mfg = mfg, Address = config.AppSettings.Settings[mfg].Value });

            mfg = "ford";
            cars.Add(new car { Mfg = mfg, Address = config.AppSettings.Settings[mfg].Value });

            mfg = "gm";
            cars.Add(new car { Mfg = mfg, Address = config.AppSettings.Settings[mfg].Value });

            mfg = "honda";
            cars.Add(new car { Mfg = mfg, Address = config.AppSettings.Settings[mfg].Value });

            mfg = "hyundaicv";
            cars.Add(new car { Mfg = mfg, Address = config.AppSettings.Settings[mfg].Value });

            mfg = "hyundai";
            cars.Add(new car { Mfg = mfg, Address = config.AppSettings.Settings[mfg].Value });

            mfg = "infiniti";
            cars.Add(new car { Mfg = mfg, Address = config.AppSettings.Settings[mfg].Value });

            mfg = "isuzu";
            cars.Add(new car { Mfg = mfg, Address = config.AppSettings.Settings[mfg].Value });

            mfg = "jaguar";
            cars.Add(new car { Mfg = mfg, Address = config.AppSettings.Settings[mfg].Value });

            mfg = "kia";
            cars.Add(new car { Mfg = mfg, Address = config.AppSettings.Settings[mfg].Value });

            mfg = "landrover";
            cars.Add(new car { Mfg = mfg, Address = config.AppSettings.Settings[mfg].Value });

            mfg = "lexus";
            cars.Add(new car { Mfg = mfg, Address = config.AppSettings.Settings[mfg].Value });

            mfg = "mazda";
            cars.Add(new car { Mfg = mfg, Address = config.AppSettings.Settings[mfg].Value });

            mfg = "mini";
            cars.Add(new car { Mfg = mfg, Address = config.AppSettings.Settings[mfg].Value });

            mfg = "mitsubishi";
            cars.Add(new car { Mfg = mfg, Address = config.AppSettings.Settings[mfg].Value });

            mfg = "nissan";
            cars.Add(new car { Mfg = mfg, Address = config.AppSettings.Settings[mfg].Value });

            mfg = "porsche";
            cars.Add(new car { Mfg = mfg, Address = config.AppSettings.Settings[mfg].Value });

            mfg = "rollsroyce";
            cars.Add(new car { Mfg = mfg, Address = config.AppSettings.Settings[mfg].Value });

            mfg = "saab";
            cars.Add(new car { Mfg = mfg, Address = config.AppSettings.Settings[mfg].Value });

            mfg = "scion";
            cars.Add(new car { Mfg = mfg, Address = config.AppSettings.Settings[mfg].Value });

            mfg = "sprinter";
            cars.Add(new car { Mfg = mfg, Address = config.AppSettings.Settings[mfg].Value });

            mfg = "subaru";
            cars.Add(new car { Mfg = mfg, Address = config.AppSettings.Settings[mfg].Value });

            mfg = "tata";
            cars.Add(new car { Mfg = mfg, Address = config.AppSettings.Settings[mfg].Value });

            mfg = "toyota";
            cars.Add(new car { Mfg = mfg, Address = config.AppSettings.Settings[mfg].Value });

            mfg = "vauxhall";
            cars.Add(new car { Mfg = mfg, Address = config.AppSettings.Settings[mfg].Value });

            mfg = "volvo";
            cars.Add(new car { Mfg = mfg, Address = config.AppSettings.Settings[mfg].Value });

            return cars;
        }



    }
}

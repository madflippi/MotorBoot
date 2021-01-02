using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MotorBoot
{
    public partial class frmConfig : Form
    {
        public List<car> cars;
        public List<car> updatedcars;

        public frmConfig()
        {
            InitializeComponent();
        }

        private void btnVolvo_Click(object sender, EventArgs e)
        {
            string mfg;
            mfg  = "volvo";
            UpdateCarAddress(mfg);            
        }

        private void UpdateCarAddress(string mfg)
        {
            bool found = false;
            
            dlgConfig cfg = new dlgConfig();
            cfg.address = GetAddress(mfg);
            if (cfg.ShowDialog() == DialogResult.OK)
            {
                if (updatedcars is null)
                {
                    updatedcars = new List<car>();
                }

                //check if mfg exists in updated cars
                foreach (car x in updatedcars)
                {
                    if (x.Mfg == mfg)
                    {
                        found = true;
                        x.Address = cfg.address;
                        break;
                    }
                }

                if (!found)
                {
                    updatedcars.Add(new car { Mfg = mfg, Address = cfg.address });
                }
            }
        }

        private string GetAddress(string mfg)
        {
            string curaddress = String.Empty;
            foreach (car x in cars)
            {
                if (x.Mfg == mfg)
                {
                    curaddress = x.Address;
                    break;
                }
            }

            return curaddress;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (updatedcars != null)
            {
                Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);

                //save each updated cars to config
                foreach (car x in updatedcars)
                {
                    config.AppSettings.Settings[x.Mfg].Value = x.Address;
                    config.Save(ConfigurationSaveMode.Modified);
                    ConfigurationManager.RefreshSection("appSettings");
                }

                cars = Common.PopulateCars();
            }
        }

        private void btnAcura_Click(object sender, EventArgs e)
        {
            string mfg;
            mfg = "acura";
            UpdateCarAddress(mfg);
        }

        private void btnAudi_Click(object sender, EventArgs e)
        {
            string mfg;
            mfg = "audi";
            UpdateCarAddress(mfg);
        }

        private void btnBentley_Click(object sender, EventArgs e)
        {
            string mfg;
            mfg = "bentley";
            UpdateCarAddress(mfg);
        }

        private void btnBenz_Click(object sender, EventArgs e)
        {
            string mfg;
            mfg = "benz";
            UpdateCarAddress(mfg);
        }

        private void btnBMW_Click(object sender, EventArgs e)
        {
            string mfg;
            mfg = "bmw";
            UpdateCarAddress(mfg);
        }

        private void btnChrysler_Click(object sender, EventArgs e)
        {
            string mfg;
            mfg = "chrysler";
            UpdateCarAddress(mfg);
        }

        private void btnDaewoo_Click(object sender, EventArgs e)
        {
            string mfg;
            mfg = "daewoo";
            UpdateCarAddress(mfg);
        }

        private void btnDucati_Click(object sender, EventArgs e)
        {
            string mfg;
            mfg = "ducati";
            UpdateCarAddress(mfg);
        }

        private void btnFiat_Click(object sender, EventArgs e)
        {
            string mfg;
            mfg = "fiat";
            UpdateCarAddress(mfg);
        }

        private void btnFord_Click(object sender, EventArgs e)
        {
            string mfg;
            mfg = "ford";
            UpdateCarAddress(mfg);

        }

        private void btnGM_Click(object sender, EventArgs e)
        {
            string mfg;
            mfg = "gm";
            UpdateCarAddress(mfg);

        }

        private void btnHonda_Click(object sender, EventArgs e)
        {
            string mfg;
            mfg = "honda";
            UpdateCarAddress(mfg);

        }

        private void btnHyundaiCV_Click(object sender, EventArgs e)
        {
            string mfg;
            mfg = "hyundaicv";
            UpdateCarAddress(mfg);

        }

        private void btnHyundai_Click(object sender, EventArgs e)
        {
            string mfg;
            mfg = "hyundai";
            UpdateCarAddress(mfg);

        }

        private void btnInfiniti_Click(object sender, EventArgs e)
        {
            string mfg;
            mfg = "infiniti";
            UpdateCarAddress(mfg);

        }

        private void btnIsuzu_Click(object sender, EventArgs e)
        {
            string mfg;
            mfg = "isuzu";
            UpdateCarAddress(mfg);

        }

        private void btnJaguar_Click(object sender, EventArgs e)
        {
            string mfg;
            mfg = "jaguar";
            UpdateCarAddress(mfg);

        }

        private void btnKia_Click(object sender, EventArgs e)
        {
            string mfg;
            mfg = "kia";
            UpdateCarAddress(mfg);

        }

        private void btnLandRover_Click(object sender, EventArgs e)
        {
            string mfg;
            mfg = "landrover";
            UpdateCarAddress(mfg);

        }

        private void btnLexus_Click(object sender, EventArgs e)
        {
            string mfg;
            mfg = "lexus";
            UpdateCarAddress(mfg);

        }

        private void btnMazda_Click(object sender, EventArgs e)
        {
            string mfg;
            mfg = "mazda";
            UpdateCarAddress(mfg);

        }

        private void btnMini_Click(object sender, EventArgs e)
        {
            string mfg;
            mfg = "mini";
            UpdateCarAddress(mfg);

        }

        private void btnMitsubishi_Click(object sender, EventArgs e)
        {
            string mfg;
            mfg = "mitsubishi";
            UpdateCarAddress(mfg);

        }

        private void btnNissan_Click(object sender, EventArgs e)
        {
            string mfg;
            mfg = "nissan";
            UpdateCarAddress(mfg);

        }

        private void btnPorsche_Click(object sender, EventArgs e)
        {
            string mfg;
            mfg = "porsche";
            UpdateCarAddress(mfg);

        }

        private void btnRollsRoyce_Click(object sender, EventArgs e)
        {
            string mfg;
            mfg = "rollsroyce";
            UpdateCarAddress(mfg);

        }

        private void btnSaab_Click(object sender, EventArgs e)
        {
            string mfg;
            mfg = "saab";
            UpdateCarAddress(mfg);

        }

        private void btnScion_Click(object sender, EventArgs e)
        {
            string mfg;
            mfg = "scion";
            UpdateCarAddress(mfg);

        }

        private void btnSprinter_Click(object sender, EventArgs e)
        {
            string mfg;
            mfg = "sprinter";
            UpdateCarAddress(mfg);

        }

        private void btnSubaru_Click(object sender, EventArgs e)
        {
            string mfg;
            mfg = "subaru";
            UpdateCarAddress(mfg);

        }

        private void btnTata_Click(object sender, EventArgs e)
        {
            string mfg;
            mfg = "tata";
            UpdateCarAddress(mfg);

        }

        private void btnToyota_Click(object sender, EventArgs e)
        {
            string mfg;
            mfg = "toyota";
            UpdateCarAddress(mfg);

        }

        private void btnVauxhall_Click(object sender, EventArgs e)
        {
            string mfg;
            mfg = "vauxhall";
            UpdateCarAddress(mfg);

        }
    }
}

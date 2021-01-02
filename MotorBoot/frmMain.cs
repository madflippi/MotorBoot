using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace MotorBoot
{
    public partial class Main : Form
    {
        public List<car> cars;


        public Main()
        {
            InitializeComponent();
            cars = Common.PopulateCars();
            UpdateButtonSet();
        }

        private void configurationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmConfig config = new frmConfig();
            config.cars = cars;
            if (config.ShowDialog() == DialogResult.OK)
            {
                cars = config.cars;
                UpdateButtonSet();
            }
        }

        private void UpdateButtonSet()
        {

            TurnOffAllButtons();

            int x = 12;
            int y = 70;


            foreach (car c in cars)
            {
                if (c.Address != String.Empty)
                {
                    switch (c.Mfg)
                    {
                        case "acura":
                            btnAcura.Visible = true;
                            btnAcura.Location = new Point(x, y);
                            break;
                        case "audi":
                            btnAudi.Visible = true;
                            btnAudi.Location = new Point(x, y);
                            break;
                        case "bentley":
                            btnBentley.Visible = true;
                            btnBentley.Location = new Point(x, y);
                            break;
                        case "benz":
                            btnBenz.Visible = true;
                            btnBenz.Location = new Point(x, y);
                            break;
                        case "bmw":
                            btnBMW.Visible = true;
                            btnBMW.Location = new Point(x, y);
                            break;
                        case "chrysler":
                            btnChrysler.Visible = true;
                            btnChrysler.Location = new Point(x, y);
                            break;
                        case "daewoo":
                            btnDaewoo.Visible = true;
                            btnDaewoo.Location = new Point(x, y);
                            break;
                        case "ducatti":
                            btnDucati.Visible = true;
                            btnDucati.Location = new Point(x, y);
                            break;
                        case "fiat":
                            btnFiat.Visible = true;
                            btnFiat.Location = new Point(x, y);
                            break;
                        case "ford":
                            btnFord.Visible = true;
                            btnFord.Location = new Point(x, y);
                            break;
                        case "gm":
                            btnGM.Visible = true;
                            btnGM.Location = new Point(x, y);
                            break;
                        case "honda":
                            btnHonda.Visible = true;
                            btnHonda.Location = new Point(x, y);
                            break;
                        case "hyundaicv":
                            btnHyundaiCV.Visible = true;
                            btnHyundaiCV.Location = new Point(x, y);
                            break;
                        case "hyundai":
                            btnHyundai.Visible = true;
                            btnHyundai.Location = new Point(x, y);
                            break;
                        case "infiniti":
                            btnInfiniti.Visible = true;
                            btnInfiniti.Location = new Point(x, y);
                            break;
                        case "isuzu":
                            btnIsuzu.Visible = true;
                            btnIsuzu.Location = new Point(x, y);
                            break;
                        case "jaguar":
                            btnJaguar.Visible = true;
                            btnJaguar.Location = new Point(x, y);
                            break;
                        case "kia":
                            btnKia.Visible = true;
                            btnKia.Location = new Point(x, y);
                            break;
                        case "landrover":
                            btnLandRover.Visible = true;
                            btnLandRover.Location = new Point(x, y);
                            break;
                        case "lexus":
                            btnLexus.Visible = true;
                            btnLexus.Location = new Point(x, y);
                            break;
                        case "mazda":
                            btnMazda.Visible = true;
                            btnMazda.Location = new Point(x, y);
                            break;
                        case "mini":
                            btnMini.Visible = true;
                            btnMini.Location = new Point(x, y);
                            break;
                        case "mitsubishi":
                            btnMitsubishi.Visible = true;
                            btnMitsubishi.Location = new Point(x, y);
                            break;
                        case "nissan":
                            btnNissan.Visible = true;
                            btnNissan.Location = new Point(x, y);
                            break;
                        case "porsche":
                            btnPorsche.Visible = true;
                            btnPorsche.Location = new Point(x, y);
                            break;
                        case "rollsroyce":
                            btnRollsRoyce.Visible = true;
                            btnRollsRoyce.Location = new Point(x, y);
                            break;
                        case "saab":
                            btnSaab.Visible = true;
                            btnSaab.Location = new Point(x, y);
                            break;
                        case "scion":
                            btnScion.Visible = true;
                            btnScion.Location = new Point(x, y);
                            break;
                        case "sprinter":
                            btnSprinter.Visible = true;
                            btnSprinter.Location = new Point(x, y);
                            break;
                        case "subaru":
                            btnSubaru.Visible = true;
                            btnSubaru.Location = new Point(x, y);
                            break;
                        case "tata":
                            btnTata.Visible = true;
                            btnTata.Location = new Point(x, y);
                            break;
                        case "toyota":
                            btnToyota.Visible = true;
                            btnToyota.Location = new Point(x, y);
                            break;
                        case "vauxhall":
                            btnVauxhall.Visible = true;
                            btnVauxhall.Location = new Point(x, y);
                            break;
                        case "volvo":
                            btnVolvo.Visible = true;
                            btnVolvo.Location = new Point(x, y);
                            break;
                    }

                    y = y + 54;
                    if (y > 394)
                    {
                        x = x + 123;
                        y = 70;
                    }

                }
            }

        }

        private void TurnOffAllButtons()
        {
            btnAcura.Visible = false;
            btnAudi.Visible = false;
            btnBentley.Visible = false;
            btnBenz.Visible = false;
            btnBMW.Visible = false;
            btnChrysler.Visible = false;
            btnDaewoo.Visible = false;
            btnDucati.Visible = false;
            btnFiat.Visible = false;
            btnFord.Visible = false;
            btnGM.Visible = false;
            btnHonda.Visible = false;
            btnHyundaiCV.Visible = false;
            btnHyundai.Visible = false;
            btnInfiniti.Visible = false;
            btnIsuzu.Visible = false;
            btnJaguar.Visible = false;
            btnKia.Visible = false;
            btnLandRover.Visible = false;
            btnLexus.Visible = false;
            btnMazda.Visible = false;
            btnMini.Visible = false;
            btnMitsubishi.Visible = false;
            btnNissan.Visible = false;
            btnPorsche.Visible = false;
            btnRollsRoyce.Visible = false;
            btnSaab.Visible = false;
            btnScion.Visible = false;
            btnSprinter.Visible = false;
            btnSubaru.Visible = false;
            btnTata.Visible = false;
            btnToyota.Visible = false;
            btnVauxhall.Visible = false;
            btnVolvo.Visible = false;
            
        }

        private void btnTest_Click(object sender, EventArgs e)
        {
            RunBCDEdit("");

            Reboot();
        }

        private void DoWork(string address)
        {
            RunBCDEdit(address);

            Reboot();
        }

        private void Reboot()
        {
            var cmd = new ProcessStartInfo("shutdown.exe", "-r -t 0");
            cmd.CreateNoWindow = true;
            cmd.UseShellExecute = false;
            cmd.ErrorDialog = false;
            Process.Start(cmd);
        }

        private void  RunBCDEdit(string address)
        {
            /*
                ## How to change the boot sequence for the next reboot?
                ## At the command prompt, type:
                ## bcdedit /bootsequence {ID} {ID} {ID} …

                ## The following command sets the specified operating system as the default for the next restart. After that restart, it will be reset to DISPLAYORDER.
                bcdedit /bootsequence {cbd971bf-b7b8-4885-951a-fa03044f5d71}
            */
            //setup new bootsequence
            //address = "2626376a - e111 - 11ea - be43 - f01dca5cfc77"; //test code

            //MessageBox.Show(address);

            ProcessStartInfo processStartInfo = new ProcessStartInfo("runas.exe", "/user:Administrator \" cmd /k arp -d \""); // same as "netsh interface ip delete arpcache"
            processStartInfo.RedirectStandardOutput = true;
            processStartInfo.Arguments = @"/C bcdedit /bootsequence {" + address + "}";

            //MessageBox.Show(processStartInfo.Arguments.ToString());

            //processStartInfo.CreateNoWindow = true;
            //processStartInfo.WindowStyle = ProcessWindowStyle.Hidden;
            processStartInfo.UseShellExecute = false;
            processStartInfo.StandardOutputEncoding = Encoding.Default;
            Process.Start(processStartInfo);            
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

        private void btnAcura_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to reboot system?", "Confirmation", MessageBoxButtons.YesNo) == DialogResult.No)
                return;

            DoWork(GetAddress("acura"));
        }

        private void btnAudi_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to reboot system?", "Confirmation", MessageBoxButtons.YesNo) == DialogResult.No)
                return;

            DoWork(GetAddress("audi"));
        }

        private void btnBentley_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to reboot system?", "Confirmation", MessageBoxButtons.YesNo) == DialogResult.No)
                return;

            DoWork(GetAddress("bentley"));
        }

        private void btnBenz_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to reboot system?", "Confirmation", MessageBoxButtons.YesNo) == DialogResult.No)
                return;

            DoWork(GetAddress("benz"));
        }

        private void btnBMW_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to reboot system?", "Confirmation", MessageBoxButtons.YesNo) == DialogResult.No)
                return;

            DoWork(GetAddress("bmw"));
        }

        private void btnChrysler_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to reboot system?", "Confirmation", MessageBoxButtons.YesNo) == DialogResult.No)
                return;

            DoWork(GetAddress("chrysler"));
        }

        private void btnDaewoo_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to reboot system?", "Confirmation", MessageBoxButtons.YesNo) == DialogResult.No)
                return;

            DoWork(GetAddress("daewoo"));
        }

        private void btnDucati_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to reboot system?", "Confirmation", MessageBoxButtons.YesNo) == DialogResult.No)
                return;

            DoWork(GetAddress("ducati"));
        }

        private void btnFiat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to reboot system?", "Confirmation", MessageBoxButtons.YesNo) == DialogResult.No)
                return;

            DoWork(GetAddress("fiat"));
        }

        private void btnFord_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to reboot system?", "Confirmation", MessageBoxButtons.YesNo) == DialogResult.No)
                return;

            DoWork(GetAddress("ford"));
        }

        private void btnGM_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to reboot system?", "Confirmation", MessageBoxButtons.YesNo) == DialogResult.No)
                return;

            DoWork(GetAddress("gm"));
        }

        private void btnHonda_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to reboot system?", "Confirmation", MessageBoxButtons.YesNo) == DialogResult.No)
                return;

            DoWork(GetAddress("honda"));
        }

        private void btnHyundaiCV_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to reboot system?", "Confirmation", MessageBoxButtons.YesNo) == DialogResult.No)
                return;

            DoWork(GetAddress("hyundaicv"));
        }

        private void btnHyundai_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to reboot system?", "Confirmation", MessageBoxButtons.YesNo) == DialogResult.No)
                return;

            DoWork(GetAddress("hyundai"));
        }

        private void btnInfiniti_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to reboot system?", "Confirmation", MessageBoxButtons.YesNo) == DialogResult.No)
                return;

            DoWork(GetAddress("infiniti"));
        }

        private void btnIsuzu_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to reboot system?", "Confirmation", MessageBoxButtons.YesNo) == DialogResult.No)
                return;

            DoWork(GetAddress("isuzu"));
        }

        private void btnJaguar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to reboot system?", "Confirmation", MessageBoxButtons.YesNo) == DialogResult.No)
                return;

            DoWork(GetAddress("jaguar"));
        }

        private void btnKia_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to reboot system?", "Confirmation", MessageBoxButtons.YesNo) == DialogResult.No)
                return;

            DoWork(GetAddress("kia"));
        }

        private void btnLandRover_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to reboot system?", "Confirmation", MessageBoxButtons.YesNo) == DialogResult.No)
                return;

            DoWork(GetAddress("landrover"));
        }

        private void btnLexus_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to reboot system?", "Confirmation", MessageBoxButtons.YesNo) == DialogResult.No)
                return;

            DoWork(GetAddress("lexus"));
        }

        private void btnMazda_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to reboot system?", "Confirmation", MessageBoxButtons.YesNo) == DialogResult.No)
                return;

            DoWork(GetAddress("mazda"));
        }

        private void btnMini_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to reboot system?", "Confirmation", MessageBoxButtons.YesNo) == DialogResult.No)
                return;

            DoWork(GetAddress("mini"));
        }

        private void btnMitsubishi_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to reboot system?", "Confirmation", MessageBoxButtons.YesNo) == DialogResult.No)
                return;

            DoWork(GetAddress("mitsubishi"));
        }

        private void btnNissan_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to reboot system?", "Confirmation", MessageBoxButtons.YesNo) == DialogResult.No)
                return;

            DoWork(GetAddress("nissan"));
        }

        private void btnPorsche_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to reboot system?", "Confirmation", MessageBoxButtons.YesNo) == DialogResult.No)
                return;

            DoWork(GetAddress("porsche"));
        }

        private void btnRollsRoyce_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to reboot system?", "Confirmation", MessageBoxButtons.YesNo) == DialogResult.No)
                return;

            DoWork(GetAddress("rollsroyce"));
        }

        private void btnSaab_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to reboot system?", "Confirmation", MessageBoxButtons.YesNo) == DialogResult.No)
                return;

            DoWork(GetAddress("saab"));
        }

        private void btnScion_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to reboot system?", "Confirmation", MessageBoxButtons.YesNo) == DialogResult.No)
                return;

            DoWork(GetAddress("scion"));
        }

        private void btnSprinter_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to reboot system?", "Confirmation", MessageBoxButtons.YesNo) == DialogResult.No)
                return;

            DoWork(GetAddress("sprinter"));
        }

        private void btnSubaru_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to reboot system?", "Confirmation", MessageBoxButtons.YesNo) == DialogResult.No)
                return;

            DoWork(GetAddress("subaru"));
        }

        private void btnTata_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to reboot system?", "Confirmation", MessageBoxButtons.YesNo) == DialogResult.No)
                return;

            DoWork(GetAddress("tata"));
        }

        private void btnToyota_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to reboot system?", "Confirmation", MessageBoxButtons.YesNo) == DialogResult.No)
                return;

            DoWork(GetAddress("toyota"));
        }

        private void btnVauxhall_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to reboot system?", "Confirmation", MessageBoxButtons.YesNo) == DialogResult.No)
                return;

            DoWork(GetAddress("vauxhall"));
        }

        private void btnVolvo_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to reboot system?", "Confirmation", MessageBoxButtons.YesNo) == DialogResult.No)
                return;

            DoWork(GetAddress("volvo"));
        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("When configuring partition address, do not add brackets as part of address. Example: 2626376a - e111 - 11ea - be43 - f01dca5cfc77");
        }
    }
}

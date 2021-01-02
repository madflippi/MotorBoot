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

        private void DoWork()
        {
            RunBCDEdit("");

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
            ProcessStartInfo processStartInfo = new ProcessStartInfo("runas.exe", "/user:Administrator \" cmd /k arp -d \""); // same as "netsh interface ip delete arpcache"
            processStartInfo.RedirectStandardOutput = true;
            processStartInfo.Arguments = @"/C bcdedit /bootsequence {" + address + "}";
            //processStartInfo.CreateNoWindow = true;
            //processStartInfo.WindowStyle = ProcessWindowStyle.Hidden;
            processStartInfo.UseShellExecute = false;
            processStartInfo.StandardOutputEncoding = Encoding.Default;
            Process.Start(processStartInfo);            
        }
    }
}

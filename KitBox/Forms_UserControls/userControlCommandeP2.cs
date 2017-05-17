using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reflection;

namespace KitBox
{
    public partial class userControlCommandeP2 : UserControl
    {
        OrderManager om;
        editor edit = new editor();

        DatabaseManager dbm = new DatabaseManager();
        int i = 1;
        int index = 0;



        public userControlCommandeP2(OrderManager om)
        {
            this.om = om;
            InitializeComponent();
        }

        private void userControlCommandeP2_Load(object sender, EventArgs e)
        {

            om.NewUnit();

            comboHauteur.SelectedValue = 1;
            comboHauteur.SelectedText = "32cm";
            comboHauteur.Text = "32cm";
            EventHandler ev = new EventHandler(comboHauteur_SelectedIndexChanged);

            comboPartie.SelectedValue = 1;
            comboPartie.SelectedText = "Portes";
            comboPartie.Text = "Portes";

            panelShelf7.Visible = false;
            btnGoToShelf7.Visible = false;

            panelShelf6.Visible = false;
            btnGoToShelf6.Visible = false;

            panelShelf5.Visible = false;
            btnGoToShelf5.Visible = false;

            panelShelf4.Visible = false;
            btnGoToShelf4.Visible = false;

            panelShelf3.Visible = false;
            btnGoToShelf3.Visible = false;

            panelShelf2.Visible = false;
            btnGoToShelf2.Visible = false;

            panelPartiesPanelHB.Visible = false;
            panelPartiesPanelGD.Visible = false;
            panelPartiesPanelAR.Visible = false;


            lblDepth.Text = om.getCabinetDimensions()[1].ToString() + " cm";
            lblWidth.Text = om.getCabinetDimensions()[0].ToString() + " cm";

            reloadCabinet();

            if (!om.getCommand().GetCabinet().getCanGetDoors())
            {
                checkBoxDoors.Checked = true;
                checkBoxDoors.Visible = false;
            }
        }

        private void btnAddShelf_Click(object sender, EventArgs e)
        {
            string temp = om.getUnitHeight(i-1).ToString();
            if (om.getUnitHeight(i-1).ToString().Equals("0"))
            {
                MessageBox.Show("Veuillez indiquer une hauteur pour votre dernier unit.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                om.NewUnit();
                index++;
                i++;
                comboHauteur.SelectedValue = 1;
                comboHauteur.SelectedText = "32cm";
                comboHauteur.Text = "32cm";
                EventHandler ev = new EventHandler(comboHauteur_SelectedIndexChanged);
                int _height = 32;
                for (int count = 0; count < i-1; count++)
                {
                    _height += om.getUnitHeight(count);
                }
                lblHeight.Text = _height.ToString() + " cm";
                Panel p = (Panel)this.Controls.Find(("panelShelf" + i.ToString()), true).FirstOrDefault();
                p.Visible = true;

                Button b = (Button)this.Controls.Find(("btnGoToShelf" + i.ToString()), true).FirstOrDefault();
                b.Visible = true;

                var value = Properties.Resources.ResourceManager.GetObject("DLWDRW", Properties.Resources.Culture);
                panelCurrentShelf.BackgroundImage = (System.Drawing.Image)value;
                p.BackgroundImage = (System.Drawing.Image)value;

                if (i < 7)
                {
                    btnAddShelf.Parent = p;
                    Type thisType = this.GetType();
                    MethodInfo theMethod = thisType.GetMethod("btnGoToShelf" + i.ToString() + "_Click");
                    EventArgs[] arr1 = new EventArgs[] { EventArgs.Empty, EventArgs.Empty };
                    theMethod.Invoke(this, arr1);
                }
                else if (i == 7)
                {
                    Type thisType = this.GetType();
                    MethodInfo theMethod = thisType.GetMethod("btnGoToShelf" + i.ToString() + "_Click");
                    EventArgs[] arr1 = new EventArgs[] { EventArgs.Empty, EventArgs.Empty };
                    theMethod.Invoke(this, arr1);
                }
                else
                {
                    btnAddShelf.Visible = false;
                }

                if (!om.getCommand().GetCabinet().getCanGetDoors())
                {
                    checkBoxDoors.Checked = true;
                    checkBoxDoors.Visible = false;
                }
            }
        }

        public void btnGoToShelf1_Click(object sender, EventArgs e)
        {
            index = 0;
            lblWhatShelf.Text = "Etage 1";
            changeCombo(index);
            unselectAll();
            btnGoToShelf1.BackgroundImage = Properties.Resources.color1;
            reloadCabinet();
       
        }

        public void btnGoToShelf2_Click(object sender, EventArgs e)
        {
            index = 1;
            lblWhatShelf.Text = "Etage 2";
            changeCombo(index);
            unselectAll();
            btnGoToShelf2.BackgroundImage = Properties.Resources.color2;
            reloadCabinet();

        }

        public void btnGoToShelf3_Click(object sender, EventArgs e)
        {
            index = 2;
            lblWhatShelf.Text = "Etage 3";
            changeCombo(index);

            unselectAll();
            btnGoToShelf3.BackgroundImage = Properties.Resources.color3;
            reloadCabinet();

        }

        public void btnGoToShelf4_Click(object sender, EventArgs e)
        {
            index = 3;
            lblWhatShelf.Text = "Etage 4";
            changeCombo(index);

            unselectAll();
            btnGoToShelf4.BackgroundImage = Properties.Resources.color4;
            reloadCabinet();

        }

        public void btnGoToShelf5_Click(object sender, EventArgs e)
        {
            index = 4;
            lblWhatShelf.Text = "Etage 5";
            changeCombo(index);

            unselectAll();
            btnGoToShelf5.BackgroundImage = Properties.Resources.color5;
            reloadCabinet();

        }

        public void btnGoToShelf6_Click(object sender, EventArgs e)
        {
            index = 5;
            lblWhatShelf.Text = "Etage 6";
            changeCombo(index);

            unselectAll();
            btnGoToShelf6.BackgroundImage = Properties.Resources.color6;
            reloadCabinet();

        }

        public void btnGoToShelf7_Click(object sender, EventArgs e)
        {
            index = 6;
            lblWhatShelf.Text = "Etage 7";
            changeCombo(index);

            unselectAll();
            btnGoToShelf7.BackgroundImage = Properties.Resources.color7;
            reloadCabinet();

        }

        void changeCombo(int index)
        {
            comboPartie.SelectedValue = 1;
            comboPartie.SelectedText = "Portes";
            comboPartie.Text = "Portes";


            if (om.getUnitHeight(index).ToString().Equals("0"))
            {
                comboHauteur.SelectedValue = null;
                comboHauteur.SelectedText = null;
                comboHauteur.Text = null;
            }
            else
            {
                comboHauteur.SelectedValue = om.getUnitHeight(index).ToString() + "cm";
                comboHauteur.Text = om.getUnitHeight(index).ToString() + "cm";
            }
        }

        private void unselectAll()
        {
            btnGoToShelf1.BackgroundImage = Properties.Resources.grey1;
            btnGoToShelf2.BackgroundImage = Properties.Resources.grey2;
            btnGoToShelf3.BackgroundImage = Properties.Resources.grey3;
            btnGoToShelf4.BackgroundImage = Properties.Resources.grey4;
            btnGoToShelf5.BackgroundImage = Properties.Resources.grey5;
            btnGoToShelf6.BackgroundImage = Properties.Resources.grey6;
            btnGoToShelf7.BackgroundImage = Properties.Resources.grey7;

        }



        private void btnBack_Click(object sender, EventArgs e)
        {
            om.ResetCabinet();
            this.Controls.Clear();
            this.Controls.Add(new userControlCommandeP1(om));
        }

        private void comboHauteur_SelectedIndexChanged(object sender, EventArgs e)
        {
            string temp = comboHauteur.Text;
            if (!comboHauteur.Text.Equals(""))
            om.setCasierHeight(index, Convert.ToInt32(comboHauteur.Text.Replace("cm","")));

            int _height = 0;
            for(int count = 0; count < i; count++)
            {
                _height += om.getUnitHeight(count);
            }
            lblHeight.Text = _height.ToString()+" cm";
        }

        private void comboPartie_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboPartie.SelectedIndex == 0)
            {
                hidePartiesPanels();
                panelPartiePortes.Visible = true;

            }
            if (comboPartie.SelectedIndex == 1)
            {
                hidePartiesPanels();
                panelPartiesPanelHB.Visible = true;

            }
            if (comboPartie.SelectedIndex == 2)
            {
                hidePartiesPanels();
                panelPartiesPanelGD.Visible = true;

            }
            if (comboPartie.SelectedIndex == 3)
            {
                hidePartiesPanels();
                panelPartiesPanelAR.Visible = true;

            }

        }
        private void hidePartiesPanels()
        {
            panelPartiePortes.Visible = false;
            panelPartiesPanelHB.Visible = false;
            panelPartiesPanelGD.Visible = false;
            panelPartiesPanelAR.Visible = false;

        }



        private void reloadCabinet()
        {
            //var value = Properties.Resources.ResourceManager.GetObject("test2", Properties.Resources.Culture);
            //panelCurrentShelf.BackgroundImage = (System.Drawing.Image)value;
            if (!om.getCabinetColor().Equals("nocolor"))
            {
                lblP1.Visible = false;
                lblP2.Visible = false;
                btnP11.Visible = false;
                btnP12.Visible = false;
                btnP13.Visible = false;
                btnP21.Visible = false;
                btnP22.Visible = false;
                btnP23.Visible = false;

                int count = comboPartie.Items.Count;
                for (int y = 1; y < count; y++)
                {
                    comboPartie.Items.RemoveAt(1);
                }
            }
            for(int y = 1; y < i+1; y++)
            {
                string imgString="";
                Dictionary<string, IElement> _elements = om.getCommand().GetCabinet().GetUnit(y-1).GetElements();


                //Panel Top
                if (_elements.ContainsKey("PH"))
                {
                    if (_elements["PH"].Color.Contains("White"))
                        imgString += "phW";
                    else
                        imgString += "phB";

                }

                //Panel Bot
                if (_elements.ContainsKey("PB"))
                {
                    if (_elements["PB"].Color.Contains("White"))
                        imgString += "pbW";
                    else
                        imgString += "pbB";

                }

                //Panel Right
                if (_elements.ContainsKey("PR"))
                {
                    if (_elements["PR"].Color.Contains("White"))
                        imgString += "prW";
                    else
                        imgString += "prB";

                }

                //Door Left
                if (_elements.ContainsKey("DL"))
                {
                    if (_elements["DL"].Color.Contains("White"))
                        imgString += "dlW";
                    else if (_elements["DL"].Color.Contains("Brown"))
                        imgString += "dlB";
                    else
                        imgString += "dlG";
                }
                else
                    imgString += "dlN";

                //Door Right
                if (_elements.ContainsKey("DR"))
                {
                    if (_elements["DR"].Color.Contains("White"))
                        imgString += "drW";
                    else if (_elements["DR"].Color.Contains("Brown"))
                        imgString += "drB";
                    else
                        imgString += "drG";
                }
                else
                    imgString += "drN";

                var value = Properties.Resources.ResourceManager.GetObject(imgString, Properties.Resources.Culture);

                if (y-1 == index)
                {
                    panelCurrentShelf.BackgroundImage = (System.Drawing.Image)value;

                }
                Panel p = (Panel)this.Controls.Find(("panelShelf" + y.ToString()), true).FirstOrDefault();
                    p.BackgroundImage = (System.Drawing.Image)value;
                

            }

            Dictionary<string, IElement> _element = om.getCommand().GetCabinet().GetUnit(index).GetElements();
            if (_element.ContainsKey("DR"))
                checkBoxDoors.Checked = false;
            else
                checkBoxDoors.Checked = true;


            this.om.getCommand().GetCabinet().GenerateCode();
            reloadSliderLocation();
            List<Dictionary<string, int>> stock = checkStock();
            double price = calcPrice(stock[1]);
            lblPrice.Text = price.ToString()+ " €";
        }

        private void checkBoxDoors_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxDoors.Checked == true)
            {
                lblP1.Visible = false;
                lblP2.Visible = false;
                btnP11.Visible = false;
                btnP12.Visible = false;
                btnP13.Visible = false;
                btnP21.Visible = false;
                btnP22.Visible = false;
                btnP23.Visible = false;
                om.getCommand().GetCabinet().GetUnit(index).GetElements().Remove("DL");
                om.getCommand().GetCabinet().GetUnit(index).GetElements().Remove("DR");

            }
            else
            {
                lblP1.Visible = true;
                lblP2.Visible = true;
                btnP11.Visible = true;
                btnP12.Visible = true;
                btnP13.Visible = true;
                btnP21.Visible = true;
                btnP22.Visible = true;
                btnP23.Visible = true;
                try
                {
                    om.getCommand().GetCabinet().GetUnit(index).GenerateDoors();
                }
                catch(Exception exception)
                {

                }

            }
            reloadCabinet();
        }

        //Door Left/Right Color Buttons

        private void btnP11_Click(object sender, EventArgs e)
        {
            om.setDoorColors(index, "DL", btnP11.BackColor.ToString());
            reloadCabinet();
        }

        private void btnP12_Click(object sender, EventArgs e)
        {
            om.setDoorColors(index, "DL", btnP12.BackColor.ToString());
            reloadCabinet();
        }

        private void btnP13_Click(object sender, EventArgs e)
        {
            om.setDoorColors(index, "DL", btnP13.BackColor.ToString());
            reloadCabinet();
        }

        private void btnP21_Click(object sender, EventArgs e)
        {
            om.setDoorColors(index, "DR", btnP21.BackColor.ToString());
            reloadCabinet();
        }

        private void btnP22_Click(object sender, EventArgs e)
        {
            om.setDoorColors(index, "DR", btnP22.BackColor.ToString());
            reloadCabinet();
        }

        private void btnP23_Click(object sender, EventArgs e)
        {
            om.setDoorColors(index, "DR", btnP23.BackColor.ToString());
            reloadCabinet();
        }


        //Panel Top/Bot Color Buttons
        private void btnPH1_Click(object sender, EventArgs e)
        {
            om.setPanelColors(index, "PH", btnPH1.BackColor.ToString());
            reloadCabinet();
        }

        private void btnPH2_Click(object sender, EventArgs e)
        {
            om.setPanelColors(index, "PH", btnPH2.BackColor.ToString());
            reloadCabinet();
        }

        private void btnPB1_Click(object sender, EventArgs e)
        {
            om.setPanelColors(index, "PB", btnPB1.BackColor.ToString());
            reloadCabinet();
        }

        private void btnPB2_Click(object sender, EventArgs e)
        {
            om.setPanelColors(index, "PB", btnPB2.BackColor.ToString());
            reloadCabinet();
        }

        //Panel Left/Right Color Buttons

        private void btnPanelG1_Click(object sender, EventArgs e)
        {
            om.setPanelColors(index, "PL", btnPanelG1.BackColor.ToString());
            reloadCabinet();
        }

        private void btnPanelG2_Click(object sender, EventArgs e)
        {
            om.setPanelColors(index, "PL", btnPanelG2.BackColor.ToString());
            reloadCabinet();
        }

        private void btnPanelD1_Click(object sender, EventArgs e)
        {
            om.setPanelColors(index, "PR", btnPanelD1.BackColor.ToString());
            reloadCabinet();
        }

        private void btnPanelD2_Click(object sender, EventArgs e)
        {
            om.setPanelColors(index, "PR", btnPanelD2.BackColor.ToString());
            reloadCabinet();
        }


        //Panel Back Color Buttons

        private void btnPanelAR1_Click(object sender, EventArgs e)
        {
            om.setPanelColors(index, "PAR", btnPanelAR1.BackColor.ToString());

            reloadCabinet();
        }

        private void btnPanelAR2_Click(object sender, EventArgs e)
        {
            om.setPanelColors(index, "PAR", btnPanelAR2.BackColor.ToString());
            reloadCabinet();
        }

        private void setSliderLocation(Button button, Panel panel)
        {
            panel.Location = new Point(button.Location.X, panel.Location.Y);

        }

        private void reloadSliderLocation()
        {
            Dictionary<string, IElement> _element = om.getCommand().GetCabinet().GetUnit(index).GetElements();

            //Back Panel
            if (_element["PAR"].Color.Contains("White"))
                setSliderLocation(btnPanelAR1, sliderPAR1);
            else
                setSliderLocation(btnPanelAR2, sliderPAR1);

            //Left Panel
            if (_element["PL"].Color.Contains("White"))
                setSliderLocation(btnPanelG1, sliderPG);
            else
                setSliderLocation(btnPanelG2, sliderPG);

            //Right Panel
            if (_element["PR"].Color.Contains("White"))
                setSliderLocation(btnPanelD1, sliderPD);
            else
                setSliderLocation(btnPanelD2, sliderPD);

            //Top Panel
            if (_element["PH"].Color.Contains("White"))
                setSliderLocation(btnPH1, sliderPH);
            else
                setSliderLocation(btnPH2, sliderPH);

            //Bot Panel
            if (_element["PB"].Color.Contains("White"))
                setSliderLocation(btnPB1, sliderPB);
            else
                setSliderLocation(btnPB2, sliderPB);

            //Left Door
            if (_element.ContainsKey("DL"))
            {
                sliderDL.Visible = true;
                if (_element["DL"].Color.Contains("White"))
                    setSliderLocation(btnP11, sliderDL);
                else if (_element["DL"].Color.Contains("Brown"))
                    setSliderLocation(btnP12, sliderDL);
                else
                    setSliderLocation(btnP13, sliderDL);
            }
            else
                sliderDL.Visible = false;

            //Right Door
            if (_element.ContainsKey("DR"))
            {
                sliderDR.Visible = true;
                if (_element["DR"].Color.Contains("White"))
                    setSliderLocation(btnP21, sliderDR);
                else if (_element["DR"].Color.Contains("Brown"))
                    setSliderLocation(btnP22, sliderDR);
                else
                    setSliderLocation(btnP23, sliderDR);
            }
            else
                sliderDR.Visible = false;


        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (i > 1)
            {
                this.om.getCommand().GetCabinet().RemoveUnit(index);
                i--;
                index = i - 1;
                hidePanels();
                for(int x=1; x < i+1; x++)
                {
                    Panel p = (Panel)this.Controls.Find(("panelShelf" + x.ToString()), true).FirstOrDefault();
                    p.Visible = true;

                    btnAddShelf.Parent = p;


                    Button b = (Button)this.Controls.Find(("btnGoToShelf" + x.ToString()), true).FirstOrDefault();
                    b.Visible = true;
                }

                Type thisType = this.GetType();
                MethodInfo theMethod = thisType.GetMethod("btnGoToShelf" + i.ToString() + "_Click");
                EventArgs[] arr1 = new EventArgs[] { EventArgs.Empty, EventArgs.Empty };
                theMethod.Invoke(this, arr1);

                reloadCabinet();
            }
        }
        private void hidePanels()
        {
            for (int x = 1; x < 8; x++)
            {
                Panel p = (Panel)this.Controls.Find(("panelShelf" + x.ToString()), true).FirstOrDefault();
                p.Visible = false;

                Button b = (Button)this.Controls.Find(("btnGoToShelf" + x.ToString()), true).FirstOrDefault();
                b.Visible = false;
            }
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("Voulez-vous valider la commande?", "Validation", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
           

            this.BackgroundImage = null;
            this.Controls.Clear();
            this.Controls.Add(new userControlClient(om));
        }

        private List<Dictionary<string,int>> checkStock()
        {
            List<Dictionary<string, int>> L = new List<Dictionary<string, int>>();
            Dictionary<string, int> dicOfElements = om.getCommand().GetCabinet().getDicOfElements();
            Dictionary<string, int> missingElements = dbm.ElementsInStock(dicOfElements)[1];
            Dictionary<string, int> dispElements = dbm.ElementsInStock(dicOfElements)[0];
            edit.printMissing(missingElements);
            L.Add(dicOfElements);
            L.Add(dispElements);
            L.Add(missingElements);

            if (missingElements.Count()>0)
            {
                lblMissing.Visible = true;
                btnInfo.Visible = true;
            }
            else
            {
                lblMissing.Visible = false;
                btnInfo.Visible = false;
            }
            return L;
        }
        private double calcPrice(Dictionary<string, int> all)
        {
            om.getCommand().setPrice(dbm.TotalPrice(all));
            return om.getCommand().getPrice();
        }

        

       


        private void btnInfo_Click(object sender, EventArgs e)
        {
            txtViewer f2 = new txtViewer("CommandeP2",null);
            f2.userControlCommandeP2 = this;
            f2.ShowDialog();
        }

        private void panelCurrentShelf_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

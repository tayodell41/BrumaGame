/**********************************************************
* frmBrumaGame.cs
*
* Original game by Brumafriend can be found here: https://github.com/brumafriend/BrumaGame
* This form handles the main game functions for BrumaGame
*
* Author: Taylor O'Dell
* Date Created: 11/18/17
* Last Modified by: Taylor O'Dell
* Date Last Modified: 11/19/17
* Part of: BrumaGame
*/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BrumaGame
{
    public partial class frmBrumaGame : Form
    {
        /*------------------------------------------------------------------------------------------
         * Form Initializers
         -----------------------------------------------------------------------------------------*/
        public frmBrumaGame fbg;
        public Random rndGen = new Random();
        public String countryName = "";
        public bool nameSet = false;
        public bool ALIVE = true;
        public bool DEAD = false;
        public int startArmy = 5000;
        public int startPop = 25000;
        public int startMoney = 50000;
        public int startTension = 10;
        public int userArmy, usaArmy, ukArmy, germanyArmy, russiaArmy, franceArmy;
        public int userPop, userMoney, userTension;
        public bool userStatus, usaStatus, ukStatus, germanyStatus, russiaStatus, franceStatus;
        public frmBrumaGame()
        {
            InitializeComponent();
            fbg = this;
        }

        /*------------------------------------------------------------------------------------------
         * Form Handlers
         -----------------------------------------------------------------------------------------*/
        private void frmBrumaGame_Load(object sender, EventArgs e)
        {
            alignLabels();
            hideAllTheThings();
        }

        private void frmBrumaGame_SizeChanged(object sender, EventArgs e)
        {
            alignLabels();
        }

        /*------------------------------------------------------------------------------------------
         * Button Handlers
         -----------------------------------------------------------------------------------------*/
        private void btnNewGame_Click(object sender, EventArgs e)
        {
            initGame();

            if (countryName == "")
            {
                return;
            }

            showButtons();

            startGame();

            setLabels();
        }
        private void btnQuit_Click(object sender, EventArgs e)
        {
            Close();
        }

        /*------------------------------------------------------------------------------------------
         * Game Functions
         -----------------------------------------------------------------------------------------*/
        /*---------------------------------------------
        * initGame()
        * 
        * Prompt user for country name and set up all starting
        *  values for each country
        --------------------------------------------*/
        private void initGame()
        {
            using (var fgu = new frmGetUsername(fbg))
            {
                fgu.ShowDialog();
            }
            lblName.Text = countryName;
        }

        private void startGame()
        {
            // set army sizes
            userArmy = startArmy + rndGen.Next(2000);
            usaArmy = startArmy + rndGen.Next(2000);
            ukArmy = startArmy + rndGen.Next(500); 
            germanyArmy = startArmy + rndGen.Next(1000);
            russiaArmy = startArmy + rndGen.Next(2000);
            franceArmy = startArmy + rndGen.Next(500);
            // set population
            userPop = startPop + rndGen.Next(10000);
            // set da monies
            userMoney = startMoney + rndGen.Next(10000);
            // set tension
            userTension = startTension;
            // set alive-ness
            userStatus = ALIVE;
            usaStatus = ALIVE;
            ukStatus = ALIVE;
            germanyStatus = ALIVE;
            russiaStatus = ALIVE;
            franceStatus = ALIVE;
            // make the labels show all the correct values
        }

        /*------------------------------------------------------------------------------------------
         * Other Functions
         -----------------------------------------------------------------------------------------*/
        /*-------------------------------------------------
        * alignLabels()
        * 
        * Aligns all the labels within the splitcontainers
        -------------------------------------------------*/
        private void alignLabels()
        {
            // your country panel 1
            lblCountryNameLabel.Location = new Point(0, ((lblCountryNameLabel.Parent.ClientSize.Height / 5) * 0) - (lblCountryNameLabel.Height / 5));
            lblArmyLabel.Location = new Point(0, ((lblArmyLabel.Parent.ClientSize.Height / 5) * 1) - (lblArmyLabel.Height / 5));
            lblMoneyLabel.Location = new Point(0, ((lblMoneyLabel.Parent.ClientSize.Height / 5) * 2) - (lblMoneyLabel.Height / 5));
            lblPopulationLabel.Location = new Point(0, ((lblPopulationLabel.Parent.ClientSize.Height / 5) * 3) - (lblPopulationLabel.Height / 5));
            lblTensionLabel.Location = new Point(0, ((lblTensionLabel.Parent.ClientSize.Height / 5) * 4) - (lblTensionLabel.Height / 5));
            // your country panel 2
            lblName.Location = new Point(0, ((lblName.Parent.ClientSize.Height / 5) * 0) - (lblName.Height / 5));
            lblArmy.Location = new Point(0, ((lblArmy.Parent.ClientSize.Height / 5) * 1) - (lblArmy.Height / 5));
            lblMoney.Location = new Point(0, ((lblMoney.Parent.ClientSize.Height / 5) * 2) - (lblMoney.Height / 5));
            lblPopulation.Location = new Point(0, ((lblPopulation.Parent.ClientSize.Height / 5) * 3) - (lblPopulation.Height / 5));
            lblTension.Location = new Point(0, ((lblTension.Parent.ClientSize.Height / 5) * 4) - (lblTension.Height / 5));
            // other countries panel 1
            lblCountryListName.Location = new Point((lblCountryListName.Parent.ClientSize.Width / 2) - (lblCountryListName.Width / 2),
                ((lblCountryListName.Parent.ClientSize.Height / 6) * 0) - (lblCountryListName.Height / 6));
            lblUSA.Location = new Point(0, ((lblCountryListName.Parent.ClientSize.Height / 6) * 1) - (lblUSA.Height / 6));
            lblUK.Location = new Point(0, ((lblCountryListName.Parent.ClientSize.Height / 6) * 2) - (lblUK.Height / 6));
            lblGermany.Location = new Point(0, ((lblCountryListName.Parent.ClientSize.Height / 6) * 3) - (lblGermany.Height / 6));
            lblRussia.Location = new Point(0, ((lblCountryListName.Parent.ClientSize.Height / 6) * 4) - (lblRussia.Height / 6));
            lblFrance.Location = new Point(0, ((lblCountryListName.Parent.ClientSize.Height / 6) * 5) - (lblFrance.Height / 6));
            // other countries panel 2
            lblCountryListArmy.Location = new Point((lblCountryListArmy.Parent.ClientSize.Width / 2) - (lblCountryListArmy.Width / 2),
                ((lblCountryListArmy.Parent.ClientSize.Height / 6) * 0) - (lblCountryListArmy.Height / 6));
            lblUSAArmy.Location = new Point(0, ((lblCountryListArmy.Parent.ClientSize.Height / 6) * 1) - (lblUSAArmy.Height / 6));
            lblUKArmy.Location = new Point(0, ((lblCountryListArmy.Parent.ClientSize.Height / 6) * 2) - (lblUKArmy.Height / 6));
            lblGermanyArmy.Location = new Point(0, ((lblCountryListArmy.Parent.ClientSize.Height / 6) * 3) - (lblGermanyArmy.Height / 6));
            lblRussiaArmy.Location = new Point(0, ((lblCountryListArmy.Parent.ClientSize.Height / 6) * 4) - (lblRussiaArmy.Height / 6));
            lblFranceArmy.Location = new Point(0, ((lblCountryListArmy.Parent.ClientSize.Height / 6) * 5) - (lblFranceArmy.Height / 6));
        }

        private void hideAllTheThings()
        {
            // set the labels to be invisible
            lblName.Text = "";
            lblArmy.Text = "0";
            lblMoney.Text = "0";
            lblPopulation.Text = "0";
            lblTension.Text = "0";
            lblUSAArmy.Text = "0";
            lblUKArmy.Text = "0";
            lblGermanyArmy.Text = "0";
            lblRussiaArmy.Text = "0";
            lblFranceArmy.Text = "0";
            // hide the buttons 
            btnWar.Visible = false;
            btnExplore.Visible = false;
            btnBuy.Visible = false;
            btnConscript.Visible = false;
        }

        private void showButtons()
        {
            btnWar.Visible = true;
            btnExplore.Visible = true;
            btnBuy.Visible = true;
            btnConscript.Visible = true;
        }

        private void setLabels()
        {
            // set user labels
            lblArmy.Text = "" + userArmy;
            lblMoney.Text = "" + userMoney;
            lblPopulation.Text = "" + userPop;
            lblTension.Text = "" + userTension;
            // set other country labels
            lblUSAArmy.Text = "" + usaArmy;
            lblUKArmy.Text = "" + ukArmy;
            lblGermanyArmy.Text = "" + germanyArmy;
            lblRussiaArmy.Text = "" + russiaArmy;
            lblFranceArmy.Text = "" + franceArmy;
        }
    }
}

namespace BrumaGame
{
    partial class frmBrumaGame
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.lblPopulation = new System.Windows.Forms.Label();
            this.lblMoney = new System.Windows.Forms.Label();
            this.lblCountryNameLabel = new System.Windows.Forms.Label();
            this.lblPopulationLabel = new System.Windows.Forms.Label();
            this.lblMoneyLabel = new System.Windows.Forms.Label();
            this.btnWar = new System.Windows.Forms.Button();
            this.btnExplore = new System.Windows.Forms.Button();
            this.lblTensionLabel = new System.Windows.Forms.Label();
            this.lblTension = new System.Windows.Forms.Label();
            this.btnBuy = new System.Windows.Forms.Button();
            this.btnConscript = new System.Windows.Forms.Button();
            this.lblOtherCountryList = new System.Windows.Forms.Label();
            this.lblUSA = new System.Windows.Forms.Label();
            this.lblUK = new System.Windows.Forms.Label();
            this.lblGermany = new System.Windows.Forms.Label();
            this.lblRussia = new System.Windows.Forms.Label();
            this.lblFrance = new System.Windows.Forms.Label();
            this.lblCountryListName = new System.Windows.Forms.Label();
            this.lblCountryListArmy = new System.Windows.Forms.Label();
            this.lblUSAArmy = new System.Windows.Forms.Label();
            this.lblUKArmy = new System.Windows.Forms.Label();
            this.scOtherCountries = new System.Windows.Forms.SplitContainer();
            this.lblFranceArmy = new System.Windows.Forms.Label();
            this.lblRussiaArmy = new System.Windows.Forms.Label();
            this.lblGermanyArmy = new System.Windows.Forms.Label();
            this.scCountryStats = new System.Windows.Forms.SplitContainer();
            this.lblArmyLabel = new System.Windows.Forms.Label();
            this.lblArmy = new System.Windows.Forms.Label();
            this.lblYourCountry = new System.Windows.Forms.Label();
            this.btnQuit = new System.Windows.Forms.Button();
            this.btnNewGame = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.scOtherCountries)).BeginInit();
            this.scOtherCountries.Panel1.SuspendLayout();
            this.scOtherCountries.Panel2.SuspendLayout();
            this.scOtherCountries.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.scCountryStats)).BeginInit();
            this.scCountryStats.Panel1.SuspendLayout();
            this.scCountryStats.Panel2.SuspendLayout();
            this.scCountryStats.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 12);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(456, 314);
            this.textBox1.TabIndex = 0;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(8, 22);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(94, 13);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "user country name";
            // 
            // lblPopulation
            // 
            this.lblPopulation.AutoSize = true;
            this.lblPopulation.Location = new System.Drawing.Point(4, 94);
            this.lblPopulation.Name = "lblPopulation";
            this.lblPopulation.Size = new System.Drawing.Size(66, 13);
            this.lblPopulation.TabIndex = 2;
            this.lblPopulation.Text = "# population";
            // 
            // lblMoney
            // 
            this.lblMoney.AutoSize = true;
            this.lblMoney.Location = new System.Drawing.Point(5, 81);
            this.lblMoney.Name = "lblMoney";
            this.lblMoney.Size = new System.Drawing.Size(49, 13);
            this.lblMoney.TabIndex = 3;
            this.lblMoney.Text = "$ monies";
            // 
            // lblCountryNameLabel
            // 
            this.lblCountryNameLabel.AutoSize = true;
            this.lblCountryNameLabel.Location = new System.Drawing.Point(2, 22);
            this.lblCountryNameLabel.Name = "lblCountryNameLabel";
            this.lblCountryNameLabel.Size = new System.Drawing.Size(77, 13);
            this.lblCountryNameLabel.TabIndex = 4;
            this.lblCountryNameLabel.Text = "Country Name:";
            // 
            // lblPopulationLabel
            // 
            this.lblPopulationLabel.AutoSize = true;
            this.lblPopulationLabel.Location = new System.Drawing.Point(3, 94);
            this.lblPopulationLabel.Name = "lblPopulationLabel";
            this.lblPopulationLabel.Size = new System.Drawing.Size(60, 13);
            this.lblPopulationLabel.TabIndex = 5;
            this.lblPopulationLabel.Text = "Population:";
            // 
            // lblMoneyLabel
            // 
            this.lblMoneyLabel.AutoSize = true;
            this.lblMoneyLabel.Location = new System.Drawing.Point(3, 81);
            this.lblMoneyLabel.Name = "lblMoneyLabel";
            this.lblMoneyLabel.Size = new System.Drawing.Size(42, 13);
            this.lblMoneyLabel.TabIndex = 6;
            this.lblMoneyLabel.Text = "Money:";
            // 
            // btnWar
            // 
            this.btnWar.Location = new System.Drawing.Point(13, 350);
            this.btnWar.Name = "btnWar";
            this.btnWar.Size = new System.Drawing.Size(75, 23);
            this.btnWar.TabIndex = 7;
            this.btnWar.Text = "War";
            this.btnWar.UseVisualStyleBackColor = true;
            // 
            // btnExplore
            // 
            this.btnExplore.Location = new System.Drawing.Point(13, 379);
            this.btnExplore.Name = "btnExplore";
            this.btnExplore.Size = new System.Drawing.Size(75, 23);
            this.btnExplore.TabIndex = 8;
            this.btnExplore.Text = "Explore";
            this.btnExplore.UseVisualStyleBackColor = true;
            // 
            // lblTensionLabel
            // 
            this.lblTensionLabel.AutoSize = true;
            this.lblTensionLabel.Location = new System.Drawing.Point(2, 107);
            this.lblTensionLabel.Name = "lblTensionLabel";
            this.lblTensionLabel.Size = new System.Drawing.Size(48, 13);
            this.lblTensionLabel.TabIndex = 9;
            this.lblTensionLabel.Text = "Tension:";
            // 
            // lblTension
            // 
            this.lblTension.AutoSize = true;
            this.lblTension.Location = new System.Drawing.Point(5, 107);
            this.lblTension.Name = "lblTension";
            this.lblTension.Size = new System.Drawing.Size(52, 13);
            this.lblTension.TabIndex = 10;
            this.lblTension.Text = "% tension";
            // 
            // btnBuy
            // 
            this.btnBuy.Location = new System.Drawing.Point(94, 350);
            this.btnBuy.Name = "btnBuy";
            this.btnBuy.Size = new System.Drawing.Size(75, 23);
            this.btnBuy.TabIndex = 11;
            this.btnBuy.Text = "Buy";
            this.btnBuy.UseVisualStyleBackColor = true;
            // 
            // btnConscript
            // 
            this.btnConscript.Location = new System.Drawing.Point(94, 379);
            this.btnConscript.Name = "btnConscript";
            this.btnConscript.Size = new System.Drawing.Size(75, 23);
            this.btnConscript.TabIndex = 12;
            this.btnConscript.Text = "Conscript";
            this.btnConscript.UseVisualStyleBackColor = true;
            // 
            // lblOtherCountryList
            // 
            this.lblOtherCountryList.AutoSize = true;
            this.lblOtherCountryList.Location = new System.Drawing.Point(526, 172);
            this.lblOtherCountryList.Name = "lblOtherCountryList";
            this.lblOtherCountryList.Size = new System.Drawing.Size(80, 13);
            this.lblOtherCountryList.TabIndex = 13;
            this.lblOtherCountryList.Text = "Other Countries";
            // 
            // lblUSA
            // 
            this.lblUSA.AutoSize = true;
            this.lblUSA.Location = new System.Drawing.Point(10, 26);
            this.lblUSA.Name = "lblUSA";
            this.lblUSA.Size = new System.Drawing.Size(29, 13);
            this.lblUSA.TabIndex = 14;
            this.lblUSA.Text = "USA";
            // 
            // lblUK
            // 
            this.lblUK.AutoSize = true;
            this.lblUK.Location = new System.Drawing.Point(10, 50);
            this.lblUK.Name = "lblUK";
            this.lblUK.Size = new System.Drawing.Size(22, 13);
            this.lblUK.TabIndex = 15;
            this.lblUK.Text = "UK";
            // 
            // lblGermany
            // 
            this.lblGermany.AutoSize = true;
            this.lblGermany.Location = new System.Drawing.Point(3, 72);
            this.lblGermany.Name = "lblGermany";
            this.lblGermany.Size = new System.Drawing.Size(49, 13);
            this.lblGermany.TabIndex = 16;
            this.lblGermany.Text = "Germany";
            // 
            // lblRussia
            // 
            this.lblRussia.AutoSize = true;
            this.lblRussia.Location = new System.Drawing.Point(9, 96);
            this.lblRussia.Name = "lblRussia";
            this.lblRussia.Size = new System.Drawing.Size(39, 13);
            this.lblRussia.TabIndex = 17;
            this.lblRussia.Text = "Russia";
            // 
            // lblFrance
            // 
            this.lblFrance.AutoSize = true;
            this.lblFrance.Location = new System.Drawing.Point(9, 113);
            this.lblFrance.Name = "lblFrance";
            this.lblFrance.Size = new System.Drawing.Size(40, 13);
            this.lblFrance.TabIndex = 18;
            this.lblFrance.Text = "France";
            // 
            // lblCountryListName
            // 
            this.lblCountryListName.AutoSize = true;
            this.lblCountryListName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCountryListName.Location = new System.Drawing.Point(10, 3);
            this.lblCountryListName.Name = "lblCountryListName";
            this.lblCountryListName.Size = new System.Drawing.Size(35, 13);
            this.lblCountryListName.TabIndex = 19;
            this.lblCountryListName.Text = "Name";
            // 
            // lblCountryListArmy
            // 
            this.lblCountryListArmy.AutoSize = true;
            this.lblCountryListArmy.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCountryListArmy.Location = new System.Drawing.Point(34, 3);
            this.lblCountryListArmy.Name = "lblCountryListArmy";
            this.lblCountryListArmy.Size = new System.Drawing.Size(53, 13);
            this.lblCountryListArmy.TabIndex = 20;
            this.lblCountryListArmy.Text = "Army Size";
            // 
            // lblUSAArmy
            // 
            this.lblUSAArmy.AutoSize = true;
            this.lblUSAArmy.Location = new System.Drawing.Point(20, 26);
            this.lblUSAArmy.Name = "lblUSAArmy";
            this.lblUSAArmy.Size = new System.Drawing.Size(67, 13);
            this.lblUSAArmy.TabIndex = 21;
            this.lblUSAArmy.Text = "usaArmySize";
            // 
            // lblUKArmy
            // 
            this.lblUKArmy.AutoSize = true;
            this.lblUKArmy.Location = new System.Drawing.Point(25, 50);
            this.lblUKArmy.Name = "lblUKArmy";
            this.lblUKArmy.Size = new System.Drawing.Size(62, 13);
            this.lblUKArmy.TabIndex = 22;
            this.lblUKArmy.Text = "ukArmySize";
            // 
            // scOtherCountries
            // 
            this.scOtherCountries.Location = new System.Drawing.Point(477, 190);
            this.scOtherCountries.Name = "scOtherCountries";
            // 
            // scOtherCountries.Panel1
            // 
            this.scOtherCountries.Panel1.Controls.Add(this.lblGermany);
            this.scOtherCountries.Panel1.Controls.Add(this.lblCountryListName);
            this.scOtherCountries.Panel1.Controls.Add(this.lblRussia);
            this.scOtherCountries.Panel1.Controls.Add(this.lblFrance);
            this.scOtherCountries.Panel1.Controls.Add(this.lblUSA);
            this.scOtherCountries.Panel1.Controls.Add(this.lblUK);
            // 
            // scOtherCountries.Panel2
            // 
            this.scOtherCountries.Panel2.Controls.Add(this.lblFranceArmy);
            this.scOtherCountries.Panel2.Controls.Add(this.lblRussiaArmy);
            this.scOtherCountries.Panel2.Controls.Add(this.lblGermanyArmy);
            this.scOtherCountries.Panel2.Controls.Add(this.lblCountryListArmy);
            this.scOtherCountries.Panel2.Controls.Add(this.lblUKArmy);
            this.scOtherCountries.Panel2.Controls.Add(this.lblUSAArmy);
            this.scOtherCountries.Size = new System.Drawing.Size(195, 136);
            this.scOtherCountries.SplitterDistance = 65;
            this.scOtherCountries.TabIndex = 23;
            // 
            // lblFranceArmy
            // 
            this.lblFranceArmy.AutoSize = true;
            this.lblFranceArmy.Location = new System.Drawing.Point(20, 96);
            this.lblFranceArmy.Name = "lblFranceArmy";
            this.lblFranceArmy.Size = new System.Drawing.Size(80, 13);
            this.lblFranceArmy.TabIndex = 25;
            this.lblFranceArmy.Text = "franceArmySize";
            // 
            // lblRussiaArmy
            // 
            this.lblRussiaArmy.AutoSize = true;
            this.lblRussiaArmy.Location = new System.Drawing.Point(20, 75);
            this.lblRussiaArmy.Name = "lblRussiaArmy";
            this.lblRussiaArmy.Size = new System.Drawing.Size(77, 13);
            this.lblRussiaArmy.TabIndex = 24;
            this.lblRussiaArmy.Text = "russiaArmySize";
            // 
            // lblGermanyArmy
            // 
            this.lblGermanyArmy.AutoSize = true;
            this.lblGermanyArmy.Location = new System.Drawing.Point(32, 62);
            this.lblGermanyArmy.Name = "lblGermanyArmy";
            this.lblGermanyArmy.Size = new System.Drawing.Size(90, 13);
            this.lblGermanyArmy.TabIndex = 23;
            this.lblGermanyArmy.Text = "germanyArmySize";
            // 
            // scCountryStats
            // 
            this.scCountryStats.Location = new System.Drawing.Point(477, 29);
            this.scCountryStats.Name = "scCountryStats";
            // 
            // scCountryStats.Panel1
            // 
            this.scCountryStats.Panel1.Controls.Add(this.lblArmyLabel);
            this.scCountryStats.Panel1.Controls.Add(this.lblPopulationLabel);
            this.scCountryStats.Panel1.Controls.Add(this.lblCountryNameLabel);
            this.scCountryStats.Panel1.Controls.Add(this.lblMoneyLabel);
            this.scCountryStats.Panel1.Controls.Add(this.lblTensionLabel);
            // 
            // scCountryStats.Panel2
            // 
            this.scCountryStats.Panel2.Controls.Add(this.lblArmy);
            this.scCountryStats.Panel2.Controls.Add(this.lblMoney);
            this.scCountryStats.Panel2.Controls.Add(this.lblName);
            this.scCountryStats.Panel2.Controls.Add(this.lblPopulation);
            this.scCountryStats.Panel2.Controls.Add(this.lblTension);
            this.scCountryStats.Size = new System.Drawing.Size(195, 136);
            this.scCountryStats.SplitterDistance = 82;
            this.scCountryStats.TabIndex = 24;
            // 
            // lblArmyLabel
            // 
            this.lblArmyLabel.AutoSize = true;
            this.lblArmyLabel.Location = new System.Drawing.Point(10, 52);
            this.lblArmyLabel.Name = "lblArmyLabel";
            this.lblArmyLabel.Size = new System.Drawing.Size(56, 13);
            this.lblArmyLabel.TabIndex = 12;
            this.lblArmyLabel.Text = "Army Size:";
            // 
            // lblArmy
            // 
            this.lblArmy.AutoSize = true;
            this.lblArmy.Location = new System.Drawing.Point(5, 52);
            this.lblArmy.Name = "lblArmy";
            this.lblArmy.Size = new System.Drawing.Size(52, 13);
            this.lblArmy.TabIndex = 11;
            this.lblArmy.Text = "# soldiers";
            // 
            // lblYourCountry
            // 
            this.lblYourCountry.AutoSize = true;
            this.lblYourCountry.Location = new System.Drawing.Point(535, 12);
            this.lblYourCountry.Name = "lblYourCountry";
            this.lblYourCountry.Size = new System.Drawing.Size(68, 13);
            this.lblYourCountry.TabIndex = 25;
            this.lblYourCountry.Text = "Your Country";
            // 
            // btnQuit
            // 
            this.btnQuit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnQuit.Location = new System.Drawing.Point(597, 379);
            this.btnQuit.Name = "btnQuit";
            this.btnQuit.Size = new System.Drawing.Size(75, 23);
            this.btnQuit.TabIndex = 26;
            this.btnQuit.Text = "Quit";
            this.btnQuit.UseVisualStyleBackColor = true;
            this.btnQuit.Click += new System.EventHandler(this.btnQuit_Click);
            // 
            // btnNewGame
            // 
            this.btnNewGame.Location = new System.Drawing.Point(597, 350);
            this.btnNewGame.Name = "btnNewGame";
            this.btnNewGame.Size = new System.Drawing.Size(75, 23);
            this.btnNewGame.TabIndex = 27;
            this.btnNewGame.Text = "New Game";
            this.btnNewGame.UseVisualStyleBackColor = true;
            this.btnNewGame.Click += new System.EventHandler(this.btnNewGame_Click);
            // 
            // frmBrumaGame
            // 
            this.AcceptButton = this.btnNewGame;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnQuit;
            this.ClientSize = new System.Drawing.Size(684, 413);
            this.Controls.Add(this.btnNewGame);
            this.Controls.Add(this.btnQuit);
            this.Controls.Add(this.lblYourCountry);
            this.Controls.Add(this.scCountryStats);
            this.Controls.Add(this.scOtherCountries);
            this.Controls.Add(this.lblOtherCountryList);
            this.Controls.Add(this.btnConscript);
            this.Controls.Add(this.btnBuy);
            this.Controls.Add(this.btnExplore);
            this.Controls.Add(this.btnWar);
            this.Controls.Add(this.textBox1);
            this.Name = "frmBrumaGame";
            this.Text = "BrumaGame";
            this.Load += new System.EventHandler(this.frmBrumaGame_Load);
            this.SizeChanged += new System.EventHandler(this.frmBrumaGame_SizeChanged);
            this.scOtherCountries.Panel1.ResumeLayout(false);
            this.scOtherCountries.Panel1.PerformLayout();
            this.scOtherCountries.Panel2.ResumeLayout(false);
            this.scOtherCountries.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.scOtherCountries)).EndInit();
            this.scOtherCountries.ResumeLayout(false);
            this.scCountryStats.Panel1.ResumeLayout(false);
            this.scCountryStats.Panel1.PerformLayout();
            this.scCountryStats.Panel2.ResumeLayout(false);
            this.scCountryStats.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.scCountryStats)).EndInit();
            this.scCountryStats.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblPopulation;
        private System.Windows.Forms.Label lblMoney;
        private System.Windows.Forms.Label lblCountryNameLabel;
        private System.Windows.Forms.Label lblPopulationLabel;
        private System.Windows.Forms.Label lblMoneyLabel;
        private System.Windows.Forms.Button btnWar;
        private System.Windows.Forms.Button btnExplore;
        private System.Windows.Forms.Label lblTensionLabel;
        private System.Windows.Forms.Label lblTension;
        private System.Windows.Forms.Button btnBuy;
        private System.Windows.Forms.Button btnConscript;
        private System.Windows.Forms.Label lblOtherCountryList;
        private System.Windows.Forms.Label lblUSA;
        private System.Windows.Forms.Label lblUK;
        private System.Windows.Forms.Label lblGermany;
        private System.Windows.Forms.Label lblRussia;
        private System.Windows.Forms.Label lblFrance;
        private System.Windows.Forms.Label lblCountryListName;
        private System.Windows.Forms.Label lblCountryListArmy;
        private System.Windows.Forms.Label lblUSAArmy;
        private System.Windows.Forms.Label lblUKArmy;
        private System.Windows.Forms.SplitContainer scOtherCountries;
        private System.Windows.Forms.Label lblFranceArmy;
        private System.Windows.Forms.Label lblRussiaArmy;
        private System.Windows.Forms.Label lblGermanyArmy;
        private System.Windows.Forms.SplitContainer scCountryStats;
        private System.Windows.Forms.Label lblYourCountry;
        private System.Windows.Forms.Label lblArmyLabel;
        private System.Windows.Forms.Label lblArmy;
        private System.Windows.Forms.Button btnQuit;
        private System.Windows.Forms.Button btnNewGame;
    }
}


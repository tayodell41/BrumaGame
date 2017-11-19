/**********************************************************
* frmGetUsername.cs
*
* Original game by Brumafriend can be found here: https://github.com/brumafriend/BrumaGame
* This form is a popup form to get a country name from the user
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
    public partial class frmGetUsername : Form
    {
        /*------------------------------------------------------------------------------------------
         * Form Initializers
         -----------------------------------------------------------------------------------------*/
        public frmBrumaGame referenceToFbg; // refrence to Parent form
        public frmGetUsername(frmBrumaGame fbg)
        {
            InitializeComponent();
            referenceToFbg = fbg; // set refrence to parent form
        }

        /*------------------------------------------------------------------------------------------
         * Button Handlers
         -----------------------------------------------------------------------------------------*/
        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            if (txtCountryName.Text != "")
            {
                referenceToFbg.countryName = txtCountryName.Text;
                referenceToFbg.nameSet = true;
                Close();
            }
        }
    }
}

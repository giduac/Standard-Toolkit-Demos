#region BSD License
/*
 * 
 * Original BSD 3-Clause License (https://github.com/ComponentFactory/Krypton/blob/master/LICENSE)
 *  © Component Factory Pty Ltd, 2006 - 2016, (Version 4.5.0.0) All rights reserved.
 * 
 *  New BSD 3-Clause License (https://github.com/Krypton-Suite/Standard-Toolkit/blob/master/LICENSE)
 *  Modifications by Peter Wagner(aka Wagnerp) & Simon Coghlan(aka Smurf-IV), et al. 2017 - 2024. All rights reserved. 
 *  
 */
#endregion

using System;
using System.ComponentModel;
using System.Drawing;
using System.Globalization;
using System.Linq;
using Krypton.Ribbon;
using Krypton.Toolkit;
using System.Windows.Forms;

namespace ApplicationMenu
{
    public partial class Form1 : KryptonForm
    {
        public Form1()
        {
            System.Threading.Thread.CurrentThread.CurrentCulture = new CultureInfo( ( "en-UK" ) );

            InitializeComponent();
            this.kryptonRibbon1.QATLocation = Krypton.Ribbon.QATLocation.Hidden;
            this.CloseBox = true;
            
            kryptonRibbonGroupComboBox1.SelectedIndex = 0;

            kryptonRibbonGroupDomainUpDown1.Enabled = true;
            kryptonRibbonGroupDomainUpDown1.SelectedIndex = 0;

            //TODO:  kryptonRibbonGroupDomainUpDown control stays enabled when set to disabled.
            kryptonRibbonGroupDomainUpDown2.Enabled = false;
            kryptonRibbonGroupDomainUpDown2.SelectedIndex = 0;

            //TODO: kribbontrackbar stays enabled when disabled

            //custom ribbon controls
            kryptonRibbonGroupCustomControl1.CustomControl = new KryptonCheckedListBox();
            kryptonRibbonGroupCustomControl2.CustomControl = new KryptonCheckedListBox();

            var s = new string[] {"one", "two", "three", "four"};
            ( kryptonRibbonGroupCustomControl1.CustomControl as KryptonCheckedListBox )!.Items.AddRange( s );
            ( kryptonRibbonGroupCustomControl2.CustomControl as KryptonCheckedListBox )!.Items.AddRange( s );

        }

        private void propertyGrid2_SelectedObjectsChanged( object sender, EventArgs e )
        {
            KryptonMessageBox.Show( nameof( PropertyGrid1.SelectedObject ) );
        }

        private void kcmdCloseApp_Execute( object sender, EventArgs e )
        {
            this.Close();
        }
    }
}

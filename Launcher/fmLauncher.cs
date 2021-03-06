﻿using System;
using System.Configuration;
using System.Diagnostics;
using System.Net;
using System.Reflection;
using System.Windows.Forms;
using Launcher.Models;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Globalization;
using System.Linq;
using System.Xml;
using System.IO;
using System.Text;
using System.Drawing;
using Launcher.Properties;
using Microsoft.Win32;

namespace Launcher
{
    public partial class fmLauncher : Form
    {
        public fmLauncher()
        {
            InitializeComponent();

            this.Icon = Launcher.Properties.Resources.launch;
        }

        public static string startCellValue = "";
        public static string startCellValueName = "";

        public void fmLauncher_Load(object sender, EventArgs e)
        {
            #region create config file if needed
            if (!File.Exists(Process.GetCurrentProcess().ProcessName + ".exe.config")) //ako config file ne postoji ovo ce ga napraviti
            {
                System.Text.StringBuilder sb = new StringBuilder();
                sb.AppendLine("<?xml version=\"1.0\" encoding=\"utf-8\"?>");
                sb.AppendLine("<configuration>");
                sb.AppendLine("<configSections>");
                sb.AppendLine("</configSections>");
                sb.AppendLine("<appSettings>");
                sb.AppendLine("</appSettings>");
                sb.AppendLine("<chkbxSettings>");
                sb.AppendLine("<add key=\"optCloseOnOpen\" value=\"false\"/>");
                sb.AppendLine("<add key=\"optMinimizeOnOpen\" value=\"false\"/>");
                sb.AppendLine("<add key=\"optDoNothing\" value=\"true\"/>");
                sb.AppendLine("</chkbxSettings>");
                sb.AppendLine("<startup>");
                sb.AppendLine("<supportedRuntime version=\"v4.0\" sku=\".NETFramework,Version=v4.0\"/>");
                sb.AppendLine("</startup>");
                sb.AppendLine("</configuration>");
                string loc = Assembly.GetEntryAssembly().Location;
                System.IO.File.WriteAllText(String.Concat(loc, ".config"), sb.ToString());
            }
            #endregion

            cboApps.SelectedIndex = 0; // 0 = S2D - default izabrana vrijednost sa popisa

            //ubacivanje liste u datagridview iz SvcSettings klase
            BindingList<SvcSettings> list = SvcSettings.GetSettingsFromConfig();
            this.grdLaunch.DataSource = list;
            this.ActiveControl = cboApps;

            XmlDocument XmlDoc = new XmlDocument();
            XmlDoc.Load(AppDomain.CurrentDomain.SetupInformation.ConfigurationFile);
            foreach (XmlElement xElement in XmlDoc.DocumentElement)
            {
                if (xElement.Name == "chkbxSettings")
                {
                    foreach (XmlNode xNode in xElement.ChildNodes)
                    {
                        if (xNode.Attributes[0].Value == "optCloseOnOpen")
                        {
                            if (xNode.Attributes[1].Value == "true")
                            { rdoCloseOption.Checked = Convert.ToBoolean(xNode.Attributes[1].Value); }
                        }
                        if (xNode.Attributes[0].Value == "optMinimizeOnOpen")
                        {
                            if (xNode.Attributes[1].Value == "true")
                            { rdoMinimizeOption.Checked = Convert.ToBoolean(xNode.Attributes[1].Value); }
                        }
                        if (xNode.Attributes[0].Value == "optDoNothing")
                        {
                            if (xNode.Attributes[1].Value == "true")
                            { rdoNothingOption.Checked = Convert.ToBoolean(xNode.Attributes[1].Value); }
                        }
                    }
                }
            }
        }

        #region BUTTONS

        private void btnAddListEntry_Click(object sender, EventArgs e)
        {

            string devAction = "-";
            string devSession = "-";

            #region CheckboxNames
            bool debug = false;
            if (chkAction.Checked)
            {
                if (txtAction.Text == "")
                {
                    MessageBox.Show("Ako je izabrana developer opcija 'action', polje za unos opcije ne smije biti prazno!");
                    goto DoNothingAction;
                }
                else
                {
                    devAction = txtAction.Text;
                }
            }
            if (chkSession.Checked)
            {
                if (txtSession.Text == "")
                {
                    MessageBox.Show("Ako je izabrana developer opcija 'session', polje za unos opcije ne smije biti prazno!");
                    goto DoNothingSession;
                }
                else
                {
                    devSession = txtSession.Text;
                }
            }

            if (chkDebug.Checked)
            {
                debug = true;
            }
            #endregion

            // nm: inace, string moze biti i null pa se to provjerava ovako: if (!string.IsNullOrEmpty(txtName.Text)) - ali u TextBox kontroli nikad nece biti null pa je ovo tvoje ok
            if (txtName.Text != "" && cboApps.Text != "" && txtHttp.Text != "" && txtUsername.Text != "" && txtPassword.Text != "")
            {
                var section = SvcSettings.GetNameValueCollectionSection("appSettings", Process.GetCurrentProcess().MainModule.FileName + ".config");
                //foreach (string key in appSettingsSection.AllKeys)

                //var section = ConfigurationManager.GetSection("appSettings") as NameValueCollection;
                var value = section[txtName.Text + "(" + cboApps.Text.Substring(0, 3) + ")"];
                string[] words = { "|", "|" }; // bezveze string
                if (value != null)
                {
                    words = value.Split('|');
                }

                //usporedjuje ime iz app configa key-a i ime uneseno u txtName (ignore case)
                if (StringComparer.CurrentCultureIgnoreCase.Equals(words[0], txtName.Text) == true
                    && StringComparer.CurrentCultureIgnoreCase.Equals(words[1], cboApps.Text) == true) // case insensitive comparing
                {
                    MessageBox.Show("Unos s istim imenom već postoji!\n\nUnesite novo ime.", "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.ActiveControl = txtName; //prebacuje focus na txtName
                }
                else
                {
                    AppName.appNameCombo = txtName.Text + "(" + cboApps.Text.Substring(0, 3) + ")";
                    SaveList.addDataToAppconfig(txtName.Text + "|"
                                               + cboApps.Text + "|"
                                               + txtHttp.Text + txtUrl.Text + "|"
                                               + txtPort.Text + "|"
                                               + txtUsername.Text + "|"
                                               + txtPassword.Text + "|"
                                               + debug.ToString() + "|"
                                               + devAction + "|"
                                               + devSession);
                    BindingList<SvcSettings> list = SvcSettings.GetSettingsFromConfig();
                    this.grdLaunch.DataSource = list;
                }
            }
            else
            {
                MessageBox.Show("Svi obavezni podaci (ime, endpoint(URL), username, password) moraju biti uneseni!", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            grdLaunch.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
        DoNothingAction: ;
        DoNothingSession: ;
            grdLaunch.CurrentCell = null;

        }

        private void btnDeleteListEntry_Click(object sender, EventArgs e)
        {
            string deleteEntry = "";
            if (grdLaunch.RowCount > 0)
            {
                deleteEntry = txtName.Text + "(" + cboApps.Text.Substring(0, 3) + ")";
                var delEntryFromConfig = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
                delEntryFromConfig.AppSettings.Settings.Remove(deleteEntry);
                delEntryFromConfig.Save(ConfigurationSaveMode.Modified);
                //ConfigurationManager.RefreshSection("appSettings"); // nakon brisanja refresh appSettings sekciju pa se i gridview refresha
                grdLaunch.Refresh();
                BindingList<SvcSettings> list = SvcSettings.GetSettingsFromConfig();
                this.grdLaunch.DataSource = list;
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnCsvExport_Click(object sender, EventArgs e)
        {
            // Displays a SaveFileDialog so the user can save the list
            // assigned to button.

            dlgFileSave.Filter = "CSV format|*.csv";
            dlgFileSave.Title = "Export to CSV";
            dlgFileSave.FileName = "S2D Export";
            dlgFileSave.DefaultExt = "csv";
            dlgFileSave.InitialDirectory = AppDomain.CurrentDomain.BaseDirectory;
            dlgFileSave.RestoreDirectory = true;
            dlgFileSave.ShowDialog();

            if (dlgFileSave.FileName != "")
            {
                WriteCsv.writeCSV(grdLaunch, dlgFileSave.FileName);
            }

        }

        private void btnOpenFolder_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process prc = new System.Diagnostics.Process();
            prc.StartInfo.WindowStyle = ProcessWindowStyle.Maximized;
            prc.StartInfo.FileName = Path.GetDirectoryName(Assembly.GetEntryAssembly().Location);
            prc.Start();


        }

        private void btnOpenConfig_Click(object sender, EventArgs e)
        {
            mnuAssocApps.Show(btnOpenConfig, new Point(0, btnOpenConfig.Height));

            Point screenPoint = btnOpenConfig.PointToScreen(new Point(btnOpenConfig.Left, btnOpenConfig.Top));
            if (screenPoint.Y + mnuAssocApps.Size.Height > Screen.PrimaryScreen.WorkingArea.Height)
            {
                mnuAssocApps.Show(btnOpenConfig, new Point(0, -mnuAssocApps.Size.Height));
            }
            else
            {
                mnuAssocApps.Show(btnOpenConfig, new Point(0, btnOpenConfig.Height));
            }

        }
        
        #endregion

        #region GRID EVENTS

        private void grdLaunch_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtName.Text = grdLaunch.Rows[grdLaunch.CurrentCell.RowIndex].Cells[1].Value.ToString();
            cboApps.Text = grdLaunch.Rows[grdLaunch.CurrentCell.RowIndex].Cells[2].Value.ToString();
            System.Uri uri = new Uri(grdLaunch.Rows[grdLaunch.CurrentCell.RowIndex].Cells[3].Value.ToString());
            string uriWithoutScheme = uri.Host + uri.PathAndQuery;
            uriWithoutScheme = uriWithoutScheme.TrimEnd('/');
            txtUrl.Text = uriWithoutScheme;
            txtPort.Text = grdLaunch.Rows[grdLaunch.CurrentCell.RowIndex].Cells[4].Value.ToString();
            txtUsername.Text = grdLaunch.Rows[grdLaunch.CurrentCell.RowIndex].Cells[5].Value.ToString();
            txtPassword.Text = grdLaunch.Rows[grdLaunch.CurrentCell.RowIndex].Cells[6].Value.ToString();
            Boolean i = bool.Parse(grdLaunch.Rows[grdLaunch.CurrentCell.RowIndex].Cells[7].Value.ToString());
            if (i == true)
            {
                chkDebug.Checked = true;
            }
            else
            {
                chkDebug.Checked = false;
            }

            string semiColon = "";
            string opcAction = "";
            string opcSession = "";
            string opcDebug = "";
            if (i == true)
            {
                opcDebug = " -debug true ";
            }
            if (grdLaunch.Rows[grdLaunch.CurrentCell.RowIndex].Cells[4].Value.ToString() != "")
            {
                semiColon = ":";
            }
            if (grdLaunch.Rows[grdLaunch.CurrentCell.RowIndex].Cells[8].Value.ToString() != "-")
            {
                opcAction = " -action " + grdLaunch.Rows[grdLaunch.CurrentCell.RowIndex].Cells[8].Value.ToString();
            }
            if (grdLaunch.Rows[grdLaunch.CurrentCell.RowIndex].Cells[9].Value.ToString() != "-")
            {
                opcSession = " -session " + grdLaunch.Rows[grdLaunch.CurrentCell.RowIndex].Cells[9].Value.ToString();
            }
            string urlFull = grdLaunch.Rows[grdLaunch.CurrentCell.RowIndex].Cells[3].Value.ToString() + semiColon + grdLaunch.Rows[grdLaunch.CurrentCell.RowIndex].Cells[4].Value.ToString();
            if (e.ColumnIndex == 0) // pokrece se s2d_v2.exe sa parametrima
            {
                ProcessStartInfo startInfo = new ProcessStartInfo();
                startInfo.FileName = cboApps.Text + ".exe";
                startInfo.Arguments = " -endpoint " + urlFull
                                    + " -user " + grdLaunch.Rows[grdLaunch.CurrentCell.RowIndex].Cells[5].Value.ToString()
                                    + " -pass " + grdLaunch.Rows[grdLaunch.CurrentCell.RowIndex].Cells[6].Value.ToString()
                                    + opcDebug + opcAction + opcSession;
                try
                {

                    Process.Start(startInfo);
                    //MessageBox.Show(startInfo.FileName.ToString() + startInfo.Arguments.ToString());
                    if (rdoCloseOption.Checked)
                    {
                        Application.Exit();
                    }
                    else if (rdoMinimizeOption.Checked)
                    {
                        this.WindowState = FormWindowState.Minimized;
                    }

                }
                catch (Exception)
                {
                    MessageBox.Show("Greška pri pokretanju aplikacije:"
                                    + "\n\n Command line:"
                                    + "\n"
                                    + startInfo.FileName
                                    + startInfo.Arguments, "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }

        private void grdLaunch_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            startCellValue = grdLaunch.Rows[grdLaunch.CurrentCell.RowIndex].Cells[grdLaunch.CurrentCell.ColumnIndex].Value.ToString();
            startCellValueName = grdLaunch.Rows[grdLaunch.CurrentCell.RowIndex].Cells[1].Value.ToString();
        }

        private void grdLaunch_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (String.IsNullOrWhiteSpace(grdLaunch.Rows[grdLaunch.CurrentCell.RowIndex].Cells[grdLaunch.CurrentCell.ColumnIndex].ToString()) || grdLaunch.Rows[grdLaunch.CurrentCell.RowIndex].Cells[grdLaunch.CurrentCell.ColumnIndex].Value == null)
                {
                    grdLaunch.Rows[grdLaunch.CurrentCell.RowIndex].Cells[grdLaunch.CurrentCell.ColumnIndex].Value = startCellValue;
                }
                Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);

                AppName.appNameCombo = grdLaunch.Rows[grdLaunch.CurrentCell.RowIndex].Cells[1].Value.ToString() + "(" + grdLaunch.Rows[grdLaunch.CurrentCell.RowIndex].Cells[2].Value.ToString().Substring(0, 3) + ")";
                config.AppSettings.Settings.Remove(startCellValueName + "(" + grdLaunch.Rows[grdLaunch.CurrentCell.RowIndex].Cells[2].Value.ToString().Substring(0, 3) + ")");
                config.Save(ConfigurationSaveMode.Modified);
                SaveList.addDataToAppconfig(grdLaunch.Rows[grdLaunch.CurrentCell.RowIndex].Cells[1].Value.ToString() + "|"
                                           + grdLaunch.Rows[grdLaunch.CurrentCell.RowIndex].Cells[2].Value.ToString() + "|"
                                           + grdLaunch.Rows[grdLaunch.CurrentCell.RowIndex].Cells[3].Value.ToString() + "|"
                                           + grdLaunch.Rows[grdLaunch.CurrentCell.RowIndex].Cells[4].Value.ToString() + "|"
                                           + grdLaunch.Rows[grdLaunch.CurrentCell.RowIndex].Cells[5].Value.ToString() + "|"
                                           + grdLaunch.Rows[grdLaunch.CurrentCell.RowIndex].Cells[6].Value.ToString() + "|"
                                           + grdLaunch.Rows[grdLaunch.CurrentCell.RowIndex].Cells[7].Value.ToString() + "|"
                                           + grdLaunch.Rows[grdLaunch.CurrentCell.RowIndex].Cells[8].Value.ToString() + "|"
                                           + grdLaunch.Rows[grdLaunch.CurrentCell.RowIndex].Cells[9].Value.ToString());
                BindingList<SvcSettings> list = SvcSettings.GetSettingsFromConfig();
                this.grdLaunch.DataSource = list;
            }
            catch (Exception)
            {

            }

        }

        private void grdLaunch_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            //kupi vrijednosti iz datagridview-a i stavlja ih u potrebne controle


            txtName.Text = grdLaunch.Rows[grdLaunch.CurrentCell.RowIndex].Cells[1].Value.ToString();
            cboApps.Text = grdLaunch.Rows[grdLaunch.CurrentCell.RowIndex].Cells[2].Value.ToString();
            System.Uri uri = new Uri(grdLaunch.Rows[grdLaunch.CurrentCell.RowIndex].Cells[3].Value.ToString());
            string uriWithoutScheme = uri.Host + uri.PathAndQuery;
            uriWithoutScheme = uriWithoutScheme.TrimEnd('/');
            txtUrl.Text = uriWithoutScheme;
            txtPort.Text = grdLaunch.Rows[grdLaunch.CurrentCell.RowIndex].Cells[4].Value.ToString();
            txtUsername.Text = grdLaunch.Rows[grdLaunch.CurrentCell.RowIndex].Cells[5].Value.ToString();
            txtPassword.Text = grdLaunch.Rows[grdLaunch.CurrentCell.RowIndex].Cells[6].Value.ToString();
            Boolean i = bool.Parse(grdLaunch.Rows[grdLaunch.CurrentCell.RowIndex].Cells[7].Value.ToString());
            if (i == true)
            {
                chkDebug.Checked = true;
            }
            else
            {
                chkDebug.Checked = false;
            }
            if (grdLaunch.Rows[grdLaunch.CurrentCell.RowIndex].Cells[8].Value.ToString() != "-")
            {
                chkAction.Checked = true;
                txtAction.Text = grdLaunch.Rows[grdLaunch.CurrentCell.RowIndex].Cells[8].Value.ToString();
            }
            else
            {
                chkAction.Checked = false;
                txtAction.Text = null;
            }
            if (grdLaunch.Rows[grdLaunch.CurrentCell.RowIndex].Cells[9].Value.ToString() != "-")
            {
                chkSession.Checked = true;
                txtSession.Text = grdLaunch.Rows[grdLaunch.CurrentCell.RowIndex].Cells[9].Value.ToString();
            }
            else
            {
                chkSession.Checked = false;
                txtSession.Text = null;
            }

        }

        #endregion

        #region TEXTBOX EVENTS
        
        private void txtPort_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar)// samo brojevi u PORT polje
                && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Dopušteni su samo brojevi!");
            }
        }

        private void txtName_Leave(object sender, EventArgs e)
        {
            if (txtName.Text.Contains(" "))
            {
                MessageBox.Show("Ime ne smije sadržavati prazna mjesta (koristite underscore '_').");
                this.ActiveControl = txtName;
                String sel = txtName.SelectedText;
                //txtName.Focus();
            }
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in grdLaunch.Rows) // SearchAsYouType tekstom iz txtName
            {
                // Test if the first column of the current row equals
                // the value in the text box
                if (StringComparer.CurrentCultureIgnoreCase.Equals((string)row.Cells[1].Value, txtName.Text) == true)
                {
                    // we have a match
                    row.Selected = true;
                }
                else
                {
                    row.Selected = false;
                }
            }
        }

        #endregion

        public class AppName // pozivanje txt controli u druge clase npr. fmLauncher.AppName.appNameCombo
        // pa ovdje dodati po potrebi variable
        {
            public static string appNameCombo = string.Empty;

        }

        private void chkAction_CheckedChanged(object sender, EventArgs e)
        {
            if (chkAction.Checked == true)
            {
                txtAction.ReadOnly = false;
            }
            else
            {
                txtAction.ReadOnly = true;
            }
        }

        private void chkSession_CheckedChanged(object sender, EventArgs e)
        {
            if (chkSession.Checked == true)
            {
                txtSession.ReadOnly = false;
            }
            else
            {
                txtSession.ReadOnly = true;
            }
        }

        public static void UpdateAppSettings(string SectionName, string KeyName, string KeyValue) //koristi za update app config
        {
            XmlDocument XmlDoc = new XmlDocument();

            XmlDoc.Load(AppDomain.CurrentDomain.SetupInformation.ConfigurationFile);

            foreach (XmlElement xElement in XmlDoc.DocumentElement)
            {
                if (xElement.Name == SectionName)
                {

                    foreach (XmlNode xNode in xElement.ChildNodes)
                    {
                        if (xNode.Attributes[0].Value == KeyName)
                        {
                            xNode.Attributes[1].Value = KeyValue;
                        }
                    }
                }
            }
            XmlDoc.Save(AppDomain.CurrentDomain.SetupInformation.ConfigurationFile);
        }

        private void rdoCloseOption_CheckedChanged(object sender, EventArgs e)
        {
            string chosenOptionClose = "false";
            string chosenOptionMinimize = "false";
            string chosenOptionNothing = "false";
            if (rdoCloseOption.Checked == true)
            {
                chosenOptionClose = "true";
            }
            if (rdoMinimizeOption.Checked == true)
            {
                chosenOptionMinimize = "true";
            }
            if (rdoNothingOption.Checked == true)
            {
                chosenOptionNothing = "true";
            }
            UpdateAppSettings("chkbxSettings", "optCloseOnOpen", chosenOptionClose);
            UpdateAppSettings("chkbxSettings", "optMinimizeOnOpen", chosenOptionMinimize);
            UpdateAppSettings("chkbxSettings", "optDoNothing", chosenOptionNothing);
        }

        private void fmLauncher_Resize(object sender, EventArgs e)
        {
            if (FormWindowState.Minimized == this.WindowState)
            {
                nfyTrayMinimize.Visible = true;
                nfyTrayMinimize.ShowBalloonTip(500);
                this.Hide();
            }
            else if (FormWindowState.Normal == this.WindowState)
            {
                nfyTrayMinimize.Visible = false;
            }
        }

        private void nfyTrayMinimize_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            this.Show();
            this.WindowState = FormWindowState.Normal;
        }

        public IEnumerable<string> AssocPrograms(string ext) //read all programs associated with filetype
        {
            List<string> progs = new List<string>();

            string baseKey = @"Software\Microsoft\Windows\CurrentVersion\Explorer\FileExts\." + ext;

            using (RegistryKey rk = Registry.CurrentUser.OpenSubKey(baseKey + @"\OpenWithList"))
            {
                if (rk != null)
                {
                    string mruList = (string)rk.GetValue("MRUList");
                    if (mruList != null)
                    {
                        foreach (char c in mruList.ToString())
                            progs.Add(rk.GetValue(c.ToString()).ToString());
                    }
                }
            }

            using (RegistryKey rk = Registry.CurrentUser.OpenSubKey(baseKey + @"\OpenWithProgids"))
            {
                if (rk != null)
                {
                    foreach (string item in rk.GetValueNames())
                        progs.Add(item);
                }
                //TO DO: Convert ProgID to ProgramName, etc.
            }

            return progs;
        } 

        private void mnuAssocApps_Opening(object sender, CancelEventArgs e)
        {
            mnuAssocApps.Items.Clear();
            foreach (string prog in AssocPrograms("config"))
            {
                mnuAssocApps.Items.Add(prog);
            }
        }

        private void mnuAssocApps_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            ProcessStartInfo startInfo = new ProcessStartInfo();
            startInfo.FileName = e.ClickedItem.Text;
            startInfo.Arguments = "Launcher.exe.config";
            try
            {
                Process.Start(startInfo);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

    }
}


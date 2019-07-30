namespace SPFileZilla2013
{
     using System;
     using System.Windows.Forms;

     public partial class FormAbout : Form
     {
          #region Public Constructors

          public FormAbout()
          {
               InitializeComponent();
               btnOk.Focus();
               textBox1.Select(0, 0);
               pbFileZilla.Click += new EventHandler(pbFileZilla_Click);

               lblVersionNumber.Text = BandR.Consts.VERSION;
          }

          #endregion Public Constructors

          #region Private Methods

          private void btnOk_Click(object sender, EventArgs e)
          {
               this.Close();
          }

          private void pbFileZilla_Click(object sender, EventArgs e)
          {
               System.Diagnostics.Process.Start("https://filezilla-project.org/");
          }

          #endregion Private Methods
     }
}
using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using System.Security.Cryptography;
using System.Text;
using System.IO;

namespace LicenseGenerator
{
  public partial class LicGenForm : Form
  {
    public LicGenForm()
    {
      InitializeComponent();
    }

    private string GetLicenseText()
    {
      return GUID.Text + "#" + Expires.Value.ToShortDateString() + "#";
    }

    private void btnGenLicense_Click(object sender, System.EventArgs e)
    {
      GUID.Text = Guid.NewGuid().ToString();
      byte[] clear = ASCIIEncoding.ASCII.GetBytes(GetLicenseText());
      SHA1Managed provSHA1 = new SHA1Managed();
      byte[] hash = provSHA1.ComputeHash(clear);


      RSACryptoServiceProvider provRSA = new RSACryptoServiceProvider();
      PublicKey.Text = provRSA.ToXmlString(false);
      PrivateKey.Text = provRSA.ToXmlString(true);

      byte[] signature = provRSA.SignHash(hash, CryptoConfig.MapNameToOID("SHA1"));

      License.Text = GetLicenseText() + Convert.ToBase64String(signature, 0, signature.Length);

      //Make read only for copy / paste
      GUID.ReadOnly = true;
      GUID.BackColor = System.Drawing.SystemColors.ButtonFace;
      PublicKey.ReadOnly = true;
      PublicKey.BackColor = System.Drawing.SystemColors.ButtonFace;
      PrivateKey.ReadOnly = true;
      PrivateKey.BackColor = System.Drawing.SystemColors.ButtonFace;
      License.ReadOnly = true;
      License.BackColor = System.Drawing.SystemColors.ButtonFace;
    }

    private void btnClose_Click(object sender, System.EventArgs e)
    {
      this.Close();
    }

    private void btnValLicense_Click(object sender, System.EventArgs e)
    {
      // pull out the text portion of license before
      // the signature
      string[] values = License.Text.Split(new char[] { '#' });
      byte[] clear = ASCIIEncoding.ASCII.GetBytes(
         values[0] + "#" + values[1] + "#");

      // recompute the hash value
      SHA1Managed provSHA1 = new SHA1Managed();
      byte[] hash = provSHA1.ComputeHash(clear);

      // reload the RSA provider based on the public key only
      RSACryptoServiceProvider provRSA = new RSACryptoServiceProvider();
      provRSA.FromXmlString(PublicKey.Text);

      // split out the signature portion of the license
      byte[] sigBytes = Convert.FromBase64String(values[2]);

      // verify the signature of the hash
      bool result = provRSA.VerifyHash(hash, CryptoConfig.MapNameToOID("SHA1"),
         sigBytes);
      MessageBox.Show("Signature verified:" + result);
    }

    private void btnCreateFile_Click(object sender, System.EventArgs e)
    {
      Stream stm;
      saveFileDialog1.Filter = " License Files (*.lic) |*.lic|All files (*.*)|*.*"  ;
      saveFileDialog1.DefaultExt = "lic";
      if (DialogResult.OK == saveFileDialog1.ShowDialog(this))
      {
        if ((stm = saveFileDialog1.OpenFile()) != null)
          stm.Close();
        //string filename = saveFileDialog1.FileName;

        // create a new file or truncate existing one
        // while pushing license string to it
        //FileStream stm = new FileStream(filename, FileMode.Truncate);
        //StreamWriter wtr = new StreamWriter(stm);
        //wtr.Write(License.Text);

        //// flush and close file buffers
        //wtr.Flush();
        //stm.Flush();
        //wtr.Close();
        //stm.Close();
      }
    }

    private void LicGenForm_Load(object sender, EventArgs e)
    {
      Expires.Value = DateTime.Now.Date.Add(new TimeSpan(365 * 10, 0, 0, 0));
    }
  }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Asp.NetDevelopHelper
{
    public partial class DPAPI_Tool : Form
    {
        public DPAPI_Tool()
        {
            InitializeComponent();
        }

        private void encBtn_Click(object sender, EventArgs e)
        {
            outputTxtbox.Text = Encrypt(inputTxtbox.Text);
        }
        private void reverseBtn_Click(object sender, EventArgs e)
        {
            outputTxtbox.Text = Decrypt(inputTxtbox.Text);

        }
        private string Encrypt(string plainText)
        {
            byte[] plainBytes = Encoding.UTF8.GetBytes(plainText);
            byte[] encryptedBytes = ProtectedData.Protect(
                plainBytes,
                null, // Optional entropy (additional secret)
                DataProtectionScope.CurrentUser); // Or DataProtectionScope.LocalMachine

            return Convert.ToBase64String(encryptedBytes);
        }
        
        private string Decrypt(string encryptedText)
        {
            byte[] encryptedBytes = Convert.FromBase64String(encryptedText);
            byte[] plainBytes = ProtectedData.Unprotect(
                encryptedBytes,
                null, // Must match entropy used during encryption
                DataProtectionScope.CurrentUser); // Must match scope used during encryption

            return Encoding.UTF8.GetString(plainBytes);
        }
       
    }
}

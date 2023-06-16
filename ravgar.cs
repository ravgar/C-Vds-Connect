using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace UzakMasaustuBaglantisi
{
    public partial class Form1 : Form
    {
        private TextBox txtUserName;
        private TextBox txtIPAddress;
        private TextBox txtPassword;
        private Button btnConnect;

        public Form1()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.txtIPAddress = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.btnConnect = new System.Windows.Forms.Button();
            this.SuspendLayout();
            
            this.txtUserName.Location = new System.Drawing.Point(12, 12);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(200, 20);
            this.txtUserName.TabIndex = 0;
            this.txtUserName.Text = "Kullanıcı Adı";
          
            this.txtIPAddress.Location = new System.Drawing.Point(12, 38);
            this.txtIPAddress.Name = "txtIPAddress";
            this.txtIPAddress.Size = new System.Drawing.Size(200, 20);
            this.txtIPAddress.TabIndex = 1;
            this.txtIPAddress.Text = "IP Adresi";
          
            this.txtPassword.Location = new System.Drawing.Point(12, 64);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(200, 20);
            this.txtPassword.TabIndex = 2;
            this.txtPassword.Text = "Şifre";
           
            this.btnConnect.Location = new System.Drawing.Point(12, 90);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(200, 23);
            this.btnConnect.TabIndex = 3;
            this.btnConnect.Text = "Tamam";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            
            this.ClientSize = new System.Drawing.Size(224, 124);
            this.Controls.Add(this.btnConnect);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtIPAddress);
            this.Controls.Add(this.txtUserName);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Uzak Masaüstü Bağlantısı";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            string userName = txtUserName.Text;
            string ipAddress = txtIPAddress.Text;
            string password = txtPassword.Text;

            string arguments = $"/v:{ipAddress} /u:{userName} /p:{password}";

            try
            {
                Process.Start("mstsc", arguments);
                MessageBox.Show("Uzak masaüstü bağlantısı başlatıldı.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Bir hata oluştu: " + ex.Message);
            }
        }

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}

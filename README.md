# C#-Vds-Connect

```js
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
  ```

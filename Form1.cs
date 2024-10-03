using System;
using Microsoft.Win32;
using System.Windows.Forms;

namespace LastAccessLogger
{
    public partial class Form1 : Form
    {
        private const string RegistryKeyPath = @"SOFTWARE\CalculatorApp\LastAccess";

        public Form1()
        {
            InitializeComponent();
            LogLastAccess();
        }

        private void LogLastAccess()
        {
            try
            {
                using (RegistryKey key = Registry.CurrentUser.CreateSubKey(RegistryKeyPath))
                {
                    if (key != null)
                    {
                        key.SetValue("LastAccessTime", DateTime.Now.ToString());
                        key.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при записи в реестр: " + ex.Message);
            }
        }

        private void btnShowLastAccess_Click(object sender, EventArgs e)
        {
            try
            {
                using (RegistryKey key = Registry.CurrentUser.OpenSubKey(RegistryKeyPath))
                {
                    if (key != null)
                    {
                        var lastAccessTime = key.GetValue("LastAccessTime", "Нет данных").ToString();
                        MessageBox.Show("Последний доступ: " + lastAccessTime);
                    }
                    else
                    {
                        MessageBox.Show("Не найден ключ реестра.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при чтении из реестра: " + ex.Message);
            }
        }
    }
}

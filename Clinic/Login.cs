
using ClinicDB.Repository;
using Infra.Clinic.Entity;
using Serilog;
using Serilog.Core;
using Serilog.Events;
using Serilog.Formatting.Compact;

namespace Clinic
{
    public partial class Login : Form
    {
        public ILogger logger { get; set; }
        public Login()
        {
          
            logger = GlobalVariables.initializeLogger();
            GlobalVariables.LogCurrentUSer("Log in Page");
            
            InitializeComponent();
            
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                PatientRepository patientRepository = new PatientRepository();
                ClinicUser user = patientRepository.Login(txtUserName.Text.Trim(), txtPassword.Text.Trim(),logger);
                if (user != null)
                {
                    GlobalVariables.LoggedUserName = txtUserName.Text.Trim();
                    GlobalVariables.loggedUserID = user.Id;
                    GlobalVariables.loggedUserDisplayName = user.DisplayName;

                    if (txtUserName.Text.Contains("user"))
                        GlobalVariables.ShowTabs = false;
                    else
                        GlobalVariables.ShowTabs = true;

                    MasterForm frm = new MasterForm();
                    frm.ShowDialog();
                    this.Close();
                    this.Dispose();
                }
                else
                {
                    logger.Information("Failed to login using username "+ txtUserName.Text + " and password "
                        + txtPassword.Text.Trim());
                    MessageBox.Show("Invalid User");
                }
            }
            catch(Exception ex)
            {
                logger.Error(ex,"Failed to login due to Prementioned Exception");

                MessageBox.Show(ex.ToString());
            }

            
           
        }
      
    }
}

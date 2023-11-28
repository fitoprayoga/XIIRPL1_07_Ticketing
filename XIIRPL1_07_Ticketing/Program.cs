using XIIRPL1_07_Ticketing.MasterForm;

namespace XIIRPL1_07_Ticketing
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            //Login login = new Login();
            //login.Show();
          
            //FrmMasterBandara bandara = new FrmMasterBandara ();
            //bandara.Show();
            //FrmMasterMaskapai maskapai = new FrmMasterMaskapai();
            //maskapai.Show();
            //FrmMasterJadwalPenerbangan jadwal_penerbangan = new FrmMasterJadwalPenerbangan();
            //jadwal_penerbangan.Show();
            FrmMasterKodePromo kode_promo = new FrmMasterKodePromo();
            kode_promo.Show();
            Application.Run();
        }
    }
}
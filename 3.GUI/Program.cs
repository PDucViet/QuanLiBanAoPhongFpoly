using _3.GUI.View;
using _3.GUI.View.BanHang;
using _3.GUI.View.FrmNhanvien;
using _3.GUI.View.FromSanPham;
using OfficeOpenXml.FormulaParsing.Excel.Functions.Math;

namespace _3.GUI
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            Application.Run(new FRDangNhap());
            //daonvph18705 @gmail.com
        }
    }
}
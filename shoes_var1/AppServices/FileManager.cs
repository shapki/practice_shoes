using System.Windows.Forms;

namespace shoes.AppServices
{
    internal class FileManager
    {
        public static string GetImgPath(string fileName)
        {
            return System.IO.Path.Combine(Application.StartupPath, "img", fileName);
        }

    }
}

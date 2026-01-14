using System;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;

namespace shoes.AppServices
{
    internal class FileManager
    {
        public static string GetImgPath(string fileName)
        {
            return System.IO.Path.Combine(Application.StartupPath, "img", fileName);
        }

        internal static void DeleteFile(string photo)
        {
            if (string.IsNullOrWhiteSpace(photo))
            {
                return;
            }

            try
            {
                File.Delete(GetImgPath(photo));
            }
            catch (Exception e)
            {
                Debug.Print($"Не удалось удалить файл {photo}."); // PKGH Отладочная печать.                
            }
        }
    }
}

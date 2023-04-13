using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace ImageDBSave 
{
    class AppCommands 
    {


        //load

        public void ImageLoaded(/*Action<string> mes,*/ Action<string> filetitle)
        {

            string filename = @"TestSource\587bcd241466d.jpg"; //путь к файлу
            //string filetitle = "кот"; //Название файла
            string shortFileName = filename.Substring(filename.LastIndexOf('\\') + 1); //короткое имя для сохранения
            byte[] imageData;
            using (System.IO.FileStream fs = new System.IO.FileStream(filename, System.IO.FileMode.Open))
            {
                imageData = new byte[fs.Length];
                fs.Read(imageData, 0, imageData.Length);
            }
            //mes("Функция находится в разработке.");
            filetitle("Кот");
        }

        //search

        public void ImageSearch(Action<string> mes/*, Action<string> vis*/)
        {
            mes("Функция находится в разработке.");
            //vis("= Visibility.Visible");
        }
        

        //enter
        public void btEnter()
        {
            AuthorizationWindow authorizationWindow = new();
            authorizationWindow.Show();
            
        }

        //application close

        public void AppClose()
        {

        }
    }
}

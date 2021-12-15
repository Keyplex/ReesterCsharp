using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Win32;

namespace ReesterCsharp
{
    class Program
    {
        static void Main(string[] args)
        {
            //RegistryKey currentUserKey = Registry.CurrentUser; // HKEY_CURRENT_USER
            //RegistryKey helloKey = currentUserKey.CreateSubKey("MyKolobovPavel"); // Создать папку
            //MessageBox.Show(null, "Ключ успешно создан", "Информация", MessageBoxButtons.OK);
            //helloKey.SetValue("Привет", "Как дела?");
            //MessageBox.Show(null, "Имя и значение успешно создан", "Информация", MessageBoxButtons.OK);
            //helloKey.SetValue("password", "12345");
            //MessageBox.Show(null, "Имя(пароль) и значение(число) успешно создан", "Информация", MessageBoxButtons.OK);
            //helloKey.Close();


            ////Считаем и проверяем сохраненные в реестре значения:
            //RegistryKey currentUserKey = Registry.CurrentUser;
            //RegistryKey helloKey = currentUserKey.OpenSubKey("MyKolobovPavel");
            //string login = helloKey.GetValue("Привет", "Как дела?").ToString(); //Работает
            //string password = helloKey.GetValue("password", "12345").ToString(); //Работает
            //helloKey.Close();
            //Console.WriteLine(login);
            //Console.WriteLine(password);

            ////В конце удалим значения из ключа и сам ключ из реестра:
            //RegistryKey currentUserKey = Registry.CurrentUser;
            //RegistryKey helloKey = currentUserKey.OpenSubKey("MyKolobovPavel", true);
            //// удалить вложенный ключ
            ////helloKey.DeleteSubKey("SubHelloKey");
            //// удалить значение из ключа
            ////helloKey.DeleteValue("Привет");
            ////helloKey.Close();
            //// удаляем сам ключ
            //currentUserKey.DeleteSubKey("MyKolobovPavel");



        }
    }
}

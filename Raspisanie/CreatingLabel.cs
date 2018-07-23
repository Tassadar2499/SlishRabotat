using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IWshRuntimeLibrary;

namespace Raspisanie
{
	class CreatingLabel
	{
		public static void CreateShortcut()
		{
			WshShell shell = new WshShell();

			//путь к ярлыку
			string shortcutPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + @"\Schedule Maker Over Power 40k.lnk";

			//создаем объект ярлыка
			IWshShortcut shortcut = (IWshShortcut)shell.CreateShortcut(shortcutPath);

			//задаем свойства для ярлыка
			//описание ярлыка в всплывающей подсказке
			shortcut.Description = "Ярлык для ээээ";
			//горячая клавиша
			shortcut.Hotkey = "Ctrl+Shift+N";
			//путь к самой программе
			shortcut.TargetPath = Environment.GetFolderPath(Environment.SpecialFolder.System) + @"\Raspisanie.exe";

			//Создаем ярлык
			shortcut.Save();
		}
	}
}

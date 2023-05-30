using Lab_PIC_5.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace Lab_PIC_5.Data
{
    internal class AppRepository
    {
        public static App[] ApplicatiionsMas =
        {
            new App("01.01.2023", "1", "г. Тюмень", "р-н Ленинский", "около дома 10", "10", "Белая собака с черным ухом, порода неизвестна,", "Физ. лицо"),
            new App("15.02.2023", "2", "г. Тюмень","р-н Калининский", "около магазина Магнит", "15", "Рыжая собака", "Физ. лицо"),
            new App("20.03.2023", "3","г. Ялуторовск", "мкр. 10", "двор дома №6", "7", "Черная собака", "Физ. лицо")
        };

        public static List<App> Applicatiions = new List<App>(ApplicatiionsMas);

        public static void Save(App app)
        {
            var id = Applicatiions.FindIndex(x => x.number == app.number);
            Applicatiions[id] = app;
        }

        public static void Del(App app)
        {
            Applicatiions.Remove(app);
        }
    }
}

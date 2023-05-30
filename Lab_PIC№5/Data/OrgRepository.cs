using Lab_PIC_5.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_PIC_5.Data
{
    internal class OrgRepository
    {
        public static Organization[] OrganizationsMas =
        {
            new Organization("МКУ «ЛесПаркХоз»", "3664069397", "770201001", "г. Москва, ул. Ленина 56", "Коммерческий", "действующее"),
            new Organization("ГосОтлов", "9574637594","770495001", "г. Москва, ул. Абрамцевская 34", "Государственная организация", "действующее"),
            new Organization("ПРОО «Общество защиты животных»", "5769384756", "720294631", "г. Тюмень ул. Мельникайте 48", "Коммерческий", "действующее")
        };

        public static List<Organization> Organizations = new List<Organization>(OrganizationsMas);

        public static void Save()
        {

        }

        public static void Del(Organization organization)
        {
            Organizations.Remove(organization);
        }
    }
}

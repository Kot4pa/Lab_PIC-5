using Lab_PIC_5.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_PIC_5.Data
{
    class ActRepository
    {
        public static List<Act> acts = new List<Act>
        {
            new Act(1, 4, 0, OrgRepository.Organizations[0], DateTime.Parse("01-06-23"), "Отловить 4 собаки",
                    AppRepository.Applicatiions[0], ContractRepository.contract[1]),

            new Act(2, 0, 4, OrgRepository.Organizations[1], DateTime.Parse("02-06-23"), "Отловить 4 кошки",
                    AppRepository.Applicatiions[1], ContractRepository.contract[0]),

            new Act(3, 3, 2, OrgRepository.Organizations[2], DateTime.Parse("03-06-23"), "Отловить 3 собаки и 2 кошки",
                    AppRepository.Applicatiions[2], ContractRepository.contract[1]),

        };


        public static List<AnimalCard> animalCards = new List<AnimalCard>
        {
            new AnimalCard(1, "Собака", "Женский", "Лабрадор", 40, "Длинная", "Рыжий",
                            "Висячие", "Длинный", "", "Метка 2",
                            LocationCostReposiroty.locationCosts[0],
                            acts[0],
                            null),

            new AnimalCard(2, "Кот", "Мужской", "Британская", 30, "Короткая", "Черный",
                            "Прямые", "Короткий", "", "Метка 1",
                            LocationCostReposiroty.locationCosts[0],
                            acts[1],
                            null),

            new AnimalCard(4, "Собака", "Женский", "Немецкая овчарка", 50, "Длинная", "Черно-серый",
                            "Висячие", "Длинный", "", "Метка 4",
                            LocationCostReposiroty.locationCosts[1],
                            acts[2],
                            null),
                        
            new AnimalCard(3, "Кот", "Мужской", "Сиамская", 25, "Короткая", "Серый",
                            "Прямые", "Длинный", "", "Метка 3",
                            LocationCostReposiroty.locationCosts[0],
                            acts[2],
                            null),
        };

        public static void SaveActData(Act actData)
        {
            var index = acts.FindIndex(x => x.ActNumber == actData.ActNumber);
            acts[index] = actData;
        }

        public static void Save(Act A)
        {
            acts.Add(A);
        }

        public static void Delete(int choosedAct)
        {
            var index = acts.FindIndex(x => x.ActNumber == choosedAct);
            acts.RemoveAt(index);
        }

        public static List<Act> ShowAct(string filter)
        {
            List<Act> returnAct = acts.Where(x => x.Date >= DateTime.Parse(filter)).ToList();
            return returnAct;
        }
    }
}

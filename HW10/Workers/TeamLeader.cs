using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW10
{
    public class TeamLeader : IWorker
    {
        public string WorkerName { get; set; }

        public string Report(House house)
        {
            if (house.Basement is null)
            {
                return "Дом еще не начал постройку. ";
            }
            else if (house.Walls.Count < 4)
            {
                return "Фундамент залит, начинаем строить стены. ";
            }
            else if (house.Door is null)
            {
                return "Фундамент залит, стены построены, работаем над дверью! ";
            }
            else if (house.Windows.Count < 4)
            {
                return "Фундамент, стены, двери сделаны, осталось окна поставить. ";
            }
            else if (house.Roof is null)
            {
                return "Осталась крышу достроить и готово! ";
            }
            return "Дом готов! ";
        }
    }
}

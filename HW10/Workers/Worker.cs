using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW10
{
    public class Worker : IWorker
    {
        public string WorkerName { get; set; }

        public void Build(House house)
        {
            if(house.Basement is null)
            {
                house.Basement = new Basement() { PartFigure = "Бригада ", PartName = "Basement" };
            }
            else if(house.Walls.Count < 4)
            {
                house.Walls.Add(new Wall(){ PartName = "Wall", PartFigure = "закончила " });
            }
            else if(house.Door is null)
            {
                house.Door = new Door() { PartName = "Door", PartFigure = "строить " };
            }
            else if(house.Windows.Count < 4)
            {
                house.Windows.Add(new Window() { PartName = "Window", PartFigure = "дом " });
            }
            else if(house.Roof is null)
            {
                house.Roof = new Roof() { PartName = "Roof", PartFigure = "!!!" };
            }
        }
    }
}

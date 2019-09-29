using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW10.Workers
{
    public class Team
    {
        public House House { get; set; } = new House();
        public Worker Worker { get; set; } = new Worker();
        public TeamLeader TeamLeader { get; set; } = new TeamLeader();

        public void StartBuilding()
        {
            Console.WriteLine("Press 'Spacebar' to get a report");
            Console.WriteLine("Press any key to build house part");
            while (true)
            {
                if(Console.ReadKey().Key == ConsoleKey.Spacebar)
                {
                    Console.WriteLine(TeamLeader.Report(House));
                }
                else
                {
                    Worker.Build(House);
                }
                if (isFinish())
                {
                    Console.WriteLine(House.Basement.PartFigure + House.Walls[0].PartFigure + House.Door.PartFigure + House.Windows[0].PartFigure + House.Roof.PartFigure);
                }
            }
        }

        public bool isFinish()
        {
            if (TeamLeader.Report(House) == "Дом готов! ")
                return true;
            return false;
        }
    }
}

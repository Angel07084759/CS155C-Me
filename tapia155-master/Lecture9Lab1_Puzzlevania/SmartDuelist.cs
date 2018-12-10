/// Lecture9	        Exercise No. Lab1
/// File Name:          SmartDuelist.cs
/// @author:            Kevin Lewis: Edited by Angel Tapia
/// Date:               October 29, 2018
///
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture9Lab1_Puzzlevania
{
    class SmartDuelist : Duelist
    {
        private bool missFirst = true;
        public SmartDuelist(String name, double probability) : base(name, probability)
        {
            missFirst = true;
        }
        public override void ShootAt(Duelist duelist)
        {
            if (missFirst)
            {
                missFirst = false;
            }
            else
            {
                base.ShootAt(duelist);
            }
        }

        public override void Reset()
        {
            missFirst = true;
            base.Reset();
        }

    }
}

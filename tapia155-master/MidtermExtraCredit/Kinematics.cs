/// Chapter No. MidtermExtraCredit
/// File Name:          MidtermExtraCredit.cs
/// @author:            Angel Tapia
/// Date:               October 8, 2018
/// 
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MidtermExtraCredit
{
    class Kinematics
    {
        private double deltaT;
        private double deltaV;
        private double deltaP;
        private double tInitial;
        private double tFinal;
        private double vInitial;
        private double vFinal;
        private double pInitial;
        private double pFinal;        
        private double acceleration;
        
  
        public bool SetDeltaT(double deltaT)//Time cannot be negative
        {
            if (deltaT < 0)
            {
                return false;
            }
            this.deltaT = deltaT;
            return true;
        }
        public void SetDeltaV(double deltaV)
        {
            this.deltaV = deltaV;

        }
        public void SetDeltaP(double deltaP)
        {
            this.deltaP = deltaP;
        }
        public bool SetTInitial(double tInitial)//Time cannot be negative
        {
            if (tInitial < 0)
            {
                return false;
            }
            this.tInitial = tInitial;
            return true;
        }
        public bool SetTFinal(double tFinal)//Time cannot be negative
        {
            if (tFinal < tInitial)
            {
                return false;
            }
            this.tFinal = tFinal;
            return true;
        }       
        public void SetVInitial(double vInitial)
        {
            this.vInitial = vInitial;
        }
        public void SetVFinal(double vFinal)
        {
            this.vFinal = vFinal;
        }
        public void SetPInitial(double pInitial)
        {
            this.pInitial = pInitial;
        }
        public void SetPFinal(double pFinal)
        {
            this.pFinal = pFinal;
        }
        public void SetAcceleration(double acceleration)
        {
            this.acceleration = acceleration;
        }



        public double GetDeltaT()
        {
            return this.deltaT;
        }
        public double GetDeltaV()
        {
            return this.deltaV;
        }        
        public double GetDeltaP()
        {
            return this.deltaP;
        }
        public double GetTInitial()
        {
            return this.tInitial;
        }
        public double GetTFinal()
        {
            return this.tFinal;
        }
        public double GetVInitial()
        {
            return this.vInitial;
        }
        public double GetVFinal()
        {
            return this.vFinal;
        }
        public double GetPInitial()
        {
            return this.pInitial;
        }
        public double GetPFinal()
        {
            return this.pFinal;
        }
        public double GetAcceleration()
        {
            return this.acceleration;
        }




        public bool SolveDeltaT()
        {
            if ((tFinal - tInitial) < 0)//Time cannot be negative
            {
                return false;
            }
            if (acceleration != 0 && vInitial != vFinal)
            {
                deltaT = (vFinal - vInitial) / acceleration;
                return true;
            }

            if ((vFinal + vInitial) != 0 && deltaP != 0)
            {
                deltaT = deltaP / ((0.5) * (vInitial + vFinal));
                return true;
            }

            if (acceleration != 0)
            {
                double a = (0.5) * (acceleration);
                double b = vInitial;
                double c = deltaP;
                double sqrt = Math.Sqrt(Math.Abs(b * b - (4 * a * c)));
                double ansNeg = (b - sqrt) / 2.0 * a;
                double ansPos = (b + sqrt) / 2.0 * a;
                if (ansNeg >= 0 || ansPos >= 0)
                { 
                    deltaT = ansNeg > ansPos ? ansNeg : ansPos;
                    return true;
                }
            }
            return false;
        }


        public bool SolveDeltaV()
        {
            if (SolveDeltaT() && deltaT <= 0)//Time cannot be negative nor zero
            {
                return false;
            }
            if (acceleration != 0 && deltaT != 0)
            {
                deltaV = vInitial + (acceleration * deltaT);
                return true;
            }
            if (deltaP != 0 && acceleration != 0)
            {
                deltaV = Math.Sqrt(Math.Abs((vInitial * vInitial) + (2 * acceleration * deltaP)));
                return true;
            }

            return false;
        }
        public bool SolveDeltaP()
        {
            if (SolveDeltaT() && deltaT <= 0)//Time cannot be negative nor zero
            {
                return false;
            }
            deltaP = (pFinal - pInitial) / deltaT;
            return true;
        }
        public bool SolveVFinal()
        {
            if (SolveDeltaT() && deltaT <= 0)//Time cannot be negative nor zero
            {
                return false;
            }
            if (acceleration != 0 && deltaT != 0)
            {
                vFinal = vInitial + (acceleration * deltaT);
                return true;
            }
            if (deltaP != 0 && acceleration != 0)
            {
                vFinal = Math.Sqrt(Math.Abs((vInitial * vInitial) + (2 * acceleration * deltaP)));
                return true;
            }

            return false;
        }

        public bool SolveVInitial()
        {
            if (SolveDeltaT() && deltaT <= 0)//Time cannot be negative nor zero
            {
                return false;
            }
            if (acceleration != 0 && deltaT != 0)
            {
                vInitial = vFinal - (acceleration * deltaT);
                return true;
            }
            if (deltaP != 0 && acceleration != 0)
            {
                vFinal = Math.Sqrt(Math.Abs((vFinal * vFinal) - (2 * acceleration * deltaP)));
                return true;
            }
            return false;
        }


        public override string ToString()
        {
            string temp = "DeltaT: " + deltaT;
            temp += "     DeltaV: " + deltaV;
            temp += "     DeltaX: " + deltaP;
            temp += "     T-Initial: " + tInitial;
            temp += "     T-Final: " + tFinal;
            temp += "     V-Initial: " + vInitial;
            temp += "     V-Final: " + vFinal;
            temp += "     X-Initial: " + pInitial;
            temp += "     X-Final: " + pFinal;
            temp += "     Acceleration: " + acceleration;
            return temp;
        }

        public override bool Equals(object obj)
        {
            if (null == obj)
            {
                return false;
            }
            Kinematics other = (Kinematics)obj;
            return deltaT == other.deltaT
                && deltaV == other.deltaV
                && deltaP == other.deltaP
                && tInitial == other.tInitial
                && tFinal == other.tFinal
                && vInitial == other.vInitial
                && vFinal == other.vFinal
                && pInitial == other.pInitial
                && pFinal == other.pFinal
                && acceleration == other.acceleration;
        }

    }
}

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NUnit_DemoProject
{
    public class DemeritPointsCalculator
    {
        private const int SpeedLimit = 80;
        public int CalculateDemeritPoints(int speed)
        {
            if (speed < 0)
                throw new ArgumentOutOfRangeException();

            if (speed <= SpeedLimit)
                return 0;

            const int kmPerDemeritPoint = 5;
            var demeritPoints = (speed - SpeedLimit)/ kmPerDemeritPoint;
            return demeritPoints;

        }
    }
}

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week3_Day3INHERITANCE
{
    class Boat : Vehicle
    {
        private double waterDrag;
        public Boat(int seats, int carryingCapacity, string color, double movementSpeed, double waterDrag)
        {
            this.seats = seats;
            this.carryingCapacity = carryingCapacity;
            this.color = color;
            this.waterDrag = waterDrag;
            this.movementSpeed = movementSpeed;

        }


        public override void Move()
        {
            distanceTraveled += movementSpeed * waterDrag;
        }

























    }

}

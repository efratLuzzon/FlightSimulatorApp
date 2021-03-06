﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FlightMobileApp.Models
{
    public class Command
    {
        [JsonConstructor]
        public Command(double aileron, double rudder, double elevator, double throttle)
        {
            Aileron = aileron;
            Rudder = rudder;
            Elevator = elevator;
            Throttle = throttle;
        }
        [JsonProperty("aileron")]
        public double Aileron { get; set; }
        [JsonProperty("rudder")]
        public double Rudder { get; set; }
        [JsonProperty("elevator")]
        public double Elevator { get; set; }
        [JsonProperty("throttle")]
        public double Throttle { get; set; }

    }
}

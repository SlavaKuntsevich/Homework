﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace lesson12_13
{
    public class SquadMembers
    {
        [JsonPropertyName("name")]
        public string Name { get; set; }
        [JsonPropertyName("age")]
        public int Age { get; set; }
        [JsonPropertyName("secretIdentity")]
        public string SecretIdentity { get; set; }
        [JsonPropertyName("powers")]
        public string[] Powers { get; set; }


    }
}

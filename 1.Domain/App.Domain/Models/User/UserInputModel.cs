﻿using System.Collections.Generic;

namespace App.Domain
{
    public class UserInputModel
    {

        public Guid? id { get; set; }

        public string? nickname { get; set; }

        public string? fullname { get; set; }

        public string? phone { get; set; }

        public string? email { get; set; }

        public string? password { get; set; }

        public string? active_mode { get; set; }
    }
}

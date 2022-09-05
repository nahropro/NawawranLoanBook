﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NLB.Server.Models.Database;

public class User
{
    public int Id { get; set; }

    public string UserName { get; set; }

    public string PasswordHash { get; set; }

    public string Salt { get; set; }
}

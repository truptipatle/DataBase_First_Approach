using System;
using System.Collections.Generic;

namespace DatabaseFirstWith_MVC_Temp.Models;

public partial class Employee
{
    public int Id { get; set; }

    public string Ename { get; set; } = null!;

    public string Ecity { get; set; } = null!;

    public string? Egender { get; set; }
}

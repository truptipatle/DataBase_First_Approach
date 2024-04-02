using System;
using System.Collections.Generic;

namespace DatabaseFirstWith_MVC_Temp.Models;

public partial class Student
{
    public int Id { get; set; }

    public string Sname { get; set; } = null!;

    public string Sgender { get; set; } = null!;

    public string Age { get; set; } = null!;
}

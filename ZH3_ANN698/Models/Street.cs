using System;
using System.Collections.Generic;

namespace ZH3_ANN698.Models;

public partial class Street
{
    public int StreetId { get; set; }

    public string StreetName { get; set; } = null!;

    public int? PostalCodeId { get; set; }

    public virtual PostalCode? PostalCode { get; set; }
}

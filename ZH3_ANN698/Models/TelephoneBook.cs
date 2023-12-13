using System;
using System.Collections.Generic;

namespace ZH3_ANN698.Models;

public partial class TelephoneBook
{
    public int PersonId { get; set; }

    public string FirstName { get; set; } = null!;

    public string LastName { get; set; } = null!;

    public string Region { get; set; } = null!;

    public string Sex { get; set; } = null!;

    public string PhoneNumber { get; set; } = null!;

    public int? PostalCodeId { get; set; }

    public virtual PostalCode? PostalCode { get; set; }
}

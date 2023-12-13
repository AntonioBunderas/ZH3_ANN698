using System;
using System.Collections.Generic;

namespace ZH3_ANN698.Models;

public partial class PostalCode
{
    public int PostalCodeId { get; set; }

    public string Code { get; set; } = null!;

    public virtual ICollection<Street> Streets { get; set; } = new List<Street>();

    public virtual ICollection<TelephoneBook> TelephoneBooks { get; set; } = new List<TelephoneBook>();
}

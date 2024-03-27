﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace modpackApi.Models;

public partial class InspirationSpecification
{
    public int InspirationSpecificationId { get; set; }

    public int InspirationId { get; set; }

    public int ComponentId { get; set; }

    public int? MaterialId { get; set; }

    public int? ColorId { get; set; }

    public int? Location { get; set; }

    public int? SizeX { get; set; }

    public int? SizeY { get; set; }

    public virtual Color Color { get; set; }

    public virtual Component Component { get; set; }

    public virtual Inspiration Inspiration { get; set; }

    public virtual Material Material { get; set; }
}
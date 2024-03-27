﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace modpackApi.Models;

public partial class Member
{
    public int MemberId { get; set; }

    public int? LevelId { get; set; }

    public string Account { get; set; }

    public string Password { get; set; }

    public string Name { get; set; }

    public string Email { get; set; }

    public string Phone { get; set; }

    public string Address { get; set; }

    public DateTime CreationTime { get; set; }

    public DateTime ModificationTime { get; set; }

    public bool IsConfirmed { get; set; }

    public virtual ICollection<Cart> Carts { get; set; } = new List<Cart>();

    public virtual ICollection<Credit> Credits { get; set; } = new List<Credit>();

    public virtual ICollection<Customized> Customizeds { get; set; } = new List<Customized>();

    public virtual ICollection<Favorite> Favorites { get; set; } = new List<Favorite>();

    public virtual MemberLevel Level { get; set; }

    public virtual ICollection<MemberActivitylog> MemberActivitylogs { get; set; } = new List<MemberActivitylog>();

    public virtual ICollection<Order> Orders { get; set; } = new List<Order>();

    public virtual ICollection<ServiceRecord> ServiceRecords { get; set; } = new List<ServiceRecord>();
}
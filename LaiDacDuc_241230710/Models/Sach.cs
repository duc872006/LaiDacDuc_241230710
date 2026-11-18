using System;
using System.Collections.Generic;

namespace LaiDacDuc_241230710.Models;

public partial class Sach
{
    public int MaSach { get; set; }

    public int MaTl { get; set; }

    public string TenSach { get; set; } = null!;

    public decimal? Gia { get; set; }

    public string? Anh { get; set; }

    public virtual TheLoai MaTlNavigation { get; set; } = null!;
}

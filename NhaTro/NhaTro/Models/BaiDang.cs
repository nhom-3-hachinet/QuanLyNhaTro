﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace NhaTro.Models
{
    [Table("BaiDang")]
    public class BaiDang
    {
        [Key]
        [StringLength(8)]
        public string MaTin { get; set; }
        [StringLength(200)]
        [DisplayName("Tiêu Đề")]
        public string TieuDe { get; set; }
        [StringLength(50)]
        [DisplayName("Giá")]
        public string Gia { get; set; }
        [StringLength(30)]
        [DisplayName("Ảnh Bìa")]
        public string AnhBia { get; set; }
        [StringLength(100)]
        [DisplayName("Địa Chỉ")]
        public string DiaChi { get; set; }
        public string MaQH { get; set; }
        public string MaTTP { get; set; }
        [StringLength(12)]
        [DisplayName("Số Điện Thoại")]
        public string SDT { get; set; }
        [DisplayName("Mới")]
        public int Moi { get; set; }
        public virtual TinhTP TinhTP { get; set; }
        public virtual QuanHuyen QuanHuyen { get; set; }

    }
}
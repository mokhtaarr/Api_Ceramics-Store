﻿
using System.ComponentModel.DataAnnotations;

namespace Dashboard_Ecommerce.Dtos
{
    public class BrandDto
    {
        public int BrandId { get; set; }
        [Required, StringLength(50)]
        public string DescA { get; set; }

        [Required, StringLength(50)]
        public string DescE { get; set; }
    }
}

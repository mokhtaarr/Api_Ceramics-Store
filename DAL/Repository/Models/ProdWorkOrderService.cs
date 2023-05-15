﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Repository.Models
{
    [Table("Prod_WorkOrderServices")]
    public partial class ProdWorkOrderService
    {
        [Key]
        public int WorkOrderServiceId { get; set; }
        public int? WorkOrderId { get; set; }
        [Column("JOrderEmpDocDetailId")]
        public int? JorderEmpDocDetailId { get; set; }
        [Column("JOrderEmpDocId")]
        public int? JorderEmpDocId { get; set; }
        public int? EmpId { get; set; }
        public int? BillOfMaterialId { get; set; }
        [Column(TypeName = "decimal(25, 3)")]
        public decimal? ServiceValue { get; set; }
        [Column(TypeName = "decimal(18, 3)")]
        public decimal? TimeBeforFormat { get; set; }
        /// <summary>
        /// 1 Minutes, 2 Hours,3 Days, 4 Months
        /// </summary>
        public byte? TimeUnit { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        public decimal? Minutes { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        public decimal? Hours { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        public decimal? Days { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        public decimal? Months { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        public decimal? OtherCost { get; set; }
        [StringLength(250)]
        public string? Remarks { get; set; }
        [StringLength(20)]
        public string? CreatedBy { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? CreatedAt { get; set; }
        [StringLength(20)]
        public string? UpdateBy { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? UpdateAt { get; set; }

        [ForeignKey("WorkOrderId")]
        [InverseProperty("ProdWorkOrderServices")]
        public virtual ProdWorkOrder? WorkOrder { get; set; }
    }
}
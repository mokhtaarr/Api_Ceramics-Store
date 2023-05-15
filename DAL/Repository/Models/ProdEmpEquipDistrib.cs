﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Repository.Models
{
    [Table("Prod_EmpEquipDistrib")]
    public partial class ProdEmpEquipDistrib
    {
        public ProdEmpEquipDistrib()
        {
            ProdEmpEquipDistribDetails = new HashSet<ProdEmpEquipDistribDetail>();
        }

        [Key]
        public int EmpEquipDistId { get; set; }
        public int? StoreId { get; set; }
        public int? BookId { get; set; }
        public int? TermId { get; set; }
        public int? FinancialIntervalsId { get; set; }
        [Column("AId")]
        public int? Aid { get; set; }
        public int TrNo { get; set; }
        [StringLength(40)]
        public string? ManualTrNo { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? TrDate { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? TimeFrom { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? TimeTo { get; set; }
        [StringLength(100)]
        public string? Remarks1 { get; set; }
        [StringLength(100)]
        public string? Remarks2 { get; set; }
        [StringLength(200)]
        public string? Remarks3 { get; set; }
        public int? TermCostCenterId { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? TermCostCenterValue { get; set; }
        /// <summary>
        /// True  Closed ;  False  Not Closed
        /// </summary>
        public bool? Closed { get; set; }
        public bool? IsPrinted { get; set; }
        public bool? IsDelivered { get; set; }
        public bool? IsPosted { get; set; }
        public int? ShiftId { get; set; }
        [StringLength(20)]
        public string? Postedby { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? PostedDate { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? CloseDate { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? UncloseDate { get; set; }
        public int? ClosedBy { get; set; }
        public int? UnclosedBy { get; set; }
        public int? PermPrinted { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? PermPrintedAt { get; set; }
        [StringLength(20)]
        public string? CreatedBy { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? CreatedAt { get; set; }
        [StringLength(20)]
        public string? UpdateBy { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? UpdateAt { get; set; }
        [StringLength(20)]
        public string? DeletedBy { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? DeletedAt { get; set; }

        [InverseProperty("EmpEquipDist")]
        public virtual ICollection<ProdEmpEquipDistribDetail> ProdEmpEquipDistribDetails { get; set; }
    }
}

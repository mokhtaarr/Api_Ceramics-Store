﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DAL.Repository.Models
{
    [Table("Ms_ItemStockAdjustment")]
    public partial class MsItemStockAdjustment
    {
        public MsItemStockAdjustment()
        {
            MsItemStockAdjustmentDetails = new HashSet<MsItemStockAdjustmentDetail>();
        }

        [Key]
        public int StockAdjustId { get; set; }
        public int? BookId { get; set; }
        public int? TermId { get; set; }
        public int? StorId { get; set; }
        public int? StorePartId { get; set; }
        public int? FinancialIntervalsId { get; set; }
        [Column("AId")]
        public int? Aid { get; set; }
        public int? TrNo { get; set; }
        [StringLength(40)]
        public string? ManualTrNo { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? TrDate { get; set; }
        [StringLength(100)]
        public string? Name1 { get; set; }
        [StringLength(100)]
        public string? Name2 { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? StockTotalCost { get; set; }
        [StringLength(200)]
        public string? Remarks { get; set; }
        [StringLength(100)]
        public string? AddField3 { get; set; }
        [StringLength(100)]
        public string? AddField4 { get; set; }
        [StringLength(100)]
        public string? AddField5 { get; set; }
        [StringLength(100)]
        public string? AddField6 { get; set; }
        [StringLength(100)]
        public string? AddField7 { get; set; }
        public bool? IsStockOpenning { get; set; }
        public bool? IsReevaluation { get; set; }
        public bool? IsPrinted { get; set; }
        public int? TermCostCenterId { get; set; }
        [Column(TypeName = "numeric(38, 10)")]
        public decimal? TermCostCenterValue { get; set; }
        public bool? IsPosted { get; set; }
        [StringLength(20)]
        public string? Postedby { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? PostedDate { get; set; }
        /// <summary>
        /// True  Closed ;  False  Not Closed
        /// </summary>
        public bool? Closed { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? CloseDate { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? UncloseDate { get; set; }
        public int? ClosedBy { get; set; }
        public int? UnclosedBy { get; set; }
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
        public int? ShiftId { get; set; }

        [InverseProperty("StockAdjust")]
        public virtual ICollection<MsItemStockAdjustmentDetail> MsItemStockAdjustmentDetails { get; set; }
    }
}
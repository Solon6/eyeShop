//------------------------------------------------------------------------------
// <auto-generated>
//    此代码是根据模板生成的。
//
//    手动更改此文件可能会导致应用程序中发生异常行为。
//    如果重新生成代码，则将覆盖对此文件的手动更改。
// </auto-generated>
//------------------------------------------------------------------------------

namespace eyeShop
{
    using System;
    using System.Collections.Generic;
    
    public partial class H1261
    {
        public string File_No { get; set; }
        public int Seq_no { get; set; }
        public string job_no { get; set; }
        public string lot_no { get; set; }
        public int lot_seq_no { get; set; }
        public string frmloc_code { get; set; }
        public string Item_no { get; set; }
        public string batchno { get; set; }
        public decimal qty { get; set; }
        public decimal qty_finish { get; set; }
        public decimal qty_return { get; set; }
        public decimal qty_scrap { get; set; }
        public decimal org_seq_no { get; set; }
        public string remark { get; set; }
        public Nullable<decimal> unit_price { get; set; }
        public Nullable<decimal> Tax_Rate { get; set; }
        public Nullable<bool> TaxRate_Flag { get; set; }
        public Nullable<decimal> Amt_Tax { get; set; }
        public string Tran_Type { get; set; }
        public string TaxSt_Code { get; set; }
        public Nullable<decimal> Amt { get; set; }
    }
}
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace Trabajo06.Models
{
    [ModelMetadataType(typeof(SalesOrderDetailMetadata))]
    public partial class SalesOrderDetail { }
    public class SalesOrderDetailMetadata
    {
        /// <summary>
        /// Primary key. Foreign key to SalesOrderHeader.SalesOrderID.
        /// </summary>
        [Display(Name = "Id de Venta")]
        public int SalesOrderId { get; set; }

        /// <summary>
        /// Primary key. One incremental unique number per product sold.
        /// </summary>
        [Display(Name = "Id de Detalle de Venta")]
        public int SalesOrderDetailId { get; set; }

        /// <summary>
        /// Shipment tracking number supplied by the shipper.
        /// </summary>
        [Display(Name = "Numero de Seguimiento")]
        public string? CarrierTrackingNumber { get; set; }

        /// <summary>
        /// Quantity ordered per product.
        /// </summary>
        [Display(Name = "Cantidad de Producto")]
        public short OrderQty { get; set; }

        /// <summary>
        /// Product sold to customer. Foreign key to Product.ProductID.
        /// </summary>
        [Display(Name = "Id de Producto")]
        public int ProductId { get; set; }

        /// <summary>
        /// Promotional code. Foreign key to SpecialOffer.SpecialOfferID.
        /// </summary>
        [Display(Name = "Id de Codigo de Promocion")]
        public int SpecialOfferId { get; set; }

        /// <summary>
        /// Selling price of a single product.
        /// </summary>
        [Display(Name = "Precio Unitario")]
        public decimal UnitPrice { get; set; }

        /// <summary>
        /// Discount amount.
        /// </summary>
        [Display(Name = "Descuento de Precio Unitario")]
        public decimal UnitPriceDiscount { get; set; }

        /// <summary>
        /// Per product subtotal. Computed as UnitPrice * (1 - UnitPriceDiscount) * OrderQty.
        /// </summary>
        [Display(Name = "Calculo Total")]
        public decimal LineTotal { get; set; }

        /// <summary>
        /// ROWGUIDCOL number uniquely identifying the record. Used to support a merge replication sample.
        /// </summary>
        [Display(Name = "Id de Fila")]
        public Guid Rowguid { get; set; }

        /// <summary>
        /// Date and time the record was last updated.
        /// </summary>
        [Display(Name = "Fecha de Modificacion")]
        public DateTime ModifiedDate { get; set; }

        public virtual SalesOrderHeader SalesOrder { get; set; } = null!;
    }
}

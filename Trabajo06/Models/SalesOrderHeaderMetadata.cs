using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;
namespace Trabajo06.Models
{
    [ModelMetadataType(typeof(SalesOrderHeaderMetadata))]
    public partial class SalesOrderHeader { }
    public class SalesOrderHeaderMetadata
    {
        /// <summary>
        /// Primary key.
        /// </summary>
        [Display(Name = "Id Venta")]
        public int SalesOrderId { get; set; }

        /// <summary>
        /// Incremental number to track changes to the sales order over time.
        /// </summary>
        [Display(Name = "Numero de Revision")]
        public byte RevisionNumber { get; set; }

        /// <summary>
        /// Dates the sales order was created.
        /// </summary>
        [Display(Name = "Fecha de Pedido")]
        public DateTime OrderDate { get; set; }

        /// <summary>
        /// Date the order is due to the customer.
        /// </summary>
        [Display(Name = "Fecha Pendiente")]
        public DateTime DueDate { get; set; }

        /// <summary>
        /// Date the order was shipped to the customer.
        /// </summary>
        [Display(Name = "Fecha de envio")]
        public DateTime? ShipDate { get; set; }

        /// <summary>
        /// Order current status. 1 = In process; 2 = Approved; 3 = Backordered; 4 = Rejected; 5 = Shipped; 6 = Cancelled
        /// </summary>
        [Display(Name = "Estado")]
        public byte Status { get; set; }

        /// <summary>
        /// 0 = Order placed by sales person. 1 = Order placed online by customer.
        /// </summary>
        [Display(Name = "Pedido Online")]
        public bool OnlineOrderFlag { get; set; }

        /// <summary>
        /// Unique sales order identification number.
        /// </summary>
        [Display(Name = "Numero de Venta")]
        public string SalesOrderNumber { get; set; } = null!;

        /// <summary>
        /// Customer purchase order number reference. 
        /// </summary>
        [Display(Name = "Numero de Venta Adquirida")]
        public string? PurchaseOrderNumber { get; set; }

        /// <summary>
        /// Financial accounting number reference.
        /// </summary>
        [Display(Name = "Numero de Cuenta")]
        public string? AccountNumber { get; set; }

        /// <summary>
        /// Customer identification number. Foreign key to Customer.BusinessEntityID.
        /// </summary>
        [Display(Name = "Numero de Cliente")]
        public int CustomerId { get; set; }

        /// <summary>
        /// Sales person who created the sales order. Foreign key to SalesPerson.BusinessEntityID.
        /// </summary>
        [Display(Name = "Id Persona de Venta")]
        public int? SalesPersonId { get; set; }

        /// <summary>
        /// Territory in which the sale was made. Foreign key to SalesTerritory.SalesTerritoryID.
        /// </summary>
        [Display(Name = "Id Territorio de Venta")]
        public int? TerritoryId { get; set; }

        /// <summary>
        /// Customer billing address. Foreign key to Address.AddressID.
        /// </summary>
        [Display(Name = "Id Direccion de Facturacion")]
        public int BillToAddressId { get; set; }

        /// <summary>
        /// Customer shipping address. Foreign key to Address.AddressID.
        /// </summary>
        [Display(Name = "Id Direccion de Envio")]
        public int ShipToAddressId { get; set; }

        /// <summary>
        /// Shipping method. Foreign key to ShipMethod.ShipMethodID.
        /// </summary>
        [Display(Name = "Id Metodo de Envio")]
        public int ShipMethodId { get; set; }

        /// <summary>
        /// Credit card identification number. Foreign key to CreditCard.CreditCardID.
        /// </summary>
        [Display(Name = "Id de Tarjeta de Credito")]
        public int? CreditCardId { get; set; }

        /// <summary>
        /// Approval code provided by the credit card company.
        /// </summary>
        [Display(Name = "Codigo de Tarjeta de Credito")]
        public string? CreditCardApprovalCode { get; set; }

        /// <summary>
        /// Currency exchange rate used. Foreign key to CurrencyRate.CurrencyRateID.
        /// </summary>
        [Display(Name = "Id Tasa de Divisa")]
        public int? CurrencyRateId { get; set; }

        /// <summary>
        /// Sales subtotal. Computed as SUM(SalesOrderDetail.LineTotal)for the appropriate SalesOrderID.
        /// </summary>
        [Display(Name = "SubTotal")]
        public decimal SubTotal { get; set; }

        /// <summary>
        /// Tax amount.
        /// </summary>
        [Display(Name = "Importe del Impuesto")]
        public decimal TaxAmt { get; set; }

        /// <summary>
        /// Shipping cost.
        /// </summary>
        [Display(Name = "Coste de Envio")]
        public decimal Freight { get; set; }

        /// <summary>
        /// Total due from customer. Computed as Subtotal + TaxAmt + Freight.
        /// </summary>
        [Display(Name = "Total Pendiente")]
        public decimal TotalDue { get; set; }

        /// <summary>
        /// Sales representative comments.
        /// </summary>
        [Display(Name = "Comentario")]
        public string? Comment { get; set; }

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

        public virtual ICollection<SalesOrderDetail> SalesOrderDetail { get; set; } = new List<SalesOrderDetail>();
    }
}

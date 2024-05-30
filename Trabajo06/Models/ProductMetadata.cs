using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace Trabajo06.Models
{
    [ModelMetadataType(typeof(ProductMetadata))]
    public partial class Product { }
    public class ProductMetadata
    {
        /// <summary>
        /// Primary key for Product records.
        /// </summary>
        [Display(Name = "Id")]
        public int ProductId { get; set; }

        /// <summary>
        /// Name of the product.
        /// </summary>
        [Display(Name = "Nombre")]
        public string Name { get; set; } = null!;

        /// <summary>
        /// Unique product identification number.
        /// </summary>
        [Display(Name = "Numero de Producto")]
        public string ProductNumber { get; set; } = null!;

        /// <summary>
        /// 0 = Product is purchased, 1 = Product is manufactured in-house.
        /// </summary>
        [Display(Name = "Manufacturado")]
        public bool MakeFlag { get; set; }

        /// <summary>
        /// 0 = Product is not a salable item. 1 = Product is salable.
        /// </summary>
        [Display(Name = "Fabricado")]
        public bool FinishedGoodsFlag { get; set; }

        /// <summary>
        /// Product color.
        /// </summary>
        [Display(Name = "Color")]
        public string? Color { get; set; }

        /// <summary>
        /// Minimum inventory quantity. 
        /// </summary>
        [Display(Name = "Cantidad Minima")]
        public short SafetyStockLevel { get; set; }

        /// <summary>
        /// Inventory level that triggers a purchase order or work order. 
        /// </summary>
        [Display(Name = "Punto de Pedido")]
        public short ReorderPoint { get; set; }

        /// <summary>
        /// Standard cost of the product.
        /// </summary>
        [Display(Name = "Coste Estandar")]
        public decimal StandardCost { get; set; }

        /// <summary>
        /// Selling price.
        /// </summary>
        [Display(Name = "Precio de venta")]
        public decimal ListPrice { get; set; }

        /// <summary>
        /// Product size.
        /// </summary>
        [Display(Name = "Tamaño")]
        public string? Size { get; set; }

        /// <summary>
        /// Unit of measure for Size column.
        /// </summary>
        [Display(Name = "Unidad de Medida")]
        public string? SizeUnitMeasureCode { get; set; }

        /// <summary>
        /// Unit of measure for Weight column.
        /// </summary>
        [Display(Name = "Unidades de Peso")]
        public string? WeightUnitMeasureCode { get; set; }

        /// <summary>
        /// Product weight.
        /// </summary>
        [Display(Name = "Peso")]
        public decimal? Weight { get; set; }

        /// <summary>
        /// Number of days required to manufacture the product.
        /// </summary>
        [Display(Name = "Dias para Manufacturar")]
        public int DaysToManufacture { get; set; }

        /// <summary>
        /// R = Road, M = Mountain, T = Touring, S = Standard
        /// </summary>
        [Display(Name = "Linea de Producto")]
        public string? ProductLine { get; set; }

        /// <summary>
        /// H = High, M = Medium, L = Low
        /// </summary>
        [Display(Name = "Clase")]
        public string? Class { get; set; }

        /// <summary>
        /// W = Womens, M = Mens, U = Universal
        /// </summary>
        [Display(Name = "Estilo")]
        public string? Style { get; set; }

        /// <summary>
        /// Product is a member of this product subcategory. Foreign key to ProductSubCategory.ProductSubCategoryID. 
        /// </summary>
        [Display(Name = "Identificador de SubCategoria")]
        public int? ProductSubcategoryId { get; set; }

        /// <summary>
        /// Product is a member of this product model. Foreign key to ProductModel.ProductModelID.
        /// </summary>
        [Display(Name = "Identificador de Modelo")]
        public int? ProductModelId { get; set; }

        /// <summary>
        /// Date the product was available for sale.
        /// </summary>
        [Display(Name = "Fecha de Venta")]
        public DateTime SellStartDate { get; set; }

        /// <summary>
        /// Date the product was no longer available for sale.
        /// </summary>
        [Display(Name = "Fecha de Caducidad de Venta")]
        public DateTime? SellEndDate { get; set; }

        /// <summary>
        /// Date the product was discontinued.
        /// </summary>
        [Display(Name = "Fecha Descontinuada")]
        public DateTime? DiscontinuedDate { get; set; }

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
    }
}

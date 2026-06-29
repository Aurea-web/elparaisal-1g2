using System;
using System.Collections.Generic;
using System.Text;

namespace ElpaisalSistemaventas.EN
{
    public class Detalleventa
    {
        public long DetalleVentaId { get; set; }
        public long VentaId {  get; set; }
        public int ProductoId { get; set; }
        public decimal Precio { get; set; }
        public short Cantidad { get; set; }
        public decimal Subtotal { get; set; }
    }
}
//+DetalleVentaId: long
//+VentaId: long
//+ProductoId: int
//+Precio: decimal
//+Catidad: short
//+SubTotal: decimal

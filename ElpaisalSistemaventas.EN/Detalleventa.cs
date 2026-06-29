using System;
using System.Collections.Generic;
using System.Text;

namespace ElpaisalSistemaventas.EN
{
    public class Detalleventa
    {
        public long detalleventaid { get; set; }
        public long ventaid {  get; set; }
        public int productoid { get; set; }
        public decimal precio { get; set; }
        public short cantidad { get; set; }
        public decimal subtotal { get; set; }
    }
}
//+DetalleVentaId: long
//+VentaId: long
//+ProductoId: int
//+Precio: decimal
//+Catidad: short
//+SubTotal: decimal

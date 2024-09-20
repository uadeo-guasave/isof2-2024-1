﻿namespace AngelMartinDatos
{
    public class Producto
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Descripción { get; set; }
        public decimal Precio { get; set; }
        public Categoría Categoría { get; set; }
    }
}

﻿using ST.SysProductos.DAL;
using ST.SysProductos.EN;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ST.SysProductos.DAL;

namespace ST.SysProductos.BL
{
    public class ProductosBL
    {
        // Declarar campo privado y de lectura para almacenar la dependencia de la capa de acceso a datos (DAL)
        private readonly ProductosDAL _ProductosDAL;

        // Constructor de la clase Productoset que recibe una instancia de ProductosDAL, como parimetro.
        public ProductosBL(ProductosDAL productosDAL)
        {
            // Asigna la instancia recibida a la variable de su lectura ProductosDAL
            // Este permite que la capa de lógica de negocios utilice los métodos de acceso a dates.
            _ProductosDAL = productosDAL;
        }
        public async Task<int> CrearAsync(Productos pProductos)
        {
            return await _ProductosDAL.CrearAsync(pProductos);
        }
        public async Task<int> ModificarAsync(Productos pProductos)
        {
            return await _ProductosDAL.ModificarAsync(pProductos);
        }
        public async Task<int> EliminarAsync(Productos pProductos)
        {
            return await _ProductosDAL.EliminarAsync(pProductos);
        }
        public async Task<Productos> ObtenerPorIdAsync(Productos pProductos)
        {
            return await _ProductosDAL.ObtenerPorIdAsync(pProductos);
        }
        public async Task<List<Productos>> ObtenerTodosAsync()
        {
            return await _ProductosDAL.ObtenerTodosAsync();
        }
        public Task AgregarTodosAsync(List<Productos> pProductos)
        {
            return _ProductosDAL.AgregarTodosAsync(pProductos);
        }
    }

}

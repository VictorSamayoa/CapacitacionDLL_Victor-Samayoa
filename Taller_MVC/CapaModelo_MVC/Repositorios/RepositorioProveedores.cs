using CapaModelo_MVC.Contratos;
using CapaModelo_MVC.Entidades;
using System;
using System.Collections.Generic;
using System.Data.Odbc;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaModelo_MVC.Repositorios
{
    public class RepositorioProveedores : RepositorioMaestro, IRepositorioProveedores
    {
        private string selectAll;
        private string insert;
        private string update;
        private string delete;

        public RepositorioProveedores()
        {
            selectAll = "SELECT id_proveedor, nombre, telefono, id_direccion FROM proveedor";
            insert = "INSERT INTO proveedor (nombre, telefono, id_direccion) VALUES (?, ?, ?)";
            update = "UPDATE proveedor SET nombre=?, telefono=?, id_direccion=? WHERE id_proveedor=?";
            delete = "DELETE FROM proveedor WHERE id_proveedor=?";
        }

        public int Agregar(Proveedor entidad)
        {
            var _parametros = new List<OdbcParameter>();
            _parametros.Add(new OdbcParameter("p_nombre", entidad.Nombre));
            _parametros.Add(new OdbcParameter("p_telefono", entidad.Telefono));
            _parametros.Add(new OdbcParameter("p_id_direccion", entidad.IdDireccion));

            return EjecucionNonQuery(insert, _parametros, CommandType.Text);
        }

        public int Editar(Proveedor entidad)
        {
            var _parametros = new List<OdbcParameter>();
            _parametros.Add(new OdbcParameter("p_nombre", entidad.Nombre));
            _parametros.Add(new OdbcParameter("p_telefono", entidad.Telefono));
            _parametros.Add(new OdbcParameter("p_id_direccion", entidad.IdDireccion));
            _parametros.Add(new OdbcParameter("p_id_proveedor", entidad.IdProveedor));

            return EjecucionNonQuery(update, _parametros, CommandType.Text);
        }

        public int Remover(Proveedor entidad)
        {
            var _parametros = new List<OdbcParameter>();
            _parametros.Add(new OdbcParameter("p_id_proveedor", entidad.IdProveedor));

            return EjecucionNonQuery(delete, _parametros, CommandType.Text);
        }

        public IEnumerable<Proveedor> GetAll()
        {
            var lstProveedor = new List<Proveedor>();
            var tblTabla = EjecucionConsulta(selectAll, CommandType.Text);
            foreach (DataRow row in tblTabla.Rows)
            {
                var proveedor = new Proveedor();
                proveedor.IdProveedor = Convert.ToInt32(row[0]);
                proveedor.Nombre = row[1] != DBNull.Value ? row[1].ToString() : string.Empty;
                proveedor.Telefono = row[2] != DBNull.Value ? row[2].ToString() : string.Empty;
                proveedor.IdDireccion = row[3] != DBNull.Value ? Convert.ToInt32(row[3]) : 0;
                lstProveedor.Add(proveedor);
            }
            tblTabla.Clear();
            tblTabla = null;
            return lstProveedor;
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaModelo_MVC.Contratos;
using CapaModelo_MVC.Entidades;
using CapaModelo_MVC.Repositorios;

namespace CapaControlador_MVC
{
    public class ModeloProveedor
    {
        private int _idProveedor;
        private string _nombre;
        private string _telefono;
        private int _idDireccion;
        private IRepositorioProveedores repositorioProveedores;

        public EstadoEntidad Estado { private get; set; }
        private List<ModeloProveedor> listaProveedores;

        public int IdProveedor { get => _idProveedor; set => _idProveedor = value; }

        [Required(ErrorMessage = "El campo Nombre es requerido")]
        [StringLength(100, MinimumLength = 2, ErrorMessage = "El nombre debe tener entre 2 y 100 caracteres")]
        public string Nombre { get => _nombre; set => _nombre = value; }

        [Required(ErrorMessage = "El campo Teléfono es requerido")]
        [RegularExpression(@"^[0-9+\s-]{7,20}$", ErrorMessage = "El teléfono debe ser numérico y tener entre 7 y 20 dígitos")]
        public string Telefono { get => _telefono; set => _telefono = value; }

        [Required(ErrorMessage = "El campo ID Dirección es requerido")]
        [Range(1, int.MaxValue, ErrorMessage = "Debe ingresar una dirección válida")]
        public int IdDireccion { get => _idDireccion; set => _idDireccion = value; }

        public ModeloProveedor()
        {
            repositorioProveedores = new RepositorioProveedores();
        }

        public string GrabarCambios()
        {
            string mensaje = null;
            try
            {
                var proveedor = new Proveedor();
                proveedor.IdProveedor = _idProveedor;
                proveedor.Nombre = _nombre;
                proveedor.Telefono = _telefono;
                proveedor.IdDireccion = _idDireccion;

                switch (Estado)
                {
                    case EstadoEntidad.Added:
                        repositorioProveedores.Agregar(proveedor);
                        mensaje = "Grabación exitosa";
                        break;
                    case EstadoEntidad.Modified:
                        repositorioProveedores.Editar(proveedor);
                        mensaje = "Actualización exitosa";
                        break;
                    case EstadoEntidad.Deleted:
                        repositorioProveedores.Remover(proveedor);
                        mensaje = "Eliminación exitosa";
                        break;
                }
            }
            catch (Exception ex)
            {
                mensaje = ex.Message;
            }
            return mensaje;
        }

        public List<ModeloProveedor> GetAll()
        {
            var modeloDatos = repositorioProveedores.GetAll();
            listaProveedores = new List<ModeloProveedor>();
            foreach (Proveedor item in modeloDatos)
            {
                listaProveedores.Add(new ModeloProveedor
                {
                    _idProveedor = item.IdProveedor,
                    _nombre = item.Nombre,
                    _telefono = item.Telefono,
                    _idDireccion = item.IdDireccion
                });
            }
            return listaProveedores;
        }

        public IEnumerable<ModeloProveedor> FindbyId(string filter)
        {
            if (listaProveedores == null)
            {
                GetAll();
            }
            if (string.IsNullOrWhiteSpace(filter))
            {
                return listaProveedores;
            }
            return listaProveedores.FindAll(e => 
                e.IdProveedor.ToString().Contains(filter) || 
                (e.Nombre != null && e.Nombre.IndexOf(filter, StringComparison.OrdinalIgnoreCase) >= 0) ||
                (e.Telefono != null && e.Telefono.Contains(filter)));
        }
    }
}

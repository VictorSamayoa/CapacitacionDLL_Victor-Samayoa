using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Windows.Forms;

namespace CapaVista_MVC.Ayudas
{
    public class ValidacionDatos
    {
        private ValidationContext contexto;
        private List<ValidationResult> resultados;
        private bool valido;
        private string mensaje;

        public ValidacionDatos(object instancia)
        {
            contexto = new ValidationContext(instancia);
            resultados = new List<ValidationResult>();
            valido = Validator.TryValidateObject(instancia, contexto, resultados, true);
        }

        public bool Validar()
        {
            if (valido == false)
            {
                mensaje = string.Empty;
                foreach (ValidationResult item in resultados)
                {
                    mensaje += item.ErrorMessage + "\n";
                }
                MessageBox.Show(mensaje, "Validación de Datos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            return valido;
        }
    }
}

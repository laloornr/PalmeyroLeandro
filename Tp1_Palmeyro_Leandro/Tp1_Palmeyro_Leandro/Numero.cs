using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tp1_Palmeyro_Leandro
{
    public class Numero
    {
        // Declaracion de Variables
        double _numero;

        #region Constructores

        /// <summary>
        /// Constructor por Defecto, Inicializa el Numero en 0.
        /// </summary>
        public Numero()
        {
            this._numero = 0;
        }

        /// <summary>
        /// Constructor que Recibe Tipo de Dato String, lo valida y lo carga
        /// </summary>
        /// <param name="numero"></param>
        public Numero(string numero)
        {
            this.setNumero(numero);
        }

        /// <summary>
        /// Constructor que Recibe Tipo de Dato Double y lo carga
        /// </summary>
        /// <param name="numero"></param>
        public Numero(double numero)
        {
            this._numero = numero;
        }

        #endregion

        #region Metodos

        /// <summary>
        /// Valida el String y devuelve el numero cargado, De no ser posible devuelve 0
        /// </summary>
        /// <returns>Si se puede convertir el string retorna el numero correspondiente, en caso contrario retorna 0</returns>
        private double validarNumero(string numero)
        {
            double retorno;

            if (!double.TryParse(numero, out retorno))
            {
                retorno = 0;
            }

            return retorno;
        }

        /// <summary>
        /// Llama a Validar Numero y carga 0 si no se puede parsear, o el Numero si se parseo.
        /// </summary>
        /// <param name="numero"></param>
        private void setNumero(string numero)
        {
            this._numero = validarNumero(numero);
        }

        /// <summary>
        /// Retorna el Numero
        /// </summary>
        /// <returns>Retorna el Numero</returns>
        public double getNumero()
        {
            return this._numero;
        }

        #endregion

    }
}

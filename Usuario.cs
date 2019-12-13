using System;
using System.Collections.Generic;
using System.Text;

namespace Series
{
    public class Usuario : Serie
    {
        public string Nombre
        {
            get => default;
            set
            {
            }
        }

        public string Apellido
        {
            get => default;
            set
            {
            }
        }

        public char Correo
        {
            get => default;
            set
            {
            }
        }

        public char FechaNacimiento
        {
            get => default;
            set
            {
            }
        }

        public void MarcarFavorita()
        {
            throw new System.NotImplementedException();
        }

        public void MarcarEmpezada()
        {
            throw new System.NotImplementedException();
        }

        public void MarcarVista()
        {
            throw new System.NotImplementedException();
        }

        public void CancelarSerie()
        {
            throw new System.NotImplementedException();
        }
    }
}
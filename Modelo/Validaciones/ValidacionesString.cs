using System.Text;

namespace Financiero.Modelo
{
    public class ValidacionesString
    {
        public bool soloLetrasYDigitos(string text)
        {
            foreach (char caracter in text.ToCharArray())
            {
                if (!char.IsLetterOrDigit(caracter))
                    return false;
            }
            return true;
        }

        public bool contieneMayuscula(string text)
        {
            foreach (char caracter in text.ToCharArray())
            {
                if (char.IsUpper(caracter))
                    return true;
            }
            return false;
        }

        public bool contieneDigito(string text)
        {
            foreach (char caracter in text.ToCharArray())
            {
                if (char.IsDigit(caracter))
                    return true;
            }
            return false;
        }

        public bool contieneEspacioEnBlanco(string text)
        {
            foreach (char caracter in text.ToCharArray())
            {
                if (char.IsWhiteSpace(caracter))
                    return true;
            }
            return false;
        }

        public bool contieneMinuscula(string text)
        {
            foreach (char caracter in text.ToCharArray())
            {
                if (char.IsLower(caracter))
                    return true;
            }
            return false;
        }

        public ValidacionesString() {
            noEspaciosVacios = "No permitidos espacios vacios";
            noCaracteresEspeciales = "No permitidos caracteres especiales";
        }

        public string noEspaciosVacios {get;}
        public string noCaracteresEspeciales {get;}
    }
}

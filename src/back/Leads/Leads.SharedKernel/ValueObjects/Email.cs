using System.Text.RegularExpressions;

namespace Leads.SharedKernel.ValueObjects
{
    public struct Email
    {
        public Email(string email)
        {
            Valor = email.ToLower().Trim();            

            if (string.IsNullOrEmpty(email) || email.Length < 5 || !Regex.IsMatch(Valor, pattern))            
                Valido = false;               
                                 
            Valido = true;
        }
        public string Valor { get; set; }
        public bool Valido { get; private set; }

        private string pattern = @"^\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*$";

        public static implicit operator string(Email email) => email.Valor;

        public static implicit operator Email(string email) => new(email);
    }
}

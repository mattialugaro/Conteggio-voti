using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conteggio_voti
{
    internal class Utente
    {
        private string email;
        private string password;
        public bool isLoggedIn { get; set; }
        public int[] voti { get; set; }

        public Utente()
        {
            this.isLoggedIn = false;
            this.voti = new int[] { 0, 0, 0 };
        }

        public Utente(string email, string password)
        {
            this.email = email;
            this.password = password;
            this.isLoggedIn = false;
            this.voti = new int[] { 0, 0, 0};
        }

        public void SetEmail(string email)
        {
            this.email = email;
        }
        public string GetEmail()
        {
            return email;
        }
        public void SetPassword(string password)
        {
            this.password = password;
        }
        public string GetPassword()
        {
            return password;
        }
        public void SetIsLoggeIn(bool isLoggedIn)
        {
            this.isLoggedIn = isLoggedIn;
        }
        public bool GetIsLoggedIn()
        {
            return isLoggedIn;
        }
        public string Login(string email, string password)
        {
            if(this.email == email && this.password == password)
            {
                isLoggedIn = true;
                return "Login effettuato con successo!";
            }
            else
            {
                return "Email e password non corretti";
            }
        }

        public void Vota()
        {
            for(int i = 0; i < voti.Length; i++)
            {
                Console.WriteLine($"Domanda {i + 1}");
                Console.WriteLine("Opzione 1");
                Console.WriteLine("Opzione 2");
                Console.WriteLine("Opzione 3");
                Console.WriteLine("Opzione 4");
                voti[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < voti.Length; i++)
            {
                Console.WriteLine($"{voti[i]}");
            }
        }
    }
}

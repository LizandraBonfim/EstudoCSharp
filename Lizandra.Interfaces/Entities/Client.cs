using System;

namespace Lizandra.Interfaces.Entities
{
    public class Client
    {
        public string Nome { get; set; }
        public string Email { get; set; }

        public Client(string nome, string email)
        {
            Nome = nome;
            Email = email;
        }

        public override bool Equals(object? obj)
        {
            if(!(obj is Client)) 
                throw new Exception("Obj nao é client");
            
            Client client = obj as Client;

            return Email.Equals(client.Email);
        }

        public override int GetHashCode()
        {
            return Email.GetHashCode();
        }
    }
}
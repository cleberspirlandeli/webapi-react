using System;

namespace backend.Models
{
    public   class Usuario{
    
    public Guid id { get; set; }
    public string nome { get; set; }
    public int idade { get; set; }
    
        public Usuario()
        {
            this.id  = Guid.NewGuid();    
        }
    }
}
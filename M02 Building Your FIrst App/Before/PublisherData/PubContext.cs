using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PublisherData
{
    public class PubContext  
    {
       public DbSet<Author> Authors { get; set; } 
    }
}
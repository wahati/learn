using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using webapi.Models;

namespace webapi.Data
{
    public class WebApiContext : DbContext
    {

        public WebApiContext (DbContextOptions<WebApiContext> options)
            : base(options)
        {
            Initilize();
        }

        public void Initilize()
        {
            if (this.Database.EnsureCreated())
            {
                if (this.Brand.Any())
                {
                    //var brands = this.Brand.Select(b => b).ToList();
                    this.Brand.RemoveRange(this.Brand);
                    this.SaveChanges();
                }
                else
                {
                    // Add some data
                    this.Brand.Add(new Brand { 
                        Name = "GU", 
                        Description = "G.U. is a Japanese discount casual wear designer, manufacturer and retailer, with 451 stores across Japan.", 
                        IconUrl = "https://is1-ssl.mzstatic.com/image/thumb/Purple126/v4/3a/de/de/3adedea6-cb8b-2074-330e-d3e468972a40/AppIcon-0-0-1x_U007emarketing-0-0-0-7-0-0-sRGB-0-0-0-GLES2_U002c0-512MB-85-220-0-0.jpeg/434x0w.webp"
                    });
                    this.Brand.Add(new Brand { 
                        Name = "GAP", 
                        Description = "Gap is an American worldwide clothing and accessories retailer. Gap was founded in 1969 by Donald Fisher and Doris F. Fisher and is headquartered in San Francisco, California.", 
                        IconUrl = "https://is1-ssl.mzstatic.com/image/thumb/Purple112/v4/98/f7/b0/98f7b005-3582-a9b4-1c41-2cdb33fafa8e/AppIcon-Release-0-1x_U007emarketing-0-5-0-85-220.png/434x0w.webp"
                    });
                    this.Brand.Add(new Brand { 
                        Name = "ZARA", 
                        Description = "Zara is a Spanish fast-fashion retailer based in Arteijo in Galicia, Spain. The company was founded in 1975 by Amancio Ortega and Rosalía Mera. It is the main brand of the Inditex group, the world's largest apparel retailer.", 
                        IconUrl = "https://is1-ssl.mzstatic.com/image/thumb/Purple112/v4/7b/f5/15/7bf515b8-4d93-03ae-8fcf-5b081e63f9cf/AppIcon-0-1x_U007emarketing-0-7-0-sRGB-0-85-220-0.png/434x0w.webp"
                    });
                    this.Brand.Add(new Brand { 
                        Name = "UNIQLO", 
                        Description = "Uniqlo Co., Ltd. is a Japanese casual wear designer, fast-fashion manufacturer and retailer.", 
                        IconUrl = "https://is1-ssl.mzstatic.com/image/thumb/Purple126/v4/9a/b6/d5/9ab6d538-be5c-1bfa-7537-25a14b253884/AppIcon01-0-0-1x_U007emarketing-0-0-0-6-0-0-sRGB-0-0-0-GLES2_U002c0-512MB-85-220-0-0.png/434x0w.webp"
                    });

                    this.SaveChanges();
                }
            }
            else
            {
                // Report error
            }
        }

        public DbSet<webapi.Models.Brand> Brand { get; set; } = default!;

        
    }
}

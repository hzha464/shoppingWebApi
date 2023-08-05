using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using shoppingWebApi.models;

namespace shoppingWebApi.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options): base(options)
        {
            
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>().HasData(
                new Product
                {
                    Id = 1,
                    brand = "Philips",
                    model = "Series 7000",
                    type = "Shaver",
                    price = 150,
                    rating = 5,
                    stock = 10,
                    waterproof = true,
                    fastCharge = true,
                    image = "https://www.maquinilladeafeitar.com/wp-content/uploads/2018/01/Philips-serie-7000.jpg"
                },
                new Product
                {
                    Id = 2,
                    brand = "Braun",
                    model = "Series 9",
                    type = "Shaver",
                    price = 250,
                    rating = 4,
                    stock = 20,
                    waterproof = true,
                    fastCharge = false,
                    image = "https://images-na.ssl-images-amazon.com/images/I/811IO5eKSJL._AC_SL1500_.jpg"
                },
                new Product
                {
                    Id = 3,
                    brand = "Panasonic",
                    model = "Arc5",
                    type = "Shaver",
                    price = 200,
                    rating = 4,
                    stock = 15,
                    waterproof = true,
                    fastCharge = true,
                    image = "https://moo.review/wp-content/uploads/2016/02/Panasonic-Arc-5-model-ES-LV9N-electric-shaver.jpg"
                },
                    new Product
                {
                    Id = 4,
                    brand = "Philips",
                    model = "OneBlade",
                    type = "Shaver",
                    price = 50,
                    rating = 4,
                    stock = 30,
                    waterproof = true,
                    fastCharge = false,
                    image = "https://www.philips.be/c-dam/corporate/newscenter/be/standard/resources/2017/one-blade/philips-one-blade-hi-res-02.download.jpg"
                },
                new Product
                {
                    Id = 5,
                    brand = "Philips",
                    model = "AquaTouch",
                    type = "Shaver",
                    price = 80,
                    rating = 3,
                    stock = 20,
                    waterproof = true,
                    fastCharge = false,
                    image = "https://www.bigw.com.au/medias/sys_master/images/images/hb5/h95/10815612026910.jpg"
                },
                new Product
                {
                    Id = 6,
                    brand = "Philips",
                    model = "Series 5000",
                    type = "Shaver",
                    price = 120,
                    rating = 5,
                    stock = 10,
                    waterproof = true,
                    fastCharge = true,
                    image = "https://top-rasage.fr/wp-content/uploads/2018/02/Philips-Series-5000-S531026.jpg"
                },
                    new Product
                {
                    Id = 7,
                    brand = "Braun",
                    model = "Series 7",
                    type = "Shaver",
                    price = 180,
                    rating = 4,
                    stock = 25,
                    waterproof = true,
                    fastCharge = true,
                    image = "https://www.bestshaverszone.com/wp-content/uploads/2015/03/Braun-Series-7-790cc-Pulsonic.jpg"
                },
                new Product
                {
                    Id = 8,
                    brand = "Braun",
                    model = "Series 5",
                    type = "Shaver",
                    price = 130,
                    rating = 4,
                    stock = 15,
                    waterproof = true,
                    fastCharge = false,
                    image = "https://pisces.bbystatic.com/image2/BestBuy_US/images/products/5895/5895021_rd.jpg"
                },
                new Product
                {
                    Id = 9,
                    brand = "Braun",
                    model = "Series 3 ProSkin",
                    type = "Shaver",
                    price = 70,
                    rating = 3,
                    stock = 20,
                    waterproof = true,
                    fastCharge = false,
                    image = "https://www.mashco.co.uk/media/catalog/product/cache/1/image/9df78eab33525d08d6e5fb8d27136e95/b/r/bra3000s.png"
                },
                    new Product
                {
                    Id = 10,
                    brand = "Panasonic",
                    model = "Arc4",
                    type = "Shaver",
                    price = 120,
                    rating = 4,
                    stock = 15,
                    waterproof = true,
                    fastCharge = true,
                    image = "https://d11zer3aoz69xt.cloudfront.net/media/catalog/product/cache/1/image/1200x/9df78eab33525d08d6e5fb8d27136e95/p/a/panasonic_arc4_4-blade_shaver_es-lf51-a_11.jpg"
                },
                new Product
                {
                    Id = 11,
                    brand = "Panasonic",
                    model = "Arc3",
                    type = "Shaver",
                    price = 90,
                    rating = 4,
                    stock = 20,
                    waterproof = true,
                    fastCharge = false,
                    image = "https://pisces.bbystatic.com/image2/BestBuy_US/images/products/6400/6400550_rd.jpg"
                },
                new Product
                {
                    Id = 12,
                    brand = "Panasonic",
                    model = "ES-LV95-S",
                    type = "Shaver",
                    price = 200,
                    rating = 5,
                    stock = 10,
                    waterproof = true,
                    fastCharge = true,
                    image = "https://c1.neweggimages.com/ProductImageCompressAll1280/96-200-517-02.jpg"
                }
            );
        }   
        public DbSet<User> Users => Set<User>();
        public DbSet<Product> Products => Set<Product>();
        public DbSet<ProductItem> ProductItems => Set<ProductItem>();
        public DbSet<Order> order => Set<Order>();
    }
}
namespace Negocio.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CrearBase : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Peliculas", "pelicula_Id", "dbo.Peliculas");
            DropIndex("dbo.Peliculas", new[] { "pelicula_Id" });
            AddColumn("dbo.Peliculas", "Clasificacion_Id", c => c.Int());
            AlterColumn("dbo.Peliculas", "FechaEstreno", c => c.String());
            CreateIndex("dbo.Peliculas", "Clasificacion_Id");
            AddForeignKey("dbo.Peliculas", "Clasificacion_Id", "dbo.Clasificacions", "Id");
            DropColumn("dbo.Peliculas", "pelicula_Id");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Peliculas", "pelicula_Id", c => c.Int());
            DropForeignKey("dbo.Peliculas", "Clasificacion_Id", "dbo.Clasificacions");
            DropIndex("dbo.Peliculas", new[] { "Clasificacion_Id" });
            AlterColumn("dbo.Peliculas", "FechaEstreno", c => c.DateTime(nullable: false));
            DropColumn("dbo.Peliculas", "Clasificacion_Id");
            CreateIndex("dbo.Peliculas", "pelicula_Id");
            AddForeignKey("dbo.Peliculas", "pelicula_Id", "dbo.Peliculas", "Id");
        }
    }
}

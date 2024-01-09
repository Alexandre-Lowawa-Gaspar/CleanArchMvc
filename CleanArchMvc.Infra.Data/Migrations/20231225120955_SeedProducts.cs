using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CleanArchMvc.Infra.Data.Migrations
{
    /// <inheritdoc />
    public partial class SeedProducts : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO PRODUCTS(NAME,DESCRIPTION,PRICE, STOCK, IMAGE,CATEGORYID)" +
                " VALUES('Caderno espiral', 'Caderno espiral de 100 folhas',7.45,50,'caderno1.jpg',1)");
            migrationBuilder.Sql("insert into products(name, description,price,stock,image,categoryid)" +
                " values('Estojo escolar','Estojo escolar cinza', 5.65,70,'estojo1.jpg',1)");
            migrationBuilder.Sql("insert into products(name, description,price,stock,image,categoryid)" +
                " values('Calculadora escolar','Calculadora simples', 15.65,20,'calculadora1.jpg',2)");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE FROM Products");
        }
    }
}

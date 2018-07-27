namespace ECommerce.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CriarBanco : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Produtos",
                c => new
                    {
                        ProdutoID = c.Int(nullable: false, identity: true),
                        Preco = c.Double(nullable: false),
                        Nome = c.String(),
                        Categoria = c.String(),
                        Descricao = c.String(),
                        Imagem = c.String(),
                    })
                .PrimaryKey(t => t.ProdutoID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Produtos");
        }
    }
}

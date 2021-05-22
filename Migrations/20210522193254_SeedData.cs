using Microsoft.EntityFrameworkCore.Migrations;

namespace StoreManagement.Migrations
{
    public partial class SeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Funcionarios",
                columns: new[] { "Id", "Cargo", "Cpf", "Email", "Endereco", "Idade", "Nome", "Telefone" },
                values: new object[,]
                {
                    { 1, "Global Applications Specialist", "551.825.468-74", "Ofelia.Martins24@yahoo.com", "83539 Júlio César Avenida, Campinas, Eslováquia", 38, "Janaína Moraes", "(68) 28528-5659" },
                    { 2, "Dynamic Web Developer", "704.593.351-70", "Fabricio_Xavier6@yahoo.com", "44530 Lorena Marginal, Londrina, Samoa", 41, "Ofélia Batista", "(27) 80628-0915" },
                    { 3, "Legacy Functionality Supervisor", "887.613.340-22", "MariaAlice68@hotmail.com", "556 Santos Avenida, São Luís, Dominica", 18, "Roberta Costa", "(43) 42400-6750" },
                    { 4, "Legacy Metrics Coordinator", "232.680.457-07", "Heitor76@gmail.com", "113 Yuri Rua, Betim, Suíça", 40, "Dalila Nogueira", "(80) 86925-7941" },
                    { 5, "Internal Research Administrator", "970.408.133-27", "Carlos82@bol.com.br", "0777 Batista Marginal, Contagem, Iraque", 41, "Melissa Costa", "(18) 67488-4366" }
                });

            migrationBuilder.InsertData(
                table: "Produtos",
                columns: new[] { "Id", "Categoria", "Nome", "Preco", "Quantidade" },
                values: new object[,]
                {
                    { 1, "Industrial", "Pequeno Fresco Bacon", 834.44m, 80 },
                    { 2, "Mercearia & Ferramentas", "Sem marca Aço Mesa", 332.69m, 11 },
                    { 3, "Sapatos", "Prático Fresco Calças", 758.09m, 62 },
                    { 4, "Casa, Roupas & Eletrônicos", "Lindo Granito Cadeira", 616.31m, 11 },
                    { 5, "Automotivo, Turismo & Casa", "Sem marca Congelado Mouse", 283.25m, 36 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Funcionarios",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Funcionarios",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Funcionarios",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Funcionarios",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Funcionarios",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Id",
                keyValue: 5);
        }
    }
}

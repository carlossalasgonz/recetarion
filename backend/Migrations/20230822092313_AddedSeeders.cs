using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace backend.Migrations
{
    /// <inheritdoc />
    public partial class AddedSeeders : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Images",
                columns: new[] { "Id", "Name", "PublicationId", "Type" },
                values: new object[] { new Guid("43c47239-a9c8-429d-9efd-942b6f46a811"), "Image.png", null, "png" });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "Id", "Calories", "Density", "ImageId", "Name" },
                values: new object[,]
                {
                    { new Guid("04f70e03-e650-443e-997e-f1ed8401e9a6"), 0, 1f, new Guid("43c47239-a9c8-429d-9efd-942b6f46a811"), "Tapioca Flour" },
                    { new Guid("05084dcf-0fd1-4853-b7a4-bfbb7f32d8c9"), 0, 1f, new Guid("43c47239-a9c8-429d-9efd-942b6f46a811"), "Barley" },
                    { new Guid("0899d724-b0ef-4ddd-aec2-87cd1faea0c4"), 0, 1f, new Guid("43c47239-a9c8-429d-9efd-942b6f46a811"), "Spelt" },
                    { new Guid("092eea21-c607-4aa8-86ce-b1506636dc4e"), 0, 1f, new Guid("43c47239-a9c8-429d-9efd-942b6f46a811"), "Chia Seeds" },
                    { new Guid("183039ed-0c2e-4404-adea-6fe55cd4d65f"), 0, 1f, new Guid("43c47239-a9c8-429d-9efd-942b6f46a811"), "Almonds" },
                    { new Guid("192af5dc-2fc2-4d11-8b8e-10a82161dece"), 0, 1f, new Guid("43c47239-a9c8-429d-9efd-942b6f46a811"), "Apples" },
                    { new Guid("1f8fc129-0a98-42a9-9673-559932631fb4"), 0, 1f, new Guid("43c47239-a9c8-429d-9efd-942b6f46a811"), "Pork Tenderloin" },
                    { new Guid("27bf3f89-c5dd-4627-9b31-ecef5504e8d9"), 0, 1f, new Guid("43c47239-a9c8-429d-9efd-942b6f46a811"), "Chocolate" },
                    { new Guid("2806f3d8-a4ff-4270-ba99-fd11df8819da"), 0, 1f, new Guid("43c47239-a9c8-429d-9efd-942b6f46a811"), "Beef Chuck" },
                    { new Guid("283cb167-332b-4244-81fd-3feef206607e"), 0, 1f, new Guid("43c47239-a9c8-429d-9efd-942b6f46a811"), "Peaches" },
                    { new Guid("2ce824b9-34fa-4a95-a972-3c2eb64edbc0"), 0, 1f, new Guid("43c47239-a9c8-429d-9efd-942b6f46a811"), "Bulgur" },
                    { new Guid("3221780e-dd89-4bd7-a29a-57c810e97856"), 0, 1f, new Guid("43c47239-a9c8-429d-9efd-942b6f46a811"), "Veal" },
                    { new Guid("334c2c6e-4d2e-4697-84c5-40145eb1101e"), 0, 1f, new Guid("43c47239-a9c8-429d-9efd-942b6f46a811"), "Chicken Breasts" },
                    { new Guid("35a0c4bc-d72f-4651-a8b6-f9eae4b73c28"), 0, 1f, new Guid("43c47239-a9c8-429d-9efd-942b6f46a811"), "Pork Ribs" },
                    { new Guid("3b3a8363-7ff7-43cb-9ccd-ed43c795da1c"), 0, 1f, new Guid("43c47239-a9c8-429d-9efd-942b6f46a811"), "Beef Ribs" },
                    { new Guid("42c6491f-e6f4-4f24-83b7-7c42a94e2228"), 0, 1f, new Guid("43c47239-a9c8-429d-9efd-942b6f46a811"), "Chicken Legs" },
                    { new Guid("48976dbb-8d58-4fbe-bb75-cf6185d237e1"), 0, 1f, new Guid("43c47239-a9c8-429d-9efd-942b6f46a811"), "Beef Tenderloin" },
                    { new Guid("49072cfc-9f6f-4531-a295-1ded17edf5aa"), 0, 1f, new Guid("43c47239-a9c8-429d-9efd-942b6f46a811"), "Venison" },
                    { new Guid("49faabf6-7aaa-497b-81c7-9883a84ca594"), 0, 1f, new Guid("43c47239-a9c8-429d-9efd-942b6f46a811"), "Brown Rice" },
                    { new Guid("50451ec4-fe8c-4a8c-b62f-807b5d0b8f8f"), 0, 1f, new Guid("43c47239-a9c8-429d-9efd-942b6f46a811"), "Duck" },
                    { new Guid("504ae686-1dbb-4da5-9b91-dbbd1cea1742"), 0, 1f, new Guid("43c47239-a9c8-429d-9efd-942b6f46a811"), "Beef" },
                    { new Guid("555b2b74-2c58-408d-bfc2-bb71f142f036"), 0, 1f, new Guid("43c47239-a9c8-429d-9efd-942b6f46a811"), "Almond Meal" },
                    { new Guid("576b8820-b7c1-4333-946c-92a38206bc9c"), 0, 1f, new Guid("43c47239-a9c8-429d-9efd-942b6f46a811"), "Apricots" },
                    { new Guid("5a05b326-0acc-43b4-a610-10d360f614fb"), 0, 1f, new Guid("43c47239-a9c8-429d-9efd-942b6f46a811"), "Turkey" },
                    { new Guid("5b5a3983-6b17-4e31-a8b5-0a92fbc9eb19"), 0, 1f, new Guid("43c47239-a9c8-429d-9efd-942b6f46a811"), "Bananas" },
                    { new Guid("5bb15aab-e068-408f-a26b-6260a19ecfed"), 0, 1f, new Guid("43c47239-a9c8-429d-9efd-942b6f46a811"), "Seafood" },
                    { new Guid("5c8e218c-12a0-490f-8240-5ee0d6998e33"), 0, 1f, new Guid("43c47239-a9c8-429d-9efd-942b6f46a811"), "Cornmeal" },
                    { new Guid("5fbeef36-d475-4def-89bb-0b6aa83c87f2"), 0, 1f, new Guid("43c47239-a9c8-429d-9efd-942b6f46a811"), "Buckwheat" },
                    { new Guid("63f81d0e-83e1-441f-af19-e25cb7c863f6"), 0, 1f, new Guid("43c47239-a9c8-429d-9efd-942b6f46a811"), "Pomegranates" },
                    { new Guid("667312d2-8dc7-4438-9a4e-eb7bf86fc9f5"), 0, 1f, new Guid("43c47239-a9c8-429d-9efd-942b6f46a811"), "Flax Seeds" },
                    { new Guid("66e0c93c-9bbc-4d0f-81fa-f372f5477dfe"), 0, 1f, new Guid("43c47239-a9c8-429d-9efd-942b6f46a811"), "Wild Rice" },
                    { new Guid("6f5aa8a0-0ef9-4a12-b79e-2dc5da8182ad"), 0, 1f, new Guid("43c47239-a9c8-429d-9efd-942b6f46a811"), "Plums" },
                    { new Guid("75527a76-04d1-414c-971c-6456847cb879"), 0, 1f, new Guid("43c47239-a9c8-429d-9efd-942b6f46a811"), "Coconut" },
                    { new Guid("76c1ecdd-3548-45d6-aec1-ebb302aaa04a"), 0, 1f, new Guid("43c47239-a9c8-429d-9efd-942b6f46a811"), "Ground Pork" },
                    { new Guid("7c858b13-dc57-42e4-999b-8e0405bc9510"), 0, 1f, new Guid("43c47239-a9c8-429d-9efd-942b6f46a811"), "Ground Beef" },
                    { new Guid("7ddff466-ebf5-4904-9397-8b2f652cc55e"), 0, 1f, new Guid("43c47239-a9c8-429d-9efd-942b6f46a811"), "Oat Flour" },
                    { new Guid("7e57b864-cbbd-4be0-b76d-c162031e8f17"), 0, 1f, new Guid("43c47239-a9c8-429d-9efd-942b6f46a811"), "Millet" },
                    { new Guid("7e72e5fa-6d1b-4dd5-a151-4c0aa0efc48a"), 0, 1f, new Guid("43c47239-a9c8-429d-9efd-942b6f46a811"), "Amaranth" },
                    { new Guid("7f24d133-67cc-4717-8298-0a268f427200"), 0, 1f, new Guid("43c47239-a9c8-429d-9efd-942b6f46a811"), "Lamb" },
                    { new Guid("82aab854-e1b0-4de3-89a4-1ab509282de3"), 0, 1f, new Guid("43c47239-a9c8-429d-9efd-942b6f46a811"), "Steak" },
                    { new Guid("90072d03-cbfc-4d7a-83b4-821d546fd1d4"), 0, 1f, new Guid("43c47239-a9c8-429d-9efd-942b6f46a811"), "Prime Rib" },
                    { new Guid("920dec8f-4d88-4fd3-9069-e2ca1a1011d3"), 0, 1f, new Guid("43c47239-a9c8-429d-9efd-942b6f46a811"), "Nectarines" },
                    { new Guid("93644195-f6eb-4fe9-b27a-7b2580d33b8d"), 0, 1f, new Guid("43c47239-a9c8-429d-9efd-942b6f46a811"), "White Rice Flour" },
                    { new Guid("9b1a5a23-21aa-48f1-b3ec-37bbaa444959"), 0, 1f, new Guid("43c47239-a9c8-429d-9efd-942b6f46a811"), "Pork" },
                    { new Guid("a0007344-135c-4c40-9713-be753fe015f0"), 0, 1f, new Guid("43c47239-a9c8-429d-9efd-942b6f46a811"), "Ground Chicken" },
                    { new Guid("a67be4fb-eb7a-4dc3-b00d-4e37c2abc342"), 0, 1f, new Guid("43c47239-a9c8-429d-9efd-942b6f46a811"), "Peanuts" },
                    { new Guid("ab890672-15f2-4bb0-a5c4-ce5f6cff44db"), 0, 1f, new Guid("43c47239-a9c8-429d-9efd-942b6f46a811"), "Pears" },
                    { new Guid("aeaec642-3ca6-4404-9aae-a5293fd55831"), 0, 1f, new Guid("43c47239-a9c8-429d-9efd-942b6f46a811"), "Cheese" },
                    { new Guid("b471b021-a4bd-4a9e-b06d-2a0e6dcb7be6"), 0, 1f, new Guid("43c47239-a9c8-429d-9efd-942b6f46a811"), "Chicken Thighs" },
                    { new Guid("bd940e76-7313-40a9-88f2-996317bfedbf"), 0, 1f, new Guid("43c47239-a9c8-429d-9efd-942b6f46a811"), "Chicken" },
                    { new Guid("c1919792-2ceb-4f6f-82d1-a9d961d3a2f0"), 0, 1f, new Guid("43c47239-a9c8-429d-9efd-942b6f46a811"), "Pork Shoulder" },
                    { new Guid("c410f959-8550-4e51-ba01-1f57a94dd1bf"), 0, 1f, new Guid("43c47239-a9c8-429d-9efd-942b6f46a811"), "Goat" },
                    { new Guid("c7185756-2b90-43b6-b72f-f661fa4e2835"), 0, 1f, new Guid("43c47239-a9c8-429d-9efd-942b6f46a811"), "Chicken Wings" },
                    { new Guid("ca89e1ae-afc7-482c-8b33-171592f42764"), 0, 1f, new Guid("43c47239-a9c8-429d-9efd-942b6f46a811"), "Wild Game" },
                    { new Guid("ca98ba01-ce07-488b-93d6-50866f7597af"), 0, 1f, new Guid("43c47239-a9c8-429d-9efd-942b6f46a811"), "Shellfish" },
                    { new Guid("ce9249ba-c718-437f-881e-1c3692fde203"), 0, 1f, new Guid("43c47239-a9c8-429d-9efd-942b6f46a811"), "Sirloin" },
                    { new Guid("cf698f78-4692-4dd6-8599-9027abaa2b9a"), 0, 1f, new Guid("43c47239-a9c8-429d-9efd-942b6f46a811"), "Cornish Hens" },
                    { new Guid("d39776f6-f031-4bb3-9f33-8d1d797c1349"), 0, 1f, new Guid("43c47239-a9c8-429d-9efd-942b6f46a811"), "Ground Turkey" },
                    { new Guid("d5185710-bd47-4328-8277-b5516e05ac69"), 0, 1f, new Guid("43c47239-a9c8-429d-9efd-942b6f46a811"), "Avocados" },
                    { new Guid("d6d1a554-7839-48ea-99ba-5f7f63b2096d"), 0, 1f, new Guid("43c47239-a9c8-429d-9efd-942b6f46a811"), "Brisket" },
                    { new Guid("d82a45c2-7875-4091-b0f7-e9aed01a4f3e"), 0, 1f, new Guid("43c47239-a9c8-429d-9efd-942b6f46a811"), "Mangos" },
                    { new Guid("de8e0a2a-815e-4eab-a2ae-fa4fe0935cba"), 0, 1f, new Guid("43c47239-a9c8-429d-9efd-942b6f46a811"), "Fish" },
                    { new Guid("e20c794e-70dd-4f1c-b37f-6b30d95956f2"), 0, 1f, new Guid("43c47239-a9c8-429d-9efd-942b6f46a811"), "Oats" },
                    { new Guid("ecd8c95d-525f-47a0-abcb-92727b2cf52d"), 0, 1f, new Guid("43c47239-a9c8-429d-9efd-942b6f46a811"), "Corn Flour" },
                    { new Guid("ee3e7108-f932-4121-9d5f-f78890af628e"), 0, 1f, new Guid("43c47239-a9c8-429d-9efd-942b6f46a811"), "Sausage" },
                    { new Guid("f208e279-48c9-4190-bca9-d426235e2e1e"), 0, 1f, new Guid("43c47239-a9c8-429d-9efd-942b6f46a811"), "Pineapples" },
                    { new Guid("f22c9132-969a-46d6-b711-c22dd697dafb"), 0, 1f, new Guid("43c47239-a9c8-429d-9efd-942b6f46a811"), "Quinoa" },
                    { new Guid("faca3207-629e-4ec2-91b2-b0ba35aa3025"), 0, 1f, new Guid("43c47239-a9c8-429d-9efd-942b6f46a811"), "Mushroom" },
                    { new Guid("ff1a2af4-5d6d-41c5-a3a7-c34210bf2cf3"), 0, 1f, new Guid("43c47239-a9c8-429d-9efd-942b6f46a811"), "Cherries" }
                });

            migrationBuilder.InsertData(
                table: "Units",
                columns: new[] { "Id", "Abbreviation", "Default", "Equivalence", "Title", "Type" },
                values: new object[,]
                {
                    { new Guid("1545b641-1d8c-4fec-abf9-a14f2a5c8135"), "fl. oz", false, 33.81402f, "Fluid ounce", "Volume" },
                    { new Guid("2eada2c1-3d6d-497d-8c0a-f0176aec2e18"), "l", true, 1f, "Liters", "Volume" },
                    { new Guid("395b337e-b7e0-4117-a601-344533326025"), "mg", false, 1000f, "Milligram", "Mass" },
                    { new Guid("3998d8f3-2f55-4ef4-9567-221a28a15ab9"), "gal", false, 0.264172f, "Gallon", "Volume" },
                    { new Guid("525c968a-37f5-4cab-aacc-34d5c0c6039a"), "ml", false, 1000f, "Milliliters", "Volume" },
                    { new Guid("52c3b265-0020-4da5-9288-bc800c2da000"), "tsp", false, 202.8841f, "Teaspoon", "Volume" },
                    { new Guid("52fed28d-9e2e-4f43-a392-6541cd4ece48"), "g", true, 1f, "Grams", "Mass" },
                    { new Guid("58ece1ef-2d52-4dde-932e-bfc883065a91"), "oz", false, 0.035274f, "Ounce", "Mass" },
                    { new Guid("5f75f7e1-8fb9-4af5-81fd-044674dbd7a5"), "tbsp", false, 67.62805f, "Tablespoon", "Volume" },
                    { new Guid("680e37b0-1a67-4608-a8d1-a8ac849152ef"), "c", false, 4.226753f, "Cup", "Volume" },
                    { new Guid("a176c3bc-3738-454e-a5ba-7475fb2618c6"), "kg", false, 0.001f, "Kilogram", "Mass" },
                    { new Guid("f316d622-82f5-4e34-b04e-dbd44002aac4"), "st", false, 0.035274f, "Stone", "Mass" },
                    { new Guid("f3ac7f04-c797-4e15-98d9-2756cd228536"), "pt", false, 2.113376f, "Pint", "Volume" },
                    { new Guid("f43eaf9f-bc1c-4c5d-b5b0-30bc505786e8"), "lb", false, 0.035274f, "Pound", "Mass" },
                    { new Guid("f721256f-b4a7-4508-a2f5-110a15165ed3"), "qt", false, 1.056688f, "Quart", "Volume" }
                });

            migrationBuilder.InsertData(
                table: "UserRoles",
                columns: new[] { "Id", "Title" },
                values: new object[,]
                {
                    { new Guid("65bd360f-77f4-4be8-8424-934d3e690c4d"), "SuperAdmin" },
                    { new Guid("67755466-7714-4abe-a0c0-de3e68107e30"), "Admin" },
                    { new Guid("c90c6a13-5705-4bd3-bcf8-71e5bbc25656"), "Client" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "CreatedAt", "DeletedAt", "Description", "Email", "FollowerCount", "ImageId", "PasswordHash", "PasswordSalt", "TokenFacebook", "TokenTwitter", "UpdatedAt", "UserRoleId", "Username" },
                values: new object[] { new Guid("645bf299-ee46-48db-b352-ef09c5fbb21d"), new DateTime(2023, 8, 22, 2, 23, 13, 606, DateTimeKind.Local).AddTicks(4964), null, "", "admin@recetarion.com", 0u, new Guid("43c47239-a9c8-429d-9efd-942b6f46a811"), "00ZPyTB82MUBqBzPTRl9G9TJ64Q3DanjgwBxWRRdFZiE3B7KZjn0Z/DCh0DGagi42n8OZq/tNE2OikqN75crsQ==", "IQVrJsnqwPAV2J9O/2p2TBfjJAcYVU4ALhDVfC5JFmMcwbqzvMc3xXYlLmOpx1Mb/zdMQqze24iXnjNOHzD0ZVIemcsozd1gNS2C5UCxFFkmm9mszGEGRiMJA47M4MA40KadlR1aA/l5RwA17fWWOWLsbLmSgUkYHguP+ndd370=", null, null, null, new Guid("65bd360f-77f4-4be8-8424-934d3e690c4d"), "Recetarion Admin" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: new Guid("43c47239-a9c8-429d-9efd-942b6f46a811"));

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: new Guid("04f70e03-e650-443e-997e-f1ed8401e9a6"));

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: new Guid("05084dcf-0fd1-4853-b7a4-bfbb7f32d8c9"));

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: new Guid("0899d724-b0ef-4ddd-aec2-87cd1faea0c4"));

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: new Guid("092eea21-c607-4aa8-86ce-b1506636dc4e"));

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: new Guid("183039ed-0c2e-4404-adea-6fe55cd4d65f"));

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: new Guid("192af5dc-2fc2-4d11-8b8e-10a82161dece"));

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: new Guid("1f8fc129-0a98-42a9-9673-559932631fb4"));

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: new Guid("27bf3f89-c5dd-4627-9b31-ecef5504e8d9"));

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: new Guid("2806f3d8-a4ff-4270-ba99-fd11df8819da"));

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: new Guid("283cb167-332b-4244-81fd-3feef206607e"));

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: new Guid("2ce824b9-34fa-4a95-a972-3c2eb64edbc0"));

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: new Guid("3221780e-dd89-4bd7-a29a-57c810e97856"));

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: new Guid("334c2c6e-4d2e-4697-84c5-40145eb1101e"));

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: new Guid("35a0c4bc-d72f-4651-a8b6-f9eae4b73c28"));

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: new Guid("3b3a8363-7ff7-43cb-9ccd-ed43c795da1c"));

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: new Guid("42c6491f-e6f4-4f24-83b7-7c42a94e2228"));

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: new Guid("48976dbb-8d58-4fbe-bb75-cf6185d237e1"));

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: new Guid("49072cfc-9f6f-4531-a295-1ded17edf5aa"));

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: new Guid("49faabf6-7aaa-497b-81c7-9883a84ca594"));

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: new Guid("50451ec4-fe8c-4a8c-b62f-807b5d0b8f8f"));

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: new Guid("504ae686-1dbb-4da5-9b91-dbbd1cea1742"));

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: new Guid("555b2b74-2c58-408d-bfc2-bb71f142f036"));

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: new Guid("576b8820-b7c1-4333-946c-92a38206bc9c"));

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: new Guid("5a05b326-0acc-43b4-a610-10d360f614fb"));

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: new Guid("5b5a3983-6b17-4e31-a8b5-0a92fbc9eb19"));

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: new Guid("5bb15aab-e068-408f-a26b-6260a19ecfed"));

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: new Guid("5c8e218c-12a0-490f-8240-5ee0d6998e33"));

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: new Guid("5fbeef36-d475-4def-89bb-0b6aa83c87f2"));

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: new Guid("63f81d0e-83e1-441f-af19-e25cb7c863f6"));

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: new Guid("667312d2-8dc7-4438-9a4e-eb7bf86fc9f5"));

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: new Guid("66e0c93c-9bbc-4d0f-81fa-f372f5477dfe"));

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: new Guid("6f5aa8a0-0ef9-4a12-b79e-2dc5da8182ad"));

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: new Guid("75527a76-04d1-414c-971c-6456847cb879"));

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: new Guid("76c1ecdd-3548-45d6-aec1-ebb302aaa04a"));

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: new Guid("7c858b13-dc57-42e4-999b-8e0405bc9510"));

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: new Guid("7ddff466-ebf5-4904-9397-8b2f652cc55e"));

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: new Guid("7e57b864-cbbd-4be0-b76d-c162031e8f17"));

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: new Guid("7e72e5fa-6d1b-4dd5-a151-4c0aa0efc48a"));

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: new Guid("7f24d133-67cc-4717-8298-0a268f427200"));

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: new Guid("82aab854-e1b0-4de3-89a4-1ab509282de3"));

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: new Guid("90072d03-cbfc-4d7a-83b4-821d546fd1d4"));

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: new Guid("920dec8f-4d88-4fd3-9069-e2ca1a1011d3"));

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: new Guid("93644195-f6eb-4fe9-b27a-7b2580d33b8d"));

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: new Guid("9b1a5a23-21aa-48f1-b3ec-37bbaa444959"));

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: new Guid("a0007344-135c-4c40-9713-be753fe015f0"));

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: new Guid("a67be4fb-eb7a-4dc3-b00d-4e37c2abc342"));

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: new Guid("ab890672-15f2-4bb0-a5c4-ce5f6cff44db"));

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: new Guid("aeaec642-3ca6-4404-9aae-a5293fd55831"));

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: new Guid("b471b021-a4bd-4a9e-b06d-2a0e6dcb7be6"));

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: new Guid("bd940e76-7313-40a9-88f2-996317bfedbf"));

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: new Guid("c1919792-2ceb-4f6f-82d1-a9d961d3a2f0"));

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: new Guid("c410f959-8550-4e51-ba01-1f57a94dd1bf"));

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: new Guid("c7185756-2b90-43b6-b72f-f661fa4e2835"));

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: new Guid("ca89e1ae-afc7-482c-8b33-171592f42764"));

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: new Guid("ca98ba01-ce07-488b-93d6-50866f7597af"));

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: new Guid("ce9249ba-c718-437f-881e-1c3692fde203"));

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: new Guid("cf698f78-4692-4dd6-8599-9027abaa2b9a"));

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: new Guid("d39776f6-f031-4bb3-9f33-8d1d797c1349"));

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: new Guid("d5185710-bd47-4328-8277-b5516e05ac69"));

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: new Guid("d6d1a554-7839-48ea-99ba-5f7f63b2096d"));

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: new Guid("d82a45c2-7875-4091-b0f7-e9aed01a4f3e"));

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: new Guid("de8e0a2a-815e-4eab-a2ae-fa4fe0935cba"));

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: new Guid("e20c794e-70dd-4f1c-b37f-6b30d95956f2"));

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: new Guid("ecd8c95d-525f-47a0-abcb-92727b2cf52d"));

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: new Guid("ee3e7108-f932-4121-9d5f-f78890af628e"));

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: new Guid("f208e279-48c9-4190-bca9-d426235e2e1e"));

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: new Guid("f22c9132-969a-46d6-b711-c22dd697dafb"));

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: new Guid("faca3207-629e-4ec2-91b2-b0ba35aa3025"));

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: new Guid("ff1a2af4-5d6d-41c5-a3a7-c34210bf2cf3"));

            migrationBuilder.DeleteData(
                table: "Units",
                keyColumn: "Id",
                keyValue: new Guid("1545b641-1d8c-4fec-abf9-a14f2a5c8135"));

            migrationBuilder.DeleteData(
                table: "Units",
                keyColumn: "Id",
                keyValue: new Guid("2eada2c1-3d6d-497d-8c0a-f0176aec2e18"));

            migrationBuilder.DeleteData(
                table: "Units",
                keyColumn: "Id",
                keyValue: new Guid("395b337e-b7e0-4117-a601-344533326025"));

            migrationBuilder.DeleteData(
                table: "Units",
                keyColumn: "Id",
                keyValue: new Guid("3998d8f3-2f55-4ef4-9567-221a28a15ab9"));

            migrationBuilder.DeleteData(
                table: "Units",
                keyColumn: "Id",
                keyValue: new Guid("525c968a-37f5-4cab-aacc-34d5c0c6039a"));

            migrationBuilder.DeleteData(
                table: "Units",
                keyColumn: "Id",
                keyValue: new Guid("52c3b265-0020-4da5-9288-bc800c2da000"));

            migrationBuilder.DeleteData(
                table: "Units",
                keyColumn: "Id",
                keyValue: new Guid("52fed28d-9e2e-4f43-a392-6541cd4ece48"));

            migrationBuilder.DeleteData(
                table: "Units",
                keyColumn: "Id",
                keyValue: new Guid("58ece1ef-2d52-4dde-932e-bfc883065a91"));

            migrationBuilder.DeleteData(
                table: "Units",
                keyColumn: "Id",
                keyValue: new Guid("5f75f7e1-8fb9-4af5-81fd-044674dbd7a5"));

            migrationBuilder.DeleteData(
                table: "Units",
                keyColumn: "Id",
                keyValue: new Guid("680e37b0-1a67-4608-a8d1-a8ac849152ef"));

            migrationBuilder.DeleteData(
                table: "Units",
                keyColumn: "Id",
                keyValue: new Guid("a176c3bc-3738-454e-a5ba-7475fb2618c6"));

            migrationBuilder.DeleteData(
                table: "Units",
                keyColumn: "Id",
                keyValue: new Guid("f316d622-82f5-4e34-b04e-dbd44002aac4"));

            migrationBuilder.DeleteData(
                table: "Units",
                keyColumn: "Id",
                keyValue: new Guid("f3ac7f04-c797-4e15-98d9-2756cd228536"));

            migrationBuilder.DeleteData(
                table: "Units",
                keyColumn: "Id",
                keyValue: new Guid("f43eaf9f-bc1c-4c5d-b5b0-30bc505786e8"));

            migrationBuilder.DeleteData(
                table: "Units",
                keyColumn: "Id",
                keyValue: new Guid("f721256f-b4a7-4508-a2f5-110a15165ed3"));

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumn: "Id",
                keyValue: new Guid("67755466-7714-4abe-a0c0-de3e68107e30"));

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumn: "Id",
                keyValue: new Guid("c90c6a13-5705-4bd3-bcf8-71e5bbc25656"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("645bf299-ee46-48db-b352-ef09c5fbb21d"));

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumn: "Id",
                keyValue: new Guid("65bd360f-77f4-4be8-8424-934d3e690c4d"));
        }
    }
}

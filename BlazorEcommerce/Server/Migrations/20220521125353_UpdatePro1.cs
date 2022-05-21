using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BlazorEcommerce.Server.Migrations
{
    public partial class UpdatePro1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Concenstration", "Description", "Featured", "ImageUrl", "Title" },
                values: new object[] { "Eau De Parfum", "BLEU DE CHANEL khẳng định bản lĩnh hoàn hảo thông qua một mùi hương bất ngờ và vượt thời gian. Hương thơm hương gỗ tỏa ra thành một đường mòn quyến rũ, thể hiện sự độc lập với sức mạnh và sự sang trọng, giống như người đàn ông mang nó.", false, "https://www.chanel.com/images//t_one//w_0.51,h_0.51,c_crop/q_auto:good,f_auto,fl_lossy,dpr_1.2/w_620/bleu-de-chanel-eau-de-parfum-spray-3-4fl-oz--packshot-default-107360-8848377380894.jpg", "Bleu de CHANEL" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Concenstration", "Description", "ImageUrl", "Title" },
                values: new object[] { "Eau De Toilette", "Một hương thơm tươi mát và phảng phất mùi gỗ ấm. Sự pha trộn của những nốt hương tươi mát, sống động và gợi cảm gợi lên sức hút của một người đàn ông phóng khoáng.", "https://www.chanel.com/images/t_one//w_0.51,h_0.51,c_crop/q_auto:good,f_auto,fl_lossy,dpr_1.2/w_320//allure-homme-sport-eau-de-toilette-spray-3-4fl-oz--packshot-default-123630-8848376758302.jpg", "Allure Homme Sport" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Concenstration", "Description", "ImageUrl", "Title" },
                values: new object[] { "Eau De Parfum", "Một khía cạnh mãnh liệt của tính cách COCO MADEMOISELLE nổi lên để tạo nên một hương thơm quyến rũ sâu sắc, mạnh mẽ mà không thể cưỡng lại theo mọi cách. Thể hiện một người phụ nữ vui tươi và nổi loạn, tự do sáng tạo lại bản thân ngày này qua ngày khác.", "https://www.chanel.com/images//t_one//w_0.51,h_0.51,c_crop/q_auto:good,f_auto,fl_lossy,dpr_1.2/w_320/coco-mademoiselle-eau-de-parfum-intense-spray-3-4fl-oz--packshot-default-116660-8848376889374.jpg", "Coco" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CategoryId", "Concenstration", "Description", "ImageUrl", "Title" },
                values: new object[] { 1, "Eau De Toilette", "Sắc nét và sạch sẽ, ấm áp và gợi cảm, ALLURE HOMME là sự thể hiện sức hút và sự quyết tâm bên trong của một người đàn ông. Một thành phần tươi, cay và gỗ thể hiện sự hiện diện của người đàn ông dùng nó.", "https://www.chanel.com/images//t_one//w_0.51,h_0.51,c_crop/q_auto:good,f_auto,fl_lossy,dpr_1.2/w_320/allure-homme-eau-de-toilette-spray-3-4fl-oz--packshot-default-121460-8848377610270.jpg", "Allure Homme" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CategoryId", "Concenstration", "Description", "Featured", "ImageUrl", "Title" },
                values: new object[] { 1, "Eau De Toilette", "Như bức chân dung của một quý ông có tính cách hướng ngoại, cá tính và khiêu khích. Phiên bản Eau de Toilette mang nốt hương xanh fougère-vert. Một mùi hương tràn đầy năng lượng với những nốt hương tươi mát.", false, "https://www.chanel.com/images//t_one//w_0.51,h_0.51,c_crop/q_auto:good,f_auto,fl_lossy,dpr_1.2/w_620/platinum-egoiste-eau-de-toilette-spray-1-7fl-oz--packshot-default-124450-8848319512606.jpg", "Platinum Égoïste" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CategoryId", "Concenstration", "Description", "ImageUrl", "Title" },
                values: new object[] { 1, "Eau De Parfum", "Hương thơm phương Đông tươi mới. Một sự pha trộn của nóng và lạnh. Đặc tính mùi hương đầy tiên phong, khiêu khích quý ông với thị hiếu khác biệt và những tuyên ngôn táo bạo.", "https://www.chanel.com/images//t_one//w_0.51,h_0.51,c_crop/q_auto:good,f_auto,fl_lossy,dpr_1.2/w_320/allure-homme-edition-blanche-eau-de-parfum-spray-3-4fl-oz--packshot-default-127460-8848377118750.jpg", "Allure Homme Édition Blanche" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CategoryId", "Concenstration", "Description", "ImageUrl", "Title" },
                values: new object[] { 1, "Eau De Toilette", "Được tạo ra vào năm 1955 với tên gọi Eau de Toilette, POUR MONSIEUR là loại nước hoa dành cho nam giới đầu tiên của Chanel. Một phiên bản mạnh mẽ hơn của bản gốc, Eau de Parfum là một mùi hương Chypre hương gỗ, tươi mát nhưng vẫn giữ được sự sang trọng tinh tế. Một thành phần tinh tế và vượt thời gian.", "https://www.chanel.com/images//t_one//w_0.55,h_0.55,c_crop/q_auto:good,f_auto,fl_lossy,dpr_1.2/w_320/pour-monsieur-eau-de-parfum-spray-2-5fl-oz--packshot-default-127451-8824192106526.jpg", "Pour Monsieur" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CategoryId", "Concenstration", "Description", "Featured", "ImageUrl", "Title" },
                values: new object[] { 1, "Eau De Toilette", "Huyền thoại về một người anh hùng mang tính cách mạnh mẽ và đa cảm được thuật lại qua mùi hương da thuộc mãnh liệt và tinh tế. Hương thơm độc nhất được chứa bên trong thiết kế chai hình vuông màu đen với các cạnh bo tròn. Một biểu tượng cho sự mạnh mẽ và nhạy cảm đầy nam tính.", false, "https://www.chanel.com/images//t_one//w_0.51,h_0.51,c_crop/q_auto:good,f_auto,fl_lossy,dpr_1.2/w_320/antaeus-eau-de-toilette-spray-3-4fl-oz--packshot-default-118460-8824198627358.jpg", "Antaeus" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CategoryId", "Concenstration", "Description", "ImageUrl", "Title" },
                values: new object[] { 1, "Eau De Parfum", "Kể từ khi được tạo ra vào năm 1921, N°5 đã toát lên bản chất của sự nữ tính. Mùi hương bí ẩn, trừu tượng - sống động với vô số khía cạnh tinh tế - tỏa ra một hương hoa phong phú lộng lẫy. Vào năm 1986, Jacques Polge đã diễn giải lại thành phần của người tiền nhiệm Ernest Beaux để tạo ra một phiên bản đầy đủ hơn, phong phú hơn của hương thơm bây giờ và mãi mãi: Eau de Parfum.", "https://www.chanel.com/images//t_one//w_0.51,h_0.51,c_crop/q_auto:good,f_auto,fl_lossy,dpr_1.2/w_320/n-5-eau-de-parfum-spray-3-4fl-oz--packshot-default-125530-8848376856606.jpg", "No.5" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CategoryId", "Concenstration", "Description", "ImageUrl", "Title" },
                values: new object[] { 2, "Eau De Parfum", "Vượt qua giới tính và thời gian, Gucci Mémoire d'Une Odeur pha trộn giữa Cúc La Mã và Hoa nhài San hô Ấn Độ để thành lập một họ khứu giác mới, Mineral Aromatic", "https://media.gucci.com/style/DarkGray_Center_0_0_2400x2400/1562765403/589186_99999_0099_001_100_0000_Light-Gucci-Mmoire-dune-Odeur-100ml-Eau-de-Parfum.jpg", "Gucci Mémoire d'une Odeur" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryId", "Concenstration", "Deleted", "Description", "Featured", "ImageUrl", "Title", "Visible" },
                values: new object[,]
                {
                    { 12, 2, "Eau De Parfum", false, "A Midnight Stroll của Gucci là một hương thơm Woody dành cho phụ nữ và nam giới. Đây là một hương thơm mới. A Midnight Stroll được ra mắt vào năm 2020. Người đứng sau loại nước hoa này là Alberto Morillas.", false, "https://media.gucci.com/style/DarkGray_Center_0_0_490x490/1589363106/624466_99999_0099_001_100_0000_Light-A-Midnight-Stroll-Incense-100ml-eau-de-parfum.jpg", "A Midnight Stroll", true },
                    { 13, 2, "Eau De Parfum", false, "A Chant for the Nymph' eau de parfum Là biểu tượng của sự bất tử cho thiên đường, mùi bền bỉ mà nó tỏa ra vào những đêm ấm áp, hoa Frangipani - hoa sứ định nghĩa nước hoa và gợi lại câu chuyện về một tiên nữ thần thoại xuất hiện trong một giấc mơ đêm mùa hè bị lãng quên từ lâu. Hương thơm hòa quyện với Ylang Ylang say đắm lòng người, hoa Tiare gợi cảm và Vanilla mềm mại.", false, "https://media.gucci.com/style/DarkGray_Center_0_0_490x490/1589363106/624470_99999_0099_001_100_0000_Light-A-Chant-for-the-Nymph-Frangipani-100ml-eau-de-parfum.jpg", "A Chant for the Nymph", true },
                    { 14, 2, "Eau De Parfum", false, "The Alchemist’s Garden. Hortus Sanitatis mang đến vibe sang trọng, cổ điển đậm chất Gucci. Nếu như bạn thấy hương thơm của Gucci Bloom quá quen thuộc thì có thể “đổi gió” với siêu phẩm nước hoa Hortus Sanitatis. Được mệnh danh là bản nhạc mới trong khu vườn của nhà giả kim hứa hẹn sẽ không làm nàng thất vọng.", false, "https://media.gucci.com/style/DarkGray_Center_0_0_490x490/1582738204/625029_99999_0099_001_100_0000_Light-Hortus-Sanitatis-Papyrus-and-Cedarwood-100ml-eau-de-parfum.jpg", "Hortus Sanitatis", true },
                    { 15, 2, "Eau De Parfum", false, "A Song For The Rose Eau de Parfum - Một giai điệu cho những búp hoa hồng: Biểu hiện của sự nữ tính tuyệt đối, chiết xuất từ Hoa hồng Bungari được giữ lại ở dạng tinh khiết nhất, ngay trước khi thu hoạch trên khu vườn.Được pha trộn với Xạ hương ngọt ngào và hương gỗ mạnh mẽ.", false, "https://media.gucci.com/style/DarkGray_Center_0_0_800x800/1546620303/548627_99999_0099_001_100_0000_Light-A-Song-for-the-Rose-Rose-100ml-eau-de-parfum.jpg", "A Song for the Rose", true },
                    { 16, 2, "Eau De Parfum", false, "Nước mắt của Iris “Nước của Iris” Eau Ee Parfum Unisex và một chai thủy tinh tinh mài mài chỉ có hiệu ứng ứng ứng với sứ, trang trí bằng cách nhấn bằng vàng… hoa Iris tỏa ra một mùi hương gợi cảm, hòa quyện với Gỗ đàn hương, Hạt bạch chỉ và Cây xạ hương… Làm nổi bật hương thơm và chất lượng của nó từ bộ sưu tập tập ra một pha trộn cá nhân hóa… cháu dễ dàng đi sâu vào tiềm thức ,không khó quên lạ.", false, "https://media.gucci.com/style/DarkGray_Center_0_0_800x800/1546620303/548625_99999_0099_001_100_0000_Light-Tears-of-Iris-Iris-100ml-eau-de-parfum.jpg", "Tears of Iris", true },
                    { 17, 2, "Parfum", false, "ading Autumn Scented Water của Gucci là một loại nước hoa có hương gỗ dành cho phụ nữ và nam giới. Fading Autumn Eau de Toilette của Gucci này có hương thơm gỗ unisex. Nó có cây tuyết tùng, dầu cypriol, cây hoắc hương và gỗ đàn hương.", false, "https://media.gucci.com/style/DarkGray_Center_0_0_800x800/1546620305/548759_99999_0099_001_100_0000_Light-Fading-Autumn-Woods-150ml-acqua-profumata.jpg", "Fading Autumn", true },
                    { 18, 2, "Parfum", false, "A Kiss from Violet là một loại nước hoa của Gucci dành cho phụ nữ và nam giới và được phát hành vào năm 2019 . Mùi hương là hương hoa da thuộc.", false, "https://media.gucci.com/style/DarkGray_Center_0_0_800x800/1547226905/548765_99999_0099_001_100_0000_Light-A-Kiss-from-Violet-Violet-20ml-perfumed-oil.jpg", "A Kiss from Violet", true },
                    { 19, 2, "Eau De Parfum", false, "Một sản phẩm đương đại lấy hai thành phần nước hoa mang tính biểu tượng phổ biến trong những năm 70, hương đầu của Hoa hồng và Hạt tiêu tạo ra một cảm giác cổ điển tràn đầy sinh lực, với chút giấm và muối cho một kết thúc bất ngờ.", false, "https://media.gucci.com/style/DarkGray_Center_0_0_2400x2400/1582739103/613748_99999_0099_001_100_0000_Light-Gucci-Guilty-Pour-Homme-90ml-eau-de-parfum.jpg", "Gucci Guilty Pour Homme", true },
                    { 20, 2, "Eau De Parfum", false, "Với thiết kế đầy mạnh mẽ và nam tính, Gucci Guilty Pour Homme đã phần nào toát lên nét đẹp vững chãi, lãng du của mình chỉ qua một cái nhìn. Tông hương đầu của Oải hương cùng Chanh từ tốn mở ra làn gió thoáng mát, sảng khoái cho mùa hè với hương thơm thanh thoát điển hình. Nhanh chóng nhường chỗ cho Hoa cam, Guilty ở tầng hương tiếp theo bộc lộ ngày càng rõ ràng mùi vị nồng nàn đầy lôi cuốn, để rồi kết thúc trong sự hòa quyện của Hoắc hương, Tuyết tùng và Vanilla the mát, ngọt dịu. Phóng đãng, tươi mới đầy tài tình, Gucci Guilty Pour Homme như viên nam châm, thu hút tất cả sự chú ý xung quanh về phía mình.", false, "https://media.gucci.com/style/DarkGray_Center_0_0_800x800/1582739103/613748_99999_0099_001_100_0000_Light-Gucci-Guilty-Pour-Homme-90ml-eau-de-parfum.jpg", "Gucci Bloom Profumo di Fiori", true },
                    { 21, 3, "Parfum", false, "Sauvage Elixir là một hương thơm cô đặc đặc biệt * ngập tràn trong sự tươi mát mang tính biểu tượng của Sauvage với trái tim say đắm của Gia vị, tinh chất Oải hương được thiết kế riêng và sự pha trộn của các loại Gỗ phong phú tạo nên dấu ấn đặc trưng của đường mòn mạnh mẽ, xa hoa và quyến rũ.", false, "https://eco-beauty.dior.com/dw/image/v2/BDGF_PRD/on/demandware.static/-/Sites-master_dior/default/dw59f3c992/assets/Y0996460/Y0996460_C099600755_E01_ZHC.jpg?sw=870&sh=580&sm=fit&imwidth=870", "Sauvage", true },
                    { 22, 3, "Parfum", false, "Dior Homme được khoác lên mình như cách bạn mặc một bộ vest sang trọng, sắc nét hiện đại. Dior Homme Intense Eau de Parfum thể hiện sự hùng vĩ và tinh tế của một loại eau de parfum hào phóng và mạnh mẽ. Cường độ khứu giác của Iris được tăng cường nhờ mặt màu Hổ phách gợi cảm và lớp nền Gỗ quý. Một kịch bản mùi mẫn, gợi cảm có dấu vết gọi đến bạn.", false, "https://eco-beauty.dior.com/dw/image/v2/BDGF_PRD/on/demandware.static/-/Sites-master_dior/default/dw6a1294a4/assets/Y0479201/Y0479201_F047924709_E01_ZHC.jpg?sw=870&sh=580&sm=fit&imwidth=870", "Dior Homme Intense", true },
                    { 23, 3, "Eau De Toilette", false, "Tràn đầy năng lượng và thanh lịch, Dior Homme Sport eau de toilette mới kết hợp sự sôi nổi tươi mới và nét quyến rũ pha chút gợi cảm cho một bộ đôi mang phong cách như một võ sĩ quyền anh.", false, "https://eco-beauty.dior.com/dw/image/v2/BDGF_PRD/on/demandware.static/-/Sites-master_dior/default/dw64b5efc2/assets/Y0996476/Y0996476_C099600782_E01_ZHC.jpg?sw=870&sh=580&sm=fit&imwidth=870", "Dior Homme Sport", true },
                    { 24, 3, "Cologne", false, "Dior Homme tái định nghĩa một sự gợi cảm nam tính, mới mẻ trong âm hưởng đa âm của hương gỗ thô và mịn. Một trái tim của gỗ dịu dàng, trong đó sự mạnh mẽ của Atlas Cedar ôm trọn sự ấm áp bao bọc của cỏ Vetiver Haiti nhuốm màu gia vị. Đồ gỗ do Dior đục đẽo bằng tay.", false, "https://eco-beauty.dior.com/dw/image/v2/BDGF_PRD/on/demandware.static/-/Sites-master_dior/default/dw2a7995bc/assets/Y0996157/Y0996157_C099600157_E01_ZHC.jpg?sw=870&sh=580&sm=fit&imwidth=870", "Dior Homme", true },
                    { 25, 3, "Eau De Toilette", false, "Hương thơm của hoa diên vĩ nam tính. Một dấu hiệu khứu giác gợi cảm được nâng cao bởi các nốt hương gỗ virile cho một sự tinh tế khác thường. Dior Homme được khoác lên mình như cách bạn mặc một bộ vest sang trọng, sắc nét hiện đại. Để lại dấu vết khứu giác của mùi hương gỗ, cay nồng đó, dấu hiệu nhận biết ngay lập tức của một phong cách khác biệt.", false, "https://eco-beauty.dior.com/dw/image/v2/BDGF_PRD/on/demandware.static/-/Sites-master_dior/default/dw9bcf86fe/assets/Y0469201/Y0469201_F046922009_E01_ZHC.jpg?sw=870&sh=580&sm=fit&imwidth=870", "Dior Homme Original", true },
                    { 26, 3, "Parfum", false, "Một mình đối mặt với những yếu tố hùng vĩ, người đàn ông của Phi Luân Hải đã hóa thân vào một khát khao tuyệt đối. Vượt thời gian và phổ quát, Fahrenheit là một hương thơm vượt qua thời gian và xu hướng để tạo nên lãnh thổ của riêng mình. Một dấu hiệu khứu giác tương phản, độc đáo * với một dấu vết mạnh mẽ kéo dài. Hương thơm được cấu trúc xung quanh những nốt hương tươi mát của Sicilian Mandarin, một sự pha trộn đáng ngạc nhiên giữa hương Gỗ và Da nam tính, và một hương vị * Violet độc đáo.", false, "https://eco-beauty.dior.com/dw/image/v2/BDGF_PRD/on/demandware.static/-/Sites-master_dior/default/dw7a79271b/assets/Y0066001/Y0066001_F006624009_E01_ZHC_2.jpg?sw=870&sh=580&sm=fit&imwidth=870", "Fahrenheit", true },
                    { 27, 3, "Parfum", false, "Eau Sauvage Eau de Toilette không chỉ là một hương thơm. Nó đồng nghĩa với sự sang trọng tuyệt đối, một “tinh thần Dior” bền bỉ hòa quyện với nét hiện đại.Hương vị cam quýt hoa của nó vừa tinh tế vừa mạnh mẽ, tinh tế và tươi mát. Sự cân bằng tinh tế của cam bergamot San Carlo, được thu hoạch dành riêng cho Eau Sauvage, cảm giác rực rỡ của hedione với chất lượng hoa mượt mà độc đáo, và dấu vết chypre đặc biệt.", false, "https://eco-beauty.dior.com/dw/image/v2/BDGF_PRD/on/demandware.static/-/Sites-master_dior/default/dw18051da9/assets/Y0097001/Y0097001_F009724109_E01_ZHC.jpg?sw=870&sh=580&sm=fit&imwidth=870", "Eau Sauvage", true },
                    { 28, 3, "Eau De Toilette", false, "Hương thơm gỗ thơm đầy bất ngờ này được tạo ra để dành cho người đàn ông thành thị hiện đại, sống trong khoảnh khắc hiện tại nhưng vẫn thể hiện sự nam tính vĩnh cửu. Mát mẻ và tràn đầy năng lượng, với các nốt hương của lê, cam quýt và húng quế, vị cay nồng và mùi xạ hương.", false, "https://eco-beauty.dior.com/dw/image/v2/BDGF_PRD/on/demandware.static/-/Sites-master_dior/default/dwd71e67be/assets/Y0660201/Y0660201_F066024009_E01_ZHC.jpg?sw=870&sh=580&sm=fit&imwidth=870", "Higher", true },
                    { 29, 3, "Eau De Parfum", false, "Khi bạn nghe J'adore, tất nhiên bạn sẽ nghĩ đến hương thơm cùng tên. Nhưng đừng quên ý nghĩa đầu tiên: đó là tiếng kêu từ trái tim - tiếng kêu của cảm xúc, khi đối mặt với thứ gì đó thu hút tất cả các giác quan của chúng ta, điều đó quyến rũ chúng ta và vận chuyển chúng ta.", false, "https://eco-beauty.dior.com/dw/image/v2/BDGF_PRD/on/demandware.static/-/Sites-master_dior/default/dw2f353651/assets/Y0996401/Y0996401_C099700049_E01_ZHC.jpg?sw=870&sh=580&sm=fit&imwidth=870", "J’adore", true },
                    { 30, 3, "Eau De Toilette", false, "Một loại nước hoa nam mạnh mẽ bao gồm các nốt hương màu xanh lá cây của gỗ và các điểm nhấn của hạt tiêu cay.", false, "https://eco-beauty.dior.com/dw/image/v2/BDGF_PRD/on/demandware.static/-/Sites-master_dior/default/dwf2d52cc8/assets/Y0061201/Y0061201_F006124109_E01_ZHC.jpg?sw=870&sh=580&sm=fit&imwidth=870", "Jules", true },
                    { 31, 4, "Eau De Parfum", false, "Louis Vuitton Météore thuộc chai nước hoa thứ 6 của bộ sưu tập nước hoa xa xỉ Louis Vuitton, đến từ bàn tay của bậc thầy mùi hương Jacques Cavallier Belletrud. Météore. Cái tên đầy cuốn hút với sức mạnh tỏa ra từ ánh sáng, khơi dậy niềm đam mê cho những chuyến đi không bao giờ dứt, giống như những đám mây rực rỡ khiến cho bầu trời bỗng nhiên bốc cháy và làm lóa hết mọi ánh nhìn.", false, "https://eu.louisvuitton.com/images/is/image/lv/1/PP_VP_L/louis-vuitton-m%C3%A9t%C3%A9ore-fragrances--LP0160_PM1_Interior%20view.png?wid=1080", "Météore", true },
                    { 32, 4, "Eau De Parfum", false, "Một trong những mẫu nước hoa của Louis Vuitton đang được săn lùng nhiều nhất trên thị trường đó chính là nước hoa L’IMMENSITÉ PERFUME. Mẫu nước hoa này nổi bật với hương thơm sang trọng, vị cay trầm ấm và kiểu dáng nhỏ gọn, cuốn hút.", false, "https://eu.louisvuitton.com/images/is/image/lv/1/PP_VP_L/louis-vuitton-l-immensit%C3%A9-fragrances--LP0052_PM1_Interior%20view.png?wid=1080", "L’immensité", true },
                    { 33, 4, "Eau De Parfum", false, "Nước hoa Louis Vuitton Orage mang mùi hương thanh lịch, trang nhã, độ toả hương cực xa. Orage Louis Vuitton là sự hoà trộn hoàn hảo của Chanh, Hoa Iris, Patchouli và tinh dầu Vetiver Java gồm 3 hương đầu, giữa và cuối cho một ngày dài năng động với hương thơm suốt ngày dài.", false, "https://eu.louisvuitton.com/images/is/image/lv/1/PP_VP_L/louis-vuitton-orage-fragrances--LP0051_PM1_Interior%20view.png?wid=1080", "Orage", true },
                    { 34, 4, "Eau De Parfum", false, "Nước hoa NOUVEAU MONDE thuộc nhóm hương phương Đông nên mang đến phong cách nam tính, mạnh mẽ, phiêu lưu và cực kỳ lôi cuốn. Một chút nồng ấm của trầm hương hòa quyện với sự bay bổng của da thuộc giúp phái mạnh tận hưởng trọn vẹn mùi hương đẳng cấp nhất.", false, "https://eu.louisvuitton.com/images/is/image/lv/1/PP_VP_L/louis-vuitton-nouveau-monde-fragrances--LP0053_PM1_Interior%20view.png?wid=1080", "Nouveau Monde", true },
                    { 35, 4, "Eau De Parfum", false, "Nước hoa SUR LA ROUTE của Louis Vuitton được sản xuất dành cho những quý ông thành đạt và khao khát về một mùi hương nam tính, sang trọng, đẳng cấp. Bậc thầy mùi hương Jacques luôn tìm tòi, sáng tạo và mang đến một siêu phẩm chứa đựng những điều tuyệt vời nhất.", false, "https://us.louisvuitton.com/images/is/image/lv/1/PP_VP_L/louis-vuitton-sur-la-route-fragrances--LP0055_PM2_Front%20view.png?wid=1240&hei=1240", "Sur La Route", true },
                    { 36, 4, "Eau De Parfum", false, "Với phái mạnh, việc chọn cho mình được một mẫu nước hoa đẳng cấp, sang trọng sẽ mang lại một phong thái tự tin, cuốn hút. Hiểu được điều đó, Louis Vuitton đã tung ra thị trường mẫu nước hoa AU HASARD PERFUME chinh phục phái mạnh ngay từ lần đầu trải nghiệm.", false, "https://eu.louisvuitton.com/images/is/image/lv/1/PP_VP_L/louis-vuitton-au-hasard-fragrances--LP0054_PM2_Front%20view.png?wid=2048&hei=2048", "Au Hasard", true },
                    { 37, 4, "Eau De Parfum", false, "Heures D'Absence là dòng sản phẩm dành cho nữ được sáng tác bởi nhà Louis Vuitton, đây là loại nước hoa đánh dấu sự đổi mới và bùng nổ sáng tạo của Louis. Một hương thơm nắm bắt được dòng chảy của thời gian và tôn vinh thiết kế đơn giản, thanh lịch, đã tạo nên sức hút và chỗ đứng nhất định của nhà Louis trong lòng các thượng khách. Một nơi nghỉ ngơi tuyệt đẹp qua những cánh đồng hoa Grasse, đây chính là lời ca tụng của những bông hoa tươi, một hình tượng ngụ ngôn về niềm vui, tình yêu và sự thoát tục.", false, "https://eu.louisvuitton.com/images/is/image/lv/1/PP_VP_L/louis-vuitton-heures-d-absence-fragrances--LP0113_PM2_Front%20view.png?wid=2048&hei=2048", "Heures D’absence", true },
                    { 38, 4, "Eau De Parfum", false, "Coeur Battant khuếch đại vẻ đẹp kỳ vĩ của thiên nhiên, cụ thể hơn là cảm giác đắm mình vào hoàng hôn tinh khôi của ngày mới – một khung cảnh khơi dậy sự thức tỉnh thanh bình trong tâm trí, nhưng cũng đong đầy xúc cảm xao xuyến, rộn ràng.", false, "https://eu.louisvuitton.com/images/is/image/lv/1/PP_VP_L/louis-vuitton-coeur-battant-fragrances--LP0151_PM2_Front%20view.png?wid=2048&hei=2048", "Coeur Battant", true },
                    { 39, 4, "Eau De Parfum", false, "Ombre Nomade là một hương thơm tinh khiết, nó mạnh mẽ và tái xác định mùi của thế giới Trung Đông và sự gợi cảm của nó trộn lẫn với nữ tính và nam tính. Mạnh mẽ, nồng nàn và nam tính, trầm hương là một trong những hương liệu thuần khiết đắt đỏ nhất thế giới. Mùi trầm hương mang đến cảm giác ấm áp với hương gỗ thơm nhẹ, mùi khói và vị ngọt quyến rũ.", false, "https://eu.louisvuitton.com/images/is/image/lv/1/PP_VP_L/louis-vuitton-ombre-nomade-fragrances--LP0095_PM2_Front%20view.png?wid=2048&hei=2048", "Ombre Nomade", true },
                    { 40, 4, "Eau De Parfum", false, "Mệnh danh là một trong những hương thơm đẳng cấp và cực kỳ ấm áp đến từ nhà Louis Vuitton thông qua dòng hương Gỗ Phương Đông, Louis Vuitton Nuit De Feu chiếm trọn tình yêu của các phái bởi tính chất Unisex đặc biệt cất giữ đằng sau lớp vỏ ngoài cơ bản.", false, "https://eu.louisvuitton.com/images/is/image/lv/1/PP_VP_L/louis-vuitton-nuit-de-feu-fragrances--LP0167_PM2_Front%20view.png?wid=2048&hei=2048", "Nuit De Feu", true }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Concenstration", "Description", "Featured", "ImageUrl", "Title" },
                values: new object[] { "", "The Hitchhiker's Guide to the Galaxy[note 1] (sometimes referred to as HG2G,[1] HHGTTG,[2] H2G2,[3] or tHGttG) is a comedy science fiction franchise created by Douglas Adams. Originally a 1978 radio comedy broadcast on BBC Radio 4, it was later adapted to other formats, including stage shows, novels, comic books, a 1981 TV series, a 1984 text-based computer game, and 2005 feature film.", true, "https://upload.wikimedia.org/wikipedia/en/b/bd/H2G2_UK_front_cover.jpg", "The Hitchhiker's Guide to the Galaxy" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Concenstration", "Description", "ImageUrl", "Title" },
                values: new object[] { "", "Ready Player One is a 2011 science fiction novel, and the debut novel of American author Ernest Cline. The story, set in a dystopia in 2045, follows protagonist Wade Watts on his search for an Easter egg in a worldwide virtual reality game, the discovery of which would lead him to inherit the game creator's fortune. Cline sold the rights to publish the novel in June 2010, in a bidding war to the Crown Publishing Group (a division of Random House).[1] The book was published on August 16, 2011.[2] An audiobook was released the same day; it was narrated by Wil Wheaton, who was mentioned briefly in one of the chapters.[3][4]Ch. 20 In 2012, the book received an Alex Award from the Young Adult Library Services Association division of the American Library Association[5] and won the 2011 Prometheus Award.[6]", "https://upload.wikimedia.org/wikipedia/en/a/a4/Ready_Player_One_cover.jpg", "Ready Player One" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Concenstration", "Description", "ImageUrl", "Title" },
                values: new object[] { "", "Nineteen Eighty-Four (also stylised as 1984) is a dystopian social science fiction novel and cautionary tale written by English writer George Orwell. It was published on 8 June 1949 by Secker & Warburg as Orwell's ninth and final book completed in his lifetime. Thematically, it centres on the consequences of totalitarianism, mass surveillance and repressive regimentation of people and behaviours within society.[2][3] Orwell, a democratic socialist, modelled the totalitarian government in the novel after Stalinist Russia and Nazi Germany.[2][3][4] More broadly, the novel examines the role of truth and facts within politics and the ways in which they are manipulated.", "https://upload.wikimedia.org/wikipedia/commons/c/c3/1984first.jpg", "Nineteen Eighty-Four" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CategoryId", "Concenstration", "Description", "ImageUrl", "Title" },
                values: new object[] { 2, "", "The Matrix is a 1999 science fiction action film written and directed by the Wachowskis, and produced by Joel Silver. Starring Keanu Reeves, Laurence Fishburne, Carrie-Anne Moss, Hugo Weaving, and Joe Pantoliano, and as the first installment in the Matrix franchise, it depicts a dystopian future in which humanity is unknowingly trapped inside a simulated reality, the Matrix, which intelligent machines have created to distract humans while using their bodies as an energy source. When computer programmer Thomas Anderson, under the hacker alias \"Neo\", uncovers the truth, he \"is drawn into a rebellion against the machines\" along with other people who have been freed from the Matrix.", "https://upload.wikimedia.org/wikipedia/en/c/c1/The_Matrix_Poster.jpg", "The Matrix" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CategoryId", "Concenstration", "Description", "Featured", "ImageUrl", "Title" },
                values: new object[] { 2, "", "Back to the Future is a 1985 American science fiction film directed by Robert Zemeckis. Written by Zemeckis and Bob Gale, it stars Michael J. Fox, Christopher Lloyd, Lea Thompson, Crispin Glover, and Thomas F. Wilson. Set in 1985, the story follows Marty McFly (Fox), a teenager accidentally sent back to 1955 in a time-traveling DeLorean automobile built by his eccentric scientist friend Doctor Emmett \"Doc\" Brown (Lloyd). Trapped in the past, Marty inadvertently prevents his future parents' meeting—threatening his very existence—and is forced to reconcile the pair and somehow get back to the future.", true, "https://upload.wikimedia.org/wikipedia/en/d/d2/Back_to_the_Future.jpg", "Back to the Future" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CategoryId", "Concenstration", "Description", "ImageUrl", "Title" },
                values: new object[] { 2, "", "Toy Story is a 1995 American computer-animated comedy film produced by Pixar Animation Studios and released by Walt Disney Pictures. The first installment in the Toy Story franchise, it was the first entirely computer-animated feature film, as well as the first feature film from Pixar. The film was directed by John Lasseter (in his feature directorial debut), and written by Joss Whedon, Andrew Stanton, Joel Cohen, and Alec Sokolow from a story by Lasseter, Stanton, Pete Docter, and Joe Ranft. The film features music by Randy Newman, was produced by Bonnie Arnold and Ralph Guggenheim, and was executive-produced by Steve Jobs and Edwin Catmull. The film features the voices of Tom Hanks, Tim Allen, Don Rickles, Wallace Shawn, John Ratzenberger, Jim Varney, Annie Potts, R. Lee Ermey, John Morris, Laurie Metcalf, and Erik von Detten. Taking place in a world where anthropomorphic toys come to life when humans are not present, the plot focuses on the relationship between an old-fashioned pull-string cowboy doll named Woody and an astronaut action figure, Buzz Lightyear, as they evolve from rivals competing for the affections of their owner, Andy Davis, to friends who work together to be reunited with Andy after being separated from him.", "https://upload.wikimedia.org/wikipedia/en/1/13/Toy_Story.jpg", "Toy Story" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CategoryId", "Concenstration", "Description", "ImageUrl", "Title" },
                values: new object[] { 3, "", "Diablo II is an action role-playing hack-and-slash computer video game developed by Blizzard North and published by Blizzard Entertainment in 2000 for Microsoft Windows, Classic Mac OS, and macOS.", "https://upload.wikimedia.org/wikipedia/en/d/d5/Diablo_II_Coverart.png", "Diablo II" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CategoryId", "Concenstration", "Description", "Featured", "ImageUrl", "Title" },
                values: new object[] { 3, "", "Day of the Tentacle, also known as Maniac Mansion II: Day of the Tentacle, is a 1993 graphic adventure game developed and published by LucasArts. It is the sequel to the 1987 game Maniac Mansion.", true, "https://upload.wikimedia.org/wikipedia/en/7/79/Day_of_the_Tentacle_artwork.jpg", "Day of the Tentacle" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CategoryId", "Concenstration", "Description", "ImageUrl", "Title" },
                values: new object[] { 3, "", "The Xbox is a home video game console and the first installment in the Xbox series of video game consoles manufactured by Microsoft.", "https://upload.wikimedia.org/wikipedia/commons/4/43/Xbox-console.jpg", "Xbox" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CategoryId", "Concenstration", "Description", "ImageUrl", "Title" },
                values: new object[] { 3, "", "The Super Nintendo Entertainment System (SNES), also known as the Super NES or Super Nintendo, is a 16-bit home video game console developed by Nintendo that was released in 1990 in Japan and South Korea.", "https://upload.wikimedia.org/wikipedia/commons/e/ee/Nintendo-Super-Famicom-Set-FL.jpg", "Super Nintendo Entertainment System" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryId", "Concenstration", "Deleted", "Description", "Featured", "ImageUrl", "Title", "Visible" },
                values: new object[] { 7, 3, "", false, "Half-Life 2 is a 2004 first-person shooter game developed and published by Valve. Like the original Half-Life, it combines shooting, puzzles, and storytelling, and adds features such as vehicles and physics-based gameplay.", false, "https://upload.wikimedia.org/wikipedia/en/2/25/Half-Life_2_cover.jpg", "Half-Life 2", true });
        }
    }
}

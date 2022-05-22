﻿namespace BlazorEcommerce.Server.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CartItem>()
                .HasKey(ci => new { ci.UserId, ci.ProductId, ci.ProductTypeId });

            modelBuilder.Entity<ProductVariant>()
                .HasKey(p => new { p.ProductId, p.ProductTypeId });

            modelBuilder.Entity<OrderItem>()
                .HasKey(oi => new { oi.OrderId, oi.ProductId, oi.ProductTypeId });

            modelBuilder.Entity<ProductType>().HasData(
                    new ProductType { Id = 1, Name = "35 ml" },
                    new ProductType { Id = 2, Name = "50 ml" },
                    new ProductType { Id = 3, Name = "60 ml" },
                    new ProductType { Id = 4, Name = "75 ml" },
                    new ProductType { Id = 5, Name = "90 ml" },
                    new ProductType { Id = 6, Name = "100 ml" },
                    new ProductType { Id = 7, Name = "150 ml" },
                    new ProductType { Id = 8, Name = "200 ml" }
                );

            modelBuilder.Entity<Category>().HasData(
                    new Category
                    {
                        Id = 1,
                        Name = "Chanel",
                        Url = "chanel"
                    },
                    new Category
                    {
                        Id = 2,
                        Name = "Gucci",
                        Url = "gucci"
                    },
                    new Category
                    {
                        Id = 3,
                        Name = "Dior",
                        Url = "dior"
                    },
                    new Category
                    {
                        Id = 4,
                        Name = "LouisVuitton",
                        Url = "louisvuitton"
                    }
                );

            modelBuilder.Entity<Product>().HasData(
                    new Product
                    {
                        Id = 1,
                        Title = "Bleu de CHANEL",
                        Description = "BLEU DE CHANEL khẳng định bản lĩnh hoàn hảo thông qua một mùi hương bất ngờ và vượt thời gian. Hương thơm hương gỗ tỏa ra thành một đường mòn quyến rũ, thể hiện sự độc lập với sức mạnh và sự sang trọng, giống như người đàn ông mang nó.",
                        ImageUrl = "https://www.chanel.com/images//t_one//w_0.51,h_0.51,c_crop/q_auto:good,f_auto,fl_lossy,dpr_1.2/w_620/bleu-de-chanel-eau-de-parfum-spray-3-4fl-oz--packshot-default-107360-8848377380894.jpg",
                        CategoryId = 1,
                        Concenstration = "Eau De Parfum"
                    },
                    new Product
                    {
                        Id = 2,
                        Title = "Allure Homme Sport",
                        Description = "Một hương thơm tươi mát và phảng phất mùi gỗ ấm. Sự pha trộn của những nốt hương tươi mát, sống động và gợi cảm gợi lên sức hút của một người đàn ông phóng khoáng.",
                        ImageUrl = "https://www.chanel.com/images/t_one//w_0.51,h_0.51,c_crop/q_auto:good,f_auto,fl_lossy,dpr_1.2/w_320//allure-homme-sport-eau-de-toilette-spray-3-4fl-oz--packshot-default-123630-8848376758302.jpg",
                        CategoryId = 1,
                        Concenstration = "Eau De Toilette"
                    },
                    new Product
                    {
                        Id = 3,
                        Title = "Coco",
                        Description = "Một khía cạnh mãnh liệt của tính cách COCO MADEMOISELLE nổi lên để tạo nên một hương thơm quyến rũ sâu sắc, mạnh mẽ mà không thể cưỡng lại theo mọi cách. Thể hiện một người phụ nữ vui tươi và nổi loạn, tự do sáng tạo lại bản thân ngày này qua ngày khác.",
                        ImageUrl = "https://www.chanel.com/images//t_one//w_0.51,h_0.51,c_crop/q_auto:good,f_auto,fl_lossy,dpr_1.2/w_320/coco-mademoiselle-eau-de-parfum-intense-spray-3-4fl-oz--packshot-default-116660-8848376889374.jpg",
                        CategoryId = 1,
                        Concenstration = "Eau De Parfum"
                    },
                    new Product
                    {
                        Id = 4,
                        Title = "Allure Homme",
                        Description = "Sắc nét và sạch sẽ, ấm áp và gợi cảm, ALLURE HOMME là sự thể hiện sức hút và sự quyết tâm bên trong của một người đàn ông. Một thành phần tươi, cay và gỗ thể hiện sự hiện diện của người đàn ông dùng nó.",
                        ImageUrl = "https://www.chanel.com/images//t_one//w_0.51,h_0.51,c_crop/q_auto:good,f_auto,fl_lossy,dpr_1.2/w_320/allure-homme-eau-de-toilette-spray-3-4fl-oz--packshot-default-121460-8848377610270.jpg",
                        CategoryId = 1,
                        Concenstration = "Eau De Toilette"
                    },
                    new Product
                    {
                        Id = 5,
                        Title = "Platinum Égoïste",
                        Description = "Như bức chân dung của một quý ông có tính cách hướng ngoại, cá tính và khiêu khích. Phiên bản Eau de Toilette mang nốt hương xanh fougère-vert. Một mùi hương tràn đầy năng lượng với những nốt hương tươi mát.",
                        ImageUrl = "https://www.chanel.com/images//t_one//w_0.51,h_0.51,c_crop/q_auto:good,f_auto,fl_lossy,dpr_1.2/w_620/platinum-egoiste-eau-de-toilette-spray-1-7fl-oz--packshot-default-124450-8848319512606.jpg",
                        CategoryId = 1,
                        Concenstration = "Eau De Toilette"
                    },
                    new Product
                    {
                        Id = 6,
                        Title = "Allure Homme Édition Blanche",
                        Description = "Hương thơm phương Đông tươi mới. Một sự pha trộn của nóng và lạnh. Đặc tính mùi hương đầy tiên phong, khiêu khích quý ông với thị hiếu khác biệt và những tuyên ngôn táo bạo.",
                        ImageUrl = "https://www.chanel.com/images//t_one//w_0.51,h_0.51,c_crop/q_auto:good,f_auto,fl_lossy,dpr_1.2/w_320/allure-homme-edition-blanche-eau-de-parfum-spray-3-4fl-oz--packshot-default-127460-8848377118750.jpg",
                        CategoryId = 1,
                        Concenstration = "Eau De Parfum"
                    },
                    new Product
                    {
                        Id = 7,
                        Title = "Égoïste",
                        Description = "Độc lập và khó nắm bắt. Hoàn toàn hấp dẫn. Một hương thơm đậm, giàu hương gỗ dành cho người đàn ông có sức mạnh quyến rũ nằm trong tính cách mạnh mẽ của anh ta. Trong một chai nam tính với các đường nét sạch sẽ.",
                        ImageUrl = "https://www.chanel.com/images//t_one//w_0.51,h_0.51,c_crop/q_auto:good,f_auto,fl_lossy,dpr_1.2/w_320/egoiste-eau-de-toilette-spray-3-4fl-oz--packshot-default-114460-8848376823838.jpg",
                        CategoryId = 1,
                        Concenstration = "Eau De Toilette"
                    },
                    new Product
                    {
                        Id = 8,
                        Title = "Pour Monsieur",
                        Description = "Được tạo ra vào năm 1955 với tên gọi Eau de Toilette, POUR MONSIEUR là loại nước hoa dành cho nam giới đầu tiên của Chanel. Một phiên bản mạnh mẽ hơn của bản gốc, Eau de Parfum là một mùi hương Chypre hương gỗ, tươi mát nhưng vẫn giữ được sự sang trọng tinh tế. Một thành phần tinh tế và vượt thời gian.",
                        ImageUrl = "https://www.chanel.com/images//t_one//w_0.55,h_0.55,c_crop/q_auto:good,f_auto,fl_lossy,dpr_1.2/w_320/pour-monsieur-eau-de-parfum-spray-2-5fl-oz--packshot-default-127451-8824192106526.jpg",
                        CategoryId = 1,
                        Concenstration = "Eau De Toilette"
                    },
                    new Product
                    {
                        Id = 9,
                        Title = "Antaeus",
                        Description = "Huyền thoại về một người anh hùng mang tính cách mạnh mẽ và đa cảm được thuật lại qua mùi hương da thuộc mãnh liệt và tinh tế. Hương thơm độc nhất được chứa bên trong thiết kế chai hình vuông màu đen với các cạnh bo tròn. Một biểu tượng cho sự mạnh mẽ và nhạy cảm đầy nam tính.",
                        ImageUrl = "https://www.chanel.com/images//t_one//w_0.51,h_0.51,c_crop/q_auto:good,f_auto,fl_lossy,dpr_1.2/w_320/antaeus-eau-de-toilette-spray-3-4fl-oz--packshot-default-118460-8824198627358.jpg",
                        CategoryId = 1,
                        Concenstration = "Eau De Toilette"
                    },
                    new Product
                    {
                        Id = 10,
                        Title = "No.5",
                        Description = "Kể từ khi được tạo ra vào năm 1921, N°5 đã toát lên bản chất của sự nữ tính. Mùi hương bí ẩn, trừu tượng - sống động với vô số khía cạnh tinh tế - tỏa ra một hương hoa phong phú lộng lẫy. Vào năm 1986, Jacques Polge đã diễn giải lại thành phần của người tiền nhiệm Ernest Beaux để tạo ra một phiên bản đầy đủ hơn, phong phú hơn của hương thơm bây giờ và mãi mãi: Eau de Parfum.",
                        ImageUrl = "https://www.chanel.com/images//t_one//w_0.51,h_0.51,c_crop/q_auto:good,f_auto,fl_lossy,dpr_1.2/w_320/n-5-eau-de-parfum-spray-3-4fl-oz--packshot-default-125530-8848376856606.jpg",
                        CategoryId = 1,
                        Concenstration = "Eau De Parfum"
                    },
                    new Product
                    {
                        Id = 11,
                        Title = "Gucci Mémoire d'une Odeur",
                        Description = "Vượt qua giới tính và thời gian, Gucci Mémoire d'Une Odeur pha trộn giữa Cúc La Mã và Hoa nhài San hô Ấn Độ để thành lập một họ khứu giác mới, Mineral Aromatic",
                        ImageUrl = "https://media.gucci.com/style/DarkGray_Center_0_0_2400x2400/1562765403/589186_99999_0099_001_100_0000_Light-Gucci-Mmoire-dune-Odeur-100ml-Eau-de-Parfum.jpg",
                        CategoryId = 2,
                        Concenstration = "Eau De Parfum"
                    },
                    new Product
                    {
                        Id = 12,
                        Title = "A Midnight Stroll",
                        Description = "A Midnight Stroll của Gucci là một hương thơm Woody dành cho phụ nữ và nam giới. Đây là một hương thơm mới. A Midnight Stroll được ra mắt vào năm 2020. Người đứng sau loại nước hoa này là Alberto Morillas.",
                        ImageUrl = "https://media.gucci.com/style/DarkGray_Center_0_0_490x490/1589363106/624466_99999_0099_001_100_0000_Light-A-Midnight-Stroll-Incense-100ml-eau-de-parfum.jpg",
                        CategoryId = 2,
                        Concenstration = "Eau De Parfum"
                    },
                    new Product
                    {
                        Id = 13,
                        Title = "A Chant for the Nymph",
                        Description = "A Chant for the Nymph' eau de parfum Là biểu tượng của sự bất tử cho thiên đường, mùi bền bỉ mà nó tỏa ra vào những đêm ấm áp, hoa Frangipani - hoa sứ định nghĩa nước hoa và gợi lại câu chuyện về một tiên nữ thần thoại xuất hiện trong một giấc mơ đêm mùa hè bị lãng quên từ lâu. Hương thơm hòa quyện với Ylang Ylang say đắm lòng người, hoa Tiare gợi cảm và Vanilla mềm mại.",
                        ImageUrl = "https://media.gucci.com/style/DarkGray_Center_0_0_490x490/1589363106/624470_99999_0099_001_100_0000_Light-A-Chant-for-the-Nymph-Frangipani-100ml-eau-de-parfum.jpg",
                        CategoryId = 2,
                        Concenstration = "Eau De Parfum"
                    },
                    new Product
                    {
                        Id = 14,
                        Title = "Hortus Sanitatis",
                        Description = "The Alchemist’s Garden. Hortus Sanitatis mang đến vibe sang trọng, cổ điển đậm chất Gucci. Nếu như bạn thấy hương thơm của Gucci Bloom quá quen thuộc thì có thể “đổi gió” với siêu phẩm nước hoa Hortus Sanitatis. Được mệnh danh là bản nhạc mới trong khu vườn của nhà giả kim hứa hẹn sẽ không làm nàng thất vọng.",
                        ImageUrl = "https://media.gucci.com/style/DarkGray_Center_0_0_490x490/1582738204/625029_99999_0099_001_100_0000_Light-Hortus-Sanitatis-Papyrus-and-Cedarwood-100ml-eau-de-parfum.jpg",
                        CategoryId = 2,
                        Concenstration = "Eau De Parfum"
                    },
                    new Product
                    {
                        Id = 15,
                        Title = "A Song for the Rose",
                        Description = "A Song For The Rose Eau de Parfum - Một giai điệu cho những búp hoa hồng: Biểu hiện của sự nữ tính tuyệt đối, chiết xuất từ Hoa hồng Bungari được giữ lại ở dạng tinh khiết nhất, ngay trước khi thu hoạch trên khu vườn.Được pha trộn với Xạ hương ngọt ngào và hương gỗ mạnh mẽ.",
                        ImageUrl = "https://media.gucci.com/style/DarkGray_Center_0_0_800x800/1546620303/548627_99999_0099_001_100_0000_Light-A-Song-for-the-Rose-Rose-100ml-eau-de-parfum.jpg",
                        CategoryId = 2,
                        Concenstration = "Eau De Parfum"
                    },
                    new Product
                    {
                        Id = 16,
                        Title = "Tears of Iris",
                        Description = "Nước mắt của Iris “Nước của Iris” Eau Ee Parfum Unisex và một chai thủy tinh tinh mài mài chỉ có hiệu ứng ứng ứng với sứ, trang trí bằng cách nhấn bằng vàng… hoa Iris tỏa ra một mùi hương gợi cảm, hòa quyện với Gỗ đàn hương, Hạt bạch chỉ và Cây xạ hương… Làm nổi bật hương thơm và chất lượng của nó từ bộ sưu tập tập ra một pha trộn cá nhân hóa… cháu dễ dàng đi sâu vào tiềm thức ,không khó quên lạ.",
                        ImageUrl = "https://media.gucci.com/style/DarkGray_Center_0_0_800x800/1546620303/548625_99999_0099_001_100_0000_Light-Tears-of-Iris-Iris-100ml-eau-de-parfum.jpg",
                        CategoryId = 2,
                        Concenstration = "Eau De Parfum"
                    },
                    new Product
                    {
                        Id = 17,
                        Title = "Fading Autumn",
                        Description = "ading Autumn Scented Water của Gucci là một loại nước hoa có hương gỗ dành cho phụ nữ và nam giới. Fading Autumn Eau de Toilette của Gucci này có hương thơm gỗ unisex. Nó có cây tuyết tùng, dầu cypriol, cây hoắc hương và gỗ đàn hương.",
                        ImageUrl = "https://media.gucci.com/style/DarkGray_Center_0_0_800x800/1546620305/548759_99999_0099_001_100_0000_Light-Fading-Autumn-Woods-150ml-acqua-profumata.jpg",
                        CategoryId = 2,
                        Concenstration = "Parfum"
                    },
                    new Product
                    {
                        Id = 18,
                        Title = "A Kiss from Violet",
                        Description = "A Kiss from Violet là một loại nước hoa của Gucci dành cho phụ nữ và nam giới và được phát hành vào năm 2019 . Mùi hương là hương hoa da thuộc.",
                        ImageUrl = "https://media.gucci.com/style/DarkGray_Center_0_0_800x800/1547226905/548765_99999_0099_001_100_0000_Light-A-Kiss-from-Violet-Violet-20ml-perfumed-oil.jpg",
                        CategoryId = 2,
                        Concenstration = "Parfum"
                    },
                    new Product
                    {
                        Id = 19,
                        Title = "Gucci Guilty Pour Homme",
                        Description = "Một sản phẩm đương đại lấy hai thành phần nước hoa mang tính biểu tượng phổ biến trong những năm 70, hương đầu của Hoa hồng và Hạt tiêu tạo ra một cảm giác cổ điển tràn đầy sinh lực, với chút giấm và muối cho một kết thúc bất ngờ.",
                        ImageUrl = "https://media.gucci.com/style/DarkGray_Center_0_0_2400x2400/1582739103/613748_99999_0099_001_100_0000_Light-Gucci-Guilty-Pour-Homme-90ml-eau-de-parfum.jpg",
                        CategoryId = 2,
                        Concenstration = "Eau De Parfum"
                    },
                    new Product
                    {
                        Id = 20,
                        Title = "Gucci Bloom Profumo di Fiori",
                        Description = "Với thiết kế đầy mạnh mẽ và nam tính, Gucci Guilty Pour Homme đã phần nào toát lên nét đẹp vững chãi, lãng du của mình chỉ qua một cái nhìn. Tông hương đầu của Oải hương cùng Chanh từ tốn mở ra làn gió thoáng mát, sảng khoái cho mùa hè với hương thơm thanh thoát điển hình. Nhanh chóng nhường chỗ cho Hoa cam, Guilty ở tầng hương tiếp theo bộc lộ ngày càng rõ ràng mùi vị nồng nàn đầy lôi cuốn, để rồi kết thúc trong sự hòa quyện của Hoắc hương, Tuyết tùng và Vanilla the mát, ngọt dịu. Phóng đãng, tươi mới đầy tài tình, Gucci Guilty Pour Homme như viên nam châm, thu hút tất cả sự chú ý xung quanh về phía mình.",
                        ImageUrl = "https://media.gucci.com/style/DarkGray_Center_0_0_2400x2400/1611335703/628572_99999_0099_001_100_0000_Light-Gucci-Bloom-Profumo-di-Fiori-100ml-Eau-de-Parfum.jpg",
                        CategoryId = 2,
                        Concenstration = "Eau De Parfum"
                    },
                    new Product
                    {
                        Id = 21,
                        Title = "Sauvage",
                        Description = "Sauvage Elixir là một hương thơm cô đặc đặc biệt * ngập tràn trong sự tươi mát mang tính biểu tượng của Sauvage với trái tim say đắm của Gia vị, tinh chất Oải hương được thiết kế riêng và sự pha trộn của các loại Gỗ phong phú tạo nên dấu ấn đặc trưng của đường mòn mạnh mẽ, xa hoa và quyến rũ.",
                        ImageUrl = "https://eco-beauty.dior.com/dw/image/v2/BDGF_PRD/on/demandware.static/-/Sites-master_dior/default/dw71015f31/assets/Y0998004/Y0998004_C099600455_E01_ZHC.jpg?sw=870&sh=580&sm=fit&imwidth=870",
                        CategoryId = 3,
                        Concenstration = "Parfum"
                    },
                    new Product
                    {
                        Id = 22,
                        Title = "Dior Homme Intense",
                        Description = "Dior Homme được khoác lên mình như cách bạn mặc một bộ vest sang trọng, sắc nét hiện đại. Dior Homme Intense Eau de Parfum thể hiện sự hùng vĩ và tinh tế của một loại eau de parfum hào phóng và mạnh mẽ. Cường độ khứu giác của Iris được tăng cường nhờ mặt màu Hổ phách gợi cảm và lớp nền Gỗ quý. Một kịch bản mùi mẫn, gợi cảm có dấu vết gọi đến bạn.",
                        ImageUrl = "https://eco-beauty.dior.com/dw/image/v2/BDGF_PRD/on/demandware.static/-/Sites-master_dior/default/dw6a1294a4/assets/Y0479201/Y0479201_F047924709_E01_ZHC.jpg?sw=870&sh=580&sm=fit&imwidth=870",
                        CategoryId = 3,
                        Concenstration = "Parfum"
                    },
                    new Product
                    {
                        Id = 23,
                        Title = "Dior Homme Sport",
                        Description = "Tràn đầy năng lượng và thanh lịch, Dior Homme Sport eau de toilette mới kết hợp sự sôi nổi tươi mới và nét quyến rũ pha chút gợi cảm cho một bộ đôi mang phong cách như một võ sĩ quyền anh.",
                        ImageUrl = "https://eco-beauty.dior.com/dw/image/v2/BDGF_PRD/on/demandware.static/-/Sites-master_dior/default/dw64b5efc2/assets/Y0996476/Y0996476_C099600782_E01_ZHC.jpg?sw=870&sh=580&sm=fit&imwidth=870",
                        CategoryId = 3,
                        Concenstration = "Eau De Toilette"
                    },
                    new Product
                    {
                        Id = 24,
                        Title = "Dior Homme",
                        Description = "Dior Homme tái định nghĩa một sự gợi cảm nam tính, mới mẻ trong âm hưởng đa âm của hương gỗ thô và mịn. Một trái tim của gỗ dịu dàng, trong đó sự mạnh mẽ của Atlas Cedar ôm trọn sự ấm áp bao bọc của cỏ Vetiver Haiti nhuốm màu gia vị. Đồ gỗ do Dior đục đẽo bằng tay.",
                        ImageUrl = "https://eco-beauty.dior.com/dw/image/v2/BDGF_PRD/on/demandware.static/-/Sites-master_dior/default/dw2a7995bc/assets/Y0996157/Y0996157_C099600157_E01_ZHC.jpg?sw=870&sh=580&sm=fit&imwidth=870",
                        CategoryId = 3,
                        Concenstration = "Cologne"
                    },
                    new Product
                    {
                        Id = 25,
                        Title = "Dior Homme Original",
                        Description = "Hương thơm của hoa diên vĩ nam tính. Một dấu hiệu khứu giác gợi cảm được nâng cao bởi các nốt hương gỗ virile cho một sự tinh tế khác thường. Dior Homme được khoác lên mình như cách bạn mặc một bộ vest sang trọng, sắc nét hiện đại. Để lại dấu vết khứu giác của mùi hương gỗ, cay nồng đó, dấu hiệu nhận biết ngay lập tức của một phong cách khác biệt.",
                        ImageUrl = "https://eco-beauty.dior.com/dw/image/v2/BDGF_PRD/on/demandware.static/-/Sites-master_dior/default/dw9bcf86fe/assets/Y0469201/Y0469201_F046922009_E01_ZHC.jpg?sw=870&sh=580&sm=fit&imwidth=870",
                        CategoryId = 3,
                        Concenstration = "Eau De Toilette"
                    },
                    new Product
                    {
                        Id = 26,
                        Title = "Fahrenheit",
                        Description = "Một mình đối mặt với những yếu tố hùng vĩ, người đàn ông của Phi Luân Hải đã hóa thân vào một khát khao tuyệt đối. Vượt thời gian và phổ quát, Fahrenheit là một hương thơm vượt qua thời gian và xu hướng để tạo nên lãnh thổ của riêng mình. Một dấu hiệu khứu giác tương phản, độc đáo * với một dấu vết mạnh mẽ kéo dài. Hương thơm được cấu trúc xung quanh những nốt hương tươi mát của Sicilian Mandarin, một sự pha trộn đáng ngạc nhiên giữa hương Gỗ và Da nam tính, và một hương vị * Violet độc đáo.",
                        ImageUrl = "https://eco-beauty.dior.com/dw/image/v2/BDGF_PRD/on/demandware.static/-/Sites-master_dior/default/dw7a79271b/assets/Y0066001/Y0066001_F006624009_E01_ZHC_2.jpg?sw=870&sh=580&sm=fit&imwidth=870",
                        CategoryId = 3,
                        Concenstration = "Parfum"
                    },
                    new Product
                    {
                        Id = 27,
                        Title = "Eau Sauvage",
                        Description = "Eau Sauvage Eau de Toilette không chỉ là một hương thơm. Nó đồng nghĩa với sự sang trọng tuyệt đối, một “tinh thần Dior” bền bỉ hòa quyện với nét hiện đại.Hương vị cam quýt hoa của nó vừa tinh tế vừa mạnh mẽ, tinh tế và tươi mát. Sự cân bằng tinh tế của cam bergamot San Carlo, được thu hoạch dành riêng cho Eau Sauvage, cảm giác rực rỡ của hedione với chất lượng hoa mượt mà độc đáo, và dấu vết chypre đặc biệt.",
                        ImageUrl = "https://eco-beauty.dior.com/dw/image/v2/BDGF_PRD/on/demandware.static/-/Sites-master_dior/default/dw18051da9/assets/Y0097001/Y0097001_F009724109_E01_ZHC.jpg?sw=870&sh=580&sm=fit&imwidth=870",
                        CategoryId = 3,
                        Concenstration = "Parfum"
                    },
                    new Product
                    {
                        Id = 28,
                        Title = "Higher",
                        Description = "Hương thơm gỗ thơm đầy bất ngờ này được tạo ra để dành cho người đàn ông thành thị hiện đại, sống trong khoảnh khắc hiện tại nhưng vẫn thể hiện sự nam tính vĩnh cửu. Mát mẻ và tràn đầy năng lượng, với các nốt hương của lê, cam quýt và húng quế, vị cay nồng và mùi xạ hương.",
                        ImageUrl = "https://eco-beauty.dior.com/dw/image/v2/BDGF_PRD/on/demandware.static/-/Sites-master_dior/default/dwd71e67be/assets/Y0660201/Y0660201_F066024009_E01_ZHC.jpg?sw=870&sh=580&sm=fit&imwidth=870",
                        CategoryId = 3,
                        Concenstration = "Eau De Toilette"
                    },
                    new Product
                    {
                        Id = 29,
                        Title = "J’adore",
                        Description = "Khi bạn nghe J'adore, tất nhiên bạn sẽ nghĩ đến hương thơm cùng tên. Nhưng đừng quên ý nghĩa đầu tiên: đó là tiếng kêu từ trái tim - tiếng kêu của cảm xúc, khi đối mặt với thứ gì đó thu hút tất cả các giác quan của chúng ta, điều đó quyến rũ chúng ta và vận chuyển chúng ta.",
                        ImageUrl = "https://eco-beauty.dior.com/dw/image/v2/BDGF_PRD/on/demandware.static/-/Sites-master_dior/default/dw2f353651/assets/Y0996401/Y0996401_C099700049_E01_ZHC.jpg?sw=870&sh=580&sm=fit&imwidth=870",
                        CategoryId = 3,
                        Concenstration = "Eau De Parfum"
                    },
                    new Product
                    {
                        Id = 30,
                        Title = "Jules",
                        Description = "Một loại nước hoa nam mạnh mẽ bao gồm các nốt hương màu xanh lá cây của gỗ và các điểm nhấn của hạt tiêu cay.",
                        ImageUrl = "https://eco-beauty.dior.com/dw/image/v2/BDGF_PRD/on/demandware.static/-/Sites-master_dior/default/dwf2d52cc8/assets/Y0061201/Y0061201_F006124109_E01_ZHC.jpg?sw=870&sh=580&sm=fit&imwidth=870",
                        CategoryId = 3,
                        Concenstration = "Eau De Toilette"
                    },
                    new Product
                    {
                        Id = 31,
                        Title = "Météore",
                        Description = "Louis Vuitton Météore thuộc chai nước hoa thứ 6 của bộ sưu tập nước hoa xa xỉ Louis Vuitton, đến từ bàn tay của bậc thầy mùi hương Jacques Cavallier Belletrud. Météore. Cái tên đầy cuốn hút với sức mạnh tỏa ra từ ánh sáng, khơi dậy niềm đam mê cho những chuyến đi không bao giờ dứt, giống như những đám mây rực rỡ khiến cho bầu trời bỗng nhiên bốc cháy và làm lóa hết mọi ánh nhìn.",
                        ImageUrl = "https://us.louisvuitton.com/images/is/image/lv/1/PP_VP_L/louis-vuitton-m%C3%A9t%C3%A9ore-fragrances--LP0160_PM2_Front%20view.png?wid=1240&hei=1240",
                        CategoryId = 4,
                        Concenstration = "Eau De Parfum"
                    },
                    new Product
                    {
                        Id = 32,
                        Title = "L’immensité",
                        Description = "Một trong những mẫu nước hoa của Louis Vuitton đang được săn lùng nhiều nhất trên thị trường đó chính là nước hoa L’IMMENSITÉ PERFUME. Mẫu nước hoa này nổi bật với hương thơm sang trọng, vị cay trầm ấm và kiểu dáng nhỏ gọn, cuốn hút.",
                        ImageUrl = "https://us.louisvuitton.com/images/is/image/lv/1/PP_VP_L/louis-vuitton-l-immensit%C3%A9-fragrances--LP0052_PM2_Front%20view.png?wid=1240&hei=1240",
                        CategoryId = 4,
                        Concenstration = "Eau De Parfum"
                    },
                    new Product
                    {
                        Id = 33,
                        Title = "Orage",
                        Description = "Nước hoa Louis Vuitton Orage mang mùi hương thanh lịch, trang nhã, độ toả hương cực xa. Orage Louis Vuitton là sự hoà trộn hoàn hảo của Chanh, Hoa Iris, Patchouli và tinh dầu Vetiver Java gồm 3 hương đầu, giữa và cuối cho một ngày dài năng động với hương thơm suốt ngày dài.",
                        ImageUrl = "https://us.louisvuitton.com/images/is/image/lv/1/PP_VP_L/louis-vuitton-orage-fragrances--LP0051_PM2_Front%20view.png?wid=1240&hei=1240",
                        CategoryId = 4,
                        Concenstration = "Eau De Parfum"
                    },
                    new Product
                    {
                        Id = 34,
                        Title = "Nouveau Monde",
                        Description = "Nước hoa NOUVEAU MONDE thuộc nhóm hương phương Đông nên mang đến phong cách nam tính, mạnh mẽ, phiêu lưu và cực kỳ lôi cuốn. Một chút nồng ấm của trầm hương hòa quyện với sự bay bổng của da thuộc giúp phái mạnh tận hưởng trọn vẹn mùi hương đẳng cấp nhất.",
                        ImageUrl = "https://us.louisvuitton.com/images/is/image/lv/1/PP_VP_L/louis-vuitton-nouveau-monde-fragrances--LP0053_PM2_Front%20view.png?wid=1240&hei=1240",
                        CategoryId = 4,
                        Concenstration = "Eau De Parfum"
                    },
                    new Product
                    {
                        Id = 35,
                        Title = "Sur La Route",
                        Description = "Nước hoa SUR LA ROUTE của Louis Vuitton được sản xuất dành cho những quý ông thành đạt và khao khát về một mùi hương nam tính, sang trọng, đẳng cấp. Bậc thầy mùi hương Jacques luôn tìm tòi, sáng tạo và mang đến một siêu phẩm chứa đựng những điều tuyệt vời nhất.",
                        ImageUrl = "https://us.louisvuitton.com/images/is/image/lv/1/PP_VP_L/louis-vuitton-sur-la-route-fragrances--LP0055_PM2_Front%20view.png?wid=1240&hei=1240",
                        CategoryId = 4,
                        Concenstration = "Eau De Parfum"
                    },
                    new Product
                    {
                        Id = 36,
                        Title = "Au Hasard",
                        Description = "Với phái mạnh, việc chọn cho mình được một mẫu nước hoa đẳng cấp, sang trọng sẽ mang lại một phong thái tự tin, cuốn hút. Hiểu được điều đó, Louis Vuitton đã tung ra thị trường mẫu nước hoa AU HASARD PERFUME chinh phục phái mạnh ngay từ lần đầu trải nghiệm.",
                        ImageUrl = "https://eu.louisvuitton.com/images/is/image/lv/1/PP_VP_L/louis-vuitton-au-hasard-fragrances--LP0054_PM2_Front%20view.png?wid=2048&hei=2048",
                        CategoryId = 4,
                        Concenstration = "Eau De Parfum"
                    },
                    new Product
                    {
                        Id = 37,
                        Title = "Heures D’absence",
                        Description = "Heures D'Absence là dòng sản phẩm dành cho nữ được sáng tác bởi nhà Louis Vuitton, đây là loại nước hoa đánh dấu sự đổi mới và bùng nổ sáng tạo của Louis. Một hương thơm nắm bắt được dòng chảy của thời gian và tôn vinh thiết kế đơn giản, thanh lịch, đã tạo nên sức hút và chỗ đứng nhất định của nhà Louis trong lòng các thượng khách. Một nơi nghỉ ngơi tuyệt đẹp qua những cánh đồng hoa Grasse, đây chính là lời ca tụng của những bông hoa tươi, một hình tượng ngụ ngôn về niềm vui, tình yêu và sự thoát tục.",
                        ImageUrl = "https://eu.louisvuitton.com/images/is/image/lv/1/PP_VP_L/louis-vuitton-heures-d-absence-fragrances--LP0113_PM2_Front%20view.png?wid=2048&hei=2048",
                        CategoryId = 4,
                        Concenstration = "Eau De Parfum"
                    },
                    new Product
                    {
                        Id = 38,
                        Title = "Coeur Battant",
                        Description = "Coeur Battant khuếch đại vẻ đẹp kỳ vĩ của thiên nhiên, cụ thể hơn là cảm giác đắm mình vào hoàng hôn tinh khôi của ngày mới – một khung cảnh khơi dậy sự thức tỉnh thanh bình trong tâm trí, nhưng cũng đong đầy xúc cảm xao xuyến, rộn ràng.",
                        ImageUrl = "https://eu.louisvuitton.com/images/is/image/lv/1/PP_VP_L/louis-vuitton-coeur-battant-fragrances--LP0151_PM2_Front%20view.png?wid=2048&hei=2048",
                        CategoryId = 4,
                        Concenstration = "Eau De Parfum"
                    },
                    new Product
                    {
                        Id = 39,
                        Title = "Ombre Nomade",
                        Description = "Ombre Nomade là một hương thơm tinh khiết, nó mạnh mẽ và tái xác định mùi của thế giới Trung Đông và sự gợi cảm của nó trộn lẫn với nữ tính và nam tính. Mạnh mẽ, nồng nàn và nam tính, trầm hương là một trong những hương liệu thuần khiết đắt đỏ nhất thế giới. Mùi trầm hương mang đến cảm giác ấm áp với hương gỗ thơm nhẹ, mùi khói và vị ngọt quyến rũ.",
                        ImageUrl = "https://eu.louisvuitton.com/images/is/image/lv/1/PP_VP_L/louis-vuitton-ombre-nomade-fragrances--LP0095_PM2_Front%20view.png?wid=2048&hei=2048",
                        CategoryId = 4,
                        Concenstration = "Eau De Parfum"
                    },
                    new Product
                    {
                        Id = 40,
                        Title = "Nuit De Feu",
                        Description = "Mệnh danh là một trong những hương thơm đẳng cấp và cực kỳ ấm áp đến từ nhà Louis Vuitton thông qua dòng hương Gỗ Phương Đông, Louis Vuitton Nuit De Feu chiếm trọn tình yêu của các phái bởi tính chất Unisex đặc biệt cất giữ đằng sau lớp vỏ ngoài cơ bản.",
                        ImageUrl = "https://eu.louisvuitton.com/images/is/image/lv/1/PP_VP_L/louis-vuitton-nuit-de-feu-fragrances--LP0167_PM2_Front%20view.png?wid=2048&hei=2048",
                        CategoryId = 4,
                        Concenstration = "Eau De Parfum"
                    }
                    );

            modelBuilder.Entity<ProductVariant>().HasData(
                    new ProductVariant
                    {
                        ProductId = 1,
                        ProductTypeId = 2,
                        Price = 2030000,
                    },
                    new ProductVariant
                    {
                        ProductId = 1,
                        ProductTypeId = 6,
                        Price = 3100000,
                    },
                    new ProductVariant
                    {
                        ProductId = 1,
                        ProductTypeId = 7,
                        Price = 4900000,
                    },
                    new ProductVariant
                    {
                        ProductId = 2,
                        ProductTypeId = 6,
                        Price = 1940000,
                    },
                    new ProductVariant
                    {
                        ProductId = 3,
                        ProductTypeId = 1,
                        Price = 1800000,
                    },
                    new ProductVariant
                    {
                        ProductId = 3,
                        ProductTypeId = 2,
                        Price = 2600000,
                    },
                    new ProductVariant
                    {
                        ProductId = 3,
                        ProductTypeId = 6,
                        Price = 2100000,
                    },
                    new ProductVariant
                    {
                        ProductId = 3,
                        ProductTypeId = 7,
                        Price = 5500000,
                    },
                    new ProductVariant
                    {
                        ProductId = 4,
                        ProductTypeId = 2,
                        Price = 2700000,
                    },
                    new ProductVariant
                    {
                        ProductId = 4,
                        ProductTypeId = 6,
                        Price = 3400000,
                    },
                    new ProductVariant
                    {
                        ProductId = 5,
                        ProductTypeId = 2,
                        Price = 1900000,
                    },
                    new ProductVariant
                    {
                        ProductId = 5,
                        ProductTypeId = 6,
                        Price = 2940000,
                    },
                    new ProductVariant
                    {
                        ProductId = 6,
                        ProductTypeId = 2,
                        Price = 2400000,
                    },
                    new ProductVariant
                    {
                        ProductId = 6,
                        ProductTypeId = 6,
                        Price = 3105000,
                    },
                    new ProductVariant
                    {
                        ProductId = 7,
                        ProductTypeId = 6,
                        Price = 2580000,
                    },
                    new ProductVariant
                    {
                        ProductId = 8,
                        ProductTypeId = 6,
                        Price = 2790000,
                    },
                    new ProductVariant
                    {
                        ProductId = 9,
                        ProductTypeId = 6,
                        Price = 2580000,
                    },
                    new ProductVariant
                    {
                        ProductId = 10,
                        ProductTypeId = 1,
                        Price = 2080000,
                    },
                    new ProductVariant
                    {
                        ProductId = 10,
                        ProductTypeId = 2,
                        Price = 2600000,
                    },
                    new ProductVariant
                    {
                        ProductId = 10,
                        ProductTypeId = 6,
                        Price = 2700000,
                    },
                    new ProductVariant
                    {
                        ProductId = 10,
                        ProductTypeId = 8,
                        Price = 5200000,
                    },
                    new ProductVariant
                    {
                        ProductId = 11,
                        ProductTypeId = 6,
                        Price = 2400000,
                    },
                    new ProductVariant
                    {
                        ProductId = 12,
                        ProductTypeId = 6,
                        Price = 7400000,
                    },
                    new ProductVariant
                    {
                        ProductId = 13,
                        ProductTypeId = 6,
                        Price = 7400000,
                    },
                    new ProductVariant
                    {
                        ProductId = 14,
                        ProductTypeId = 6,
                        Price = 7400000,
                    },
                    new ProductVariant
                    {
                        ProductId = 15,
                        ProductTypeId = 6,
                        Price = 7400000,
                    },
                    new ProductVariant
                    {
                        ProductId = 16,
                        ProductTypeId = 6,
                        Price = 6800000,
                    },
                    new ProductVariant
                    {
                        ProductId = 17,
                        ProductTypeId = 6,
                        Price = 5600000,
                    },
                    new ProductVariant
                    {
                        ProductId = 18,
                        ProductTypeId = 6,
                        Price = 8400000,
                    },
                    new ProductVariant
                    {
                        ProductId = 19,
                        ProductTypeId = 2,
                        Price = 2800000,
                    },
                    new ProductVariant
                    {
                        ProductId = 19,
                        ProductTypeId = 5,
                        Price = 3400000,
                    },
                    new ProductVariant
                    {
                        ProductId = 20,
                        ProductTypeId = 6,
                        Price = 2600000,
                    },
                    new ProductVariant
                    {
                        ProductId = 21,
                        ProductTypeId = 3,
                        Price = 2990000,
                    },
                    new ProductVariant
                    {
                        ProductId = 21,
                        ProductTypeId = 6,
                        Price = 3200000,
                    },
                    new ProductVariant
                    {
                        ProductId = 22,
                        ProductTypeId = 2,
                        Price = 1990000,
                    },
                    new ProductVariant
                    {
                        ProductId = 22,
                        ProductTypeId = 6,
                        Price = 2600000,
                    },
                    new ProductVariant
                    {
                        ProductId = 22,
                        ProductTypeId = 7,
                        Price = 3600000,
                    },
                    new ProductVariant
                    {
                        ProductId = 23,
                        ProductTypeId = 4,
                        Price = 1700000,
                    },
                    new ProductVariant
                    {
                        ProductId = 23,
                        ProductTypeId = 6,
                        Price = 2500000,
                    },
                    new ProductVariant
                    {
                        ProductId = 24,
                        ProductTypeId = 2,
                        Price = 1900000,
                    },
                    new ProductVariant
                    {
                        ProductId = 24,
                        ProductTypeId = 6,
                        Price = 2600000,
                    },
                    new ProductVariant
                    {
                        ProductId = 24,
                        ProductTypeId = 7,
                        Price = 2990000,
                    },
                    new ProductVariant
                    {
                        ProductId = 25,
                        ProductTypeId = 2,
                        Price = 2100000,
                    },
                    new ProductVariant
                    {
                        ProductId = 25,
                        ProductTypeId = 6,
                        Price = 2280000,
                    },
                    new ProductVariant
                    {
                        ProductId = 26,
                        ProductTypeId = 2,
                        Price = 1880000,
                    },
                    new ProductVariant
                    {
                        ProductId = 26,
                        ProductTypeId = 6,
                        Price = 2880000,
                    },
                    new ProductVariant
                    {
                        ProductId = 27,
                        ProductTypeId = 2,
                        Price = 2000000,
                    },
                    new ProductVariant
                    {
                        ProductId = 27,
                        ProductTypeId = 6,
                        Price = 2500000,
                    },

                    new ProductVariant
                    {
                        ProductId = 28,
                        ProductTypeId = 6,
                        Price = 2280000,
                    },
                    new ProductVariant
                    {
                        ProductId = 29,
                        ProductTypeId = 1,
                        Price = 1500000,
                    },
                    new ProductVariant
                    {
                        ProductId = 29,
                        ProductTypeId = 2,
                        Price = 2100000,
                    },
                    new ProductVariant
                    {
                        ProductId = 29,
                        ProductTypeId = 6,
                        Price = 3360000,
                    },
                    new ProductVariant
                    {
                        ProductId = 30,
                        ProductTypeId = 6,
                        Price = 2100000,
                    },

                    new ProductVariant
                    {
                        ProductId = 31,
                        ProductTypeId = 6,
                        Price = 5300000,
                    },
                    new ProductVariant
                    {
                        ProductId = 31,
                        ProductTypeId = 8,
                        Price = 9800000,
                    },
                    new ProductVariant
                    {
                        ProductId = 32,
                        ProductTypeId = 6,
                        Price = 5300000,
                    },
                    new ProductVariant
                    {
                        ProductId = 32,
                        ProductTypeId = 8,
                        Price = 7500000,
                    },
                    new ProductVariant
                    {
                        ProductId = 33,
                        ProductTypeId = 6,
                        Price = 5300000,
                    },
                    new ProductVariant
                    {
                        ProductId = 33,
                        ProductTypeId = 8,
                        Price = 13800000,
                    },
                    new ProductVariant
                    {
                        ProductId = 34,
                        ProductTypeId = 6,
                        Price = 5300000,
                    },
                    new ProductVariant
                    {
                        ProductId = 34,
                        ProductTypeId = 8,
                        Price = 12000000,
                    },
                    new ProductVariant
                    {
                        ProductId = 35,
                        ProductTypeId = 6,
                        Price = 4500000,
                    },
                    new ProductVariant
                    {
                        ProductId = 35,
                        ProductTypeId = 8,
                        Price = 7990000,
                    },
                    new ProductVariant
                    {
                        ProductId = 36,
                        ProductTypeId = 6,
                        Price = 4300000,
                    },
                    new ProductVariant
                    {
                        ProductId = 36,
                        ProductTypeId = 8,
                        Price = 8800000,
                    },
                    new ProductVariant
                    {
                        ProductId = 37,
                        ProductTypeId = 6,
                        Price = 5300000,
                    },
                    new ProductVariant
                    {
                        ProductId = 37,
                        ProductTypeId = 8,
                        Price = 11500000,
                    },
                    new ProductVariant
                    {
                        ProductId = 38,
                        ProductTypeId = 6,
                        Price = 4800000,
                    },
                    new ProductVariant
                    {
                        ProductId = 38,
                        ProductTypeId = 8,
                        Price = 7500000,
                    },
                    new ProductVariant
                    {
                        ProductId = 39,
                        ProductTypeId = 6,
                        Price = 7200000,
                    },
                    new ProductVariant
                    {
                        ProductId = 39,
                        ProductTypeId = 8,
                        Price = 11500000,
                    },
                    new ProductVariant
                    {
                        ProductId = 40,
                        ProductTypeId = 6,
                        Price = 7200000,
                    },
                    new ProductVariant
                    {
                        ProductId = 40,
                        ProductTypeId = 8,
                        Price = 1200000,
                    }
            );
        }

        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<ProductType> ProductTypes { get; set; }
        public DbSet<ProductVariant> ProductVariants { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<CartItem> CartItems { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderItem> OrderItems { get; set; }
        public DbSet<Address> Addresses { get; set; }
        public DbSet<Image> Images { get; set; }
    }
}

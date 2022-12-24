-- STATUS_ACC
insert into status_acc values (1,"Bình thường");
insert into status_acc values (2,"Tạm khóa");
insert into status_acc values (3,"Khóa vĩnh viễn");

-- ROLE_ADMIN
insert into role_admin values (1,"root");
insert into role_admin values (2,"member");

-- ACCOUNT_ADMIN
insert into account_admin (username,id_role_admin,id_status_acc,passwordAD,fullname) values ("tranminhtuyen",1,1,"20130459","Trần Minh Tuyên");
insert into account_admin (username,id_role_admin,id_status_acc,passwordAD,fullname) values ("nguyenphutai",2,1,"123456","Nguyễn Phú Tài");
insert into account_admin (username,id_role_admin,id_status_acc,passwordAD,fullname) values ("nguyenthuylinh",2,1,"123456","Nguyễn Thùy Linh");
insert into account_admin (username,id_role_admin,id_status_acc,passwordAD,fullname) values ("nguyenvanlenh",2,1,"123456","Nguyễn Văn Lênh");
insert into account_admin (username,id_role_admin,id_status_acc,passwordAD,fullname) values ("dangthevu",2,1,"123456","Đặng Thế Vũ");

-- TYPE_PRODUCT
INSERT INTO type_product(id_type_product,name_type_product) VALUES (0,"-- Chọn loại sản phẩm --");
INSERT INTO type_product(name_type_product) VALUES ("ACID");
INSERT INTO type_product(name_type_product) VALUES ("BAZO");
INSERT INTO type_product(name_type_product) VALUES ("DUNG MÔI");
INSERT INTO type_product(name_type_product) VALUES ("ESTE");
INSERT INTO type_product(name_type_product) VALUES ("HÓA CHẤT CƠ BẢN");
INSERT INTO type_product(name_type_product) VALUES ("HÓA CHẤT TẠP CHỨC, POLIME");
INSERT INTO type_product(name_type_product) VALUES ("KIM LOẠI");
INSERT INTO type_product(name_type_product) VALUES ("MUỐI");
INSERT INTO type_product(name_type_product) VALUES ("OXIT");
INSERT INTO type_product(name_type_product) VALUES ("THUỐC THỬ");
INSERT INTO type_product(name_type_product) VALUES ("BÌNH THÍ NGHIỆM");
INSERT INTO type_product(name_type_product) VALUES ("BỘ CHÀY CỐI");
INSERT INTO type_product(name_type_product) VALUES ("BỘ LỌC HÚT CHÂN KHÔNG");
INSERT INTO type_product(name_type_product) VALUES ("CỐC CHÉN ĐĨA CHO LAB");
INSERT INTO type_product(name_type_product) VALUES ("ĐÈN CỒN");
INSERT INTO type_product(name_type_product) VALUES ("ĐO NHIỆT ĐỘ,TỶ TRỌNG,ÁP SUẤT");
INSERT INTO type_product(name_type_product) VALUES ("GIẤY LỌC,MÀNG LỌC");
INSERT INTO type_product(name_type_product) VALUES ("ỐNG ĐONG");
INSERT INTO type_product(name_type_product) VALUES ("ỐNG NGHIỆM");
INSERT INTO type_product(name_type_product) VALUES ("PHỄU");
INSERT INTO type_product(name_type_product) VALUES ("CÂN PHÒNG THÍ NGHIỆM");
INSERT INTO type_product(name_type_product) VALUES ("KÍNH HIỂN VI");
INSERT INTO type_product(name_type_product) VALUES ("LÒ NUNG");
INSERT INTO type_product(name_type_product) VALUES ("MÁY CẤT NƯỚC");
INSERT INTO type_product(name_type_product) VALUES ("MÁY ĐO CÁC CHỈ TIÊU TRONG DUNG DỊCH");
INSERT INTO type_product(name_type_product) VALUES ("MÁY LẮC");
INSERT INTO type_product(name_type_product) VALUES ("MÁY LY TÂM");
INSERT INTO type_product(name_type_product) VALUES ("NỒI HẤP TIỆT TRÙNG");
INSERT INTO type_product(name_type_product) VALUES ("TỦ ẤM");
INSERT INTO type_product(name_type_product) VALUES ("TỦ BẢO QUẢN MẪU VÀ TỦ LẠNH");

-- SUPPLIERS
INSERT INTO `suppliers` (`id_supplier`, `name_supplier`) VALUES
	(0,'-- Chọn nhà cung cấp --'),
	(1, 'Cty hóa chất Đức Việt'),
	(2, 'Cty TNHH một thành viên Thái Hòa'),
	(3, 'Cty hóa chất Hóa Việt');

-- STATUS_PRODUCT
INSERT INTO status_product VALUES (0,'-- Chọn trạng thái sản phẩm --');
INSERT INTO status_product VALUES (1, 'Mới');
INSERT INTO status_product VALUES (2, 'Hết hàng');
INSERT INTO status_product VALUES (3, 'Còn hàng');
INSERT INTO status_product VALUES (4, 'Cấm bán');

-- ----------------------------
-- Records of products
-- ----------------------------
INSERT INTO `products` VALUES (1, 1, 1, 1, 'Axit sunfuric loãng', 'Axit sunfuric - H2SO4 là một axit vô cơ mạnh, hóa chất này có đầy đủ các tính chất hóa học chung của một axit.', '/DATA/Images/axit-sunfuric.jpg', 45, '2022-12-23 08:59:24', 4, 'nguyenphutai');
INSERT INTO `products` VALUES (2, 1, 1, 3, 'Acid Acetic 97 - 99%', 'Acetic acid hay còn gọi là Hydro axetat, Ethylic acid, Axit metanecarboxylic, Dấm là hợp chất hữu cơ lỏng không màu, mùi gắt, vị chua. Axit axetic hoàn toàn tan trong nước, cồn, eter, benzen, axeton và trong cloroform, hoàn toàn không tan trong CS2, chất dễ cháy, và ở nhiệt độ ấm hơn 39 °C. Axit axetic được coi là một hợp chất hữu cơ dễ bay hơi của các chất ô nhiễm. CTHH: CH3COOH, CAS: 64-19-7, hàm lượng: 99%', '/DATA/Images/acetic-acid.jpg', 1000, '2022-12-23 09:02:21', 4, 'nguyenphutai');
INSERT INTO `products` VALUES (5, 1, 1, 1, 'Axit sunfuric loãng', 'Axit sunfuric - H2SO4 là một axit vô cơ mạnh, hóa chất này có đầy đủ các tính chất hóa học chung của một axit.', '/DATA/Images/axit-sunfuric.jpg', 45, '2022-12-01 14:34:15', 4, 'Lenh');
INSERT INTO `products` VALUES (6, 1, 1, 2, 'Acid Acetic 97 - 99%', 'Acetic acid hay còn gọi là Hydro axetat, Ethylic acid, Axit metanecarboxylic, Dấm là hợp chất hữu cơ lỏng không màu, mùi gắt, vị chua. Axit axetic hoàn toàn tan trong nước, cồn, eter, benzen, axeton và trong cloroform, hoàn toàn không tan trong CS2, chất dễ cháy, và ở nhiệt độ ấm hơn 39 °C. Axit axetic được coi là một hợp chất hữu cơ dễ bay hơi của các chất ô nhiễm. CTHH: CH3COOH, CAS: 64-19-7, hàm lượng: 99%', '/DATA/Images/acetic-acid.jpg', 30, '2022-12-01 14:39:23', 4, 'Lenh');
INSERT INTO `products` VALUES (7, 19, 1, 2, 'Ống nghiệm 100ml', 'Ống nghiệm thủy tinh 100ml, dùng cho block gia nhiệt QUICKFIT . Code:TT100/26 (Scilabware - Anh). Phù hợp sử dụng với máy sưởi.', '/DATA/Images/ong-nghiem-2.jpg', 10, '2022-12-06 13:43:09', 4, 'Lenh');
INSERT INTO `products` VALUES (8, 17, 1, 1, 'Màng lọc định tính', 'Giấy lọc định tính chảy trung đường kính 240mm, xuất xứ: Onelab-Trung Quốc. Sản phẩm được sử dụng rộng rãi trong phòng thí nghiệm và thường được dùng để lọc dung môi, hoá chất, hợp chất và giữ lại cặn ở mặt trên giấy. Quy cách đóng gói: 100 tờ/hộp.', '/DATA/Images/giay-loc-dinh-tinh-1.png', 14, '2022-12-06 13:56:13', 5, 'Lenh');
INSERT INTO `products` VALUES (9, 17, 1, 3, 'Giấy lọc định lượng', 'Giấy lọc định lượng 44, chậm 3um, 185mm. Code 1444-185 (Whatman - Anh). Chất liệu: Cellulose, hình tròn, bề mặt mịn. Là phiên bản mỏng của loại 42, tốc độ lọc bằng 1 nửa so với loại 42. Khả năng giữ hạt mịn cao, lọc các chất rắn và các chất kết tủa. Quy cách đóng gói: 100 cái/hộp', '/DATA/Images/giay-loc-dinh-luong-1.png', 17, '2022-12-06 13:56:35', 3, 'Lenh');
INSERT INTO `products` VALUES (10, 22, 1, 1, 'Kính hiển vi điện tử', 'Kính hiển vi được sử dụng như con mắt thứ hai để quan sát các vật thể có kích thước rất nhỏ trong không gian mà mắt thường của con người không thể quan sát được. Thiết bị này có thể phóng đại những vật có kích thước cực kỳ nhỏ bé trở nên chi tiết và rõ ràng hơn (độ phóng đại lên từ 40 - 3000 lần). Khả năng quan sát của kính được quyết định bởi độ phân giải.', '/DATA/Images/kinh-huynh-quang-1.jpg', 5, '2022-12-06 14:01:28', 5, 'Tuyen');
INSERT INTO `products` VALUES (11, 22, 1, 2, 'Kính hiển vi sinh học', 'Kính hiển vi sinh học 1 mắt B-155R (tích hợp pin sạc) xuất xứ Optika – Ý. Là kính hiển vi 1 mắt, 400X, mâm kính 2 lớp, tích hợp pin sạc, dễ sử dụng với độ bền cao và chất lượng hình ảnh ổn định. Sản phẩm dùng trong khoa học đời sống giáo dục, Y tế cũng như nhiều ứng dụng nghiên cứu sinh học,...', '/DATA/Images/kinh-hien-vi-sinh-hoc-1.jpg', 7, '2022-12-06 14:03:01', 4, 'Tai');
INSERT INTO `products` VALUES (12, 23, 1, 3, 'Lò nung dưới 1000 độ C', 'Lò nung dưới 1000 độ. Model: SX- 4-10 (Trung Quốc). Là một thiết bị dùng để gia nhiệt đến nhiệt độ rất cao (trên dưới 1000 °C), nhiệt được đảm bảo đồng đều khắp lò nung. Được dùng trong phòng thí nghiệm, viện nghiên cứu, ứng dụng chủ yếu trong lĩnh vực hóa học và thử nghiệm vật liệu, phân tích mẫu,….', '/DATA/Images/lo-nung-duoi-1000-1.jpg', 15, '2022-12-06 14:05:41', 4, 'Linh');
INSERT INTO `products` VALUES (13, 23, 0, 1, 'Lò nung trên 1000 độ C', 'Nhiệt độ lò trên 1000 độ C; Tích hợp bộ điều khiển Jog-Shuttle và màn hình LCD với chức năng Back-Light. Chức năng tự bù nhiệt cho người dùng và công tắc an toàn khi mở cửa.', '/DATA/Images/lo-nung-tren-1000-1.jpg', 0, '2022-12-06 14:07:25', 5, 'Vu');
INSERT INTO `products` VALUES (14, 24, 1, 3, 'Máy cắt nước', 'Máy nước cất 1 lần của GFL - Đức với thiết kế nhỏ gọn, đẹp mắt, thanh đốt được làm bằng thép không gỉ độ bền cao, cho phép cất nước tự động với tốc độ cao 4 lít/giờ đáp ứng mọi nhu cầu sử dụng nước sạch cho các phòng thí nghiệm, viện nghiên cứu,...', '/DATA/Images/may-cat-nuoc-1.jpg', 7, '2022-12-06 14:09:23', 3, 'Tuyen');
INSERT INTO `products` VALUES (16, 1, 1, 2, 'Dung dịch đệm', 'Dung dịch đệm là một dạng dung dịch lỏng chứa trong đó một hỗn hợp bao gồm axit yếu và bazơ liên hợp của nó hoặc một bazơ yếu và axit liên hợp. Hỗn hợp đệm có một tính chất rất đặc biệt đó là nếu thêm vào hỗn hợp 1 axit hoặc bazo thì dung dịch mới có độ pH thay đổi rất ít so với ban đầu. Hợp chất đệm được dùng để làm ổn định độ pH trong các thí nghiệm và trong tự nhiên.', '/DATA/Images/dung-dich-dem-1.png', 20, '2022-12-06 14:12:44', 4, 'Tai');
INSERT INTO `products` VALUES (17, 10, 1, 3, 'Thuốc Thử Nguyên Chất', 'Thuốc thử nguyên chất Calsio Delatiumn 120-26P 15% được sản xuất theo tiêu chuẩn quốc tế IAEA đảm báo chất lượng 100%', '/DATA/Images/thuoc-thu-2.jpg', 10, '2022-12-08 14:58:00', 5, 'Lenh');
INSERT INTO `products` VALUES (18, 11, 1, 3, 'Bình đong chia vạch 1500ml Simax', 'Bình đong chia vạch 1500ml Simax. Code: 2030100012823. Bình đong chia vạch 1500ml Simax với thang chia vạch dễ đọc, ca có mỏ giúp dễ dàng cho việc rót ra, được làm từ loại thủy tinh có khả năng chịu nhiệt và kháng hóa chất cao, được dùng để đong, đo chất lỏng,...Quy cách: 4 cái/hộp', '/DATA/Images/binh-dong-chia-vach-simax1.jpg', 4, '2022-12-14 15:08:31', 4, 'Lenh');
INSERT INTO `products` VALUES (20, 19, 1, 1, 'Cuvette semi (100 PCS) 2.5ml tóp đáy nhựa PS, tròn bên trong Kartel.', 'Cuvette semi (100 PCS) 2.5ml tóp đáy nhựa PS, tròn bên trong Kartel. Chất liệu: PS. Đặc điểm: đạt độ trong suốt, không lẫn tạp chất. Tương thích với hầu các loại máy sinh hóa bán tự động', '/DATA/Images/kartell-labware-cuvette-for-olli.jpg', 7, '2022-12-14 15:12:29', 4, 'Lenh');
INSERT INTO `products` VALUES (22, 2, 1, 2, 'Thioglycolat-broth', 'Thioglycollate broth là canh trường làm giàu được sử dụng phổ biến nhất trong chẩn đoán vi sinh. Môi trường này hỗ trợ sinh trưởng vi khuẩn kỵ khí, hiếu khí, vi sinh vật ưa nước và sinh vật khó cấy. Nó chứa nhiều nhân tố dinh dưỡng bao gồm: casein, chiết thịt bò, nấm men và các vitamin để tăng cường sự sinh trưởng của hầu hết các loài vi khuẩn quan trọng trong y tế. Các chất dinh dưỡng khác được bổ sung bao gồm chỉ thị ô xi hóa khử (resazurin), dextrose, vitamin K1, và hemin.', '/DATA/Images/thioglycolat-broth.jpg', 38, '2022-12-14 15:18:53', 5, 'Lenh');
INSERT INTO `products` VALUES (23, 3, 1, 2, 'Chất chỉ thị ', 'Chất chỉ thị màu là những chất dùng để xác định sự có mặt của một chất nhất định, một loại vi sinh.\r\n\r\nChất chỉ thị màu là những axit hữu cơ yếu hay bazo hữu cơ yếu, có khả năng điện ly thuận nghịch (HA); A- và HA có màu khác nhau.', '/DATA/Images/chi-thi-1.jpg', 5, '2022-12-14 17:12:25', 4, 'bhh');

-- ----------------------------
-- Records of price_product
-- ----------------------------
INSERT INTO `price_product` VALUES (1, '2022-12-23 08:59:24', 980000, 700000, 'nguyenphutai');
INSERT INTO `price_product` VALUES (2, '2022-12-23 09:02:21', 990000, 700000, 'nguyenphutai');
INSERT INTO `price_product` VALUES (5, '2022-12-05 15:46:09', 1100000, 1100000, 'Tuyen');
INSERT INTO `price_product` VALUES (6, '2022-12-04 17:00:00', 1000000, 900000, 'Lenh');
INSERT INTO `price_product` VALUES (7, '2022-12-06 14:38:14', 300000, 300000, 'Lenh');
INSERT INTO `price_product` VALUES (8, '2022-12-06 14:37:15', 500000, 430000, 'Lenh');
INSERT INTO `price_product` VALUES (9, '2022-12-06 14:30:56', 300000, 210000, 'Linh');
INSERT INTO `price_product` VALUES (10, '2022-12-06 14:31:54', 16000000, 15900000, 'Lenh');
INSERT INTO `price_product` VALUES (11, '2022-12-06 14:31:28', 10000000, 9800000, 'Vu');
INSERT INTO `price_product` VALUES (12, '2022-12-06 14:36:17', 7800000, 7800000, 'Lenh');
INSERT INTO `price_product` VALUES (13, '2022-12-06 14:36:39', 11000000, 10900000, 'Lenh');
INSERT INTO `price_product` VALUES (14, '2022-12-06 14:37:43', 5500000, 5700000, 'Lenh');
INSERT INTO `price_product` VALUES (16, '2022-12-06 14:30:15', 290000, 290000, 'Tai');
INSERT INTO `price_product` VALUES (17, '2022-12-14 15:00:32', 900000, 600000, 'Lenh');
INSERT INTO `price_product` VALUES (18, '2022-12-14 15:10:06', 1000000, 730000, 'Lenh');
INSERT INTO `price_product` VALUES (20, '2022-12-14 15:12:38', 250000, 250000, 'Lenh');
INSERT INTO `price_product` VALUES (22, '2022-12-14 15:19:51', 200000, 200000, 'Lenh');
INSERT INTO `price_product` VALUES (23, '2022-12-14 17:12:25', 300000, 300000, 'bhh');

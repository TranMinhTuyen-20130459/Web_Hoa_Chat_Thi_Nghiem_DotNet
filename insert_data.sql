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
	(1, 'Cty hóa chất Đức Việt'),
	(2, 'Cty TNHH một thành viên Thái Hòa'),
	(3, 'Cty hóa chất Hóa Việt');

-- STATUS_PRODUCT
INSERT INTO status_product VALUES (1, 'Mới');
INSERT INTO status_product VALUES (2, 'Hết hàng');
INSERT INTO status_product VALUES (3, 'Còn hàng');
INSERT INTO status_product VALUES (4, 'Cấm bán');

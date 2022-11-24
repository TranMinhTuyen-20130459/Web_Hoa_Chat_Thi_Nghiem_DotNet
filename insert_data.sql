
-- STATUS_ACC
insert into status_acc values (1,"Bình thường");
insert into status_acc values (2,"Tạm khóa");
insert into status_acc values (3,"Khóa vĩnh viễn");

-- ROLE_ADMIN
insert into role_admin values (1,"root");
insert into role_admin values (2,"member");

-- ACCOUNT_ADMIN
insert into account_admin (username,id_role_admin,id_status_acc,passwordAD) values ("tuyen",1,1,"20130459");
insert into account_admin (username,id_role_admin,id_status_acc,passwordAD) values ("tai",2,1,"20130390");
insert into account_admin (username,id_role_admin,id_status_acc,passwordAD) values ("dat",2,1,"20130221");

-- UPDATE TABLE ACCOUNT_ADMIN
UPDATE account_admin
SET fullname = "Trần Minh Tuyên"
where username ="tuyen";


UPDATE account_admin
SET fullname = "Nguyễn Phú Tài"
where username ="tai";


UPDATE account_admin
SET fullname = "Nguyễn Tấn Đạt"
where username ="dat";






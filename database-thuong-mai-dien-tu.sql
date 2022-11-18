CREATE TABLE `account_admin`  (
  `username` varchar(50) CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci NOT NULL,
  `id_role_admin` int NOT NULL,
  `id_status_acc` int NOT NULL,
  `passwordAD` varchar(50) CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci NOT NULL,
  `time_created` timestamp NOT NULL DEFAULT current_timestamp,
  `time_change_pass` timestamp NOT NULL DEFAULT current_timestamp,
  PRIMARY KEY (`username`) USING BTREE,
  INDEX `id_status_acc`(`id_status_acc` ASC) USING BTREE,
  INDEX `id_role_admin`(`id_role_admin` ASC) USING BTREE
) ENGINE = InnoDB CHARACTER SET = utf8mb4 COLLATE = utf8mb4_general_ci ROW_FORMAT = DYNAMIC;

CREATE TABLE `account_customer`  (
  `id_user_customer` int NOT NULL AUTO_INCREMENT,
  `username` varchar(50) CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci NOT NULL,
  `pass` varchar(50) CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci NOT NULL,
  `id_status_acc` int NOT NULL,
  `id_city` int NOT NULL,
  `fullname` varchar(255) CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci NULL DEFAULT NULL,
  `sex` varchar(50) CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci NULL DEFAULT NULL,
  `email_customer` varchar(50) CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci NULL DEFAULT NULL,
  `phone_customer` varchar(15) CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci NULL DEFAULT NULL,
  `address` varchar(255) CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci NULL DEFAULT NULL,
  `time_created` timestamp NOT NULL DEFAULT current_timestamp,
  `time_change_pass` timestamp NOT NULL DEFAULT current_timestamp,
  PRIMARY KEY (`id_user_customer`) USING BTREE,
  INDEX `id_status_acc`(`id_status_acc` ASC) USING BTREE,
  INDEX `id_city`(`id_city` ASC) USING BTREE,
  UNIQUE INDEX `username`(`username` ASC) USING BTREE
) ENGINE = InnoDB AUTO_INCREMENT = 1 CHARACTER SET = utf8mb4 COLLATE = utf8mb4_general_ci ROW_FORMAT = Dynamic;

CREATE TABLE `bill_detail`  (
  `id_bill` int NOT NULL,
  `id_product` int NOT NULL,
  `quantity` int NOT NULL,
  `listed_price` bigint NOT NULL,
  `current_price` bigint NOT NULL,
  PRIMARY KEY (`id_bill`, `id_product`) USING BTREE,
  INDEX `id_product`(`id_product` ASC) USING BTREE
) ENGINE = InnoDB CHARACTER SET = utf8mb4 COLLATE = utf8mb4_unicode_ci ROW_FORMAT = DYNAMIC;

CREATE TABLE `bills`  (
  `id_bill` int NOT NULL AUTO_INCREMENT,
  `id_user` int NOT NULL,
  `id_status_bill` int NOT NULL,
  `id_city` int NOT NULL,
  `fullname_customer` varchar(100) CHARACTER SET utf8mb4 COLLATE utf8mb4_unicode_ci NOT NULL,
  `phone_customer` varchar(20) CHARACTER SET utf8mb4 COLLATE utf8mb4_unicode_ci NOT NULL,
  `email_customer` varchar(50) CHARACTER SET utf8mb4 COLLATE utf8mb4_unicode_ci NOT NULL,
  `address_customer` varchar(255) CHARACTER SET utf8mb4 COLLATE utf8mb4_unicode_ci NOT NULL,
  `bill_price` bigint NOT NULL,
  `total_price` bigint NOT NULL,
  `time_order` timestamp NOT NULL DEFAULT current_timestamp,
  PRIMARY KEY (`id_bill`) USING BTREE,
  INDEX `id_user`(`id_user` ASC) USING BTREE,
  INDEX `id_status_bill`(`id_status_bill` ASC) USING BTREE,
  INDEX `id_city`(`id_city` ASC) USING BTREE
) ENGINE = InnoDB AUTO_INCREMENT = 1 CHARACTER SET = utf8mb4 COLLATE = utf8mb4_unicode_ci ROW_FORMAT = DYNAMIC;

CREATE TABLE `city`  (
  `id_city` int NOT NULL AUTO_INCREMENT,
  `name_city` varchar(100) CHARACTER SET utf8mb4 COLLATE utf8mb4_unicode_ci NOT NULL,
  `transport` bigint NOT NULL,
  PRIMARY KEY (`id_city`) USING BTREE
) ENGINE = InnoDB AUTO_INCREMENT = 1 CHARACTER SET = utf8mb4 COLLATE = utf8mb4_unicode_ci ROW_FORMAT = DYNAMIC;

CREATE TABLE `comment_news`  (
  `id_comment` int NOT NULL AUTO_INCREMENT,
  `id_news` int NOT NULL,
  `id_user_customer` int NOT NULL,
  `time_comment` timestamp NOT NULL DEFAULT current_timestamp,
  `content_comment` text CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci NOT NULL,
  PRIMARY KEY (`id_comment`) USING BTREE,
  INDEX `id_news`(`id_news` ASC) USING BTREE,
  INDEX `id_user_customer`(`id_user_customer` ASC) USING BTREE
) ENGINE = InnoDB AUTO_INCREMENT = 1 CHARACTER SET = utf8mb4 COLLATE = utf8mb4_general_ci ROW_FORMAT = DYNAMIC;

CREATE TABLE `contact`  (
  `id_contact` int NOT NULL AUTO_INCREMENT,
  `full_name` varchar(50) CHARACTER SET utf8mb4 COLLATE utf8mb4_unicode_ci NOT NULL,
  `phone_contact` varchar(50) CHARACTER SET utf8mb4 COLLATE utf8mb4_unicode_ci NOT NULL,
  `email_contact` varchar(50) CHARACTER SET utf8mb4 COLLATE utf8mb4_unicode_ci NOT NULL,
  `problem_name` varchar(255) CHARACTER SET utf8mb4 COLLATE utf8mb4_unicode_ci NOT NULL,
  `content_problem` text CHARACTER SET utf8mb4 COLLATE utf8mb4_unicode_ci NOT NULL,
  `time_insert` timestamp NOT NULL DEFAULT current_timestamp,
  PRIMARY KEY (`id_contact`) USING BTREE
) ENGINE = InnoDB AUTO_INCREMENT = 1 CHARACTER SET = utf8mb4 COLLATE = utf8mb4_unicode_ci ROW_FORMAT = DYNAMIC;

CREATE TABLE `infor_web`  (
  `id_infor` int NOT NULL AUTO_INCREMENT,
  `phone_web` varchar(50) CHARACTER SET utf8mb4 COLLATE utf8mb4_unicode_ci NOT NULL,
  `email_web` varchar(100) CHARACTER SET utf8mb4 COLLATE utf8mb4_unicode_ci NOT NULL,
  `address_web` varchar(100) CHARACTER SET utf8mb4 COLLATE utf8mb4_unicode_ci NOT NULL,
  PRIMARY KEY (`id_infor`) USING BTREE
) ENGINE = InnoDB AUTO_INCREMENT = 1 CHARACTER SET = utf8mb4 COLLATE = utf8mb4_unicode_ci ROW_FORMAT = DYNAMIC;

CREATE TABLE `news`  (
  `id_news` int NOT NULL AUTO_INCREMENT,
  `title_news` text CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci NOT NULL,
  `content_news` text CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci NOT NULL,
  `url_img_news` text CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci NULL,
  `date_posted` timestamp NOT NULL DEFAULT current_timestamp ON UPDATE CURRENT_TIMESTAMP,
  `quantity_comment` int NOT NULL,
  PRIMARY KEY (`id_news`) USING BTREE
) ENGINE = InnoDB AUTO_INCREMENT = 1 CHARACTER SET = utf8mb4 COLLATE = utf8mb4_general_ci ROW_FORMAT = DYNAMIC;

CREATE TABLE `price_product`  (
  `id_product` int NOT NULL,
  `date` date NOT NULL,
  `listed_price` bigint NOT NULL,
  `current_price` bigint NOT NULL,
  PRIMARY KEY (`id_product`, `date`) USING BTREE
) ENGINE = InnoDB CHARACTER SET = utf8mb4 COLLATE = utf8mb4_general_ci ROW_FORMAT = DYNAMIC;

CREATE TABLE `products`  (
  `id_product` int NOT NULL AUTO_INCREMENT,
  `id_type_product` int NOT NULL,
  `id_status_product` int NOT NULL,
  `id_supplier` int NOT NULL,
  `name_product` varchar(255) CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci NOT NULL,
  `description_product` text CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci NULL,
  `url_img_product` text CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci NULL,
  `quantity_product` int NOT NULL,
  `country` varchar(255) CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci NULL DEFAULT NULL,
  `date_inserted` timestamp NOT NULL DEFAULT current_timestamp,
  `star_review` tinyint NULL DEFAULT NULL,
  PRIMARY KEY (`id_product`) USING BTREE,
  INDEX `id_type_product`(`id_type_product` ASC) USING BTREE,
  INDEX `id_status_product`(`id_status_product` ASC) USING BTREE,
  INDEX `id_supplier`(`id_supplier` ASC) USING BTREE
) ENGINE = InnoDB AUTO_INCREMENT = 1 CHARACTER SET = utf8mb4 COLLATE = utf8mb4_general_ci ROW_FORMAT = DYNAMIC;

CREATE TABLE `role_admin`  (
  `id_role_admin` int NOT NULL,
  `name_role` varchar(50) CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci NOT NULL,
  PRIMARY KEY (`id_role_admin`) USING BTREE
) ENGINE = InnoDB CHARACTER SET = utf8mb4 COLLATE = utf8mb4_general_ci ROW_FORMAT = DYNAMIC;

CREATE TABLE `sold_product`  (
  `id_product` int NOT NULL,
  `datetime` date NOT NULL DEFAULT current_timestamp,
  `quantity_sold` int NOT NULL,
  PRIMARY KEY (`id_product`, `datetime`) USING BTREE
) ENGINE = InnoDB CHARACTER SET = utf8mb4 COLLATE = utf8mb4_general_ci ROW_FORMAT = DYNAMIC;

CREATE TABLE `status_acc`  (
  `id_status_acc` int NOT NULL,
  `name_status_acc` varchar(50) CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci NULL DEFAULT NULL,
  PRIMARY KEY (`id_status_acc`) USING BTREE
) ENGINE = InnoDB CHARACTER SET = utf8mb4 COLLATE = utf8mb4_general_ci ROW_FORMAT = DYNAMIC;

CREATE TABLE `status_bill`  (
  `id_status_bill` int NOT NULL,
  `name_status_bill` varchar(50) CHARACTER SET utf8mb4 COLLATE utf8mb4_unicode_ci NOT NULL,
  PRIMARY KEY (`id_status_bill`) USING BTREE
) ENGINE = InnoDB CHARACTER SET = utf8mb4 COLLATE = utf8mb4_unicode_ci ROW_FORMAT = DYNAMIC;

CREATE TABLE `status_product`  (
  `id_status_product` int NOT NULL,
  `name_status_product` varchar(50) CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci NOT NULL,
  PRIMARY KEY (`id_status_product`) USING BTREE
) ENGINE = InnoDB CHARACTER SET = utf8mb4 COLLATE = utf8mb4_general_ci ROW_FORMAT = DYNAMIC;

CREATE TABLE `suppliers`  (
  `id_supplier` int NOT NULL AUTO_INCREMENT,
  `name_supplier` varchar(255) CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci NOT NULL,
  PRIMARY KEY (`id_supplier`) USING BTREE
) ENGINE = InnoDB AUTO_INCREMENT = 1 CHARACTER SET = utf8mb4 COLLATE = utf8mb4_general_ci ROW_FORMAT = DYNAMIC;

CREATE TABLE `type_product`  (
  `id_type_product` int NOT NULL AUTO_INCREMENT,
  `name_type_product` varchar(255) CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci NOT NULL,
  PRIMARY KEY (`id_type_product`) USING BTREE
) ENGINE = InnoDB AUTO_INCREMENT = 1 CHARACTER SET = utf8mb4 COLLATE = utf8mb4_general_ci ROW_FORMAT = DYNAMIC;

ALTER TABLE `account_admin` ADD CONSTRAINT `account_admin_ibfk_1` FOREIGN KEY (`id_status_acc`) REFERENCES `status_acc` (`id_status_acc`) ON DELETE RESTRICT ON UPDATE RESTRICT;
ALTER TABLE `account_admin` ADD CONSTRAINT `account_admin_ibfk_2` FOREIGN KEY (`id_role_admin`) REFERENCES `role_admin` (`id_role_admin`) ON DELETE RESTRICT ON UPDATE RESTRICT;
ALTER TABLE `account_customer` ADD CONSTRAINT `account_customer_ibfk_1` FOREIGN KEY (`id_status_acc`) REFERENCES `status_acc` (`id_status_acc`) ON DELETE RESTRICT ON UPDATE RESTRICT;
ALTER TABLE `account_customer` ADD CONSTRAINT `account_customer_ibfk_2` FOREIGN KEY (`id_city`) REFERENCES `city` (`id_city`) ON DELETE RESTRICT ON UPDATE RESTRICT;
ALTER TABLE `bill_detail` ADD CONSTRAINT `bill_detail_ibfk_1` FOREIGN KEY (`id_bill`) REFERENCES `bills` (`id_bill`) ON DELETE RESTRICT ON UPDATE RESTRICT;
ALTER TABLE `bill_detail` ADD CONSTRAINT `bill_detail_ibfk_2` FOREIGN KEY (`id_product`) REFERENCES `products` (`id_product`) ON DELETE RESTRICT ON UPDATE RESTRICT;
ALTER TABLE `bills` ADD CONSTRAINT `bills_ibfk_2` FOREIGN KEY (`id_status_bill`) REFERENCES `status_bill` (`id_status_bill`) ON DELETE RESTRICT ON UPDATE RESTRICT;
ALTER TABLE `bills` ADD CONSTRAINT `bills_ibfk_3` FOREIGN KEY (`id_city`) REFERENCES `city` (`id_city`) ON DELETE RESTRICT ON UPDATE RESTRICT;
ALTER TABLE `bills` ADD CONSTRAINT `bills_ibfk_4` FOREIGN KEY (`id_user`) REFERENCES `account_customer` (`id_user_customer`) ON DELETE RESTRICT ON UPDATE RESTRICT;
ALTER TABLE `comment_news` ADD CONSTRAINT `comment_news_ibfk_1` FOREIGN KEY (`id_news`) REFERENCES `news` (`id_news`) ON DELETE RESTRICT ON UPDATE RESTRICT;
ALTER TABLE `comment_news` ADD CONSTRAINT `comment_news_ibfk_2` FOREIGN KEY (`id_user_customer`) REFERENCES `account_customer` (`id_user_customer`) ON DELETE RESTRICT ON UPDATE RESTRICT;
ALTER TABLE `price_product` ADD CONSTRAINT `price_product_ibfk_1` FOREIGN KEY (`id_product`) REFERENCES `products` (`id_product`) ON DELETE RESTRICT ON UPDATE RESTRICT;
ALTER TABLE `products` ADD CONSTRAINT `products_ibfk_1` FOREIGN KEY (`id_type_product`) REFERENCES `type_product` (`id_type_product`) ON DELETE RESTRICT ON UPDATE RESTRICT;
ALTER TABLE `products` ADD CONSTRAINT `products_ibfk_2` FOREIGN KEY (`id_status_product`) REFERENCES `status_product` (`id_status_product`) ON DELETE RESTRICT ON UPDATE RESTRICT;
ALTER TABLE `products` ADD CONSTRAINT `products_ibfk_3` FOREIGN KEY (`id_supplier`) REFERENCES `suppliers` (`id_supplier`) ON DELETE RESTRICT ON UPDATE RESTRICT;
ALTER TABLE `sold_product` ADD CONSTRAINT `sold_product_ibfk_1` FOREIGN KEY (`id_product`) REFERENCES `products` (`id_product`) ON DELETE RESTRICT ON UPDATE RESTRICT;



-- ACCOUNT_ADMIN
alter table account_admin
			add column fullname varchar(255)
			
-- PRODUCTS
ALTER TABLE products 
			DROP COLUMN country;
			
ALTER TABLE products
			ADD COLUMN nameAdmin VARCHAR(50);

-- PRICE_PRODUCT
ALTER TABLE price_product
			MODIFY COLUMN date TIMESTAMP DEFAULT(CURRENT_TIMESTAMP);
		
ALTER TABLE price_product
			ADD COLUMN nameAdmin VARCHAR(50);
			
-- NEWS
ALTER TABLE news
			MODIFY COLUMN content_news LONGTEXT NOT NULL;
			
ALTER TABLE news
			ADD COLUMN nameAdmin VARCHAR(255);

			

			

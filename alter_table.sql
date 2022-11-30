
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
			

			

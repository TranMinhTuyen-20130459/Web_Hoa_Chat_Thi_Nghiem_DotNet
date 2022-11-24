CREATE TABLE [account_admin] (
  [username] nvarchar(50) NOT NULL,
  [id_role_admin] int NOT NULL,
  [id_status_acc] int NOT NULL,
  [passwordAD] nvarchar(50) NOT NULL,
  [time_created] datetime2 NOT NULL,
  [time_change_pass] datetime2 NOT NULL,
  PRIMARY KEY CLUSTERED ([username])
WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON)
)
GO
CREATE NONCLUSTERED INDEX [id_status_acc]
ON [].[account_admin] (
  [id_status_acc] ASC
)
GO
CREATE NONCLUSTERED INDEX [id_role_admin]
ON [].[account_admin] (
  [id_role_admin] ASC
)
GO

CREATE TABLE [account_customer] (
  [id_user_customer] int NOT NULL,
  [username] nvarchar(50) NOT NULL,
  [pass] nvarchar(50) NOT NULL,
  [id_status_acc] int NOT NULL,
  [id_city] int NOT NULL,
  [fullname] nvarchar(255) NULL,
  [sex] nvarchar(50) NULL,
  [email_customer] nvarchar(50) NULL,
  [phone_customer] nvarchar(15) NULL,
  [address] nvarchar(255) NULL,
  [time_created] datetime2 NOT NULL,
  [time_change_pass] datetime2 NOT NULL,
  CONSTRAINT [_copy_17] PRIMARY KEY CLUSTERED ([id_user_customer])
WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON)
)
GO
CREATE UNIQUE NONCLUSTERED INDEX [username]
ON [].[account_customer] (
  [username] ASC
)
GO
CREATE NONCLUSTERED INDEX [id_status_acc]
ON [].[account_customer] (
  [id_status_acc] ASC
)
GO
CREATE NONCLUSTERED INDEX [id_city]
ON [].[account_customer] (
  [id_city] ASC
)
GO

CREATE TABLE [bill_detail] (
  [id_bill] int NOT NULL,
  [id_product] int NOT NULL,
  [quantity] int NOT NULL,
  [listed_price] bigint NOT NULL,
  [current_price] bigint NOT NULL,
  CONSTRAINT [_copy_16] PRIMARY KEY CLUSTERED ([id_bill], [id_product])
WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON)
)
GO
CREATE NONCLUSTERED INDEX [id_product]
ON [].[bill_detail] (
  [id_product] ASC
)
GO

CREATE TABLE [bills] (
  [id_bill] int NOT NULL,
  [id_user] int NOT NULL,
  [id_status_bill] int NOT NULL,
  [id_city] int NOT NULL,
  [fullname_customer] nvarchar(100) NOT NULL,
  [phone_customer] nvarchar(20) NOT NULL,
  [email_customer] nvarchar(50) NOT NULL,
  [address_customer] nvarchar(255) NOT NULL,
  [bill_price] bigint NOT NULL,
  [total_price] bigint NOT NULL,
  [time_order] datetime2 NOT NULL,
  CONSTRAINT [_copy_15] PRIMARY KEY CLUSTERED ([id_bill])
WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON)
)
GO
CREATE NONCLUSTERED INDEX [id_user]
ON [].[bills] (
  [id_user] ASC
)
GO
CREATE NONCLUSTERED INDEX [id_status_bill]
ON [].[bills] (
  [id_status_bill] ASC
)
GO
CREATE NONCLUSTERED INDEX [id_city]
ON [].[bills] (
  [id_city] ASC
)
GO

CREATE TABLE [city] (
  [id_city] int NOT NULL,
  [name_city] nvarchar(100) NOT NULL,
  [transport] bigint NOT NULL,
  CONSTRAINT [_copy_14] PRIMARY KEY CLUSTERED ([id_city])
WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON)
)
GO

CREATE TABLE [comment_news] (
  [id_comment] int NOT NULL,
  [id_news] int NOT NULL,
  [id_user_customer] int NOT NULL,
  [time_comment] datetime2 NOT NULL,
  [content_comment] nvarchar(max) NOT NULL,
  CONSTRAINT [_copy_13] PRIMARY KEY CLUSTERED ([id_comment])
WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON)
)
GO
CREATE NONCLUSTERED INDEX [id_news]
ON [].[comment_news] (
  [id_news] ASC
)
GO
CREATE NONCLUSTERED INDEX [id_user_customer]
ON [].[comment_news] (
  [id_user_customer] ASC
)
GO

CREATE TABLE [contact] (
  [id_contact] int NOT NULL,
  [full_name] nvarchar(50) NOT NULL,
  [phone_contact] nvarchar(50) NOT NULL,
  [email_contact] nvarchar(50) NOT NULL,
  [problem_name] nvarchar(255) NOT NULL,
  [content_problem] nvarchar(max) NOT NULL,
  [time_insert] datetime2 NOT NULL,
  CONSTRAINT [_copy_12] PRIMARY KEY CLUSTERED ([id_contact])
WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON)
)
GO

CREATE TABLE [infor_web] (
  [id_infor] int NOT NULL,
  [phone_web] nvarchar(50) NOT NULL,
  [email_web] nvarchar(100) NOT NULL,
  [address_web] nvarchar(100) NOT NULL,
  CONSTRAINT [_copy_11] PRIMARY KEY CLUSTERED ([id_infor])
WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON)
)
GO

CREATE TABLE [news] (
  [id_news] int NOT NULL,
  [title_news] nvarchar(max) NOT NULL,
  [content_news] nvarchar(max) NOT NULL,
  [url_img_news] nvarchar(max) NULL,
  [date_posted] datetime2 NOT NULL,
  [quantity_comment] int NOT NULL,
  CONSTRAINT [_copy_10] PRIMARY KEY CLUSTERED ([id_news])
WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON)
)
GO

CREATE TABLE [price_product] (
  [id_product] int NOT NULL,
  [date] date NOT NULL,
  [listed_price] bigint NOT NULL,
  [current_price] bigint NOT NULL,
  CONSTRAINT [_copy_9] PRIMARY KEY CLUSTERED ([id_product], [date])
WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON)
)
GO

CREATE TABLE [products] (
  [id_product] int NOT NULL,
  [id_type_product] int NOT NULL,
  [id_status_product] int NOT NULL,
  [id_supplier] int NOT NULL,
  [name_product] nvarchar(255) NOT NULL,
  [description_product] nvarchar(max) NULL,
  [url_img_product] nvarchar(max) NULL,
  [quantity_product] int NOT NULL,
  [country] nvarchar(255) NULL,
  [date_inserted] datetime2 NOT NULL,
  [star_review] tinyint NULL,
  CONSTRAINT [_copy_8] PRIMARY KEY CLUSTERED ([id_product])
WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON)
)
GO
CREATE NONCLUSTERED INDEX [id_type_product]
ON [].[products] (
  [id_type_product] ASC
)
GO
CREATE NONCLUSTERED INDEX [id_status_product]
ON [].[products] (
  [id_status_product] ASC
)
GO
CREATE NONCLUSTERED INDEX [id_supplier]
ON [].[products] (
  [id_supplier] ASC
)
GO

CREATE TABLE [role_admin] (
  [id_role_admin] int NOT NULL,
  [name_role] nvarchar(50) NOT NULL,
  CONSTRAINT [_copy_7] PRIMARY KEY CLUSTERED ([id_role_admin])
WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON)
)
GO

CREATE TABLE [sold_product] (
  [id_product] int NOT NULL,
  [datetime] date NOT NULL,
  [quantity_sold] int NOT NULL,
  CONSTRAINT [_copy_6] PRIMARY KEY CLUSTERED ([id_product], [datetime])
WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON)
)
GO

CREATE TABLE [status_acc] (
  [id_status_acc] int NOT NULL,
  [name_status_acc] nvarchar(50) NULL,
  CONSTRAINT [_copy_5] PRIMARY KEY CLUSTERED ([id_status_acc])
WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON)
)
GO

CREATE TABLE [status_bill] (
  [id_status_bill] int NOT NULL,
  [name_status_bill] nvarchar(50) NOT NULL,
  CONSTRAINT [_copy_4] PRIMARY KEY CLUSTERED ([id_status_bill])
WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON)
)
GO

CREATE TABLE [status_product] (
  [id_status_product] int NOT NULL,
  [name_status_product] nvarchar(50) NOT NULL,
  CONSTRAINT [_copy_3] PRIMARY KEY CLUSTERED ([id_status_product])
WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON)
)
GO

CREATE TABLE [suppliers] (
  [id_supplier] int NOT NULL,
  [name_supplier] nvarchar(255) NOT NULL,
  CONSTRAINT [_copy_2] PRIMARY KEY CLUSTERED ([id_supplier])
WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON)
)
GO

CREATE TABLE [type_product] (
  [id_type_product] int NOT NULL,
  [name_type_product] nvarchar(255) NOT NULL,
  CONSTRAINT [_copy_1] PRIMARY KEY CLUSTERED ([id_type_product])
WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON)
)
GO

ALTER TABLE [account_admin] ADD CONSTRAINT [account_admin_ibfk_1] FOREIGN KEY ([id_status_acc]) REFERENCES [status_acc] ([id_status_acc])
GO
ALTER TABLE [account_admin] ADD CONSTRAINT [account_admin_ibfk_2] FOREIGN KEY ([id_role_admin]) REFERENCES [role_admin] ([id_role_admin])
GO
ALTER TABLE [account_customer] ADD CONSTRAINT [account_customer_ibfk_1] FOREIGN KEY ([id_status_acc]) REFERENCES [status_acc] ([id_status_acc])
GO
ALTER TABLE [account_customer] ADD CONSTRAINT [account_customer_ibfk_2] FOREIGN KEY ([id_city]) REFERENCES [city] ([id_city])
GO
ALTER TABLE [bill_detail] ADD CONSTRAINT [bill_detail_ibfk_1] FOREIGN KEY ([id_bill]) REFERENCES [bills] ([id_bill])
GO
ALTER TABLE [bill_detail] ADD CONSTRAINT [bill_detail_ibfk_2] FOREIGN KEY ([id_product]) REFERENCES [products] ([id_product])
GO
ALTER TABLE [bills] ADD CONSTRAINT [bills_ibfk_2] FOREIGN KEY ([id_status_bill]) REFERENCES [status_bill] ([id_status_bill])
GO
ALTER TABLE [bills] ADD CONSTRAINT [bills_ibfk_3] FOREIGN KEY ([id_city]) REFERENCES [city] ([id_city])
GO
ALTER TABLE [bills] ADD CONSTRAINT [bills_ibfk_4] FOREIGN KEY ([id_user]) REFERENCES [account_customer] ([id_user_customer])
GO
ALTER TABLE [comment_news] ADD CONSTRAINT [comment_news_ibfk_1] FOREIGN KEY ([id_news]) REFERENCES [news] ([id_news])
GO
ALTER TABLE [comment_news] ADD CONSTRAINT [comment_news_ibfk_2] FOREIGN KEY ([id_user_customer]) REFERENCES [account_customer] ([id_user_customer])
GO
ALTER TABLE [price_product] ADD CONSTRAINT [price_product_ibfk_1] FOREIGN KEY ([id_product]) REFERENCES [products] ([id_product])
GO
ALTER TABLE [products] ADD CONSTRAINT [products_ibfk_1] FOREIGN KEY ([id_type_product]) REFERENCES [type_product] ([id_type_product])
GO
ALTER TABLE [products] ADD CONSTRAINT [products_ibfk_2] FOREIGN KEY ([id_status_product]) REFERENCES [status_product] ([id_status_product])
GO
ALTER TABLE [products] ADD CONSTRAINT [products_ibfk_3] FOREIGN KEY ([id_supplier]) REFERENCES [suppliers] ([id_supplier])
GO
ALTER TABLE [sold_product] ADD CONSTRAINT [sold_product_ibfk_1] FOREIGN KEY ([id_product]) REFERENCES [products] ([id_product])
GO


IF OBJECT_ID(N'[__EFMigrationsHistory]') IS NULL
BEGIN
    CREATE TABLE [__EFMigrationsHistory] (
        [MigrationId] nvarchar(150) NOT NULL,
        [ProductVersion] nvarchar(32) NOT NULL,
        CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY ([MigrationId])
    );
END;
GO

BEGIN TRANSACTION;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230725115908_initialUser')
BEGIN
    CREATE TABLE [Users] (
        [Id] int NOT NULL IDENTITY,
        [Username] nvarchar(max) NOT NULL,
        [PasswordHash] varbinary(max) NOT NULL,
        [passwordSalt] varbinary(max) NOT NULL,
        CONSTRAINT [PK_Users] PRIMARY KEY ([Id])
    );
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230725115908_initialUser')
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20230725115908_initialUser', N'7.0.9');
END;
GO

COMMIT;
GO

BEGIN TRANSACTION;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230726163846_product')
BEGIN
    CREATE TABLE [Products] (
        [Id] int NOT NULL IDENTITY,
        [name] nvarchar(max) NOT NULL,
        [price] int NOT NULL,
        CONSTRAINT [PK_Products] PRIMARY KEY ([Id])
    );
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230726163846_product')
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20230726163846_product', N'7.0.9');
END;
GO

COMMIT;
GO

BEGIN TRANSACTION;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230726164544_relations')
BEGIN
    ALTER TABLE [Users] ADD [MyProperty] int NOT NULL DEFAULT 0;
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230726164544_relations')
BEGIN
    CREATE TABLE [ProductUser] (
        [productsId] int NOT NULL,
        [usersId] int NOT NULL,
        CONSTRAINT [PK_ProductUser] PRIMARY KEY ([productsId], [usersId]),
        CONSTRAINT [FK_ProductUser_Products_productsId] FOREIGN KEY ([productsId]) REFERENCES [Products] ([Id]) ON DELETE CASCADE,
        CONSTRAINT [FK_ProductUser_Users_usersId] FOREIGN KEY ([usersId]) REFERENCES [Users] ([Id]) ON DELETE CASCADE
    );
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230726164544_relations')
BEGIN
    CREATE INDEX [IX_ProductUser_usersId] ON [ProductUser] ([usersId]);
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230726164544_relations')
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20230726164544_relations', N'7.0.9');
END;
GO

COMMIT;
GO

BEGIN TRANSACTION;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230729123837_seed')
BEGIN
    EXEC sp_rename N'[Products].[name]', N'type', N'COLUMN';
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230729123837_seed')
BEGIN
    ALTER TABLE [Products] ADD [brand] nvarchar(max) NOT NULL DEFAULT N'';
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230729123837_seed')
BEGIN
    ALTER TABLE [Products] ADD [fastCharge] bit NOT NULL DEFAULT CAST(0 AS bit);
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230729123837_seed')
BEGIN
    ALTER TABLE [Products] ADD [model] nvarchar(max) NOT NULL DEFAULT N'';
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230729123837_seed')
BEGIN
    ALTER TABLE [Products] ADD [rating] int NOT NULL DEFAULT 0;
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230729123837_seed')
BEGIN
    ALTER TABLE [Products] ADD [stock] int NOT NULL DEFAULT 0;
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230729123837_seed')
BEGIN
    ALTER TABLE [Products] ADD [waterproof] bit NOT NULL DEFAULT CAST(0 AS bit);
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230729123837_seed')
BEGIN
    IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'brand', N'fastCharge', N'model', N'price', N'rating', N'stock', N'type', N'waterproof') AND [object_id] = OBJECT_ID(N'[Products]'))
        SET IDENTITY_INSERT [Products] ON;
    EXEC(N'INSERT INTO [Products] ([Id], [brand], [fastCharge], [model], [price], [rating], [stock], [type], [waterproof])
    VALUES (1, N''Philips'', CAST(1 AS bit), N''Series 7000'', 150, 5, 10, N''Shaver'', CAST(1 AS bit)),
    (2, N''Braun'', CAST(0 AS bit), N''Series 9'', 250, 4, 20, N''Shaver'', CAST(1 AS bit)),
    (3, N''Panasonic'', CAST(1 AS bit), N''Arc5'', 200, 4, 15, N''Shaver'', CAST(1 AS bit)),
    (4, N''Philips'', CAST(0 AS bit), N''OneBlade'', 50, 4, 30, N''Shaver'', CAST(1 AS bit)),
    (5, N''Philips'', CAST(0 AS bit), N''AquaTouch'', 80, 3, 20, N''Shaver'', CAST(1 AS bit)),
    (6, N''Philips'', CAST(1 AS bit), N''Series 5000'', 120, 5, 10, N''Shaver'', CAST(1 AS bit)),
    (7, N''Braun'', CAST(1 AS bit), N''Series 7'', 180, 4, 25, N''Shaver'', CAST(1 AS bit)),
    (8, N''Braun'', CAST(0 AS bit), N''Series 5'', 130, 4, 15, N''Shaver'', CAST(1 AS bit)),
    (9, N''Braun'', CAST(0 AS bit), N''Series 3 ProSkin'', 70, 3, 20, N''Shaver'', CAST(1 AS bit)),
    (10, N''Panasonic'', CAST(1 AS bit), N''Arc4'', 120, 4, 15, N''Shaver'', CAST(1 AS bit)),
    (11, N''Panasonic'', CAST(0 AS bit), N''Arc3'', 90, 4, 20, N''Shaver'', CAST(1 AS bit)),
    (12, N''Panasonic'', CAST(1 AS bit), N''ES-LV95-S'', 200, 5, 10, N''Shaver'', CAST(1 AS bit))');
    IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'brand', N'fastCharge', N'model', N'price', N'rating', N'stock', N'type', N'waterproof') AND [object_id] = OBJECT_ID(N'[Products]'))
        SET IDENTITY_INSERT [Products] OFF;
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230729123837_seed')
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20230729123837_seed', N'7.0.9');
END;
GO

COMMIT;
GO

BEGIN TRANSACTION;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230729125208_link')
BEGIN
    ALTER TABLE [Products] ADD [image] nvarchar(max) NOT NULL DEFAULT N'';
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230729125208_link')
BEGIN
    EXEC(N'UPDATE [Products] SET [image] = N''https://www.maquinilladeafeitar.com/wp-content/uploads/2018/01/Philips-serie-7000.jpg''
    WHERE [Id] = 1;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230729125208_link')
BEGIN
    EXEC(N'UPDATE [Products] SET [image] = N''https://images-na.ssl-images-amazon.com/images/I/811IO5eKSJL._AC_SL1500_.jpg''
    WHERE [Id] = 2;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230729125208_link')
BEGIN
    EXEC(N'UPDATE [Products] SET [image] = N''https://moo.review/wp-content/uploads/2016/02/Panasonic-Arc-5-model-ES-LV9N-electric-shaver.jpg''
    WHERE [Id] = 3;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230729125208_link')
BEGIN
    EXEC(N'UPDATE [Products] SET [image] = N''https://www.philips.be/c-dam/corporate/newscenter/be/standard/resources/2017/one-blade/philips-one-blade-hi-res-02.download.jpg''
    WHERE [Id] = 4;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230729125208_link')
BEGIN
    EXEC(N'UPDATE [Products] SET [image] = N''https://www.bigw.com.au/medias/sys_master/images/images/hb5/h95/10815612026910.jpg''
    WHERE [Id] = 5;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230729125208_link')
BEGIN
    EXEC(N'UPDATE [Products] SET [image] = N''https://top-rasage.fr/wp-content/uploads/2018/02/Philips-Series-5000-S531026.jpg''
    WHERE [Id] = 6;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230729125208_link')
BEGIN
    EXEC(N'UPDATE [Products] SET [image] = N''https://www.bestshaverszone.com/wp-content/uploads/2015/03/Braun-Series-7-790cc-Pulsonic.jpg''
    WHERE [Id] = 7;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230729125208_link')
BEGIN
    EXEC(N'UPDATE [Products] SET [image] = N''https://pisces.bbystatic.com/image2/BestBuy_US/images/products/5895/5895021_rd.jpg''
    WHERE [Id] = 8;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230729125208_link')
BEGIN
    EXEC(N'UPDATE [Products] SET [image] = N''https://www.mashco.co.uk/media/catalog/product/cache/1/image/9df78eab33525d08d6e5fb8d27136e95/b/r/bra3000s.png''
    WHERE [Id] = 9;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230729125208_link')
BEGIN
    EXEC(N'UPDATE [Products] SET [image] = N''https://d11zer3aoz69xt.cloudfront.net/media/catalog/product/cache/1/image/1200x/9df78eab33525d08d6e5fb8d27136e95/p/a/panasonic_arc4_4-blade_shaver_es-lf51-a_11.jpg''
    WHERE [Id] = 10;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230729125208_link')
BEGIN
    EXEC(N'UPDATE [Products] SET [image] = N''https://pisces.bbystatic.com/image2/BestBuy_US/images/products/6400/6400550_rd.jpg''
    WHERE [Id] = 11;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230729125208_link')
BEGIN
    EXEC(N'UPDATE [Products] SET [image] = N''https://c1.neweggimages.com/ProductImageCompressAll1280/96-200-517-02.jpg''
    WHERE [Id] = 12;
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230729125208_link')
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20230729125208_link', N'7.0.9');
END;
GO

COMMIT;
GO

BEGIN TRANSACTION;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230729192738_order')
BEGIN
    DROP TABLE [ProductUser];
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230729192738_order')
BEGIN
    ALTER TABLE [Users] ADD [ProductId] int NULL;
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230729192738_order')
BEGIN
    CREATE TABLE [order] (
        [Id] int NOT NULL IDENTITY,
        [status] int NOT NULL,
        [userId] int NULL,
        CONSTRAINT [PK_order] PRIMARY KEY ([Id]),
        CONSTRAINT [FK_order_Users_userId] FOREIGN KEY ([userId]) REFERENCES [Users] ([Id])
    );
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230729192738_order')
BEGIN
    CREATE TABLE [ProductItems] (
        [Id] int NOT NULL IDENTITY,
        [productId] int NULL,
        [number] int NOT NULL,
        [OrderId] int NULL,
        CONSTRAINT [PK_ProductItems] PRIMARY KEY ([Id]),
        CONSTRAINT [FK_ProductItems_Products_productId] FOREIGN KEY ([productId]) REFERENCES [Products] ([Id]),
        CONSTRAINT [FK_ProductItems_order_OrderId] FOREIGN KEY ([OrderId]) REFERENCES [order] ([Id])
    );
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230729192738_order')
BEGIN
    CREATE INDEX [IX_Users_ProductId] ON [Users] ([ProductId]);
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230729192738_order')
BEGIN
    CREATE INDEX [IX_order_userId] ON [order] ([userId]);
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230729192738_order')
BEGIN
    CREATE INDEX [IX_ProductItems_OrderId] ON [ProductItems] ([OrderId]);
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230729192738_order')
BEGIN
    CREATE INDEX [IX_ProductItems_productId] ON [ProductItems] ([productId]);
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230729192738_order')
BEGIN
    ALTER TABLE [Users] ADD CONSTRAINT [FK_Users_Products_ProductId] FOREIGN KEY ([ProductId]) REFERENCES [Products] ([Id]);
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230729192738_order')
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20230729192738_order', N'7.0.9');
END;
GO

COMMIT;
GO

BEGIN TRANSACTION;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230731005611_newproduct')
BEGIN
    ALTER TABLE [ProductItems] DROP CONSTRAINT [FK_ProductItems_order_OrderId];
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230731005611_newproduct')
BEGIN
    ALTER TABLE [Users] DROP CONSTRAINT [FK_Users_Products_ProductId];
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230731005611_newproduct')
BEGIN
    DROP INDEX [IX_Users_ProductId] ON [Users];
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230731005611_newproduct')
BEGIN
    DECLARE @var0 sysname;
    SELECT @var0 = [d].[name]
    FROM [sys].[default_constraints] [d]
    INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
    WHERE ([d].[parent_object_id] = OBJECT_ID(N'[Users]') AND [c].[name] = N'ProductId');
    IF @var0 IS NOT NULL EXEC(N'ALTER TABLE [Users] DROP CONSTRAINT [' + @var0 + '];');
    ALTER TABLE [Users] DROP COLUMN [ProductId];
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230731005611_newproduct')
BEGIN
    EXEC sp_rename N'[ProductItems].[OrderId]', N'orderId', N'COLUMN';
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230731005611_newproduct')
BEGIN
    EXEC sp_rename N'[ProductItems].[IX_ProductItems_OrderId]', N'IX_ProductItems_orderId', N'INDEX';
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230731005611_newproduct')
BEGIN
    DECLARE @var1 sysname;
    SELECT @var1 = [d].[name]
    FROM [sys].[default_constraints] [d]
    INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
    WHERE ([d].[parent_object_id] = OBJECT_ID(N'[Products]') AND [c].[name] = N'image');
    IF @var1 IS NOT NULL EXEC(N'ALTER TABLE [Products] DROP CONSTRAINT [' + @var1 + '];');
    ALTER TABLE [Products] ALTER COLUMN [image] nvarchar(max) NULL;
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230731005611_newproduct')
BEGIN
    ALTER TABLE [ProductItems] ADD CONSTRAINT [FK_ProductItems_order_orderId] FOREIGN KEY ([orderId]) REFERENCES [order] ([Id]);
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20230731005611_newproduct')
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20230731005611_newproduct', N'7.0.9');
END;
GO

COMMIT;
GO


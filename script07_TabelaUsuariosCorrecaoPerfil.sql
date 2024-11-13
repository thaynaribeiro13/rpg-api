﻿BEGIN TRANSACTION;
GO

DROP TABLE [TB_DISPUTAS];
GO

DECLARE @var0 sysname;
SELECT @var0 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[TB_USUARIOS]') AND [c].[name] = N'Perfil');
IF @var0 IS NOT NULL EXEC(N'ALTER TABLE [TB_USUARIOS] DROP CONSTRAINT [' + @var0 + '];');
UPDATE [TB_USUARIOS] SET [Perfil] = 'Jogador' WHERE [Perfil] IS NULL;
ALTER TABLE [TB_USUARIOS] ALTER COLUMN [Perfil] Varchar(200) NOT NULL;
ALTER TABLE [TB_USUARIOS] ADD DEFAULT 'Jogador' FOR [Perfil];
GO

DECLARE @var1 sysname;
SELECT @var1 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[TB_USUARIOS]') AND [c].[name] = N'Email');
IF @var1 IS NOT NULL EXEC(N'ALTER TABLE [TB_USUARIOS] DROP CONSTRAINT [' + @var1 + '];');
UPDATE [TB_USUARIOS] SET [Email] = '' WHERE [Email] IS NULL;
ALTER TABLE [TB_USUARIOS] ALTER COLUMN [Email] Varchar(200) NOT NULL;
ALTER TABLE [TB_USUARIOS] ADD DEFAULT '' FOR [Email];
GO

UPDATE [TB_USUARIOS] SET [PasswordHash] = 0x09EE38449D5F3E82A7DFE32E33D41396789F40F06AF0DB4709C1FB21721128026E09121FF5FC4FB2F6ACB4A87AEAF2B13474A994B9D997A69D501FFA1B3A7936, [PasswordSalt] = 0xBB162062D63F22965A9AC01CB04C83B01B7247A163A64DEC7A2C5E09E5A7595119D05B00E63D16E53AEC275ADC6C4A322203BFBC4A401E8142EA6E273BE74FFD12A1D8AD74A308D897D60CF5A46E202E19E599A922851D5C15BDAEEA19716D8FD247808FEC871BC6106B8FB6F663180EBCDECB316E696F884E30CFA92097B2F4
WHERE [Id] = 1;
SELECT @@ROWCOUNT;

GO

DELETE FROM [__EFMigrationsHistory]
WHERE [MigrationId] = N'20241001144433_MigracaoCorrecaoPerfil';
GO

COMMIT;
GO

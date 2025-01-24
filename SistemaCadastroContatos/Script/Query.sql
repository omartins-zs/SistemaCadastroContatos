USE [DB_SistemaContatos]
GO

INSERT INTO [dbo].[Usuarios]
           ([Nome]
           ,[Login]
           ,[Email]
           ,[Perfil]
           ,[Senha]
           ,[DataCadastro]
           ,[DataAtualizacao])
     VALUES
           ('Admin',                 -- Nome
            'admin',                 -- Login
            'admin@gmail.com.br',    -- Email
            2,                       -- Perfil (supondo que 2 seja um valor v�lido)
            '234234234',             -- Senha
            GETDATE(),               -- DataCadastro (usei GETDATE() para a data atual)
            GETDATE())               -- DataAtualizacao (tamb�m usei GETDATE() para a data atual)
GO


INSERT INTO [dbo].[Usuarios]
           ([Nome]
           ,[Login]
           ,[Email]
           ,[Perfil]
           ,[Senha]
           ,[DataCadastro]
           ,[DataAtualizacao])
     VALUES
           ('Gabriel Martins',              -- Nome
            'gabriel',                      -- Login
            'gabrielmatheus209@gmail.com',  -- Email
            2,                              -- Perfil (supondo que 2 seja um valor v�lido)
            '12345678',                     -- Senha
            GETDATE(),                      -- DataCadastro (data atual)
            GETDATE())                      -- DataAtualizacao (data atual)
GO
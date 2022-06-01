USE [TP_TecnicasProg]

CREATE TABLE[dbo].[Usuarios]
(
    [Id_usuario]INT NOT NULL,
    [Usuario]VARCHAR(50)NULL,
    [Password]VARCHAR(50)NULL,
    [Tipo_usuario]VARCHAR(50)NULL
)
 
 
 select * from Usuarios

insert into Usuarios values(01,'administrador','administrador','Admin'),
                          (02,'cliente','cliente','Cliente'),
						  (03,'encargado','encargado','logistica'),
						  (04,'gerente','gerente','Gerente')

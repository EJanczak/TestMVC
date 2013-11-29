create schema Programs

GO

create table Programs.Program (
    Id int identity(1,1),
    Name nvarchar(50) not null
)
GO

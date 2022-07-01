use TeacherDB
go
create proc [dbo].[sp_StudentDelete]
@StudentId int
as
begin
delete from Students where StudentId = @StudentId
end

go

create proc [dbo].[sp_StudentInsert]
@StudentName nvarchar(100),
@StudentMobile nvarchar(14),
@ParentMobile nvarchar(14),
@StudentAddress nvarchar(200),
@Notes nvarchar(300),
@GroupId int
as
begin
insert into Students values(@StudentName,@StudentMobile,@ParentMobile,@StudentAddress,@Notes,@GroupId)
end

go

create proc [dbo].[sp_StudentsReadAll]
as
begin
select * from Students
end
go

alter proc [dbo].[sp_StudentsReadbyID]
@StudentId int
as
begin
select * from Students where StudentId = @StudentId
end
go

create proc [dbo].[sp_StudentsUpdate]
(
@StudentId int,
@StudentName nvarchar(100),
@StudentMobile nvarchar(14),
@ParentMobile nvarchar(14),
@StudentAddress nvarchar(200),
@Notes nvarchar(300),
@GroupId int
)
as
begin
update Students set StudentName = @StudentName, StudentMobile = @StudentMobile,ParentMobile = @ParentMobile, StudentAddress = @StudentAddress, Notes = @Notes ,GroupId = @GroupId 
 where StudentId = @StudentId 
END

go
create proc [dbo].[sp_StudentsReadbyGroupId]
@GroupId int
as
begin
select * from Students where GroupId = @GroupId
end
go

------------------group-----------------------------------------------------
go
create proc [dbo].[sp_GroupDelete]
@GroupId int
as
begin
delete from Groups where GroupId = @GroupId
end

go

create proc [dbo].[sp_GroupInsert]
@GroupName nvarchar(200),
@GroupLocation nvarchar(200),
@GroupDate date
as
begin
insert into Groups values(@GroupName,@GroupLocation ,@GroupDate )
end

go
create proc [dbo].[sp_GroupsReadAll]
as
begin
select * from Groups
end
go

create proc [dbo].[sp_GroupsReadbyID]
@GroupId  int
as
begin
select * from Groups where GroupId  = @GroupId 
end
go

alter proc [dbo].[sp_GroupsUpdate]
@GroupId  int,
@GroupName nvarchar(200),
@GroupLocation nvarchar(200),
@GroupDate date
as
begin
update Groups set GroupName = @GroupName , GroupLocation = @GroupLocation, GroupDate = @GroupDate 
 where GroupId = @GroupId 
END

go
---------------------------Tests---------------------------------
go
create proc [dbo].[sp_TestDelete]
@TestId int
as
begin
delete from Tests where TestId = @TestId
end

go

create proc [dbo].[sp_TestInsert]
@TestName nvarchar(100),
@TestDate date,
@TestGrade decimal(9,2)
as
begin
insert into Tests values(@TestName,@TestDate ,@TestGrade )
end

go
create proc [dbo].[sp_TestsReadAll]
as
begin
select * from Tests
end
go

create proc [dbo].[sp_TestsReadbyID]
@TestId  int
as
begin
select * from Tests where TestId  = @TestId 
end
go

create proc [dbo].[sp_TestsUpdate]
@TestId  int,
@TestName nvarchar(100),
@TestDate date,
@TestGrade decimal(9, 2)
as
begin
update Tests set TestName = @TestName , TestDate = @TestDate, TestGrade= @TestGrade 
 where TestId = @TestId 
END

go

--------------------------------studentTest----------------------------------

go
create proc [dbo].[sp_StudentTestDelete]
@StudentTestID int
as
begin
delete from StudentTests where StudentTestID = @StudentTestID
end

go

create proc [dbo].[sp_StudentTestInsert]
@StudentId int,
@TestId int,
@StudentGrade decimal(9,2)
as
begin
insert into StudentTests values(@StudentId,@TestId ,@StudentGrade )
end

go
create proc [dbo].[sp_StudentTestsReadAll]
as
begin
select * from StudentTests
end
go

create proc [dbo].[sp_StudentTestsReadbyID]
@StudentTestID  int
as
begin
select * from StudentTests where StudentTestID  = @StudentTestID
end
go

create proc [dbo].[sp_StudentTestsUpdate]
@StudentTestID int,
@StudentId int,
@TestId int,
@StudentGrade decimal(9, 2)
as
begin
update StudentTests set StudentId = @StudentId , TestId = @TestId, StudentGrade= @StudentGrade 
 where StudentTestID = @StudentTestID 
END

go

--------------------------students Read all by groups--------------------------------

create proc [dbo].[sp_StudentsReadAllByGroup]
@GroupId  int
as
begin
select * from Students where GroupId  = @GroupId
end
go

exec sp_StudentsReadAllByGroup 1
go
-----------------------------------------------



create proc [dbo].[sp_ReadSearchByName]
@StudentName nvarchar(100)
as
begin
select * from Students where StudentName like '%' + @StudentName + '%'
end
go

exec sp_ReadSearchByName 'h'
go

create proc [dbo].[sp_sp_ReadSearchByMobile]
@StudentMobile  nvarchar(14)
as
begin
select * from Students where StudentMobile  = @StudentMobile
end
go



exec [sp_sp_ReadSearchByMobile] '012'


alter proc [dbo].[sp_sp_ReadSearchByGroup]
@Group nvarchar(14)
as
begin
select * from Students as s join Groups as g on s.GroupId = g.GroupId where g.GroupName like '%' + @Group +'%'
end
go

exec sp_sp_ReadSearchByGroup 's'
-----------------------attendance-------------------------------


go
create proc [dbo].[sp_AttendanceDelete]
@AttendanceID int
as
begin
delete from Attendances where AttendanceID = @AttendanceID
end

go

create proc [dbo].[sp_AttendanceInsert]
@AttendanceDate date,
@StudentID int
as
begin
insert into Attendances values(@AttendanceDate ,@StudentID )
end

go

create proc [dbo].[sp_AttendanceReadAll]
as
begin
select * from Attendances
end
go

create proc [dbo].[sp_AttendanceReadbyID]
@AttendanceID int
as
begin
select * from Attendances where AttendanceID = @AttendanceID
end
go

create proc [dbo].[sp_AttendanceUpdate]
(
@AttendanceID int,
@AttendanceDate date,
@StudentID int
)
as
begin
update Attendances set AttendanceDate = @AttendanceDate, StudentID= @StudentID
 where AttendanceID = @AttendanceID 
END

---------------------------------------payments----------------------

go
alter proc [dbo].[sp_PaymentDelete]
@PaymentId int
as
begin
delete from Payments where PaymentId = @PaymentId
end

go

alter proc [dbo].[sp_PaymentInsert]
@PaymentAmount decimal(9,2),
@PaymentDate date,
@StudentId int,
@PaymentRemainder decimal(9,2)
as
begin
insert into Payments values(@PaymentAmount,@PaymentDate ,@StudentId,@PaymentRemainder)
end

go

alter proc [dbo].[sp_PaymentReadAll]
as
begin
select * from Payments
end
go

alter proc [dbo].[sp_PaymentReadbyID]
@PaymentId int
as
begin
select * from Payments where PaymentId = @PaymentId
end
go

alter proc [dbo].[sp_PaymentUpdate]
(
@PaymentId int,
@PaymentAmount decimal(9,2),
@PaymentDate date,
@StudentId int,
@PaymentRemainder decimal(9,2)
)
as
begin
update Payments set PaymentDate = @PaymentDate, PaymentAmount = @PaymentAmount, StudentID= @StudentID, PaymentRemainder = @PaymentRemainder 
 where PaymentId = @PaymentId 
END


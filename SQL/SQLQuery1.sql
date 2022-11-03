create or alter procedure spPaySlipOfEmployees(@empnumber int,@Pf money output,@Pt money output,@hra money output,@da money output,
@it money output)
as 
begin

declare @sal money,@ded money ,@gross money,@enme varchar(max)
select  @sal=salary ,@empnumber=EmpNo,@enme=EName from Employee03
set @hra=@sal*0.1
set @da=@sal*0.2
set @Pf=@sal*0.08
set @it=@sal*0.05
set @ded = @sal*0.08+@sal*0.05
set @gross=@sal+@hra+@da
print 'Employee name is : ' +@enme
print 'Employee no : ' +cast(@empnumber as varchar(max))
print 'deductions :' +cast(@ded  as varchar (max))
print 'gross salary is: '+cast(@gross as varchar(max))
print 'net salary is : ' +cast((@gross-@ded) as varchar (max)) 

end


select*from Employee03

declare @pfo money ,@hrao money,@dao money,@ito money,@pto money
exec spPaySlipOfEmployees 7934,@pfo output,@pto output,@hrao output,@dao output,@ito output
--print @pfo 
--print @hrao
--print @dao
--print @ito
--print @pto




--1.    Write a T-SQL based procedure Program to generate complete payslip of 
--given employee with respect to the following condition
 
--a)    HRA  as 10% Of sal
--b)    DA as  20% of sal
--c)    PF as 8% of sal
--d)    IT as 5% of sal
--e)    Deductions as sum of PF and IT
--f)    Gross Salary as sum of SAL,HRA,DA 
--g)    Net salary as  Gross salary- Deduction
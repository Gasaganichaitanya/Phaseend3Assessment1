SELECT TOP (1000) [EmpCode]
      ,[DateOfBirth]
      ,[EmpName]
      ,[Email]
      ,[DeptCode]
      ,[DeptMasterDeptCode]
  FROM [ASSESSMENT1PHASE3.Data].[dbo].[EmpProfile]

  SELECT TOP (1000) [DeptCode]
      ,[DeptName]
  FROM [ASSESSMENT1PHASE3.Data].[dbo].[DeptMaster]
DROP PROCEDURE
IF EXISTS SP_IdentitySeed_GetSeed;

CREATE PROCEDURE SP_IdentitySeed_GetSeed (
	Param_ModuleName VARCHAR (200),
	Param_ActionName VARCHAR (200),
	Param_SeedDate VARCHAR (100)
)
BEGIN
	SELECT @Count := COUNT(*) FROM IdentitySeed 
	WHERE ModuleName = Param_ModuleName AND ActionName = Param_ActionName AND SeedDate = Param_SeedDate ;

	IF(@Count = 0) 
	THEN
		INSERT INTO IdentitySeed(ID,ModuleName,ActionName,SeedDate,Seed,CreateBy,CreateTime)
		VALUES (UUID(),Param_ModuleName,Param_ActionName,Param_SeedDate,1,'SYS',SYSDATE());
	ELSE 
		UPDATE IdentitySeed SET Seed = Seed + 1 
		WHERE ModuleName = Param_ModuleName AND ActionName = Param_ActionName AND SeedDate = Param_SeedDate ;
	END IF ;

	SELECT Seed FROM IdentitySeed 
	WHERE ModuleName = Param_ModuleName AND ActionName = Param_ActionName AND SeedDate = Param_SeedDate ;
END;

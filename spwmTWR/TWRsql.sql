CREATE TYPE ReturnsTable 
AS TABLE (
  		return_day date NOT NULL,
    	return_value decimal(11, 9) NOT NULL)
GO;

CREATE FUNCTION dbo.CalculateTWR
(
    @returnsTable ReturnsTable READONLY
)
RETURNS DECIMAL(11,9)
AS
BEGIN
    DECLARE @result DECIMAL(11,9) = 1;
    
    SELECT @result = @result * (1 + return_value)
    FROM @returnsTable;

    RETURN @result-1;
END

GO;

DECLARE @returnsTable ReturnsTable

INSERT INTO @returnsTable (return_day, return_value)
VALUES
    ('2023-04-01', 0),
    ('2023-04-02', 0),
    ('2023-04-03', -0.006253657),
    ('2023-04-04', -0.00361612),
    ('2023-04-05', -0.004777986),
    ('2023-04-06', -0.026842209),
    ('2023-04-07', 0.000095331),
    ('2023-04-08', 0),
    ('2023-04-09', 0),
    ('2023-04-10', -0.004793408);
    
SELECT dbo.CalculateTWR(@returnsTable)
GO;
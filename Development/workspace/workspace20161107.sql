SELECT        
	  TR.Id
	, TR.CompleteDate
	, TR.NumbersToTransaction
	, TR.TransactionPrice
	, BO.BuyDate
	, BO.BuyComment
	, SO.SellDate
	, SO.SellComment
FROM            
	dbo.Transactions TR
	INNER JOIN dbo.BuyOrders BO
	ON TR.BuyOrder = BO.Id 
	INNER JOIN dbo.SellOrders SO
	ON TR.SellOrder = SO.Id
;
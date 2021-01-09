install.packages('quantmod')
library('quantmod')
getSymbols('SPY')

head(SPY)
Ad(SPY) # 수정주가
Cl(SPY) # 종가

chart_Series(Ad(SPY))

data = getSymbols('AAPL', from = '2001-01-01', to = '2018-12-31', auto.assign = FALSE)
head(data)

ticker = c('FB', 'NVDA','AAPL') 
getSymbols(ticker)



getSymbols('005930.KS', from = '2001-01-01', to = '2018-12-31')


getSymbols('DGS10',src='FRED')
chart_Series(DGS10)


#원화 달러환율
getSymbols('DEXKOUS',src='FRED')
chart_Series(DEXKOUS)



install.packages('rvest')
install.packages('httr')

library(rvest)
library(httr)

url = 'https://finance.naver.com/news/news_list.nhn?mode=LSS2D&section_id=101&section_id2=258'
data = GET(url)

print(data)

#class 일때 앞에 점
data_title = data %>%
  read_html(encoding = 'EUC-KR') %>%
  html_nodes('dl') %>%
  html_nodes('.articleSubject') %>%  
  html_nodes('a') %>%
  html_attr('title')

print(data_title)


# =============== post 크롤링 ==================

library(httr)
library(rvest)

Sys.setlocale("LC_ALL", "English")

url = 'https://dev-kind.krx.co.kr/disclosure/todaydisclosure.do'


# 네트워크의 form data를입력
data = POST(url, body = 
              list(
                method = 'searchTodayDisclosureSub',
                currentPageSize = '15',
                pageIndex = '1',
                orderMode = '0',
                orderStat = 'D',
                forward = 'todaydisclosure_sub',
                chose = 'S',
                todayFlag = 'Y',
                selDate = '2020-12-30'
              ))

data = read_html(data) %>%
  html_table(fill = TRUE) %>%
  .[[1]]

Sys.setlocale("LC_ALL", "Korean")

Interface Segregation Principle(ISP) 介面隔離原則
(Clients should not be forced to depend on methods that they do not use.)
(客戶不應該被強迫依賴他們不使用的方法)

把不同功能從介面中分離出來，針對不同需求的用戶，開放其對應需求的介面，提拱使用。

IAvengers : 設定攻擊方法和防禦方法的介面
IFly : 運用介面隔離原則隔離出飛行方法的介面
Thor : 繼承 IAvengers IFly 2個介面並實作方法的類別
AntMan : 繼承 IAvengers 介面並實作方法的類別

優點
遵守介面隔離原則最大的好處是，在需要多型時，會比較容易為類別實作對應方法。

參考資料 https://ithelp.ithome.com.tw/articles/10192464
Dependency Inversion Principle (DIP) 依賴反轉原則 
搭配
Dependency Injection Principle (DIP) 依賴注入原則
( 
  High-level modules should not depend on low-level modules. Both should depend on abstractions.
  Abstractions should not depend on details. Details should depend on abstractions. 
)
(
  高層模組不應該依賴底層模組，它們都應該依賴抽象。
  抽象不應該依賴細節。細節應該依賴抽象。
)

它的目標就是解除物件與物件間，兩者的直接相依關係。

IAvengers : 設定攻擊方法和防禦方法的介面
DoctorStrange : 繼承 IAvengers 介面並實作方法的類別
Hulk : 繼承 IAvengers 介面並實作方法的類別
Task : 實作 依賴反轉原則 依賴注入原則 的類別
Implent_DIP 資料夾 -> Implent_DIP : 實作 依賴反轉原則 依賴注入原則 的專案


參考資料 https://ithelp.ithome.com.tw/articles/10192844
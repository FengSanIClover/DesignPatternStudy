Liskov Substitution Principle(LSP) 里氏替換原則
(Subtypes must be substitutable for their base types.)

在一個系統中，子類別應該要可以替換掉父類別，而不會影響程式架構，
當子類別實作繼承了介面或父類別，那麼只要在程式中出現該介面或類別，都要可以用該子類別來替換，
要能做到替換而不出現任何錯誤或異常。

IAvengers : 設定攻擊和防禦的介面
CaptainAmerica : 繼承介面實作方法的類別
IronMan : 繼承介面實作方法的類別
Task : 實現替換原則的類別

遵守原則的要領
為避免發生錯誤或異常，實作可以參考要領，如下：

子類別必須完全實作父類別的方法
子類別可以有屬於自己的屬性和方法

優點
里氏替換原則的重點是要增加程式的強健性，讓版本升級的時候也能有很好的兼容性。
比方說：子類別增加或修改，並不影響其他子類別，這正是強健性的特質。

參考資料 https://ithelp.ithome.com.tw/articles/10192317
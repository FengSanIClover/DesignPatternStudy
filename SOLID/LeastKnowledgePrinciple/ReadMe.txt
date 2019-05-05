Least Knowledge Principle (LKP) 最少知識原則(迪米特法則)
(
  Each unit should have only limited knowledge about other units : 
  only units "closely" related to the current unit.

  Only talk to your immediate friends.
)
(
 每個單元應該對其他單元只能有有限的知識：
 只了解跟目前單元比較親近的單元。

 兩物件之間的耦合稱為朋友關係，包含組合、聚合、依賴等，而迪米特法則要求只與直接的朋友溝通。
)

此類別庫內容:
Cooker : 廚師類別，實作製作餐點的方法
Waiter : 服務生類別，實作 點餐 和 叫廚師出來讓客人點餐 等方法
Client : 客人類別，實作 向服務生點餐 和 向廚師點餐 及 不違反原則的 Train Wreck  等方法
Implent 資料夾 -> Implent_LKP : 實作 最少知識原則(迪米特法則) 的範例專案

迪米特法則的核心概念是解耦，為了類別之間能高內聚、低耦合，達到類別可重複使用。

高階模組不應該知道低階模組的內部如何運作。
低階模組不應該暴露內部物件，不應該暴露實踐細節，應僅提供方法給高階模組使用。
一個物件應該對其他物件有最少的了解。
簡單來說，迪米特法則就是物件導向封裝特性的具體實現。

Train Wreck
違反迪米特法則，會寫出 Train Wreck，
但寫出 Train Wreck 不一定違反迪米特法則。
關鍵在於有沒有暴露內部物件與暴露實踐細節。

迪米特法則重點在於強調物件導向的封裝特性，關鍵在於不該暴露內部物件，進而暴露實踐細節，
導致使用端與內部物件強烈耦合而無法抽換商業邏輯。

迪米特法則要求所有的動作都必須透過物件本身的方法操作，而不能傳出內部物件，
讓使用端直接操作內部物件，而不在於是否使用 Train Wreck 。


優點
程式不可能沒有耦合，但耦合過高又會讓破壞程式碼的內聚性，
最小知識原則告訴我們，要把耦合的程度適度的縮小才是最好的。

參考資料 https://ithelp.ithome.com.tw/articles/10193110
		 https://oomusou.io/oop/oop-demeter/
		 http://glj8989332.blogspot.com/2018/04/design-pattern-law-of-demeter.html
Least Knowledge Principle (LKP) 最小知識原則(迪米特法則)
(
  Each unit should have only limited knowledge about other units : 
  only units "closely" related to the current unit.
)
(
 每個單元應該對其他單元只能有有限的知識：
 只了解跟目前單元比較親近的單元。
)

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
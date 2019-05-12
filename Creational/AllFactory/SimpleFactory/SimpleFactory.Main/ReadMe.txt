創建型模式-簡單工廠模式(又稱靜態工廠模式) 
(Simple Factory Pattern)

目的:定義一個簡單工廠，傳入不同的參數取得不同的類別物件

此專案的內容:
Models資料夾 -> Interfaces資料夾 -> 定義扭蛋機介面(產品介面)

Models資料夾 -> Class資料夾 -> CapsuleToyMachine.cs 實作範例二 邏輯抽離用的類別
							   MachineLunchDrink.cs 繼承 扭蛋機介面 並實作方法的類別，實作範例三 簡易工廠模式用(產品類別)
							   MachineLunchFood.cs  繼承 扭蛋機介面 並實作方法的類別，實作範例三 簡易工廠模式用(產品類別)
							   CapsuleToyMachineFactory.cs 實作簡易工廠模式的類別(工廠類別)

SimpleFactory.Main 實作範例的主控台應用程式

簡單工廠模式的優點就是分離了物件的使用和創造，缺點也很明確，每當有新的類別出來工廠就要改，複雜度上升得很快。
適用情況是需要創建的類別比較少時。
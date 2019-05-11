創建型模式-簡單工廠模式(又稱靜態工廠模式) 
(Simple Factory Pattern)

目的:定義一個簡單工廠，傳入不同的參數取得不同的類別物件

此專案的內容:
Models資料夾 -> Interfaces資料夾 -> 定義扭蛋機介面

Models資料夾 -> Class資料夾 -> CapsuleToyMachine.cs 實作範例二 邏輯抽離用的類別
							   MachineLunchDrink.cs 繼承 扭蛋機介面 並實作方法的類別，實作範例三 簡易工廠模式用
							   MachineLunchFood.cs  繼承 扭蛋機介面 並實作方法的類別，實作範例三 簡易工廠模式用

SimpleFactory.Main 實作範例的主控台應用程式
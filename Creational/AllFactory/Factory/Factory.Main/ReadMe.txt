工廠模式
(Factory)

目的:提供一個工廠介面，將產生實體程式的程式碼交由子類別各自實現，工廠使一個類別的實例化延遲到其子類別。

此專案的內容:
Modules資料夾 -> Interface資料夾 -> ICapsuleToyMachineFactory.cs 扭蛋機的工廠介面
									ICapsuleToyMachine.cs 扭蛋機介面

Modules資料夾 -> Class資料夾 -> MachineLunchFoodFactory.cs 繼承 扭蛋機工廠介面的扭蛋機-食物工廠類別，回傳對應的扭蛋機類別
								MachineLunchDrinkFactory.cs 繼承 扭蛋機工廠介面的扭蛋機-飲料工廠類別，回傳對應的扭蛋機類別
							    MachineLunchDrink.cs 繼承 扭蛋機介面 並實作方法的類別
							    MachineLunchFood.cs  繼承 扭蛋機介面 並實作方法的類別

Factory.Main 實作範例的主控台應用程式

工廠模式與簡單工廠模式比較

簡單工廠模式:工廠直接負責管理所有產品的生產工作，利用 if...else 或 switch case 判斷式來產生產品，
			 因為只有一個工廠，要新增產品種類要直接修改工廠類別裡的程式碼，違反了 開放/封閉原則(OCP)

工廠模式:工廠提升為一個概念，實際上管理產品生產工作的是實作工廠概念的實體工廠
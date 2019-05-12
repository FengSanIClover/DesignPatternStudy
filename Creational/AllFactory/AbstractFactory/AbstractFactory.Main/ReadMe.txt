創建型模式-抽象工廠模式
(Abstract Factory)

目的:用一個工廠來產生一系列相關的物件，但實際建立哪些物件由實作工廠的子類別來實現。

此專案的內容:
Modules資料夾 -> Interface資料夾 -> ICapsuleToyMachineFactory.cs 扭蛋機的工廠介面(工廠介面)
									ICapsuleToyMachine.cs 扭蛋機介面(產品介面)
									IEquipmentFactory.cs 設定扭蛋機外觀的工廠介面(工廠介面)
									IMachineStyle.cs 設定機台外觀的介面(產品介面)
									IEggStyle.cs 設定扭蛋外觀的介面(產品介面)

Modules資料夾 -> Class資料夾 -> MachineLunchFoodFactory.cs 繼承 扭蛋機工廠介面的扭蛋機-食物工廠類別，
								回傳對應的扭蛋機類別 (實體工廠類別)
								MachineLunchDrinkFactory.cs 繼承 扭蛋機工廠介面的扭蛋機-飲料工廠類別，
								回傳對應的扭蛋機類別 (實體工廠類別)
							    MachineLunchDrink.cs 繼承 扭蛋機介面 並實作方法的類別 (產品類別)
							    MachineLunchFood.cs  繼承 扭蛋機介面 並實作方法的類別 (產品類別)
								MachineStyle.cs 繼承 設定機台外觀的介面 並實作方法的類別 (產品類別)
								EggStyle.cs 繼承 扭蛋外觀的介面 並實作方法的類別 (產品類別)
								DoraemonFactory.cs 繼承 設定扭蛋機外觀的工廠介面，回傳對應的扭蛋、機台外觀的類別 (實體工廠類別)
								DisneyCompanyFactory.cs 繼承 設定扭蛋機外觀的工廠介面，回傳對應的扭蛋、機台外觀的類別 (實體工廠類別)


工廠模式與抽象工廠模式比較:
工廠模式:注重的是如何產生一個物件，例如扭蛋機工廠，只需負責如何產生扭蛋機。

抽象工廠模式:抽象工廠注重在產品的抽象關係，像扭蛋外觀和機台外觀，
是沒有關係的兩種物品，不過這兩種物品都屬於扭蛋機的裝備，因此他們就有了這層抽象關係。

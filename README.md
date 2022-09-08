# CoffeeShopConsoleAppNet60
## Coffee shop assignment 
### Goal: to have a recap at inheritance, override, abstract, interface and do some simple programming  

You are implementing a system for a coffeshop that support their business to keep track of the coffee orders. Until now the shop only sell one type of coffee and therefore only have one class named “coffee” in the It system. But now the owner wants to sell different kind of coffee e.g. Latte and Cortado etc. It’s your job to create and implements these new drinks in the system. 

The Coffee class has one public method “Price”, which returns the price of the coffee. It returns 20 (Danish kroner) 

Below are all the tasks that should be solved by you. 

### 1 Black coffee  
Create a new class “BlackCoffee” that inherit from the “Coffee” class. 

### 2 Latte 
Create a new class “Latte” that inherit from the “Coffee” class. 

The price of a latte is 40 dkr. So you have to override the Price method and return the new price. 

### 3 Cortado 
Create a new class “Cortado” that inherit from the “Coffee” class. 

The price of a Cortado is 25 dkr.  

### 4 Change the coffee class  

Because we now have these specialized classes it dosen’t make sense anymore to have an object of the coffee class.  

Make the coffee class abstract. 

Make an abstract method in the coffee class called “Strength”, it returns a string. Strength says how strong the coffee is and can have one of the values “Weak”, “Medium”, “Strong” 

Implement the method in the specialized classes and return the following values according to the schema below 

Coffee | Strength
------ | -------
BlackCoffee | Strong
Cortado | Medium
Latte | Weak

### 5 Create an interface 
The owner of the coffee shop would like to have a way to see how much ml of milk the milk drinks contains. 

Implement an interface called “IMilk” that tells how much milk the coffee have. The interface have one method “mlMilk” that returns an int.  

Implement the “Milk” interface at the “Cortado” and “Latte” class according to the schema below 

Coffee | MlMilk
------ | -------
Cortado | 40
Latte | 200

### 6 Add coffedrinks objects  
Now create some different coffee objects in the program file

Also create a list so it could consist of all off the coffee drinks. 

Foreach over the list and print out the price and strength for every object. 

### 7 Add a discount property 
The shop owner now wants a way to give discount then people order a coffee.  

Implement a property discount in the coffee class.  

Also implement a constructor at the coffee class to set the discount. 

Also implement the constructor at the specialized classes. 

The price method have to handle the discount for the coffee, so the price is correct 
If the discount is bigger than 5 kr. Raise an exception 


```mermaid
classDiagram
    Coffee <|-- BlackCoffee
    Coffee <|-- Latte
    Coffee <|-- Cortado
    Coffee : +int Price
    Coffee : +string Strength
    Coffee : +int Discount
    class IMlMilk{
    }
    Latte ..> IMlMilk
    Cortado ..> IMlMilk
    class Latte{
         +MlMilk()
    }
    class Cortado{
         +MlMilk()
    }
```

## Extra assignments:

### 8 extra Add only coffee with milks list  
Create a new list that only can consists of coffee with milk.  Which type should the list have? add some objects to the list. 

### 9 extra add more coffees 
Add one or more classes that inherit from the coffee class e.g. a “Flat White” 

### 10 extra extend the classes with more functionality 
Add one or more properties to the classes e.g. so that you have the possibility to decide which type of coffee blend your coffee should be brewed upon. For inspiration look at https://coffeecollective.dk/shop/ at espresso to see some different coffee blends. 

### 11 extra Add a Order class that can handles coffee orderes
The order class should have a the following properties e.g.:
-orderid
-name of the barista
-name of the customer
-tableid / take away (where should we serve the coffee) 
-list of all the ordered coffees
Add some methods that:
-count the total price of the order
-count the total of items in the order
-count the total of the discount in the order

### 12 extra Add a OrderSystem class that can handle multiple orders
Thik about what would be nice to put in this class

### 13 extra Not only milk
Add some functionality so that the customer can select different types of milk/Nonmilk e.g. "minimælk", "sødmælk", "havredrik", "soyadrik" etc. 
where should you place the logic to handle this ?- think about it before you code :-)



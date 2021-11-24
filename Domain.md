Printed Coding Exercise v. 1.1.3.pdf
Noted nouns and verbs as first step to determine object model

Users:
Customers
Marketing team

Nouns:
a prototype checkout system
current price catalog
products, items
regular price, effective price
promotions (limited time)
        On Sale price = a price less than the regular price
    Advanced:
        Group promotional price based on the quantity purchased
        Additional product discount
Quantity of specific product, an attribute of the customer basket or a promotion
Time for promotions and time of checkout
Customer’s basket
final total price
Latest pricing rules
    (current price catalog, promotions)
Itemized receipt
    (item, regular price, discount or saving, [effective price?]) + final total price

Inputs:
current price catalog
promotions
customer’s basket = a simple file containing *unsorted* list of items=products in which a product can be listed multiple times

Verbs:
Checkout
apply promotion
Calculate
Display
Print itemized receipt

Output
Itemized receipt
    (item, regular price, discount or saving, [effective price?]) + total price






# -------------
# anotations
# -------------
Users:
Customers
Marketing team

Nouns:
a prototype checkout system
current price catalog - dictionary for fast retreival.
products, items - object with name and amount
regular price, effective price - MoneyAmount
promotions (limited time)
        On Sale price = a price less than the regular price
    Advanced:
        Group promotional price based on the quantity purchased
        Additional product discount
Quantity of specific product, an attribute of the customer basket or a promotion
Time for promotions and time of checkout
Customer’s basket
final total price
Latest pricing rules
    (current price catalog, promotions)
Itemized receipt
    (item, regular price, discount or saving, [effective price?]) + final total price

Inputs:
current price catalog
promotions
customer’s basket = a simple file containing *unsorted* list of items=products in which a product can be listed multiple times

Verbs:
Checkout
apply promotion
Calculate
Display
Print itemized receipt

Output
Itemized receipt
    (item, regular price, discount or saving, [effective price?]) + total price
    
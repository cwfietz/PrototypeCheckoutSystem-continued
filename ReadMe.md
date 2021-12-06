## Notes:
Main menu choices:
1. Show product and prices list
2. Show promotions
3. Show customer basket
4. Calculate customer basket

Number 4. Prints a rough receipt 

## Limitations:
- At this time the first three menu items only allow the user to display. There is no option to edit yet.
- The promotions are shown in json format. They are not read from a file but stored in a GenerateSeedPromotions() method.
- There remain lots of opportunities to refactor.
- For example, the receipt output has many hardcoded field widths and many of the tests are
dependent on the receipt so many of the tests are fragile. A proper separation
of the contents and the output widths would be much better. Also not using hard
coded numbers in the LefPad() and RightPad() methods.

## Design choices:
- Using Json files as there are prebuilt modules (in this case Newtonsoft.Json) for handling the serialization and deserialization of json to data structures.
- Current price catalog and promotions as input text files rather than database engine data
- Used a dictionary for the Product Catalogue as it can be queried at O(1). I'd expect an actual catalogue to be very large.
- Used a sorted dictionary for sorting the basket as I do not expect the basket to be so large that O(n*log()n)) is too much of a cost and it provides the sorting.
- Used a list for the ProductReceiptEntries as the baskets has been sorted.
- Used a dictionary for the active promotions to speed up retreival time.
- No logging as I am not yet familiar with C#’s logging modules
- No consideration for translating amounts into other currencies. e.g. no translating into U.S.A. dollars.
- All time in local time as dates
    - events would otherwise be recorded in UTC - we make this assumption as the kiosks are in physical stores and the transactions aren’t happening all hours of the day possibly crossing midnight and therefore different dates.
    - Promotions change at the last minute but are assumed to be in effect only on given dates not during different hours or minutes of a day.

## Assumptions:
- Prices in dollars though ‘$’ can be replaced with other symbols
- Dollars and cents tenths and hundredths, rounded to hundredths, no parts of pennies.

- Each line of the customer’s basket file represents only one item, no instances of
    
    ```3 apples```

    only

    ```
    apple
    apple
    apple
    ```

- Lowest price (regular or effective) is zero. No negative prices.
- No sales that increase the prices.

## See:
    - Domain.md a list of the objects I considered.
    - Notes.md files for the notes to myself as I progressed through the project.


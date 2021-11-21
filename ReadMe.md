## Notes:
Main menue offers choice of:
1. Build product and prices list

## Limitations:
## Design choices:
- Rounding in GroceryCo’s favour
- All time in local time - events would otherwise be recorded in UTC - we make this assumption as the kiosks are in physical stores and the transactions aren’t happening all hours of the day possibly crossing midnight and therefore different dates.
Promotions change at the last minute but are assumed to be in effect only on given dates not during different hours or minutes of a day.
Future challenge: use UTC times for everything so as to make a promotion effective at a moment rather than a date.
- Current price catalog and promotions as input text files rather than database engine data
- Effective price listed on receipt even though it isn’t called for in the instructions
- No logging as I am not yet familiar with C#’s logging modules
No consideration for translating amounts into other currencies. e.g. no translating into U.S.A. dollars.

## Assumptions:
- Prices in dollars though ‘$’ can be replaced with other symbols
- Dollars and cents tenths and hundredths, rounded to hundredths, no parts of pennies.

- Each line of the customer’s basket file represents only one item, no instances of
    “3 apples”,

    only

    “
    apple
    apple
    apple
    ”

- Won’t use commas in customer basket file
- Width of receipt on paper fixed
- Lowest price (regular or effective) is zero. No negative prices.
- No sales that increase the prices.




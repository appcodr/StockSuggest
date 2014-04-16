StockSuggest
============

This Project shows the Navigation drawer menu sync problem with Backstack. 

Follow these steps to reproduce the problem.

1. Run the StockSuggest.Droid app
2. By default Home fragment would be shown. Navigate to "Picks" menu from the drawer menu
3. The Picks Fragment would be shown with 4 stocks. Now when you click the left drawer menu(using the hamburger icon on the action bar or sliding left) you will see that "Picks" item is selected
4. Now click the back option on the Android device or emulator and it would go to Home screen.
5. But the Navigation drawer would still show the "Picks" Item highlighted even though "Home" screen is shown.

Not sure how to sync Navigation drawer menu with the back stack. Any suggestions?

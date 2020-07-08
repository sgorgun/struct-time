# The Time Struct

## Task description
Design a *immutable* struct `Time` that represents the times in `24`-hours format without dates according to the following requirements.    
- The `Time` struct should have constructor with two integers parameters `hours` and `minutes`. 
    - Value of `hours` and `minutes` parameters can be any and are converted into the standard range for hours `(0..23)` and minutes `(0..59)`.
- The `Time` struct should have following properties.
    - `Hours` is a read-only `System.Int32` property that indicates hours in `24`-hours format and whose value is supplied by calling the `Time` constructor.
    - `Minutes` is a read-write `System.Int32` property that indicates minutes in `60`-minuts format and whose value is supplied by calling the `Time` constructor.
- The `Time` struct should have following methods:
    - A `ToString` method to return the information about time. For example, for the object with the values `Hours = 8, Minutes = 45`, method `ToString` should return following string "08:45".
-  For a detailed description of the `Time` struct, see test cases. 
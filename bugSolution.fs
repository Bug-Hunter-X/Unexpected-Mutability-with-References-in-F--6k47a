let mutable x = 10
// Using `&` creates a reference directly to the mutable variable `x`
let y = &x
!y <- 20 // Modifying the variable `x` through the reference `y`
printf "%d %d" x (!y) //prints 20 20

// Using `ref` creates a new reference cell that initially holds the value of `x`
let mutable x2 = 10
let y2 = ref x2
!y2 <- 20 // Modifying the value inside the reference cell `y2`
printf "%d %d" x2 (!y2) //prints 10 20

//Explanation:
//The & operator creates an alias that points to the memory location of the mutable variable.
//The ref keyword creates a new reference cell containing a copy of the value.  Changing the reference cell's value doesn't change the original variable.
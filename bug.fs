let mutable x = 10
let y = &x
!y <- 20
printf "%d" x //prints 20

//However if you try to do it this way
let mutable x = 10
let y = ref x
!y <- 20
printf "%d" x //prints 10
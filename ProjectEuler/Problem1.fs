module Problem1

// If we list all the natural numbers below 10 that are multiples of 3 or 5, we get 3, 5, 6 and 9. The sum of these multiples is 23.
// Find the sum of all the multiples of 3 or 5 below 1000.

let isDivisible n = 
    if (n % 3 = 0) || (n % 5 = 0) then 
        n 
    else 
        0

let rec sum list =
   match list with
   | head :: tail -> isDivisible head + sum tail
   | [] -> 0

let solve = 
   let list = [1 .. 999]
   let result = sum list
   printfn "Problem1 Answer: %d" result


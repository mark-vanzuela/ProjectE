module Problem2

let isEven n =
    if (n % 2I = 0I) then 
        n 
    else 
        0I

let fiboTailRec =
  let rec loop (n1,n2) acc =
    if n2 < 4000000I then
        loop (n1+n2,n1) (acc + isEven n2)
    else 
        acc
  loop (0I,1I) 0I


let solve =
    let result = fiboTailRec
    printfn "Problem2 Answer: %A" result


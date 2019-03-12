#light

module hw08

//
// sum4x1 L
//
// Given a list L of integers, computes sum(4x+1):x in L.
// Example: sum4x1 [3; 1; 2] => 27
// 
// NOTE: write this using a higher-order approach, in 
// particular using List.map and List.sum.  Do not use
// other List. functions.
// 

let helper x =
    (4*x + 1)

let sum4x1 L = 
    List.sum(List.map (fun x -> helper x) L)
    
    


#light

module hw08

//
// countBetween A B L
//
// Given a list L of integers, counts A < x < B : x in L.
// Example: countBetween 20 60 [20; 90; 50; 60; 45] => 2
// 
// NOTE: write this using a higher-order approach, in 
// particular using List.map and List.sum, or List.filter
// and List.length.  Do not use other List. functions.
// 

let checker A B e =
    if A < e && e < B then 1 else 0

let countBetween A B L = 
    List.sum(List.map (fun e -> checker A B e) L)

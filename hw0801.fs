#light

module hw08

//
// sum4x1 L
//
// Given a list L of integers, computes sum(4x+1):x in L.
// Example: sum4x1 [3; 1; 2] => 27
// 
// NOTE: write a tail-recursive version using a helper function;
// do not change the API of the original sum4x1 function.
// 
let sum4x1 L = 
    let rec _sum L sum = 
        match L with
        | [] -> sum
        | e::tail -> _sum tail ((e*4 + 1) + sum)
    _sum L 0 
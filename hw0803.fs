#light

module hw08

//
// countBetween A B L
//
// Given a list L of integers, counts A < x < B : x in L.
// Example: countBetween 20 60 [20; 90; 50; 60; 45] => 2
// 
// NOTE: write a tail-recursive version using a helper function;
// do not change the API of the original countBetween function.
// 



let countBetween A B L = 
    let rec _countBetween A B L sum = 
        match L with
        | [] -> sum
        | e::tail when A < e && e < B -> _countBetween A B tail (sum+1)
        | e::tail ->_countBetween A B tail sum
    _countBetween A B L 0
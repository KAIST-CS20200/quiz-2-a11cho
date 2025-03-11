module CS220.Quiz1.Math

open System

/// Modify the function `collatz` in such a way that the function takes in a
/// 32-bit integer, and returns the number of steps it takes to reach 1 in the
/// Collatz sequence.
let collatz n =
  let n = uint64 n
  let rec col (n:uint64) = 
      if n = uint64 1 then uint64 0
      else if (( n % (uint64 2) ) = uint64 0 )then col (n/(uint64 2)) + uint64 1
      else col ((uint64 3)*n+(uint64 1)) + uint64 1
  col n |> int32

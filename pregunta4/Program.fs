// Learn more about F# at http://fsharp.org

open System

[<EntryPoint>]
let main argv =
    


    let listSuma=[for i in 1..5 ->4]
    let suma=List.sum listSuma
    printf "%A" suma
    
  
    


    Console.ReadKey() |>ignore
    0 // return an integer exit code
   
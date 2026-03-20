open System


//Номер 1 

let rec getlist() = 
    let s = Console.ReadLine()
    if String.IsNullOrWhiteSpace(s) then 
        []
    else 
        
        if Char.IsDigit(s.[0]) then 
            let n = int s
            if n >= 1 && n <= 7 then
                n :: getlist()
            else
                printfn "Ошибка"
                getlist()
        else
            printfn "Ошибка" 
            getlist()

let toDayName n = 
    match n with

    | 1 -> "Понедельник"
    | 2 -> "Вторник"
    | 3 -> "Среда"

    | 4 -> "Четверг"
    | 5 -> "Пятница"
    | 6 -> "Суббота"

    | 7 -> "Воскресенье"
    | _ -> "Неизвестно"

[<EntryPoint>]
let main argv = 
    printfn "Вводите числа от 1 до 7 :"
    
    let numbers = getlist()
    let dayNames = numbers |> List.map toDayName

    printfn "Исходные числа: %A" numbers
    printfn "Дни недели: %A" dayNames

    0

//Номер 2 


(*
let countWithKDigits k numbers =
    numbers 

    |> List.fold (fun acc x -> 
        if (string x).Length = k then acc + 1 else acc) 0

[<EntryPoint>]
let main argv =
    printfn "Введите числа через пробел:"
    let input = Console.ReadLine().Split(' ') |> Array.toList |> List.map int
    
    printfn "Введите число k (количество цифр):"
    let k = Console.ReadLine() |> int
    
    let result = countWithKDigits k input
    
    printfn "Количество чисел, содержащих %d цифр: %d" k result
    0
*)

  
open System

type ExitCode =
    | SUCCESS = 0
    | FAILURE = 1

[<EntryPoint>]
let main (_argv: string array) : int =
    try
        let mutable stdinVal = Console.ReadLine()
        let mutable res = 0

        while stdinVal <> null && not (String.IsNullOrEmpty stdinVal) do
            res <- res + (int stdinVal)
            stdinVal <- Console.ReadLine()

        printfn "The result is %i" res
        ExitCode.SUCCESS |> int
    with exn ->
        eprintfn "An exception was triggered: %A" exn
        ExitCode.FAILURE |> int

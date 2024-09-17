module Main

open System
open DataWrangle

[<EntryPoint>]
let main (args : string[]) =
    if args.Length < 2 then 1   
    else
        let clientDataPath = args[0]
        let claimDataPath = args[1]
        let result = wrangleClientData clientDataPath // eg "./Data/Clients_20240912.csv"
        let result = wrangleClaimData  claimDataPath // eg "./Data/Claims_20240912.csv"

        0
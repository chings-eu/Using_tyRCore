#if INTERACTIVE
#I @"../../lib"
#load @"ui.fs"
#endif

namespace tyR.create

open Autodesk.Revit.UI
open Autodesk.Revit.DB
open Autodesk.Revit.Attributes

[<Regeneration(RegenerationOption.Manual)>]
[<TransactionAttribute(TransactionMode.Manual)>]
/// <summary>
/// Here write your summary
/// </summary>
type ``Instantly``() as this =
    interface IExternalCommand with
        override x.Execute(cdata, msg, elset) =
            // Write your code
            TaskDialog.Show("Respond", sprintf $"{this} is running.") |> ignore
            Result.Succeeded
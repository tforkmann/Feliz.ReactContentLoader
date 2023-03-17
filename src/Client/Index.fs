module Index

open System
open Elmish
open Fable.React
open Feliz
open Feliz.ReactContentLoader
open Browser.Dom

type Model = { Number: int }

type Msg = | Add



let init () = { Number = 1 }, Cmd.none




let update msg (model: Model) =
    match msg with
    | Add -> { model with Number = model.Number + 1 }, Cmd.none

[<ReactComponent>]
let Counter
    (props:
        {|
            data: {| label: string |}
            isConnectable: bool
        |})
    ()
    =
    let (count, setCount) = React.useState (0)

    Html.div [
        prop.style [ style.padding 10 ]
        prop.children [
            Html.button [
                prop.style [ style.marginRight 5 ]
                prop.onClick (fun _ -> setCount (count + 1))
                prop.text "Increment"
            ]
            Html.text props.data.label
            Html.text count
        ]
    ]


let view (model: Model) (dispatch: Msg -> unit) =
    let gridSize = 20

    Html.div [
        prop.style [ Feliz.style.height 800 ]
        prop.children [
            ReactContentLoader.contentLoader [
                ReactContentLoader.speed 3.
                ReactContentLoader.title "Test"
                ReactContentLoader.interval 0.9
                ReactContentLoader.children [
                    Svg.rect [
                        svg.x 0.
                        svg.y 0.
                        svg.rx 5.
                        svg.ry 5.
                        svg.width 70
                        svg.height 70
                    ]
                    Svg.rect [
                        svg.x 80.
                        svg.y 17.
                        svg.rx 4.
                        svg.ry 4.
                        svg.width 300
                        svg.height 13
                    ]
                    Svg.rect [
                        svg.x 80.
                        svg.y 40.
                        svg.rx 3.
                        svg.ry 3.
                        svg.width 250
                        svg.height 10
                    ]
                ]
            ]
        ]
    ]

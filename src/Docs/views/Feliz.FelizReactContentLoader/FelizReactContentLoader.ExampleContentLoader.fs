module Views.ExampleFlow

open Fable.React
open Browser.Dom
open Feliz
open Feliz.Bulma
open Feliz.ReactContentLoader
open Shared

[<ReactComponent>]
let Counter() =
    let (count, setCount) = React.useState(0)
    Html.div [
        prop.style [ style.padding 10 ]
        prop.children [
            ReactContentLoader.handle [
                handle.``type`` Target
                handle.position Top
            ]
            Html.button [
                prop.style [ style.marginRight 5 ]
                prop.onClick (fun _ -> setCount(count + 1))
                prop.text "Increment"
            ]
            Html.text count
        ]
    ]

let flowChart =
    div [ Props.Style [
              Props.CSSProp.Height 150
          ] ] [
          ReactContentLoader.flowChart [
            ReactContentLoader.nodeTypes {| test = Counter |}
            ReactContentLoader.elements [|
                ReactContentLoader.node [
                    node.id "1"
                    node.nodetype Input
                    node.data {| label = "Erdgas Einsatz" |}
                    node.style [
                        style.background "yellow"
                        style.color "#332"
                        style.border "1px solid #222138"
                        style.width 180
                    ]
                    node.position (20, 5)
                ]
                ReactContentLoader.node [
                    node.id "2"
                    node.nodetype Default
                    node.data {| label = "CityCube" |}
                    node.style [
                        style.background "#2e88c9"
                        style.color "white"
                        style.border "1px solid #222138"
                        style.width 180
                    ]
                    node.position (250, 15)
                ]
                ReactContentLoader.node [
                    node.id "3"
                    node.nodetype Output
                    node.data {| label = "Strom Absatz" |}
                    node.style [
                        style.background "lightblue"
                        style.color "#333"
                        style.border "1px solid #222138"
                        style.width 180
                    ]
                    node.position (100, 100)
                ]
                ReactContentLoader.node [
                    node.id "4"
                    node.nodetype Output
                    node.data {| label = "Wärme Absatz" |}
                    node.style [
                        style.background "red"
                        style.color "white"
                        style.border "1px solid #222138"
                        style.width 180
                    ]
                    node.position (100, 100)
                ]
                ReactContentLoader.node [
                    node.id "5"
                    node.nodetype (Custom "test")
                    node.data {| label = "Test" |}
                    node.position (50, 120)
                    node.style [
                        style.background "lightgreen"
                        style.border "1px solid black"
                        style.width 180
                    ]
                ]
                ReactContentLoader.edge [
                    edge.id "e1-2"
                    edge.source "1"
                    edge.target "2"
                    edge.animated false
                    edge.label "100 MWh"
                    edge.edgeType SmoothStep
                    edge.arrowHeadType ArrowClosed
                    edge.style [ style.stroke "yellow" ]
                    edge.labelStyle [
                        labelStyle.fill "black"
                        labelStyle.fontWeight 700
                    ]
                ]
                ReactContentLoader.edge [
                    edge.id "e2-3"
                    edge.source "2"
                    edge.target "3"
                    edge.animated true
                    edge.label "50 MWh"
                    edge.edgeType SmoothStep
                    edge.arrowHeadType ArrowClosed
                    edge.style [ style.stroke "blue" ]
                    edge.labelStyle [
                        labelStyle.fill "blue"
                        labelStyle.fontWeight 700
                    ]
                ]
                ReactContentLoader.edge [
                    edge.id "e2-4"
                    edge.source "2"
                    edge.target "4"
                    edge.animated true
                    edge.label "55 MWh"
                    edge.edgeType SmoothStep
                    edge.arrowHeadType ArrowClosed
                    edge.style [ style.stroke "red" ]
                    edge.labelStyle [
                        labelStyle.fill "red"
                        labelStyle.fontWeight 700
                    ]
                ]
            |]
            ReactContentLoader.onElementClick
                (fun ev element ->
                    console.log element
                    window.alert "You clicked me!")
            ReactContentLoader.onNodeDragStop
                (fun ev node ->
                    console.log node
                    window.alert "You dragged me!")
            ReactContentLoader.onElementsRemove
                (fun elements ->
                    console.log elements
                    window.alert "You removed me!")
            ReactContentLoader.onConnect
                (fun element ->
                    console.log element
                    window.alert "You connected me!")
            ReactContentLoader.onConnectStart
                (fun ev element ->
                    console.log element
                    window.alert "You started to connect me!")
        ]
          ]

let overview =
    Html.div
        [ Bulma.title.h1 [ Html.text "Feliz.ReactContentLoader Example" ]
          Bulma.content
              [ Html.p "Here is an example how to use ReactContentLoader"
                flowChart
                code """
                ReactContentLoader.flowChart [
                    ReactContentLoader.elements [|
                        ReactContentLoader.node [
                            node.id "1"
                            node.nodetype Input
                            node.data {| label = "Erdgas Einsatz" |}
                            node.style [
                                style.background "yellow"
                                style.color "#332"
                                style.border "1px solid #222138"
                                style.width 180
                            ]
                            node.position (20, 5)
                        ]
                        ReactContentLoader.node [
                            node.id "2"
                            node.nodetype Default
                            node.data {| label = "CityCube" |}
                            node.style [
                                style.background "#2e88c9"
                                style.color "white"
                                style.border "1px solid #222138"
                                style.width 180
                            ]
                            node.position (250, 5)
                        ]
                        ReactContentLoader.node [
                            node.id "3"
                            node.nodetype Output
                            node.data {| label = "Strom Absatz" |}
                            node.style [
                                style.background "lightblue"
                                style.color "#333"
                                style.border "1px solid #222138"
                                style.width 180
                            ]
                            node.position (100, 100)
                        ]
                        ReactContentLoader.node [
                            node.id "4"
                            node.nodetype Output
                            node.data {| label = "Wärme Absatz" |}
                            node.style [
                                style.background "red"
                                style.color "white"
                                style.border "1px solid #222138"
                                style.width 180
                            ]
                            node.position (100, 100)
                        ]
                        ReactContentLoader.edge [
                            edge.id "e1-2"
                            edge.source "1"
                            edge.target "2"
                            edge.animated false
                            edge.label "100 MWh"
                            edge.edgeType SmoothStep
                            edge.arrowHeadType ArrowClosed
                            edge.style [ style.stroke "yellow" ]
                            edge.labelStyle [
                                labelStyle.fill "black"
                                labelStyle.fontWeight 700
                            ]
                        ]
                        ReactContentLoader.edge [
                            edge.id "e2-3"
                            edge.source "2"
                            edge.target "3"
                            edge.animated true
                            edge.label "50 MWh"
                            edge.edgeType SmoothStep
                            edge.arrowHeadType ArrowClosed
                            edge.style [ style.stroke "blue" ]
                            edge.labelStyle [
                                labelStyle.fill "blue"
                                labelStyle.fontWeight 700
                            ]
                        ]
                        ReactContentLoader.edge [
                            edge.id "e2-4"
                            edge.source "2"
                            edge.target "4"
                            edge.animated true
                            edge.label "55 MWh"
                            edge.edgeType SmoothStep
                            edge.arrowHeadType ArrowClosed
                            edge.style [ style.stroke "red" ]
                            edge.labelStyle [
                                labelStyle.fill "red"
                                labelStyle.fontWeight 700
                            ]
                        ]
                    |]
                    ReactContentLoader.onElementClick
                        (fun (x, y) ->
                            console.log y
                            window.alert "You clicked me!")
                    ReactContentLoader.onNodeDragStop
                        (fun (x, y) ->
                            console.log y
                            window.alert "You dragged me!")
                    ReactContentLoader.onElementsRemove
                        (fun (x, y) ->
                            console.log y
                            window.alert "You removed me!")
                    ReactContentLoader.onConnect
                        (fun (x, y) ->
                            console.log y
                            window.alert "You connected me!")
                    ReactContentLoader.onConnectStart
                        (fun (x, y) ->
                            console.log y
                            window.alert "You started to connect me!")
                ]
                """ ]
          fixDocsView "FelizReactContentLoader.ExampleFlow" false      ]


// https://github.com/tforkmann/Feliz.ReactContentLoader/blob/main/src/Docs/views/Feliz.ReactContentLoader/FelizReact.ExampleFlow.fs
// https://github.com/tforkmann/Feliz.ReactContentLoader/blob/main/src/Docs/views/Feliz.ReactContentLoader/FelizReactContentLoader.ExampleFlow.fs
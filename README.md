# Feliz Binding for [ReactContentLoader](https://github.com/danilowoz/react-content-loader)

[![Feliz.ReactContentLoader on Nuget](https://buildstats.info/nuget/Feliz.ReactContentLoader)](https://www.nuget.org/packages/Feliz.ReactContentLoader/)
[![Client](https://github.com/tforkmann/Feliz.ReactContentLoader/actions/workflows/Docs.yml/badge.svg)](https://github.com/tforkmann/Feliz.ReactContentLoader/actions/workflows/Docs.yml)

## Installation
Install the nuget package
```
dotnet paket add Feliz.ReactContentLoader
```

and install the npm package

```
npm install --save react-content-loader
```

or use Femto:
```
femto install Feliz.ReactContentLoader
```

## Start test app

- Start your test app by cloning this repository and then execute:
```
dotnet run
```

## Example ReactContentLoader
Here is an example ReactContentLoader
```fs
div [ Props.Style [
              Props.CSSProp.Height 1000
          ] ] [
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
                    node.position (50, 30)
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
                    node.position (400, 30)
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
                    node.position (300, 200)
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
                    node.position (500, 200)
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
                    edge.style [ style.stroke "blue" ]
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
                ReactContentLoader.edge [
                    edge.id "e1-5"
                    edge.source "1"
                    edge.target "5"
                    edge.edgeType SmoothStep
                    edge.style [ style.stroke "black" ]
                ]
            |]
            ReactContentLoader.onElementClick
                (fun ev element ->
                    console.log ev
                    window.alert "You clicked me!")
            ReactContentLoader.onNodeDragStop
                (fun ev node ->
                    console.log ev
                    window.alert "You dragged me!")
            ReactContentLoader.onElementsRemove
                (fun elements ->
                    console.log elements
                    window.alert "You removed me!")
            ReactContentLoader.onConnect
                (fun ev ->
                    console.log ev
                    window.alert "You connected me!")
            ReactContentLoader.onConnectStart
                (fun ev nodeId ->
                    console.log ev
                    window.alert "You started to connect me!")
        ]
    ]
```

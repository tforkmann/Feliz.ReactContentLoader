module Docs.Pages.ReactContentLoaderView

open Feliz
open Feliz.Bulma
open Feliz.ReactContentLoader
open Docs.SharedView

[<ReactComponent>]
let ReactContentLoader () =
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

let ReactContentLoaderExample =
    Html.div [
        prop.style [ style.height 800 ]
        prop.children [
            ReactContentLoader()
        ]
    ]


let code =
    """
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
    """

let title = Html.text "QR Code"

[<ReactComponent>]
let ReactContentLoaderView () =
    Html.div [
        Bulma.content [
            codedView title code ReactContentLoaderExample
        ]
        fixDocsView "ReactContentLoader" false
    ]

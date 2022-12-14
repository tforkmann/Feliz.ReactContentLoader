module Views.FelizReactContentLoader

open Feliz
open Feliz.Bulma
open Fable.React
open Feliz.ReactContentLoader
open Browser.Dom


let overview =
    Html.div [
        Bulma.title.h1 [
            Html.text "Feliz.ReactContentLoader - Documentation"
            Html.a [
                prop.href "https://www.nuget.org/packages/Feliz.ReactContentLoader/"
                prop.children [
                    Html.img [
                        prop.src "https://img.shields.io/nuget/v/Feliz.ReactContentLoader.svg?style=flat"
                    ]
                ]
            ]
        ]
        Bulma.subtitle.h2 [
            Html.text "Feliz bindings for ReactContentLoader."
        ]
        Html.hr [
          ]
        // Bulma.content [
        //     Bulma.title.h4 "Features"
        //     Html.ul [
        //         Html.li "column interactions (resize, reorder and pin columns="
        //         Html.li "Pagination"
        //         Html.li "Sorting"
        //         Html.li "Row selection"
        //         Html.li "Data export"
        //     ]
        // ]
        Shared.fixDocsView "FelizReactContentLoader" false
    ]

let installation = Shared.installationView "Feliz.ReactContentLoader"

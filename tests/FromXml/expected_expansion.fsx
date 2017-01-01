
#if INTERACTIVE
#load @"../../templates/FromXml/FromXml_Base.fsx"
#load @"../../templates/FromXml/FromXml_Expander.fsx"
#load @"source_types.fsx"
#endif

(*
 * This file was auto-generated by the TypeExpansion type provider
 *
 * The contents of this file are likely to be overwritten at any time while
 * Visual Studio or F# Interactive is open, or while a build is in progress.
 *
 * Please do not make important changes to this file.
 *)

namespace Amazingant.FSharp.TypeExpansion.Templates.FromXml.Tests
    [<AutoOpen>]
    module Node_FromXml_Extensions =

        open Amazingant.FSharp.TypeExpansion.Templates.FromXml
        open System.Linq
        open System.Xml

        type Node with
            static member FromXmlNode (xml : XmlNode) : Node =
                let children = Enumerable.Cast<XmlNode> xml.ChildNodes
                let xmlAttrs = Enumerable.Cast<XmlAttribute> xml.Attributes
                let ``field`` = findEither children xmlAttrs "field"
                {
                    ``Field`` = ``field``;
                }

            static member FromXmlDoc doc = thingFromDocElement doc "node" Node.FromXmlNode
            static member FromXmlDoc xml = thingFromStringElement xml "node" Node.FromXmlNode


namespace Amazingant.FSharp.TypeExpansion.Templates.FromXml.Tests
    [<AutoOpen>]
    module NodeOpt_FromXml_Extensions =

        open Amazingant.FSharp.TypeExpansion.Templates.FromXml
        open System.Linq
        open System.Xml

        type NodeOpt with
            static member FromXmlNode (xml : XmlNode) : NodeOpt =
                let children = Enumerable.Cast<XmlNode> xml.ChildNodes
                let xmlAttrs = Enumerable.Cast<XmlAttribute> xml.Attributes
                let ``field`` = findEither children xmlAttrs "field"
                {
                    ``Field`` = ``field``;
                }

            static member FromXmlDoc doc = thingFromDocElement doc "node_opt" NodeOpt.FromXmlNode
            static member FromXmlDoc xml = thingFromStringElement xml "node_opt" NodeOpt.FromXmlNode


namespace Amazingant.FSharp.TypeExpansion.Templates.FromXml.Tests
    [<AutoOpen>]
    module NodeColl_FromXml_Extensions =

        open Amazingant.FSharp.TypeExpansion.Templates.FromXml
        open System.Linq
        open System.Xml

        type NodeColl with
            static member FromXmlNode (xml : XmlNode) : NodeColl =
                let children = Enumerable.Cast<XmlNode> xml.ChildNodes
                let xmlAttrs = Enumerable.Cast<XmlAttribute> xml.Attributes
                let ``field`` = findEither children xmlAttrs "field"
                {
                    ``Field`` = ``field``;
                }

            static member FromXmlDoc doc = thingFromDocElement doc "node_coll" NodeColl.FromXmlNode
            static member FromXmlDoc xml = thingFromStringElement xml "node_coll" NodeColl.FromXmlNode


namespace Amazingant.FSharp.TypeExpansion.Templates.FromXml.Tests
    [<AutoOpen>]
    module NodeOptColl_FromXml_Extensions =

        open Amazingant.FSharp.TypeExpansion.Templates.FromXml
        open System.Linq
        open System.Xml

        type NodeOptColl with
            static member FromXmlNode (xml : XmlNode) : NodeOptColl =
                let children = Enumerable.Cast<XmlNode> xml.ChildNodes
                let xmlAttrs = Enumerable.Cast<XmlAttribute> xml.Attributes
                let ``field`` = findEither children xmlAttrs "field"
                {
                    ``Field`` = ``field``;
                }

            static member FromXmlDoc doc = thingFromDocElement doc "node_opt_coll" NodeOptColl.FromXmlNode
            static member FromXmlDoc xml = thingFromStringElement xml "node_opt_coll" NodeOptColl.FromXmlNode


namespace Amazingant.FSharp.TypeExpansion.Templates.FromXml.Tests
    [<AutoOpen>]
    module Path_FromXml_Extensions =

        open Amazingant.FSharp.TypeExpansion.Templates.FromXml
        open System.Linq
        open System.Xml

        type Path with
            static member FromXmlNode (xml : XmlNode) : Path =
                let children = Enumerable.Cast<XmlNode> xml.ChildNodes
                let xmlAttrs = Enumerable.Cast<XmlAttribute> xml.Attributes
                let ``field`` = findEither children xmlAttrs "field"
                {
                    ``Field`` = ``field``;
                }

            static member FromXmlDoc doc = thingFromDocXPath doc "xpath/path" Path.FromXmlNode
            static member FromXmlDoc xml = thingFromStringXPath xml "xpath/path" Path.FromXmlNode


namespace Amazingant.FSharp.TypeExpansion.Templates.FromXml.Tests
    [<AutoOpen>]
    module PathOpt_FromXml_Extensions =

        open Amazingant.FSharp.TypeExpansion.Templates.FromXml
        open System.Linq
        open System.Xml

        type PathOpt with
            static member FromXmlNode (xml : XmlNode) : PathOpt =
                let children = Enumerable.Cast<XmlNode> xml.ChildNodes
                let xmlAttrs = Enumerable.Cast<XmlAttribute> xml.Attributes
                let ``field`` = findEither children xmlAttrs "field"
                {
                    ``Field`` = ``field``;
                }

            static member FromXmlDoc doc = thingFromDocXPath doc "xpath/path_opt" PathOpt.FromXmlNode
            static member FromXmlDoc xml = thingFromStringXPath xml "xpath/path_opt" PathOpt.FromXmlNode


namespace Amazingant.FSharp.TypeExpansion.Templates.FromXml.Tests
    [<AutoOpen>]
    module PathColl_FromXml_Extensions =

        open Amazingant.FSharp.TypeExpansion.Templates.FromXml
        open System.Linq
        open System.Xml

        type PathColl with
            static member FromXmlNode (xml : XmlNode) : PathColl =
                let children = Enumerable.Cast<XmlNode> xml.ChildNodes
                let xmlAttrs = Enumerable.Cast<XmlAttribute> xml.Attributes
                let ``field`` = findEither children xmlAttrs "field"
                {
                    ``Field`` = ``field``;
                }

            static member FromXmlDoc doc = thingFromDocXPath doc "xpath/path_coll" PathColl.FromXmlNode
            static member FromXmlDoc xml = thingFromStringXPath xml "xpath/path_coll" PathColl.FromXmlNode


namespace Amazingant.FSharp.TypeExpansion.Templates.FromXml.Tests
    [<AutoOpen>]
    module PathOptColl_FromXml_Extensions =

        open Amazingant.FSharp.TypeExpansion.Templates.FromXml
        open System.Linq
        open System.Xml

        type PathOptColl with
            static member FromXmlNode (xml : XmlNode) : PathOptColl =
                let children = Enumerable.Cast<XmlNode> xml.ChildNodes
                let xmlAttrs = Enumerable.Cast<XmlAttribute> xml.Attributes
                let ``field`` = findEither children xmlAttrs "field"
                {
                    ``Field`` = ``field``;
                }

            static member FromXmlDoc doc = thingFromDocXPath doc "xpath/path_opt_coll" PathOptColl.FromXmlNode
            static member FromXmlDoc xml = thingFromStringXPath xml "xpath/path_opt_coll" PathOptColl.FromXmlNode


namespace Amazingant.FSharp.TypeExpansion.Templates.FromXml.Tests
    [<AutoOpen>]
    module TestFields_FromXml_Extensions =

        open Amazingant.FSharp.TypeExpansion.Templates.FromXml
        open System.Linq
        open System.Xml

        type TestFields with
            static member FromXmlNode (xml : XmlNode) : TestFields =
                let children = Enumerable.Cast<XmlNode> xml.ChildNodes
                let xmlAttrs = Enumerable.Cast<XmlAttribute> xml.Attributes
                let ``simplestring`` = findEither children xmlAttrs "simplestring"
                let ``maybestring`` = tryFindEither children xmlAttrs "maybestring"
                let ``stringlist`` = findAllEither children xmlAttrs "stringlist" |> Seq.toArray |> Array.toList
                let ``stringarray`` = findAllEither children xmlAttrs "stringarray" |> Seq.toArray
                let ``stringseq`` = findAllEither children xmlAttrs "stringseq" |> Seq.toArray |> Array.toSeq
                let ``maybestringlist`` =
                    let xs = findAllEither children xmlAttrs "maybestringlist" |> Seq.toArray
                    if xs.Length = 0 then None
                    else xs |> Array.toList |> Some
                let ``maybestringarray`` =
                    let xs = findAllEither children xmlAttrs "maybestringarray" |> Seq.toArray
                    if xs.Length = 0 then None
                    else xs |> Some
                let ``maybestringseq`` =
                    let xs = findAllEither children xmlAttrs "maybestringseq" |> Seq.toArray
                    if xs.Length = 0 then None
                    else xs |> Array.toSeq |> Some
                let ``simplefield`` = findEither children xmlAttrs "simplefield" |> (parse System.Int32.TryParse "simplefield")
                let ``maybefield`` = tryFindEither children xmlAttrs "maybefield" |> (tryParse System.Int32.TryParse "maybefield")
                let ``fieldlist`` = findAllEither children xmlAttrs "fieldlist" |> Seq.map (parse System.Int32.TryParse "fieldlist") |> Seq.toArray |> Array.toList
                let ``fieldarray`` = findAllEither children xmlAttrs "fieldarray" |> Seq.map (parse System.Int32.TryParse "fieldarray") |> Seq.toArray
                let ``fieldseq`` = findAllEither children xmlAttrs "fieldseq" |> Seq.map (parse System.Int32.TryParse "fieldseq") |> Seq.toArray |> Array.toSeq
                let ``maybefieldlist`` =
                    let xs = findAllEither children xmlAttrs "maybefieldlist" |> Seq.toArray
                    if xs.Length = 0 then None
                    else xs |> Array.map (parse System.Int32.TryParse "maybefieldlist") |> Array.toList |> Some
                let ``maybefieldarray`` =
                    let xs = findAllEither children xmlAttrs "maybefieldarray" |> Seq.toArray
                    if xs.Length = 0 then None
                    else xs |> Array.map (parse System.Int32.TryParse "maybefieldarray") |> Some
                let ``maybefieldseq`` =
                    let xs = findAllEither children xmlAttrs "maybefieldseq" |> Seq.toArray
                    if xs.Length = 0 then None
                    else xs |> Array.map (parse System.Int32.TryParse "maybefieldseq") |> Array.toSeq |> Some
                let ``simplexpathstring`` = xml.SelectSingleNode("string").InnerText
                let ``maybexpathstring`` = xml.SelectSingleNode("string_opt") |> tryInnerText
                let ``xpathstringlist`` = xml.SelectNodes("string_coll") |> getInnerTexts |> Seq.toArray |> Array.toList
                let ``xpathstringarray`` = xml.SelectNodes("string_coll") |> getInnerTexts |> Seq.toArray
                let ``xpathstringseq`` = xml.SelectNodes("string_coll") |> getInnerTexts |> Seq.toArray |> Array.toSeq
                let ``maybexpathstringlist`` =
                    let xs = xml.SelectNodes("string_opt_coll") |> getInnerTexts |> Seq.toArray
                    if xs.Length = 0 then None
                    else xs |> Array.toList |> Some
                let ``maybexpathstringarray`` =
                    let xs = xml.SelectNodes("string_opt_coll") |> getInnerTexts |> Seq.toArray
                    if xs.Length = 0 then None
                    else xs |> Some
                let ``maybexpathstringseq`` =
                    let xs = xml.SelectNodes("string_opt_coll") |> getInnerTexts |> Seq.toArray
                    if xs.Length = 0 then None
                    else xs |> Array.toSeq |> Some
                let ``simplexpathfield`` =
                    xml.SelectSingleNode("int").InnerText
                    |> (parse System.Int32.TryParse "simplexpathfield")
                let ``maybexpathfield`` =
                    xml.SelectSingleNode("int_opt")
                    |> tryInnerText
                    |> (tryParse System.Int32.TryParse "maybexpathfield")
                let ``xpathfieldlist`` =
                    xml.SelectNodes("int_coll")
                    |> getInnerTexts
                    |> Seq.map (parse System.Int32.TryParse "xpathfieldlist")
                    |> Seq.toArray |> Array.toList
                let ``xpathfieldarray`` =
                    xml.SelectNodes("int_coll")
                    |> getInnerTexts
                    |> Seq.map (parse System.Int32.TryParse "xpathfieldarray")
                    |> Seq.toArray
                let ``xpathfieldseq`` =
                    xml.SelectNodes("int_coll")
                    |> getInnerTexts
                    |> Seq.map (parse System.Int32.TryParse "xpathfieldseq")
                    |> Seq.toArray |> Array.toSeq
                let ``maybexpathfieldlist`` =
                    let xs = xml.SelectNodes("int_opt_coll") |> getInnerTexts |> Seq.toArray
                    if xs.Length = 0 then None
                    else xs |> Array.map (parse System.Int32.TryParse "maybexpathfieldlist") |> Array.toList |> Some
                let ``maybexpathfieldarray`` =
                    let xs = xml.SelectNodes("int_opt_coll") |> getInnerTexts |> Seq.toArray
                    if xs.Length = 0 then None
                    else xs |> Array.map (parse System.Int32.TryParse "maybexpathfieldarray") |> Some
                let ``maybexpathfieldseq`` =
                    let xs = xml.SelectNodes("int_opt_coll") |> getInnerTexts |> Seq.toArray
                    if xs.Length = 0 then None
                    else xs |> Array.map (parse System.Int32.TryParse "maybexpathfieldseq") |> Array.toSeq |> Some
                let ``simplenodestring`` = find children "string"
                let ``maybenodestring`` = tryFind children "string_opt"
                let ``nodestringlist`` = findAll children "string_coll" |> Seq.toArray |> Array.toList
                let ``nodestringarray`` = findAll children "string_coll" |> Seq.toArray
                let ``nodestringseq`` = findAll children "string_coll" |> Seq.toArray |> Array.toSeq
                let ``maybenodestringlist`` =
                    let xs = findAll children "string_opt_coll" |> Seq.toArray
                    if xs.Length = 0 then None
                    else xs |> Array.toList |> Some
                let ``maybenodestringarray`` =
                    let xs = findAll children "string_opt_coll" |> Seq.toArray
                    if xs.Length = 0 then None
                    else xs |> Some
                let ``maybenodestringseq`` =
                    let xs = findAll children "string_opt_coll" |> Seq.toArray
                    if xs.Length = 0 then None
                    else xs |> Array.toSeq |> Some
                let ``simplenodefield`` =
                    find children "int"
                    |> (parse System.Int32.TryParse "int")
                let ``maybenodefield`` =
                    tryFind children "int_opt"
                    |> (tryParse System.Int32.TryParse "int_opt")
                let ``nodefieldlist`` =
                    findAll children "int_coll"
                    |> Seq.toArray
                    |> Array.map (parse System.Int32.TryParse "int_coll") |> Array.toList
                let ``nodefieldarray`` =
                    findAll children "int_coll"
                    |> Seq.toArray
                    |> Array.map (parse System.Int32.TryParse "int_coll")
                let ``nodefieldseq`` =
                    findAll children "int_coll"
                    |> Seq.toArray
                    |> Array.map (parse System.Int32.TryParse "int_coll") |> Array.toSeq
                let ``maybenodefieldlist`` =
                    let xs = findAll children "int_opt_coll" |> Seq.toArray
                    if xs.Length = 0 then None
                    else xs |> Array.map (parse System.Int32.TryParse "int_opt_coll") |> Array.toList |> Some
                let ``maybenodefieldarray`` =
                    let xs = findAll children "int_opt_coll" |> Seq.toArray
                    if xs.Length = 0 then None
                    else xs |> Array.map (parse System.Int32.TryParse "int_opt_coll") |> Some
                let ``maybenodefieldseq`` =
                    let xs = findAll children "int_opt_coll" |> Seq.toArray
                    if xs.Length = 0 then None
                    else xs |> Array.map (parse System.Int32.TryParse "int_opt_coll") |> Array.toSeq |> Some
                let ``simpleattrstring`` = findAttr xmlAttrs "string"
                let ``maybeattrstring`` = tryFindAttr xmlAttrs "string_opt"
                let ``attrstringlist`` = findAllAttr xmlAttrs "string_coll" |> Seq.toArray |> Array.toList
                let ``attrstringarray`` = findAllAttr xmlAttrs "string_coll" |> Seq.toArray
                let ``attrstringseq`` = findAllAttr xmlAttrs "string_coll" |> Seq.toArray |> Array.toSeq
                let ``maybeattrstringlist`` =
                    let xs = findAllAttr xmlAttrs "string_opt_coll" |> Seq.toArray
                    if xs.Length = 0 then None
                    else xs |> Array.toList |> Some
                let ``maybeattrstringarray`` =
                    let xs = findAllAttr xmlAttrs "string_opt_coll" |> Seq.toArray
                    if xs.Length = 0 then None
                    else xs |> Some
                let ``maybeattrstringseq`` =
                    let xs = findAllAttr xmlAttrs "string_opt_coll" |> Seq.toArray
                    if xs.Length = 0 then None
                    else xs |> Array.toSeq |> Some
                let ``simpleattrfield`` =
                    findAttr xmlAttrs "int"
                    |> (parse System.Int32.TryParse "int")
                let ``maybeattrfield`` =
                    tryFindAttr xmlAttrs "int_opt"
                    |> (tryParse System.Int32.TryParse "int_opt")
                let ``attrfieldlist`` =
                    findAllAttr xmlAttrs "int_coll"
                    |> Seq.toArray
                    |> Array.map (parse System.Int32.TryParse "int_coll") |> Array.toList
                let ``attrfieldarray`` =
                    findAllAttr xmlAttrs "int_coll"
                    |> Seq.toArray
                    |> Array.map (parse System.Int32.TryParse "int_coll")
                let ``attrfieldseq`` =
                    findAllAttr xmlAttrs "int_coll"
                    |> Seq.toArray
                    |> Array.map (parse System.Int32.TryParse "int_coll") |> Array.toSeq
                let ``maybeattrfieldlist`` =
                    let xs = findAllAttr xmlAttrs "int_opt_coll" |> Seq.toArray
                    if xs.Length = 0 then None
                    else xs |> Array.map (parse System.Int32.TryParse "int_opt_coll") |> Array.toList |> Some
                let ``maybeattrfieldarray`` =
                    let xs = findAllAttr xmlAttrs "int_opt_coll" |> Seq.toArray
                    if xs.Length = 0 then None
                    else xs |> Array.map (parse System.Int32.TryParse "int_opt_coll") |> Some
                let ``maybeattrfieldseq`` =
                    let xs = findAllAttr xmlAttrs "int_opt_coll" |> Seq.toArray
                    if xs.Length = 0 then None
                    else xs |> Array.map (parse System.Int32.TryParse "int_opt_coll") |> Array.toSeq |> Some
                let ``simplenestedfield`` =
                    findNode children "node"
                    |> Amazingant.FSharp.TypeExpansion.Templates.FromXml.Tests.Node.FromXmlNode
                let ``maybenestedfield`` =
                    tryFindNode children "node_opt"
                    |> Option.map Amazingant.FSharp.TypeExpansion.Templates.FromXml.Tests.NodeOpt.FromXmlNode
                let ``nestedfieldlist`` =
                    findAllNodes children "node_coll"
                    |> Seq.toArray
                    |> Array.map Amazingant.FSharp.TypeExpansion.Templates.FromXml.Tests.NodeColl.FromXmlNode |> Array.toList
                let ``nestedfieldarray`` =
                    findAllNodes children "node_coll"
                    |> Seq.toArray
                    |> Array.map Amazingant.FSharp.TypeExpansion.Templates.FromXml.Tests.NodeColl.FromXmlNode
                let ``nestedfieldseq`` =
                    findAllNodes children "node_coll"
                    |> Seq.toArray
                    |> Array.map Amazingant.FSharp.TypeExpansion.Templates.FromXml.Tests.NodeColl.FromXmlNode |> Array.toSeq
                let ``maybenestedfieldlist`` =
                    let xs = Seq.toArray (findAllNodes children "node_opt_coll")
                    if xs.Length = 0 then None
                    else xs |> Array.map Amazingant.FSharp.TypeExpansion.Templates.FromXml.Tests.NodeOptColl.FromXmlNode |> Array.toList |> Some
                let ``maybenestedfieldarray`` =
                    let xs = Seq.toArray (findAllNodes children "node_opt_coll")
                    if xs.Length = 0 then None
                    else xs |> Array.map Amazingant.FSharp.TypeExpansion.Templates.FromXml.Tests.NodeOptColl.FromXmlNode |> Some
                let ``maybenestedfieldseq`` =
                    let xs = Seq.toArray (findAllNodes children "node_opt_coll")
                    if xs.Length = 0 then None
                    else xs |> Array.map Amazingant.FSharp.TypeExpansion.Templates.FromXml.Tests.NodeOptColl.FromXmlNode |> Array.toSeq |> Some
                let ``simplemultiattrfield`` =
                    findNode children "other_node"
                    |> Amazingant.FSharp.TypeExpansion.Templates.FromXml.Tests.Node.FromXmlNode
                let ``maybemultiattrfield`` =
                    tryFindNode children "other_node_opt"
                    |> Option.map Amazingant.FSharp.TypeExpansion.Templates.FromXml.Tests.Node.FromXmlNode
                let ``multiattrfieldlist`` =
                    findAllNodes children "other_node_coll"
                    |> Seq.toArray
                    |> Array.map Amazingant.FSharp.TypeExpansion.Templates.FromXml.Tests.Node.FromXmlNode |> Array.toList
                let ``multiattrfieldarray`` =
                    findAllNodes children "other_node_coll"
                    |> Seq.toArray
                    |> Array.map Amazingant.FSharp.TypeExpansion.Templates.FromXml.Tests.Node.FromXmlNode
                let ``multiattrfieldseq`` =
                    findAllNodes children "other_node_coll"
                    |> Seq.toArray
                    |> Array.map Amazingant.FSharp.TypeExpansion.Templates.FromXml.Tests.Node.FromXmlNode |> Array.toSeq
                let ``maybemultiattrfieldlist`` =
                    let xs = Seq.toArray (findAllNodes children "other_node_opt_coll")
                    if xs.Length = 0 then None
                    else xs |> Array.map Amazingant.FSharp.TypeExpansion.Templates.FromXml.Tests.Node.FromXmlNode |> Array.toList |> Some
                let ``maybemultiattrfieldarray`` =
                    let xs = Seq.toArray (findAllNodes children "other_node_opt_coll")
                    if xs.Length = 0 then None
                    else xs |> Array.map Amazingant.FSharp.TypeExpansion.Templates.FromXml.Tests.Node.FromXmlNode |> Some
                let ``maybemultiattrfieldseq`` =
                    let xs = Seq.toArray (findAllNodes children "other_node_opt_coll")
                    if xs.Length = 0 then None
                    else xs |> Array.map Amazingant.FSharp.TypeExpansion.Templates.FromXml.Tests.Node.FromXmlNode |> Array.toSeq |> Some
                let ``simplexpathnestedfield`` =
                    xml.SelectSingleNode("xpath/path")
                    |> Amazingant.FSharp.TypeExpansion.Templates.FromXml.Tests.Path.FromXmlNode
                let ``maybexpathnestedfield`` =
                    xml.SelectSingleNode("xpath/path_opt")
                    |> Option.ofObj
                    |> Option.map Amazingant.FSharp.TypeExpansion.Templates.FromXml.Tests.PathOpt.FromXmlNode
                let ``xpathnestedfieldlist`` =
                    xPathToXS xml "xpath/path_coll"
                        Amazingant.FSharp.TypeExpansion.Templates.FromXml.Tests.PathColl.FromXmlNode
                     |> Array.toList
                let ``xpathnestedfieldarray`` =
                    xPathToXS xml "xpath/path_coll"
                        Amazingant.FSharp.TypeExpansion.Templates.FromXml.Tests.PathColl.FromXmlNode
                let ``xpathnestedfieldseq`` =
                    xPathToXS xml "xpath/path_coll"
                        Amazingant.FSharp.TypeExpansion.Templates.FromXml.Tests.PathColl.FromXmlNode
                     |> Array.toSeq
                let ``maybexpathnestedfieldlist`` =
                    let xs = System.Linq.Enumerable.Cast<XmlNode> (xml.SelectNodes("xpath/path_opt_coll")) |> Seq.toArray
                    if xs.Length = 0 then None
                    else xs |> Array.map Amazingant.FSharp.TypeExpansion.Templates.FromXml.Tests.PathOptColl.FromXmlNode |> Array.toList |> Some
                let ``maybexpathnestedfieldarray`` =
                    let xs = System.Linq.Enumerable.Cast<XmlNode> (xml.SelectNodes("xpath/path_opt_coll")) |> Seq.toArray
                    if xs.Length = 0 then None
                    else xs |> Array.map Amazingant.FSharp.TypeExpansion.Templates.FromXml.Tests.PathOptColl.FromXmlNode |> Some
                let ``maybexpathnestedfieldseq`` =
                    let xs = System.Linq.Enumerable.Cast<XmlNode> (xml.SelectNodes("xpath/path_opt_coll")) |> Seq.toArray
                    if xs.Length = 0 then None
                    else xs |> Array.map Amazingant.FSharp.TypeExpansion.Templates.FromXml.Tests.PathOptColl.FromXmlNode |> Array.toSeq |> Some
                let ``simplenestedxpathfield`` =
                    xml.SelectSingleNode("other_node")
                    |> Amazingant.FSharp.TypeExpansion.Templates.FromXml.Tests.Node.FromXmlNode
                let ``maybenestedxpathfield`` =
                    xml.SelectSingleNode("other_node_opt")
                    |> Option.ofObj
                    |> Option.map Amazingant.FSharp.TypeExpansion.Templates.FromXml.Tests.Node.FromXmlNode
                let ``nestedxpathfieldlist`` =
                    xPathToXS xml "other_node_coll"
                        Amazingant.FSharp.TypeExpansion.Templates.FromXml.Tests.Node.FromXmlNode
                     |> Array.toList
                let ``nestedxpathfieldarray`` =
                    xPathToXS xml "other_node_coll"
                        Amazingant.FSharp.TypeExpansion.Templates.FromXml.Tests.Node.FromXmlNode
                let ``nestedxpathfieldseq`` =
                    xPathToXS xml "other_node_coll"
                        Amazingant.FSharp.TypeExpansion.Templates.FromXml.Tests.Node.FromXmlNode
                     |> Array.toSeq
                let ``maybenestedxpathfieldlist`` =
                    let xs = xPathToNodes xml "other_node_opt_coll"
                    if xs.Length = 0 then None
                    else xs |> Array.map Amazingant.FSharp.TypeExpansion.Templates.FromXml.Tests.Node.FromXmlNode |> Array.toList |> Some
                let ``maybenestedxpathfieldarray`` =
                    let xs = xPathToNodes xml "other_node_opt_coll"
                    if xs.Length = 0 then None
                    else xs |> Array.map Amazingant.FSharp.TypeExpansion.Templates.FromXml.Tests.Node.FromXmlNode |> Some
                let ``maybenestedxpathfieldseq`` =
                    let xs = xPathToNodes xml "other_node_opt_coll"
                    if xs.Length = 0 then None
                    else xs |> Array.map Amazingant.FSharp.TypeExpansion.Templates.FromXml.Tests.Node.FromXmlNode |> Array.toSeq |> Some
                let ``simplexpathnestedxpathfield`` =
                    xml.SelectSingleNode("other_node")
                    |> Amazingant.FSharp.TypeExpansion.Templates.FromXml.Tests.Path.FromXmlNode
                let ``maybexpathnestedxpathfield`` =
                    xml.SelectSingleNode("other_node_opt")
                    |> Option.ofObj
                    |> Option.map Amazingant.FSharp.TypeExpansion.Templates.FromXml.Tests.Path.FromXmlNode
                let ``xpathnestedxpathfieldlist`` =
                    xPathToXS xml "other_node_coll"
                        Amazingant.FSharp.TypeExpansion.Templates.FromXml.Tests.Path.FromXmlNode
                     |> Array.toList
                let ``xpathnestedxpathfieldarray`` =
                    xPathToXS xml "other_node_coll"
                        Amazingant.FSharp.TypeExpansion.Templates.FromXml.Tests.Path.FromXmlNode
                let ``xpathnestedxpathfieldseq`` =
                    xPathToXS xml "other_node_coll"
                        Amazingant.FSharp.TypeExpansion.Templates.FromXml.Tests.Path.FromXmlNode
                     |> Array.toSeq
                let ``maybexpathnestedxpathfieldlist`` =
                    let xs = xPathToNodes xml "other_node_opt_coll"
                    if xs.Length = 0 then None
                    else xs |> Array.map Amazingant.FSharp.TypeExpansion.Templates.FromXml.Tests.Path.FromXmlNode |> Array.toList |> Some
                let ``maybexpathnestedxpathfieldarray`` =
                    let xs = xPathToNodes xml "other_node_opt_coll"
                    if xs.Length = 0 then None
                    else xs |> Array.map Amazingant.FSharp.TypeExpansion.Templates.FromXml.Tests.Path.FromXmlNode |> Some
                let ``maybexpathnestedxpathfieldseq`` =
                    let xs = xPathToNodes xml "other_node_opt_coll"
                    if xs.Length = 0 then None
                    else xs |> Array.map Amazingant.FSharp.TypeExpansion.Templates.FromXml.Tests.Path.FromXmlNode |> Array.toSeq |> Some
                {
                    ``SimpleString`` = ``simplestring``;
                    ``MaybeString`` = ``maybestring``;
                    ``StringList`` = ``stringlist``;
                    ``StringArray`` = ``stringarray``;
                    ``StringSeq`` = ``stringseq``;
                    ``MaybeStringList`` = ``maybestringlist``;
                    ``MaybeStringArray`` = ``maybestringarray``;
                    ``MaybeStringSeq`` = ``maybestringseq``;
                    ``SimpleField`` = ``simplefield``;
                    ``MaybeField`` = ``maybefield``;
                    ``FieldList`` = ``fieldlist``;
                    ``FieldArray`` = ``fieldarray``;
                    ``FieldSeq`` = ``fieldseq``;
                    ``MaybeFieldList`` = ``maybefieldlist``;
                    ``MaybeFieldArray`` = ``maybefieldarray``;
                    ``MaybeFieldSeq`` = ``maybefieldseq``;
                    ``SimpleXPathString`` = ``simplexpathstring``;
                    ``MaybeXPathString`` = ``maybexpathstring``;
                    ``XPathStringList`` = ``xpathstringlist``;
                    ``XPathStringArray`` = ``xpathstringarray``;
                    ``XPathStringSeq`` = ``xpathstringseq``;
                    ``MaybeXPathStringList`` = ``maybexpathstringlist``;
                    ``MaybeXPathStringArray`` = ``maybexpathstringarray``;
                    ``MaybeXPathStringSeq`` = ``maybexpathstringseq``;
                    ``SimpleXPathField`` = ``simplexpathfield``;
                    ``MaybeXPathField`` = ``maybexpathfield``;
                    ``XPathFieldList`` = ``xpathfieldlist``;
                    ``XPathFieldArray`` = ``xpathfieldarray``;
                    ``XPathFieldSeq`` = ``xpathfieldseq``;
                    ``MaybeXPathFieldList`` = ``maybexpathfieldlist``;
                    ``MaybeXPathFieldArray`` = ``maybexpathfieldarray``;
                    ``MaybeXPathFieldSeq`` = ``maybexpathfieldseq``;
                    ``SimpleNodeString`` = ``simplenodestring``;
                    ``MaybeNodeString`` = ``maybenodestring``;
                    ``NodeStringList`` = ``nodestringlist``;
                    ``NodeStringArray`` = ``nodestringarray``;
                    ``NodeStringSeq`` = ``nodestringseq``;
                    ``MaybeNodeStringList`` = ``maybenodestringlist``;
                    ``MaybeNodeStringArray`` = ``maybenodestringarray``;
                    ``MaybeNodeStringSeq`` = ``maybenodestringseq``;
                    ``SimpleNodeField`` = ``simplenodefield``;
                    ``MaybeNodeField`` = ``maybenodefield``;
                    ``NodeFieldList`` = ``nodefieldlist``;
                    ``NodeFieldArray`` = ``nodefieldarray``;
                    ``NodeFieldSeq`` = ``nodefieldseq``;
                    ``MaybeNodeFieldList`` = ``maybenodefieldlist``;
                    ``MaybeNodeFieldArray`` = ``maybenodefieldarray``;
                    ``MaybeNodeFieldSeq`` = ``maybenodefieldseq``;
                    ``SimpleAttrString`` = ``simpleattrstring``;
                    ``MaybeAttrString`` = ``maybeattrstring``;
                    ``AttrStringList`` = ``attrstringlist``;
                    ``AttrStringArray`` = ``attrstringarray``;
                    ``AttrStringSeq`` = ``attrstringseq``;
                    ``MaybeAttrStringList`` = ``maybeattrstringlist``;
                    ``MaybeAttrStringArray`` = ``maybeattrstringarray``;
                    ``MaybeAttrStringSeq`` = ``maybeattrstringseq``;
                    ``SimpleAttrField`` = ``simpleattrfield``;
                    ``MaybeAttrField`` = ``maybeattrfield``;
                    ``AttrFieldList`` = ``attrfieldlist``;
                    ``AttrFieldArray`` = ``attrfieldarray``;
                    ``AttrFieldSeq`` = ``attrfieldseq``;
                    ``MaybeAttrFieldList`` = ``maybeattrfieldlist``;
                    ``MaybeAttrFieldArray`` = ``maybeattrfieldarray``;
                    ``MaybeAttrFieldSeq`` = ``maybeattrfieldseq``;
                    ``SimpleNestedField`` = ``simplenestedfield``;
                    ``MaybeNestedField`` = ``maybenestedfield``;
                    ``NestedFieldList`` = ``nestedfieldlist``;
                    ``NestedFieldArray`` = ``nestedfieldarray``;
                    ``NestedFieldSeq`` = ``nestedfieldseq``;
                    ``MaybeNestedFieldList`` = ``maybenestedfieldlist``;
                    ``MaybeNestedFieldArray`` = ``maybenestedfieldarray``;
                    ``MaybeNestedFieldSeq`` = ``maybenestedfieldseq``;
                    ``SimpleMultiAttrField`` = ``simplemultiattrfield``;
                    ``MaybeMultiAttrField`` = ``maybemultiattrfield``;
                    ``MultiAttrFieldList`` = ``multiattrfieldlist``;
                    ``MultiAttrFieldArray`` = ``multiattrfieldarray``;
                    ``MultiAttrFieldSeq`` = ``multiattrfieldseq``;
                    ``MaybeMultiAttrFieldList`` = ``maybemultiattrfieldlist``;
                    ``MaybeMultiAttrFieldArray`` = ``maybemultiattrfieldarray``;
                    ``MaybeMultiAttrFieldSeq`` = ``maybemultiattrfieldseq``;
                    ``SimpleXPathNestedField`` = ``simplexpathnestedfield``;
                    ``MaybeXPathNestedField`` = ``maybexpathnestedfield``;
                    ``XPathNestedFieldList`` = ``xpathnestedfieldlist``;
                    ``XPathNestedFieldArray`` = ``xpathnestedfieldarray``;
                    ``XPathNestedFieldSeq`` = ``xpathnestedfieldseq``;
                    ``MaybeXPathNestedFieldList`` = ``maybexpathnestedfieldlist``;
                    ``MaybeXPathNestedFieldArray`` = ``maybexpathnestedfieldarray``;
                    ``MaybeXPathNestedFieldSeq`` = ``maybexpathnestedfieldseq``;
                    ``SimpleNestedXPathField`` = ``simplenestedxpathfield``;
                    ``MaybeNestedXPathField`` = ``maybenestedxpathfield``;
                    ``NestedXPathFieldList`` = ``nestedxpathfieldlist``;
                    ``NestedXPathFieldArray`` = ``nestedxpathfieldarray``;
                    ``NestedXPathFieldSeq`` = ``nestedxpathfieldseq``;
                    ``MaybeNestedXPathFieldList`` = ``maybenestedxpathfieldlist``;
                    ``MaybeNestedXPathFieldArray`` = ``maybenestedxpathfieldarray``;
                    ``MaybeNestedXPathFieldSeq`` = ``maybenestedxpathfieldseq``;
                    ``SimpleXPathNestedXPathField`` = ``simplexpathnestedxpathfield``;
                    ``MaybeXPathNestedXPathField`` = ``maybexpathnestedxpathfield``;
                    ``XPathNestedXPathFieldList`` = ``xpathnestedxpathfieldlist``;
                    ``XPathNestedXPathFieldArray`` = ``xpathnestedxpathfieldarray``;
                    ``XPathNestedXPathFieldSeq`` = ``xpathnestedxpathfieldseq``;
                    ``MaybeXPathNestedXPathFieldList`` = ``maybexpathnestedxpathfieldlist``;
                    ``MaybeXPathNestedXPathFieldArray`` = ``maybexpathnestedxpathfieldarray``;
                    ``MaybeXPathNestedXPathFieldSeq`` = ``maybexpathnestedxpathfieldseq``;
                }

            static member FromXmlDoc doc = thingFromDocElement doc "test" TestFields.FromXmlNode
            static member FromXmlDoc xml = thingFromStringElement xml "test" TestFields.FromXmlNode

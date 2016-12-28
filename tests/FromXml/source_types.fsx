//#r "../../packages/Amazingant.FSharp.TypeExpansion/lib/net45/Amazingant.FSharp.TypeExpansion.Attributes.dll"
#r @"M:\Users\amazingant\GitHub\Amazingant.FSharp.TypeExpansion\Source\Amazingant.FSharp.TypeExpansion\bin\Debug\Amazingant.FSharp.TypeExpansion.Attributes.dll"
#load "../../templates/FromXml/FromXml_Base.fsx"

namespace Amazingant.FSharp.TypeExpansion.Templates.FromXml.Tests

open Amazingant.FSharp.TypeExpansion.Templates.FromXml
open Amazingant.FSharp.TypeExpansion.Attributes

// These are here for test fields that need a "nested" type. The base "Node"
// type can be used in any situation where a field will have an XmlNode
// attribute on it; the other types are needed for fields that are
// optional/collections/etc.
[<XmlNode("node"         ); ExpandableType([| "FromXml" |])>] type Node        = { Field : string; }
[<XmlNode("node_opt"     ); ExpandableType([| "FromXml" |])>] type NodeOpt     = { Field : string; }
[<XmlNode("node_coll"    ); ExpandableType([| "FromXml" |])>] type NodeColl    = { Field : string; }
[<XmlNode("node_opt_coll"); ExpandableType([| "FromXml" |])>] type NodeOptColl = { Field : string; }


[<XmlNode("Test"); ExpandableType([| "FromXml" |])>]
type TestFields =
    {
        // **** Simple fields **** //
        // Strings are treated differently than other types
        SimpleString      :  string              ;
         MaybeString      :  string        option;
              StringList  :  string list         ;
              StringArray :  string array        ;
              StringSeq   :  string seq          ;
         MaybeStringList  : (string list ) option;
         MaybeStringArray : (string array) option;
         MaybeStringSeq   : (string seq  ) option;
        // Now the simple fields; these use `int`, but any other type should be
        // fine so long as the type itself does not have one of the FromXml
        // attributes on it
        SimpleField       :  int                 ;
         MaybeField       :  int           option;
              FieldList   :  int    list         ;
              FieldArray  :  int    array        ;
              FieldSeq    :  int    seq          ;
         MaybeFieldList   : (int    list ) option;
         MaybeFieldArray  : (int    array) option;
         MaybeFieldSeq    : (int    seq  ) option;

        // **** XPath fields **** //
        // Strings with an XPath attribute on the field
        [<XPath("string"         )>] SimpleXPathString      :  string              ;
        [<XPath("string_opt"     )>]  MaybeXPathString      :  string        option;
        [<XPath("string_coll"    )>]       XPathStringList  :  string list         ;
        [<XPath("string_coll"    )>]       XPathStringArray :  string array        ;
        [<XPath("string_coll"    )>]       XPathStringSeq   :  string seq          ;
        [<XPath("string_opt_coll")>]  MaybeXPathStringList  : (string list ) option;
        [<XPath("string_opt_coll")>]  MaybeXPathStringArray : (string array) option;
        [<XPath("string_opt_coll")>]  MaybeXPathStringSeq   : (string seq  ) option;
    }

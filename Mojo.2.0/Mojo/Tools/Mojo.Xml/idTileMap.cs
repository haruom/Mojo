﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:2.0.50727.5448
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// 
// This source code was auto-generated by xsd, Version=2.0.50727.3038.
// 
namespace Mojo.Xml {
    using System.Xml.Serialization;
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
    public partial class idTileMap {
        
        private idTileMapIdTileMapEntry[] idTileMapEntryField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("idTileMapEntry")]
        public idTileMapIdTileMapEntry[] idTileMapEntry {
            get {
                return this.idTileMapEntryField;
            }
            set {
                this.idTileMapEntryField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    public partial class idTileMapIdTileMapEntry {
        
        private idTileMapIdTileMapEntryTile[] tilesField;
        
        private uint idField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("tile", IsNullable=false)]
        public idTileMapIdTileMapEntryTile[] tiles {
            get {
                return this.tilesField;
            }
            set {
                this.tilesField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public uint id {
            get {
                return this.idField;
            }
            set {
                this.idField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    public partial class idTileMapIdTileMapEntryTile {
        
        private uint xField;
        
        private uint yField;
        
        private uint zField;
        
        private uint wField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public uint x {
            get {
                return this.xField;
            }
            set {
                this.xField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public uint y {
            get {
                return this.yField;
            }
            set {
                this.yField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public uint z {
            get {
                return this.zField;
            }
            set {
                this.zField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public uint w {
            get {
                return this.wField;
            }
            set {
                this.wField = value;
            }
        }
    }
}

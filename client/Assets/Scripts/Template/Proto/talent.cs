//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Option: missing-value detection (*Specified/ShouldSerialize*/Reset*) enabled
    
// Generated from: talent.proto
namespace Proto
{
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"TalentUnit")]
  public partial class TalentUnit : global::ProtoBuf.IExtensible
  {
    public TalentUnit() {}
    
    private uint? _talentid;
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"talentid", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public uint talentid
    {
      get { return _talentid?? default(uint); }
      set { _talentid = value; }
    }
    [global::System.Xml.Serialization.XmlIgnore]
    [global::System.ComponentModel.Browsable(false)]
    public bool talentidSpecified
    {
      get { return this._talentid != null; }
      set { if (value == (this._talentid== null)) this._talentid = value ? this.talentid : (uint?)null; }
    }
    private bool ShouldSerializetalentid() { return talentidSpecified; }
    private void Resettalentid() { talentidSpecified = false; }
    
    private uint? _talentlvl;
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"talentlvl", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public uint talentlvl
    {
      get { return _talentlvl?? default(uint); }
      set { _talentlvl = value; }
    }
    [global::System.Xml.Serialization.XmlIgnore]
    [global::System.ComponentModel.Browsable(false)]
    public bool talentlvlSpecified
    {
      get { return this._talentlvl != null; }
      set { if (value == (this._talentlvl== null)) this._talentlvl = value ? this.talentlvl : (uint?)null; }
    }
    private bool ShouldSerializetalentlvl() { return talentlvlSpecified; }
    private void Resettalentlvl() { talentlvlSpecified = false; }
    
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"TalentPoint")]
  public partial class TalentPoint : global::ProtoBuf.IExtensible
  {
    public TalentPoint() {}
    
    private readonly global::System.Collections.Generic.List<Proto.TalentUnit> _unit = new global::System.Collections.Generic.List<Proto.TalentUnit>();
    [global::ProtoBuf.ProtoMember(1, Name=@"unit", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public global::System.Collections.Generic.List<Proto.TalentUnit> unit
    {
      get { return _unit; }
    }
  
    private uint? _point;
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"point", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public uint point
    {
      get { return _point?? default(uint); }
      set { _point = value; }
    }
    [global::System.Xml.Serialization.XmlIgnore]
    [global::System.ComponentModel.Browsable(false)]
    public bool pointSpecified
    {
      get { return this._point != null; }
      set { if (value == (this._point== null)) this._point = value ? this.point : (uint?)null; }
    }
    private bool ShouldSerializepoint() { return pointSpecified; }
    private void Resetpoint() { pointSpecified = false; }
    
    private uint? _page;
    [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"page", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public uint page
    {
      get { return _page?? default(uint); }
      set { _page = value; }
    }
    [global::System.Xml.Serialization.XmlIgnore]
    [global::System.ComponentModel.Browsable(false)]
    public bool pageSpecified
    {
      get { return this._page != null; }
      set { if (value == (this._page== null)) this._page = value ? this.page : (uint?)null; }
    }
    private bool ShouldSerializepage() { return pageSpecified; }
    private void Resetpage() { pageSpecified = false; }
    
    private readonly global::System.Collections.Generic.List<uint> _talentclass = new global::System.Collections.Generic.List<uint>();
    [global::ProtoBuf.ProtoMember(4, Name=@"talentclass", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public global::System.Collections.Generic.List<uint> talentclass
    {
      get { return _talentclass; }
    }
  
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"OccupationTalent")]
  public partial class OccupationTalent : global::ProtoBuf.IExtensible
  {
    public OccupationTalent() {}
    
    private uint? _occ;
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"occ", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public uint occ
    {
      get { return _occ?? default(uint); }
      set { _occ = value; }
    }
    [global::System.Xml.Serialization.XmlIgnore]
    [global::System.ComponentModel.Browsable(false)]
    public bool occSpecified
    {
      get { return this._occ != null; }
      set { if (value == (this._occ== null)) this._occ = value ? this.occ : (uint?)null; }
    }
    private bool ShouldSerializeocc() { return occSpecified; }
    private void Resetocc() { occSpecified = false; }
    
    private uint? _openpage;
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"openpage", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public uint openpage
    {
      get { return _openpage?? default(uint); }
      set { _openpage = value; }
    }
    [global::System.Xml.Serialization.XmlIgnore]
    [global::System.ComponentModel.Browsable(false)]
    public bool openpageSpecified
    {
      get { return this._openpage != null; }
      set { if (value == (this._openpage== null)) this._openpage = value ? this.openpage : (uint?)null; }
    }
    private bool ShouldSerializeopenpage() { return openpageSpecified; }
    private void Resetopenpage() { openpageSpecified = false; }
    
    private uint? _curpage;
    [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"curpage", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public uint curpage
    {
      get { return _curpage?? default(uint); }
      set { _curpage = value; }
    }
    [global::System.Xml.Serialization.XmlIgnore]
    [global::System.ComponentModel.Browsable(false)]
    public bool curpageSpecified
    {
      get { return this._curpage != null; }
      set { if (value == (this._curpage== null)) this._curpage = value ? this.curpage : (uint?)null; }
    }
    private bool ShouldSerializecurpage() { return curpageSpecified; }
    private void Resetcurpage() { curpageSpecified = false; }
    
    private readonly global::System.Collections.Generic.List<Proto.TalentPoint> _talent = new global::System.Collections.Generic.List<Proto.TalentPoint>();
    [global::ProtoBuf.ProtoMember(4, Name=@"talent", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public global::System.Collections.Generic.List<Proto.TalentPoint> talent
    {
      get { return _talent; }
    }
  
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"CmdTalentInfoNtf")]
  public partial class CmdTalentInfoNtf : global::ProtoBuf.IExtensible
  {
    public CmdTalentInfoNtf() {}
    
    private uint? _totalpoint;
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"totalpoint", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public uint totalpoint
    {
      get { return _totalpoint?? default(uint); }
      set { _totalpoint = value; }
    }
    [global::System.Xml.Serialization.XmlIgnore]
    [global::System.ComponentModel.Browsable(false)]
    public bool totalpointSpecified
    {
      get { return this._totalpoint != null; }
      set { if (value == (this._totalpoint== null)) this._totalpoint = value ? this.totalpoint : (uint?)null; }
    }
    private bool ShouldSerializetotalpoint() { return totalpointSpecified; }
    private void Resettotalpoint() { totalpointSpecified = false; }
    
    private uint? _buypoint;
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"buypoint", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public uint buypoint
    {
      get { return _buypoint?? default(uint); }
      set { _buypoint = value; }
    }
    [global::System.Xml.Serialization.XmlIgnore]
    [global::System.ComponentModel.Browsable(false)]
    public bool buypointSpecified
    {
      get { return this._buypoint != null; }
      set { if (value == (this._buypoint== null)) this._buypoint = value ? this.buypoint : (uint?)null; }
    }
    private bool ShouldSerializebuypoint() { return buypointSpecified; }
    private void Resetbuypoint() { buypointSpecified = false; }
    
    private Proto.OccupationTalent _occtalent = null;
    [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"occtalent", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(null)]
    public Proto.OccupationTalent occtalent
    {
      get { return _occtalent; }
      set { _occtalent = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"CmdTalentOpenPageReq")]
  public partial class CmdTalentOpenPageReq : global::ProtoBuf.IExtensible
  {
    public CmdTalentOpenPageReq() {}
    
    private uint? _page;
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"page", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public uint page
    {
      get { return _page?? default(uint); }
      set { _page = value; }
    }
    [global::System.Xml.Serialization.XmlIgnore]
    [global::System.ComponentModel.Browsable(false)]
    public bool pageSpecified
    {
      get { return this._page != null; }
      set { if (value == (this._page== null)) this._page = value ? this.page : (uint?)null; }
    }
    private bool ShouldSerializepage() { return pageSpecified; }
    private void Resetpage() { pageSpecified = false; }
    
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"CmdTalentOpenPageRes")]
  public partial class CmdTalentOpenPageRes : global::ProtoBuf.IExtensible
  {
    public CmdTalentOpenPageRes() {}
    
    private uint? _page;
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"page", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public uint page
    {
      get { return _page?? default(uint); }
      set { _page = value; }
    }
    [global::System.Xml.Serialization.XmlIgnore]
    [global::System.ComponentModel.Browsable(false)]
    public bool pageSpecified
    {
      get { return this._page != null; }
      set { if (value == (this._page== null)) this._page = value ? this.page : (uint?)null; }
    }
    private bool ShouldSerializepage() { return pageSpecified; }
    private void Resetpage() { pageSpecified = false; }
    
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"CmdTalentChangePageReq")]
  public partial class CmdTalentChangePageReq : global::ProtoBuf.IExtensible
  {
    public CmdTalentChangePageReq() {}
    
    private uint? _page;
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"page", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public uint page
    {
      get { return _page?? default(uint); }
      set { _page = value; }
    }
    [global::System.Xml.Serialization.XmlIgnore]
    [global::System.ComponentModel.Browsable(false)]
    public bool pageSpecified
    {
      get { return this._page != null; }
      set { if (value == (this._page== null)) this._page = value ? this.page : (uint?)null; }
    }
    private bool ShouldSerializepage() { return pageSpecified; }
    private void Resetpage() { pageSpecified = false; }
    
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"CmdTalentChangePageRes")]
  public partial class CmdTalentChangePageRes : global::ProtoBuf.IExtensible
  {
    public CmdTalentChangePageRes() {}
    
    private uint? _page;
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"page", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public uint page
    {
      get { return _page?? default(uint); }
      set { _page = value; }
    }
    [global::System.Xml.Serialization.XmlIgnore]
    [global::System.ComponentModel.Browsable(false)]
    public bool pageSpecified
    {
      get { return this._page != null; }
      set { if (value == (this._page== null)) this._page = value ? this.page : (uint?)null; }
    }
    private bool ShouldSerializepage() { return pageSpecified; }
    private void Resetpage() { pageSpecified = false; }
    
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"CmdTalentOperateReq")]
  public partial class CmdTalentOperateReq : global::ProtoBuf.IExtensible
  {
    public CmdTalentOperateReq() {}
    
    private uint? _type;
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"type", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public uint type
    {
      get { return _type?? default(uint); }
      set { _type = value; }
    }
    [global::System.Xml.Serialization.XmlIgnore]
    [global::System.ComponentModel.Browsable(false)]
    public bool typeSpecified
    {
      get { return this._type != null; }
      set { if (value == (this._type== null)) this._type = value ? this.type : (uint?)null; }
    }
    private bool ShouldSerializetype() { return typeSpecified; }
    private void Resettype() { typeSpecified = false; }
    
    private uint? _talentid;
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"talentid", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public uint talentid
    {
      get { return _talentid?? default(uint); }
      set { _talentid = value; }
    }
    [global::System.Xml.Serialization.XmlIgnore]
    [global::System.ComponentModel.Browsable(false)]
    public bool talentidSpecified
    {
      get { return this._talentid != null; }
      set { if (value == (this._talentid== null)) this._talentid = value ? this.talentid : (uint?)null; }
    }
    private bool ShouldSerializetalentid() { return talentidSpecified; }
    private void Resettalentid() { talentidSpecified = false; }
    
    private uint? _page;
    [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"page", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public uint page
    {
      get { return _page?? default(uint); }
      set { _page = value; }
    }
    [global::System.Xml.Serialization.XmlIgnore]
    [global::System.ComponentModel.Browsable(false)]
    public bool pageSpecified
    {
      get { return this._page != null; }
      set { if (value == (this._page== null)) this._page = value ? this.page : (uint?)null; }
    }
    private bool ShouldSerializepage() { return pageSpecified; }
    private void Resetpage() { pageSpecified = false; }
    
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"CmdTalentOperateRes")]
  public partial class CmdTalentOperateRes : global::ProtoBuf.IExtensible
  {
    public CmdTalentOperateRes() {}
    
    private uint? _point;
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"point", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public uint point
    {
      get { return _point?? default(uint); }
      set { _point = value; }
    }
    [global::System.Xml.Serialization.XmlIgnore]
    [global::System.ComponentModel.Browsable(false)]
    public bool pointSpecified
    {
      get { return this._point != null; }
      set { if (value == (this._point== null)) this._point = value ? this.point : (uint?)null; }
    }
    private bool ShouldSerializepoint() { return pointSpecified; }
    private void Resetpoint() { pointSpecified = false; }
    
    private Proto.TalentUnit _unit = null;
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"unit", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(null)]
    public Proto.TalentUnit unit
    {
      get { return _unit; }
      set { _unit = value; }
    }
    private uint? _talentclass;
    [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"talentclass", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public uint talentclass
    {
      get { return _talentclass?? default(uint); }
      set { _talentclass = value; }
    }
    [global::System.Xml.Serialization.XmlIgnore]
    [global::System.ComponentModel.Browsable(false)]
    public bool talentclassSpecified
    {
      get { return this._talentclass != null; }
      set { if (value == (this._talentclass== null)) this._talentclass = value ? this.talentclass : (uint?)null; }
    }
    private bool ShouldSerializetalentclass() { return talentclassSpecified; }
    private void Resettalentclass() { talentclassSpecified = false; }
    
    private uint? _pointclass;
    [global::ProtoBuf.ProtoMember(4, IsRequired = false, Name=@"pointclass", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public uint pointclass
    {
      get { return _pointclass?? default(uint); }
      set { _pointclass = value; }
    }
    [global::System.Xml.Serialization.XmlIgnore]
    [global::System.ComponentModel.Browsable(false)]
    public bool pointclassSpecified
    {
      get { return this._pointclass != null; }
      set { if (value == (this._pointclass== null)) this._pointclass = value ? this.pointclass : (uint?)null; }
    }
    private bool ShouldSerializepointclass() { return pointclassSpecified; }
    private void Resetpointclass() { pointclassSpecified = false; }
    
    private uint? _page;
    [global::ProtoBuf.ProtoMember(5, IsRequired = false, Name=@"page", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public uint page
    {
      get { return _page?? default(uint); }
      set { _page = value; }
    }
    [global::System.Xml.Serialization.XmlIgnore]
    [global::System.ComponentModel.Browsable(false)]
    public bool pageSpecified
    {
      get { return this._page != null; }
      set { if (value == (this._page== null)) this._page = value ? this.page : (uint?)null; }
    }
    private bool ShouldSerializepage() { return pageSpecified; }
    private void Resetpage() { pageSpecified = false; }
    
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"CmdTalentBuyTalentPointReq")]
  public partial class CmdTalentBuyTalentPointReq : global::ProtoBuf.IExtensible
  {
    public CmdTalentBuyTalentPointReq() {}
    
    private uint? _point;
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"point", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public uint point
    {
      get { return _point?? default(uint); }
      set { _point = value; }
    }
    [global::System.Xml.Serialization.XmlIgnore]
    [global::System.ComponentModel.Browsable(false)]
    public bool pointSpecified
    {
      get { return this._point != null; }
      set { if (value == (this._point== null)) this._point = value ? this.point : (uint?)null; }
    }
    private bool ShouldSerializepoint() { return pointSpecified; }
    private void Resetpoint() { pointSpecified = false; }
    
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"CmdTalentResetTalentPointReq")]
  public partial class CmdTalentResetTalentPointReq : global::ProtoBuf.IExtensible
  {
    public CmdTalentResetTalentPointReq() {}
    
    private uint? _page;
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"page", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public uint page
    {
      get { return _page?? default(uint); }
      set { _page = value; }
    }
    [global::System.Xml.Serialization.XmlIgnore]
    [global::System.ComponentModel.Browsable(false)]
    public bool pageSpecified
    {
      get { return this._page != null; }
      set { if (value == (this._page== null)) this._page = value ? this.page : (uint?)null; }
    }
    private bool ShouldSerializepage() { return pageSpecified; }
    private void Resetpage() { pageSpecified = false; }
    
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"CmdTalentResetTalentPointRes")]
  public partial class CmdTalentResetTalentPointRes : global::ProtoBuf.IExtensible
  {
    public CmdTalentResetTalentPointRes() {}
    
    private uint? _page;
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"page", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public uint page
    {
      get { return _page?? default(uint); }
      set { _page = value; }
    }
    [global::System.Xml.Serialization.XmlIgnore]
    [global::System.ComponentModel.Browsable(false)]
    public bool pageSpecified
    {
      get { return this._page != null; }
      set { if (value == (this._page== null)) this._page = value ? this.page : (uint?)null; }
    }
    private bool ShouldSerializepage() { return pageSpecified; }
    private void Resetpage() { pageSpecified = false; }
    
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"CmdTalentTalentPointNtf")]
  public partial class CmdTalentTalentPointNtf : global::ProtoBuf.IExtensible
  {
    public CmdTalentTalentPointNtf() {}
    
    private uint? _totalpoint;
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"totalpoint", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public uint totalpoint
    {
      get { return _totalpoint?? default(uint); }
      set { _totalpoint = value; }
    }
    [global::System.Xml.Serialization.XmlIgnore]
    [global::System.ComponentModel.Browsable(false)]
    public bool totalpointSpecified
    {
      get { return this._totalpoint != null; }
      set { if (value == (this._totalpoint== null)) this._totalpoint = value ? this.totalpoint : (uint?)null; }
    }
    private bool ShouldSerializetotalpoint() { return totalpointSpecified; }
    private void Resettotalpoint() { totalpointSpecified = false; }
    
    private uint? _buypoint;
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"buypoint", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public uint buypoint
    {
      get { return _buypoint?? default(uint); }
      set { _buypoint = value; }
    }
    [global::System.Xml.Serialization.XmlIgnore]
    [global::System.ComponentModel.Browsable(false)]
    public bool buypointSpecified
    {
      get { return this._buypoint != null; }
      set { if (value == (this._buypoint== null)) this._buypoint = value ? this.buypoint : (uint?)null; }
    }
    private bool ShouldSerializebuypoint() { return buypointSpecified; }
    private void Resetbuypoint() { buypointSpecified = false; }
    
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"CmdTalentRoleExpUpdateNtf")]
  public partial class CmdTalentRoleExpUpdateNtf : global::ProtoBuf.IExtensible
  {
    public CmdTalentRoleExpUpdateNtf() {}
    
    private long? _exp;
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"exp", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public long exp
    {
      get { return _exp?? default(long); }
      set { _exp = value; }
    }
    [global::System.Xml.Serialization.XmlIgnore]
    [global::System.ComponentModel.Browsable(false)]
    public bool expSpecified
    {
      get { return this._exp != null; }
      set { if (value == (this._exp== null)) this._exp = value ? this.exp : (long?)null; }
    }
    private bool ShouldSerializeexp() { return expSpecified; }
    private void Resetexp() { expSpecified = false; }
    
    private long? _sealexp;
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"sealexp", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public long sealexp
    {
      get { return _sealexp?? default(long); }
      set { _sealexp = value; }
    }
    [global::System.Xml.Serialization.XmlIgnore]
    [global::System.ComponentModel.Browsable(false)]
    public bool sealexpSpecified
    {
      get { return this._sealexp != null; }
      set { if (value == (this._sealexp== null)) this._sealexp = value ? this.sealexp : (long?)null; }
    }
    private bool ShouldSerializesealexp() { return sealexpSpecified; }
    private void Resetsealexp() { sealexpSpecified = false; }
    
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
    [global::ProtoBuf.ProtoContract(Name=@"CmdTalent")]
    public enum CmdTalent
    {
            
      [global::ProtoBuf.ProtoEnum(Name=@"CmdTalent_InfoNtf", Value=8900)]
      CmdTalent_InfoNtf = 8900,
            
      [global::ProtoBuf.ProtoEnum(Name=@"CmdTalent_OpenPageReq", Value=8901)]
      CmdTalent_OpenPageReq = 8901,
            
      [global::ProtoBuf.ProtoEnum(Name=@"CmdTalent_OpenPageRes", Value=8902)]
      CmdTalent_OpenPageRes = 8902,
            
      [global::ProtoBuf.ProtoEnum(Name=@"CmdTalent_ChangePageReq", Value=8903)]
      CmdTalent_ChangePageReq = 8903,
            
      [global::ProtoBuf.ProtoEnum(Name=@"CmdTalent_ChangePageRes", Value=8904)]
      CmdTalent_ChangePageRes = 8904,
            
      [global::ProtoBuf.ProtoEnum(Name=@"CmdTalent_OperateReq", Value=8905)]
      CmdTalent_OperateReq = 8905,
            
      [global::ProtoBuf.ProtoEnum(Name=@"CmdTalent_OperateRes", Value=8906)]
      CmdTalent_OperateRes = 8906,
            
      [global::ProtoBuf.ProtoEnum(Name=@"CmdTalent_BuyTalentPointReq", Value=8907)]
      CmdTalent_BuyTalentPointReq = 8907,
            
      [global::ProtoBuf.ProtoEnum(Name=@"CmdTalent_ResetTalentPointReq", Value=8908)]
      CmdTalent_ResetTalentPointReq = 8908,
            
      [global::ProtoBuf.ProtoEnum(Name=@"CmdTalent_ResetTalentPointRes", Value=8909)]
      CmdTalent_ResetTalentPointRes = 8909,
            
      [global::ProtoBuf.ProtoEnum(Name=@"CmdTalent_TalentPointNtf", Value=8910)]
      CmdTalent_TalentPointNtf = 8910,
            
      [global::ProtoBuf.ProtoEnum(Name=@"CmdTalent_RoleExpUpdateNtf", Value=8911)]
      CmdTalent_RoleExpUpdateNtf = 8911
    }
  
    [global::ProtoBuf.ProtoContract(Name=@"ErrorTalent")]
    public enum ErrorTalent
    {
            
      [global::ProtoBuf.ProtoEnum(Name=@"ErrorTalent_TalentPoint_NotEnough", Value=8901)]
      ErrorTalent_TalentPoint_NotEnough = 8901,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ErrorTalent_TalentOccError", Value=8902)]
      ErrorTalent_TalentOccError = 8902,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ErrorTalent_TalentPageError", Value=8903)]
      ErrorTalent_TalentPageError = 8903,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ErrorTalent_TalentPageNotOpen", Value=8904)]
      ErrorTalent_TalentPageNotOpen = 8904,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ErrorTalent_TalentOperateTypeError", Value=8905)]
      ErrorTalent_TalentOperateTypeError = 8905,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ErrorTalent_TalentIdError", Value=8906)]
      ErrorTalent_TalentIdError = 8906,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ErrorTalent_TalentRoleLevelError", Value=8908)]
      ErrorTalent_TalentRoleLevelError = 8908,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ErrorTalent_TalentClassError", Value=8909)]
      ErrorTalent_TalentClassError = 8909,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ErrorTalent_TalentNeedPoint_NotEnough", Value=8910)]
      ErrorTalent_TalentNeedPoint_NotEnough = 8910,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ErrorTalent_TalentBeforeLvl_NotEnough", Value=8911)]
      ErrorTalent_TalentBeforeLvl_NotEnough = 8911,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ErrorTalent_TalentNotLearn", Value=8912)]
      ErrorTalent_TalentNotLearn = 8912,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ErrorTalent_TalentRoleLvlError", Value=8913)]
      ErrorTalent_TalentRoleLvlError = 8913,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ErrorTalent_TalentNotCanBuyPoint", Value=8914)]
      ErrorTalent_TalentNotCanBuyPoint = 8914,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ErrorTalent_TalentExpNotEnough", Value=8915)]
      ErrorTalent_TalentExpNotEnough = 8915,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ErrorTalent_TalentPointMax", Value=8916)]
      ErrorTalent_TalentPointMax = 8916,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ErrorTalent_TalentLayerPointError", Value=8917)]
      ErrorTalent_TalentLayerPointError = 8917,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ErrorTalent_TalentLayerInfoError", Value=8918)]
      ErrorTalent_TalentLayerInfoError = 8918
    }
  
}
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Option: missing-value detection (*Specified/ShouldSerialize*/Reset*) enabled
    
// Generated from: report.proto
namespace Proto
{
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"CmdReportRoleReq")]
  public partial class CmdReportRoleReq : global::ProtoBuf.IExtensible
  {
    public CmdReportRoleReq() {}
    
    private ulong? _roleId;
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"roleId", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public ulong roleId
    {
      get { return _roleId?? default(ulong); }
      set { _roleId = value; }
    }
    [global::System.Xml.Serialization.XmlIgnore]
    [global::System.ComponentModel.Browsable(false)]
    public bool roleIdSpecified
    {
      get { return this._roleId != null; }
      set { if (value == (this._roleId== null)) this._roleId = value ? this.roleId : (ulong?)null; }
    }
    private bool ShouldSerializeroleId() { return roleIdSpecified; }
    private void ResetroleId() { roleIdSpecified = false; }
    
    private uint? _type;
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"type", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
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
    
    private byte[] _context;
    [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"context", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public byte[] context
    {
      get { return _context?? null; }
      set { _context = value; }
    }
    [global::System.Xml.Serialization.XmlIgnore]
    [global::System.ComponentModel.Browsable(false)]
    public bool contextSpecified
    {
      get { return this._context != null; }
      set { if (value == (this._context== null)) this._context = value ? this.context : (byte[])null; }
    }
    private bool ShouldSerializecontext() { return contextSpecified; }
    private void Resetcontext() { contextSpecified = false; }
    
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"CmdReportRoleRes")]
  public partial class CmdReportRoleRes : global::ProtoBuf.IExtensible
  {
    public CmdReportRoleRes() {}
    
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
    [global::ProtoBuf.ProtoContract(Name=@"CmdReport")]
    public enum CmdReport
    {
            
      [global::ProtoBuf.ProtoEnum(Name=@"CmdReport_RoleReq", Value=7200)]
      CmdReport_RoleReq = 7200,
            
      [global::ProtoBuf.ProtoEnum(Name=@"CmdReport_RoleRes", Value=7201)]
      CmdReport_RoleRes = 7201
    }
  
}
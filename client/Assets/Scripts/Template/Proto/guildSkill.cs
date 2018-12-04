//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Option: missing-value detection (*Specified/ShouldSerialize*/Reset*) enabled
    
// Generated from: guildSkill.proto
namespace Proto
{
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"GuildSkillEntry")]
  public partial class GuildSkillEntry : global::ProtoBuf.IExtensible
  {
    public GuildSkillEntry() {}
    
    private uint? _skillId;
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"skillId", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public uint skillId
    {
      get { return _skillId?? default(uint); }
      set { _skillId = value; }
    }
    [global::System.Xml.Serialization.XmlIgnore]
    [global::System.ComponentModel.Browsable(false)]
    public bool skillIdSpecified
    {
      get { return this._skillId != null; }
      set { if (value == (this._skillId== null)) this._skillId = value ? this.skillId : (uint?)null; }
    }
    private bool ShouldSerializeskillId() { return skillIdSpecified; }
    private void ResetskillId() { skillIdSpecified = false; }
    
    private uint? _level;
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"level", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public uint level
    {
      get { return _level?? default(uint); }
      set { _level = value; }
    }
    [global::System.Xml.Serialization.XmlIgnore]
    [global::System.ComponentModel.Browsable(false)]
    public bool levelSpecified
    {
      get { return this._level != null; }
      set { if (value == (this._level== null)) this._level = value ? this.level : (uint?)null; }
    }
    private bool ShouldSerializelevel() { return levelSpecified; }
    private void Resetlevel() { levelSpecified = false; }
    
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"CmdGuildSkillDataNtf")]
  public partial class CmdGuildSkillDataNtf : global::ProtoBuf.IExtensible
  {
    public CmdGuildSkillDataNtf() {}
    
    private readonly global::System.Collections.Generic.List<Proto.GuildSkillEntry> _skills = new global::System.Collections.Generic.List<Proto.GuildSkillEntry>();
    [global::ProtoBuf.ProtoMember(1, Name=@"skills", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public global::System.Collections.Generic.List<Proto.GuildSkillEntry> skills
    {
      get { return _skills; }
    }
  
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"CmdGuildSkillUpdateNtf")]
  public partial class CmdGuildSkillUpdateNtf : global::ProtoBuf.IExtensible
  {
    public CmdGuildSkillUpdateNtf() {}
    
    private Proto.GuildSkillEntry _skill = null;
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"skill", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(null)]
    public Proto.GuildSkillEntry skill
    {
      get { return _skill; }
      set { _skill = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"CmdGuildSkillLevelUpReq")]
  public partial class CmdGuildSkillLevelUpReq : global::ProtoBuf.IExtensible
  {
    public CmdGuildSkillLevelUpReq() {}
    
    private uint? _skillId;
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"skillId", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public uint skillId
    {
      get { return _skillId?? default(uint); }
      set { _skillId = value; }
    }
    [global::System.Xml.Serialization.XmlIgnore]
    [global::System.ComponentModel.Browsable(false)]
    public bool skillIdSpecified
    {
      get { return this._skillId != null; }
      set { if (value == (this._skillId== null)) this._skillId = value ? this.skillId : (uint?)null; }
    }
    private bool ShouldSerializeskillId() { return skillIdSpecified; }
    private void ResetskillId() { skillIdSpecified = false; }
    
    private uint? _level;
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"level", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public uint level
    {
      get { return _level?? default(uint); }
      set { _level = value; }
    }
    [global::System.Xml.Serialization.XmlIgnore]
    [global::System.ComponentModel.Browsable(false)]
    public bool levelSpecified
    {
      get { return this._level != null; }
      set { if (value == (this._level== null)) this._level = value ? this.level : (uint?)null; }
    }
    private bool ShouldSerializelevel() { return levelSpecified; }
    private void Resetlevel() { levelSpecified = false; }
    
    private uint? _targetLevel;
    [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"targetLevel", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public uint targetLevel
    {
      get { return _targetLevel?? default(uint); }
      set { _targetLevel = value; }
    }
    [global::System.Xml.Serialization.XmlIgnore]
    [global::System.ComponentModel.Browsable(false)]
    public bool targetLevelSpecified
    {
      get { return this._targetLevel != null; }
      set { if (value == (this._targetLevel== null)) this._targetLevel = value ? this.targetLevel : (uint?)null; }
    }
    private bool ShouldSerializetargetLevel() { return targetLevelSpecified; }
    private void ResettargetLevel() { targetLevelSpecified = false; }
    
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"CmdGuildSkillLevelUpRes")]
  public partial class CmdGuildSkillLevelUpRes : global::ProtoBuf.IExtensible
  {
    public CmdGuildSkillLevelUpRes() {}
    
    private uint? _skillId;
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"skillId", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public uint skillId
    {
      get { return _skillId?? default(uint); }
      set { _skillId = value; }
    }
    [global::System.Xml.Serialization.XmlIgnore]
    [global::System.ComponentModel.Browsable(false)]
    public bool skillIdSpecified
    {
      get { return this._skillId != null; }
      set { if (value == (this._skillId== null)) this._skillId = value ? this.skillId : (uint?)null; }
    }
    private bool ShouldSerializeskillId() { return skillIdSpecified; }
    private void ResetskillId() { skillIdSpecified = false; }
    
    private uint? _spendContri;
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"spendContri", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public uint spendContri
    {
      get { return _spendContri?? default(uint); }
      set { _spendContri = value; }
    }
    [global::System.Xml.Serialization.XmlIgnore]
    [global::System.ComponentModel.Browsable(false)]
    public bool spendContriSpecified
    {
      get { return this._spendContri != null; }
      set { if (value == (this._spendContri== null)) this._spendContri = value ? this.spendContri : (uint?)null; }
    }
    private bool ShouldSerializespendContri() { return spendContriSpecified; }
    private void ResetspendContri() { spendContriSpecified = false; }
    
    private uint? _spendCoin;
    [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"spendCoin", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public uint spendCoin
    {
      get { return _spendCoin?? default(uint); }
      set { _spendCoin = value; }
    }
    [global::System.Xml.Serialization.XmlIgnore]
    [global::System.ComponentModel.Browsable(false)]
    public bool spendCoinSpecified
    {
      get { return this._spendCoin != null; }
      set { if (value == (this._spendCoin== null)) this._spendCoin = value ? this.spendCoin : (uint?)null; }
    }
    private bool ShouldSerializespendCoin() { return spendCoinSpecified; }
    private void ResetspendCoin() { spendCoinSpecified = false; }
    
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
    [global::ProtoBuf.ProtoContract(Name=@"CmdGuildSkill")]
    public enum CmdGuildSkill
    {
            
      [global::ProtoBuf.ProtoEnum(Name=@"CmdGuildSkill_DataNtf", Value=6701)]
      CmdGuildSkill_DataNtf = 6701,
            
      [global::ProtoBuf.ProtoEnum(Name=@"CmdGuildSkill_UpdateNtf", Value=6702)]
      CmdGuildSkill_UpdateNtf = 6702,
            
      [global::ProtoBuf.ProtoEnum(Name=@"CmdGuildSkill_LevelUpReq", Value=6703)]
      CmdGuildSkill_LevelUpReq = 6703,
            
      [global::ProtoBuf.ProtoEnum(Name=@"CmdGuildSkill_LevelUpRes", Value=6704)]
      CmdGuildSkill_LevelUpRes = 6704
    }
  
    [global::ProtoBuf.ProtoContract(Name=@"ErrorCmdGuildSkill")]
    public enum ErrorCmdGuildSkill
    {
            
      [global::ProtoBuf.ProtoEnum(Name=@"ErrorGuildSkill_InfoNotFound", Value=6701)]
      ErrorGuildSkill_InfoNotFound = 6701,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ErrorGuildSkill_AlreadyFull", Value=6702)]
      ErrorGuildSkill_AlreadyFull = 6702,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ErrorGuildSkill_GuildNotExist", Value=6703)]
      ErrorGuildSkill_GuildNotExist = 6703,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ErrorGuildSkill_StartLevelWrong", Value=6704)]
      ErrorGuildSkill_StartLevelWrong = 6704,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ErrorGuildSkill_TargetLevelWrong", Value=6705)]
      ErrorGuildSkill_TargetLevelWrong = 6705,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ErrorGuildSKill_OpenLevelLimit", Value=6706)]
      ErrorGuildSKill_OpenLevelLimit = 6706,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ErrorGuildSkill_OpenGuildTechLevelLimit", Value=6707)]
      ErrorGuildSkill_OpenGuildTechLevelLimit = 6707,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ErrorGuildSkill_UpLevelLimit", Value=6708)]
      ErrorGuildSkill_UpLevelLimit = 6708,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ErrorGuildSkill_UpGuildTechLevelLimit", Value=6709)]
      ErrorGuildSkill_UpGuildTechLevelLimit = 6709,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ErrorGuildSkill_UpSrcLevelInfoNotFound", Value=6710)]
      ErrorGuildSkill_UpSrcLevelInfoNotFound = 6710,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ErrorGuildSkill_UpDstLevelInfoNotFound", Value=6711)]
      ErrorGuildSkill_UpDstLevelInfoNotFound = 6711,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ErrorGuildSkill_SkillLevelAlreadyMax", Value=6712)]
      ErrorGuildSkill_SkillLevelAlreadyMax = 6712,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ErrorGuildSkill_LevelInfoConfigWrong", Value=6713)]
      ErrorGuildSkill_LevelInfoConfigWrong = 6713
    }
  
}
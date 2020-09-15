// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: clientData.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
/// <summary>Holder for reflection information generated from clientData.proto</summary>
public static partial class ClientDataReflection {

  #region Descriptor
  /// <summary>File descriptor for clientData.proto</summary>
  public static pbr::FileDescriptor Descriptor {
    get { return descriptor; }
  }
  private static pbr::FileDescriptor descriptor;

  static ClientDataReflection() {
    byte[] descriptorData = global::System.Convert.FromBase64String(
        string.Concat(
          "ChBjbGllbnREYXRhLnByb3RvIjcKFHN0X2FjdGlvbl9zb3VuZF9kYXRhEgoK",
          "AklEGAEgASgREhMKC2FjdGlvblNvdW5kGAIgASgMQgJIA2IGcHJvdG8z"));
    descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
        new pbr::FileDescriptor[] { },
        new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
          new pbr::GeneratedClrTypeInfo(typeof(global::st_action_sound_data), global::st_action_sound_data.Parser, new[]{ "ID", "ActionSound" }, null, null, null, null)
        }));
  }
  #endregion

}
#region Messages
public sealed partial class st_action_sound_data : pb::IMessage<st_action_sound_data>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    , pb::IBufferMessage
#endif
{
  private static readonly pb::MessageParser<st_action_sound_data> _parser = new pb::MessageParser<st_action_sound_data>(() => new st_action_sound_data());
  private pb::UnknownFieldSet _unknownFields;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public static pb::MessageParser<st_action_sound_data> Parser { get { return _parser; } }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public static pbr::MessageDescriptor Descriptor {
    get { return global::ClientDataReflection.Descriptor.MessageTypes[0]; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  pbr::MessageDescriptor pb::IMessage.Descriptor {
    get { return Descriptor; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public st_action_sound_data() {
    OnConstruction();
  }

  partial void OnConstruction();

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public st_action_sound_data(st_action_sound_data other) : this() {
    iD_ = other.iD_;
    actionSound_ = other.actionSound_;
    _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public st_action_sound_data Clone() {
    return new st_action_sound_data(this);
  }

  /// <summary>Field number for the "ID" field.</summary>
  public const int IDFieldNumber = 1;
  private int iD_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public int ID {
    get { return iD_; }
    set {
      iD_ = value;
    }
  }

  /// <summary>Field number for the "actionSound" field.</summary>
  public const int ActionSoundFieldNumber = 2;
  private pb::ByteString actionSound_ = pb::ByteString.Empty;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public pb::ByteString ActionSound {
    get { return actionSound_; }
    set {
      actionSound_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
    }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public override bool Equals(object other) {
    return Equals(other as st_action_sound_data);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public bool Equals(st_action_sound_data other) {
    if (ReferenceEquals(other, null)) {
      return false;
    }
    if (ReferenceEquals(other, this)) {
      return true;
    }
    if (ID != other.ID) return false;
    if (ActionSound != other.ActionSound) return false;
    return Equals(_unknownFields, other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public override int GetHashCode() {
    int hash = 1;
    if (ID != 0) hash ^= ID.GetHashCode();
    if (ActionSound.Length != 0) hash ^= ActionSound.GetHashCode();
    if (_unknownFields != null) {
      hash ^= _unknownFields.GetHashCode();
    }
    return hash;
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public override string ToString() {
    return pb::JsonFormatter.ToDiagnosticString(this);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public void WriteTo(pb::CodedOutputStream output) {
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    output.WriteRawMessage(this);
  #else
    if (ID != 0) {
      output.WriteRawTag(8);
      output.WriteSInt32(ID);
    }
    if (ActionSound.Length != 0) {
      output.WriteRawTag(18);
      output.WriteBytes(ActionSound);
    }
    if (_unknownFields != null) {
      _unknownFields.WriteTo(output);
    }
  #endif
  }

  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
    if (ID != 0) {
      output.WriteRawTag(8);
      output.WriteSInt32(ID);
    }
    if (ActionSound.Length != 0) {
      output.WriteRawTag(18);
      output.WriteBytes(ActionSound);
    }
    if (_unknownFields != null) {
      _unknownFields.WriteTo(ref output);
    }
  }
  #endif

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public int CalculateSize() {
    int size = 0;
    if (ID != 0) {
      size += 1 + pb::CodedOutputStream.ComputeSInt32Size(ID);
    }
    if (ActionSound.Length != 0) {
      size += 1 + pb::CodedOutputStream.ComputeBytesSize(ActionSound);
    }
    if (_unknownFields != null) {
      size += _unknownFields.CalculateSize();
    }
    return size;
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public void MergeFrom(st_action_sound_data other) {
    if (other == null) {
      return;
    }
    if (other.ID != 0) {
      ID = other.ID;
    }
    if (other.ActionSound.Length != 0) {
      ActionSound = other.ActionSound;
    }
    _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public void MergeFrom(pb::CodedInputStream input) {
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    input.ReadRawMessage(this);
  #else
    uint tag;
    while ((tag = input.ReadTag()) != 0) {
      switch(tag) {
        default:
          _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
          break;
        case 8: {
          ID = input.ReadSInt32();
          break;
        }
        case 18: {
          ActionSound = input.ReadBytes();
          break;
        }
      }
    }
  #endif
  }

  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  void pb::IBufferMessage.InternalMergeFrom(ref pb::ParseContext input) {
    uint tag;
    while ((tag = input.ReadTag()) != 0) {
      switch(tag) {
        default:
          _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
          break;
        case 8: {
          ID = input.ReadSInt32();
          break;
        }
        case 18: {
          ActionSound = input.ReadBytes();
          break;
        }
      }
    }
  }
  #endif

}

#endregion


#endregion Designer generated code
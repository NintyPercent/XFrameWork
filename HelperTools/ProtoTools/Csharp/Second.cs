// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: Second.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
/// <summary>Holder for reflection information generated from Second.proto</summary>
public static partial class SecondReflection {

  #region Descriptor
  /// <summary>File descriptor for Second.proto</summary>
  public static pbr::FileDescriptor Descriptor {
    get { return descriptor; }
  }
  private static pbr::FileDescriptor descriptor;

  static SecondReflection() {
    byte[] descriptorData = global::System.Convert.FromBase64String(
        string.Concat(
          "CgxTZWNvbmQucHJvdG8iLwoIbG9jYXRpb24SCQoBeBgBIAEoBRIJCgF5GAIg",
          "ASgFEg0KBWxheWVyGAMgASgFYgZwcm90bzM="));
    descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
        new pbr::FileDescriptor[] { },
        new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
          new pbr::GeneratedClrTypeInfo(typeof(global::location), global::location.Parser, new[]{ "X", "Y", "Layer" }, null, null, null, null)
        }));
  }
  #endregion

}
#region Messages
public sealed partial class location : pb::IMessage<location>
#if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    , pb::IBufferMessage
#endif
{
  private static readonly pb::MessageParser<location> _parser = new pb::MessageParser<location>(() => new location());
  private pb::UnknownFieldSet _unknownFields;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public static pb::MessageParser<location> Parser { get { return _parser; } }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public static pbr::MessageDescriptor Descriptor {
    get { return global::SecondReflection.Descriptor.MessageTypes[0]; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  pbr::MessageDescriptor pb::IMessage.Descriptor {
    get { return Descriptor; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public location() {
    OnConstruction();
  }

  partial void OnConstruction();

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public location(location other) : this() {
    x_ = other.x_;
    y_ = other.y_;
    layer_ = other.layer_;
    _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public location Clone() {
    return new location(this);
  }

  /// <summary>Field number for the "x" field.</summary>
  public const int XFieldNumber = 1;
  private int x_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public int X {
    get { return x_; }
    set {
      x_ = value;
    }
  }

  /// <summary>Field number for the "y" field.</summary>
  public const int YFieldNumber = 2;
  private int y_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public int Y {
    get { return y_; }
    set {
      y_ = value;
    }
  }

  /// <summary>Field number for the "layer" field.</summary>
  public const int LayerFieldNumber = 3;
  private int layer_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public int Layer {
    get { return layer_; }
    set {
      layer_ = value;
    }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public override bool Equals(object other) {
    return Equals(other as location);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public bool Equals(location other) {
    if (ReferenceEquals(other, null)) {
      return false;
    }
    if (ReferenceEquals(other, this)) {
      return true;
    }
    if (X != other.X) return false;
    if (Y != other.Y) return false;
    if (Layer != other.Layer) return false;
    return Equals(_unknownFields, other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public override int GetHashCode() {
    int hash = 1;
    if (X != 0) hash ^= X.GetHashCode();
    if (Y != 0) hash ^= Y.GetHashCode();
    if (Layer != 0) hash ^= Layer.GetHashCode();
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
    if (X != 0) {
      output.WriteRawTag(8);
      output.WriteInt32(X);
    }
    if (Y != 0) {
      output.WriteRawTag(16);
      output.WriteInt32(Y);
    }
    if (Layer != 0) {
      output.WriteRawTag(24);
      output.WriteInt32(Layer);
    }
    if (_unknownFields != null) {
      _unknownFields.WriteTo(output);
    }
  #endif
  }

  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
    if (X != 0) {
      output.WriteRawTag(8);
      output.WriteInt32(X);
    }
    if (Y != 0) {
      output.WriteRawTag(16);
      output.WriteInt32(Y);
    }
    if (Layer != 0) {
      output.WriteRawTag(24);
      output.WriteInt32(Layer);
    }
    if (_unknownFields != null) {
      _unknownFields.WriteTo(ref output);
    }
  }
  #endif

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public int CalculateSize() {
    int size = 0;
    if (X != 0) {
      size += 1 + pb::CodedOutputStream.ComputeInt32Size(X);
    }
    if (Y != 0) {
      size += 1 + pb::CodedOutputStream.ComputeInt32Size(Y);
    }
    if (Layer != 0) {
      size += 1 + pb::CodedOutputStream.ComputeInt32Size(Layer);
    }
    if (_unknownFields != null) {
      size += _unknownFields.CalculateSize();
    }
    return size;
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public void MergeFrom(location other) {
    if (other == null) {
      return;
    }
    if (other.X != 0) {
      X = other.X;
    }
    if (other.Y != 0) {
      Y = other.Y;
    }
    if (other.Layer != 0) {
      Layer = other.Layer;
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
          X = input.ReadInt32();
          break;
        }
        case 16: {
          Y = input.ReadInt32();
          break;
        }
        case 24: {
          Layer = input.ReadInt32();
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
          X = input.ReadInt32();
          break;
        }
        case 16: {
          Y = input.ReadInt32();
          break;
        }
        case 24: {
          Layer = input.ReadInt32();
          break;
        }
      }
    }
  }
  #endif

}

#endregion


#endregion Designer generated code

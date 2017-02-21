// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: POGOProtos/Map/Pokemon/NearbyPokemon.proto
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace POGOProtos.Map.Pokemon {

  /// <summary>Holder for reflection information generated from POGOProtos/Map/Pokemon/NearbyPokemon.proto</summary>
  public static partial class NearbyPokemonReflection {

    #region Descriptor
    /// <summary>File descriptor for POGOProtos/Map/Pokemon/NearbyPokemon.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static NearbyPokemonReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CipQT0dPUHJvdG9zL01hcC9Qb2tlbW9uL05lYXJieVBva2Vtb24ucHJvdG8S",
            "FlBPR09Qcm90b3MuTWFwLlBva2Vtb24aIFBPR09Qcm90b3MvRW51bXMvUG9r",
            "ZW1vbklkLnByb3RvGiRQT0dPUHJvdG9zL0RhdGEvUG9rZW1vbkRpc3BsYXku",
            "cHJvdG8i1QEKDU5lYXJieVBva2Vtb24SLwoKcG9rZW1vbl9pZBgBIAEoDjIb",
            "LlBPR09Qcm90b3MuRW51bXMuUG9rZW1vbklkEhoKEmRpc3RhbmNlX2luX21l",
            "dGVycxgCIAEoAhIUCgxlbmNvdW50ZXJfaWQYAyABKAYSDwoHZm9ydF9pZBgE",
            "IAEoCRIWCg5mb3J0X2ltYWdlX3VybBgFIAEoCRI4Cg9wb2tlbW9uX2Rpc3Bs",
            "YXkYBiABKAsyHy5QT0dPUHJvdG9zLkRhdGEuUG9rZW1vbkRpc3BsYXliBnBy",
            "b3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::POGOProtos.Enums.PokemonIdReflection.Descriptor, global::POGOProtos.Data.PokemonDisplayReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::POGOProtos.Map.Pokemon.NearbyPokemon), global::POGOProtos.Map.Pokemon.NearbyPokemon.Parser, new[]{ "PokemonId", "DistanceInMeters", "EncounterId", "FortId", "FortImageUrl", "PokemonDisplay" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class NearbyPokemon : pb::IMessage<NearbyPokemon> {
    private static readonly pb::MessageParser<NearbyPokemon> _parser = new pb::MessageParser<NearbyPokemon>(() => new NearbyPokemon());
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<NearbyPokemon> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::POGOProtos.Map.Pokemon.NearbyPokemonReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public NearbyPokemon() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public NearbyPokemon(NearbyPokemon other) : this() {
      pokemonId_ = other.pokemonId_;
      distanceInMeters_ = other.distanceInMeters_;
      encounterId_ = other.encounterId_;
      fortId_ = other.fortId_;
      fortImageUrl_ = other.fortImageUrl_;
      PokemonDisplay = other.pokemonDisplay_ != null ? other.PokemonDisplay.Clone() : null;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public NearbyPokemon Clone() {
      return new NearbyPokemon(this);
    }

    /// <summary>Field number for the "pokemon_id" field.</summary>
    public const int PokemonIdFieldNumber = 1;
    private global::POGOProtos.Enums.PokemonId pokemonId_ = 0;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::POGOProtos.Enums.PokemonId PokemonId {
      get { return pokemonId_; }
      set {
        pokemonId_ = value;
      }
    }

    /// <summary>Field number for the "distance_in_meters" field.</summary>
    public const int DistanceInMetersFieldNumber = 2;
    private float distanceInMeters_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public float DistanceInMeters {
      get { return distanceInMeters_; }
      set {
        distanceInMeters_ = value;
      }
    }

    /// <summary>Field number for the "encounter_id" field.</summary>
    public const int EncounterIdFieldNumber = 3;
    private ulong encounterId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ulong EncounterId {
      get { return encounterId_; }
      set {
        encounterId_ = value;
      }
    }

    /// <summary>Field number for the "fort_id" field.</summary>
    public const int FortIdFieldNumber = 4;
    private string fortId_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string FortId {
      get { return fortId_; }
      set {
        fortId_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "fort_image_url" field.</summary>
    public const int FortImageUrlFieldNumber = 5;
    private string fortImageUrl_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string FortImageUrl {
      get { return fortImageUrl_; }
      set {
        fortImageUrl_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "pokemon_display" field.</summary>
    public const int PokemonDisplayFieldNumber = 6;
    private global::POGOProtos.Data.PokemonDisplay pokemonDisplay_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::POGOProtos.Data.PokemonDisplay PokemonDisplay {
      get { return pokemonDisplay_; }
      set {
        pokemonDisplay_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as NearbyPokemon);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(NearbyPokemon other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (PokemonId != other.PokemonId) return false;
      if (DistanceInMeters != other.DistanceInMeters) return false;
      if (EncounterId != other.EncounterId) return false;
      if (FortId != other.FortId) return false;
      if (FortImageUrl != other.FortImageUrl) return false;
      if (!object.Equals(PokemonDisplay, other.PokemonDisplay)) return false;
      return true;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (PokemonId != 0) hash ^= PokemonId.GetHashCode();
      if (DistanceInMeters != 0F) hash ^= DistanceInMeters.GetHashCode();
      if (EncounterId != 0UL) hash ^= EncounterId.GetHashCode();
      if (FortId.Length != 0) hash ^= FortId.GetHashCode();
      if (FortImageUrl.Length != 0) hash ^= FortImageUrl.GetHashCode();
      if (pokemonDisplay_ != null) hash ^= PokemonDisplay.GetHashCode();
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (PokemonId != 0) {
        output.WriteRawTag(8);
        output.WriteEnum((int) PokemonId);
      }
      if (DistanceInMeters != 0F) {
        output.WriteRawTag(21);
        output.WriteFloat(DistanceInMeters);
      }
      if (EncounterId != 0UL) {
        output.WriteRawTag(25);
        output.WriteFixed64(EncounterId);
      }
      if (FortId.Length != 0) {
        output.WriteRawTag(34);
        output.WriteString(FortId);
      }
      if (FortImageUrl.Length != 0) {
        output.WriteRawTag(42);
        output.WriteString(FortImageUrl);
      }
      if (pokemonDisplay_ != null) {
        output.WriteRawTag(50);
        output.WriteMessage(PokemonDisplay);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (PokemonId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) PokemonId);
      }
      if (DistanceInMeters != 0F) {
        size += 1 + 4;
      }
      if (EncounterId != 0UL) {
        size += 1 + 8;
      }
      if (FortId.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(FortId);
      }
      if (FortImageUrl.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(FortImageUrl);
      }
      if (pokemonDisplay_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(PokemonDisplay);
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(NearbyPokemon other) {
      if (other == null) {
        return;
      }
      if (other.PokemonId != 0) {
        PokemonId = other.PokemonId;
      }
      if (other.DistanceInMeters != 0F) {
        DistanceInMeters = other.DistanceInMeters;
      }
      if (other.EncounterId != 0UL) {
        EncounterId = other.EncounterId;
      }
      if (other.FortId.Length != 0) {
        FortId = other.FortId;
      }
      if (other.FortImageUrl.Length != 0) {
        FortImageUrl = other.FortImageUrl;
      }
      if (other.pokemonDisplay_ != null) {
        if (pokemonDisplay_ == null) {
          pokemonDisplay_ = new global::POGOProtos.Data.PokemonDisplay();
        }
        PokemonDisplay.MergeFrom(other.PokemonDisplay);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            input.SkipLastField();
            break;
          case 8: {
            pokemonId_ = (global::POGOProtos.Enums.PokemonId) input.ReadEnum();
            break;
          }
          case 21: {
            DistanceInMeters = input.ReadFloat();
            break;
          }
          case 25: {
            EncounterId = input.ReadFixed64();
            break;
          }
          case 34: {
            FortId = input.ReadString();
            break;
          }
          case 42: {
            FortImageUrl = input.ReadString();
            break;
          }
          case 50: {
            if (pokemonDisplay_ == null) {
              pokemonDisplay_ = new global::POGOProtos.Data.PokemonDisplay();
            }
            input.ReadMessage(pokemonDisplay_);
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code

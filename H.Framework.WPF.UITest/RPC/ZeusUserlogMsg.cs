// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: zeus_userlog_msg.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Zeus.RPC.Protocol {

  /// <summary>Holder for reflection information generated from zeus_userlog_msg.proto</summary>
  public static partial class ZeusUserlogMsgReflection {

    #region Descriptor
    /// <summary>File descriptor for zeus_userlog_msg.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static ZeusUserlogMsgReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChZ6ZXVzX3VzZXJsb2dfbXNnLnByb3RvEhFaZXVzLlJQQy5Qcm90b2NvbBoO",
            "emV1c19tc2cucHJvdG8i4wEKClVzZXJMb2dSZXESEAoIdXNlcm5hbWUYASAB",
            "KAkSDwoHY291bnRlchgCIAEoCRIPCgdjb21wYW55GAMgASgJEg8KB2FjY291",
            "bnQYBCABKAkSLgoGYWN0aW9uGAUgASgOMh4uWmV1cy5SUEMuUHJvdG9jb2wu",
            "VHJhZGVBY3Rpb24SDgoGcmVzdWx0GAYgASgJEg8KB2NvbnRlbnQYByABKAkS",
            "EAoIZXh0X2pzb24YCCABKAkSLQoIUGxhdGZvcm0YCSABKA4yGy5aZXVzLlJQ",
            "Qy5Qcm90b2NvbC5QbGF0Zm9ybSI8CgtVc2VyTG9nUmVzcBItCgRyZXNwGAEg",
            "ASgLMh8uWmV1cy5SUEMuUHJvdG9jb2wuQmFzZVJlc3BvbnNlMmIKEVVzZXJM",
            "b2dScGNTZXJ2aWNlEk0KCkFkZFVzZXJMb2cSHS5aZXVzLlJQQy5Qcm90b2Nv",
            "bC5Vc2VyTG9nUmVxGh4uWmV1cy5SUEMuUHJvdG9jb2wuVXNlckxvZ1Jlc3Ai",
            "AGIGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Zeus.RPC.Protocol.ZeusMsgReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Zeus.RPC.Protocol.UserLogReq), global::Zeus.RPC.Protocol.UserLogReq.Parser, new[]{ "Username", "Counter", "Company", "Account", "Action", "Result", "Content", "ExtJson", "Platform" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Zeus.RPC.Protocol.UserLogResp), global::Zeus.RPC.Protocol.UserLogResp.Parser, new[]{ "Resp" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class UserLogReq : pb::IMessage<UserLogReq> {
    private static readonly pb::MessageParser<UserLogReq> _parser = new pb::MessageParser<UserLogReq>(() => new UserLogReq());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<UserLogReq> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Zeus.RPC.Protocol.ZeusUserlogMsgReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public UserLogReq() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public UserLogReq(UserLogReq other) : this() {
      username_ = other.username_;
      counter_ = other.counter_;
      company_ = other.company_;
      account_ = other.account_;
      action_ = other.action_;
      result_ = other.result_;
      content_ = other.content_;
      extJson_ = other.extJson_;
      platform_ = other.platform_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public UserLogReq Clone() {
      return new UserLogReq(this);
    }

    /// <summary>Field number for the "username" field.</summary>
    public const int UsernameFieldNumber = 1;
    private string username_ = "";
    /// <summary>
    ///用户名
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Username {
      get { return username_; }
      set {
        username_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "counter" field.</summary>
    public const int CounterFieldNumber = 2;
    private string counter_ = "";
    /// <summary>
    ///柜台
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Counter {
      get { return counter_; }
      set {
        counter_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "company" field.</summary>
    public const int CompanyFieldNumber = 3;
    private string company_ = "";
    /// <summary>
    ///期货公司
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Company {
      get { return company_; }
      set {
        company_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "account" field.</summary>
    public const int AccountFieldNumber = 4;
    private string account_ = "";
    /// <summary>
    ///资金账号
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Account {
      get { return account_; }
      set {
        account_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "action" field.</summary>
    public const int ActionFieldNumber = 5;
    private global::Zeus.RPC.Protocol.TradeAction action_ = 0;
    /// <summary>
    ///用户动作
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Zeus.RPC.Protocol.TradeAction Action {
      get { return action_; }
      set {
        action_ = value;
      }
    }

    /// <summary>Field number for the "result" field.</summary>
    public const int ResultFieldNumber = 6;
    private string result_ = "";
    /// <summary>
    ///结果
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Result {
      get { return result_; }
      set {
        result_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "content" field.</summary>
    public const int ContentFieldNumber = 7;
    private string content_ = "";
    /// <summary>
    ///内容
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Content {
      get { return content_; }
      set {
        content_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "ext_json" field.</summary>
    public const int ExtJsonFieldNumber = 8;
    private string extJson_ = "";
    /// <summary>
    ///扩展json
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string ExtJson {
      get { return extJson_; }
      set {
        extJson_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "Platform" field.</summary>
    public const int PlatformFieldNumber = 9;
    private global::Zeus.RPC.Protocol.Platform platform_ = 0;
    /// <summary>
    ///平台
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Zeus.RPC.Protocol.Platform Platform {
      get { return platform_; }
      set {
        platform_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as UserLogReq);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(UserLogReq other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Username != other.Username) return false;
      if (Counter != other.Counter) return false;
      if (Company != other.Company) return false;
      if (Account != other.Account) return false;
      if (Action != other.Action) return false;
      if (Result != other.Result) return false;
      if (Content != other.Content) return false;
      if (ExtJson != other.ExtJson) return false;
      if (Platform != other.Platform) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Username.Length != 0) hash ^= Username.GetHashCode();
      if (Counter.Length != 0) hash ^= Counter.GetHashCode();
      if (Company.Length != 0) hash ^= Company.GetHashCode();
      if (Account.Length != 0) hash ^= Account.GetHashCode();
      if (Action != 0) hash ^= Action.GetHashCode();
      if (Result.Length != 0) hash ^= Result.GetHashCode();
      if (Content.Length != 0) hash ^= Content.GetHashCode();
      if (ExtJson.Length != 0) hash ^= ExtJson.GetHashCode();
      if (Platform != 0) hash ^= Platform.GetHashCode();
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
      if (Username.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(Username);
      }
      if (Counter.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(Counter);
      }
      if (Company.Length != 0) {
        output.WriteRawTag(26);
        output.WriteString(Company);
      }
      if (Account.Length != 0) {
        output.WriteRawTag(34);
        output.WriteString(Account);
      }
      if (Action != 0) {
        output.WriteRawTag(40);
        output.WriteEnum((int) Action);
      }
      if (Result.Length != 0) {
        output.WriteRawTag(50);
        output.WriteString(Result);
      }
      if (Content.Length != 0) {
        output.WriteRawTag(58);
        output.WriteString(Content);
      }
      if (ExtJson.Length != 0) {
        output.WriteRawTag(66);
        output.WriteString(ExtJson);
      }
      if (Platform != 0) {
        output.WriteRawTag(72);
        output.WriteEnum((int) Platform);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (Username.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Username);
      }
      if (Counter.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Counter);
      }
      if (Company.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Company);
      }
      if (Account.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Account);
      }
      if (Action != 0) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) Action);
      }
      if (Result.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Result);
      }
      if (Content.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Content);
      }
      if (ExtJson.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(ExtJson);
      }
      if (Platform != 0) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) Platform);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(UserLogReq other) {
      if (other == null) {
        return;
      }
      if (other.Username.Length != 0) {
        Username = other.Username;
      }
      if (other.Counter.Length != 0) {
        Counter = other.Counter;
      }
      if (other.Company.Length != 0) {
        Company = other.Company;
      }
      if (other.Account.Length != 0) {
        Account = other.Account;
      }
      if (other.Action != 0) {
        Action = other.Action;
      }
      if (other.Result.Length != 0) {
        Result = other.Result;
      }
      if (other.Content.Length != 0) {
        Content = other.Content;
      }
      if (other.ExtJson.Length != 0) {
        ExtJson = other.ExtJson;
      }
      if (other.Platform != 0) {
        Platform = other.Platform;
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 10: {
            Username = input.ReadString();
            break;
          }
          case 18: {
            Counter = input.ReadString();
            break;
          }
          case 26: {
            Company = input.ReadString();
            break;
          }
          case 34: {
            Account = input.ReadString();
            break;
          }
          case 40: {
            Action = (global::Zeus.RPC.Protocol.TradeAction) input.ReadEnum();
            break;
          }
          case 50: {
            Result = input.ReadString();
            break;
          }
          case 58: {
            Content = input.ReadString();
            break;
          }
          case 66: {
            ExtJson = input.ReadString();
            break;
          }
          case 72: {
            Platform = (global::Zeus.RPC.Protocol.Platform) input.ReadEnum();
            break;
          }
        }
      }
    }

  }

  public sealed partial class UserLogResp : pb::IMessage<UserLogResp> {
    private static readonly pb::MessageParser<UserLogResp> _parser = new pb::MessageParser<UserLogResp>(() => new UserLogResp());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<UserLogResp> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Zeus.RPC.Protocol.ZeusUserlogMsgReflection.Descriptor.MessageTypes[1]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public UserLogResp() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public UserLogResp(UserLogResp other) : this() {
      resp_ = other.resp_ != null ? other.resp_.Clone() : null;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public UserLogResp Clone() {
      return new UserLogResp(this);
    }

    /// <summary>Field number for the "resp" field.</summary>
    public const int RespFieldNumber = 1;
    private global::Zeus.RPC.Protocol.BaseResponse resp_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Zeus.RPC.Protocol.BaseResponse Resp {
      get { return resp_; }
      set {
        resp_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as UserLogResp);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(UserLogResp other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!object.Equals(Resp, other.Resp)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (resp_ != null) hash ^= Resp.GetHashCode();
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
      if (resp_ != null) {
        output.WriteRawTag(10);
        output.WriteMessage(Resp);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (resp_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Resp);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(UserLogResp other) {
      if (other == null) {
        return;
      }
      if (other.resp_ != null) {
        if (resp_ == null) {
          Resp = new global::Zeus.RPC.Protocol.BaseResponse();
        }
        Resp.MergeFrom(other.Resp);
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 10: {
            if (resp_ == null) {
              Resp = new global::Zeus.RPC.Protocol.BaseResponse();
            }
            input.ReadMessage(Resp);
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code

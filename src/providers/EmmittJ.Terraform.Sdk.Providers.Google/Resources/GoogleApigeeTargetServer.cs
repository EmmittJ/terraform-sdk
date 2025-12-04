using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for s_sl_info in GoogleApigeeTargetServer.
/// Nesting mode: list
/// </summary>
public class GoogleApigeeTargetServerSSlInfoBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "s_sl_info";

    /// <summary>
    /// The SSL/TLS cipher suites to be used. For programmable proxies, it must be one of the cipher suite names listed in: http://docs.oracle.com/javase/8/docs/technotes/guides/security/StandardNames.html#ciphersuites. For configurable proxies, it must follow the configuration specified in: https://commondatastorage.googleapis.com/chromium-boringssl-docs/ssl.h.html#Cipher-suite-configuration. This setting has no effect for configurable proxies when negotiating TLS 1.3.
    /// </summary>
    public TerraformList<string>? Ciphers
    {
        get => GetArgument<TerraformList<string>>("ciphers");
        set => SetArgument("ciphers", value);
    }

    /// <summary>
    /// Enables two-way TLS.
    /// </summary>
    public TerraformValue<bool>? ClientAuthEnabled
    {
        get => GetArgument<TerraformValue<bool>>("client_auth_enabled");
        set => SetArgument("client_auth_enabled", value);
    }

    /// <summary>
    /// Enables TLS. If false, neither one-way nor two-way TLS will be enabled.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Enabled is required")]
    public required TerraformValue<bool> Enabled
    {
        get => GetArgument<TerraformValue<bool>>("enabled");
        set => SetArgument("enabled", value);
    }

    /// <summary>
    /// If true, TLS is strictly enforced.
    /// </summary>
    public TerraformValue<bool>? Enforce
    {
        get => GetArgument<TerraformValue<bool>>("enforce");
        set => SetArgument("enforce", value);
    }

    /// <summary>
    /// If true, Edge ignores TLS certificate errors. Valid when configuring TLS for target servers and target endpoints, and when configuring virtual hosts that use 2-way TLS. When used with a target endpoint/target server, if the backend system uses SNI and returns a cert with a subject Distinguished Name (DN) that does not match the hostname, there is no way to ignore the error and the connection fails.
    /// </summary>
    public TerraformValue<bool>? IgnoreValidationErrors
    {
        get => GetArgument<TerraformValue<bool>>("ignore_validation_errors");
        set => SetArgument("ignore_validation_errors", value);
    }

    /// <summary>
    /// Required if clientAuthEnabled is true. The resource ID for the alias containing the private key and cert.
    /// </summary>
    public TerraformValue<string>? KeyAlias
    {
        get => GetArgument<TerraformValue<string>>("key_alias");
        set => SetArgument("key_alias", value);
    }

    /// <summary>
    /// Required if clientAuthEnabled is true. The resource ID of the keystore.
    /// </summary>
    public TerraformValue<string>? KeyStore
    {
        get => GetArgument<TerraformValue<string>>("key_store");
        set => SetArgument("key_store", value);
    }

    /// <summary>
    /// The TLS versioins to be used.
    /// </summary>
    public TerraformList<string>? Protocols
    {
        get => GetArgument<TerraformList<string>>("protocols");
        set => SetArgument("protocols", value);
    }

    /// <summary>
    /// The resource ID of the truststore.
    /// </summary>
    public TerraformValue<string>? TrustStore
    {
        get => GetArgument<TerraformValue<string>>("trust_store");
        set => SetArgument("trust_store", value);
    }

    /// <summary>
    /// CommonName block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 CommonName block(s) allowed")]
    public TerraformList<GoogleApigeeTargetServerSSlInfoBlockCommonNameBlock>? CommonName
    {
        get => GetArgument<TerraformList<GoogleApigeeTargetServerSSlInfoBlockCommonNameBlock>>("common_name");
        set => SetArgument("common_name", value);
    }

}

/// <summary>
/// Block type for common_name in GoogleApigeeTargetServerSSlInfoBlock.
/// Nesting mode: list
/// </summary>
public class GoogleApigeeTargetServerSSlInfoBlockCommonNameBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "common_name";

    /// <summary>
    /// The TLS Common Name string of the certificate.
    /// </summary>
    public TerraformValue<string>? Value
    {
        get => GetArgument<TerraformValue<string>>("value");
        set => SetArgument("value", value);
    }

    /// <summary>
    /// Indicates whether the cert should be matched against as a wildcard cert.
    /// </summary>
    public TerraformValue<bool>? WildcardMatch
    {
        get => GetArgument<TerraformValue<bool>>("wildcard_match");
        set => SetArgument("wildcard_match", value);
    }

}


/// <summary>
/// Block type for timeouts in GoogleApigeeTargetServer.
/// Nesting mode: single
/// </summary>
public class GoogleApigeeTargetServerTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "timeouts";

    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformValue<string>? Create
    {
        get => GetArgument<TerraformValue<string>>("create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformValue<string>? Delete
    {
        get => GetArgument<TerraformValue<string>>("delete");
        set => SetArgument("delete", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformValue<string>? Update
    {
        get => GetArgument<TerraformValue<string>>("update");
        set => SetArgument("update", value);
    }

}


/// <summary>
/// Represents a google_apigee_target_server Terraform resource.
/// Manages a google_apigee_target_server resource.
/// </summary>
public partial class GoogleApigeeTargetServer(string name) : TerraformResource("google_apigee_target_server", name)
{
    /// <summary>
    /// A human-readable description of this TargetServer.
    /// </summary>
    public TerraformValue<string>? Description
    {
        get => GetArgument<TerraformValue<string>>("description");
        set => SetArgument("description", value);
    }

    /// <summary>
    /// The Apigee environment group associated with the Apigee environment,
    /// in the format &#39;organizations/{{org_name}}/environments/{{env_name}}&#39;.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "EnvId is required")]
    public required TerraformValue<string> EnvId
    {
        get => GetArgument<TerraformValue<string>>("env_id");
        set => SetArgument("env_id", value);
    }

    /// <summary>
    /// The host name this target connects to. Value must be a valid hostname as described by RFC-1123.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Host is required")]
    public required TerraformValue<string> Host
    {
        get => GetArgument<TerraformValue<string>>("host");
        set => SetArgument("host", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string>? Id
    {
        get => GetArgument<TerraformValue<string>>("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// Enabling/disabling a TargetServer is useful when TargetServers are used in load balancing configurations, and one or more TargetServers need to taken out of rotation periodically. Defaults to true.
    /// </summary>
    public TerraformValue<bool>? IsEnabled
    {
        get => GetArgument<TerraformValue<bool>>("is_enabled");
        set => SetArgument("is_enabled", value);
    }

    /// <summary>
    /// The resource id of this reference. Values must match the regular expression [\w\s-.]+.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The port number this target connects to on the given host. Value must be between 1 and 65535, inclusive.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Port is required")]
    public required TerraformValue<double> Port
    {
        get => GetArgument<TerraformValue<double>>("port");
        set => SetArgument("port", value);
    }

    /// <summary>
    /// Immutable. The protocol used by this TargetServer. Possible values: [&amp;quot;HTTP&amp;quot;, &amp;quot;HTTP2&amp;quot;, &amp;quot;GRPC_TARGET&amp;quot;, &amp;quot;GRPC&amp;quot;, &amp;quot;EXTERNAL_CALLOUT&amp;quot;]
    /// </summary>
    public TerraformValue<string>? Protocol
    {
        get => GetArgument<TerraformValue<string>>("protocol");
        set => SetArgument("protocol", value);
    }

    /// <summary>
    /// SSlInfo block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SSlInfo block(s) allowed")]
    public TerraformList<GoogleApigeeTargetServerSSlInfoBlock>? SSlInfo
    {
        get => GetArgument<TerraformList<GoogleApigeeTargetServerSSlInfoBlock>>("s_sl_info");
        set => SetArgument("s_sl_info", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public GoogleApigeeTargetServerTimeoutsBlock? Timeouts
    {
        get => GetArgument<GoogleApigeeTargetServerTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}

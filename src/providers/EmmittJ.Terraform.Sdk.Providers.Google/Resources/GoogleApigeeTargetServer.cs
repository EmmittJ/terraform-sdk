using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for s_sl_info in .
/// Nesting mode: list
/// </summary>
public class GoogleApigeeTargetServerSSlInfoBlock : ITerraformBlock
{
    /// <summary>
    /// The SSL/TLS cipher suites to be used. For programmable proxies, it must be one of the cipher suite names listed in: http://docs.oracle.com/javase/8/docs/technotes/guides/security/StandardNames.html#ciphersuites. For configurable proxies, it must follow the configuration specified in: https://commondatastorage.googleapis.com/chromium-boringssl-docs/ssl.h.html#Cipher-suite-configuration. This setting has no effect for configurable proxies when negotiating TLS 1.3.
    /// </summary>
    [TerraformPropertyName("ciphers")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<List<TerraformProperty<string>>>? Ciphers { get; set; }

    /// <summary>
    /// Enables two-way TLS.
    /// </summary>
    [TerraformPropertyName("client_auth_enabled")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? ClientAuthEnabled { get; set; }

    /// <summary>
    /// Enables TLS. If false, neither one-way nor two-way TLS will be enabled.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Enabled is required")]
    [TerraformPropertyName("enabled")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<bool>> Enabled { get; set; }

    /// <summary>
    /// If true, TLS is strictly enforced.
    /// </summary>
    [TerraformPropertyName("enforce")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? Enforce { get; set; }

    /// <summary>
    /// If true, Edge ignores TLS certificate errors. Valid when configuring TLS for target servers and target endpoints, and when configuring virtual hosts that use 2-way TLS. When used with a target endpoint/target server, if the backend system uses SNI and returns a cert with a subject Distinguished Name (DN) that does not match the hostname, there is no way to ignore the error and the connection fails.
    /// </summary>
    [TerraformPropertyName("ignore_validation_errors")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? IgnoreValidationErrors { get; set; }

    /// <summary>
    /// Required if clientAuthEnabled is true. The resource ID for the alias containing the private key and cert.
    /// </summary>
    [TerraformPropertyName("key_alias")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? KeyAlias { get; set; }

    /// <summary>
    /// Required if clientAuthEnabled is true. The resource ID of the keystore.
    /// </summary>
    [TerraformPropertyName("key_store")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? KeyStore { get; set; }

    /// <summary>
    /// The TLS versioins to be used.
    /// </summary>
    [TerraformPropertyName("protocols")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<List<TerraformProperty<string>>>? Protocols { get; set; }

    /// <summary>
    /// The resource ID of the truststore.
    /// </summary>
    [TerraformPropertyName("trust_store")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? TrustStore { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class GoogleApigeeTargetServerTimeoutsBlock : ITerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformPropertyName("create")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformPropertyName("delete")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Delete { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformPropertyName("update")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Update { get; set; }

}

/// <summary>
/// Manages a google_apigee_target_server resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class GoogleApigeeTargetServer : TerraformResource
{
    public GoogleApigeeTargetServer(string name) : base("google_apigee_target_server", name)
    {
    }

    /// <summary>
    /// A human-readable description of this TargetServer.
    /// </summary>
    [TerraformPropertyName("description")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Description { get; set; }

    /// <summary>
    /// The Apigee environment group associated with the Apigee environment,
    /// in the format &#39;organizations/{{org_name}}/environments/{{env_name}}&#39;.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "EnvId is required")]
    [TerraformPropertyName("env_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> EnvId { get; set; }

    /// <summary>
    /// The host name this target connects to. Value must be a valid hostname as described by RFC-1123.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Host is required")]
    [TerraformPropertyName("host")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Host { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// Enabling/disabling a TargetServer is useful when TargetServers are used in load balancing configurations, and one or more TargetServers need to taken out of rotation periodically. Defaults to true.
    /// </summary>
    [TerraformPropertyName("is_enabled")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? IsEnabled { get; set; }

    /// <summary>
    /// The resource id of this reference. Values must match the regular expression [\w\s-.]+.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Name { get; set; }

    /// <summary>
    /// The port number this target connects to on the given host. Value must be between 1 and 65535, inclusive.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Port is required")]
    [TerraformPropertyName("port")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<double>> Port { get; set; }

    /// <summary>
    /// Immutable. The protocol used by this TargetServer. Possible values: [&amp;quot;HTTP&amp;quot;, &amp;quot;HTTP2&amp;quot;, &amp;quot;GRPC_TARGET&amp;quot;, &amp;quot;GRPC&amp;quot;, &amp;quot;EXTERNAL_CALLOUT&amp;quot;]
    /// </summary>
    [TerraformPropertyName("protocol")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Protocol { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "protocol");

    /// <summary>
    /// Block for s_sl_info.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SSlInfo block(s) allowed")]
    [TerraformPropertyName("s_sl_info")]
    public TerraformList<TerraformBlock<GoogleApigeeTargetServerSSlInfoBlock>>? SSlInfo { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<GoogleApigeeTargetServerTimeoutsBlock>? Timeouts { get; set; } = new();

}

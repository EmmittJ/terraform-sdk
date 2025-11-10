using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for s_sl_info in .
/// Nesting mode: list
/// </summary>
public class GoogleApigeeTargetServerSSlInfoBlock : TerraformBlock
{
    /// <summary>
    /// The SSL/TLS cipher suites to be used. For programmable proxies, it must be one of the cipher suite names listed in: http://docs.oracle.com/javase/8/docs/technotes/guides/security/StandardNames.html#ciphersuites. For configurable proxies, it must follow the configuration specified in: https://commondatastorage.googleapis.com/chromium-boringssl-docs/ssl.h.html#Cipher-suite-configuration. This setting has no effect for configurable proxies when negotiating TLS 1.3.
    /// </summary>
    public List<TerraformProperty<string>>? Ciphers
    {
        set => SetProperty("ciphers", value);
    }

    /// <summary>
    /// Enables two-way TLS.
    /// </summary>
    public TerraformProperty<bool>? ClientAuthEnabled
    {
        set => SetProperty("client_auth_enabled", value);
    }

    /// <summary>
    /// Enables TLS. If false, neither one-way nor two-way TLS will be enabled.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Enabled is required")]
    public required TerraformProperty<bool> Enabled
    {
        set => SetProperty("enabled", value);
    }

    /// <summary>
    /// If true, TLS is strictly enforced.
    /// </summary>
    public TerraformProperty<bool>? Enforce
    {
        set => SetProperty("enforce", value);
    }

    /// <summary>
    /// If true, Edge ignores TLS certificate errors. Valid when configuring TLS for target servers and target endpoints, and when configuring virtual hosts that use 2-way TLS. When used with a target endpoint/target server, if the backend system uses SNI and returns a cert with a subject Distinguished Name (DN) that does not match the hostname, there is no way to ignore the error and the connection fails.
    /// </summary>
    public TerraformProperty<bool>? IgnoreValidationErrors
    {
        set => SetProperty("ignore_validation_errors", value);
    }

    /// <summary>
    /// Required if clientAuthEnabled is true. The resource ID for the alias containing the private key and cert.
    /// </summary>
    public TerraformProperty<string>? KeyAlias
    {
        set => SetProperty("key_alias", value);
    }

    /// <summary>
    /// Required if clientAuthEnabled is true. The resource ID of the keystore.
    /// </summary>
    public TerraformProperty<string>? KeyStore
    {
        set => SetProperty("key_store", value);
    }

    /// <summary>
    /// The TLS versioins to be used.
    /// </summary>
    public List<TerraformProperty<string>>? Protocols
    {
        set => SetProperty("protocols", value);
    }

    /// <summary>
    /// The resource ID of the truststore.
    /// </summary>
    public TerraformProperty<string>? TrustStore
    {
        set => SetProperty("trust_store", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class GoogleApigeeTargetServerTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformProperty<string>? Create
    {
        set => SetProperty("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        set => SetProperty("delete", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformProperty<string>? Update
    {
        set => SetProperty("update", value);
    }

}

/// <summary>
/// Manages a google_apigee_target_server resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class GoogleApigeeTargetServer : TerraformResource
{
    public GoogleApigeeTargetServer(string name) : base("google_apigee_target_server", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("description");
        SetOutput("env_id");
        SetOutput("host");
        SetOutput("id");
        SetOutput("is_enabled");
        SetOutput("name");
        SetOutput("port");
        SetOutput("protocol");
    }

    /// <summary>
    /// A human-readable description of this TargetServer.
    /// </summary>
    public TerraformProperty<string> Description
    {
        get => GetRequiredOutput<TerraformProperty<string>>("description");
        set => SetProperty("description", value);
    }

    /// <summary>
    /// The Apigee environment group associated with the Apigee environment,
    /// in the format &#39;organizations/{{org_name}}/environments/{{env_name}}&#39;.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "EnvId is required")]
    public required TerraformProperty<string> EnvId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("env_id");
        set => SetProperty("env_id", value);
    }

    /// <summary>
    /// The host name this target connects to. Value must be a valid hostname as described by RFC-1123.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Host is required")]
    public required TerraformProperty<string> Host
    {
        get => GetRequiredOutput<TerraformProperty<string>>("host");
        set => SetProperty("host", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string> Id
    {
        get => GetRequiredOutput<TerraformProperty<string>>("id");
        set => SetProperty("id", value);
    }

    /// <summary>
    /// Enabling/disabling a TargetServer is useful when TargetServers are used in load balancing configurations, and one or more TargetServers need to taken out of rotation periodically. Defaults to true.
    /// </summary>
    public TerraformProperty<bool> IsEnabled
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("is_enabled");
        set => SetProperty("is_enabled", value);
    }

    /// <summary>
    /// The resource id of this reference. Values must match the regular expression [\w\s-.]+.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetRequiredOutput<TerraformProperty<string>>("name");
        set => SetProperty("name", value);
    }

    /// <summary>
    /// The port number this target connects to on the given host. Value must be between 1 and 65535, inclusive.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Port is required")]
    public required TerraformProperty<double> Port
    {
        get => GetRequiredOutput<TerraformProperty<double>>("port");
        set => SetProperty("port", value);
    }

    /// <summary>
    /// Immutable. The protocol used by this TargetServer. Possible values: [&amp;quot;HTTP&amp;quot;, &amp;quot;HTTP2&amp;quot;, &amp;quot;GRPC_TARGET&amp;quot;, &amp;quot;GRPC&amp;quot;, &amp;quot;EXTERNAL_CALLOUT&amp;quot;]
    /// </summary>
    public TerraformProperty<string> Protocol
    {
        get => GetRequiredOutput<TerraformProperty<string>>("protocol");
        set => SetProperty("protocol", value);
    }

    /// <summary>
    /// Block for s_sl_info.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SSlInfo block(s) allowed")]
    public List<GoogleApigeeTargetServerSSlInfoBlock>? SSlInfo
    {
        set => SetProperty("s_sl_info", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public GoogleApigeeTargetServerTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

}

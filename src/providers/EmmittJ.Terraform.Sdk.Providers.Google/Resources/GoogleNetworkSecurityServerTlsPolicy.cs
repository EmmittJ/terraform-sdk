using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for mtls_policy in GoogleNetworkSecurityServerTlsPolicy.
/// Nesting mode: list
/// </summary>
public class GoogleNetworkSecurityServerTlsPolicyMtlsPolicyBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "mtls_policy";

    /// <summary>
    /// When the client presents an invalid certificate or no certificate to the load balancer, the clientValidationMode specifies how the client connection is handled.
    /// Required if the policy is to be used with the external HTTPS load balancing. For Traffic Director it must be empty. Possible values: [&amp;quot;CLIENT_VALIDATION_MODE_UNSPECIFIED&amp;quot;, &amp;quot;ALLOW_INVALID_OR_MISSING_CLIENT_CERT&amp;quot;, &amp;quot;REJECT_INVALID&amp;quot;]
    /// </summary>
    public TerraformValue<string>? ClientValidationMode
    {
        get => GetArgument<TerraformValue<string>>("client_validation_mode");
        set => SetArgument("client_validation_mode", value);
    }

    /// <summary>
    /// Reference to the TrustConfig from certificatemanager.googleapis.com namespace.
    /// If specified, the chain validation will be performed against certificates configured in the given TrustConfig.
    /// Allowed only if the policy is to be used with external HTTPS load balancers.
    /// </summary>
    public TerraformValue<string>? ClientValidationTrustConfig
    {
        get => GetArgument<TerraformValue<string>>("client_validation_trust_config");
        set => SetArgument("client_validation_trust_config", value);
    }

    /// <summary>
    /// ClientValidationCa block (nesting mode: list).
    /// </summary>
    public TerraformList<GoogleNetworkSecurityServerTlsPolicyMtlsPolicyBlockClientValidationCaBlock>? ClientValidationCa
    {
        get => GetArgument<TerraformList<GoogleNetworkSecurityServerTlsPolicyMtlsPolicyBlockClientValidationCaBlock>>("client_validation_ca");
        set => SetArgument("client_validation_ca", value);
    }

}

/// <summary>
/// Block type for client_validation_ca in GoogleNetworkSecurityServerTlsPolicyMtlsPolicyBlock.
/// Nesting mode: list
/// </summary>
public class GoogleNetworkSecurityServerTlsPolicyMtlsPolicyBlockClientValidationCaBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "client_validation_ca";

    /// <summary>
    /// CertificateProviderInstance block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 CertificateProviderInstance block(s) allowed")]
    public TerraformList<GoogleNetworkSecurityServerTlsPolicyMtlsPolicyBlockClientValidationCaBlockCertificateProviderInstanceBlock>? CertificateProviderInstance
    {
        get => GetArgument<TerraformList<GoogleNetworkSecurityServerTlsPolicyMtlsPolicyBlockClientValidationCaBlockCertificateProviderInstanceBlock>>("certificate_provider_instance");
        set => SetArgument("certificate_provider_instance", value);
    }

    /// <summary>
    /// GrpcEndpoint block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 GrpcEndpoint block(s) allowed")]
    public TerraformList<GoogleNetworkSecurityServerTlsPolicyMtlsPolicyBlockClientValidationCaBlockGrpcEndpointBlock>? GrpcEndpoint
    {
        get => GetArgument<TerraformList<GoogleNetworkSecurityServerTlsPolicyMtlsPolicyBlockClientValidationCaBlockGrpcEndpointBlock>>("grpc_endpoint");
        set => SetArgument("grpc_endpoint", value);
    }

}

/// <summary>
/// Block type for certificate_provider_instance in GoogleNetworkSecurityServerTlsPolicyMtlsPolicyBlockClientValidationCaBlock.
/// Nesting mode: list
/// </summary>
public class GoogleNetworkSecurityServerTlsPolicyMtlsPolicyBlockClientValidationCaBlockCertificateProviderInstanceBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "certificate_provider_instance";

    /// <summary>
    /// Plugin instance name, used to locate and load CertificateProvider instance configuration. Set to &amp;quot;google_cloud_private_spiffe&amp;quot; to use Certificate Authority Service certificate provider instance.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PluginInstance is required")]
    public required TerraformValue<string> PluginInstance
    {
        get => GetArgument<TerraformValue<string>>("plugin_instance");
        set => SetArgument("plugin_instance", value);
    }

}

/// <summary>
/// Block type for grpc_endpoint in GoogleNetworkSecurityServerTlsPolicyMtlsPolicyBlockClientValidationCaBlock.
/// Nesting mode: list
/// </summary>
public class GoogleNetworkSecurityServerTlsPolicyMtlsPolicyBlockClientValidationCaBlockGrpcEndpointBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "grpc_endpoint";

    /// <summary>
    /// The target URI of the gRPC endpoint. Only UDS path is supported, and should start with &amp;quot;unix:&amp;quot;.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TargetUri is required")]
    public required TerraformValue<string> TargetUri
    {
        get => GetArgument<TerraformValue<string>>("target_uri");
        set => SetArgument("target_uri", value);
    }

}


/// <summary>
/// Block type for server_certificate in GoogleNetworkSecurityServerTlsPolicy.
/// Nesting mode: list
/// </summary>
public class GoogleNetworkSecurityServerTlsPolicyServerCertificateBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "server_certificate";

    /// <summary>
    /// CertificateProviderInstance block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 CertificateProviderInstance block(s) allowed")]
    public TerraformList<GoogleNetworkSecurityServerTlsPolicyServerCertificateBlockCertificateProviderInstanceBlock>? CertificateProviderInstance
    {
        get => GetArgument<TerraformList<GoogleNetworkSecurityServerTlsPolicyServerCertificateBlockCertificateProviderInstanceBlock>>("certificate_provider_instance");
        set => SetArgument("certificate_provider_instance", value);
    }

    /// <summary>
    /// GrpcEndpoint block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 GrpcEndpoint block(s) allowed")]
    public TerraformList<GoogleNetworkSecurityServerTlsPolicyServerCertificateBlockGrpcEndpointBlock>? GrpcEndpoint
    {
        get => GetArgument<TerraformList<GoogleNetworkSecurityServerTlsPolicyServerCertificateBlockGrpcEndpointBlock>>("grpc_endpoint");
        set => SetArgument("grpc_endpoint", value);
    }

}

/// <summary>
/// Block type for certificate_provider_instance in GoogleNetworkSecurityServerTlsPolicyServerCertificateBlock.
/// Nesting mode: list
/// </summary>
public class GoogleNetworkSecurityServerTlsPolicyServerCertificateBlockCertificateProviderInstanceBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "certificate_provider_instance";

    /// <summary>
    /// Plugin instance name, used to locate and load CertificateProvider instance configuration. Set to &amp;quot;google_cloud_private_spiffe&amp;quot; to use Certificate Authority Service certificate provider instance.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PluginInstance is required")]
    public required TerraformValue<string> PluginInstance
    {
        get => GetArgument<TerraformValue<string>>("plugin_instance");
        set => SetArgument("plugin_instance", value);
    }

}

/// <summary>
/// Block type for grpc_endpoint in GoogleNetworkSecurityServerTlsPolicyServerCertificateBlock.
/// Nesting mode: list
/// </summary>
public class GoogleNetworkSecurityServerTlsPolicyServerCertificateBlockGrpcEndpointBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "grpc_endpoint";

    /// <summary>
    /// The target URI of the gRPC endpoint. Only UDS path is supported, and should start with &amp;quot;unix:&amp;quot;.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TargetUri is required")]
    public required TerraformValue<string> TargetUri
    {
        get => GetArgument<TerraformValue<string>>("target_uri");
        set => SetArgument("target_uri", value);
    }

}


/// <summary>
/// Block type for timeouts in GoogleNetworkSecurityServerTlsPolicy.
/// Nesting mode: single
/// </summary>
public class GoogleNetworkSecurityServerTlsPolicyTimeoutsBlock : TerraformBlock
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
/// Represents a google_network_security_server_tls_policy Terraform resource.
/// Manages a google_network_security_server_tls_policy resource.
/// </summary>
public partial class GoogleNetworkSecurityServerTlsPolicy(string name) : TerraformResource("google_network_security_server_tls_policy", name)
{
    /// <summary>
    /// This field applies only for Traffic Director policies. It is must be set to false for external HTTPS load balancer policies.
    /// Determines if server allows plaintext connections. If set to true, server allows plain text connections. By default, it is set to false. This setting is not exclusive of other encryption modes. For example, if allowOpen and mtlsPolicy are set, server allows both plain text and mTLS connections. See documentation of other encryption modes to confirm compatibility.
    /// Consider using it if you wish to upgrade in place your deployment to TLS while having mixed TLS and non-TLS traffic reaching port :80.
    /// </summary>
    public TerraformValue<bool>? AllowOpen
    {
        get => GetArgument<TerraformValue<bool>>("allow_open");
        set => SetArgument("allow_open", value);
    }

    /// <summary>
    /// A free-text description of the resource. Max length 1024 characters.
    /// </summary>
    public TerraformValue<string>? Description
    {
        get => GetArgument<TerraformValue<string>>("description");
        set => SetArgument("description", value);
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
    /// Set of label tags associated with the ServerTlsPolicy resource.
    /// 
    /// **Note**: This field is non-authoritative, and will only manage the labels present in your configuration.
    /// Please refer to the field &#39;effective_labels&#39; for all of the labels present on the resource.
    /// </summary>
    public TerraformMap<string>? Labels
    {
        get => GetArgument<TerraformMap<string>>("labels");
        set => SetArgument("labels", value);
    }

    /// <summary>
    /// The location of the server tls policy.
    /// The default value is &#39;global&#39;.
    /// </summary>
    public TerraformValue<string>? Location
    {
        get => GetArgument<TerraformValue<string>>("location");
        set => SetArgument("location", value);
    }

    /// <summary>
    /// Name of the ServerTlsPolicy resource.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The project attribute.
    /// </summary>
    public TerraformValue<string>? Project
    {
        get => GetArgument<TerraformValue<string>>("project");
        set => SetArgument("project", value);
    }

    /// <summary>
    /// Time the ServerTlsPolicy was created in UTC.
    /// </summary>
    public TerraformValue<string> CreateTime
        => AsReference("create_time");

    /// <summary>
    /// All of labels (key/value pairs) present on the resource in GCP, including the labels configured through Terraform, other clients and services.
    /// </summary>
    public TerraformMap<string> EffectiveLabels
        => AsReference("effective_labels");

    /// <summary>
    /// The combination of labels configured directly on the resource
    ///  and default labels configured on the provider.
    /// </summary>
    public TerraformMap<string> TerraformLabels
        => AsReference("terraform_labels");

    /// <summary>
    /// Time the ServerTlsPolicy was updated in UTC.
    /// </summary>
    public TerraformValue<string> UpdateTime
        => AsReference("update_time");

    /// <summary>
    /// MtlsPolicy block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 MtlsPolicy block(s) allowed")]
    public TerraformList<GoogleNetworkSecurityServerTlsPolicyMtlsPolicyBlock>? MtlsPolicy
    {
        get => GetArgument<TerraformList<GoogleNetworkSecurityServerTlsPolicyMtlsPolicyBlock>>("mtls_policy");
        set => SetArgument("mtls_policy", value);
    }

    /// <summary>
    /// ServerCertificate block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ServerCertificate block(s) allowed")]
    public TerraformList<GoogleNetworkSecurityServerTlsPolicyServerCertificateBlock>? ServerCertificate
    {
        get => GetArgument<TerraformList<GoogleNetworkSecurityServerTlsPolicyServerCertificateBlock>>("server_certificate");
        set => SetArgument("server_certificate", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public GoogleNetworkSecurityServerTlsPolicyTimeoutsBlock? Timeouts
    {
        get => GetArgument<GoogleNetworkSecurityServerTlsPolicyTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}

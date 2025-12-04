using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for client_certificate in GoogleNetworkSecurityClientTlsPolicy.
/// Nesting mode: list
/// </summary>
public class GoogleNetworkSecurityClientTlsPolicyClientCertificateBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "client_certificate";

    /// <summary>
    /// CertificateProviderInstance block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 CertificateProviderInstance block(s) allowed")]
    public TerraformList<GoogleNetworkSecurityClientTlsPolicyClientCertificateBlockCertificateProviderInstanceBlock>? CertificateProviderInstance
    {
        get => GetArgument<TerraformList<GoogleNetworkSecurityClientTlsPolicyClientCertificateBlockCertificateProviderInstanceBlock>>("certificate_provider_instance");
        set => SetArgument("certificate_provider_instance", value);
    }

    /// <summary>
    /// GrpcEndpoint block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 GrpcEndpoint block(s) allowed")]
    public TerraformList<GoogleNetworkSecurityClientTlsPolicyClientCertificateBlockGrpcEndpointBlock>? GrpcEndpoint
    {
        get => GetArgument<TerraformList<GoogleNetworkSecurityClientTlsPolicyClientCertificateBlockGrpcEndpointBlock>>("grpc_endpoint");
        set => SetArgument("grpc_endpoint", value);
    }

}

/// <summary>
/// Block type for certificate_provider_instance in GoogleNetworkSecurityClientTlsPolicyClientCertificateBlock.
/// Nesting mode: list
/// </summary>
public class GoogleNetworkSecurityClientTlsPolicyClientCertificateBlockCertificateProviderInstanceBlock : TerraformBlock
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
/// Block type for grpc_endpoint in GoogleNetworkSecurityClientTlsPolicyClientCertificateBlock.
/// Nesting mode: list
/// </summary>
public class GoogleNetworkSecurityClientTlsPolicyClientCertificateBlockGrpcEndpointBlock : TerraformBlock
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
/// Block type for server_validation_ca in GoogleNetworkSecurityClientTlsPolicy.
/// Nesting mode: list
/// </summary>
public class GoogleNetworkSecurityClientTlsPolicyServerValidationCaBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "server_validation_ca";

    /// <summary>
    /// CertificateProviderInstance block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 CertificateProviderInstance block(s) allowed")]
    public TerraformList<GoogleNetworkSecurityClientTlsPolicyServerValidationCaBlockCertificateProviderInstanceBlock>? CertificateProviderInstance
    {
        get => GetArgument<TerraformList<GoogleNetworkSecurityClientTlsPolicyServerValidationCaBlockCertificateProviderInstanceBlock>>("certificate_provider_instance");
        set => SetArgument("certificate_provider_instance", value);
    }

    /// <summary>
    /// GrpcEndpoint block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 GrpcEndpoint block(s) allowed")]
    public TerraformList<GoogleNetworkSecurityClientTlsPolicyServerValidationCaBlockGrpcEndpointBlock>? GrpcEndpoint
    {
        get => GetArgument<TerraformList<GoogleNetworkSecurityClientTlsPolicyServerValidationCaBlockGrpcEndpointBlock>>("grpc_endpoint");
        set => SetArgument("grpc_endpoint", value);
    }

}

/// <summary>
/// Block type for certificate_provider_instance in GoogleNetworkSecurityClientTlsPolicyServerValidationCaBlock.
/// Nesting mode: list
/// </summary>
public class GoogleNetworkSecurityClientTlsPolicyServerValidationCaBlockCertificateProviderInstanceBlock : TerraformBlock
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
/// Block type for grpc_endpoint in GoogleNetworkSecurityClientTlsPolicyServerValidationCaBlock.
/// Nesting mode: list
/// </summary>
public class GoogleNetworkSecurityClientTlsPolicyServerValidationCaBlockGrpcEndpointBlock : TerraformBlock
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
/// Block type for timeouts in GoogleNetworkSecurityClientTlsPolicy.
/// Nesting mode: single
/// </summary>
public class GoogleNetworkSecurityClientTlsPolicyTimeoutsBlock : TerraformBlock
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
/// Represents a google_network_security_client_tls_policy Terraform resource.
/// Manages a google_network_security_client_tls_policy resource.
/// </summary>
public partial class GoogleNetworkSecurityClientTlsPolicy(string name) : TerraformResource("google_network_security_client_tls_policy", name)
{
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
    /// Set of label tags associated with the ClientTlsPolicy resource.
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
    /// The location of the client tls policy.
    /// The default value is &#39;global&#39;.
    /// </summary>
    public TerraformValue<string>? Location
    {
        get => GetArgument<TerraformValue<string>>("location");
        set => SetArgument("location", value);
    }

    /// <summary>
    /// Name of the ClientTlsPolicy resource.
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
    /// Server Name Indication string to present to the server during TLS handshake. E.g: &amp;quot;secure.example.com&amp;quot;.
    /// </summary>
    public TerraformValue<string>? Sni
    {
        get => GetArgument<TerraformValue<string>>("sni");
        set => SetArgument("sni", value);
    }

    /// <summary>
    /// Time the ClientTlsPolicy was created in UTC.
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
    /// Time the ClientTlsPolicy was updated in UTC.
    /// </summary>
    public TerraformValue<string> UpdateTime
        => AsReference("update_time");

    /// <summary>
    /// ClientCertificate block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ClientCertificate block(s) allowed")]
    public TerraformList<GoogleNetworkSecurityClientTlsPolicyClientCertificateBlock>? ClientCertificate
    {
        get => GetArgument<TerraformList<GoogleNetworkSecurityClientTlsPolicyClientCertificateBlock>>("client_certificate");
        set => SetArgument("client_certificate", value);
    }

    /// <summary>
    /// ServerValidationCa block (nesting mode: list).
    /// </summary>
    public TerraformList<GoogleNetworkSecurityClientTlsPolicyServerValidationCaBlock>? ServerValidationCa
    {
        get => GetArgument<TerraformList<GoogleNetworkSecurityClientTlsPolicyServerValidationCaBlock>>("server_validation_ca");
        set => SetArgument("server_validation_ca", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public GoogleNetworkSecurityClientTlsPolicyTimeoutsBlock? Timeouts
    {
        get => GetArgument<GoogleNetworkSecurityClientTlsPolicyTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}

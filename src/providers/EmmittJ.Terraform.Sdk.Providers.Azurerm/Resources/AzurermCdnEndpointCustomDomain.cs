using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for cdn_managed_https in AzurermCdnEndpointCustomDomain.
/// Nesting mode: list
/// </summary>
public class AzurermCdnEndpointCustomDomainCdnManagedHttpsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "cdn_managed_https";

    /// <summary>
    /// The certificate_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CertificateType is required")]
    public required TerraformValue<string> CertificateType
    {
        get => GetRequiredArgument<TerraformValue<string>>("certificate_type");
        set => SetArgument("certificate_type", value);
    }

    /// <summary>
    /// The protocol_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ProtocolType is required")]
    public required TerraformValue<string> ProtocolType
    {
        get => GetRequiredArgument<TerraformValue<string>>("protocol_type");
        set => SetArgument("protocol_type", value);
    }

    /// <summary>
    /// The tls_version attribute.
    /// </summary>
    public TerraformValue<string>? TlsVersion
    {
        get => GetArgument<TerraformValue<string>>("tls_version");
        set => SetArgument("tls_version", value);
    }

}


/// <summary>
/// Block type for timeouts in AzurermCdnEndpointCustomDomain.
/// Nesting mode: single
/// </summary>
public class AzurermCdnEndpointCustomDomainTimeoutsBlock : TerraformBlock
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
    /// The read attribute.
    /// </summary>
    public TerraformValue<string>? Read
    {
        get => GetArgument<TerraformValue<string>>("read");
        set => SetArgument("read", value);
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
/// Block type for user_managed_https in AzurermCdnEndpointCustomDomain.
/// Nesting mode: list
/// </summary>
public class AzurermCdnEndpointCustomDomainUserManagedHttpsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "user_managed_https";

    /// <summary>
    /// The key_vault_secret_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "KeyVaultSecretId is required")]
    public required TerraformValue<string> KeyVaultSecretId
    {
        get => GetRequiredArgument<TerraformValue<string>>("key_vault_secret_id");
        set => SetArgument("key_vault_secret_id", value);
    }

    /// <summary>
    /// The tls_version attribute.
    /// </summary>
    public TerraformValue<string>? TlsVersion
    {
        get => GetArgument<TerraformValue<string>>("tls_version");
        set => SetArgument("tls_version", value);
    }

}


/// <summary>
/// Represents a azurerm_cdn_endpoint_custom_domain Terraform resource.
/// Manages a azurerm_cdn_endpoint_custom_domain resource.
/// </summary>
public partial class AzurermCdnEndpointCustomDomain(string name) : TerraformResource("azurerm_cdn_endpoint_custom_domain", name)
{
    /// <summary>
    /// The cdn_endpoint_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CdnEndpointId is required")]
    public required TerraformValue<string> CdnEndpointId
    {
        get => GetRequiredArgument<TerraformValue<string>>("cdn_endpoint_id");
        set => SetArgument("cdn_endpoint_id", value);
    }

    /// <summary>
    /// The host_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "HostName is required")]
    public required TerraformValue<string> HostName
    {
        get => GetRequiredArgument<TerraformValue<string>>("host_name");
        set => SetArgument("host_name", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => GetArgument<TerraformValue<string>>("id") ?? CreateReference("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetRequiredArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// CdnManagedHttps block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 CdnManagedHttps block(s) allowed")]
    public TerraformList<AzurermCdnEndpointCustomDomainCdnManagedHttpsBlock>? CdnManagedHttps
    {
        get => GetArgument<TerraformList<AzurermCdnEndpointCustomDomainCdnManagedHttpsBlock>>("cdn_managed_https");
        set => SetArgument("cdn_managed_https", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermCdnEndpointCustomDomainTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermCdnEndpointCustomDomainTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

    /// <summary>
    /// UserManagedHttps block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 UserManagedHttps block(s) allowed")]
    public TerraformList<AzurermCdnEndpointCustomDomainUserManagedHttpsBlock>? UserManagedHttps
    {
        get => GetArgument<TerraformList<AzurermCdnEndpointCustomDomainUserManagedHttpsBlock>>("user_managed_https");
        set => SetArgument("user_managed_https", value);
    }

}

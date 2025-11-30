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
        get => new TerraformReference<string>(this, "certificate_type");
        set => SetArgument("certificate_type", value);
    }

    /// <summary>
    /// The protocol_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ProtocolType is required")]
    public required TerraformValue<string> ProtocolType
    {
        get => new TerraformReference<string>(this, "protocol_type");
        set => SetArgument("protocol_type", value);
    }

    /// <summary>
    /// The tls_version attribute.
    /// </summary>
    public TerraformValue<string>? TlsVersion
    {
        get => new TerraformReference<string>(this, "tls_version");
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
        get => new TerraformReference<string>(this, "create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformValue<string>? Delete
    {
        get => new TerraformReference<string>(this, "delete");
        set => SetArgument("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformValue<string>? Read
    {
        get => new TerraformReference<string>(this, "read");
        set => SetArgument("read", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformValue<string>? Update
    {
        get => new TerraformReference<string>(this, "update");
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
        get => new TerraformReference<string>(this, "key_vault_secret_id");
        set => SetArgument("key_vault_secret_id", value);
    }

    /// <summary>
    /// The tls_version attribute.
    /// </summary>
    public TerraformValue<string>? TlsVersion
    {
        get => new TerraformReference<string>(this, "tls_version");
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
        get => new TerraformReference<string>(this, "cdn_endpoint_id");
        set => SetArgument("cdn_endpoint_id", value);
    }

    /// <summary>
    /// The host_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "HostName is required")]
    public required TerraformValue<string> HostName
    {
        get => new TerraformReference<string>(this, "host_name");
        set => SetArgument("host_name", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
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

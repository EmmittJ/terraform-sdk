using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

// Resources, Data Sources, Ephemeral Resources, Blocks: Getter ALWAYS returns a reference
// This is the key to natural Terraform syntax
// When you access rg.Name, you get azurerm_resource_group.rg.name (a reference)
// The value that was SET is only used during serialization

// Providers: Getter returns stored value
// Providers are not referenced in HCL
// Use required getter if property is required or non-nullable

/// <summary>
/// Block type for cdn_managed_https in .
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
    [TerraformArgument("certificate_type")]
    public required TerraformValue<string> CertificateType
    {
        get => new TerraformReference<string>(this, "certificate_type");
        set => SetArgument("certificate_type", value);
    }

    /// <summary>
    /// The protocol_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ProtocolType is required")]
    [TerraformArgument("protocol_type")]
    public required TerraformValue<string> ProtocolType
    {
        get => new TerraformReference<string>(this, "protocol_type");
        set => SetArgument("protocol_type", value);
    }

    /// <summary>
    /// The tls_version attribute.
    /// </summary>
    [TerraformArgument("tls_version")]
    public TerraformValue<string>? TlsVersion
    {
        get => new TerraformReference<string>(this, "tls_version");
        set => SetArgument("tls_version", value);
    }

}

/// <summary>
/// Block type for timeouts in .
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
    [TerraformArgument("create")]
    public TerraformValue<string>? Create
    {
        get => new TerraformReference<string>(this, "create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformArgument("delete")]
    public TerraformValue<string>? Delete
    {
        get => new TerraformReference<string>(this, "delete");
        set => SetArgument("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformArgument("read")]
    public TerraformValue<string>? Read
    {
        get => new TerraformReference<string>(this, "read");
        set => SetArgument("read", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformArgument("update")]
    public TerraformValue<string>? Update
    {
        get => new TerraformReference<string>(this, "update");
        set => SetArgument("update", value);
    }

}

/// <summary>
/// Block type for user_managed_https in .
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
    [TerraformArgument("key_vault_secret_id")]
    public required TerraformValue<string> KeyVaultSecretId
    {
        get => new TerraformReference<string>(this, "key_vault_secret_id");
        set => SetArgument("key_vault_secret_id", value);
    }

    /// <summary>
    /// The tls_version attribute.
    /// </summary>
    [TerraformArgument("tls_version")]
    public TerraformValue<string>? TlsVersion
    {
        get => new TerraformReference<string>(this, "tls_version");
        set => SetArgument("tls_version", value);
    }

}

/// <summary>
/// Manages a azurerm_cdn_endpoint_custom_domain resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AzurermCdnEndpointCustomDomain : TerraformResource
{
    public AzurermCdnEndpointCustomDomain(string name) : base("azurerm_cdn_endpoint_custom_domain", name)
    {
    }

    /// <summary>
    /// The cdn_endpoint_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CdnEndpointId is required")]
    [TerraformArgument("cdn_endpoint_id")]
    public required TerraformValue<string> CdnEndpointId
    {
        get => new TerraformReference<string>(this, "cdn_endpoint_id");
        set => SetArgument("cdn_endpoint_id", value);
    }

    /// <summary>
    /// The host_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "HostName is required")]
    [TerraformArgument("host_name")]
    public required TerraformValue<string> HostName
    {
        get => new TerraformReference<string>(this, "host_name");
        set => SetArgument("host_name", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformArgument("id")]
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformArgument("name")]
    public required TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// Block for cdn_managed_https.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 CdnManagedHttps block(s) allowed")]
    [TerraformArgument("cdn_managed_https")]
    public TerraformList<AzurermCdnEndpointCustomDomainCdnManagedHttpsBlock> CdnManagedHttps { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformArgument("timeouts")]
    public AzurermCdnEndpointCustomDomainTimeoutsBlock Timeouts { get; set; } = new();

    /// <summary>
    /// Block for user_managed_https.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 UserManagedHttps block(s) allowed")]
    [TerraformArgument("user_managed_https")]
    public TerraformList<AzurermCdnEndpointCustomDomainUserManagedHttpsBlock> UserManagedHttps { get; set; } = new();

}

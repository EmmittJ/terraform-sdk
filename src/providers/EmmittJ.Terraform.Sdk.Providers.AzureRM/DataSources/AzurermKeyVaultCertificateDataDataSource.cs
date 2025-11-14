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
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermKeyVaultCertificateDataDataSourceTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "timeouts";

    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformArgument("read")]
    public TerraformValue<string>? Read
    {
        get => new TerraformReference<string>(this, "read");
        set => SetArgument("read", value);
    }

}

/// <summary>
/// Retrieves information about a azurerm_key_vault_certificate_data.
/// </summary>
public class AzurermKeyVaultCertificateDataDataSource : TerraformDataSource
{
    public AzurermKeyVaultCertificateDataDataSource(string name) : base("azurerm_key_vault_certificate_data", name)
    {
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
    /// The key_vault_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "KeyVaultId is required")]
    [TerraformArgument("key_vault_id")]
    public required TerraformValue<string> KeyVaultId
    {
        get => new TerraformReference<string>(this, "key_vault_id");
        set => SetArgument("key_vault_id", value);
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
    /// The version attribute.
    /// </summary>
    [TerraformArgument("version")]
    public TerraformValue<string> Version
    {
        get => new TerraformReference<string>(this, "version");
        set => SetArgument("version", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformArgument("timeouts")]
    public AzurermKeyVaultCertificateDataDataSourceTimeoutsBlock Timeouts { get; set; } = new();

    /// <summary>
    /// The certificates_count attribute.
    /// </summary>
    [TerraformArgument("certificates_count")]
    public TerraformValue<double> CertificatesCount
    {
        get => new TerraformReference<double>(this, "certificates_count");
    }

    /// <summary>
    /// The expires attribute.
    /// </summary>
    [TerraformArgument("expires")]
    public TerraformValue<string> Expires
    {
        get => new TerraformReference<string>(this, "expires");
    }

    /// <summary>
    /// The hex attribute.
    /// </summary>
    [TerraformArgument("hex")]
    public TerraformValue<string> Hex
    {
        get => new TerraformReference<string>(this, "hex");
    }

    /// <summary>
    /// The key attribute.
    /// </summary>
    [TerraformArgument("key")]
    public TerraformValue<string> Key
    {
        get => new TerraformReference<string>(this, "key");
    }

    /// <summary>
    /// The not_before attribute.
    /// </summary>
    [TerraformArgument("not_before")]
    public TerraformValue<string> NotBefore
    {
        get => new TerraformReference<string>(this, "not_before");
    }

    /// <summary>
    /// The pem attribute.
    /// </summary>
    [TerraformArgument("pem")]
    public TerraformValue<string> Pem
    {
        get => new TerraformReference<string>(this, "pem");
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformArgument("tags")]
    public TerraformMap<string> Tags
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "tags").ResolveNodes(ctx));
    }

}

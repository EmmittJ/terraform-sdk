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
public class AzurermKeyVaultCertificateIssuerDataSourceTimeoutsBlock : TerraformBlock
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
/// Retrieves information about a azurerm_key_vault_certificate_issuer.
/// </summary>
public class AzurermKeyVaultCertificateIssuerDataSource : TerraformDataSource
{
    public AzurermKeyVaultCertificateIssuerDataSource(string name) : base("azurerm_key_vault_certificate_issuer", name)
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
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformArgument("timeouts")]
    public AzurermKeyVaultCertificateIssuerDataSourceTimeoutsBlock Timeouts { get; set; } = new();

    /// <summary>
    /// The account_id attribute.
    /// </summary>
    [TerraformArgument("account_id")]
    public TerraformValue<string> AccountId
    {
        get => new TerraformReference<string>(this, "account_id");
    }

    /// <summary>
    /// The admin attribute.
    /// </summary>
    [TerraformArgument("admin")]
    public TerraformList<object> Admin
    {
        get => TerraformList<object>.Lazy(ctx => new TerraformReference<TerraformList<object>>(this, "admin").ResolveNodes(ctx));
    }

    /// <summary>
    /// The org_id attribute.
    /// </summary>
    [TerraformArgument("org_id")]
    public TerraformValue<string> OrgId
    {
        get => new TerraformReference<string>(this, "org_id");
    }

    /// <summary>
    /// The provider_name attribute.
    /// </summary>
    [TerraformArgument("provider_name")]
    public TerraformValue<string> ProviderName
    {
        get => new TerraformReference<string>(this, "provider_name");
    }

}

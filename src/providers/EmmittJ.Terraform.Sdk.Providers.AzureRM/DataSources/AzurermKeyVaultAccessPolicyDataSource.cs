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
public class AzurermKeyVaultAccessPolicyDataSourceTimeoutsBlock : TerraformBlock
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
/// Retrieves information about a azurerm_key_vault_access_policy.
/// </summary>
public class AzurermKeyVaultAccessPolicyDataSource : TerraformDataSource
{
    public AzurermKeyVaultAccessPolicyDataSource(string name) : base("azurerm_key_vault_access_policy", name)
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
    public AzurermKeyVaultAccessPolicyDataSourceTimeoutsBlock Timeouts { get; set; } = new();

    /// <summary>
    /// The certificate_permissions attribute.
    /// </summary>
    [TerraformArgument("certificate_permissions")]
    public TerraformList<string> CertificatePermissions
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "certificate_permissions").ResolveNodes(ctx));
    }

    /// <summary>
    /// The key_permissions attribute.
    /// </summary>
    [TerraformArgument("key_permissions")]
    public TerraformList<string> KeyPermissions
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "key_permissions").ResolveNodes(ctx));
    }

    /// <summary>
    /// The secret_permissions attribute.
    /// </summary>
    [TerraformArgument("secret_permissions")]
    public TerraformList<string> SecretPermissions
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "secret_permissions").ResolveNodes(ctx));
    }

}

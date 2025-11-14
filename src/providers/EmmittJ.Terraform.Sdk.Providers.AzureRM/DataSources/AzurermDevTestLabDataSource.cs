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
public class AzurermDevTestLabDataSourceTimeoutsBlock : TerraformBlock
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
/// Retrieves information about a azurerm_dev_test_lab.
/// </summary>
public class AzurermDevTestLabDataSource : TerraformDataSource
{
    public AzurermDevTestLabDataSource(string name) : base("azurerm_dev_test_lab", name)
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
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    [TerraformArgument("resource_group_name")]
    public required TerraformValue<string> ResourceGroupName
    {
        get => new TerraformReference<string>(this, "resource_group_name");
        set => SetArgument("resource_group_name", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformArgument("timeouts")]
    public AzurermDevTestLabDataSourceTimeoutsBlock Timeouts { get; set; } = new();

    /// <summary>
    /// The artifacts_storage_account_id attribute.
    /// </summary>
    [TerraformArgument("artifacts_storage_account_id")]
    public TerraformValue<string> ArtifactsStorageAccountId
    {
        get => new TerraformReference<string>(this, "artifacts_storage_account_id");
    }

    /// <summary>
    /// The default_premium_storage_account_id attribute.
    /// </summary>
    [TerraformArgument("default_premium_storage_account_id")]
    public TerraformValue<string> DefaultPremiumStorageAccountId
    {
        get => new TerraformReference<string>(this, "default_premium_storage_account_id");
    }

    /// <summary>
    /// The default_storage_account_id attribute.
    /// </summary>
    [TerraformArgument("default_storage_account_id")]
    public TerraformValue<string> DefaultStorageAccountId
    {
        get => new TerraformReference<string>(this, "default_storage_account_id");
    }

    /// <summary>
    /// The key_vault_id attribute.
    /// </summary>
    [TerraformArgument("key_vault_id")]
    public TerraformValue<string> KeyVaultId
    {
        get => new TerraformReference<string>(this, "key_vault_id");
    }

    /// <summary>
    /// The location attribute.
    /// </summary>
    [TerraformArgument("location")]
    public TerraformValue<string> Location
    {
        get => new TerraformReference<string>(this, "location");
    }

    /// <summary>
    /// The premium_data_disk_storage_account_id attribute.
    /// </summary>
    [TerraformArgument("premium_data_disk_storage_account_id")]
    public TerraformValue<string> PremiumDataDiskStorageAccountId
    {
        get => new TerraformReference<string>(this, "premium_data_disk_storage_account_id");
    }

    /// <summary>
    /// The storage_type attribute.
    /// </summary>
    [TerraformArgument("storage_type")]
    public TerraformValue<string> StorageType
    {
        get => new TerraformReference<string>(this, "storage_type");
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformArgument("tags")]
    public TerraformMap<string> Tags
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "tags").ResolveNodes(ctx));
    }

    /// <summary>
    /// The unique_identifier attribute.
    /// </summary>
    [TerraformArgument("unique_identifier")]
    public TerraformValue<string> UniqueIdentifier
    {
        get => new TerraformReference<string>(this, "unique_identifier");
    }

}

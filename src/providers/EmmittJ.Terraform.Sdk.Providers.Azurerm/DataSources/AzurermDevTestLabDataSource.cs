using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for timeouts in AzurermDevTestLabDataSource.
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
    public TerraformValue<string>? Read
    {
        get => new TerraformReference<string>(this, "read");
        set => SetArgument("read", value);
    }

}


/// <summary>
/// Represents a azurerm_dev_test_lab Terraform data source.
/// Retrieves information about a azurerm_dev_test_lab.
/// </summary>
public partial class AzurermDevTestLabDataSource(string name) : TerraformDataSource("azurerm_dev_test_lab", name)
{
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
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    public required TerraformValue<string> ResourceGroupName
    {
        get => new TerraformReference<string>(this, "resource_group_name");
        set => SetArgument("resource_group_name", value);
    }

    /// <summary>
    /// The artifacts_storage_account_id attribute.
    /// </summary>
    public TerraformValue<string> ArtifactsStorageAccountId
    {
        get => new TerraformReference<string>(this, "artifacts_storage_account_id");
    }

    /// <summary>
    /// The default_premium_storage_account_id attribute.
    /// </summary>
    public TerraformValue<string> DefaultPremiumStorageAccountId
    {
        get => new TerraformReference<string>(this, "default_premium_storage_account_id");
    }

    /// <summary>
    /// The default_storage_account_id attribute.
    /// </summary>
    public TerraformValue<string> DefaultStorageAccountId
    {
        get => new TerraformReference<string>(this, "default_storage_account_id");
    }

    /// <summary>
    /// The key_vault_id attribute.
    /// </summary>
    public TerraformValue<string> KeyVaultId
    {
        get => new TerraformReference<string>(this, "key_vault_id");
    }

    /// <summary>
    /// The location attribute.
    /// </summary>
    public TerraformValue<string> Location
    {
        get => new TerraformReference<string>(this, "location");
    }

    /// <summary>
    /// The premium_data_disk_storage_account_id attribute.
    /// </summary>
    public TerraformValue<string> PremiumDataDiskStorageAccountId
    {
        get => new TerraformReference<string>(this, "premium_data_disk_storage_account_id");
    }

    /// <summary>
    /// The storage_type attribute.
    /// </summary>
    public TerraformValue<string> StorageType
    {
        get => new TerraformReference<string>(this, "storage_type");
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string> Tags
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "tags").ResolveNodes(ctx));
    }

    /// <summary>
    /// The unique_identifier attribute.
    /// </summary>
    public TerraformValue<string> UniqueIdentifier
    {
        get => new TerraformReference<string>(this, "unique_identifier");
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermDevTestLabDataSourceTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermDevTestLabDataSourceTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}

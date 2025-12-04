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
        get => GetArgument<TerraformValue<string>>("read");
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
        get => GetArgument<TerraformValue<string>>("id") ?? AsReference("id");
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
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    public required TerraformValue<string> ResourceGroupName
    {
        get => GetRequiredArgument<TerraformValue<string>>("resource_group_name");
        set => SetArgument("resource_group_name", value);
    }

    /// <summary>
    /// The artifacts_storage_account_id attribute.
    /// </summary>
    public TerraformValue<string> ArtifactsStorageAccountId
        => AsReference("artifacts_storage_account_id");

    /// <summary>
    /// The default_premium_storage_account_id attribute.
    /// </summary>
    public TerraformValue<string> DefaultPremiumStorageAccountId
        => AsReference("default_premium_storage_account_id");

    /// <summary>
    /// The default_storage_account_id attribute.
    /// </summary>
    public TerraformValue<string> DefaultStorageAccountId
        => AsReference("default_storage_account_id");

    /// <summary>
    /// The key_vault_id attribute.
    /// </summary>
    public TerraformValue<string> KeyVaultId
        => AsReference("key_vault_id");

    /// <summary>
    /// The location attribute.
    /// </summary>
    public TerraformValue<string> Location
        => AsReference("location");

    /// <summary>
    /// The premium_data_disk_storage_account_id attribute.
    /// </summary>
    public TerraformValue<string> PremiumDataDiskStorageAccountId
        => AsReference("premium_data_disk_storage_account_id");

    /// <summary>
    /// The storage_type attribute.
    /// </summary>
    public TerraformValue<string> StorageType
        => AsReference("storage_type");

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string> Tags
        => AsReference("tags");

    /// <summary>
    /// The unique_identifier attribute.
    /// </summary>
    public TerraformValue<string> UniqueIdentifier
        => AsReference("unique_identifier");

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermDevTestLabDataSourceTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermDevTestLabDataSourceTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}

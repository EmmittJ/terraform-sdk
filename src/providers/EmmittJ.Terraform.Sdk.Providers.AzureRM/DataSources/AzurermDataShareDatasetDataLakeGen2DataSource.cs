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
public class AzurermDataShareDatasetDataLakeGen2DataSourceTimeoutsBlock : TerraformBlock
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
/// Retrieves information about a azurerm_data_share_dataset_data_lake_gen2.
/// </summary>
public class AzurermDataShareDatasetDataLakeGen2DataSource : TerraformDataSource
{
    public AzurermDataShareDatasetDataLakeGen2DataSource(string name) : base("azurerm_data_share_dataset_data_lake_gen2", name)
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
    /// The share_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ShareId is required")]
    [TerraformArgument("share_id")]
    public required TerraformValue<string> ShareId
    {
        get => new TerraformReference<string>(this, "share_id");
        set => SetArgument("share_id", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformArgument("timeouts")]
    public AzurermDataShareDatasetDataLakeGen2DataSourceTimeoutsBlock Timeouts { get; set; } = new();

    /// <summary>
    /// The display_name attribute.
    /// </summary>
    [TerraformArgument("display_name")]
    public TerraformValue<string> DisplayName
    {
        get => new TerraformReference<string>(this, "display_name");
    }

    /// <summary>
    /// The file_path attribute.
    /// </summary>
    [TerraformArgument("file_path")]
    public TerraformValue<string> FilePath
    {
        get => new TerraformReference<string>(this, "file_path");
    }

    /// <summary>
    /// The file_system_name attribute.
    /// </summary>
    [TerraformArgument("file_system_name")]
    public TerraformValue<string> FileSystemName
    {
        get => new TerraformReference<string>(this, "file_system_name");
    }

    /// <summary>
    /// The folder_path attribute.
    /// </summary>
    [TerraformArgument("folder_path")]
    public TerraformValue<string> FolderPath
    {
        get => new TerraformReference<string>(this, "folder_path");
    }

    /// <summary>
    /// The storage_account_id attribute.
    /// </summary>
    [TerraformArgument("storage_account_id")]
    public TerraformValue<string> StorageAccountId
    {
        get => new TerraformReference<string>(this, "storage_account_id");
    }

}

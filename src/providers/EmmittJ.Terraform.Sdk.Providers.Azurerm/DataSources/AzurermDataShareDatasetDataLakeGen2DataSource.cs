using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for timeouts in AzurermDataShareDatasetDataLakeGen2DataSource.
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
    public TerraformValue<string>? Read
    {
        get => GetArgument<TerraformValue<string>>("read");
        set => SetArgument("read", value);
    }

}


/// <summary>
/// Represents a azurerm_data_share_dataset_data_lake_gen2 Terraform data source.
/// Retrieves information about a azurerm_data_share_dataset_data_lake_gen2.
/// </summary>
public partial class AzurermDataShareDatasetDataLakeGen2DataSource(string name) : TerraformDataSource("azurerm_data_share_dataset_data_lake_gen2", name)
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
    /// The share_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ShareId is required")]
    public required TerraformValue<string> ShareId
    {
        get => GetRequiredArgument<TerraformValue<string>>("share_id");
        set => SetArgument("share_id", value);
    }

    /// <summary>
    /// The display_name attribute.
    /// </summary>
    public TerraformValue<string> DisplayName
        => AsReference("display_name");

    /// <summary>
    /// The file_path attribute.
    /// </summary>
    public TerraformValue<string> FilePath
        => AsReference("file_path");

    /// <summary>
    /// The file_system_name attribute.
    /// </summary>
    public TerraformValue<string> FileSystemName
        => AsReference("file_system_name");

    /// <summary>
    /// The folder_path attribute.
    /// </summary>
    public TerraformValue<string> FolderPath
        => AsReference("folder_path");

    /// <summary>
    /// The storage_account_id attribute.
    /// </summary>
    public TerraformValue<string> StorageAccountId
        => AsReference("storage_account_id");

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermDataShareDatasetDataLakeGen2DataSourceTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermDataShareDatasetDataLakeGen2DataSourceTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}

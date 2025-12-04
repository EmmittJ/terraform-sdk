using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for timeouts in AzurermStorageTableDataSource.
/// Nesting mode: single
/// </summary>
public class AzurermStorageTableDataSourceTimeoutsBlock : TerraformBlock
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
/// Represents a azurerm_storage_table Terraform data source.
/// Retrieves information about a azurerm_storage_table.
/// </summary>
public partial class AzurermStorageTableDataSource(string name) : TerraformDataSource("azurerm_storage_table", name)
{
    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The storage_account_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "StorageAccountName is required")]
    public required TerraformValue<string> StorageAccountName
    {
        get => GetArgument<TerraformValue<string>>("storage_account_name");
        set => SetArgument("storage_account_name", value);
    }

    /// <summary>
    /// The acl attribute.
    /// </summary>
    public TerraformSet<TerraformMap<object>> Acl
        => AsReference("acl");

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
        => AsReference("id");

    /// <summary>
    /// The resource_manager_id attribute.
    /// </summary>
    public TerraformValue<string> ResourceManagerId
        => AsReference("resource_manager_id");

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermStorageTableDataSourceTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermStorageTableDataSourceTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}

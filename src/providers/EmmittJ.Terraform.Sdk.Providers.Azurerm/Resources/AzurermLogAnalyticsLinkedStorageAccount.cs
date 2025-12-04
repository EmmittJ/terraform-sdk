using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for timeouts in AzurermLogAnalyticsLinkedStorageAccount.
/// Nesting mode: single
/// </summary>
public class AzurermLogAnalyticsLinkedStorageAccountTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "timeouts";

    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformValue<string>? Create
    {
        get => GetArgument<TerraformValue<string>>("create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformValue<string>? Delete
    {
        get => GetArgument<TerraformValue<string>>("delete");
        set => SetArgument("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformValue<string>? Read
    {
        get => GetArgument<TerraformValue<string>>("read");
        set => SetArgument("read", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformValue<string>? Update
    {
        get => GetArgument<TerraformValue<string>>("update");
        set => SetArgument("update", value);
    }

}


/// <summary>
/// Represents a azurerm_log_analytics_linked_storage_account Terraform resource.
/// Manages a azurerm_log_analytics_linked_storage_account resource.
/// </summary>
public partial class AzurermLogAnalyticsLinkedStorageAccount(string name) : TerraformResource("azurerm_log_analytics_linked_storage_account", name)
{
    /// <summary>
    /// The data_source_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DataSourceTypeAttribute is required")]
    public required TerraformValue<string> DataSourceTypeAttribute
    {
        get => GetArgument<TerraformValue<string>>("data_source_type");
        set => SetArgument("data_source_type", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string>? Id
    {
        get => GetArgument<TerraformValue<string>>("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    public required TerraformValue<string> ResourceGroupName
    {
        get => GetArgument<TerraformValue<string>>("resource_group_name");
        set => SetArgument("resource_group_name", value);
    }

    /// <summary>
    /// The storage_account_ids attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "StorageAccountIds is required")]
    public required TerraformSet<string> StorageAccountIds
    {
        get => GetArgument<TerraformSet<string>>("storage_account_ids");
        set => SetArgument("storage_account_ids", value);
    }

    /// <summary>
    /// The workspace_id attribute.
    /// </summary>
    public TerraformValue<string>? WorkspaceId
    {
        get => GetArgument<TerraformValue<string>>("workspace_id");
        set => SetArgument("workspace_id", value);
    }

    /// <summary>
    /// The workspace_resource_id attribute.
    /// </summary>
    public TerraformValue<string>? WorkspaceResourceId
    {
        get => GetArgument<TerraformValue<string>>("workspace_resource_id");
        set => SetArgument("workspace_resource_id", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermLogAnalyticsLinkedStorageAccountTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermLogAnalyticsLinkedStorageAccountTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}

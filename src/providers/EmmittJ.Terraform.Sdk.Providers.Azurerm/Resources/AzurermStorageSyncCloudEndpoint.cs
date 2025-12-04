using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for timeouts in AzurermStorageSyncCloudEndpoint.
/// Nesting mode: single
/// </summary>
public class AzurermStorageSyncCloudEndpointTimeoutsBlock : TerraformBlock
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

}


/// <summary>
/// Represents a azurerm_storage_sync_cloud_endpoint Terraform resource.
/// Manages a azurerm_storage_sync_cloud_endpoint resource.
/// </summary>
public partial class AzurermStorageSyncCloudEndpoint(string name) : TerraformResource("azurerm_storage_sync_cloud_endpoint", name)
{
    /// <summary>
    /// The file_share_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "FileShareName is required")]
    public required TerraformValue<string> FileShareName
    {
        get => GetRequiredArgument<TerraformValue<string>>("file_share_name");
        set => SetArgument("file_share_name", value);
    }

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
    /// The storage_account_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "StorageAccountId is required")]
    public required TerraformValue<string> StorageAccountId
    {
        get => GetRequiredArgument<TerraformValue<string>>("storage_account_id");
        set => SetArgument("storage_account_id", value);
    }

    /// <summary>
    /// The storage_account_tenant_id attribute.
    /// </summary>
    public TerraformValue<string> StorageAccountTenantId
    {
        get => GetArgument<TerraformValue<string>>("storage_account_tenant_id") ?? AsReference("storage_account_tenant_id");
        set => SetArgument("storage_account_tenant_id", value);
    }

    /// <summary>
    /// The storage_sync_group_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "StorageSyncGroupId is required")]
    public required TerraformValue<string> StorageSyncGroupId
    {
        get => GetRequiredArgument<TerraformValue<string>>("storage_sync_group_id");
        set => SetArgument("storage_sync_group_id", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermStorageSyncCloudEndpointTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermStorageSyncCloudEndpointTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}

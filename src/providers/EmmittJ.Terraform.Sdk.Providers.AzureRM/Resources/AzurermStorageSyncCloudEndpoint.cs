using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for timeouts in .
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
        get => new TerraformReference<string>(this, "create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformValue<string>? Delete
    {
        get => new TerraformReference<string>(this, "delete");
        set => SetArgument("delete", value);
    }

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
        get => new TerraformReference<string>(this, "file_share_name");
        set => SetArgument("file_share_name", value);
    }

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
    /// The storage_account_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "StorageAccountId is required")]
    public required TerraformValue<string> StorageAccountId
    {
        get => new TerraformReference<string>(this, "storage_account_id");
        set => SetArgument("storage_account_id", value);
    }

    /// <summary>
    /// The storage_account_tenant_id attribute.
    /// </summary>
    public TerraformValue<string> StorageAccountTenantId
    {
        get => new TerraformReference<string>(this, "storage_account_tenant_id");
        set => SetArgument("storage_account_tenant_id", value);
    }

    /// <summary>
    /// The storage_sync_group_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "StorageSyncGroupId is required")]
    public required TerraformValue<string> StorageSyncGroupId
    {
        get => new TerraformReference<string>(this, "storage_sync_group_id");
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

using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for timeouts in AzurermDatabricksWorkspaceDataSource.
/// Nesting mode: single
/// </summary>
public class AzurermDatabricksWorkspaceDataSourceTimeoutsBlock : TerraformBlock
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
/// Represents a azurerm_databricks_workspace Terraform data source.
/// Retrieves information about a azurerm_databricks_workspace.
/// </summary>
public partial class AzurermDatabricksWorkspaceDataSource(string name) : TerraformDataSource("azurerm_databricks_workspace", name)
{
    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string>? Id
    {
        get => GetArgument<TerraformValue<string>>("id");
        set => SetArgument("id", value);
    }

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
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    public required TerraformValue<string> ResourceGroupName
    {
        get => GetArgument<TerraformValue<string>>("resource_group_name");
        set => SetArgument("resource_group_name", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string>? Tags
    {
        get => GetArgument<TerraformMap<string>>("tags");
        set => SetArgument("tags", value);
    }

    /// <summary>
    /// The custom_parameters attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> CustomParameters
        => AsReference("custom_parameters");

    /// <summary>
    /// The enhanced_security_compliance attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> EnhancedSecurityCompliance
        => AsReference("enhanced_security_compliance");

    /// <summary>
    /// The location attribute.
    /// </summary>
    public TerraformValue<string> Location
        => AsReference("location");

    /// <summary>
    /// The managed_disk_identity attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> ManagedDiskIdentity
        => AsReference("managed_disk_identity");

    /// <summary>
    /// The sku attribute.
    /// </summary>
    public TerraformValue<string> Sku
        => AsReference("sku");

    /// <summary>
    /// The storage_account_identity attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> StorageAccountIdentity
        => AsReference("storage_account_identity");

    /// <summary>
    /// The workspace_id attribute.
    /// </summary>
    public TerraformValue<string> WorkspaceId
        => AsReference("workspace_id");

    /// <summary>
    /// The workspace_url attribute.
    /// </summary>
    public TerraformValue<string> WorkspaceUrl
        => AsReference("workspace_url");

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermDatabricksWorkspaceDataSourceTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermDatabricksWorkspaceDataSourceTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}

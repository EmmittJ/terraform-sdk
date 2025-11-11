using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermDatabricksWorkspaceDataSourceTimeoutsBlock
{
    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformPropertyName("read")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Read { get; set; }

}

/// <summary>
/// Retrieves information about a azurerm_databricks_workspace.
/// </summary>
public class AzurermDatabricksWorkspaceDataSource : TerraformDataSource
{
    public AzurermDatabricksWorkspaceDataSource(string name) : base("azurerm_databricks_workspace", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Id { get; set; } = default!;

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    [TerraformPropertyName("resource_group_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> ResourceGroupName { get; set; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformPropertyName("tags")]
    // Optional argument - user may or may not set a value
    public TerraformMap<string>? Tags { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AzurermDatabricksWorkspaceDataSourceTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// The custom_parameters attribute.
    /// </summary>
    [TerraformPropertyName("custom_parameters")]
    // Output-only attribute - read-only reference
    public TerraformList<object> CustomParameters => new TerraformReference(this, "custom_parameters");

    /// <summary>
    /// The enhanced_security_compliance attribute.
    /// </summary>
    [TerraformPropertyName("enhanced_security_compliance")]
    // Output-only attribute - read-only reference
    public TerraformList<object> EnhancedSecurityCompliance => new TerraformReference(this, "enhanced_security_compliance");

    /// <summary>
    /// The location attribute.
    /// </summary>
    [TerraformPropertyName("location")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Location => new TerraformReference(this, "location");

    /// <summary>
    /// The managed_disk_identity attribute.
    /// </summary>
    [TerraformPropertyName("managed_disk_identity")]
    // Output-only attribute - read-only reference
    public TerraformList<object> ManagedDiskIdentity => new TerraformReference(this, "managed_disk_identity");

    /// <summary>
    /// The sku attribute.
    /// </summary>
    [TerraformPropertyName("sku")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Sku => new TerraformReference(this, "sku");

    /// <summary>
    /// The storage_account_identity attribute.
    /// </summary>
    [TerraformPropertyName("storage_account_identity")]
    // Output-only attribute - read-only reference
    public TerraformList<object> StorageAccountIdentity => new TerraformReference(this, "storage_account_identity");

    /// <summary>
    /// The workspace_id attribute.
    /// </summary>
    [TerraformPropertyName("workspace_id")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> WorkspaceId => new TerraformReference(this, "workspace_id");

    /// <summary>
    /// The workspace_url attribute.
    /// </summary>
    [TerraformPropertyName("workspace_url")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> WorkspaceUrl => new TerraformReference(this, "workspace_url");

}

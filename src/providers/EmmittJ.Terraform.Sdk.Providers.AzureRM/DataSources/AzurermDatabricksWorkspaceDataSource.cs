using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AzurermDatabricksWorkspaceDataSourceTimeoutsBlock : TerraformBlockBase
{
    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformProperty("read")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Read { get; set; }

}

/// <summary>
/// Retrieves information about a azurerm_databricks_workspace.
/// </summary>
public partial class AzurermDatabricksWorkspaceDataSource : TerraformDataSource
{
    public AzurermDatabricksWorkspaceDataSource(string name) : base("azurerm_databricks_workspace", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    [TerraformProperty("resource_group_name")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> ResourceGroupName { get; set; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformProperty("tags")]
    // Optional argument - source generator will implement get/set
    public TerraformMap<string>? Tags { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public TerraformBlock<AzurermDatabricksWorkspaceDataSourceTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// The custom_parameters attribute.
    /// </summary>
    [TerraformProperty("custom_parameters")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformList<object> CustomParameters { get; }

    /// <summary>
    /// The enhanced_security_compliance attribute.
    /// </summary>
    [TerraformProperty("enhanced_security_compliance")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformList<object> EnhancedSecurityCompliance { get; }

    /// <summary>
    /// The location attribute.
    /// </summary>
    [TerraformProperty("location")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Location { get; }

    /// <summary>
    /// The managed_disk_identity attribute.
    /// </summary>
    [TerraformProperty("managed_disk_identity")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformList<object> ManagedDiskIdentity { get; }

    /// <summary>
    /// The sku attribute.
    /// </summary>
    [TerraformProperty("sku")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Sku { get; }

    /// <summary>
    /// The storage_account_identity attribute.
    /// </summary>
    [TerraformProperty("storage_account_identity")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformList<object> StorageAccountIdentity { get; }

    /// <summary>
    /// The workspace_id attribute.
    /// </summary>
    [TerraformProperty("workspace_id")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> WorkspaceId { get; }

    /// <summary>
    /// The workspace_url attribute.
    /// </summary>
    [TerraformProperty("workspace_url")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> WorkspaceUrl { get; }

}

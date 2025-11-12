using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AzurermDatabricksWorkspaceDataSourceTimeoutsBlock() : TerraformBlock("timeouts")
{
    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformProperty("read")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Read { get; set; }

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
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    [TerraformProperty("resource_group_name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> ResourceGroupName { get; set; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformProperty("tags")]
    // Optional argument - source generator will implement get/set
    public partial TerraformMap<string>? Tags { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public AzurermDatabricksWorkspaceDataSourceTimeoutsBlock Timeouts { get; set; } = new();

    /// <summary>
    /// The custom_parameters attribute.
    /// </summary>
    [TerraformProperty("custom_parameters")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<object> CustomParameters { get; }

    /// <summary>
    /// The enhanced_security_compliance attribute.
    /// </summary>
    [TerraformProperty("enhanced_security_compliance")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<object> EnhancedSecurityCompliance { get; }

    /// <summary>
    /// The location attribute.
    /// </summary>
    [TerraformProperty("location")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Location { get; }

    /// <summary>
    /// The managed_disk_identity attribute.
    /// </summary>
    [TerraformProperty("managed_disk_identity")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<object> ManagedDiskIdentity { get; }

    /// <summary>
    /// The sku attribute.
    /// </summary>
    [TerraformProperty("sku")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Sku { get; }

    /// <summary>
    /// The storage_account_identity attribute.
    /// </summary>
    [TerraformProperty("storage_account_identity")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<object> StorageAccountIdentity { get; }

    /// <summary>
    /// The workspace_id attribute.
    /// </summary>
    [TerraformProperty("workspace_id")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> WorkspaceId { get; }

    /// <summary>
    /// The workspace_url attribute.
    /// </summary>
    [TerraformProperty("workspace_url")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> WorkspaceUrl { get; }

}

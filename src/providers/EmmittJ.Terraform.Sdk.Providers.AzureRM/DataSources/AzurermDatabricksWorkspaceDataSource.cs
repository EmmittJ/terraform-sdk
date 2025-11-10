using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermDatabricksWorkspaceDataSourceTimeoutsBlock : ITerraformBlock
{
    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformPropertyName("read")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Read { get; set; }

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
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Name { get; set; }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    [TerraformPropertyName("resource_group_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> ResourceGroupName { get; set; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformPropertyName("tags")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>>? Tags { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AzurermDatabricksWorkspaceDataSourceTimeoutsBlock>? Timeouts { get; set; } = new();

    /// <summary>
    /// The custom_parameters attribute.
    /// </summary>
    [TerraformPropertyName("custom_parameters")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> CustomParameters => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "custom_parameters");

    /// <summary>
    /// The enhanced_security_compliance attribute.
    /// </summary>
    [TerraformPropertyName("enhanced_security_compliance")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> EnhancedSecurityCompliance => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "enhanced_security_compliance");

    /// <summary>
    /// The location attribute.
    /// </summary>
    [TerraformPropertyName("location")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Location => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "location");

    /// <summary>
    /// The managed_disk_identity attribute.
    /// </summary>
    [TerraformPropertyName("managed_disk_identity")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> ManagedDiskIdentity => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "managed_disk_identity");

    /// <summary>
    /// The sku attribute.
    /// </summary>
    [TerraformPropertyName("sku")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Sku => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "sku");

    /// <summary>
    /// The storage_account_identity attribute.
    /// </summary>
    [TerraformPropertyName("storage_account_identity")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> StorageAccountIdentity => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "storage_account_identity");

    /// <summary>
    /// The workspace_id attribute.
    /// </summary>
    [TerraformPropertyName("workspace_id")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> WorkspaceId => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "workspace_id");

    /// <summary>
    /// The workspace_url attribute.
    /// </summary>
    [TerraformPropertyName("workspace_url")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> WorkspaceUrl => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "workspace_url");

}

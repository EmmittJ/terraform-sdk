using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermStackHciClusterDataSourceTimeoutsBlock
{
    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformPropertyName("read")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Read { get; set; }

}

/// <summary>
/// Retrieves information about a azurerm_stack_hci_cluster.
/// </summary>
public class AzurermStackHciClusterDataSource : TerraformDataSource
{
    public AzurermStackHciClusterDataSource(string name) : base("azurerm_stack_hci_cluster", name)
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
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AzurermStackHciClusterDataSourceTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// The automanage_configuration_id attribute.
    /// </summary>
    [TerraformPropertyName("automanage_configuration_id")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> AutomanageConfigurationId => new TerraformReference(this, "automanage_configuration_id");

    /// <summary>
    /// The client_id attribute.
    /// </summary>
    [TerraformPropertyName("client_id")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> ClientId => new TerraformReference(this, "client_id");

    /// <summary>
    /// The cloud_id attribute.
    /// </summary>
    [TerraformPropertyName("cloud_id")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> CloudId => new TerraformReference(this, "cloud_id");

    /// <summary>
    /// The identity attribute.
    /// </summary>
    [TerraformPropertyName("identity")]
    // Output-only attribute - read-only reference
    public TerraformList<object> Identity => new TerraformReference(this, "identity");

    /// <summary>
    /// The location attribute.
    /// </summary>
    [TerraformPropertyName("location")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Location => new TerraformReference(this, "location");

    /// <summary>
    /// The resource_provider_object_id attribute.
    /// </summary>
    [TerraformPropertyName("resource_provider_object_id")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> ResourceProviderObjectId => new TerraformReference(this, "resource_provider_object_id");

    /// <summary>
    /// The service_endpoint attribute.
    /// </summary>
    [TerraformPropertyName("service_endpoint")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> ServiceEndpoint => new TerraformReference(this, "service_endpoint");

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformPropertyName("tags")]
    // Output-only attribute - read-only reference
    public TerraformMap<string> Tags => new TerraformReference(this, "tags");

    /// <summary>
    /// The tenant_id attribute.
    /// </summary>
    [TerraformPropertyName("tenant_id")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> TenantId => new TerraformReference(this, "tenant_id");

}

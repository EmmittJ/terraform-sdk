using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AzurermActiveDirectoryDomainServiceDataSourceTimeoutsBlock : TerraformBlockBase
{
    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformProperty("read")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Read { get; set; }

}

/// <summary>
/// Retrieves information about a azurerm_active_directory_domain_service.
/// </summary>
public partial class AzurermActiveDirectoryDomainServiceDataSource : TerraformDataSource
{
    public AzurermActiveDirectoryDomainServiceDataSource(string name) : base("azurerm_active_directory_domain_service", name)
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
    public TerraformBlock<AzurermActiveDirectoryDomainServiceDataSourceTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// The deployment_id attribute.
    /// </summary>
    [TerraformProperty("deployment_id")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> DeploymentId { get; }

    /// <summary>
    /// The domain_configuration_type attribute.
    /// </summary>
    [TerraformProperty("domain_configuration_type")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> DomainConfigurationType { get; }

    /// <summary>
    /// The domain_name attribute.
    /// </summary>
    [TerraformProperty("domain_name")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> DomainName { get; }

    /// <summary>
    /// The filtered_sync_enabled attribute.
    /// </summary>
    [TerraformProperty("filtered_sync_enabled")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<bool> FilteredSyncEnabled { get; }

    /// <summary>
    /// The location attribute.
    /// </summary>
    [TerraformProperty("location")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Location { get; }

    /// <summary>
    /// The notifications attribute.
    /// </summary>
    [TerraformProperty("notifications")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformList<object> Notifications { get; }

    /// <summary>
    /// The replica_sets attribute.
    /// </summary>
    [TerraformProperty("replica_sets")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformList<object> ReplicaSets { get; }

    /// <summary>
    /// The resource_id attribute.
    /// </summary>
    [TerraformProperty("resource_id")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> ResourceId { get; }

    /// <summary>
    /// The secure_ldap attribute.
    /// </summary>
    [TerraformProperty("secure_ldap")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformList<object> SecureLdap { get; }

    /// <summary>
    /// The security attribute.
    /// </summary>
    [TerraformProperty("security")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformList<object> Security { get; }

    /// <summary>
    /// The sku attribute.
    /// </summary>
    [TerraformProperty("sku")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Sku { get; }

    /// <summary>
    /// The sync_owner attribute.
    /// </summary>
    [TerraformProperty("sync_owner")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> SyncOwner { get; }

    /// <summary>
    /// The tenant_id attribute.
    /// </summary>
    [TerraformProperty("tenant_id")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> TenantId { get; }

    /// <summary>
    /// The version attribute.
    /// </summary>
    [TerraformProperty("version")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<double> Version { get; }

}

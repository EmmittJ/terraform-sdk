using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermActiveDirectoryDomainServiceDataSourceTimeoutsBlock
{
    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformPropertyName("read")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Read { get; set; }

}

/// <summary>
/// Retrieves information about a azurerm_active_directory_domain_service.
/// </summary>
public class AzurermActiveDirectoryDomainServiceDataSource : TerraformDataSource
{
    public AzurermActiveDirectoryDomainServiceDataSource(string name) : base("azurerm_active_directory_domain_service", name)
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
    public TerraformBlock<AzurermActiveDirectoryDomainServiceDataSourceTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// The deployment_id attribute.
    /// </summary>
    [TerraformPropertyName("deployment_id")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> DeploymentId => new TerraformReference(this, "deployment_id");

    /// <summary>
    /// The domain_configuration_type attribute.
    /// </summary>
    [TerraformPropertyName("domain_configuration_type")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> DomainConfigurationType => new TerraformReference(this, "domain_configuration_type");

    /// <summary>
    /// The domain_name attribute.
    /// </summary>
    [TerraformPropertyName("domain_name")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> DomainName => new TerraformReference(this, "domain_name");

    /// <summary>
    /// The filtered_sync_enabled attribute.
    /// </summary>
    [TerraformPropertyName("filtered_sync_enabled")]
    // Output-only attribute - read-only reference
    public TerraformValue<bool> FilteredSyncEnabled => new TerraformReference(this, "filtered_sync_enabled");

    /// <summary>
    /// The location attribute.
    /// </summary>
    [TerraformPropertyName("location")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Location => new TerraformReference(this, "location");

    /// <summary>
    /// The notifications attribute.
    /// </summary>
    [TerraformPropertyName("notifications")]
    // Output-only attribute - read-only reference
    public TerraformList<object> Notifications => new TerraformReference(this, "notifications");

    /// <summary>
    /// The replica_sets attribute.
    /// </summary>
    [TerraformPropertyName("replica_sets")]
    // Output-only attribute - read-only reference
    public TerraformList<object> ReplicaSets => new TerraformReference(this, "replica_sets");

    /// <summary>
    /// The resource_id attribute.
    /// </summary>
    [TerraformPropertyName("resource_id")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> ResourceId => new TerraformReference(this, "resource_id");

    /// <summary>
    /// The secure_ldap attribute.
    /// </summary>
    [TerraformPropertyName("secure_ldap")]
    // Output-only attribute - read-only reference
    public TerraformList<object> SecureLdap => new TerraformReference(this, "secure_ldap");

    /// <summary>
    /// The security attribute.
    /// </summary>
    [TerraformPropertyName("security")]
    // Output-only attribute - read-only reference
    public TerraformList<object> Security => new TerraformReference(this, "security");

    /// <summary>
    /// The sku attribute.
    /// </summary>
    [TerraformPropertyName("sku")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Sku => new TerraformReference(this, "sku");

    /// <summary>
    /// The sync_owner attribute.
    /// </summary>
    [TerraformPropertyName("sync_owner")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> SyncOwner => new TerraformReference(this, "sync_owner");

    /// <summary>
    /// The tenant_id attribute.
    /// </summary>
    [TerraformPropertyName("tenant_id")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> TenantId => new TerraformReference(this, "tenant_id");

    /// <summary>
    /// The version attribute.
    /// </summary>
    [TerraformPropertyName("version")]
    // Output-only attribute - read-only reference
    public TerraformValue<double> Version => new TerraformReference(this, "version");

}

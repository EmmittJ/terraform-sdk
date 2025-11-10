using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermActiveDirectoryDomainServiceDataSourceTimeoutsBlock : ITerraformBlock
{
    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformPropertyName("read")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Read { get; set; }

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
    public TerraformBlock<AzurermActiveDirectoryDomainServiceDataSourceTimeoutsBlock>? Timeouts { get; set; } = new();

    /// <summary>
    /// The deployment_id attribute.
    /// </summary>
    [TerraformPropertyName("deployment_id")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> DeploymentId => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "deployment_id");

    /// <summary>
    /// The domain_configuration_type attribute.
    /// </summary>
    [TerraformPropertyName("domain_configuration_type")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> DomainConfigurationType => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "domain_configuration_type");

    /// <summary>
    /// The domain_name attribute.
    /// </summary>
    [TerraformPropertyName("domain_name")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> DomainName => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "domain_name");

    /// <summary>
    /// The filtered_sync_enabled attribute.
    /// </summary>
    [TerraformPropertyName("filtered_sync_enabled")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<bool>> FilteredSyncEnabled => new TerraformReferenceProperty<TerraformProperty<bool>>(ResourceAddress, "filtered_sync_enabled");

    /// <summary>
    /// The location attribute.
    /// </summary>
    [TerraformPropertyName("location")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Location => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "location");

    /// <summary>
    /// The notifications attribute.
    /// </summary>
    [TerraformPropertyName("notifications")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> Notifications => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "notifications");

    /// <summary>
    /// The replica_sets attribute.
    /// </summary>
    [TerraformPropertyName("replica_sets")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> ReplicaSets => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "replica_sets");

    /// <summary>
    /// The resource_id attribute.
    /// </summary>
    [TerraformPropertyName("resource_id")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> ResourceId => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "resource_id");

    /// <summary>
    /// The secure_ldap attribute.
    /// </summary>
    [TerraformPropertyName("secure_ldap")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> SecureLdap => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "secure_ldap");

    /// <summary>
    /// The security attribute.
    /// </summary>
    [TerraformPropertyName("security")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> Security => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "security");

    /// <summary>
    /// The sku attribute.
    /// </summary>
    [TerraformPropertyName("sku")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Sku => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "sku");

    /// <summary>
    /// The sync_owner attribute.
    /// </summary>
    [TerraformPropertyName("sync_owner")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> SyncOwner => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "sync_owner");

    /// <summary>
    /// The tenant_id attribute.
    /// </summary>
    [TerraformPropertyName("tenant_id")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> TenantId => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "tenant_id");

    /// <summary>
    /// The version attribute.
    /// </summary>
    [TerraformPropertyName("version")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<double>> Version => new TerraformReferenceProperty<TerraformProperty<double>>(ResourceAddress, "version");

}

using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermArcMachineDataSourceTimeoutsBlock : ITerraformBlock
{
    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformPropertyName("read")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Read { get; set; }

}

/// <summary>
/// Retrieves information about a azurerm_arc_machine.
/// </summary>
public class AzurermArcMachineDataSource : TerraformDataSource
{
    public AzurermArcMachineDataSource(string name) : base("azurerm_arc_machine", name)
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
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AzurermArcMachineDataSourceTimeoutsBlock>? Timeouts { get; set; } = new();

    /// <summary>
    /// The active_directory_fqdn attribute.
    /// </summary>
    [TerraformPropertyName("active_directory_fqdn")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> ActiveDirectoryFqdn => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "active_directory_fqdn");

    /// <summary>
    /// The agent attribute.
    /// </summary>
    [TerraformPropertyName("agent")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> Agent => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "agent");

    /// <summary>
    /// The agent_version attribute.
    /// </summary>
    [TerraformPropertyName("agent_version")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> AgentVersion => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "agent_version");

    /// <summary>
    /// The client_public_key attribute.
    /// </summary>
    [TerraformPropertyName("client_public_key")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> ClientPublicKey => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "client_public_key");

    /// <summary>
    /// The cloud_metadata attribute.
    /// </summary>
    [TerraformPropertyName("cloud_metadata")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> CloudMetadata => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "cloud_metadata");

    /// <summary>
    /// The detected_properties attribute.
    /// </summary>
    [TerraformPropertyName("detected_properties")]
    // Output-only attribute - read-only reference
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>> DetectedProperties => new TerraformReferenceProperty<Dictionary<string, TerraformProperty<string>>>(ResourceAddress, "detected_properties");

    /// <summary>
    /// The display_name attribute.
    /// </summary>
    [TerraformPropertyName("display_name")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> DisplayName => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "display_name");

    /// <summary>
    /// The dns_fqdn attribute.
    /// </summary>
    [TerraformPropertyName("dns_fqdn")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> DnsFqdn => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "dns_fqdn");

    /// <summary>
    /// The domain_name attribute.
    /// </summary>
    [TerraformPropertyName("domain_name")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> DomainName => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "domain_name");

    /// <summary>
    /// The identity attribute.
    /// </summary>
    [TerraformPropertyName("identity")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> Identity => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "identity");

    /// <summary>
    /// The last_status_change_time attribute.
    /// </summary>
    [TerraformPropertyName("last_status_change_time")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> LastStatusChangeTime => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "last_status_change_time");

    /// <summary>
    /// The location attribute.
    /// </summary>
    [TerraformPropertyName("location")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Location => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "location");

    /// <summary>
    /// The location_data attribute.
    /// </summary>
    [TerraformPropertyName("location_data")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> LocationData => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "location_data");

    /// <summary>
    /// The machine_fqdn attribute.
    /// </summary>
    [TerraformPropertyName("machine_fqdn")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> MachineFqdn => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "machine_fqdn");

    /// <summary>
    /// The mssql_discovered attribute.
    /// </summary>
    [TerraformPropertyName("mssql_discovered")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<bool>> MssqlDiscovered => new TerraformReferenceProperty<TerraformProperty<bool>>(ResourceAddress, "mssql_discovered");

    /// <summary>
    /// The os_name attribute.
    /// </summary>
    [TerraformPropertyName("os_name")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> OsName => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "os_name");

    /// <summary>
    /// The os_profile attribute.
    /// </summary>
    [TerraformPropertyName("os_profile")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> OsProfile => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "os_profile");

    /// <summary>
    /// The os_sku attribute.
    /// </summary>
    [TerraformPropertyName("os_sku")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> OsSku => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "os_sku");

    /// <summary>
    /// The os_type attribute.
    /// </summary>
    [TerraformPropertyName("os_type")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> OsType => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "os_type");

    /// <summary>
    /// The os_version attribute.
    /// </summary>
    [TerraformPropertyName("os_version")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> OsVersion => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "os_version");

    /// <summary>
    /// The parent_cluster_resource_id attribute.
    /// </summary>
    [TerraformPropertyName("parent_cluster_resource_id")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> ParentClusterResourceId => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "parent_cluster_resource_id");

    /// <summary>
    /// The private_link_scope_resource_id attribute.
    /// </summary>
    [TerraformPropertyName("private_link_scope_resource_id")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> PrivateLinkScopeResourceId => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "private_link_scope_resource_id");

    /// <summary>
    /// The service_status attribute.
    /// </summary>
    [TerraformPropertyName("service_status")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> ServiceStatus => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "service_status");

    /// <summary>
    /// The status attribute.
    /// </summary>
    [TerraformPropertyName("status")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Status => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "status");

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformPropertyName("tags")]
    // Output-only attribute - read-only reference
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>> Tags => new TerraformReferenceProperty<Dictionary<string, TerraformProperty<string>>>(ResourceAddress, "tags");

    /// <summary>
    /// The vm_id attribute.
    /// </summary>
    [TerraformPropertyName("vm_id")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> VmId => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "vm_id");

    /// <summary>
    /// The vm_uuid attribute.
    /// </summary>
    [TerraformPropertyName("vm_uuid")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> VmUuid => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "vm_uuid");

}

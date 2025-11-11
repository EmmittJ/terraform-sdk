using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermArcMachineDataSourceTimeoutsBlock
{
    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformPropertyName("read")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Read { get; set; }

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
    public TerraformBlock<AzurermArcMachineDataSourceTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// The active_directory_fqdn attribute.
    /// </summary>
    [TerraformPropertyName("active_directory_fqdn")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> ActiveDirectoryFqdn => new TerraformReference(this, "active_directory_fqdn");

    /// <summary>
    /// The agent attribute.
    /// </summary>
    [TerraformPropertyName("agent")]
    // Output-only attribute - read-only reference
    public TerraformList<object> Agent => new TerraformReference(this, "agent");

    /// <summary>
    /// The agent_version attribute.
    /// </summary>
    [TerraformPropertyName("agent_version")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> AgentVersion => new TerraformReference(this, "agent_version");

    /// <summary>
    /// The client_public_key attribute.
    /// </summary>
    [TerraformPropertyName("client_public_key")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> ClientPublicKey => new TerraformReference(this, "client_public_key");

    /// <summary>
    /// The cloud_metadata attribute.
    /// </summary>
    [TerraformPropertyName("cloud_metadata")]
    // Output-only attribute - read-only reference
    public TerraformList<object> CloudMetadata => new TerraformReference(this, "cloud_metadata");

    /// <summary>
    /// The detected_properties attribute.
    /// </summary>
    [TerraformPropertyName("detected_properties")]
    // Output-only attribute - read-only reference
    public TerraformMap<string> DetectedProperties => new TerraformReference(this, "detected_properties");

    /// <summary>
    /// The display_name attribute.
    /// </summary>
    [TerraformPropertyName("display_name")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> DisplayName => new TerraformReference(this, "display_name");

    /// <summary>
    /// The dns_fqdn attribute.
    /// </summary>
    [TerraformPropertyName("dns_fqdn")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> DnsFqdn => new TerraformReference(this, "dns_fqdn");

    /// <summary>
    /// The domain_name attribute.
    /// </summary>
    [TerraformPropertyName("domain_name")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> DomainName => new TerraformReference(this, "domain_name");

    /// <summary>
    /// The identity attribute.
    /// </summary>
    [TerraformPropertyName("identity")]
    // Output-only attribute - read-only reference
    public TerraformList<object> Identity => new TerraformReference(this, "identity");

    /// <summary>
    /// The last_status_change_time attribute.
    /// </summary>
    [TerraformPropertyName("last_status_change_time")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> LastStatusChangeTime => new TerraformReference(this, "last_status_change_time");

    /// <summary>
    /// The location attribute.
    /// </summary>
    [TerraformPropertyName("location")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Location => new TerraformReference(this, "location");

    /// <summary>
    /// The location_data attribute.
    /// </summary>
    [TerraformPropertyName("location_data")]
    // Output-only attribute - read-only reference
    public TerraformList<object> LocationData => new TerraformReference(this, "location_data");

    /// <summary>
    /// The machine_fqdn attribute.
    /// </summary>
    [TerraformPropertyName("machine_fqdn")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> MachineFqdn => new TerraformReference(this, "machine_fqdn");

    /// <summary>
    /// The mssql_discovered attribute.
    /// </summary>
    [TerraformPropertyName("mssql_discovered")]
    // Output-only attribute - read-only reference
    public TerraformValue<bool> MssqlDiscovered => new TerraformReference(this, "mssql_discovered");

    /// <summary>
    /// The os_name attribute.
    /// </summary>
    [TerraformPropertyName("os_name")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> OsName => new TerraformReference(this, "os_name");

    /// <summary>
    /// The os_profile attribute.
    /// </summary>
    [TerraformPropertyName("os_profile")]
    // Output-only attribute - read-only reference
    public TerraformList<object> OsProfile => new TerraformReference(this, "os_profile");

    /// <summary>
    /// The os_sku attribute.
    /// </summary>
    [TerraformPropertyName("os_sku")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> OsSku => new TerraformReference(this, "os_sku");

    /// <summary>
    /// The os_type attribute.
    /// </summary>
    [TerraformPropertyName("os_type")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> OsType => new TerraformReference(this, "os_type");

    /// <summary>
    /// The os_version attribute.
    /// </summary>
    [TerraformPropertyName("os_version")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> OsVersion => new TerraformReference(this, "os_version");

    /// <summary>
    /// The parent_cluster_resource_id attribute.
    /// </summary>
    [TerraformPropertyName("parent_cluster_resource_id")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> ParentClusterResourceId => new TerraformReference(this, "parent_cluster_resource_id");

    /// <summary>
    /// The private_link_scope_resource_id attribute.
    /// </summary>
    [TerraformPropertyName("private_link_scope_resource_id")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> PrivateLinkScopeResourceId => new TerraformReference(this, "private_link_scope_resource_id");

    /// <summary>
    /// The service_status attribute.
    /// </summary>
    [TerraformPropertyName("service_status")]
    // Output-only attribute - read-only reference
    public TerraformList<object> ServiceStatus => new TerraformReference(this, "service_status");

    /// <summary>
    /// The status attribute.
    /// </summary>
    [TerraformPropertyName("status")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Status => new TerraformReference(this, "status");

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformPropertyName("tags")]
    // Output-only attribute - read-only reference
    public TerraformMap<string> Tags => new TerraformReference(this, "tags");

    /// <summary>
    /// The vm_id attribute.
    /// </summary>
    [TerraformPropertyName("vm_id")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> VmId => new TerraformReference(this, "vm_id");

    /// <summary>
    /// The vm_uuid attribute.
    /// </summary>
    [TerraformPropertyName("vm_uuid")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> VmUuid => new TerraformReference(this, "vm_uuid");

}

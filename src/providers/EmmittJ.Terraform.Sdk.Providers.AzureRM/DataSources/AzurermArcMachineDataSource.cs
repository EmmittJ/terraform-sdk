using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AzurermArcMachineDataSourceTimeoutsBlock() : TerraformBlock("timeouts")
{
    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformProperty("read")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Read { get; set; }

}

/// <summary>
/// Retrieves information about a azurerm_arc_machine.
/// </summary>
public partial class AzurermArcMachineDataSource : TerraformDataSource
{
    public AzurermArcMachineDataSource(string name) : base("azurerm_arc_machine", name)
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
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public AzurermArcMachineDataSourceTimeoutsBlock Timeouts { get; set; } = new();

    /// <summary>
    /// The active_directory_fqdn attribute.
    /// </summary>
    [TerraformProperty("active_directory_fqdn")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> ActiveDirectoryFqdn { get; }

    /// <summary>
    /// The agent attribute.
    /// </summary>
    [TerraformProperty("agent")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<object> Agent { get; }

    /// <summary>
    /// The agent_version attribute.
    /// </summary>
    [TerraformProperty("agent_version")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> AgentVersion { get; }

    /// <summary>
    /// The client_public_key attribute.
    /// </summary>
    [TerraformProperty("client_public_key")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> ClientPublicKey { get; }

    /// <summary>
    /// The cloud_metadata attribute.
    /// </summary>
    [TerraformProperty("cloud_metadata")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<object> CloudMetadata { get; }

    /// <summary>
    /// The detected_properties attribute.
    /// </summary>
    [TerraformProperty("detected_properties")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformMap<string> DetectedProperties { get; }

    /// <summary>
    /// The display_name attribute.
    /// </summary>
    [TerraformProperty("display_name")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> DisplayName { get; }

    /// <summary>
    /// The dns_fqdn attribute.
    /// </summary>
    [TerraformProperty("dns_fqdn")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> DnsFqdn { get; }

    /// <summary>
    /// The domain_name attribute.
    /// </summary>
    [TerraformProperty("domain_name")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> DomainName { get; }

    /// <summary>
    /// The identity attribute.
    /// </summary>
    [TerraformProperty("identity")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<object> Identity { get; }

    /// <summary>
    /// The last_status_change_time attribute.
    /// </summary>
    [TerraformProperty("last_status_change_time")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> LastStatusChangeTime { get; }

    /// <summary>
    /// The location attribute.
    /// </summary>
    [TerraformProperty("location")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Location { get; }

    /// <summary>
    /// The location_data attribute.
    /// </summary>
    [TerraformProperty("location_data")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<object> LocationData { get; }

    /// <summary>
    /// The machine_fqdn attribute.
    /// </summary>
    [TerraformProperty("machine_fqdn")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> MachineFqdn { get; }

    /// <summary>
    /// The mssql_discovered attribute.
    /// </summary>
    [TerraformProperty("mssql_discovered")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<bool> MssqlDiscovered { get; }

    /// <summary>
    /// The os_name attribute.
    /// </summary>
    [TerraformProperty("os_name")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> OsName { get; }

    /// <summary>
    /// The os_profile attribute.
    /// </summary>
    [TerraformProperty("os_profile")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<object> OsProfile { get; }

    /// <summary>
    /// The os_sku attribute.
    /// </summary>
    [TerraformProperty("os_sku")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> OsSku { get; }

    /// <summary>
    /// The os_type attribute.
    /// </summary>
    [TerraformProperty("os_type")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> OsType { get; }

    /// <summary>
    /// The os_version attribute.
    /// </summary>
    [TerraformProperty("os_version")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> OsVersion { get; }

    /// <summary>
    /// The parent_cluster_resource_id attribute.
    /// </summary>
    [TerraformProperty("parent_cluster_resource_id")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> ParentClusterResourceId { get; }

    /// <summary>
    /// The private_link_scope_resource_id attribute.
    /// </summary>
    [TerraformProperty("private_link_scope_resource_id")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> PrivateLinkScopeResourceId { get; }

    /// <summary>
    /// The service_status attribute.
    /// </summary>
    [TerraformProperty("service_status")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<object> ServiceStatus { get; }

    /// <summary>
    /// The status attribute.
    /// </summary>
    [TerraformProperty("status")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Status { get; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformProperty("tags")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformMap<string> Tags { get; }

    /// <summary>
    /// The vm_id attribute.
    /// </summary>
    [TerraformProperty("vm_id")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> VmId { get; }

    /// <summary>
    /// The vm_uuid attribute.
    /// </summary>
    [TerraformProperty("vm_uuid")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> VmUuid { get; }

}

using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Retrieves information about a google_compute_instance_group_manager.
/// </summary>
public class GoogleComputeInstanceGroupManagerDataSource : TerraformDataSource
{
    public GoogleComputeInstanceGroupManagerDataSource(string name) : base("google_compute_instance_group_manager", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Id { get; set; } = default!;

    /// <summary>
    /// The name of the instance group manager. Must be 1-63 characters long and comply with RFC1035. Supported characters include lowercase letters, numbers, and hyphens.
    /// </summary>
    [TerraformPropertyName("name")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Name { get; set; }

    /// <summary>
    /// The ID of the project in which the resource belongs. If it is not provided, the provider project is used.
    /// </summary>
    [TerraformPropertyName("project")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Project { get; set; }

    /// <summary>
    /// The URL of the created resource.
    /// </summary>
    [TerraformPropertyName("self_link")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? SelfLink { get; set; }

    /// <summary>
    /// The zone that instances in this group should be created in.
    /// </summary>
    [TerraformPropertyName("zone")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Zone { get; set; }

    /// <summary>
    /// Specifies configuration that overrides the instance template configuration for the group.
    /// </summary>
    [TerraformPropertyName("all_instances_config")]
    // Output-only attribute - read-only reference
    public TerraformList<object> AllInstancesConfig => new TerraformReference(this, "all_instances_config");

    /// <summary>
    /// The autohealing policies for this managed instance group. You can specify only one value.
    /// </summary>
    [TerraformPropertyName("auto_healing_policies")]
    // Output-only attribute - read-only reference
    public TerraformList<object> AutoHealingPolicies => new TerraformReference(this, "auto_healing_policies");

    /// <summary>
    /// The base instance name to use for instances in this group. The value must be a valid RFC1035 name. Supported characters are lowercase letters, numbers, and hyphens (-). Instances are named by appending a hyphen and a random four-character string to the base instance name.
    /// </summary>
    [TerraformPropertyName("base_instance_name")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> BaseInstanceName => new TerraformReference(this, "base_instance_name");

    /// <summary>
    /// Creation timestamp in RFC3339 text format.
    /// </summary>
    [TerraformPropertyName("creation_timestamp")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> CreationTimestamp => new TerraformReference(this, "creation_timestamp");

    /// <summary>
    /// An optional textual description of the instance group manager.
    /// </summary>
    [TerraformPropertyName("description")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Description => new TerraformReference(this, "description");

    /// <summary>
    /// The fingerprint of the instance group manager.
    /// </summary>
    [TerraformPropertyName("fingerprint")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Fingerprint => new TerraformReference(this, "fingerprint");

    /// <summary>
    /// The full URL of the instance group created by the manager.
    /// </summary>
    [TerraformPropertyName("instance_group")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> InstanceGroup => new TerraformReference(this, "instance_group");

    /// <summary>
    /// The unique identifier number for the resource. This identifier is defined by the server.
    /// </summary>
    [TerraformPropertyName("instance_group_manager_id")]
    // Output-only attribute - read-only reference
    public TerraformValue<double> InstanceGroupManagerId => new TerraformReference(this, "instance_group_manager_id");

    /// <summary>
    /// The instance lifecycle policy for this managed instance group.
    /// </summary>
    [TerraformPropertyName("instance_lifecycle_policy")]
    // Output-only attribute - read-only reference
    public TerraformList<object> InstanceLifecyclePolicy => new TerraformReference(this, "instance_lifecycle_policy");

    /// <summary>
    /// Pagination behavior of the listManagedInstances API method for this managed instance group. Valid values are: &amp;quot;PAGELESS&amp;quot;, &amp;quot;PAGINATED&amp;quot;. If PAGELESS (default), Pagination is disabled for the group&#39;s listManagedInstances API method. maxResults and pageToken query parameters are ignored and all instances are returned in a single response. If PAGINATED, pagination is enabled, maxResults and pageToken query parameters are respected.
    /// </summary>
    [TerraformPropertyName("list_managed_instances_results")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> ListManagedInstancesResults => new TerraformReference(this, "list_managed_instances_results");

    /// <summary>
    /// The named port configuration.
    /// </summary>
    [TerraformPropertyName("named_port")]
    // Output-only attribute - read-only reference
    public TerraformSet<object> NamedPort => new TerraformReference(this, "named_port");

    /// <summary>
    /// The operation attribute.
    /// </summary>
    [TerraformPropertyName("operation")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Operation => new TerraformReference(this, "operation");

    /// <summary>
    /// Resource policies for this managed instance group.
    /// </summary>
    [TerraformPropertyName("resource_policies")]
    // Output-only attribute - read-only reference
    public TerraformList<object> ResourcePolicies => new TerraformReference(this, "resource_policies");

    /// <summary>
    /// Standby policy for stopped and suspended instances.
    /// </summary>
    [TerraformPropertyName("standby_policy")]
    // Output-only attribute - read-only reference
    public TerraformList<object> StandbyPolicy => new TerraformReference(this, "standby_policy");

    /// <summary>
    /// Disks created on the instances that will be preserved on instance delete, update, etc.
    /// </summary>
    [TerraformPropertyName("stateful_disk")]
    // Output-only attribute - read-only reference
    public TerraformSet<object> StatefulDisk => new TerraformReference(this, "stateful_disk");

    /// <summary>
    /// External IPs considered stateful by the instance group. 
    /// </summary>
    [TerraformPropertyName("stateful_external_ip")]
    // Output-only attribute - read-only reference
    public TerraformList<object> StatefulExternalIp => new TerraformReference(this, "stateful_external_ip");

    /// <summary>
    /// External IPs considered stateful by the instance group. 
    /// </summary>
    [TerraformPropertyName("stateful_internal_ip")]
    // Output-only attribute - read-only reference
    public TerraformList<object> StatefulInternalIp => new TerraformReference(this, "stateful_internal_ip");

    /// <summary>
    /// The status of this managed instance group.
    /// </summary>
    [TerraformPropertyName("status")]
    // Output-only attribute - read-only reference
    public TerraformList<object> Status => new TerraformReference(this, "status");

    /// <summary>
    /// The full URL of all target pools to which new instances in the group are added. Updating the target pools attribute does not affect existing instances.
    /// </summary>
    [TerraformPropertyName("target_pools")]
    // Output-only attribute - read-only reference
    public TerraformSet<string> TargetPools => new TerraformReference(this, "target_pools");

    /// <summary>
    /// The target number of running instances for this managed instance group. This value should always be explicitly set unless this resource is attached to an autoscaler, in which case it should never be set. Defaults to 0.
    /// </summary>
    [TerraformPropertyName("target_size")]
    // Output-only attribute - read-only reference
    public TerraformValue<double> TargetSize => new TerraformReference(this, "target_size");

    /// <summary>
    /// The target number of stopped instances for this managed instance group.
    /// </summary>
    [TerraformPropertyName("target_stopped_size")]
    // Output-only attribute - read-only reference
    public TerraformValue<double> TargetStoppedSize => new TerraformReference(this, "target_stopped_size");

    /// <summary>
    /// The target number of suspended instances for this managed instance group.
    /// </summary>
    [TerraformPropertyName("target_suspended_size")]
    // Output-only attribute - read-only reference
    public TerraformValue<double> TargetSuspendedSize => new TerraformReference(this, "target_suspended_size");

    /// <summary>
    /// The update policy for this managed instance group.
    /// </summary>
    [TerraformPropertyName("update_policy")]
    // Output-only attribute - read-only reference
    public TerraformList<object> UpdatePolicy => new TerraformReference(this, "update_policy");

    /// <summary>
    /// Application versions managed by this instance group. Each version deals with a specific instance template, allowing canary release scenarios.
    /// </summary>
    [TerraformPropertyName("version")]
    // Output-only attribute - read-only reference
    public TerraformList<object> Version => new TerraformReference(this, "version");

    /// <summary>
    /// Whether to wait for all instances to be created/updated before returning. Note that if this is set to true and the operation does not succeed, Terraform will continue trying until it times out.
    /// </summary>
    [TerraformPropertyName("wait_for_instances")]
    // Output-only attribute - read-only reference
    public TerraformValue<bool> WaitForInstances => new TerraformReference(this, "wait_for_instances");

    /// <summary>
    /// When used with wait_for_instances specifies the status to wait for. When STABLE is specified this resource will wait until the instances are stable before returning. When UPDATED is set, it will wait for the version target to be reached and any per instance configs to be effective and all instances configs to be effective as well as all instances to be stable before returning.
    /// </summary>
    [TerraformPropertyName("wait_for_instances_status")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> WaitForInstancesStatus => new TerraformReference(this, "wait_for_instances_status");

}

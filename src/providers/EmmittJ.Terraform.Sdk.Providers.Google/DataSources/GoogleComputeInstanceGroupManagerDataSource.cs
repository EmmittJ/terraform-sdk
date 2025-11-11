using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Retrieves information about a google_compute_instance_group_manager.
/// </summary>
public partial class GoogleComputeInstanceGroupManagerDataSource : TerraformDataSource
{
    public GoogleComputeInstanceGroupManagerDataSource(string name) : base("google_compute_instance_group_manager", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The name of the instance group manager. Must be 1-63 characters long and comply with RFC1035. Supported characters include lowercase letters, numbers, and hyphens.
    /// </summary>
    [TerraformProperty("name")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Name { get; set; }

    /// <summary>
    /// The ID of the project in which the resource belongs. If it is not provided, the provider project is used.
    /// </summary>
    [TerraformProperty("project")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Project { get; set; }

    /// <summary>
    /// The URL of the created resource.
    /// </summary>
    [TerraformProperty("self_link")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? SelfLink { get; set; }

    /// <summary>
    /// The zone that instances in this group should be created in.
    /// </summary>
    [TerraformProperty("zone")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Zone { get; set; }

    /// <summary>
    /// Specifies configuration that overrides the instance template configuration for the group.
    /// </summary>
    [TerraformProperty("all_instances_config")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformList<object> AllInstancesConfig { get; }

    /// <summary>
    /// The autohealing policies for this managed instance group. You can specify only one value.
    /// </summary>
    [TerraformProperty("auto_healing_policies")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformList<object> AutoHealingPolicies { get; }

    /// <summary>
    /// The base instance name to use for instances in this group. The value must be a valid RFC1035 name. Supported characters are lowercase letters, numbers, and hyphens (-). Instances are named by appending a hyphen and a random four-character string to the base instance name.
    /// </summary>
    [TerraformProperty("base_instance_name")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> BaseInstanceName { get; }

    /// <summary>
    /// Creation timestamp in RFC3339 text format.
    /// </summary>
    [TerraformProperty("creation_timestamp")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> CreationTimestamp { get; }

    /// <summary>
    /// An optional textual description of the instance group manager.
    /// </summary>
    [TerraformProperty("description")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Description { get; }

    /// <summary>
    /// The fingerprint of the instance group manager.
    /// </summary>
    [TerraformProperty("fingerprint")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Fingerprint { get; }

    /// <summary>
    /// The full URL of the instance group created by the manager.
    /// </summary>
    [TerraformProperty("instance_group")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> InstanceGroup { get; }

    /// <summary>
    /// The unique identifier number for the resource. This identifier is defined by the server.
    /// </summary>
    [TerraformProperty("instance_group_manager_id")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<double> InstanceGroupManagerId { get; }

    /// <summary>
    /// The instance lifecycle policy for this managed instance group.
    /// </summary>
    [TerraformProperty("instance_lifecycle_policy")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformList<object> InstanceLifecyclePolicy { get; }

    /// <summary>
    /// Pagination behavior of the listManagedInstances API method for this managed instance group. Valid values are: &amp;quot;PAGELESS&amp;quot;, &amp;quot;PAGINATED&amp;quot;. If PAGELESS (default), Pagination is disabled for the group&#39;s listManagedInstances API method. maxResults and pageToken query parameters are ignored and all instances are returned in a single response. If PAGINATED, pagination is enabled, maxResults and pageToken query parameters are respected.
    /// </summary>
    [TerraformProperty("list_managed_instances_results")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> ListManagedInstancesResults { get; }

    /// <summary>
    /// The named port configuration.
    /// </summary>
    [TerraformProperty("named_port")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformSet<object> NamedPort { get; }

    /// <summary>
    /// The operation attribute.
    /// </summary>
    [TerraformProperty("operation")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Operation { get; }

    /// <summary>
    /// Resource policies for this managed instance group.
    /// </summary>
    [TerraformProperty("resource_policies")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformList<object> ResourcePolicies { get; }

    /// <summary>
    /// Standby policy for stopped and suspended instances.
    /// </summary>
    [TerraformProperty("standby_policy")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformList<object> StandbyPolicy { get; }

    /// <summary>
    /// Disks created on the instances that will be preserved on instance delete, update, etc.
    /// </summary>
    [TerraformProperty("stateful_disk")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformSet<object> StatefulDisk { get; }

    /// <summary>
    /// External IPs considered stateful by the instance group. 
    /// </summary>
    [TerraformProperty("stateful_external_ip")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformList<object> StatefulExternalIp { get; }

    /// <summary>
    /// External IPs considered stateful by the instance group. 
    /// </summary>
    [TerraformProperty("stateful_internal_ip")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformList<object> StatefulInternalIp { get; }

    /// <summary>
    /// The status of this managed instance group.
    /// </summary>
    [TerraformProperty("status")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformList<object> Status { get; }

    /// <summary>
    /// The full URL of all target pools to which new instances in the group are added. Updating the target pools attribute does not affect existing instances.
    /// </summary>
    [TerraformProperty("target_pools")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformSet<string> TargetPools { get; }

    /// <summary>
    /// The target number of running instances for this managed instance group. This value should always be explicitly set unless this resource is attached to an autoscaler, in which case it should never be set. Defaults to 0.
    /// </summary>
    [TerraformProperty("target_size")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<double> TargetSize { get; }

    /// <summary>
    /// The target number of stopped instances for this managed instance group.
    /// </summary>
    [TerraformProperty("target_stopped_size")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<double> TargetStoppedSize { get; }

    /// <summary>
    /// The target number of suspended instances for this managed instance group.
    /// </summary>
    [TerraformProperty("target_suspended_size")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<double> TargetSuspendedSize { get; }

    /// <summary>
    /// The update policy for this managed instance group.
    /// </summary>
    [TerraformProperty("update_policy")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformList<object> UpdatePolicy { get; }

    /// <summary>
    /// Application versions managed by this instance group. Each version deals with a specific instance template, allowing canary release scenarios.
    /// </summary>
    [TerraformProperty("version")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformList<object> Version { get; }

    /// <summary>
    /// Whether to wait for all instances to be created/updated before returning. Note that if this is set to true and the operation does not succeed, Terraform will continue trying until it times out.
    /// </summary>
    [TerraformProperty("wait_for_instances")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<bool> WaitForInstances { get; }

    /// <summary>
    /// When used with wait_for_instances specifies the status to wait for. When STABLE is specified this resource will wait until the instances are stable before returning. When UPDATED is set, it will wait for the version target to be reached and any per instance configs to be effective and all instances configs to be effective as well as all instances to be stable before returning.
    /// </summary>
    [TerraformProperty("wait_for_instances_status")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> WaitForInstancesStatus { get; }

}

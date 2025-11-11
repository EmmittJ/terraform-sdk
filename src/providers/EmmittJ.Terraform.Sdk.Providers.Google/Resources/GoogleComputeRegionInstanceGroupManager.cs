using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for all_instances_config in .
/// Nesting mode: list
/// </summary>
public partial class GoogleComputeRegionInstanceGroupManagerAllInstancesConfigBlock : TerraformBlockBase
{
    /// <summary>
    /// The label key-value pairs that you want to patch onto the instance,
    /// </summary>
    [TerraformProperty("labels")]
    // Optional argument - source generator will implement get/set
    public partial TerraformMap<string>? Labels { get; set; }

    /// <summary>
    /// The metadata key-value pairs that you want to patch onto the instance. For more information, see Project and instance metadata,
    /// </summary>
    [TerraformProperty("metadata")]
    // Optional argument - source generator will implement get/set
    public partial TerraformMap<string>? Metadata { get; set; }

}

/// <summary>
/// Block type for auto_healing_policies in .
/// Nesting mode: list
/// </summary>
public partial class GoogleComputeRegionInstanceGroupManagerAutoHealingPoliciesBlock : TerraformBlockBase
{
    /// <summary>
    /// The health check resource that signals autohealing.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "HealthCheck is required")]
    [TerraformProperty("health_check")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> HealthCheck { get; set; }

    /// <summary>
    /// The number of seconds that the managed instance group waits before it applies autohealing policies to new instances or recently recreated instances. Between 0 and 3600.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "InitialDelaySec is required")]
    [TerraformProperty("initial_delay_sec")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<double> InitialDelaySec { get; set; }

}

/// <summary>
/// Block type for instance_flexibility_policy in .
/// Nesting mode: list
/// </summary>
public partial class GoogleComputeRegionInstanceGroupManagerInstanceFlexibilityPolicyBlock : TerraformBlockBase
{
}

/// <summary>
/// Block type for instance_lifecycle_policy in .
/// Nesting mode: list
/// </summary>
public partial class GoogleComputeRegionInstanceGroupManagerInstanceLifecyclePolicyBlock : TerraformBlockBase
{
    /// <summary>
    /// Default behavior for all instance or health check failures.
    /// </summary>
    [TerraformProperty("default_action_on_failure")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? DefaultActionOnFailure { get; set; }

    /// <summary>
    /// Specifies whether to apply the group&#39;s latest configuration when repairing a VM. Valid options are: YES, NO. If YES and you updated the group&#39;s instance template or per-instance configurations after the VM was created, then these changes are applied when VM is repaired. If NO (default), then updates are applied in accordance with the group&#39;s update policy type.
    /// </summary>
    [TerraformProperty("force_update_on_repair")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? ForceUpdateOnRepair { get; set; }

}

/// <summary>
/// Block type for named_port in .
/// Nesting mode: set
/// </summary>
public partial class GoogleComputeRegionInstanceGroupManagerNamedPortBlock : TerraformBlockBase
{
    /// <summary>
    /// The name of the port.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The port number.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Port is required")]
    [TerraformProperty("port")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<double> Port { get; set; }

}

/// <summary>
/// Block type for standby_policy in .
/// Nesting mode: list
/// </summary>
public partial class GoogleComputeRegionInstanceGroupManagerStandbyPolicyBlock : TerraformBlockBase
{
    /// <summary>
    /// Specifies the number of seconds that the MIG should wait to suspend or stop a VM after that VM was created. The initial delay gives the initialization script the time to prepare your VM for a quick scale out. The value of initial delay must be between 0 and 3600 seconds. The default value is 0.
    /// </summary>
    [TerraformProperty("initial_delay_sec")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<double> InitialDelaySec { get; set; }

    /// <summary>
    /// Defines how a MIG resumes or starts VMs from a standby pool when the group scales out. The default mode is &amp;quot;MANUAL&amp;quot;.
    /// </summary>
    [TerraformProperty("mode")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Mode { get; set; }

}

/// <summary>
/// Block type for stateful_disk in .
/// Nesting mode: set
/// </summary>
public partial class GoogleComputeRegionInstanceGroupManagerStatefulDiskBlock : TerraformBlockBase
{
    /// <summary>
    /// A value that prescribes what should happen to the stateful disk when the VM instance is deleted. The available options are NEVER and ON_PERMANENT_INSTANCE_DELETION. NEVER - detach the disk when the VM is deleted, but do not delete the disk. ON_PERMANENT_INSTANCE_DELETION will delete the stateful disk when the VM is permanently deleted from the instance group. The default is NEVER.
    /// </summary>
    [TerraformProperty("delete_rule")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? DeleteRule { get; set; }

    /// <summary>
    /// The device name of the disk to be attached.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DeviceName is required")]
    [TerraformProperty("device_name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> DeviceName { get; set; }

}

/// <summary>
/// Block type for stateful_external_ip in .
/// Nesting mode: list
/// </summary>
public partial class GoogleComputeRegionInstanceGroupManagerStatefulExternalIpBlock : TerraformBlockBase
{
    /// <summary>
    /// A value that prescribes what should happen to an associated static Address resource when a VM instance is permanently deleted. The available options are NEVER and ON_PERMANENT_INSTANCE_DELETION. NEVER - detach the IP when the VM is deleted, but do not delete the address resource. ON_PERMANENT_INSTANCE_DELETION will delete the stateful address when the VM is permanently deleted from the instance group. The default is NEVER.
    /// </summary>
    [TerraformProperty("delete_rule")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? DeleteRule { get; set; }

    /// <summary>
    /// The network interface name
    /// </summary>
    [TerraformProperty("interface_name")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? InterfaceName { get; set; }

}

/// <summary>
/// Block type for stateful_internal_ip in .
/// Nesting mode: list
/// </summary>
public partial class GoogleComputeRegionInstanceGroupManagerStatefulInternalIpBlock : TerraformBlockBase
{
    /// <summary>
    /// A value that prescribes what should happen to an associated static Address resource when a VM instance is permanently deleted. The available options are NEVER and ON_PERMANENT_INSTANCE_DELETION. NEVER - detach the IP when the VM is deleted, but do not delete the address resource. ON_PERMANENT_INSTANCE_DELETION will delete the stateful address when the VM is permanently deleted from the instance group. The default is NEVER.
    /// </summary>
    [TerraformProperty("delete_rule")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? DeleteRule { get; set; }

    /// <summary>
    /// The network interface name
    /// </summary>
    [TerraformProperty("interface_name")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? InterfaceName { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class GoogleComputeRegionInstanceGroupManagerTimeoutsBlock : TerraformBlockBase
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformProperty("create")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformProperty("delete")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Delete { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformProperty("update")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Update { get; set; }

}

/// <summary>
/// Block type for update_policy in .
/// Nesting mode: list
/// </summary>
public partial class GoogleComputeRegionInstanceGroupManagerUpdatePolicyBlock : TerraformBlockBase
{
    /// <summary>
    /// The instance redistribution policy for regional managed instance groups. Valid values are: &amp;quot;PROACTIVE&amp;quot;, &amp;quot;NONE&amp;quot;. If PROACTIVE (default), the group attempts to maintain an even distribution of VM instances across zones in the region. If NONE, proactive redistribution is disabled.
    /// </summary>
    [TerraformProperty("instance_redistribution_type")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? InstanceRedistributionType { get; set; }

    /// <summary>
    /// Specifies a fixed number of VM instances. This must be a positive integer. Conflicts with max_surge_percent. Both cannot be 0
    /// </summary>
    [TerraformProperty("max_surge_fixed")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<double> MaxSurgeFixed { get; set; }

    /// <summary>
    /// Specifies a percentage of instances between 0 to 100%, inclusive. For example, specify 80 for 80%. Conflicts with max_surge_fixed.
    /// </summary>
    [TerraformProperty("max_surge_percent")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<double>? MaxSurgePercent { get; set; }

    /// <summary>
    /// Specifies a fixed number of VM instances. This must be a positive integer.
    /// </summary>
    [TerraformProperty("max_unavailable_fixed")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<double> MaxUnavailableFixed { get; set; }

    /// <summary>
    /// Specifies a percentage of instances between 0 to 100%, inclusive. For example, specify 80 for 80%.
    /// </summary>
    [TerraformProperty("max_unavailable_percent")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<double>? MaxUnavailablePercent { get; set; }

    /// <summary>
    /// Minimal action to be taken on an instance. You can specify either NONE to forbid any actions, REFRESH to update without stopping instances, RESTART to restart existing instances or REPLACE to delete and create new instances from the target template. If you specify a REFRESH, the Updater will attempt to perform that action only. However, if the Updater determines that the minimal action you specify is not enough to perform the update, it might perform a more disruptive action.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MinimalAction is required")]
    [TerraformProperty("minimal_action")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> MinimalAction { get; set; }

    /// <summary>
    /// Most disruptive action that is allowed to be taken on an instance. You can specify either NONE to forbid any actions, REFRESH to allow actions that do not need instance restart, RESTART to allow actions that can be applied without instance replacing or REPLACE to allow all possible actions. If the Updater determines that the minimal update action needed is more disruptive than most disruptive allowed action you specify it will not perform the update at all.
    /// </summary>
    [TerraformProperty("most_disruptive_allowed_action")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? MostDisruptiveAllowedAction { get; set; }

    /// <summary>
    /// The instance replacement method for regional managed instance groups. Valid values are: &amp;quot;RECREATE&amp;quot;, &amp;quot;SUBSTITUTE&amp;quot;. If SUBSTITUTE (default), the group replaces VM instances with new instances that have randomly generated names. If RECREATE, instance names are preserved.  You must also set max_unavailable_fixed or max_unavailable_percent to be greater than 0.
    /// </summary>
    [TerraformProperty("replacement_method")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? ReplacementMethod { get; set; }

    /// <summary>
    /// The type of update process. You can specify either PROACTIVE so that the instance group manager proactively executes actions in order to bring instances to their target versions or OPPORTUNISTIC so that no action is proactively executed but the update will be performed as part of other actions (for example, resizes or recreateInstances calls).
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    [TerraformProperty("type")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Type { get; set; }

}

/// <summary>
/// Block type for version in .
/// Nesting mode: list
/// </summary>
public partial class GoogleComputeRegionInstanceGroupManagerVersionBlock : TerraformBlockBase
{
    /// <summary>
    /// The full URL to an instance template from which all new instances of this version will be created.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "InstanceTemplate is required")]
    [TerraformProperty("instance_template")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> InstanceTemplate { get; set; }

    /// <summary>
    /// Version name.
    /// </summary>
    [TerraformProperty("name")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Name { get; set; }

}

/// <summary>
/// Manages a google_compute_region_instance_group_manager resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class GoogleComputeRegionInstanceGroupManager : TerraformResource
{
    public GoogleComputeRegionInstanceGroupManager(string name) : base("google_compute_region_instance_group_manager", name)
    {
    }

    /// <summary>
    /// The base instance name to use for instances in this group. The value must be a valid RFC1035 name. Supported characters are lowercase letters, numbers, and hyphens (-). Instances are named by appending a hyphen and a random four-character string to the base instance name.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "BaseInstanceName is required")]
    [TerraformProperty("base_instance_name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> BaseInstanceName { get; set; }

    /// <summary>
    /// An optional textual description of the instance group manager.
    /// </summary>
    [TerraformProperty("description")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Description { get; set; }

    /// <summary>
    /// The shape to which the group converges either proactively or on resize events (depending on the value set in updatePolicy.instanceRedistributionType).
    /// </summary>
    [TerraformProperty("distribution_policy_target_shape")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> DistributionPolicyTargetShape { get; set; }

    /// <summary>
    /// The distribution policy for this managed instance group. You can specify one or more values.
    /// </summary>
    [TerraformProperty("distribution_policy_zones")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformSet<string> DistributionPolicyZones { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// Pagination behavior of the listManagedInstances API method for this managed instance group. Valid values are: &amp;quot;PAGELESS&amp;quot;, &amp;quot;PAGINATED&amp;quot;. If PAGELESS (default), Pagination is disabled for the group&#39;s listManagedInstances API method. maxResults and pageToken query parameters are ignored and all instances are returned in a single response. If PAGINATED, pagination is enabled, maxResults and pageToken query parameters are respected.
    /// </summary>
    [TerraformProperty("list_managed_instances_results")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? ListManagedInstancesResults { get; set; }

    /// <summary>
    /// The name of the instance group manager. Must be 1-63 characters long and comply with RFC1035. Supported characters include lowercase letters, numbers, and hyphens.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The ID of the project in which the resource belongs. If it is not provided, the provider project is used.
    /// </summary>
    [TerraformProperty("project")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Project { get; set; }

    /// <summary>
    /// The region where the managed instance group resides.
    /// </summary>
    [TerraformProperty("region")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Region { get; set; }

    /// <summary>
    /// The full URL of all target pools to which new instances in the group are added. Updating the target pools attribute does not affect existing instances.
    /// </summary>
    [TerraformProperty("target_pools")]
    // Optional argument - source generator will implement get/set
    public partial TerraformSet<string>? TargetPools { get; set; }

    /// <summary>
    /// The target number of running instances for this managed instance group. This value should always be explicitly set unless this resource is attached to an autoscaler, in which case it should never be set. Defaults to 0.
    /// </summary>
    [TerraformProperty("target_size")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<double> TargetSize { get; set; }

    /// <summary>
    /// The target number of stopped instances for this managed instance group.
    /// </summary>
    [TerraformProperty("target_stopped_size")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<double> TargetStoppedSize { get; set; }

    /// <summary>
    /// The target number of suspended instances for this managed instance group.
    /// </summary>
    [TerraformProperty("target_suspended_size")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<double> TargetSuspendedSize { get; set; }

    /// <summary>
    /// Whether to wait for all instances to be created/updated before returning. Note that if this is set to true and the operation does not succeed, Terraform will continue trying until it times out.
    /// </summary>
    [TerraformProperty("wait_for_instances")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? WaitForInstances { get; set; }

    /// <summary>
    /// When used with wait_for_instances specifies the status to wait for. When STABLE is specified this resource will wait until the instances are stable before returning. When UPDATED is set, it will wait for the version target to be reached and any per instance configs to be effective and all instances configs to be effective as well as all instances to be stable before returning.
    /// </summary>
    [TerraformProperty("wait_for_instances_status")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? WaitForInstancesStatus { get; set; }

    /// <summary>
    /// Block for all_instances_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AllInstancesConfig block(s) allowed")]
    [TerraformProperty("all_instances_config")]
    public partial TerraformList<TerraformBlock<GoogleComputeRegionInstanceGroupManagerAllInstancesConfigBlock>>? AllInstancesConfig { get; set; }

    /// <summary>
    /// Block for auto_healing_policies.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AutoHealingPolicies block(s) allowed")]
    [TerraformProperty("auto_healing_policies")]
    public partial TerraformList<TerraformBlock<GoogleComputeRegionInstanceGroupManagerAutoHealingPoliciesBlock>>? AutoHealingPolicies { get; set; }

    /// <summary>
    /// Block for instance_flexibility_policy.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 InstanceFlexibilityPolicy block(s) allowed")]
    [TerraformProperty("instance_flexibility_policy")]
    public partial TerraformList<TerraformBlock<GoogleComputeRegionInstanceGroupManagerInstanceFlexibilityPolicyBlock>>? InstanceFlexibilityPolicy { get; set; }

    /// <summary>
    /// Block for instance_lifecycle_policy.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 InstanceLifecyclePolicy block(s) allowed")]
    [TerraformProperty("instance_lifecycle_policy")]
    public partial TerraformList<TerraformBlock<GoogleComputeRegionInstanceGroupManagerInstanceLifecyclePolicyBlock>>? InstanceLifecyclePolicy { get; set; }

    /// <summary>
    /// Block for named_port.
    /// Nesting mode: set
    /// </summary>
    [TerraformProperty("named_port")]
    public partial TerraformSet<TerraformBlock<GoogleComputeRegionInstanceGroupManagerNamedPortBlock>>? NamedPort { get; set; }

    /// <summary>
    /// Block for standby_policy.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 StandbyPolicy block(s) allowed")]
    [TerraformProperty("standby_policy")]
    public partial TerraformList<TerraformBlock<GoogleComputeRegionInstanceGroupManagerStandbyPolicyBlock>>? StandbyPolicy { get; set; }

    /// <summary>
    /// Block for stateful_disk.
    /// Nesting mode: set
    /// </summary>
    [TerraformProperty("stateful_disk")]
    public partial TerraformSet<TerraformBlock<GoogleComputeRegionInstanceGroupManagerStatefulDiskBlock>>? StatefulDisk { get; set; }

    /// <summary>
    /// Block for stateful_external_ip.
    /// Nesting mode: list
    /// </summary>
    [TerraformProperty("stateful_external_ip")]
    public partial TerraformList<TerraformBlock<GoogleComputeRegionInstanceGroupManagerStatefulExternalIpBlock>>? StatefulExternalIp { get; set; }

    /// <summary>
    /// Block for stateful_internal_ip.
    /// Nesting mode: list
    /// </summary>
    [TerraformProperty("stateful_internal_ip")]
    public partial TerraformList<TerraformBlock<GoogleComputeRegionInstanceGroupManagerStatefulInternalIpBlock>>? StatefulInternalIp { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public partial TerraformBlock<GoogleComputeRegionInstanceGroupManagerTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// Block for update_policy.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 UpdatePolicy block(s) allowed")]
    [TerraformProperty("update_policy")]
    public partial TerraformList<TerraformBlock<GoogleComputeRegionInstanceGroupManagerUpdatePolicyBlock>>? UpdatePolicy { get; set; }

    /// <summary>
    /// Block for version.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Version is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Version block(s) required")]
    [TerraformProperty("version")]
    public partial TerraformList<TerraformBlock<GoogleComputeRegionInstanceGroupManagerVersionBlock>>? Version { get; set; }

    /// <summary>
    /// Creation timestamp in RFC3339 text format.
    /// </summary>
    [TerraformProperty("creation_timestamp")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> CreationTimestamp { get; }

    /// <summary>
    /// The fingerprint of the instance group manager.
    /// </summary>
    [TerraformProperty("fingerprint")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Fingerprint { get; }

    /// <summary>
    /// The full URL of the instance group created by the manager.
    /// </summary>
    [TerraformProperty("instance_group")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> InstanceGroup { get; }

    /// <summary>
    /// The unique identifier number for the resource. This identifier is defined by the server.
    /// </summary>
    [TerraformProperty("instance_group_manager_id")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<double> InstanceGroupManagerId { get; }

    /// <summary>
    /// The URL of the created resource.
    /// </summary>
    [TerraformProperty("self_link")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> SelfLink { get; }

    /// <summary>
    /// The status of this managed instance group.
    /// </summary>
    [TerraformProperty("status")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<object> Status { get; }

}

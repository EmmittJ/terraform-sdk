using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for all_instances_config in .
/// Nesting mode: list
/// </summary>
public class GoogleComputeInstanceGroupManagerAllInstancesConfigBlock : ITerraformBlock
{
    /// <summary>
    /// The label key-value pairs that you want to patch onto the instance,
    /// </summary>
    [TerraformPropertyName("labels")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>>? Labels { get; set; }

    /// <summary>
    /// The metadata key-value pairs that you want to patch onto the instance. For more information, see Project and instance metadata,
    /// </summary>
    [TerraformPropertyName("metadata")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>>? Metadata { get; set; }

}

/// <summary>
/// Block type for auto_healing_policies in .
/// Nesting mode: list
/// </summary>
public class GoogleComputeInstanceGroupManagerAutoHealingPoliciesBlock : ITerraformBlock
{
    /// <summary>
    /// The health check resource that signals autohealing.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "HealthCheck is required")]
    [TerraformPropertyName("health_check")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> HealthCheck { get; set; }

    /// <summary>
    /// The number of seconds that the managed instance group waits before it applies autohealing policies to new instances or recently recreated instances. Between 0 and 3600.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "InitialDelaySec is required")]
    [TerraformPropertyName("initial_delay_sec")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<double>> InitialDelaySec { get; set; }

}

/// <summary>
/// Block type for instance_lifecycle_policy in .
/// Nesting mode: list
/// </summary>
public class GoogleComputeInstanceGroupManagerInstanceLifecyclePolicyBlock : ITerraformBlock
{
    /// <summary>
    /// Default behavior for all instance or health check failures.
    /// </summary>
    [TerraformPropertyName("default_action_on_failure")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? DefaultActionOnFailure { get; set; }

    /// <summary>
    /// Specifies whether to apply the group&#39;s latest configuration when repairing a VM. Valid options are: YES, NO. If YES and you updated the group&#39;s instance template or per-instance configurations after the VM was created, then these changes are applied when VM is repaired. If NO (default), then updates are applied in accordance with the group&#39;s update policy type.
    /// </summary>
    [TerraformPropertyName("force_update_on_repair")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? ForceUpdateOnRepair { get; set; }

}

/// <summary>
/// Block type for named_port in .
/// Nesting mode: set
/// </summary>
public class GoogleComputeInstanceGroupManagerNamedPortBlock : ITerraformBlock
{
    /// <summary>
    /// The name of the port.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Name { get; set; }

    /// <summary>
    /// The port number.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Port is required")]
    [TerraformPropertyName("port")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<double>> Port { get; set; }

}

/// <summary>
/// Block type for resource_policies in .
/// Nesting mode: list
/// </summary>
public class GoogleComputeInstanceGroupManagerResourcePoliciesBlock : ITerraformBlock
{
    /// <summary>
    /// The URL of the workload policy that is specified for this managed instance group. It can be a full or partial URL.
    /// </summary>
    [TerraformPropertyName("workload_policy")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? WorkloadPolicy { get; set; }

}

/// <summary>
/// Block type for standby_policy in .
/// Nesting mode: list
/// </summary>
public class GoogleComputeInstanceGroupManagerStandbyPolicyBlock : ITerraformBlock
{
    /// <summary>
    /// Specifies the number of seconds that the MIG should wait to suspend or stop a VM after that VM was created. The initial delay gives the initialization script the time to prepare your VM for a quick scale out. The value of initial delay must be between 0 and 3600 seconds. The default value is 0.
    /// </summary>
    [TerraformPropertyName("initial_delay_sec")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<double>> InitialDelaySec { get; set; } = new TerraformReferenceProperty<TerraformProperty<double>>("", "initial_delay_sec");

    /// <summary>
    /// Defines how a MIG resumes or starts VMs from a standby pool when the group scales out. The default mode is &amp;quot;MANUAL&amp;quot;.
    /// </summary>
    [TerraformPropertyName("mode")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Mode { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>("", "mode");

}

/// <summary>
/// Block type for stateful_disk in .
/// Nesting mode: set
/// </summary>
public class GoogleComputeInstanceGroupManagerStatefulDiskBlock : ITerraformBlock
{
    /// <summary>
    /// A value that prescribes what should happen to the stateful disk when the VM instance is deleted. The available options are NEVER and ON_PERMANENT_INSTANCE_DELETION. NEVER - detach the disk when the VM is deleted, but do not delete the disk. ON_PERMANENT_INSTANCE_DELETION will delete the stateful disk when the VM is permanently deleted from the instance group. The default is NEVER.
    /// </summary>
    [TerraformPropertyName("delete_rule")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? DeleteRule { get; set; }

    /// <summary>
    /// The device name of the disk to be attached.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DeviceName is required")]
    [TerraformPropertyName("device_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> DeviceName { get; set; }

}

/// <summary>
/// Block type for stateful_external_ip in .
/// Nesting mode: list
/// </summary>
public class GoogleComputeInstanceGroupManagerStatefulExternalIpBlock : ITerraformBlock
{
    /// <summary>
    /// A value that prescribes what should happen to an associated static Address resource when a VM instance is permanently deleted. The available options are NEVER and ON_PERMANENT_INSTANCE_DELETION. NEVER - detach the IP when the VM is deleted, but do not delete the address resource. ON_PERMANENT_INSTANCE_DELETION will delete the stateful address when the VM is permanently deleted from the instance group. The default is NEVER.
    /// </summary>
    [TerraformPropertyName("delete_rule")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? DeleteRule { get; set; }

    /// <summary>
    /// The network interface name
    /// </summary>
    [TerraformPropertyName("interface_name")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? InterfaceName { get; set; }

}

/// <summary>
/// Block type for stateful_internal_ip in .
/// Nesting mode: list
/// </summary>
public class GoogleComputeInstanceGroupManagerStatefulInternalIpBlock : ITerraformBlock
{
    /// <summary>
    /// A value that prescribes what should happen to an associated static Address resource when a VM instance is permanently deleted. The available options are NEVER and ON_PERMANENT_INSTANCE_DELETION. NEVER - detach the IP when the VM is deleted, but do not delete the address resource. ON_PERMANENT_INSTANCE_DELETION will delete the stateful address when the VM is permanently deleted from the instance group. The default is NEVER.
    /// </summary>
    [TerraformPropertyName("delete_rule")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? DeleteRule { get; set; }

    /// <summary>
    /// The network interface name
    /// </summary>
    [TerraformPropertyName("interface_name")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? InterfaceName { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class GoogleComputeInstanceGroupManagerTimeoutsBlock : ITerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformPropertyName("create")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformPropertyName("delete")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Delete { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformPropertyName("update")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Update { get; set; }

}

/// <summary>
/// Block type for update_policy in .
/// Nesting mode: list
/// </summary>
public class GoogleComputeInstanceGroupManagerUpdatePolicyBlock : ITerraformBlock
{
    /// <summary>
    /// Specifies a fixed number of VM instances. This must be a positive integer. Conflicts with max_surge_percent. Both cannot be 0
    /// </summary>
    [TerraformPropertyName("max_surge_fixed")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<double>> MaxSurgeFixed { get; set; } = new TerraformReferenceProperty<TerraformProperty<double>>("", "max_surge_fixed");

    /// <summary>
    /// Specifies a percentage of instances between 0 to 100%, inclusive. For example, specify 80 for 80%. Conflicts with max_surge_fixed.
    /// </summary>
    [TerraformPropertyName("max_surge_percent")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<double>>? MaxSurgePercent { get; set; }

    /// <summary>
    /// Specifies a fixed number of VM instances. This must be a positive integer.
    /// </summary>
    [TerraformPropertyName("max_unavailable_fixed")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<double>> MaxUnavailableFixed { get; set; } = new TerraformReferenceProperty<TerraformProperty<double>>("", "max_unavailable_fixed");

    /// <summary>
    /// Specifies a percentage of instances between 0 to 100%, inclusive. For example, specify 80 for 80%.
    /// </summary>
    [TerraformPropertyName("max_unavailable_percent")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<double>>? MaxUnavailablePercent { get; set; }

    /// <summary>
    /// Minimal action to be taken on an instance. You can specify either NONE to forbid any actions, REFRESH to update without stopping instances, RESTART to restart existing instances or REPLACE to delete and create new instances from the target template. If you specify a REFRESH, the Updater will attempt to perform that action only. However, if the Updater determines that the minimal action you specify is not enough to perform the update, it might perform a more disruptive action.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MinimalAction is required")]
    [TerraformPropertyName("minimal_action")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> MinimalAction { get; set; }

    /// <summary>
    /// Most disruptive action that is allowed to be taken on an instance. You can specify either NONE to forbid any actions, REFRESH to allow actions that do not need instance restart, RESTART to allow actions that can be applied without instance replacing or REPLACE to allow all possible actions. If the Updater determines that the minimal update action needed is more disruptive than most disruptive allowed action you specify it will not perform the update at all.
    /// </summary>
    [TerraformPropertyName("most_disruptive_allowed_action")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? MostDisruptiveAllowedAction { get; set; }

    /// <summary>
    /// The instance replacement method for managed instance groups. Valid values are: &amp;quot;RECREATE&amp;quot;, &amp;quot;SUBSTITUTE&amp;quot;. If SUBSTITUTE (default), the group replaces VM instances with new instances that have randomly generated names. If RECREATE, instance names are preserved.  You must also set max_unavailable_fixed or max_unavailable_percent to be greater than 0.
    /// </summary>
    [TerraformPropertyName("replacement_method")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? ReplacementMethod { get; set; }

    /// <summary>
    /// The type of update process. You can specify either PROACTIVE so that the instance group manager proactively executes actions in order to bring instances to their target versions or OPPORTUNISTIC so that no action is proactively executed but the update will be performed as part of other actions (for example, resizes or recreateInstances calls).
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    [TerraformPropertyName("type")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Type { get; set; }

}

/// <summary>
/// Block type for version in .
/// Nesting mode: list
/// </summary>
public class GoogleComputeInstanceGroupManagerVersionBlock : ITerraformBlock
{
    /// <summary>
    /// The full URL to an instance template from which all new instances of this version will be created.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "InstanceTemplate is required")]
    [TerraformPropertyName("instance_template")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> InstanceTemplate { get; set; }

    /// <summary>
    /// Version name.
    /// </summary>
    [TerraformPropertyName("name")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Name { get; set; }

}

/// <summary>
/// Manages a google_compute_instance_group_manager resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class GoogleComputeInstanceGroupManager : TerraformResource
{
    public GoogleComputeInstanceGroupManager(string name) : base("google_compute_instance_group_manager", name)
    {
    }

    /// <summary>
    /// The base instance name to use for instances in this group. The value must be a valid RFC1035 name. Supported characters are lowercase letters, numbers, and hyphens (-). Instances are named by appending a hyphen and a random four-character string to the base instance name.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "BaseInstanceName is required")]
    [TerraformPropertyName("base_instance_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> BaseInstanceName { get; set; }

    /// <summary>
    /// An optional textual description of the instance group manager.
    /// </summary>
    [TerraformPropertyName("description")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Description { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// Pagination behavior of the listManagedInstances API method for this managed instance group. Valid values are: &amp;quot;PAGELESS&amp;quot;, &amp;quot;PAGINATED&amp;quot;. If PAGELESS (default), Pagination is disabled for the group&#39;s listManagedInstances API method. maxResults and pageToken query parameters are ignored and all instances are returned in a single response. If PAGINATED, pagination is enabled, maxResults and pageToken query parameters are respected.
    /// </summary>
    [TerraformPropertyName("list_managed_instances_results")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? ListManagedInstancesResults { get; set; }

    /// <summary>
    /// The name of the instance group manager. Must be 1-63 characters long and comply with RFC1035. Supported characters include lowercase letters, numbers, and hyphens.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Name { get; set; }

    /// <summary>
    /// The ID of the project in which the resource belongs. If it is not provided, the provider project is used.
    /// </summary>
    [TerraformPropertyName("project")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Project { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "project");

    /// <summary>
    /// The full URL of all target pools to which new instances in the group are added. Updating the target pools attribute does not affect existing instances.
    /// </summary>
    [TerraformPropertyName("target_pools")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<HashSet<TerraformProperty<string>>>? TargetPools { get; set; }

    /// <summary>
    /// The target number of running instances for this managed instance group. This value should always be explicitly set unless this resource is attached to an autoscaler, in which case it should never be set. Defaults to 0.
    /// </summary>
    [TerraformPropertyName("target_size")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<double>> TargetSize { get; set; } = new TerraformReferenceProperty<TerraformProperty<double>>(ResourceAddress, "target_size");

    /// <summary>
    /// The target number of stopped instances for this managed instance group.
    /// </summary>
    [TerraformPropertyName("target_stopped_size")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<double>> TargetStoppedSize { get; set; } = new TerraformReferenceProperty<TerraformProperty<double>>(ResourceAddress, "target_stopped_size");

    /// <summary>
    /// The target number of suspended instances for this managed instance group.
    /// </summary>
    [TerraformPropertyName("target_suspended_size")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<double>> TargetSuspendedSize { get; set; } = new TerraformReferenceProperty<TerraformProperty<double>>(ResourceAddress, "target_suspended_size");

    /// <summary>
    /// Whether to wait for all instances to be created/updated before returning. Note that if this is set to true and the operation does not succeed, Terraform will continue trying until it times out.
    /// </summary>
    [TerraformPropertyName("wait_for_instances")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? WaitForInstances { get; set; }

    /// <summary>
    /// When used with wait_for_instances specifies the status to wait for. When STABLE is specified this resource will wait until the instances are stable before returning. When UPDATED is set, it will wait for the version target to be reached and any per instance configs to be effective and all instances configs to be effective as well as all instances to be stable before returning.
    /// </summary>
    [TerraformPropertyName("wait_for_instances_status")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? WaitForInstancesStatus { get; set; }

    /// <summary>
    /// The zone that instances in this group should be created in.
    /// </summary>
    [TerraformPropertyName("zone")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Zone { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "zone");

    /// <summary>
    /// Block for all_instances_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AllInstancesConfig block(s) allowed")]
    [TerraformPropertyName("all_instances_config")]
    public TerraformList<TerraformBlock<GoogleComputeInstanceGroupManagerAllInstancesConfigBlock>>? AllInstancesConfig { get; set; } = new();

    /// <summary>
    /// Block for auto_healing_policies.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AutoHealingPolicies block(s) allowed")]
    [TerraformPropertyName("auto_healing_policies")]
    public TerraformList<TerraformBlock<GoogleComputeInstanceGroupManagerAutoHealingPoliciesBlock>>? AutoHealingPolicies { get; set; } = new();

    /// <summary>
    /// Block for instance_lifecycle_policy.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 InstanceLifecyclePolicy block(s) allowed")]
    [TerraformPropertyName("instance_lifecycle_policy")]
    public TerraformList<TerraformBlock<GoogleComputeInstanceGroupManagerInstanceLifecyclePolicyBlock>>? InstanceLifecyclePolicy { get; set; } = new();

    /// <summary>
    /// Block for named_port.
    /// Nesting mode: set
    /// </summary>
    [TerraformPropertyName("named_port")]
    public TerraformSet<TerraformBlock<GoogleComputeInstanceGroupManagerNamedPortBlock>>? NamedPort { get; set; } = new();

    /// <summary>
    /// Block for resource_policies.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ResourcePolicies block(s) allowed")]
    [TerraformPropertyName("resource_policies")]
    public TerraformList<TerraformBlock<GoogleComputeInstanceGroupManagerResourcePoliciesBlock>>? ResourcePolicies { get; set; } = new();

    /// <summary>
    /// Block for standby_policy.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 StandbyPolicy block(s) allowed")]
    [TerraformPropertyName("standby_policy")]
    public TerraformList<TerraformBlock<GoogleComputeInstanceGroupManagerStandbyPolicyBlock>>? StandbyPolicy { get; set; } = new();

    /// <summary>
    /// Block for stateful_disk.
    /// Nesting mode: set
    /// </summary>
    [TerraformPropertyName("stateful_disk")]
    public TerraformSet<TerraformBlock<GoogleComputeInstanceGroupManagerStatefulDiskBlock>>? StatefulDisk { get; set; } = new();

    /// <summary>
    /// Block for stateful_external_ip.
    /// Nesting mode: list
    /// </summary>
    [TerraformPropertyName("stateful_external_ip")]
    public TerraformList<TerraformBlock<GoogleComputeInstanceGroupManagerStatefulExternalIpBlock>>? StatefulExternalIp { get; set; } = new();

    /// <summary>
    /// Block for stateful_internal_ip.
    /// Nesting mode: list
    /// </summary>
    [TerraformPropertyName("stateful_internal_ip")]
    public TerraformList<TerraformBlock<GoogleComputeInstanceGroupManagerStatefulInternalIpBlock>>? StatefulInternalIp { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<GoogleComputeInstanceGroupManagerTimeoutsBlock>? Timeouts { get; set; } = new();

    /// <summary>
    /// Block for update_policy.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 UpdatePolicy block(s) allowed")]
    [TerraformPropertyName("update_policy")]
    public TerraformList<TerraformBlock<GoogleComputeInstanceGroupManagerUpdatePolicyBlock>>? UpdatePolicy { get; set; } = new();

    /// <summary>
    /// Block for version.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Version is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Version block(s) required")]
    [TerraformPropertyName("version")]
    public TerraformList<TerraformBlock<GoogleComputeInstanceGroupManagerVersionBlock>>? Version { get; set; } = new();

    /// <summary>
    /// Creation timestamp in RFC3339 text format.
    /// </summary>
    [TerraformPropertyName("creation_timestamp")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> CreationTimestamp => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "creation_timestamp");

    /// <summary>
    /// The fingerprint of the instance group manager.
    /// </summary>
    [TerraformPropertyName("fingerprint")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Fingerprint => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "fingerprint");

    /// <summary>
    /// The full URL of the instance group created by the manager.
    /// </summary>
    [TerraformPropertyName("instance_group")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> InstanceGroup => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "instance_group");

    /// <summary>
    /// The unique identifier number for the resource. This identifier is defined by the server.
    /// </summary>
    [TerraformPropertyName("instance_group_manager_id")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<double>> InstanceGroupManagerId => new TerraformReferenceProperty<TerraformProperty<double>>(ResourceAddress, "instance_group_manager_id");

    /// <summary>
    /// The operation attribute.
    /// </summary>
    [TerraformPropertyName("operation")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Operation => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "operation");

    /// <summary>
    /// The URL of the created resource.
    /// </summary>
    [TerraformPropertyName("self_link")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> SelfLink => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "self_link");

    /// <summary>
    /// The status of this managed instance group.
    /// </summary>
    [TerraformPropertyName("status")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> Status => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "status");

}

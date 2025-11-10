using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for all_instances_config in .
/// Nesting mode: list
/// </summary>
public class GoogleComputeRegionInstanceGroupManagerAllInstancesConfigBlock : TerraformBlock
{
    /// <summary>
    /// The label key-value pairs that you want to patch onto the instance,
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? Labels
    {
        set => SetProperty("labels", value);
    }

    /// <summary>
    /// The metadata key-value pairs that you want to patch onto the instance. For more information, see Project and instance metadata,
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? Metadata
    {
        set => SetProperty("metadata", value);
    }

}

/// <summary>
/// Block type for auto_healing_policies in .
/// Nesting mode: list
/// </summary>
public class GoogleComputeRegionInstanceGroupManagerAutoHealingPoliciesBlock : TerraformBlock
{
    /// <summary>
    /// The health check resource that signals autohealing.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "HealthCheck is required")]
    public required TerraformProperty<string> HealthCheck
    {
        set => SetProperty("health_check", value);
    }

    /// <summary>
    /// The number of seconds that the managed instance group waits before it applies autohealing policies to new instances or recently recreated instances. Between 0 and 3600.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "InitialDelaySec is required")]
    public required TerraformProperty<double> InitialDelaySec
    {
        set => SetProperty("initial_delay_sec", value);
    }

}

/// <summary>
/// Block type for instance_flexibility_policy in .
/// Nesting mode: list
/// </summary>
public class GoogleComputeRegionInstanceGroupManagerInstanceFlexibilityPolicyBlock : TerraformBlock
{
}

/// <summary>
/// Block type for instance_lifecycle_policy in .
/// Nesting mode: list
/// </summary>
public class GoogleComputeRegionInstanceGroupManagerInstanceLifecyclePolicyBlock : TerraformBlock
{
    /// <summary>
    /// Default behavior for all instance or health check failures.
    /// </summary>
    public TerraformProperty<string>? DefaultActionOnFailure
    {
        set => SetProperty("default_action_on_failure", value);
    }

    /// <summary>
    /// Specifies whether to apply the group&#39;s latest configuration when repairing a VM. Valid options are: YES, NO. If YES and you updated the group&#39;s instance template or per-instance configurations after the VM was created, then these changes are applied when VM is repaired. If NO (default), then updates are applied in accordance with the group&#39;s update policy type.
    /// </summary>
    public TerraformProperty<string>? ForceUpdateOnRepair
    {
        set => SetProperty("force_update_on_repair", value);
    }

}

/// <summary>
/// Block type for named_port in .
/// Nesting mode: set
/// </summary>
public class GoogleComputeRegionInstanceGroupManagerNamedPortBlock : TerraformBlock
{
    /// <summary>
    /// The name of the port.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        set => SetProperty("name", value);
    }

    /// <summary>
    /// The port number.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Port is required")]
    public required TerraformProperty<double> Port
    {
        set => SetProperty("port", value);
    }

}

/// <summary>
/// Block type for standby_policy in .
/// Nesting mode: list
/// </summary>
public class GoogleComputeRegionInstanceGroupManagerStandbyPolicyBlock : TerraformBlock
{
    /// <summary>
    /// Specifies the number of seconds that the MIG should wait to suspend or stop a VM after that VM was created. The initial delay gives the initialization script the time to prepare your VM for a quick scale out. The value of initial delay must be between 0 and 3600 seconds. The default value is 0.
    /// </summary>
    public TerraformProperty<double>? InitialDelaySec
    {
        set => SetProperty("initial_delay_sec", value);
    }

    /// <summary>
    /// Defines how a MIG resumes or starts VMs from a standby pool when the group scales out. The default mode is &amp;quot;MANUAL&amp;quot;.
    /// </summary>
    public TerraformProperty<string>? Mode
    {
        set => SetProperty("mode", value);
    }

}

/// <summary>
/// Block type for stateful_disk in .
/// Nesting mode: set
/// </summary>
public class GoogleComputeRegionInstanceGroupManagerStatefulDiskBlock : TerraformBlock
{
    /// <summary>
    /// A value that prescribes what should happen to the stateful disk when the VM instance is deleted. The available options are NEVER and ON_PERMANENT_INSTANCE_DELETION. NEVER - detach the disk when the VM is deleted, but do not delete the disk. ON_PERMANENT_INSTANCE_DELETION will delete the stateful disk when the VM is permanently deleted from the instance group. The default is NEVER.
    /// </summary>
    public TerraformProperty<string>? DeleteRule
    {
        set => SetProperty("delete_rule", value);
    }

    /// <summary>
    /// The device name of the disk to be attached.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DeviceName is required")]
    public required TerraformProperty<string> DeviceName
    {
        set => SetProperty("device_name", value);
    }

}

/// <summary>
/// Block type for stateful_external_ip in .
/// Nesting mode: list
/// </summary>
public class GoogleComputeRegionInstanceGroupManagerStatefulExternalIpBlock : TerraformBlock
{
    /// <summary>
    /// A value that prescribes what should happen to an associated static Address resource when a VM instance is permanently deleted. The available options are NEVER and ON_PERMANENT_INSTANCE_DELETION. NEVER - detach the IP when the VM is deleted, but do not delete the address resource. ON_PERMANENT_INSTANCE_DELETION will delete the stateful address when the VM is permanently deleted from the instance group. The default is NEVER.
    /// </summary>
    public TerraformProperty<string>? DeleteRule
    {
        set => SetProperty("delete_rule", value);
    }

    /// <summary>
    /// The network interface name
    /// </summary>
    public TerraformProperty<string>? InterfaceName
    {
        set => SetProperty("interface_name", value);
    }

}

/// <summary>
/// Block type for stateful_internal_ip in .
/// Nesting mode: list
/// </summary>
public class GoogleComputeRegionInstanceGroupManagerStatefulInternalIpBlock : TerraformBlock
{
    /// <summary>
    /// A value that prescribes what should happen to an associated static Address resource when a VM instance is permanently deleted. The available options are NEVER and ON_PERMANENT_INSTANCE_DELETION. NEVER - detach the IP when the VM is deleted, but do not delete the address resource. ON_PERMANENT_INSTANCE_DELETION will delete the stateful address when the VM is permanently deleted from the instance group. The default is NEVER.
    /// </summary>
    public TerraformProperty<string>? DeleteRule
    {
        set => SetProperty("delete_rule", value);
    }

    /// <summary>
    /// The network interface name
    /// </summary>
    public TerraformProperty<string>? InterfaceName
    {
        set => SetProperty("interface_name", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class GoogleComputeRegionInstanceGroupManagerTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformProperty<string>? Create
    {
        set => SetProperty("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        set => SetProperty("delete", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformProperty<string>? Update
    {
        set => SetProperty("update", value);
    }

}

/// <summary>
/// Block type for update_policy in .
/// Nesting mode: list
/// </summary>
public class GoogleComputeRegionInstanceGroupManagerUpdatePolicyBlock : TerraformBlock
{
    /// <summary>
    /// The instance redistribution policy for regional managed instance groups. Valid values are: &amp;quot;PROACTIVE&amp;quot;, &amp;quot;NONE&amp;quot;. If PROACTIVE (default), the group attempts to maintain an even distribution of VM instances across zones in the region. If NONE, proactive redistribution is disabled.
    /// </summary>
    public TerraformProperty<string>? InstanceRedistributionType
    {
        set => SetProperty("instance_redistribution_type", value);
    }

    /// <summary>
    /// Specifies a fixed number of VM instances. This must be a positive integer. Conflicts with max_surge_percent. Both cannot be 0
    /// </summary>
    public TerraformProperty<double>? MaxSurgeFixed
    {
        set => SetProperty("max_surge_fixed", value);
    }

    /// <summary>
    /// Specifies a percentage of instances between 0 to 100%, inclusive. For example, specify 80 for 80%. Conflicts with max_surge_fixed.
    /// </summary>
    public TerraformProperty<double>? MaxSurgePercent
    {
        set => SetProperty("max_surge_percent", value);
    }

    /// <summary>
    /// Specifies a fixed number of VM instances. This must be a positive integer.
    /// </summary>
    public TerraformProperty<double>? MaxUnavailableFixed
    {
        set => SetProperty("max_unavailable_fixed", value);
    }

    /// <summary>
    /// Specifies a percentage of instances between 0 to 100%, inclusive. For example, specify 80 for 80%.
    /// </summary>
    public TerraformProperty<double>? MaxUnavailablePercent
    {
        set => SetProperty("max_unavailable_percent", value);
    }

    /// <summary>
    /// Minimal action to be taken on an instance. You can specify either NONE to forbid any actions, REFRESH to update without stopping instances, RESTART to restart existing instances or REPLACE to delete and create new instances from the target template. If you specify a REFRESH, the Updater will attempt to perform that action only. However, if the Updater determines that the minimal action you specify is not enough to perform the update, it might perform a more disruptive action.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MinimalAction is required")]
    public required TerraformProperty<string> MinimalAction
    {
        set => SetProperty("minimal_action", value);
    }

    /// <summary>
    /// Most disruptive action that is allowed to be taken on an instance. You can specify either NONE to forbid any actions, REFRESH to allow actions that do not need instance restart, RESTART to allow actions that can be applied without instance replacing or REPLACE to allow all possible actions. If the Updater determines that the minimal update action needed is more disruptive than most disruptive allowed action you specify it will not perform the update at all.
    /// </summary>
    public TerraformProperty<string>? MostDisruptiveAllowedAction
    {
        set => SetProperty("most_disruptive_allowed_action", value);
    }

    /// <summary>
    /// The instance replacement method for regional managed instance groups. Valid values are: &amp;quot;RECREATE&amp;quot;, &amp;quot;SUBSTITUTE&amp;quot;. If SUBSTITUTE (default), the group replaces VM instances with new instances that have randomly generated names. If RECREATE, instance names are preserved.  You must also set max_unavailable_fixed or max_unavailable_percent to be greater than 0.
    /// </summary>
    public TerraformProperty<string>? ReplacementMethod
    {
        set => SetProperty("replacement_method", value);
    }

    /// <summary>
    /// The type of update process. You can specify either PROACTIVE so that the instance group manager proactively executes actions in order to bring instances to their target versions or OPPORTUNISTIC so that no action is proactively executed but the update will be performed as part of other actions (for example, resizes or recreateInstances calls).
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    public required TerraformProperty<string> Type
    {
        set => SetProperty("type", value);
    }

}

/// <summary>
/// Block type for version in .
/// Nesting mode: list
/// </summary>
public class GoogleComputeRegionInstanceGroupManagerVersionBlock : TerraformBlock
{
    /// <summary>
    /// The full URL to an instance template from which all new instances of this version will be created.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "InstanceTemplate is required")]
    public required TerraformProperty<string> InstanceTemplate
    {
        set => SetProperty("instance_template", value);
    }

    /// <summary>
    /// Version name.
    /// </summary>
    public TerraformProperty<string>? Name
    {
        set => SetProperty("name", value);
    }

}

/// <summary>
/// Manages a google_compute_region_instance_group_manager resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class GoogleComputeRegionInstanceGroupManager : TerraformResource
{
    public GoogleComputeRegionInstanceGroupManager(string name) : base("google_compute_region_instance_group_manager", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("creation_timestamp");
        SetOutput("fingerprint");
        SetOutput("instance_group");
        SetOutput("instance_group_manager_id");
        SetOutput("self_link");
        SetOutput("status");
        SetOutput("base_instance_name");
        SetOutput("description");
        SetOutput("distribution_policy_target_shape");
        SetOutput("distribution_policy_zones");
        SetOutput("id");
        SetOutput("list_managed_instances_results");
        SetOutput("name");
        SetOutput("project");
        SetOutput("region");
        SetOutput("target_pools");
        SetOutput("target_size");
        SetOutput("target_stopped_size");
        SetOutput("target_suspended_size");
        SetOutput("wait_for_instances");
        SetOutput("wait_for_instances_status");
    }

    /// <summary>
    /// The base instance name to use for instances in this group. The value must be a valid RFC1035 name. Supported characters are lowercase letters, numbers, and hyphens (-). Instances are named by appending a hyphen and a random four-character string to the base instance name.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "BaseInstanceName is required")]
    public required TerraformProperty<string> BaseInstanceName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("base_instance_name");
        set => SetProperty("base_instance_name", value);
    }

    /// <summary>
    /// An optional textual description of the instance group manager.
    /// </summary>
    public TerraformProperty<string> Description
    {
        get => GetRequiredOutput<TerraformProperty<string>>("description");
        set => SetProperty("description", value);
    }

    /// <summary>
    /// The shape to which the group converges either proactively or on resize events (depending on the value set in updatePolicy.instanceRedistributionType).
    /// </summary>
    public TerraformProperty<string> DistributionPolicyTargetShape
    {
        get => GetRequiredOutput<TerraformProperty<string>>("distribution_policy_target_shape");
        set => SetProperty("distribution_policy_target_shape", value);
    }

    /// <summary>
    /// The distribution policy for this managed instance group. You can specify one or more values.
    /// </summary>
    public HashSet<TerraformProperty<string>> DistributionPolicyZones
    {
        get => GetRequiredOutput<HashSet<TerraformProperty<string>>>("distribution_policy_zones");
        set => SetProperty("distribution_policy_zones", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string> Id
    {
        get => GetRequiredOutput<TerraformProperty<string>>("id");
        set => SetProperty("id", value);
    }

    /// <summary>
    /// Pagination behavior of the listManagedInstances API method for this managed instance group. Valid values are: &amp;quot;PAGELESS&amp;quot;, &amp;quot;PAGINATED&amp;quot;. If PAGELESS (default), Pagination is disabled for the group&#39;s listManagedInstances API method. maxResults and pageToken query parameters are ignored and all instances are returned in a single response. If PAGINATED, pagination is enabled, maxResults and pageToken query parameters are respected.
    /// </summary>
    public TerraformProperty<string> ListManagedInstancesResults
    {
        get => GetRequiredOutput<TerraformProperty<string>>("list_managed_instances_results");
        set => SetProperty("list_managed_instances_results", value);
    }

    /// <summary>
    /// The name of the instance group manager. Must be 1-63 characters long and comply with RFC1035. Supported characters include lowercase letters, numbers, and hyphens.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetRequiredOutput<TerraformProperty<string>>("name");
        set => SetProperty("name", value);
    }

    /// <summary>
    /// The ID of the project in which the resource belongs. If it is not provided, the provider project is used.
    /// </summary>
    public TerraformProperty<string> Project
    {
        get => GetRequiredOutput<TerraformProperty<string>>("project");
        set => SetProperty("project", value);
    }

    /// <summary>
    /// The region where the managed instance group resides.
    /// </summary>
    public TerraformProperty<string> Region
    {
        get => GetRequiredOutput<TerraformProperty<string>>("region");
        set => SetProperty("region", value);
    }

    /// <summary>
    /// The full URL of all target pools to which new instances in the group are added. Updating the target pools attribute does not affect existing instances.
    /// </summary>
    public HashSet<TerraformProperty<string>> TargetPools
    {
        get => GetRequiredOutput<HashSet<TerraformProperty<string>>>("target_pools");
        set => SetProperty("target_pools", value);
    }

    /// <summary>
    /// The target number of running instances for this managed instance group. This value should always be explicitly set unless this resource is attached to an autoscaler, in which case it should never be set. Defaults to 0.
    /// </summary>
    public TerraformProperty<double> TargetSize
    {
        get => GetRequiredOutput<TerraformProperty<double>>("target_size");
        set => SetProperty("target_size", value);
    }

    /// <summary>
    /// The target number of stopped instances for this managed instance group.
    /// </summary>
    public TerraformProperty<double> TargetStoppedSize
    {
        get => GetRequiredOutput<TerraformProperty<double>>("target_stopped_size");
        set => SetProperty("target_stopped_size", value);
    }

    /// <summary>
    /// The target number of suspended instances for this managed instance group.
    /// </summary>
    public TerraformProperty<double> TargetSuspendedSize
    {
        get => GetRequiredOutput<TerraformProperty<double>>("target_suspended_size");
        set => SetProperty("target_suspended_size", value);
    }

    /// <summary>
    /// Whether to wait for all instances to be created/updated before returning. Note that if this is set to true and the operation does not succeed, Terraform will continue trying until it times out.
    /// </summary>
    public TerraformProperty<bool> WaitForInstances
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("wait_for_instances");
        set => SetProperty("wait_for_instances", value);
    }

    /// <summary>
    /// When used with wait_for_instances specifies the status to wait for. When STABLE is specified this resource will wait until the instances are stable before returning. When UPDATED is set, it will wait for the version target to be reached and any per instance configs to be effective and all instances configs to be effective as well as all instances to be stable before returning.
    /// </summary>
    public TerraformProperty<string> WaitForInstancesStatus
    {
        get => GetRequiredOutput<TerraformProperty<string>>("wait_for_instances_status");
        set => SetProperty("wait_for_instances_status", value);
    }

    /// <summary>
    /// Block for all_instances_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AllInstancesConfig block(s) allowed")]
    public List<GoogleComputeRegionInstanceGroupManagerAllInstancesConfigBlock>? AllInstancesConfig
    {
        set => SetProperty("all_instances_config", value);
    }

    /// <summary>
    /// Block for auto_healing_policies.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AutoHealingPolicies block(s) allowed")]
    public List<GoogleComputeRegionInstanceGroupManagerAutoHealingPoliciesBlock>? AutoHealingPolicies
    {
        set => SetProperty("auto_healing_policies", value);
    }

    /// <summary>
    /// Block for instance_flexibility_policy.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 InstanceFlexibilityPolicy block(s) allowed")]
    public List<GoogleComputeRegionInstanceGroupManagerInstanceFlexibilityPolicyBlock>? InstanceFlexibilityPolicy
    {
        set => SetProperty("instance_flexibility_policy", value);
    }

    /// <summary>
    /// Block for instance_lifecycle_policy.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 InstanceLifecyclePolicy block(s) allowed")]
    public List<GoogleComputeRegionInstanceGroupManagerInstanceLifecyclePolicyBlock>? InstanceLifecyclePolicy
    {
        set => SetProperty("instance_lifecycle_policy", value);
    }

    /// <summary>
    /// Block for named_port.
    /// Nesting mode: set
    /// </summary>
    public HashSet<GoogleComputeRegionInstanceGroupManagerNamedPortBlock>? NamedPort
    {
        set => SetProperty("named_port", value);
    }

    /// <summary>
    /// Block for standby_policy.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 StandbyPolicy block(s) allowed")]
    public List<GoogleComputeRegionInstanceGroupManagerStandbyPolicyBlock>? StandbyPolicy
    {
        set => SetProperty("standby_policy", value);
    }

    /// <summary>
    /// Block for stateful_disk.
    /// Nesting mode: set
    /// </summary>
    public HashSet<GoogleComputeRegionInstanceGroupManagerStatefulDiskBlock>? StatefulDisk
    {
        set => SetProperty("stateful_disk", value);
    }

    /// <summary>
    /// Block for stateful_external_ip.
    /// Nesting mode: list
    /// </summary>
    public List<GoogleComputeRegionInstanceGroupManagerStatefulExternalIpBlock>? StatefulExternalIp
    {
        set => SetProperty("stateful_external_ip", value);
    }

    /// <summary>
    /// Block for stateful_internal_ip.
    /// Nesting mode: list
    /// </summary>
    public List<GoogleComputeRegionInstanceGroupManagerStatefulInternalIpBlock>? StatefulInternalIp
    {
        set => SetProperty("stateful_internal_ip", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public GoogleComputeRegionInstanceGroupManagerTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

    /// <summary>
    /// Block for update_policy.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 UpdatePolicy block(s) allowed")]
    public List<GoogleComputeRegionInstanceGroupManagerUpdatePolicyBlock>? UpdatePolicy
    {
        set => SetProperty("update_policy", value);
    }

    /// <summary>
    /// Block for version.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Version is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Version block(s) required")]
    public List<GoogleComputeRegionInstanceGroupManagerVersionBlock>? Version
    {
        set => SetProperty("version", value);
    }

    /// <summary>
    /// Creation timestamp in RFC3339 text format.
    /// </summary>
    public TerraformExpression CreationTimestamp => this["creation_timestamp"];

    /// <summary>
    /// The fingerprint of the instance group manager.
    /// </summary>
    public TerraformExpression Fingerprint => this["fingerprint"];

    /// <summary>
    /// The full URL of the instance group created by the manager.
    /// </summary>
    public TerraformExpression InstanceGroup => this["instance_group"];

    /// <summary>
    /// The unique identifier number for the resource. This identifier is defined by the server.
    /// </summary>
    public TerraformExpression InstanceGroupManagerId => this["instance_group_manager_id"];

    /// <summary>
    /// The URL of the created resource.
    /// </summary>
    public TerraformExpression SelfLink => this["self_link"];

    /// <summary>
    /// The status of this managed instance group.
    /// </summary>
    public TerraformExpression Status => this["status"];

}

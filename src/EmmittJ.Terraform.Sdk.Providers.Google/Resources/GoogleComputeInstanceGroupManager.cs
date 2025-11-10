using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for all_instances_config in .
/// Nesting mode: list
/// </summary>
public class GoogleComputeInstanceGroupManagerAllInstancesConfigBlock : TerraformBlock
{
    /// <summary>
    /// The label key-value pairs that you want to patch onto the instance,
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? Labels
    {
        get => GetProperty<Dictionary<string, TerraformProperty<string>>>("labels");
        set => WithProperty("labels", value);
    }

    /// <summary>
    /// The metadata key-value pairs that you want to patch onto the instance. For more information, see Project and instance metadata,
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? Metadata
    {
        get => GetProperty<Dictionary<string, TerraformProperty<string>>>("metadata");
        set => WithProperty("metadata", value);
    }

}

/// <summary>
/// Block type for auto_healing_policies in .
/// Nesting mode: list
/// </summary>
public class GoogleComputeInstanceGroupManagerAutoHealingPoliciesBlock : TerraformBlock
{
    /// <summary>
    /// The health check resource that signals autohealing.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "HealthCheck is required")]
    public required TerraformProperty<string> HealthCheck
    {
        get => GetProperty<TerraformProperty<string>>("health_check");
        set => WithProperty("health_check", value);
    }

    /// <summary>
    /// The number of seconds that the managed instance group waits before it applies autohealing policies to new instances or recently recreated instances. Between 0 and 3600.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "InitialDelaySec is required")]
    public required TerraformProperty<double> InitialDelaySec
    {
        get => GetProperty<TerraformProperty<double>>("initial_delay_sec");
        set => WithProperty("initial_delay_sec", value);
    }

}

/// <summary>
/// Block type for instance_lifecycle_policy in .
/// Nesting mode: list
/// </summary>
public class GoogleComputeInstanceGroupManagerInstanceLifecyclePolicyBlock : TerraformBlock
{
    /// <summary>
    /// Default behavior for all instance or health check failures.
    /// </summary>
    public TerraformProperty<string>? DefaultActionOnFailure
    {
        get => GetProperty<TerraformProperty<string>>("default_action_on_failure");
        set => WithProperty("default_action_on_failure", value);
    }

    /// <summary>
    /// Specifies whether to apply the group&#39;s latest configuration when repairing a VM. Valid options are: YES, NO. If YES and you updated the group&#39;s instance template or per-instance configurations after the VM was created, then these changes are applied when VM is repaired. If NO (default), then updates are applied in accordance with the group&#39;s update policy type.
    /// </summary>
    public TerraformProperty<string>? ForceUpdateOnRepair
    {
        get => GetProperty<TerraformProperty<string>>("force_update_on_repair");
        set => WithProperty("force_update_on_repair", value);
    }

}

/// <summary>
/// Block type for named_port in .
/// Nesting mode: set
/// </summary>
public class GoogleComputeInstanceGroupManagerNamedPortBlock : TerraformBlock
{
    /// <summary>
    /// The name of the port.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetProperty<TerraformProperty<string>>("name");
        set => WithProperty("name", value);
    }

    /// <summary>
    /// The port number.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Port is required")]
    public required TerraformProperty<double> Port
    {
        get => GetProperty<TerraformProperty<double>>("port");
        set => WithProperty("port", value);
    }

}

/// <summary>
/// Block type for resource_policies in .
/// Nesting mode: list
/// </summary>
public class GoogleComputeInstanceGroupManagerResourcePoliciesBlock : TerraformBlock
{
    /// <summary>
    /// The URL of the workload policy that is specified for this managed instance group. It can be a full or partial URL.
    /// </summary>
    public TerraformProperty<string>? WorkloadPolicy
    {
        get => GetProperty<TerraformProperty<string>>("workload_policy");
        set => WithProperty("workload_policy", value);
    }

}

/// <summary>
/// Block type for standby_policy in .
/// Nesting mode: list
/// </summary>
public class GoogleComputeInstanceGroupManagerStandbyPolicyBlock : TerraformBlock
{
    /// <summary>
    /// Specifies the number of seconds that the MIG should wait to suspend or stop a VM after that VM was created. The initial delay gives the initialization script the time to prepare your VM for a quick scale out. The value of initial delay must be between 0 and 3600 seconds. The default value is 0.
    /// </summary>
    public TerraformProperty<double>? InitialDelaySec
    {
        get => GetProperty<TerraformProperty<double>>("initial_delay_sec");
        set => WithProperty("initial_delay_sec", value);
    }

    /// <summary>
    /// Defines how a MIG resumes or starts VMs from a standby pool when the group scales out. The default mode is &amp;quot;MANUAL&amp;quot;.
    /// </summary>
    public TerraformProperty<string>? Mode
    {
        get => GetProperty<TerraformProperty<string>>("mode");
        set => WithProperty("mode", value);
    }

}

/// <summary>
/// Block type for stateful_disk in .
/// Nesting mode: set
/// </summary>
public class GoogleComputeInstanceGroupManagerStatefulDiskBlock : TerraformBlock
{
    /// <summary>
    /// A value that prescribes what should happen to the stateful disk when the VM instance is deleted. The available options are NEVER and ON_PERMANENT_INSTANCE_DELETION. NEVER - detach the disk when the VM is deleted, but do not delete the disk. ON_PERMANENT_INSTANCE_DELETION will delete the stateful disk when the VM is permanently deleted from the instance group. The default is NEVER.
    /// </summary>
    public TerraformProperty<string>? DeleteRule
    {
        get => GetProperty<TerraformProperty<string>>("delete_rule");
        set => WithProperty("delete_rule", value);
    }

    /// <summary>
    /// The device name of the disk to be attached.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DeviceName is required")]
    public required TerraformProperty<string> DeviceName
    {
        get => GetProperty<TerraformProperty<string>>("device_name");
        set => WithProperty("device_name", value);
    }

}

/// <summary>
/// Block type for stateful_external_ip in .
/// Nesting mode: list
/// </summary>
public class GoogleComputeInstanceGroupManagerStatefulExternalIpBlock : TerraformBlock
{
    /// <summary>
    /// A value that prescribes what should happen to an associated static Address resource when a VM instance is permanently deleted. The available options are NEVER and ON_PERMANENT_INSTANCE_DELETION. NEVER - detach the IP when the VM is deleted, but do not delete the address resource. ON_PERMANENT_INSTANCE_DELETION will delete the stateful address when the VM is permanently deleted from the instance group. The default is NEVER.
    /// </summary>
    public TerraformProperty<string>? DeleteRule
    {
        get => GetProperty<TerraformProperty<string>>("delete_rule");
        set => WithProperty("delete_rule", value);
    }

    /// <summary>
    /// The network interface name
    /// </summary>
    public TerraformProperty<string>? InterfaceName
    {
        get => GetProperty<TerraformProperty<string>>("interface_name");
        set => WithProperty("interface_name", value);
    }

}

/// <summary>
/// Block type for stateful_internal_ip in .
/// Nesting mode: list
/// </summary>
public class GoogleComputeInstanceGroupManagerStatefulInternalIpBlock : TerraformBlock
{
    /// <summary>
    /// A value that prescribes what should happen to an associated static Address resource when a VM instance is permanently deleted. The available options are NEVER and ON_PERMANENT_INSTANCE_DELETION. NEVER - detach the IP when the VM is deleted, but do not delete the address resource. ON_PERMANENT_INSTANCE_DELETION will delete the stateful address when the VM is permanently deleted from the instance group. The default is NEVER.
    /// </summary>
    public TerraformProperty<string>? DeleteRule
    {
        get => GetProperty<TerraformProperty<string>>("delete_rule");
        set => WithProperty("delete_rule", value);
    }

    /// <summary>
    /// The network interface name
    /// </summary>
    public TerraformProperty<string>? InterfaceName
    {
        get => GetProperty<TerraformProperty<string>>("interface_name");
        set => WithProperty("interface_name", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class GoogleComputeInstanceGroupManagerTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformProperty<string>? Create
    {
        get => GetProperty<TerraformProperty<string>>("create");
        set => WithProperty("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        get => GetProperty<TerraformProperty<string>>("delete");
        set => WithProperty("delete", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformProperty<string>? Update
    {
        get => GetProperty<TerraformProperty<string>>("update");
        set => WithProperty("update", value);
    }

}

/// <summary>
/// Block type for update_policy in .
/// Nesting mode: list
/// </summary>
public class GoogleComputeInstanceGroupManagerUpdatePolicyBlock : TerraformBlock
{
    /// <summary>
    /// Specifies a fixed number of VM instances. This must be a positive integer. Conflicts with max_surge_percent. Both cannot be 0
    /// </summary>
    public TerraformProperty<double>? MaxSurgeFixed
    {
        get => GetProperty<TerraformProperty<double>>("max_surge_fixed");
        set => WithProperty("max_surge_fixed", value);
    }

    /// <summary>
    /// Specifies a percentage of instances between 0 to 100%, inclusive. For example, specify 80 for 80%. Conflicts with max_surge_fixed.
    /// </summary>
    public TerraformProperty<double>? MaxSurgePercent
    {
        get => GetProperty<TerraformProperty<double>>("max_surge_percent");
        set => WithProperty("max_surge_percent", value);
    }

    /// <summary>
    /// Specifies a fixed number of VM instances. This must be a positive integer.
    /// </summary>
    public TerraformProperty<double>? MaxUnavailableFixed
    {
        get => GetProperty<TerraformProperty<double>>("max_unavailable_fixed");
        set => WithProperty("max_unavailable_fixed", value);
    }

    /// <summary>
    /// Specifies a percentage of instances between 0 to 100%, inclusive. For example, specify 80 for 80%.
    /// </summary>
    public TerraformProperty<double>? MaxUnavailablePercent
    {
        get => GetProperty<TerraformProperty<double>>("max_unavailable_percent");
        set => WithProperty("max_unavailable_percent", value);
    }

    /// <summary>
    /// Minimal action to be taken on an instance. You can specify either NONE to forbid any actions, REFRESH to update without stopping instances, RESTART to restart existing instances or REPLACE to delete and create new instances from the target template. If you specify a REFRESH, the Updater will attempt to perform that action only. However, if the Updater determines that the minimal action you specify is not enough to perform the update, it might perform a more disruptive action.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MinimalAction is required")]
    public required TerraformProperty<string> MinimalAction
    {
        get => GetProperty<TerraformProperty<string>>("minimal_action");
        set => WithProperty("minimal_action", value);
    }

    /// <summary>
    /// Most disruptive action that is allowed to be taken on an instance. You can specify either NONE to forbid any actions, REFRESH to allow actions that do not need instance restart, RESTART to allow actions that can be applied without instance replacing or REPLACE to allow all possible actions. If the Updater determines that the minimal update action needed is more disruptive than most disruptive allowed action you specify it will not perform the update at all.
    /// </summary>
    public TerraformProperty<string>? MostDisruptiveAllowedAction
    {
        get => GetProperty<TerraformProperty<string>>("most_disruptive_allowed_action");
        set => WithProperty("most_disruptive_allowed_action", value);
    }

    /// <summary>
    /// The instance replacement method for managed instance groups. Valid values are: &amp;quot;RECREATE&amp;quot;, &amp;quot;SUBSTITUTE&amp;quot;. If SUBSTITUTE (default), the group replaces VM instances with new instances that have randomly generated names. If RECREATE, instance names are preserved.  You must also set max_unavailable_fixed or max_unavailable_percent to be greater than 0.
    /// </summary>
    public TerraformProperty<string>? ReplacementMethod
    {
        get => GetProperty<TerraformProperty<string>>("replacement_method");
        set => WithProperty("replacement_method", value);
    }

    /// <summary>
    /// The type of update process. You can specify either PROACTIVE so that the instance group manager proactively executes actions in order to bring instances to their target versions or OPPORTUNISTIC so that no action is proactively executed but the update will be performed as part of other actions (for example, resizes or recreateInstances calls).
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    public required TerraformProperty<string> Type
    {
        get => GetProperty<TerraformProperty<string>>("type");
        set => WithProperty("type", value);
    }

}

/// <summary>
/// Block type for version in .
/// Nesting mode: list
/// </summary>
public class GoogleComputeInstanceGroupManagerVersionBlock : TerraformBlock
{
    /// <summary>
    /// The full URL to an instance template from which all new instances of this version will be created.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "InstanceTemplate is required")]
    public required TerraformProperty<string> InstanceTemplate
    {
        get => GetProperty<TerraformProperty<string>>("instance_template");
        set => WithProperty("instance_template", value);
    }

    /// <summary>
    /// Version name.
    /// </summary>
    public TerraformProperty<string>? Name
    {
        get => GetProperty<TerraformProperty<string>>("name");
        set => WithProperty("name", value);
    }

}

/// <summary>
/// Manages a google_compute_instance_group_manager resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class GoogleComputeInstanceGroupManager : TerraformResource
{
    public GoogleComputeInstanceGroupManager(string name) : base("google_compute_instance_group_manager", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("creation_timestamp");
        this.DeclareOutput("fingerprint");
        this.DeclareOutput("instance_group");
        this.DeclareOutput("instance_group_manager_id");
        this.DeclareOutput("operation");
        this.DeclareOutput("self_link");
        this.DeclareOutput("status");
    }

    /// <summary>
    /// The base instance name to use for instances in this group. The value must be a valid RFC1035 name. Supported characters are lowercase letters, numbers, and hyphens (-). Instances are named by appending a hyphen and a random four-character string to the base instance name.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "BaseInstanceName is required")]
    public required TerraformProperty<string> BaseInstanceName
    {
        get => GetProperty<TerraformProperty<string>>("base_instance_name");
        set => this.WithProperty("base_instance_name", value);
    }

    /// <summary>
    /// An optional textual description of the instance group manager.
    /// </summary>
    public TerraformProperty<string>? Description
    {
        get => GetProperty<TerraformProperty<string>>("description");
        set => this.WithProperty("description", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string>? Id
    {
        get => GetProperty<TerraformProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// Pagination behavior of the listManagedInstances API method for this managed instance group. Valid values are: &amp;quot;PAGELESS&amp;quot;, &amp;quot;PAGINATED&amp;quot;. If PAGELESS (default), Pagination is disabled for the group&#39;s listManagedInstances API method. maxResults and pageToken query parameters are ignored and all instances are returned in a single response. If PAGINATED, pagination is enabled, maxResults and pageToken query parameters are respected.
    /// </summary>
    public TerraformProperty<string>? ListManagedInstancesResults
    {
        get => GetProperty<TerraformProperty<string>>("list_managed_instances_results");
        set => this.WithProperty("list_managed_instances_results", value);
    }

    /// <summary>
    /// The name of the instance group manager. Must be 1-63 characters long and comply with RFC1035. Supported characters include lowercase letters, numbers, and hyphens.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// The ID of the project in which the resource belongs. If it is not provided, the provider project is used.
    /// </summary>
    public TerraformProperty<string>? Project
    {
        get => GetProperty<TerraformProperty<string>>("project");
        set => this.WithProperty("project", value);
    }

    /// <summary>
    /// The full URL of all target pools to which new instances in the group are added. Updating the target pools attribute does not affect existing instances.
    /// </summary>
    public HashSet<TerraformProperty<string>>? TargetPools
    {
        get => GetProperty<HashSet<TerraformProperty<string>>>("target_pools");
        set => this.WithProperty("target_pools", value);
    }

    /// <summary>
    /// The target number of running instances for this managed instance group. This value should always be explicitly set unless this resource is attached to an autoscaler, in which case it should never be set. Defaults to 0.
    /// </summary>
    public TerraformProperty<double>? TargetSize
    {
        get => GetProperty<TerraformProperty<double>>("target_size");
        set => this.WithProperty("target_size", value);
    }

    /// <summary>
    /// The target number of stopped instances for this managed instance group.
    /// </summary>
    public TerraformProperty<double>? TargetStoppedSize
    {
        get => GetProperty<TerraformProperty<double>>("target_stopped_size");
        set => this.WithProperty("target_stopped_size", value);
    }

    /// <summary>
    /// The target number of suspended instances for this managed instance group.
    /// </summary>
    public TerraformProperty<double>? TargetSuspendedSize
    {
        get => GetProperty<TerraformProperty<double>>("target_suspended_size");
        set => this.WithProperty("target_suspended_size", value);
    }

    /// <summary>
    /// Whether to wait for all instances to be created/updated before returning. Note that if this is set to true and the operation does not succeed, Terraform will continue trying until it times out.
    /// </summary>
    public TerraformProperty<bool>? WaitForInstances
    {
        get => GetProperty<TerraformProperty<bool>>("wait_for_instances");
        set => this.WithProperty("wait_for_instances", value);
    }

    /// <summary>
    /// When used with wait_for_instances specifies the status to wait for. When STABLE is specified this resource will wait until the instances are stable before returning. When UPDATED is set, it will wait for the version target to be reached and any per instance configs to be effective and all instances configs to be effective as well as all instances to be stable before returning.
    /// </summary>
    public TerraformProperty<string>? WaitForInstancesStatus
    {
        get => GetProperty<TerraformProperty<string>>("wait_for_instances_status");
        set => this.WithProperty("wait_for_instances_status", value);
    }

    /// <summary>
    /// The zone that instances in this group should be created in.
    /// </summary>
    public TerraformProperty<string>? Zone
    {
        get => GetProperty<TerraformProperty<string>>("zone");
        set => this.WithProperty("zone", value);
    }

    /// <summary>
    /// Block for all_instances_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AllInstancesConfig block(s) allowed")]
    public List<GoogleComputeInstanceGroupManagerAllInstancesConfigBlock>? AllInstancesConfig
    {
        get => GetProperty<List<GoogleComputeInstanceGroupManagerAllInstancesConfigBlock>>("all_instances_config");
        set => this.WithProperty("all_instances_config", value);
    }

    /// <summary>
    /// Block for auto_healing_policies.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AutoHealingPolicies block(s) allowed")]
    public List<GoogleComputeInstanceGroupManagerAutoHealingPoliciesBlock>? AutoHealingPolicies
    {
        get => GetProperty<List<GoogleComputeInstanceGroupManagerAutoHealingPoliciesBlock>>("auto_healing_policies");
        set => this.WithProperty("auto_healing_policies", value);
    }

    /// <summary>
    /// Block for instance_lifecycle_policy.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 InstanceLifecyclePolicy block(s) allowed")]
    public List<GoogleComputeInstanceGroupManagerInstanceLifecyclePolicyBlock>? InstanceLifecyclePolicy
    {
        get => GetProperty<List<GoogleComputeInstanceGroupManagerInstanceLifecyclePolicyBlock>>("instance_lifecycle_policy");
        set => this.WithProperty("instance_lifecycle_policy", value);
    }

    /// <summary>
    /// Block for named_port.
    /// Nesting mode: set
    /// </summary>
    public HashSet<GoogleComputeInstanceGroupManagerNamedPortBlock>? NamedPort
    {
        get => GetProperty<HashSet<GoogleComputeInstanceGroupManagerNamedPortBlock>>("named_port");
        set => this.WithProperty("named_port", value);
    }

    /// <summary>
    /// Block for resource_policies.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ResourcePolicies block(s) allowed")]
    public List<GoogleComputeInstanceGroupManagerResourcePoliciesBlock>? ResourcePolicies
    {
        get => GetProperty<List<GoogleComputeInstanceGroupManagerResourcePoliciesBlock>>("resource_policies");
        set => this.WithProperty("resource_policies", value);
    }

    /// <summary>
    /// Block for standby_policy.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 StandbyPolicy block(s) allowed")]
    public List<GoogleComputeInstanceGroupManagerStandbyPolicyBlock>? StandbyPolicy
    {
        get => GetProperty<List<GoogleComputeInstanceGroupManagerStandbyPolicyBlock>>("standby_policy");
        set => this.WithProperty("standby_policy", value);
    }

    /// <summary>
    /// Block for stateful_disk.
    /// Nesting mode: set
    /// </summary>
    public HashSet<GoogleComputeInstanceGroupManagerStatefulDiskBlock>? StatefulDisk
    {
        get => GetProperty<HashSet<GoogleComputeInstanceGroupManagerStatefulDiskBlock>>("stateful_disk");
        set => this.WithProperty("stateful_disk", value);
    }

    /// <summary>
    /// Block for stateful_external_ip.
    /// Nesting mode: list
    /// </summary>
    public List<GoogleComputeInstanceGroupManagerStatefulExternalIpBlock>? StatefulExternalIp
    {
        get => GetProperty<List<GoogleComputeInstanceGroupManagerStatefulExternalIpBlock>>("stateful_external_ip");
        set => this.WithProperty("stateful_external_ip", value);
    }

    /// <summary>
    /// Block for stateful_internal_ip.
    /// Nesting mode: list
    /// </summary>
    public List<GoogleComputeInstanceGroupManagerStatefulInternalIpBlock>? StatefulInternalIp
    {
        get => GetProperty<List<GoogleComputeInstanceGroupManagerStatefulInternalIpBlock>>("stateful_internal_ip");
        set => this.WithProperty("stateful_internal_ip", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public GoogleComputeInstanceGroupManagerTimeoutsBlock? Timeouts
    {
        get => GetProperty<GoogleComputeInstanceGroupManagerTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
    }

    /// <summary>
    /// Block for update_policy.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 UpdatePolicy block(s) allowed")]
    public List<GoogleComputeInstanceGroupManagerUpdatePolicyBlock>? UpdatePolicy
    {
        get => GetProperty<List<GoogleComputeInstanceGroupManagerUpdatePolicyBlock>>("update_policy");
        set => this.WithProperty("update_policy", value);
    }

    /// <summary>
    /// Block for version.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Version block(s) required")]
    public List<GoogleComputeInstanceGroupManagerVersionBlock>? Version
    {
        get => GetProperty<List<GoogleComputeInstanceGroupManagerVersionBlock>>("version");
        set => this.WithProperty("version", value);
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
    /// The operation attribute.
    /// </summary>
    public TerraformExpression Operation => this["operation"];

    /// <summary>
    /// The URL of the created resource.
    /// </summary>
    public TerraformExpression SelfLink => this["self_link"];

    /// <summary>
    /// The status of this managed instance group.
    /// </summary>
    public TerraformExpression Status => this["status"];

}

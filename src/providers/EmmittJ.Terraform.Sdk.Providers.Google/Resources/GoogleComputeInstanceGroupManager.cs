using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for all_instances_config in GoogleComputeInstanceGroupManager.
/// Nesting mode: list
/// </summary>
public class GoogleComputeInstanceGroupManagerAllInstancesConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "all_instances_config";

    /// <summary>
    /// The label key-value pairs that you want to patch onto the instance,
    /// </summary>
    public TerraformMap<string>? Labels
    {
        get => GetArgument<TerraformMap<string>>("labels");
        set => SetArgument("labels", value);
    }

    /// <summary>
    /// The metadata key-value pairs that you want to patch onto the instance. For more information, see Project and instance metadata,
    /// </summary>
    public TerraformMap<string>? Metadata
    {
        get => GetArgument<TerraformMap<string>>("metadata");
        set => SetArgument("metadata", value);
    }

}


/// <summary>
/// Block type for auto_healing_policies in GoogleComputeInstanceGroupManager.
/// Nesting mode: list
/// </summary>
public class GoogleComputeInstanceGroupManagerAutoHealingPoliciesBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "auto_healing_policies";

    /// <summary>
    /// The health check resource that signals autohealing.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "HealthCheck is required")]
    public required TerraformValue<string> HealthCheck
    {
        get => GetRequiredArgument<TerraformValue<string>>("health_check");
        set => SetArgument("health_check", value);
    }

    /// <summary>
    /// The number of seconds that the managed instance group waits before it applies autohealing policies to new instances or recently recreated instances. Between 0 and 3600.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "InitialDelaySec is required")]
    public required TerraformValue<double> InitialDelaySec
    {
        get => GetRequiredArgument<TerraformValue<double>>("initial_delay_sec");
        set => SetArgument("initial_delay_sec", value);
    }

}


/// <summary>
/// Block type for instance_lifecycle_policy in GoogleComputeInstanceGroupManager.
/// Nesting mode: list
/// </summary>
public class GoogleComputeInstanceGroupManagerInstanceLifecyclePolicyBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "instance_lifecycle_policy";

    /// <summary>
    /// Default behavior for all instance or health check failures.
    /// </summary>
    public TerraformValue<string>? DefaultActionOnFailure
    {
        get => GetArgument<TerraformValue<string>>("default_action_on_failure");
        set => SetArgument("default_action_on_failure", value);
    }

    /// <summary>
    /// Specifies whether to apply the group&#39;s latest configuration when repairing a VM. Valid options are: YES, NO. If YES and you updated the group&#39;s instance template or per-instance configurations after the VM was created, then these changes are applied when VM is repaired. If NO (default), then updates are applied in accordance with the group&#39;s update policy type.
    /// </summary>
    public TerraformValue<string>? ForceUpdateOnRepair
    {
        get => GetArgument<TerraformValue<string>>("force_update_on_repair");
        set => SetArgument("force_update_on_repair", value);
    }

}


/// <summary>
/// Block type for named_port in GoogleComputeInstanceGroupManager.
/// Nesting mode: set
/// </summary>
public class GoogleComputeInstanceGroupManagerNamedPortBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "named_port";

    /// <summary>
    /// The name of the port.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetRequiredArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The port number.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Port is required")]
    public required TerraformValue<double> Port
    {
        get => GetRequiredArgument<TerraformValue<double>>("port");
        set => SetArgument("port", value);
    }

}


/// <summary>
/// Block type for resource_policies in GoogleComputeInstanceGroupManager.
/// Nesting mode: list
/// </summary>
public class GoogleComputeInstanceGroupManagerResourcePoliciesBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "resource_policies";

    /// <summary>
    /// The URL of the workload policy that is specified for this managed instance group. It can be a full or partial URL.
    /// </summary>
    public TerraformValue<string>? WorkloadPolicy
    {
        get => GetArgument<TerraformValue<string>>("workload_policy");
        set => SetArgument("workload_policy", value);
    }

}


/// <summary>
/// Block type for standby_policy in GoogleComputeInstanceGroupManager.
/// Nesting mode: list
/// </summary>
public class GoogleComputeInstanceGroupManagerStandbyPolicyBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "standby_policy";

    /// <summary>
    /// Specifies the number of seconds that the MIG should wait to suspend or stop a VM after that VM was created. The initial delay gives the initialization script the time to prepare your VM for a quick scale out. The value of initial delay must be between 0 and 3600 seconds. The default value is 0.
    /// </summary>
    public TerraformValue<double> InitialDelaySec
    {
        get => GetArgument<TerraformValue<double>>("initial_delay_sec") ?? CreateReference("initial_delay_sec");
        set => SetArgument("initial_delay_sec", value);
    }

    /// <summary>
    /// Defines how a MIG resumes or starts VMs from a standby pool when the group scales out. The default mode is &amp;quot;MANUAL&amp;quot;.
    /// </summary>
    public TerraformValue<string> Mode
    {
        get => GetArgument<TerraformValue<string>>("mode") ?? CreateReference("mode");
        set => SetArgument("mode", value);
    }

}


/// <summary>
/// Block type for stateful_disk in GoogleComputeInstanceGroupManager.
/// Nesting mode: set
/// </summary>
public class GoogleComputeInstanceGroupManagerStatefulDiskBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "stateful_disk";

    /// <summary>
    /// A value that prescribes what should happen to the stateful disk when the VM instance is deleted. The available options are NEVER and ON_PERMANENT_INSTANCE_DELETION. NEVER - detach the disk when the VM is deleted, but do not delete the disk. ON_PERMANENT_INSTANCE_DELETION will delete the stateful disk when the VM is permanently deleted from the instance group. The default is NEVER.
    /// </summary>
    public TerraformValue<string>? DeleteRule
    {
        get => GetArgument<TerraformValue<string>>("delete_rule");
        set => SetArgument("delete_rule", value);
    }

    /// <summary>
    /// The device name of the disk to be attached.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DeviceName is required")]
    public required TerraformValue<string> DeviceName
    {
        get => GetRequiredArgument<TerraformValue<string>>("device_name");
        set => SetArgument("device_name", value);
    }

}


/// <summary>
/// Block type for stateful_external_ip in GoogleComputeInstanceGroupManager.
/// Nesting mode: list
/// </summary>
public class GoogleComputeInstanceGroupManagerStatefulExternalIpBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "stateful_external_ip";

    /// <summary>
    /// A value that prescribes what should happen to an associated static Address resource when a VM instance is permanently deleted. The available options are NEVER and ON_PERMANENT_INSTANCE_DELETION. NEVER - detach the IP when the VM is deleted, but do not delete the address resource. ON_PERMANENT_INSTANCE_DELETION will delete the stateful address when the VM is permanently deleted from the instance group. The default is NEVER.
    /// </summary>
    public TerraformValue<string>? DeleteRule
    {
        get => GetArgument<TerraformValue<string>>("delete_rule");
        set => SetArgument("delete_rule", value);
    }

    /// <summary>
    /// The network interface name
    /// </summary>
    public TerraformValue<string>? InterfaceName
    {
        get => GetArgument<TerraformValue<string>>("interface_name");
        set => SetArgument("interface_name", value);
    }

}


/// <summary>
/// Block type for stateful_internal_ip in GoogleComputeInstanceGroupManager.
/// Nesting mode: list
/// </summary>
public class GoogleComputeInstanceGroupManagerStatefulInternalIpBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "stateful_internal_ip";

    /// <summary>
    /// A value that prescribes what should happen to an associated static Address resource when a VM instance is permanently deleted. The available options are NEVER and ON_PERMANENT_INSTANCE_DELETION. NEVER - detach the IP when the VM is deleted, but do not delete the address resource. ON_PERMANENT_INSTANCE_DELETION will delete the stateful address when the VM is permanently deleted from the instance group. The default is NEVER.
    /// </summary>
    public TerraformValue<string>? DeleteRule
    {
        get => GetArgument<TerraformValue<string>>("delete_rule");
        set => SetArgument("delete_rule", value);
    }

    /// <summary>
    /// The network interface name
    /// </summary>
    public TerraformValue<string>? InterfaceName
    {
        get => GetArgument<TerraformValue<string>>("interface_name");
        set => SetArgument("interface_name", value);
    }

}


/// <summary>
/// Block type for timeouts in GoogleComputeInstanceGroupManager.
/// Nesting mode: single
/// </summary>
public class GoogleComputeInstanceGroupManagerTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "timeouts";

    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformValue<string>? Create
    {
        get => GetArgument<TerraformValue<string>>("create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformValue<string>? Delete
    {
        get => GetArgument<TerraformValue<string>>("delete");
        set => SetArgument("delete", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformValue<string>? Update
    {
        get => GetArgument<TerraformValue<string>>("update");
        set => SetArgument("update", value);
    }

}


/// <summary>
/// Block type for update_policy in GoogleComputeInstanceGroupManager.
/// Nesting mode: list
/// </summary>
public class GoogleComputeInstanceGroupManagerUpdatePolicyBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "update_policy";

    /// <summary>
    /// Specifies a fixed number of VM instances. This must be a positive integer. Conflicts with max_surge_percent. Both cannot be 0
    /// </summary>
    public TerraformValue<double> MaxSurgeFixed
    {
        get => GetArgument<TerraformValue<double>>("max_surge_fixed") ?? CreateReference("max_surge_fixed");
        set => SetArgument("max_surge_fixed", value);
    }

    /// <summary>
    /// Specifies a percentage of instances between 0 to 100%, inclusive. For example, specify 80 for 80%. Conflicts with max_surge_fixed.
    /// </summary>
    public TerraformValue<double>? MaxSurgePercent
    {
        get => GetArgument<TerraformValue<double>>("max_surge_percent");
        set => SetArgument("max_surge_percent", value);
    }

    /// <summary>
    /// Specifies a fixed number of VM instances. This must be a positive integer.
    /// </summary>
    public TerraformValue<double> MaxUnavailableFixed
    {
        get => GetArgument<TerraformValue<double>>("max_unavailable_fixed") ?? CreateReference("max_unavailable_fixed");
        set => SetArgument("max_unavailable_fixed", value);
    }

    /// <summary>
    /// Specifies a percentage of instances between 0 to 100%, inclusive. For example, specify 80 for 80%.
    /// </summary>
    public TerraformValue<double>? MaxUnavailablePercent
    {
        get => GetArgument<TerraformValue<double>>("max_unavailable_percent");
        set => SetArgument("max_unavailable_percent", value);
    }

    /// <summary>
    /// Minimal action to be taken on an instance. You can specify either NONE to forbid any actions, REFRESH to update without stopping instances, RESTART to restart existing instances or REPLACE to delete and create new instances from the target template. If you specify a REFRESH, the Updater will attempt to perform that action only. However, if the Updater determines that the minimal action you specify is not enough to perform the update, it might perform a more disruptive action.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MinimalAction is required")]
    public required TerraformValue<string> MinimalAction
    {
        get => GetRequiredArgument<TerraformValue<string>>("minimal_action");
        set => SetArgument("minimal_action", value);
    }

    /// <summary>
    /// Most disruptive action that is allowed to be taken on an instance. You can specify either NONE to forbid any actions, REFRESH to allow actions that do not need instance restart, RESTART to allow actions that can be applied without instance replacing or REPLACE to allow all possible actions. If the Updater determines that the minimal update action needed is more disruptive than most disruptive allowed action you specify it will not perform the update at all.
    /// </summary>
    public TerraformValue<string>? MostDisruptiveAllowedAction
    {
        get => GetArgument<TerraformValue<string>>("most_disruptive_allowed_action");
        set => SetArgument("most_disruptive_allowed_action", value);
    }

    /// <summary>
    /// The instance replacement method for managed instance groups. Valid values are: &amp;quot;RECREATE&amp;quot;, &amp;quot;SUBSTITUTE&amp;quot;. If SUBSTITUTE (default), the group replaces VM instances with new instances that have randomly generated names. If RECREATE, instance names are preserved.  You must also set max_unavailable_fixed or max_unavailable_percent to be greater than 0.
    /// </summary>
    public TerraformValue<string>? ReplacementMethod
    {
        get => GetArgument<TerraformValue<string>>("replacement_method");
        set => SetArgument("replacement_method", value);
    }

    /// <summary>
    /// The type of update process. You can specify either PROACTIVE so that the instance group manager proactively executes actions in order to bring instances to their target versions or OPPORTUNISTIC so that no action is proactively executed but the update will be performed as part of other actions (for example, resizes or recreateInstances calls).
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    public required TerraformValue<string> Type
    {
        get => GetRequiredArgument<TerraformValue<string>>("type");
        set => SetArgument("type", value);
    }

}


/// <summary>
/// Block type for version in GoogleComputeInstanceGroupManager.
/// Nesting mode: list
/// </summary>
public class GoogleComputeInstanceGroupManagerVersionBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "version";

    /// <summary>
    /// The full URL to an instance template from which all new instances of this version will be created.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "InstanceTemplate is required")]
    public required TerraformValue<string> InstanceTemplate
    {
        get => GetRequiredArgument<TerraformValue<string>>("instance_template");
        set => SetArgument("instance_template", value);
    }

    /// <summary>
    /// Version name.
    /// </summary>
    public TerraformValue<string>? Name
    {
        get => GetArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// TargetSize block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 TargetSize block(s) allowed")]
    public TerraformList<GoogleComputeInstanceGroupManagerVersionBlockTargetSizeBlock>? TargetSize
    {
        get => GetArgument<TerraformList<GoogleComputeInstanceGroupManagerVersionBlockTargetSizeBlock>>("target_size");
        set => SetArgument("target_size", value);
    }

}

/// <summary>
/// Block type for target_size in GoogleComputeInstanceGroupManagerVersionBlock.
/// Nesting mode: list
/// </summary>
public class GoogleComputeInstanceGroupManagerVersionBlockTargetSizeBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "target_size";

    /// <summary>
    /// The number of instances which are managed for this version. Conflicts with percent.
    /// </summary>
    public TerraformValue<double>? FixedAttribute
    {
        get => GetArgument<TerraformValue<double>>("fixed");
        set => SetArgument("fixed", value);
    }

    /// <summary>
    /// The number of instances (calculated as percentage) which are managed for this version. Conflicts with fixed. Note that when using percent, rounding will be in favor of explicitly set target_size values; a managed instance group with 2 instances and 2 versions, one of which has a target_size.percent of 60 will create 2 instances of that version.
    /// </summary>
    public TerraformValue<double>? Percent
    {
        get => GetArgument<TerraformValue<double>>("percent");
        set => SetArgument("percent", value);
    }

}


/// <summary>
/// Represents a google_compute_instance_group_manager Terraform resource.
/// Manages a google_compute_instance_group_manager resource.
/// </summary>
public partial class GoogleComputeInstanceGroupManager(string name) : TerraformResource("google_compute_instance_group_manager", name)
{
    /// <summary>
    /// The base instance name to use for instances in this group. The value must be a valid RFC1035 name. Supported characters are lowercase letters, numbers, and hyphens (-). Instances are named by appending a hyphen and a random four-character string to the base instance name.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "BaseInstanceName is required")]
    public required TerraformValue<string> BaseInstanceName
    {
        get => GetRequiredArgument<TerraformValue<string>>("base_instance_name");
        set => SetArgument("base_instance_name", value);
    }

    /// <summary>
    /// An optional textual description of the instance group manager.
    /// </summary>
    public TerraformValue<string>? Description
    {
        get => GetArgument<TerraformValue<string>>("description");
        set => SetArgument("description", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => GetArgument<TerraformValue<string>>("id") ?? CreateReference("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// Pagination behavior of the listManagedInstances API method for this managed instance group. Valid values are: &amp;quot;PAGELESS&amp;quot;, &amp;quot;PAGINATED&amp;quot;. If PAGELESS (default), Pagination is disabled for the group&#39;s listManagedInstances API method. maxResults and pageToken query parameters are ignored and all instances are returned in a single response. If PAGINATED, pagination is enabled, maxResults and pageToken query parameters are respected.
    /// </summary>
    public TerraformValue<string>? ListManagedInstancesResults
    {
        get => GetArgument<TerraformValue<string>>("list_managed_instances_results");
        set => SetArgument("list_managed_instances_results", value);
    }

    /// <summary>
    /// The name of the instance group manager. Must be 1-63 characters long and comply with RFC1035. Supported characters include lowercase letters, numbers, and hyphens.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetRequiredArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The ID of the project in which the resource belongs. If it is not provided, the provider project is used.
    /// </summary>
    public TerraformValue<string> Project
    {
        get => GetArgument<TerraformValue<string>>("project") ?? CreateReference("project");
        set => SetArgument("project", value);
    }

    /// <summary>
    /// The full URL of all target pools to which new instances in the group are added. Updating the target pools attribute does not affect existing instances.
    /// </summary>
    public TerraformSet<string>? TargetPools
    {
        get => GetArgument<TerraformSet<string>>("target_pools");
        set => SetArgument("target_pools", value);
    }

    /// <summary>
    /// The target number of running instances for this managed instance group. This value should always be explicitly set unless this resource is attached to an autoscaler, in which case it should never be set. Defaults to 0.
    /// </summary>
    public TerraformValue<double> TargetSize
    {
        get => GetArgument<TerraformValue<double>>("target_size") ?? CreateReference("target_size");
        set => SetArgument("target_size", value);
    }

    /// <summary>
    /// The target number of stopped instances for this managed instance group.
    /// </summary>
    public TerraformValue<double> TargetStoppedSize
    {
        get => GetArgument<TerraformValue<double>>("target_stopped_size") ?? CreateReference("target_stopped_size");
        set => SetArgument("target_stopped_size", value);
    }

    /// <summary>
    /// The target number of suspended instances for this managed instance group.
    /// </summary>
    public TerraformValue<double> TargetSuspendedSize
    {
        get => GetArgument<TerraformValue<double>>("target_suspended_size") ?? CreateReference("target_suspended_size");
        set => SetArgument("target_suspended_size", value);
    }

    /// <summary>
    /// Whether to wait for all instances to be created/updated before returning. Note that if this is set to true and the operation does not succeed, Terraform will continue trying until it times out.
    /// </summary>
    public TerraformValue<bool>? WaitForInstances
    {
        get => GetArgument<TerraformValue<bool>>("wait_for_instances");
        set => SetArgument("wait_for_instances", value);
    }

    /// <summary>
    /// When used with wait_for_instances specifies the status to wait for. When STABLE is specified this resource will wait until the instances are stable before returning. When UPDATED is set, it will wait for the version target to be reached and any per instance configs to be effective and all instances configs to be effective as well as all instances to be stable before returning.
    /// </summary>
    public TerraformValue<string>? WaitForInstancesStatus
    {
        get => GetArgument<TerraformValue<string>>("wait_for_instances_status");
        set => SetArgument("wait_for_instances_status", value);
    }

    /// <summary>
    /// The zone that instances in this group should be created in.
    /// </summary>
    public TerraformValue<string> Zone
    {
        get => GetArgument<TerraformValue<string>>("zone") ?? CreateReference("zone");
        set => SetArgument("zone", value);
    }

    /// <summary>
    /// Creation timestamp in RFC3339 text format.
    /// </summary>
    public TerraformValue<string> CreationTimestamp
        => CreateReference("creation_timestamp");

    /// <summary>
    /// The fingerprint of the instance group manager.
    /// </summary>
    public TerraformValue<string> Fingerprint
        => CreateReference("fingerprint");

    /// <summary>
    /// The full URL of the instance group created by the manager.
    /// </summary>
    public TerraformValue<string> InstanceGroup
        => CreateReference("instance_group");

    /// <summary>
    /// The unique identifier number for the resource. This identifier is defined by the server.
    /// </summary>
    public TerraformValue<double> InstanceGroupManagerId
        => CreateReference("instance_group_manager_id");

    /// <summary>
    /// The operation attribute.
    /// </summary>
    public TerraformValue<string> Operation
        => CreateReference("operation");

    /// <summary>
    /// The URL of the created resource.
    /// </summary>
    public TerraformValue<string> SelfLink
        => CreateReference("self_link");

    /// <summary>
    /// The status of this managed instance group.
    /// </summary>
    public TerraformList<TerraformMap<object>> Status
        => CreateReference("status");

    /// <summary>
    /// AllInstancesConfig block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AllInstancesConfig block(s) allowed")]
    public TerraformList<GoogleComputeInstanceGroupManagerAllInstancesConfigBlock>? AllInstancesConfig
    {
        get => GetArgument<TerraformList<GoogleComputeInstanceGroupManagerAllInstancesConfigBlock>>("all_instances_config");
        set => SetArgument("all_instances_config", value);
    }

    /// <summary>
    /// AutoHealingPolicies block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AutoHealingPolicies block(s) allowed")]
    public TerraformList<GoogleComputeInstanceGroupManagerAutoHealingPoliciesBlock>? AutoHealingPolicies
    {
        get => GetArgument<TerraformList<GoogleComputeInstanceGroupManagerAutoHealingPoliciesBlock>>("auto_healing_policies");
        set => SetArgument("auto_healing_policies", value);
    }

    /// <summary>
    /// InstanceLifecyclePolicy block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 InstanceLifecyclePolicy block(s) allowed")]
    public TerraformList<GoogleComputeInstanceGroupManagerInstanceLifecyclePolicyBlock>? InstanceLifecyclePolicy
    {
        get => GetArgument<TerraformList<GoogleComputeInstanceGroupManagerInstanceLifecyclePolicyBlock>>("instance_lifecycle_policy");
        set => SetArgument("instance_lifecycle_policy", value);
    }

    /// <summary>
    /// NamedPort block (nesting mode: set).
    /// </summary>
    public TerraformSet<GoogleComputeInstanceGroupManagerNamedPortBlock>? NamedPort
    {
        get => GetArgument<TerraformSet<GoogleComputeInstanceGroupManagerNamedPortBlock>>("named_port");
        set => SetArgument("named_port", value);
    }

    /// <summary>
    /// ResourcePolicies block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ResourcePolicies block(s) allowed")]
    public TerraformList<GoogleComputeInstanceGroupManagerResourcePoliciesBlock>? ResourcePolicies
    {
        get => GetArgument<TerraformList<GoogleComputeInstanceGroupManagerResourcePoliciesBlock>>("resource_policies");
        set => SetArgument("resource_policies", value);
    }

    /// <summary>
    /// StandbyPolicy block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 StandbyPolicy block(s) allowed")]
    public TerraformList<GoogleComputeInstanceGroupManagerStandbyPolicyBlock>? StandbyPolicy
    {
        get => GetArgument<TerraformList<GoogleComputeInstanceGroupManagerStandbyPolicyBlock>>("standby_policy");
        set => SetArgument("standby_policy", value);
    }

    /// <summary>
    /// StatefulDisk block (nesting mode: set).
    /// </summary>
    public TerraformSet<GoogleComputeInstanceGroupManagerStatefulDiskBlock>? StatefulDisk
    {
        get => GetArgument<TerraformSet<GoogleComputeInstanceGroupManagerStatefulDiskBlock>>("stateful_disk");
        set => SetArgument("stateful_disk", value);
    }

    /// <summary>
    /// StatefulExternalIp block (nesting mode: list).
    /// </summary>
    public TerraformList<GoogleComputeInstanceGroupManagerStatefulExternalIpBlock>? StatefulExternalIp
    {
        get => GetArgument<TerraformList<GoogleComputeInstanceGroupManagerStatefulExternalIpBlock>>("stateful_external_ip");
        set => SetArgument("stateful_external_ip", value);
    }

    /// <summary>
    /// StatefulInternalIp block (nesting mode: list).
    /// </summary>
    public TerraformList<GoogleComputeInstanceGroupManagerStatefulInternalIpBlock>? StatefulInternalIp
    {
        get => GetArgument<TerraformList<GoogleComputeInstanceGroupManagerStatefulInternalIpBlock>>("stateful_internal_ip");
        set => SetArgument("stateful_internal_ip", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public GoogleComputeInstanceGroupManagerTimeoutsBlock? Timeouts
    {
        get => GetArgument<GoogleComputeInstanceGroupManagerTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

    /// <summary>
    /// UpdatePolicy block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 UpdatePolicy block(s) allowed")]
    public TerraformList<GoogleComputeInstanceGroupManagerUpdatePolicyBlock>? UpdatePolicy
    {
        get => GetArgument<TerraformList<GoogleComputeInstanceGroupManagerUpdatePolicyBlock>>("update_policy");
        set => SetArgument("update_policy", value);
    }

    /// <summary>
    /// Version block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Version is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Version block(s) required")]
    public required TerraformList<GoogleComputeInstanceGroupManagerVersionBlock> Version
    {
        get => GetRequiredArgument<TerraformList<GoogleComputeInstanceGroupManagerVersionBlock>>("version");
        set => SetArgument("version", value);
    }

}

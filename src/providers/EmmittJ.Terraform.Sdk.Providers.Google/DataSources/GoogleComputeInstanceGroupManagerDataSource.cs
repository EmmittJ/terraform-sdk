using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Represents a google_compute_instance_group_manager Terraform data source.
/// Retrieves information about a google_compute_instance_group_manager.
/// </summary>
public partial class GoogleComputeInstanceGroupManagerDataSource(string name) : TerraformDataSource("google_compute_instance_group_manager", name)
{
    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => GetArgument<TerraformValue<string>>("id") ?? CreateReference("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The name of the instance group manager. Must be 1-63 characters long and comply with RFC1035. Supported characters include lowercase letters, numbers, and hyphens.
    /// </summary>
    public TerraformValue<string>? Name
    {
        get => GetArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The ID of the project in which the resource belongs. If it is not provided, the provider project is used.
    /// </summary>
    public TerraformValue<string>? Project
    {
        get => GetArgument<TerraformValue<string>>("project");
        set => SetArgument("project", value);
    }

    /// <summary>
    /// The URL of the created resource.
    /// </summary>
    public TerraformValue<string>? SelfLink
    {
        get => GetArgument<TerraformValue<string>>("self_link");
        set => SetArgument("self_link", value);
    }

    /// <summary>
    /// The zone that instances in this group should be created in.
    /// </summary>
    public TerraformValue<string>? Zone
    {
        get => GetArgument<TerraformValue<string>>("zone");
        set => SetArgument("zone", value);
    }

    /// <summary>
    /// Specifies configuration that overrides the instance template configuration for the group.
    /// </summary>
    public TerraformList<TerraformMap<object>> AllInstancesConfig
        => CreateReference("all_instances_config");

    /// <summary>
    /// The autohealing policies for this managed instance group. You can specify only one value.
    /// </summary>
    public TerraformList<TerraformMap<object>> AutoHealingPolicies
        => CreateReference("auto_healing_policies");

    /// <summary>
    /// The base instance name to use for instances in this group. The value must be a valid RFC1035 name. Supported characters are lowercase letters, numbers, and hyphens (-). Instances are named by appending a hyphen and a random four-character string to the base instance name.
    /// </summary>
    public TerraformValue<string> BaseInstanceName
        => CreateReference("base_instance_name");

    /// <summary>
    /// Creation timestamp in RFC3339 text format.
    /// </summary>
    public TerraformValue<string> CreationTimestamp
        => CreateReference("creation_timestamp");

    /// <summary>
    /// An optional textual description of the instance group manager.
    /// </summary>
    public TerraformValue<string> Description
        => CreateReference("description");

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
    /// The instance lifecycle policy for this managed instance group.
    /// </summary>
    public TerraformList<TerraformMap<object>> InstanceLifecyclePolicy
        => CreateReference("instance_lifecycle_policy");

    /// <summary>
    /// Pagination behavior of the listManagedInstances API method for this managed instance group. Valid values are: &amp;quot;PAGELESS&amp;quot;, &amp;quot;PAGINATED&amp;quot;. If PAGELESS (default), Pagination is disabled for the group&#39;s listManagedInstances API method. maxResults and pageToken query parameters are ignored and all instances are returned in a single response. If PAGINATED, pagination is enabled, maxResults and pageToken query parameters are respected.
    /// </summary>
    public TerraformValue<string> ListManagedInstancesResults
        => CreateReference("list_managed_instances_results");

    /// <summary>
    /// The named port configuration.
    /// </summary>
    public TerraformSet<TerraformMap<object>> NamedPort
        => CreateReference("named_port");

    /// <summary>
    /// The operation attribute.
    /// </summary>
    public TerraformValue<string> Operation
        => CreateReference("operation");

    /// <summary>
    /// Resource policies for this managed instance group.
    /// </summary>
    public TerraformList<TerraformMap<object>> ResourcePolicies
        => CreateReference("resource_policies");

    /// <summary>
    /// Standby policy for stopped and suspended instances.
    /// </summary>
    public TerraformList<TerraformMap<object>> StandbyPolicy
        => CreateReference("standby_policy");

    /// <summary>
    /// Disks created on the instances that will be preserved on instance delete, update, etc.
    /// </summary>
    public TerraformSet<TerraformMap<object>> StatefulDisk
        => CreateReference("stateful_disk");

    /// <summary>
    /// External IPs considered stateful by the instance group. 
    /// </summary>
    public TerraformList<TerraformMap<object>> StatefulExternalIp
        => CreateReference("stateful_external_ip");

    /// <summary>
    /// External IPs considered stateful by the instance group. 
    /// </summary>
    public TerraformList<TerraformMap<object>> StatefulInternalIp
        => CreateReference("stateful_internal_ip");

    /// <summary>
    /// The status of this managed instance group.
    /// </summary>
    public TerraformList<TerraformMap<object>> Status
        => CreateReference("status");

    /// <summary>
    /// The full URL of all target pools to which new instances in the group are added. Updating the target pools attribute does not affect existing instances.
    /// </summary>
    public TerraformSet<string> TargetPools
        => CreateReference("target_pools");

    /// <summary>
    /// The target number of running instances for this managed instance group. This value should always be explicitly set unless this resource is attached to an autoscaler, in which case it should never be set. Defaults to 0.
    /// </summary>
    public TerraformValue<double> TargetSize
        => CreateReference("target_size");

    /// <summary>
    /// The target number of stopped instances for this managed instance group.
    /// </summary>
    public TerraformValue<double> TargetStoppedSize
        => CreateReference("target_stopped_size");

    /// <summary>
    /// The target number of suspended instances for this managed instance group.
    /// </summary>
    public TerraformValue<double> TargetSuspendedSize
        => CreateReference("target_suspended_size");

    /// <summary>
    /// The update policy for this managed instance group.
    /// </summary>
    public TerraformList<TerraformMap<object>> UpdatePolicy
        => CreateReference("update_policy");

    /// <summary>
    /// Application versions managed by this instance group. Each version deals with a specific instance template, allowing canary release scenarios.
    /// </summary>
    public TerraformList<TerraformMap<object>> Version
        => CreateReference("version");

    /// <summary>
    /// Whether to wait for all instances to be created/updated before returning. Note that if this is set to true and the operation does not succeed, Terraform will continue trying until it times out.
    /// </summary>
    public TerraformValue<bool> WaitForInstances
        => CreateReference("wait_for_instances");

    /// <summary>
    /// When used with wait_for_instances specifies the status to wait for. When STABLE is specified this resource will wait until the instances are stable before returning. When UPDATED is set, it will wait for the version target to be reached and any per instance configs to be effective and all instances configs to be effective as well as all instances to be stable before returning.
    /// </summary>
    public TerraformValue<string> WaitForInstancesStatus
        => CreateReference("wait_for_instances_status");

}

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
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The name of the instance group manager. Must be 1-63 characters long and comply with RFC1035. Supported characters include lowercase letters, numbers, and hyphens.
    /// </summary>
    public TerraformValue<string>? Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The ID of the project in which the resource belongs. If it is not provided, the provider project is used.
    /// </summary>
    public TerraformValue<string>? Project
    {
        get => new TerraformReference<string>(this, "project");
        set => SetArgument("project", value);
    }

    /// <summary>
    /// The URL of the created resource.
    /// </summary>
    public TerraformValue<string>? SelfLink
    {
        get => new TerraformReference<string>(this, "self_link");
        set => SetArgument("self_link", value);
    }

    /// <summary>
    /// The zone that instances in this group should be created in.
    /// </summary>
    public TerraformValue<string>? Zone
    {
        get => new TerraformReference<string>(this, "zone");
        set => SetArgument("zone", value);
    }

    /// <summary>
    /// Specifies configuration that overrides the instance template configuration for the group.
    /// </summary>
    public TerraformList<TerraformMap<object>> AllInstancesConfig
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "all_instances_config").ResolveNodes(ctx));
    }

    /// <summary>
    /// The autohealing policies for this managed instance group. You can specify only one value.
    /// </summary>
    public TerraformList<TerraformMap<object>> AutoHealingPolicies
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "auto_healing_policies").ResolveNodes(ctx));
    }

    /// <summary>
    /// The base instance name to use for instances in this group. The value must be a valid RFC1035 name. Supported characters are lowercase letters, numbers, and hyphens (-). Instances are named by appending a hyphen and a random four-character string to the base instance name.
    /// </summary>
    public TerraformValue<string> BaseInstanceName
    {
        get => new TerraformReference<string>(this, "base_instance_name");
    }

    /// <summary>
    /// Creation timestamp in RFC3339 text format.
    /// </summary>
    public TerraformValue<string> CreationTimestamp
    {
        get => new TerraformReference<string>(this, "creation_timestamp");
    }

    /// <summary>
    /// An optional textual description of the instance group manager.
    /// </summary>
    public TerraformValue<string> Description
    {
        get => new TerraformReference<string>(this, "description");
    }

    /// <summary>
    /// The fingerprint of the instance group manager.
    /// </summary>
    public TerraformValue<string> Fingerprint
    {
        get => new TerraformReference<string>(this, "fingerprint");
    }

    /// <summary>
    /// The full URL of the instance group created by the manager.
    /// </summary>
    public TerraformValue<string> InstanceGroup
    {
        get => new TerraformReference<string>(this, "instance_group");
    }

    /// <summary>
    /// The unique identifier number for the resource. This identifier is defined by the server.
    /// </summary>
    public TerraformValue<double> InstanceGroupManagerId
    {
        get => new TerraformReference<double>(this, "instance_group_manager_id");
    }

    /// <summary>
    /// The instance lifecycle policy for this managed instance group.
    /// </summary>
    public TerraformList<TerraformMap<object>> InstanceLifecyclePolicy
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "instance_lifecycle_policy").ResolveNodes(ctx));
    }

    /// <summary>
    /// Pagination behavior of the listManagedInstances API method for this managed instance group. Valid values are: &amp;quot;PAGELESS&amp;quot;, &amp;quot;PAGINATED&amp;quot;. If PAGELESS (default), Pagination is disabled for the group&#39;s listManagedInstances API method. maxResults and pageToken query parameters are ignored and all instances are returned in a single response. If PAGINATED, pagination is enabled, maxResults and pageToken query parameters are respected.
    /// </summary>
    public TerraformValue<string> ListManagedInstancesResults
    {
        get => new TerraformReference<string>(this, "list_managed_instances_results");
    }

    /// <summary>
    /// The named port configuration.
    /// </summary>
    public TerraformSet<TerraformMap<object>> NamedPort
    {
        get => TerraformSet<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformSet<TerraformMap<object>>>(this, "named_port").ResolveNodes(ctx));
    }

    /// <summary>
    /// The operation attribute.
    /// </summary>
    public TerraformValue<string> Operation
    {
        get => new TerraformReference<string>(this, "operation");
    }

    /// <summary>
    /// Resource policies for this managed instance group.
    /// </summary>
    public TerraformList<TerraformMap<object>> ResourcePolicies
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "resource_policies").ResolveNodes(ctx));
    }

    /// <summary>
    /// Standby policy for stopped and suspended instances.
    /// </summary>
    public TerraformList<TerraformMap<object>> StandbyPolicy
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "standby_policy").ResolveNodes(ctx));
    }

    /// <summary>
    /// Disks created on the instances that will be preserved on instance delete, update, etc.
    /// </summary>
    public TerraformSet<TerraformMap<object>> StatefulDisk
    {
        get => TerraformSet<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformSet<TerraformMap<object>>>(this, "stateful_disk").ResolveNodes(ctx));
    }

    /// <summary>
    /// External IPs considered stateful by the instance group. 
    /// </summary>
    public TerraformList<TerraformMap<object>> StatefulExternalIp
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "stateful_external_ip").ResolveNodes(ctx));
    }

    /// <summary>
    /// External IPs considered stateful by the instance group. 
    /// </summary>
    public TerraformList<TerraformMap<object>> StatefulInternalIp
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "stateful_internal_ip").ResolveNodes(ctx));
    }

    /// <summary>
    /// The status of this managed instance group.
    /// </summary>
    public TerraformList<TerraformMap<object>> Status
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "status").ResolveNodes(ctx));
    }

    /// <summary>
    /// The full URL of all target pools to which new instances in the group are added. Updating the target pools attribute does not affect existing instances.
    /// </summary>
    public TerraformSet<string> TargetPools
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "target_pools").ResolveNodes(ctx));
    }

    /// <summary>
    /// The target number of running instances for this managed instance group. This value should always be explicitly set unless this resource is attached to an autoscaler, in which case it should never be set. Defaults to 0.
    /// </summary>
    public TerraformValue<double> TargetSize
    {
        get => new TerraformReference<double>(this, "target_size");
    }

    /// <summary>
    /// The target number of stopped instances for this managed instance group.
    /// </summary>
    public TerraformValue<double> TargetStoppedSize
    {
        get => new TerraformReference<double>(this, "target_stopped_size");
    }

    /// <summary>
    /// The target number of suspended instances for this managed instance group.
    /// </summary>
    public TerraformValue<double> TargetSuspendedSize
    {
        get => new TerraformReference<double>(this, "target_suspended_size");
    }

    /// <summary>
    /// The update policy for this managed instance group.
    /// </summary>
    public TerraformList<TerraformMap<object>> UpdatePolicy
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "update_policy").ResolveNodes(ctx));
    }

    /// <summary>
    /// Application versions managed by this instance group. Each version deals with a specific instance template, allowing canary release scenarios.
    /// </summary>
    public TerraformList<TerraformMap<object>> Version
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "version").ResolveNodes(ctx));
    }

    /// <summary>
    /// Whether to wait for all instances to be created/updated before returning. Note that if this is set to true and the operation does not succeed, Terraform will continue trying until it times out.
    /// </summary>
    public TerraformValue<bool> WaitForInstances
    {
        get => new TerraformReference<bool>(this, "wait_for_instances");
    }

    /// <summary>
    /// When used with wait_for_instances specifies the status to wait for. When STABLE is specified this resource will wait until the instances are stable before returning. When UPDATED is set, it will wait for the version target to be reached and any per instance configs to be effective and all instances configs to be effective as well as all instances to be stable before returning.
    /// </summary>
    public TerraformValue<string> WaitForInstancesStatus
    {
        get => new TerraformReference<string>(this, "wait_for_instances_status");
    }

}

using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Represents a google_compute_region_instance_group_manager Terraform data source.
/// Retrieves information about a google_compute_region_instance_group_manager.
/// </summary>
public partial class GoogleComputeRegionInstanceGroupManagerDataSource(string name) : TerraformDataSource("google_compute_region_instance_group_manager", name)
{
    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => GetArgument<TerraformValue<string>>("id") ?? AsReference("id");
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
    /// The region where the managed instance group resides.
    /// </summary>
    public TerraformValue<string>? Region
    {
        get => GetArgument<TerraformValue<string>>("region");
        set => SetArgument("region", value);
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
    /// Specifies configuration that overrides the instance template configuration for the group.
    /// </summary>
    public TerraformList<TerraformMap<object>> AllInstancesConfig
        => AsReference("all_instances_config");

    /// <summary>
    /// The autohealing policies for this managed instance group. You can specify only one value.
    /// </summary>
    public TerraformList<TerraformMap<object>> AutoHealingPolicies
        => AsReference("auto_healing_policies");

    /// <summary>
    /// The base instance name to use for instances in this group. The value must be a valid RFC1035 name. Supported characters are lowercase letters, numbers, and hyphens (-). Instances are named by appending a hyphen and a random four-character string to the base instance name.
    /// </summary>
    public TerraformValue<string> BaseInstanceName
        => AsReference("base_instance_name");

    /// <summary>
    /// Creation timestamp in RFC3339 text format.
    /// </summary>
    public TerraformValue<string> CreationTimestamp
        => AsReference("creation_timestamp");

    /// <summary>
    /// An optional textual description of the instance group manager.
    /// </summary>
    public TerraformValue<string> Description
        => AsReference("description");

    /// <summary>
    /// The shape to which the group converges either proactively or on resize events (depending on the value set in updatePolicy.instanceRedistributionType).
    /// </summary>
    public TerraformValue<string> DistributionPolicyTargetShape
        => AsReference("distribution_policy_target_shape");

    /// <summary>
    /// The distribution policy for this managed instance group. You can specify one or more values.
    /// </summary>
    public TerraformSet<string> DistributionPolicyZones
        => AsReference("distribution_policy_zones");

    /// <summary>
    /// The fingerprint of the instance group manager.
    /// </summary>
    public TerraformValue<string> Fingerprint
        => AsReference("fingerprint");

    /// <summary>
    /// The flexibility policy for this managed instance group. Instance flexibility allowing MIG to create VMs from multiple types of machines. Instance flexibility configuration on MIG overrides instance template configuration.
    /// </summary>
    public TerraformList<TerraformMap<object>> InstanceFlexibilityPolicy
        => AsReference("instance_flexibility_policy");

    /// <summary>
    /// The full URL of the instance group created by the manager.
    /// </summary>
    public TerraformValue<string> InstanceGroup
        => AsReference("instance_group");

    /// <summary>
    /// The unique identifier number for the resource. This identifier is defined by the server.
    /// </summary>
    public TerraformValue<double> InstanceGroupManagerId
        => AsReference("instance_group_manager_id");

    /// <summary>
    /// The instance lifecycle policy for this managed instance group.
    /// </summary>
    public TerraformList<TerraformMap<object>> InstanceLifecyclePolicy
        => AsReference("instance_lifecycle_policy");

    /// <summary>
    /// Pagination behavior of the listManagedInstances API method for this managed instance group. Valid values are: &amp;quot;PAGELESS&amp;quot;, &amp;quot;PAGINATED&amp;quot;. If PAGELESS (default), Pagination is disabled for the group&#39;s listManagedInstances API method. maxResults and pageToken query parameters are ignored and all instances are returned in a single response. If PAGINATED, pagination is enabled, maxResults and pageToken query parameters are respected.
    /// </summary>
    public TerraformValue<string> ListManagedInstancesResults
        => AsReference("list_managed_instances_results");

    /// <summary>
    /// The named port configuration.
    /// </summary>
    public TerraformSet<TerraformMap<object>> NamedPort
        => AsReference("named_port");

    /// <summary>
    /// Standby policy for stopped and suspended instances.
    /// </summary>
    public TerraformList<TerraformMap<object>> StandbyPolicy
        => AsReference("standby_policy");

    /// <summary>
    /// Disks created on the instances that will be preserved on instance delete, update, etc. Structure is documented below. For more information see the official documentation. Proactive cross zone instance redistribution must be disabled before you can update stateful disks on existing instance group managers. This can be controlled via the update_policy.
    /// </summary>
    public TerraformSet<TerraformMap<object>> StatefulDisk
        => AsReference("stateful_disk");

    /// <summary>
    /// External IPs considered stateful by the instance group. 
    /// </summary>
    public TerraformList<TerraformMap<object>> StatefulExternalIp
        => AsReference("stateful_external_ip");

    /// <summary>
    /// External IPs considered stateful by the instance group. 
    /// </summary>
    public TerraformList<TerraformMap<object>> StatefulInternalIp
        => AsReference("stateful_internal_ip");

    /// <summary>
    /// The status of this managed instance group.
    /// </summary>
    public TerraformList<TerraformMap<object>> Status
        => AsReference("status");

    /// <summary>
    /// The full URL of all target pools to which new instances in the group are added. Updating the target pools attribute does not affect existing instances.
    /// </summary>
    public TerraformSet<string> TargetPools
        => AsReference("target_pools");

    /// <summary>
    /// The target number of running instances for this managed instance group. This value should always be explicitly set unless this resource is attached to an autoscaler, in which case it should never be set. Defaults to 0.
    /// </summary>
    public TerraformValue<double> TargetSize
        => AsReference("target_size");

    /// <summary>
    /// The target number of stopped instances for this managed instance group.
    /// </summary>
    public TerraformValue<double> TargetStoppedSize
        => AsReference("target_stopped_size");

    /// <summary>
    /// The target number of suspended instances for this managed instance group.
    /// </summary>
    public TerraformValue<double> TargetSuspendedSize
        => AsReference("target_suspended_size");

    /// <summary>
    /// The update policy for this managed instance group.
    /// </summary>
    public TerraformList<TerraformMap<object>> UpdatePolicy
        => AsReference("update_policy");

    /// <summary>
    /// Application versions managed by this instance group. Each version deals with a specific instance template, allowing canary release scenarios.
    /// </summary>
    public TerraformList<TerraformMap<object>> Version
        => AsReference("version");

    /// <summary>
    /// Whether to wait for all instances to be created/updated before returning. Note that if this is set to true and the operation does not succeed, Terraform will continue trying until it times out.
    /// </summary>
    public TerraformValue<bool> WaitForInstances
        => AsReference("wait_for_instances");

    /// <summary>
    /// When used with wait_for_instances specifies the status to wait for. When STABLE is specified this resource will wait until the instances are stable before returning. When UPDATED is set, it will wait for the version target to be reached and any per instance configs to be effective and all instances configs to be effective as well as all instances to be stable before returning.
    /// </summary>
    public TerraformValue<string> WaitForInstancesStatus
        => AsReference("wait_for_instances_status");

}

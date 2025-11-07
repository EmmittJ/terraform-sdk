using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Manages a google_compute_region_instance_group_manager resource.
/// </summary>
public class GoogleComputeRegionInstanceGroupManager : TerraformResource
{
    public GoogleComputeRegionInstanceGroupManager(string name) : base("google_compute_region_instance_group_manager", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("creation_timestamp");
        this.DeclareOutput("fingerprint");
        this.DeclareOutput("instance_group");
        this.DeclareOutput("instance_group_manager_id");
        this.DeclareOutput("self_link");
        this.DeclareOutput("status");
    }

    /// <summary>
    /// The base instance name to use for instances in this group. The value must be a valid RFC1035 name. Supported characters are lowercase letters, numbers, and hyphens (-). Instances are named by appending a hyphen and a random four-character string to the base instance name.
    /// </summary>
    public TerraformProperty<string>? BaseInstanceName
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
    /// The shape to which the group converges either proactively or on resize events (depending on the value set in updatePolicy.instanceRedistributionType).
    /// </summary>
    public TerraformProperty<string>? DistributionPolicyTargetShape
    {
        get => GetProperty<TerraformProperty<string>>("distribution_policy_target_shape");
        set => this.WithProperty("distribution_policy_target_shape", value);
    }

    /// <summary>
    /// The distribution policy for this managed instance group. You can specify one or more values.
    /// </summary>
    public TerraformProperty<HashSet<string>>? DistributionPolicyZones
    {
        get => GetProperty<TerraformProperty<HashSet<string>>>("distribution_policy_zones");
        set => this.WithProperty("distribution_policy_zones", value);
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
    public TerraformProperty<string>? Name
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
    /// The region where the managed instance group resides.
    /// </summary>
    public TerraformProperty<string>? Region
    {
        get => GetProperty<TerraformProperty<string>>("region");
        set => this.WithProperty("region", value);
    }

    /// <summary>
    /// The full URL of all target pools to which new instances in the group are added. Updating the target pools attribute does not affect existing instances.
    /// </summary>
    public TerraformProperty<HashSet<string>>? TargetPools
    {
        get => GetProperty<TerraformProperty<HashSet<string>>>("target_pools");
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

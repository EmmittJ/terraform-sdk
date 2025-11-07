using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Retrieves information about a google_compute_region_instance_group_manager.
/// </summary>
public class GoogleComputeRegionInstanceGroupManagerDataSource : TerraformDataSource
{
    public GoogleComputeRegionInstanceGroupManagerDataSource(string name) : base("google_compute_region_instance_group_manager", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("all_instances_config");
        this.DeclareOutput("auto_healing_policies");
        this.DeclareOutput("base_instance_name");
        this.DeclareOutput("creation_timestamp");
        this.DeclareOutput("description");
        this.DeclareOutput("distribution_policy_target_shape");
        this.DeclareOutput("distribution_policy_zones");
        this.DeclareOutput("fingerprint");
        this.DeclareOutput("instance_flexibility_policy");
        this.DeclareOutput("instance_group");
        this.DeclareOutput("instance_group_manager_id");
        this.DeclareOutput("instance_lifecycle_policy");
        this.DeclareOutput("list_managed_instances_results");
        this.DeclareOutput("named_port");
        this.DeclareOutput("standby_policy");
        this.DeclareOutput("stateful_disk");
        this.DeclareOutput("stateful_external_ip");
        this.DeclareOutput("stateful_internal_ip");
        this.DeclareOutput("status");
        this.DeclareOutput("target_pools");
        this.DeclareOutput("target_size");
        this.DeclareOutput("target_stopped_size");
        this.DeclareOutput("target_suspended_size");
        this.DeclareOutput("update_policy");
        this.DeclareOutput("version");
        this.DeclareOutput("wait_for_instances");
        this.DeclareOutput("wait_for_instances_status");
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
    /// The URL of the created resource.
    /// </summary>
    public TerraformProperty<string>? SelfLink
    {
        get => GetProperty<TerraformProperty<string>>("self_link");
        set => this.WithProperty("self_link", value);
    }

    /// <summary>
    /// Specifies configuration that overrides the instance template configuration for the group.
    /// </summary>
    public TerraformExpression AllInstancesConfig => this["all_instances_config"];

    /// <summary>
    /// The autohealing policies for this managed instance group. You can specify only one value.
    /// </summary>
    public TerraformExpression AutoHealingPolicies => this["auto_healing_policies"];

    /// <summary>
    /// The base instance name to use for instances in this group. The value must be a valid RFC1035 name. Supported characters are lowercase letters, numbers, and hyphens (-). Instances are named by appending a hyphen and a random four-character string to the base instance name.
    /// </summary>
    public TerraformExpression BaseInstanceName => this["base_instance_name"];

    /// <summary>
    /// Creation timestamp in RFC3339 text format.
    /// </summary>
    public TerraformExpression CreationTimestamp => this["creation_timestamp"];

    /// <summary>
    /// An optional textual description of the instance group manager.
    /// </summary>
    public TerraformExpression Description => this["description"];

    /// <summary>
    /// The shape to which the group converges either proactively or on resize events (depending on the value set in updatePolicy.instanceRedistributionType).
    /// </summary>
    public TerraformExpression DistributionPolicyTargetShape => this["distribution_policy_target_shape"];

    /// <summary>
    /// The distribution policy for this managed instance group. You can specify one or more values.
    /// </summary>
    public TerraformExpression DistributionPolicyZones => this["distribution_policy_zones"];

    /// <summary>
    /// The fingerprint of the instance group manager.
    /// </summary>
    public TerraformExpression Fingerprint => this["fingerprint"];

    /// <summary>
    /// The flexibility policy for this managed instance group. Instance flexibility allowing MIG to create VMs from multiple types of machines. Instance flexibility configuration on MIG overrides instance template configuration.
    /// </summary>
    public TerraformExpression InstanceFlexibilityPolicy => this["instance_flexibility_policy"];

    /// <summary>
    /// The full URL of the instance group created by the manager.
    /// </summary>
    public TerraformExpression InstanceGroup => this["instance_group"];

    /// <summary>
    /// The unique identifier number for the resource. This identifier is defined by the server.
    /// </summary>
    public TerraformExpression InstanceGroupManagerId => this["instance_group_manager_id"];

    /// <summary>
    /// The instance lifecycle policy for this managed instance group.
    /// </summary>
    public TerraformExpression InstanceLifecyclePolicy => this["instance_lifecycle_policy"];

    /// <summary>
    /// Pagination behavior of the listManagedInstances API method for this managed instance group. Valid values are: &amp;quot;PAGELESS&amp;quot;, &amp;quot;PAGINATED&amp;quot;. If PAGELESS (default), Pagination is disabled for the group&#39;s listManagedInstances API method. maxResults and pageToken query parameters are ignored and all instances are returned in a single response. If PAGINATED, pagination is enabled, maxResults and pageToken query parameters are respected.
    /// </summary>
    public TerraformExpression ListManagedInstancesResults => this["list_managed_instances_results"];

    /// <summary>
    /// The named port configuration.
    /// </summary>
    public TerraformExpression NamedPort => this["named_port"];

    /// <summary>
    /// Standby policy for stopped and suspended instances.
    /// </summary>
    public TerraformExpression StandbyPolicy => this["standby_policy"];

    /// <summary>
    /// Disks created on the instances that will be preserved on instance delete, update, etc. Structure is documented below. For more information see the official documentation. Proactive cross zone instance redistribution must be disabled before you can update stateful disks on existing instance group managers. This can be controlled via the update_policy.
    /// </summary>
    public TerraformExpression StatefulDisk => this["stateful_disk"];

    /// <summary>
    /// External IPs considered stateful by the instance group. 
    /// </summary>
    public TerraformExpression StatefulExternalIp => this["stateful_external_ip"];

    /// <summary>
    /// External IPs considered stateful by the instance group. 
    /// </summary>
    public TerraformExpression StatefulInternalIp => this["stateful_internal_ip"];

    /// <summary>
    /// The status of this managed instance group.
    /// </summary>
    public TerraformExpression Status => this["status"];

    /// <summary>
    /// The full URL of all target pools to which new instances in the group are added. Updating the target pools attribute does not affect existing instances.
    /// </summary>
    public TerraformExpression TargetPools => this["target_pools"];

    /// <summary>
    /// The target number of running instances for this managed instance group. This value should always be explicitly set unless this resource is attached to an autoscaler, in which case it should never be set. Defaults to 0.
    /// </summary>
    public TerraformExpression TargetSize => this["target_size"];

    /// <summary>
    /// The target number of stopped instances for this managed instance group.
    /// </summary>
    public TerraformExpression TargetStoppedSize => this["target_stopped_size"];

    /// <summary>
    /// The target number of suspended instances for this managed instance group.
    /// </summary>
    public TerraformExpression TargetSuspendedSize => this["target_suspended_size"];

    /// <summary>
    /// The update policy for this managed instance group.
    /// </summary>
    public TerraformExpression UpdatePolicy => this["update_policy"];

    /// <summary>
    /// Application versions managed by this instance group. Each version deals with a specific instance template, allowing canary release scenarios.
    /// </summary>
    public TerraformExpression Version => this["version"];

    /// <summary>
    /// Whether to wait for all instances to be created/updated before returning. Note that if this is set to true and the operation does not succeed, Terraform will continue trying until it times out.
    /// </summary>
    public TerraformExpression WaitForInstances => this["wait_for_instances"];

    /// <summary>
    /// When used with wait_for_instances specifies the status to wait for. When STABLE is specified this resource will wait until the instances are stable before returning. When UPDATED is set, it will wait for the version target to be reached and any per instance configs to be effective and all instances configs to be effective as well as all instances to be stable before returning.
    /// </summary>
    public TerraformExpression WaitForInstancesStatus => this["wait_for_instances_status"];

}

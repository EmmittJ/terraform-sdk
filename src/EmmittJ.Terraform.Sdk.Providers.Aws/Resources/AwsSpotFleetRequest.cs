using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_spot_fleet_request resource.
/// </summary>
public class AwsSpotFleetRequest : TerraformResource
{
    public AwsSpotFleetRequest(string name) : base("aws_spot_fleet_request", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("client_token");
        this.DeclareOutput("spot_request_state");
    }

    /// <summary>
    /// The allocation_strategy attribute.
    /// </summary>
    public TerraformProperty<string>? AllocationStrategy
    {
        get => GetProperty<TerraformProperty<string>>("allocation_strategy");
        set => this.WithProperty("allocation_strategy", value);
    }

    /// <summary>
    /// The context attribute.
    /// </summary>
    public TerraformProperty<string>? Context
    {
        get => GetProperty<TerraformProperty<string>>("context");
        set => this.WithProperty("context", value);
    }

    /// <summary>
    /// The excess_capacity_termination_policy attribute.
    /// </summary>
    public TerraformProperty<string>? ExcessCapacityTerminationPolicy
    {
        get => GetProperty<TerraformProperty<string>>("excess_capacity_termination_policy");
        set => this.WithProperty("excess_capacity_termination_policy", value);
    }

    /// <summary>
    /// The fleet_type attribute.
    /// </summary>
    public TerraformProperty<string>? FleetType
    {
        get => GetProperty<TerraformProperty<string>>("fleet_type");
        set => this.WithProperty("fleet_type", value);
    }

    /// <summary>
    /// The iam_fleet_role attribute.
    /// </summary>
    public TerraformProperty<string>? IamFleetRole
    {
        get => GetProperty<TerraformProperty<string>>("iam_fleet_role");
        set => this.WithProperty("iam_fleet_role", value);
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
    /// The instance_interruption_behaviour attribute.
    /// </summary>
    public TerraformProperty<string>? InstanceInterruptionBehaviour
    {
        get => GetProperty<TerraformProperty<string>>("instance_interruption_behaviour");
        set => this.WithProperty("instance_interruption_behaviour", value);
    }

    /// <summary>
    /// The instance_pools_to_use_count attribute.
    /// </summary>
    public TerraformProperty<double>? InstancePoolsToUseCount
    {
        get => GetProperty<TerraformProperty<double>>("instance_pools_to_use_count");
        set => this.WithProperty("instance_pools_to_use_count", value);
    }

    /// <summary>
    /// The load_balancers attribute.
    /// </summary>
    public TerraformProperty<HashSet<string>>? LoadBalancers
    {
        get => GetProperty<TerraformProperty<HashSet<string>>>("load_balancers");
        set => this.WithProperty("load_balancers", value);
    }

    /// <summary>
    /// The on_demand_allocation_strategy attribute.
    /// </summary>
    public TerraformProperty<string>? OnDemandAllocationStrategy
    {
        get => GetProperty<TerraformProperty<string>>("on_demand_allocation_strategy");
        set => this.WithProperty("on_demand_allocation_strategy", value);
    }

    /// <summary>
    /// The on_demand_max_total_price attribute.
    /// </summary>
    public TerraformProperty<string>? OnDemandMaxTotalPrice
    {
        get => GetProperty<TerraformProperty<string>>("on_demand_max_total_price");
        set => this.WithProperty("on_demand_max_total_price", value);
    }

    /// <summary>
    /// The on_demand_target_capacity attribute.
    /// </summary>
    public TerraformProperty<double>? OnDemandTargetCapacity
    {
        get => GetProperty<TerraformProperty<double>>("on_demand_target_capacity");
        set => this.WithProperty("on_demand_target_capacity", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformProperty<string>? Region
    {
        get => GetProperty<TerraformProperty<string>>("region");
        set => this.WithProperty("region", value);
    }

    /// <summary>
    /// The replace_unhealthy_instances attribute.
    /// </summary>
    public TerraformProperty<bool>? ReplaceUnhealthyInstances
    {
        get => GetProperty<TerraformProperty<bool>>("replace_unhealthy_instances");
        set => this.WithProperty("replace_unhealthy_instances", value);
    }

    /// <summary>
    /// The spot_price attribute.
    /// </summary>
    public TerraformProperty<string>? SpotPrice
    {
        get => GetProperty<TerraformProperty<string>>("spot_price");
        set => this.WithProperty("spot_price", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformProperty<Dictionary<string, string>>? Tags
    {
        get => GetProperty<TerraformProperty<Dictionary<string, string>>>("tags");
        set => this.WithProperty("tags", value);
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public TerraformProperty<Dictionary<string, string>>? TagsAll
    {
        get => GetProperty<TerraformProperty<Dictionary<string, string>>>("tags_all");
        set => this.WithProperty("tags_all", value);
    }

    /// <summary>
    /// The target_capacity attribute.
    /// </summary>
    public TerraformProperty<double>? TargetCapacity
    {
        get => GetProperty<TerraformProperty<double>>("target_capacity");
        set => this.WithProperty("target_capacity", value);
    }

    /// <summary>
    /// The target_capacity_unit_type attribute.
    /// </summary>
    public TerraformProperty<string>? TargetCapacityUnitType
    {
        get => GetProperty<TerraformProperty<string>>("target_capacity_unit_type");
        set => this.WithProperty("target_capacity_unit_type", value);
    }

    /// <summary>
    /// The target_group_arns attribute.
    /// </summary>
    public TerraformProperty<HashSet<string>>? TargetGroupArns
    {
        get => GetProperty<TerraformProperty<HashSet<string>>>("target_group_arns");
        set => this.WithProperty("target_group_arns", value);
    }

    /// <summary>
    /// The terminate_instances_on_delete attribute.
    /// </summary>
    public TerraformProperty<string>? TerminateInstancesOnDelete
    {
        get => GetProperty<TerraformProperty<string>>("terminate_instances_on_delete");
        set => this.WithProperty("terminate_instances_on_delete", value);
    }

    /// <summary>
    /// The terminate_instances_with_expiration attribute.
    /// </summary>
    public TerraformProperty<bool>? TerminateInstancesWithExpiration
    {
        get => GetProperty<TerraformProperty<bool>>("terminate_instances_with_expiration");
        set => this.WithProperty("terminate_instances_with_expiration", value);
    }

    /// <summary>
    /// The valid_from attribute.
    /// </summary>
    public TerraformProperty<string>? ValidFrom
    {
        get => GetProperty<TerraformProperty<string>>("valid_from");
        set => this.WithProperty("valid_from", value);
    }

    /// <summary>
    /// The valid_until attribute.
    /// </summary>
    public TerraformProperty<string>? ValidUntil
    {
        get => GetProperty<TerraformProperty<string>>("valid_until");
        set => this.WithProperty("valid_until", value);
    }

    /// <summary>
    /// The wait_for_fulfillment attribute.
    /// </summary>
    public TerraformProperty<bool>? WaitForFulfillment
    {
        get => GetProperty<TerraformProperty<bool>>("wait_for_fulfillment");
        set => this.WithProperty("wait_for_fulfillment", value);
    }

    /// <summary>
    /// The client_token attribute.
    /// </summary>
    public TerraformExpression ClientToken => this["client_token"];

    /// <summary>
    /// The spot_request_state attribute.
    /// </summary>
    public TerraformExpression SpotRequestState => this["spot_request_state"];

}

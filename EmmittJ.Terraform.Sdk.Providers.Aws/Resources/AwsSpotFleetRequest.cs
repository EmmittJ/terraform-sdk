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
    public string? AllocationStrategy
    {
        get => GetProperty<TerraformLiteralProperty<string>>("allocation_strategy")?.Value;
        set => this.WithProperty("allocation_strategy", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The context attribute.
    /// </summary>
    public string? Context
    {
        get => GetProperty<TerraformLiteralProperty<string>>("context")?.Value;
        set => this.WithProperty("context", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The excess_capacity_termination_policy attribute.
    /// </summary>
    public string? ExcessCapacityTerminationPolicy
    {
        get => GetProperty<TerraformLiteralProperty<string>>("excess_capacity_termination_policy")?.Value;
        set => this.WithProperty("excess_capacity_termination_policy", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The fleet_type attribute.
    /// </summary>
    public string? FleetType
    {
        get => GetProperty<TerraformLiteralProperty<string>>("fleet_type")?.Value;
        set => this.WithProperty("fleet_type", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The iam_fleet_role attribute.
    /// </summary>
    public string? IamFleetRole
    {
        get => GetProperty<TerraformLiteralProperty<string>>("iam_fleet_role")?.Value;
        set => this.WithProperty("iam_fleet_role", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public string? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id")?.Value;
        set => this.WithProperty("id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The instance_interruption_behaviour attribute.
    /// </summary>
    public string? InstanceInterruptionBehaviour
    {
        get => GetProperty<TerraformLiteralProperty<string>>("instance_interruption_behaviour")?.Value;
        set => this.WithProperty("instance_interruption_behaviour", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The instance_pools_to_use_count attribute.
    /// </summary>
    public double? InstancePoolsToUseCount
    {
        get => GetProperty<TerraformLiteralProperty<double>>("instance_pools_to_use_count")?.Value;
        set => this.WithProperty("instance_pools_to_use_count", value == null ? null : new TerraformLiteralProperty<double>(value.Value));
    }

    /// <summary>
    /// The load_balancers attribute.
    /// </summary>
    public HashSet<string>? LoadBalancers
    {
        get => GetProperty<TerraformLiteralProperty<HashSet<string>>>("load_balancers")?.Value;
        set => this.WithProperty("load_balancers", value == null ? null : new TerraformLiteralProperty<HashSet<string>>(value));
    }

    /// <summary>
    /// The on_demand_allocation_strategy attribute.
    /// </summary>
    public string? OnDemandAllocationStrategy
    {
        get => GetProperty<TerraformLiteralProperty<string>>("on_demand_allocation_strategy")?.Value;
        set => this.WithProperty("on_demand_allocation_strategy", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The on_demand_max_total_price attribute.
    /// </summary>
    public string? OnDemandMaxTotalPrice
    {
        get => GetProperty<TerraformLiteralProperty<string>>("on_demand_max_total_price")?.Value;
        set => this.WithProperty("on_demand_max_total_price", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The on_demand_target_capacity attribute.
    /// </summary>
    public double? OnDemandTargetCapacity
    {
        get => GetProperty<TerraformLiteralProperty<double>>("on_demand_target_capacity")?.Value;
        set => this.WithProperty("on_demand_target_capacity", value == null ? null : new TerraformLiteralProperty<double>(value.Value));
    }

    /// <summary>
    /// The replace_unhealthy_instances attribute.
    /// </summary>
    public bool? ReplaceUnhealthyInstances
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("replace_unhealthy_instances")?.Value;
        set => this.WithProperty("replace_unhealthy_instances", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The spot_price attribute.
    /// </summary>
    public string? SpotPrice
    {
        get => GetProperty<TerraformLiteralProperty<string>>("spot_price")?.Value;
        set => this.WithProperty("spot_price", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, string>? Tags
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("tags")?.Value;
        set => this.WithProperty("tags", value == null ? null : new TerraformLiteralProperty<Dictionary<string, string>>(value));
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public Dictionary<string, string>? TagsAll
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("tags_all")?.Value;
        set => this.WithProperty("tags_all", value == null ? null : new TerraformLiteralProperty<Dictionary<string, string>>(value));
    }

    /// <summary>
    /// The target_capacity attribute.
    /// </summary>
    public double? TargetCapacity
    {
        get => GetProperty<TerraformLiteralProperty<double>>("target_capacity")?.Value;
        set => this.WithProperty("target_capacity", value == null ? null : new TerraformLiteralProperty<double>(value.Value));
    }

    /// <summary>
    /// The target_capacity_unit_type attribute.
    /// </summary>
    public string? TargetCapacityUnitType
    {
        get => GetProperty<TerraformLiteralProperty<string>>("target_capacity_unit_type")?.Value;
        set => this.WithProperty("target_capacity_unit_type", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The target_group_arns attribute.
    /// </summary>
    public HashSet<string>? TargetGroupArns
    {
        get => GetProperty<TerraformLiteralProperty<HashSet<string>>>("target_group_arns")?.Value;
        set => this.WithProperty("target_group_arns", value == null ? null : new TerraformLiteralProperty<HashSet<string>>(value));
    }

    /// <summary>
    /// The terminate_instances_on_delete attribute.
    /// </summary>
    public string? TerminateInstancesOnDelete
    {
        get => GetProperty<TerraformLiteralProperty<string>>("terminate_instances_on_delete")?.Value;
        set => this.WithProperty("terminate_instances_on_delete", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The terminate_instances_with_expiration attribute.
    /// </summary>
    public bool? TerminateInstancesWithExpiration
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("terminate_instances_with_expiration")?.Value;
        set => this.WithProperty("terminate_instances_with_expiration", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The valid_from attribute.
    /// </summary>
    public string? ValidFrom
    {
        get => GetProperty<TerraformLiteralProperty<string>>("valid_from")?.Value;
        set => this.WithProperty("valid_from", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The valid_until attribute.
    /// </summary>
    public string? ValidUntil
    {
        get => GetProperty<TerraformLiteralProperty<string>>("valid_until")?.Value;
        set => this.WithProperty("valid_until", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The wait_for_fulfillment attribute.
    /// </summary>
    public bool? WaitForFulfillment
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("wait_for_fulfillment")?.Value;
        set => this.WithProperty("wait_for_fulfillment", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
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

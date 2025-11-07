using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_ec2_fleet resource.
/// </summary>
public class AwsEc2Fleet : TerraformResource
{
    public AwsEc2Fleet(string name) : base("aws_ec2_fleet", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("arn");
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
    /// The fleet_state attribute.
    /// </summary>
    public TerraformProperty<string>? FleetState
    {
        get => GetProperty<TerraformProperty<string>>("fleet_state");
        set => this.WithProperty("fleet_state", value);
    }

    /// <summary>
    /// The fulfilled_capacity attribute.
    /// </summary>
    public TerraformProperty<double>? FulfilledCapacity
    {
        get => GetProperty<TerraformProperty<double>>("fulfilled_capacity");
        set => this.WithProperty("fulfilled_capacity", value);
    }

    /// <summary>
    /// The fulfilled_on_demand_capacity attribute.
    /// </summary>
    public TerraformProperty<double>? FulfilledOnDemandCapacity
    {
        get => GetProperty<TerraformProperty<double>>("fulfilled_on_demand_capacity");
        set => this.WithProperty("fulfilled_on_demand_capacity", value);
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
    /// The terminate_instances attribute.
    /// </summary>
    public TerraformProperty<bool>? TerminateInstances
    {
        get => GetProperty<TerraformProperty<bool>>("terminate_instances");
        set => this.WithProperty("terminate_instances", value);
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
    /// The type attribute.
    /// </summary>
    public TerraformProperty<string>? Type
    {
        get => GetProperty<TerraformProperty<string>>("type");
        set => this.WithProperty("type", value);
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
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

}

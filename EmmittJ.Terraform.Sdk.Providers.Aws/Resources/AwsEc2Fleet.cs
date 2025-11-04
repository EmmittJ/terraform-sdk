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
    /// The fleet_state attribute.
    /// </summary>
    public string? FleetState
    {
        get => GetProperty<TerraformLiteralProperty<string>>("fleet_state")?.Value;
        set => this.WithProperty("fleet_state", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The fulfilled_capacity attribute.
    /// </summary>
    public double? FulfilledCapacity
    {
        get => GetProperty<TerraformLiteralProperty<double>>("fulfilled_capacity")?.Value;
        set => this.WithProperty("fulfilled_capacity", value == null ? null : new TerraformLiteralProperty<double>(value.Value));
    }

    /// <summary>
    /// The fulfilled_on_demand_capacity attribute.
    /// </summary>
    public double? FulfilledOnDemandCapacity
    {
        get => GetProperty<TerraformLiteralProperty<double>>("fulfilled_on_demand_capacity")?.Value;
        set => this.WithProperty("fulfilled_on_demand_capacity", value == null ? null : new TerraformLiteralProperty<double>(value.Value));
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
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public string? Region
    {
        get => GetProperty<TerraformLiteralProperty<string>>("region")?.Value;
        set => this.WithProperty("region", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The terminate_instances attribute.
    /// </summary>
    public bool? TerminateInstances
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("terminate_instances")?.Value;
        set => this.WithProperty("terminate_instances", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
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
    /// The type attribute.
    /// </summary>
    public string? Type
    {
        get => GetProperty<TerraformLiteralProperty<string>>("type")?.Value;
        set => this.WithProperty("type", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

}

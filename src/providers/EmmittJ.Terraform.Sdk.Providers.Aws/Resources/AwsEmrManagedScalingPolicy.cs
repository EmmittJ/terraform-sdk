using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for compute_limits in AwsEmrManagedScalingPolicy.
/// Nesting mode: set
/// </summary>
public class AwsEmrManagedScalingPolicyComputeLimitsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "compute_limits";

    /// <summary>
    /// The maximum_capacity_units attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MaximumCapacityUnits is required")]
    public required TerraformValue<double> MaximumCapacityUnits
    {
        get => new TerraformReference<double>(this, "maximum_capacity_units");
        set => SetArgument("maximum_capacity_units", value);
    }

    /// <summary>
    /// The maximum_core_capacity_units attribute.
    /// </summary>
    public TerraformValue<double>? MaximumCoreCapacityUnits
    {
        get => new TerraformReference<double>(this, "maximum_core_capacity_units");
        set => SetArgument("maximum_core_capacity_units", value);
    }

    /// <summary>
    /// The maximum_ondemand_capacity_units attribute.
    /// </summary>
    public TerraformValue<double>? MaximumOndemandCapacityUnits
    {
        get => new TerraformReference<double>(this, "maximum_ondemand_capacity_units");
        set => SetArgument("maximum_ondemand_capacity_units", value);
    }

    /// <summary>
    /// The minimum_capacity_units attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MinimumCapacityUnits is required")]
    public required TerraformValue<double> MinimumCapacityUnits
    {
        get => new TerraformReference<double>(this, "minimum_capacity_units");
        set => SetArgument("minimum_capacity_units", value);
    }

    /// <summary>
    /// The unit_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "UnitType is required")]
    public required TerraformValue<string> UnitType
    {
        get => new TerraformReference<string>(this, "unit_type");
        set => SetArgument("unit_type", value);
    }

}


/// <summary>
/// Represents a aws_emr_managed_scaling_policy Terraform resource.
/// Manages a aws_emr_managed_scaling_policy resource.
/// </summary>
public partial class AwsEmrManagedScalingPolicy(string name) : TerraformResource("aws_emr_managed_scaling_policy", name)
{
    /// <summary>
    /// The cluster_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ClusterId is required")]
    public required TerraformValue<string> ClusterId
    {
        get => new TerraformReference<string>(this, "cluster_id");
        set => SetArgument("cluster_id", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string> Region
    {
        get => new TerraformReference<string>(this, "region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// ComputeLimits block (nesting mode: set).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ComputeLimits is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 ComputeLimits block(s) required")]
    public required TerraformSet<AwsEmrManagedScalingPolicyComputeLimitsBlock> ComputeLimits
    {
        get => GetRequiredArgument<TerraformSet<AwsEmrManagedScalingPolicyComputeLimitsBlock>>("compute_limits");
        set => SetArgument("compute_limits", value);
    }

}

using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for compute_limits in .
/// Nesting mode: set
/// </summary>
public class AwsEmrManagedScalingPolicyComputeLimitsBlock : TerraformBlock
{
    /// <summary>
    /// The maximum_capacity_units attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MaximumCapacityUnits is required")]
    public required TerraformProperty<double> MaximumCapacityUnits
    {
        get => GetProperty<TerraformProperty<double>>("maximum_capacity_units");
        set => WithProperty("maximum_capacity_units", value);
    }

    /// <summary>
    /// The maximum_core_capacity_units attribute.
    /// </summary>
    public TerraformProperty<double>? MaximumCoreCapacityUnits
    {
        get => GetProperty<TerraformProperty<double>>("maximum_core_capacity_units");
        set => WithProperty("maximum_core_capacity_units", value);
    }

    /// <summary>
    /// The maximum_ondemand_capacity_units attribute.
    /// </summary>
    public TerraformProperty<double>? MaximumOndemandCapacityUnits
    {
        get => GetProperty<TerraformProperty<double>>("maximum_ondemand_capacity_units");
        set => WithProperty("maximum_ondemand_capacity_units", value);
    }

    /// <summary>
    /// The minimum_capacity_units attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MinimumCapacityUnits is required")]
    public required TerraformProperty<double> MinimumCapacityUnits
    {
        get => GetProperty<TerraformProperty<double>>("minimum_capacity_units");
        set => WithProperty("minimum_capacity_units", value);
    }

    /// <summary>
    /// The unit_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "UnitType is required")]
    public required TerraformProperty<string> UnitType
    {
        get => GetProperty<TerraformProperty<string>>("unit_type");
        set => WithProperty("unit_type", value);
    }

}

/// <summary>
/// Manages a aws_emr_managed_scaling_policy resource.
/// </summary>
public class AwsEmrManagedScalingPolicy : TerraformResource
{
    public AwsEmrManagedScalingPolicy(string name) : base("aws_emr_managed_scaling_policy", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
    }

    /// <summary>
    /// The cluster_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ClusterId is required")]
    public required TerraformProperty<string> ClusterId
    {
        get => GetProperty<TerraformProperty<string>>("cluster_id");
        set => this.WithProperty("cluster_id", value);
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
    /// Block for compute_limits.
    /// Nesting mode: set
    /// </summary>
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 ComputeLimits block(s) required")]
    public HashSet<AwsEmrManagedScalingPolicyComputeLimitsBlock>? ComputeLimits
    {
        get => GetProperty<HashSet<AwsEmrManagedScalingPolicyComputeLimitsBlock>>("compute_limits");
        set => this.WithProperty("compute_limits", value);
    }

}

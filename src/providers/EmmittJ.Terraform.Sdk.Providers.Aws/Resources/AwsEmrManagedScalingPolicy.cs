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
        set => SetProperty("maximum_capacity_units", value);
    }

    /// <summary>
    /// The maximum_core_capacity_units attribute.
    /// </summary>
    public TerraformProperty<double>? MaximumCoreCapacityUnits
    {
        set => SetProperty("maximum_core_capacity_units", value);
    }

    /// <summary>
    /// The maximum_ondemand_capacity_units attribute.
    /// </summary>
    public TerraformProperty<double>? MaximumOndemandCapacityUnits
    {
        set => SetProperty("maximum_ondemand_capacity_units", value);
    }

    /// <summary>
    /// The minimum_capacity_units attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MinimumCapacityUnits is required")]
    public required TerraformProperty<double> MinimumCapacityUnits
    {
        set => SetProperty("minimum_capacity_units", value);
    }

    /// <summary>
    /// The unit_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "UnitType is required")]
    public required TerraformProperty<string> UnitType
    {
        set => SetProperty("unit_type", value);
    }

}

/// <summary>
/// Manages a aws_emr_managed_scaling_policy resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AwsEmrManagedScalingPolicy : TerraformResource
{
    public AwsEmrManagedScalingPolicy(string name) : base("aws_emr_managed_scaling_policy", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("cluster_id");
        SetOutput("id");
        SetOutput("region");
    }

    /// <summary>
    /// The cluster_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ClusterId is required")]
    public required TerraformProperty<string> ClusterId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("cluster_id");
        set => SetProperty("cluster_id", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string> Id
    {
        get => GetRequiredOutput<TerraformProperty<string>>("id");
        set => SetProperty("id", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformProperty<string> Region
    {
        get => GetRequiredOutput<TerraformProperty<string>>("region");
        set => SetProperty("region", value);
    }

    /// <summary>
    /// Block for compute_limits.
    /// Nesting mode: set
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ComputeLimits is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 ComputeLimits block(s) required")]
    public HashSet<AwsEmrManagedScalingPolicyComputeLimitsBlock>? ComputeLimits
    {
        set => SetProperty("compute_limits", value);
    }

}

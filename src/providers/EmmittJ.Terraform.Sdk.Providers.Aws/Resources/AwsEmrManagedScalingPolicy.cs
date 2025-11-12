using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for compute_limits in .
/// Nesting mode: set
/// </summary>
public partial class AwsEmrManagedScalingPolicyComputeLimitsBlock() : TerraformBlock("compute_limits")
{
    /// <summary>
    /// The maximum_capacity_units attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MaximumCapacityUnits is required")]
    [TerraformProperty("maximum_capacity_units")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<double> MaximumCapacityUnits { get; set; }

    /// <summary>
    /// The maximum_core_capacity_units attribute.
    /// </summary>
    [TerraformProperty("maximum_core_capacity_units")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<double>? MaximumCoreCapacityUnits { get; set; }

    /// <summary>
    /// The maximum_ondemand_capacity_units attribute.
    /// </summary>
    [TerraformProperty("maximum_ondemand_capacity_units")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<double>? MaximumOndemandCapacityUnits { get; set; }

    /// <summary>
    /// The minimum_capacity_units attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MinimumCapacityUnits is required")]
    [TerraformProperty("minimum_capacity_units")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<double> MinimumCapacityUnits { get; set; }

    /// <summary>
    /// The unit_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "UnitType is required")]
    [TerraformProperty("unit_type")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> UnitType { get; set; }

}

/// <summary>
/// Manages a aws_emr_managed_scaling_policy resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class AwsEmrManagedScalingPolicy : TerraformResource
{
    public AwsEmrManagedScalingPolicy(string name) : base("aws_emr_managed_scaling_policy", name)
    {
    }

    /// <summary>
    /// The cluster_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ClusterId is required")]
    [TerraformProperty("cluster_id")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> ClusterId { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformProperty("region")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Region { get; set; }

    /// <summary>
    /// Block for compute_limits.
    /// Nesting mode: set
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ComputeLimits is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 ComputeLimits block(s) required")]
    [TerraformProperty("compute_limits")]
    public required TerraformSet<AwsEmrManagedScalingPolicyComputeLimitsBlock> ComputeLimits { get; set; } = new();

}

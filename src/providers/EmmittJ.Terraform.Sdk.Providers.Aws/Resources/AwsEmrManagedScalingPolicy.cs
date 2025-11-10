using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for compute_limits in .
/// Nesting mode: set
/// </summary>
public class AwsEmrManagedScalingPolicyComputeLimitsBlock : ITerraformBlock
{
    /// <summary>
    /// The maximum_capacity_units attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MaximumCapacityUnits is required")]
    [TerraformPropertyName("maximum_capacity_units")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<double>> MaximumCapacityUnits { get; set; }

    /// <summary>
    /// The maximum_core_capacity_units attribute.
    /// </summary>
    [TerraformPropertyName("maximum_core_capacity_units")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<double>>? MaximumCoreCapacityUnits { get; set; }

    /// <summary>
    /// The maximum_ondemand_capacity_units attribute.
    /// </summary>
    [TerraformPropertyName("maximum_ondemand_capacity_units")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<double>>? MaximumOndemandCapacityUnits { get; set; }

    /// <summary>
    /// The minimum_capacity_units attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MinimumCapacityUnits is required")]
    [TerraformPropertyName("minimum_capacity_units")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<double>> MinimumCapacityUnits { get; set; }

    /// <summary>
    /// The unit_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "UnitType is required")]
    [TerraformPropertyName("unit_type")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> UnitType { get; set; }

}

/// <summary>
/// Manages a aws_emr_managed_scaling_policy resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AwsEmrManagedScalingPolicy : TerraformResource
{
    public AwsEmrManagedScalingPolicy(string name) : base("aws_emr_managed_scaling_policy", name)
    {
    }

    /// <summary>
    /// The cluster_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ClusterId is required")]
    [TerraformPropertyName("cluster_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> ClusterId { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Region { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "region");

    /// <summary>
    /// Block for compute_limits.
    /// Nesting mode: set
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ComputeLimits is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 ComputeLimits block(s) required")]
    [TerraformPropertyName("compute_limits")]
    public TerraformSet<TerraformBlock<AwsEmrManagedScalingPolicyComputeLimitsBlock>>? ComputeLimits { get; set; } = new();

}

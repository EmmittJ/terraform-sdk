using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for instance_type_configs in .
/// Nesting mode: set
/// </summary>
public class AwsEmrInstanceFleetInstanceTypeConfigsBlock
{
    /// <summary>
    /// The bid_price attribute.
    /// </summary>
    [TerraformPropertyName("bid_price")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? BidPrice { get; set; }

    /// <summary>
    /// The bid_price_as_percentage_of_on_demand_price attribute.
    /// </summary>
    [TerraformPropertyName("bid_price_as_percentage_of_on_demand_price")]
    // Optional argument - user may or may not set a value
    public TerraformValue<double>? BidPriceAsPercentageOfOnDemandPrice { get; set; }

    /// <summary>
    /// The instance_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "InstanceType is required")]
    [TerraformPropertyName("instance_type")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> InstanceType { get; set; }

    /// <summary>
    /// The weighted_capacity attribute.
    /// </summary>
    [TerraformPropertyName("weighted_capacity")]
    // Optional argument - user may or may not set a value
    public TerraformValue<double>? WeightedCapacity { get; set; }

}

/// <summary>
/// Block type for launch_specifications in .
/// Nesting mode: list
/// </summary>
public class AwsEmrInstanceFleetLaunchSpecificationsBlock
{
}

/// <summary>
/// Manages a aws_emr_instance_fleet resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AwsEmrInstanceFleet : TerraformResource
{
    public AwsEmrInstanceFleet(string name) : base("aws_emr_instance_fleet", name)
    {
    }

    /// <summary>
    /// The cluster_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ClusterId is required")]
    [TerraformPropertyName("cluster_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> ClusterId { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Id { get; set; } = default!;

    /// <summary>
    /// The name attribute.
    /// </summary>
    [TerraformPropertyName("name")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Name { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Region { get; set; } = default!;

    /// <summary>
    /// The target_on_demand_capacity attribute.
    /// </summary>
    [TerraformPropertyName("target_on_demand_capacity")]
    // Optional argument - user may or may not set a value
    public TerraformValue<double>? TargetOnDemandCapacity { get; set; }

    /// <summary>
    /// The target_spot_capacity attribute.
    /// </summary>
    [TerraformPropertyName("target_spot_capacity")]
    // Optional argument - user may or may not set a value
    public TerraformValue<double>? TargetSpotCapacity { get; set; }

    /// <summary>
    /// Block for instance_type_configs.
    /// Nesting mode: set
    /// </summary>
    [TerraformPropertyName("instance_type_configs")]
    public TerraformSet<TerraformBlock<AwsEmrInstanceFleetInstanceTypeConfigsBlock>>? InstanceTypeConfigs { get; set; }

    /// <summary>
    /// Block for launch_specifications.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 LaunchSpecifications block(s) allowed")]
    [TerraformPropertyName("launch_specifications")]
    public TerraformList<TerraformBlock<AwsEmrInstanceFleetLaunchSpecificationsBlock>>? LaunchSpecifications { get; set; }

    /// <summary>
    /// The provisioned_on_demand_capacity attribute.
    /// </summary>
    [TerraformPropertyName("provisioned_on_demand_capacity")]
    // Output-only attribute - read-only reference
    public TerraformValue<double> ProvisionedOnDemandCapacity => new TerraformReference(this, "provisioned_on_demand_capacity");

    /// <summary>
    /// The provisioned_spot_capacity attribute.
    /// </summary>
    [TerraformPropertyName("provisioned_spot_capacity")]
    // Output-only attribute - read-only reference
    public TerraformValue<double> ProvisionedSpotCapacity => new TerraformReference(this, "provisioned_spot_capacity");

}

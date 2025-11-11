using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for instance_type_configs in .
/// Nesting mode: set
/// </summary>
public partial class AwsEmrInstanceFleetInstanceTypeConfigsBlock : TerraformBlockBase
{
    /// <summary>
    /// The bid_price attribute.
    /// </summary>
    [TerraformProperty("bid_price")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? BidPrice { get; set; }

    /// <summary>
    /// The bid_price_as_percentage_of_on_demand_price attribute.
    /// </summary>
    [TerraformProperty("bid_price_as_percentage_of_on_demand_price")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<double>? BidPriceAsPercentageOfOnDemandPrice { get; set; }

    /// <summary>
    /// The instance_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "InstanceType is required")]
    [TerraformProperty("instance_type")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> InstanceType { get; set; }

    /// <summary>
    /// The weighted_capacity attribute.
    /// </summary>
    [TerraformProperty("weighted_capacity")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<double>? WeightedCapacity { get; set; }

}

/// <summary>
/// Block type for launch_specifications in .
/// Nesting mode: list
/// </summary>
public partial class AwsEmrInstanceFleetLaunchSpecificationsBlock : TerraformBlockBase
{
}

/// <summary>
/// Manages a aws_emr_instance_fleet resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class AwsEmrInstanceFleet : TerraformResource
{
    public AwsEmrInstanceFleet(string name) : base("aws_emr_instance_fleet", name)
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
    /// The name attribute.
    /// </summary>
    [TerraformProperty("name")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Name { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformProperty("region")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Region { get; set; }

    /// <summary>
    /// The target_on_demand_capacity attribute.
    /// </summary>
    [TerraformProperty("target_on_demand_capacity")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<double>? TargetOnDemandCapacity { get; set; }

    /// <summary>
    /// The target_spot_capacity attribute.
    /// </summary>
    [TerraformProperty("target_spot_capacity")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<double>? TargetSpotCapacity { get; set; }

    /// <summary>
    /// Block for instance_type_configs.
    /// Nesting mode: set
    /// </summary>
    [TerraformProperty("instance_type_configs")]
    public partial TerraformSet<TerraformBlock<AwsEmrInstanceFleetInstanceTypeConfigsBlock>>? InstanceTypeConfigs { get; set; }

    /// <summary>
    /// Block for launch_specifications.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 LaunchSpecifications block(s) allowed")]
    [TerraformProperty("launch_specifications")]
    public partial TerraformList<TerraformBlock<AwsEmrInstanceFleetLaunchSpecificationsBlock>>? LaunchSpecifications { get; set; }

    /// <summary>
    /// The provisioned_on_demand_capacity attribute.
    /// </summary>
    [TerraformProperty("provisioned_on_demand_capacity")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<double> ProvisionedOnDemandCapacity { get; }

    /// <summary>
    /// The provisioned_spot_capacity attribute.
    /// </summary>
    [TerraformProperty("provisioned_spot_capacity")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<double> ProvisionedSpotCapacity { get; }

}

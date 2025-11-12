using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for default_capacity_provider_strategy in .
/// Nesting mode: set
/// </summary>
public partial class AwsEcsClusterCapacityProvidersDefaultCapacityProviderStrategyBlock() : TerraformBlock("default_capacity_provider_strategy")
{
    /// <summary>
    /// The base attribute.
    /// </summary>
    [TerraformProperty("base")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<double>? Base { get; set; }

    /// <summary>
    /// The capacity_provider attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CapacityProvider is required")]
    [TerraformProperty("capacity_provider")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> CapacityProvider { get; set; }

    /// <summary>
    /// The weight attribute.
    /// </summary>
    [TerraformProperty("weight")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<double>? Weight { get; set; }

}

/// <summary>
/// Manages a aws_ecs_cluster_capacity_providers resource.
/// </summary>
public partial class AwsEcsClusterCapacityProviders : TerraformResource
{
    public AwsEcsClusterCapacityProviders(string name) : base("aws_ecs_cluster_capacity_providers", name)
    {
    }

    /// <summary>
    /// The capacity_providers attribute.
    /// </summary>
    [TerraformProperty("capacity_providers")]
    // Optional argument - source generator will implement get/set
    public partial TerraformSet<string>? CapacityProviders { get; set; }

    /// <summary>
    /// The cluster_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ClusterName is required")]
    [TerraformProperty("cluster_name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> ClusterName { get; set; }

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
    /// Block for default_capacity_provider_strategy.
    /// Nesting mode: set
    /// </summary>
    [TerraformProperty("default_capacity_provider_strategy")]
    public TerraformSet<AwsEcsClusterCapacityProvidersDefaultCapacityProviderStrategyBlock> DefaultCapacityProviderStrategy { get; set; } = new();

}

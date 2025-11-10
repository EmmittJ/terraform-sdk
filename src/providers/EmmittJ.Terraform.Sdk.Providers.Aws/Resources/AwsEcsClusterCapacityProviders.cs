using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for default_capacity_provider_strategy in .
/// Nesting mode: set
/// </summary>
public class AwsEcsClusterCapacityProvidersDefaultCapacityProviderStrategyBlock : ITerraformBlock
{
    /// <summary>
    /// The base attribute.
    /// </summary>
    [TerraformPropertyName("base")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<double>>? Base { get; set; }

    /// <summary>
    /// The capacity_provider attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CapacityProvider is required")]
    [TerraformPropertyName("capacity_provider")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> CapacityProvider { get; set; }

    /// <summary>
    /// The weight attribute.
    /// </summary>
    [TerraformPropertyName("weight")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<double>>? Weight { get; set; }

}

/// <summary>
/// Manages a aws_ecs_cluster_capacity_providers resource.
/// </summary>
public class AwsEcsClusterCapacityProviders : TerraformResource
{
    public AwsEcsClusterCapacityProviders(string name) : base("aws_ecs_cluster_capacity_providers", name)
    {
    }

    /// <summary>
    /// The capacity_providers attribute.
    /// </summary>
    [TerraformPropertyName("capacity_providers")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<HashSet<TerraformProperty<string>>>? CapacityProviders { get; set; }

    /// <summary>
    /// The cluster_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ClusterName is required")]
    [TerraformPropertyName("cluster_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> ClusterName { get; set; }

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
    /// Block for default_capacity_provider_strategy.
    /// Nesting mode: set
    /// </summary>
    [TerraformPropertyName("default_capacity_provider_strategy")]
    public TerraformSet<TerraformBlock<AwsEcsClusterCapacityProvidersDefaultCapacityProviderStrategyBlock>>? DefaultCapacityProviderStrategy { get; set; } = new();

}

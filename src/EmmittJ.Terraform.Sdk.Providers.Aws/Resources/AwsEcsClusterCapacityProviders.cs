using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for default_capacity_provider_strategy in .
/// Nesting mode: set
/// </summary>
public class AwsEcsClusterCapacityProvidersDefaultCapacityProviderStrategyBlock : TerraformBlock
{
    /// <summary>
    /// The base attribute.
    /// </summary>
    public TerraformProperty<double>? Base
    {
        get => GetProperty<TerraformProperty<double>>("base");
        set => WithProperty("base", value);
    }

    /// <summary>
    /// The capacity_provider attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CapacityProvider is required")]
    public required TerraformProperty<string> CapacityProvider
    {
        get => GetProperty<TerraformProperty<string>>("capacity_provider");
        set => WithProperty("capacity_provider", value);
    }

    /// <summary>
    /// The weight attribute.
    /// </summary>
    public TerraformProperty<double>? Weight
    {
        get => GetProperty<TerraformProperty<double>>("weight");
        set => WithProperty("weight", value);
    }

}

/// <summary>
/// Manages a aws_ecs_cluster_capacity_providers resource.
/// </summary>
public class AwsEcsClusterCapacityProviders : TerraformResource
{
    public AwsEcsClusterCapacityProviders(string name) : base("aws_ecs_cluster_capacity_providers", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
    }

    /// <summary>
    /// The capacity_providers attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>>? CapacityProviders
    {
        get => GetProperty<HashSet<TerraformProperty<string>>>("capacity_providers");
        set => this.WithProperty("capacity_providers", value);
    }

    /// <summary>
    /// The cluster_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ClusterName is required")]
    public required TerraformProperty<string> ClusterName
    {
        get => GetProperty<TerraformProperty<string>>("cluster_name");
        set => this.WithProperty("cluster_name", value);
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
    /// Block for default_capacity_provider_strategy.
    /// Nesting mode: set
    /// </summary>
    public HashSet<AwsEcsClusterCapacityProvidersDefaultCapacityProviderStrategyBlock>? DefaultCapacityProviderStrategy
    {
        get => GetProperty<HashSet<AwsEcsClusterCapacityProvidersDefaultCapacityProviderStrategyBlock>>("default_capacity_provider_strategy");
        set => this.WithProperty("default_capacity_provider_strategy", value);
    }

}

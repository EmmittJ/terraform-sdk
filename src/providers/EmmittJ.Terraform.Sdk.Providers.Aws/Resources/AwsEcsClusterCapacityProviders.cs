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
        set => SetProperty("base", value);
    }

    /// <summary>
    /// The capacity_provider attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CapacityProvider is required")]
    public required TerraformProperty<string> CapacityProvider
    {
        set => SetProperty("capacity_provider", value);
    }

    /// <summary>
    /// The weight attribute.
    /// </summary>
    public TerraformProperty<double>? Weight
    {
        set => SetProperty("weight", value);
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
        SetOutput("capacity_providers");
        SetOutput("cluster_name");
        SetOutput("id");
        SetOutput("region");
    }

    /// <summary>
    /// The capacity_providers attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>> CapacityProviders
    {
        get => GetRequiredOutput<HashSet<TerraformProperty<string>>>("capacity_providers");
        set => SetProperty("capacity_providers", value);
    }

    /// <summary>
    /// The cluster_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ClusterName is required")]
    public required TerraformProperty<string> ClusterName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("cluster_name");
        set => SetProperty("cluster_name", value);
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
    /// Block for default_capacity_provider_strategy.
    /// Nesting mode: set
    /// </summary>
    public HashSet<AwsEcsClusterCapacityProvidersDefaultCapacityProviderStrategyBlock>? DefaultCapacityProviderStrategy
    {
        set => SetProperty("default_capacity_provider_strategy", value);
    }

}

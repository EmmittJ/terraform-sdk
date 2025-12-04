using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for default_capacity_provider_strategy in AwsEcsClusterCapacityProviders.
/// Nesting mode: set
/// </summary>
public class AwsEcsClusterCapacityProvidersDefaultCapacityProviderStrategyBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "default_capacity_provider_strategy";

    /// <summary>
    /// The base attribute.
    /// </summary>
    public TerraformValue<double>? BaseAttribute
    {
        get => GetArgument<TerraformValue<double>>("base");
        set => SetArgument("base", value);
    }

    /// <summary>
    /// The capacity_provider attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CapacityProvider is required")]
    public required TerraformValue<string> CapacityProvider
    {
        get => GetArgument<TerraformValue<string>>("capacity_provider");
        set => SetArgument("capacity_provider", value);
    }

    /// <summary>
    /// The weight attribute.
    /// </summary>
    public TerraformValue<double>? Weight
    {
        get => GetArgument<TerraformValue<double>>("weight");
        set => SetArgument("weight", value);
    }

}


/// <summary>
/// Represents a aws_ecs_cluster_capacity_providers Terraform resource.
/// Manages a aws_ecs_cluster_capacity_providers resource.
/// </summary>
public partial class AwsEcsClusterCapacityProviders(string name) : TerraformResource("aws_ecs_cluster_capacity_providers", name)
{
    /// <summary>
    /// The capacity_providers attribute.
    /// </summary>
    public TerraformSet<string>? CapacityProviders
    {
        get => GetArgument<TerraformSet<string>>("capacity_providers");
        set => SetArgument("capacity_providers", value);
    }

    /// <summary>
    /// The cluster_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ClusterName is required")]
    public required TerraformValue<string> ClusterName
    {
        get => GetArgument<TerraformValue<string>>("cluster_name");
        set => SetArgument("cluster_name", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string>? Id
    {
        get => GetArgument<TerraformValue<string>>("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string>? Region
    {
        get => GetArgument<TerraformValue<string>>("region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// DefaultCapacityProviderStrategy block (nesting mode: set).
    /// </summary>
    public TerraformSet<AwsEcsClusterCapacityProvidersDefaultCapacityProviderStrategyBlock>? DefaultCapacityProviderStrategy
    {
        get => GetArgument<TerraformSet<AwsEcsClusterCapacityProvidersDefaultCapacityProviderStrategyBlock>>("default_capacity_provider_strategy");
        set => SetArgument("default_capacity_provider_strategy", value);
    }

}

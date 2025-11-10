using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for instance_type_configs in .
/// Nesting mode: set
/// </summary>
public class AwsEmrInstanceFleetInstanceTypeConfigsBlock : TerraformBlock
{
    /// <summary>
    /// The bid_price attribute.
    /// </summary>
    public TerraformProperty<string>? BidPrice
    {
        set => SetProperty("bid_price", value);
    }

    /// <summary>
    /// The bid_price_as_percentage_of_on_demand_price attribute.
    /// </summary>
    public TerraformProperty<double>? BidPriceAsPercentageOfOnDemandPrice
    {
        set => SetProperty("bid_price_as_percentage_of_on_demand_price", value);
    }

    /// <summary>
    /// The instance_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "InstanceType is required")]
    public required TerraformProperty<string> InstanceType
    {
        set => SetProperty("instance_type", value);
    }

    /// <summary>
    /// The weighted_capacity attribute.
    /// </summary>
    public TerraformProperty<double>? WeightedCapacity
    {
        set => SetProperty("weighted_capacity", value);
    }

}

/// <summary>
/// Block type for launch_specifications in .
/// Nesting mode: list
/// </summary>
public class AwsEmrInstanceFleetLaunchSpecificationsBlock : TerraformBlock
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
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("provisioned_on_demand_capacity");
        SetOutput("provisioned_spot_capacity");
        SetOutput("cluster_id");
        SetOutput("id");
        SetOutput("name");
        SetOutput("region");
        SetOutput("target_on_demand_capacity");
        SetOutput("target_spot_capacity");
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
    /// The name attribute.
    /// </summary>
    public TerraformProperty<string> Name
    {
        get => GetRequiredOutput<TerraformProperty<string>>("name");
        set => SetProperty("name", value);
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
    /// The target_on_demand_capacity attribute.
    /// </summary>
    public TerraformProperty<double> TargetOnDemandCapacity
    {
        get => GetRequiredOutput<TerraformProperty<double>>("target_on_demand_capacity");
        set => SetProperty("target_on_demand_capacity", value);
    }

    /// <summary>
    /// The target_spot_capacity attribute.
    /// </summary>
    public TerraformProperty<double> TargetSpotCapacity
    {
        get => GetRequiredOutput<TerraformProperty<double>>("target_spot_capacity");
        set => SetProperty("target_spot_capacity", value);
    }

    /// <summary>
    /// Block for instance_type_configs.
    /// Nesting mode: set
    /// </summary>
    public HashSet<AwsEmrInstanceFleetInstanceTypeConfigsBlock>? InstanceTypeConfigs
    {
        set => SetProperty("instance_type_configs", value);
    }

    /// <summary>
    /// Block for launch_specifications.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 LaunchSpecifications block(s) allowed")]
    public List<AwsEmrInstanceFleetLaunchSpecificationsBlock>? LaunchSpecifications
    {
        set => SetProperty("launch_specifications", value);
    }

    /// <summary>
    /// The provisioned_on_demand_capacity attribute.
    /// </summary>
    public TerraformExpression ProvisionedOnDemandCapacity => this["provisioned_on_demand_capacity"];

    /// <summary>
    /// The provisioned_spot_capacity attribute.
    /// </summary>
    public TerraformExpression ProvisionedSpotCapacity => this["provisioned_spot_capacity"];

}

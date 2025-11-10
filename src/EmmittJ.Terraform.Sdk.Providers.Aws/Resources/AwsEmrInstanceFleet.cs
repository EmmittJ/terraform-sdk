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
        get => GetProperty<TerraformProperty<string>>("bid_price");
        set => WithProperty("bid_price", value);
    }

    /// <summary>
    /// The bid_price_as_percentage_of_on_demand_price attribute.
    /// </summary>
    public TerraformProperty<double>? BidPriceAsPercentageOfOnDemandPrice
    {
        get => GetProperty<TerraformProperty<double>>("bid_price_as_percentage_of_on_demand_price");
        set => WithProperty("bid_price_as_percentage_of_on_demand_price", value);
    }

    /// <summary>
    /// The instance_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "InstanceType is required")]
    public required TerraformProperty<string> InstanceType
    {
        get => GetProperty<TerraformProperty<string>>("instance_type");
        set => WithProperty("instance_type", value);
    }

    /// <summary>
    /// The weighted_capacity attribute.
    /// </summary>
    public TerraformProperty<double>? WeightedCapacity
    {
        get => GetProperty<TerraformProperty<double>>("weighted_capacity");
        set => WithProperty("weighted_capacity", value);
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
        this.DeclareOutput("provisioned_on_demand_capacity");
        this.DeclareOutput("provisioned_spot_capacity");
    }

    /// <summary>
    /// The cluster_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ClusterId is required")]
    public required TerraformProperty<string> ClusterId
    {
        get => GetProperty<TerraformProperty<string>>("cluster_id");
        set => this.WithProperty("cluster_id", value);
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
    /// The name attribute.
    /// </summary>
    public TerraformProperty<string>? Name
    {
        get => GetProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
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
    /// The target_on_demand_capacity attribute.
    /// </summary>
    public TerraformProperty<double>? TargetOnDemandCapacity
    {
        get => GetProperty<TerraformProperty<double>>("target_on_demand_capacity");
        set => this.WithProperty("target_on_demand_capacity", value);
    }

    /// <summary>
    /// The target_spot_capacity attribute.
    /// </summary>
    public TerraformProperty<double>? TargetSpotCapacity
    {
        get => GetProperty<TerraformProperty<double>>("target_spot_capacity");
        set => this.WithProperty("target_spot_capacity", value);
    }

    /// <summary>
    /// Block for instance_type_configs.
    /// Nesting mode: set
    /// </summary>
    public HashSet<AwsEmrInstanceFleetInstanceTypeConfigsBlock>? InstanceTypeConfigs
    {
        get => GetProperty<HashSet<AwsEmrInstanceFleetInstanceTypeConfigsBlock>>("instance_type_configs");
        set => this.WithProperty("instance_type_configs", value);
    }

    /// <summary>
    /// Block for launch_specifications.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 LaunchSpecifications block(s) allowed")]
    public List<AwsEmrInstanceFleetLaunchSpecificationsBlock>? LaunchSpecifications
    {
        get => GetProperty<List<AwsEmrInstanceFleetLaunchSpecificationsBlock>>("launch_specifications");
        set => this.WithProperty("launch_specifications", value);
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

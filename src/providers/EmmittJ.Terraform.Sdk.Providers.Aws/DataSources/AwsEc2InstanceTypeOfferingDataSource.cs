using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for filter in .
/// Nesting mode: set
/// </summary>
public class AwsEc2InstanceTypeOfferingDataSourceFilterBlock : TerraformBlock
{
    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetRequiredProperty<TerraformProperty<string>>("name");
        set => WithProperty("name", value);
    }

    /// <summary>
    /// The values attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Values is required")]
    public HashSet<TerraformProperty<string>>? Values
    {
        get => GetProperty<HashSet<TerraformProperty<string>>>("values");
        set => WithProperty("values", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AwsEc2InstanceTypeOfferingDataSourceTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformProperty<string>? Read
    {
        get => GetProperty<TerraformProperty<string>>("read");
        set => WithProperty("read", value);
    }

}

/// <summary>
/// Retrieves information about a aws_ec2_instance_type_offering.
/// </summary>
public class AwsEc2InstanceTypeOfferingDataSource : TerraformDataSource
{
    public AwsEc2InstanceTypeOfferingDataSource(string name) : base("aws_ec2_instance_type_offering", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.WithOutput("instance_type");
        this.WithOutput("location");
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
    /// The location_type attribute.
    /// </summary>
    public TerraformProperty<string>? LocationType
    {
        get => GetProperty<TerraformProperty<string>>("location_type");
        set => this.WithProperty("location_type", value);
    }

    /// <summary>
    /// The preferred_instance_types attribute.
    /// </summary>
    public List<TerraformProperty<string>>? PreferredInstanceTypes
    {
        get => GetProperty<List<TerraformProperty<string>>>("preferred_instance_types");
        set => this.WithProperty("preferred_instance_types", value);
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
    /// Block for filter.
    /// Nesting mode: set
    /// </summary>
    public HashSet<AwsEc2InstanceTypeOfferingDataSourceFilterBlock>? Filter
    {
        get => GetProperty<HashSet<AwsEc2InstanceTypeOfferingDataSourceFilterBlock>>("filter");
        set => this.WithProperty("filter", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AwsEc2InstanceTypeOfferingDataSourceTimeoutsBlock? Timeouts
    {
        get => GetProperty<AwsEc2InstanceTypeOfferingDataSourceTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
    }

    /// <summary>
    /// The instance_type attribute.
    /// </summary>
    public TerraformExpression InstanceType => this["instance_type"];

    /// <summary>
    /// The location attribute.
    /// </summary>
    public TerraformExpression Location => this["location"];

}

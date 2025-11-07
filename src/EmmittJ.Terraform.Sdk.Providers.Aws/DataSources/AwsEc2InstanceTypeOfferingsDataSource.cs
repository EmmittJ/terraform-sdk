using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_ec2_instance_type_offerings.
/// </summary>
public class AwsEc2InstanceTypeOfferingsDataSource : TerraformDataSource
{
    public AwsEc2InstanceTypeOfferingsDataSource(string name) : base("aws_ec2_instance_type_offerings", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("instance_types");
        this.DeclareOutput("location_types");
        this.DeclareOutput("locations");
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
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformProperty<string>? Region
    {
        get => GetProperty<TerraformProperty<string>>("region");
        set => this.WithProperty("region", value);
    }

    /// <summary>
    /// The instance_types attribute.
    /// </summary>
    public TerraformExpression InstanceTypes => this["instance_types"];

    /// <summary>
    /// The location_types attribute.
    /// </summary>
    public TerraformExpression LocationTypes => this["location_types"];

    /// <summary>
    /// The locations attribute.
    /// </summary>
    public TerraformExpression Locations => this["locations"];

}

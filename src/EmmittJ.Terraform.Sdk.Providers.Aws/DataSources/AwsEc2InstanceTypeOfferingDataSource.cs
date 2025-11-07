using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

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
        this.DeclareOutput("instance_type");
        this.DeclareOutput("location");
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// The location_type attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? LocationType
    {
        get => GetProperty<TerraformLiteralProperty<string>>("location_type");
        set => this.WithProperty("location_type", value);
    }

    /// <summary>
    /// The preferred_instance_types attribute.
    /// </summary>
    public TerraformLiteralProperty<List<string>>? PreferredInstanceTypes
    {
        get => GetProperty<TerraformLiteralProperty<List<string>>>("preferred_instance_types");
        set => this.WithProperty("preferred_instance_types", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformLiteralProperty<string>? Region
    {
        get => GetProperty<TerraformLiteralProperty<string>>("region");
        set => this.WithProperty("region", value);
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

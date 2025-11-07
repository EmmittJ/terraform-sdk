using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_ec2_spot_price.
/// </summary>
public class AwsEc2SpotPriceDataSource : TerraformDataSource
{
    public AwsEc2SpotPriceDataSource(string name) : base("aws_ec2_spot_price", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("spot_price");
        this.DeclareOutput("spot_price_timestamp");
    }

    /// <summary>
    /// The availability_zone attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? AvailabilityZone
    {
        get => GetProperty<TerraformLiteralProperty<string>>("availability_zone");
        set => this.WithProperty("availability_zone", value);
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
    /// The instance_type attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? InstanceType
    {
        get => GetProperty<TerraformLiteralProperty<string>>("instance_type");
        set => this.WithProperty("instance_type", value);
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
    /// The spot_price attribute.
    /// </summary>
    public TerraformExpression SpotPrice => this["spot_price"];

    /// <summary>
    /// The spot_price_timestamp attribute.
    /// </summary>
    public TerraformExpression SpotPriceTimestamp => this["spot_price_timestamp"];

}

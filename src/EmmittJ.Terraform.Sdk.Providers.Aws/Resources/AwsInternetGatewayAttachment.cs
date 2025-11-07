using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_internet_gateway_attachment resource.
/// </summary>
public class AwsInternetGatewayAttachment : TerraformResource
{
    public AwsInternetGatewayAttachment(string name) : base("aws_internet_gateway_attachment", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
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
    /// The internet_gateway_id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? InternetGatewayId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("internet_gateway_id");
        set => this.WithProperty("internet_gateway_id", value);
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
    /// The vpc_id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? VpcId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("vpc_id");
        set => this.WithProperty("vpc_id", value);
    }

}

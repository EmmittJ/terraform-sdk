using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_vpc_block_public_access_options resource.
/// </summary>
public class AwsVpcBlockPublicAccessOptions : TerraformResource
{
    public AwsVpcBlockPublicAccessOptions(string name) : base("aws_vpc_block_public_access_options", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("aws_account_id");
        this.DeclareOutput("aws_region");
        this.DeclareOutput("id");
    }

    /// <summary>
    /// The internet_gateway_block_mode attribute.
    /// </summary>
    public string? InternetGatewayBlockMode
    {
        get => GetProperty<TerraformLiteralProperty<string>>("internet_gateway_block_mode")?.Value;
        set => this.WithProperty("internet_gateway_block_mode", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public string? Region
    {
        get => GetProperty<TerraformLiteralProperty<string>>("region")?.Value;
        set => this.WithProperty("region", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The aws_account_id attribute.
    /// </summary>
    public TerraformExpression AwsAccountId => this["aws_account_id"];

    /// <summary>
    /// The aws_region attribute.
    /// </summary>
    public TerraformExpression AwsRegion => this["aws_region"];

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformExpression Id => this["id"];

}

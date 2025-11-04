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

using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_api_gateway_api_keys.
/// </summary>
public class AwsApiGatewayApiKeysDataSource : TerraformDataSource
{
    public AwsApiGatewayApiKeysDataSource(string name) : base("aws_api_gateway_api_keys", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("id");
        this.DeclareOutput("items");
    }

    /// <summary>
    /// The customer_id attribute.
    /// </summary>
    public string? CustomerId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("customer_id")?.Value;
        set => this.WithProperty("customer_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The include_values attribute.
    /// </summary>
    public bool? IncludeValues
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("include_values")?.Value;
        set => this.WithProperty("include_values", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
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
    /// The id attribute.
    /// </summary>
    public TerraformExpression Id => this["id"];

    /// <summary>
    /// The items attribute.
    /// </summary>
    public TerraformExpression Items => this["items"];

}

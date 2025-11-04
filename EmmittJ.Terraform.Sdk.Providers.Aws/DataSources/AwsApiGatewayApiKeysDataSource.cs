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
    /// The id attribute.
    /// </summary>
    public TerraformExpression Id => this["id"];

    /// <summary>
    /// The items attribute.
    /// </summary>
    public TerraformExpression Items => this["items"];

}

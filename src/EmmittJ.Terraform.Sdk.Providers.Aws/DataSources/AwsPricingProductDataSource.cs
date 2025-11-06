using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_pricing_product.
/// </summary>
public class AwsPricingProductDataSource : TerraformDataSource
{
    public AwsPricingProductDataSource(string name) : base("aws_pricing_product", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("result");
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public string? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id")?.Value;
        set => this.WithProperty("id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The service_code attribute.
    /// </summary>
    public string? ServiceCode
    {
        get => GetProperty<TerraformLiteralProperty<string>>("service_code")?.Value;
        set => this.WithProperty("service_code", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The result attribute.
    /// </summary>
    public TerraformExpression Result => this["result"];

}

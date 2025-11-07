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
    public TerraformProperty<string>? Id
    {
        get => GetProperty<TerraformProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// The service_code attribute.
    /// </summary>
    public TerraformProperty<string>? ServiceCode
    {
        get => GetProperty<TerraformProperty<string>>("service_code");
        set => this.WithProperty("service_code", value);
    }

    /// <summary>
    /// The result attribute.
    /// </summary>
    public TerraformExpression Result => this["result"];

}

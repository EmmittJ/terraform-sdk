using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for filters in .
/// Nesting mode: list
/// </summary>
public class AwsPricingProductDataSourceFiltersBlock : TerraformBlock
{
    /// <summary>
    /// The field attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Field is required")]
    public required TerraformProperty<string> Field
    {
        get => GetProperty<TerraformProperty<string>>("field");
        set => WithProperty("field", value);
    }

    /// <summary>
    /// The value attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Value is required")]
    public required TerraformProperty<string> Value
    {
        get => GetProperty<TerraformProperty<string>>("value");
        set => WithProperty("value", value);
    }

}

/// <summary>
/// Retrieves information about a aws_pricing_product.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
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
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ServiceCode is required")]
    public required TerraformProperty<string> ServiceCode
    {
        get => GetProperty<TerraformProperty<string>>("service_code");
        set => this.WithProperty("service_code", value);
    }

    /// <summary>
    /// Block for filters.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Filters block(s) required")]
    public List<AwsPricingProductDataSourceFiltersBlock>? Filters
    {
        get => GetProperty<List<AwsPricingProductDataSourceFiltersBlock>>("filters");
        set => this.WithProperty("filters", value);
    }

    /// <summary>
    /// The result attribute.
    /// </summary>
    public TerraformExpression Result => this["result"];

}

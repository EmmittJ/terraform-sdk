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
        set => SetProperty("field", value);
    }

    /// <summary>
    /// The value attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Value is required")]
    public required TerraformProperty<string> Value
    {
        set => SetProperty("value", value);
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
        SetOutput("result");
        SetOutput("id");
        SetOutput("service_code");
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string> Id
    {
        get => GetRequiredOutput<TerraformProperty<string>>("id");
        set => SetProperty("id", value);
    }

    /// <summary>
    /// The service_code attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ServiceCode is required")]
    public required TerraformProperty<string> ServiceCode
    {
        get => GetRequiredOutput<TerraformProperty<string>>("service_code");
        set => SetProperty("service_code", value);
    }

    /// <summary>
    /// Block for filters.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Filters is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Filters block(s) required")]
    public List<AwsPricingProductDataSourceFiltersBlock>? Filters
    {
        set => SetProperty("filters", value);
    }

    /// <summary>
    /// The result attribute.
    /// </summary>
    public TerraformExpression Result => this["result"];

}

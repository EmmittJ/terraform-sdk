using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for filters in AwsPricingProductDataSource.
/// Nesting mode: list
/// </summary>
public class AwsPricingProductDataSourceFiltersBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "filters";

    /// <summary>
    /// The field attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Field is required")]
    public required TerraformValue<string> Field
    {
        get => GetRequiredArgument<TerraformValue<string>>("field");
        set => SetArgument("field", value);
    }

    /// <summary>
    /// The value attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Value is required")]
    public required TerraformValue<string> Value
    {
        get => GetRequiredArgument<TerraformValue<string>>("value");
        set => SetArgument("value", value);
    }

}


/// <summary>
/// Represents a aws_pricing_product Terraform data source.
/// Retrieves information about a aws_pricing_product.
/// </summary>
public partial class AwsPricingProductDataSource(string name) : TerraformDataSource("aws_pricing_product", name)
{
    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => GetArgument<TerraformValue<string>>("id") ?? AsReference("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The service_code attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ServiceCode is required")]
    public required TerraformValue<string> ServiceCode
    {
        get => GetRequiredArgument<TerraformValue<string>>("service_code");
        set => SetArgument("service_code", value);
    }

    /// <summary>
    /// The result attribute.
    /// </summary>
    public TerraformValue<string> Result
        => AsReference("result");

    /// <summary>
    /// Filters block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Filters is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Filters block(s) required")]
    public required TerraformList<AwsPricingProductDataSourceFiltersBlock> Filters
    {
        get => GetRequiredArgument<TerraformList<AwsPricingProductDataSourceFiltersBlock>>("filters");
        set => SetArgument("filters", value);
    }

}

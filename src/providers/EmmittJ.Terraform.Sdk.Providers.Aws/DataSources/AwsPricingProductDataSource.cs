using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for filters in .
/// Nesting mode: list
/// </summary>
public partial class AwsPricingProductDataSourceFiltersBlock : TerraformBlockBase
{
    /// <summary>
    /// The field attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Field is required")]
    [TerraformProperty("field")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Field { get; set; }

    /// <summary>
    /// The value attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Value is required")]
    [TerraformProperty("value")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Value { get; set; }

}

/// <summary>
/// Retrieves information about a aws_pricing_product.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class AwsPricingProductDataSource : TerraformDataSource
{
    public AwsPricingProductDataSource(string name) : base("aws_pricing_product", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The service_code attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ServiceCode is required")]
    [TerraformProperty("service_code")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> ServiceCode { get; set; }

    /// <summary>
    /// Block for filters.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Filters is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Filters block(s) required")]
    [TerraformProperty("filters")]
    public partial TerraformList<TerraformBlock<AwsPricingProductDataSourceFiltersBlock>>? Filters { get; set; }

    /// <summary>
    /// The result attribute.
    /// </summary>
    [TerraformProperty("result")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Result { get; }

}

using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AwsServicecatalogPortfolioConstraintsDataSourceTimeoutsBlock : ITerraformBlock
{
    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformPropertyName("read")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Read { get; set; }

}

/// <summary>
/// Retrieves information about a aws_servicecatalog_portfolio_constraints.
/// </summary>
public class AwsServicecatalogPortfolioConstraintsDataSource : TerraformDataSource
{
    public AwsServicecatalogPortfolioConstraintsDataSource(string name) : base("aws_servicecatalog_portfolio_constraints", name)
    {
    }

    /// <summary>
    /// The accept_language attribute.
    /// </summary>
    [TerraformPropertyName("accept_language")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? AcceptLanguage { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// The portfolio_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PortfolioId is required")]
    [TerraformPropertyName("portfolio_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> PortfolioId { get; set; }

    /// <summary>
    /// The product_id attribute.
    /// </summary>
    [TerraformPropertyName("product_id")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? ProductId { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Region { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "region");

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AwsServicecatalogPortfolioConstraintsDataSourceTimeoutsBlock>? Timeouts { get; set; } = new();

    /// <summary>
    /// The details attribute.
    /// </summary>
    [TerraformPropertyName("details")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> Details => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "details");

}

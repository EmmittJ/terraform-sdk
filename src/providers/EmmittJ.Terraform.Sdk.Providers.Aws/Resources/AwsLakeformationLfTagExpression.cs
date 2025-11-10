using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for expression in .
/// Nesting mode: set
/// </summary>
public class AwsLakeformationLfTagExpressionExpressionBlock : ITerraformBlock
{
    /// <summary>
    /// The tag_key attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TagKey is required")]
    [TerraformPropertyName("tag_key")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> TagKey { get; set; }

    /// <summary>
    /// The tag_values attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TagValues is required")]
    [TerraformPropertyName("tag_values")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public TerraformProperty<HashSet<TerraformProperty<string>>>? TagValues { get; set; }

}

/// <summary>
/// Manages an AWS Lake Formation Tag Expression.
/// </summary>
public class AwsLakeformationLfTagExpression : TerraformResource
{
    public AwsLakeformationLfTagExpression(string name) : base("aws_lakeformation_lf_tag_expression", name)
    {
    }

    /// <summary>
    /// The ID of the Data Catalog.
    /// </summary>
    [TerraformPropertyName("catalog_id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> CatalogId { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "catalog_id");

    /// <summary>
    /// A description of the LF-Tag Expression.
    /// </summary>
    [TerraformPropertyName("description")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Description { get; set; }

    /// <summary>
    /// The name of the LF-Tag Expression.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Name { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Region { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "region");

    /// <summary>
    /// Block for expression.
    /// Nesting mode: set
    /// </summary>
    [TerraformPropertyName("expression")]
    public TerraformSet<TerraformBlock<AwsLakeformationLfTagExpressionExpressionBlock>>? Expression { get; set; } = new();

}

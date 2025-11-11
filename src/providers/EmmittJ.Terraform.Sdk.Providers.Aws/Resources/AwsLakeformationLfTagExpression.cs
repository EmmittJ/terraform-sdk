using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for expression in .
/// Nesting mode: set
/// </summary>
public partial class AwsLakeformationLfTagExpressionExpressionBlock : TerraformBlockBase
{
    /// <summary>
    /// The tag_key attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TagKey is required")]
    [TerraformProperty("tag_key")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> TagKey { get; set; }

    /// <summary>
    /// The tag_values attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TagValues is required")]
    [TerraformProperty("tag_values")]
    // Required argument - source generator will implement get/set
    public required partial TerraformSet<string> TagValues { get; set; }

}

/// <summary>
/// Manages an AWS Lake Formation Tag Expression.
/// </summary>
public partial class AwsLakeformationLfTagExpression : TerraformResource
{
    public AwsLakeformationLfTagExpression(string name) : base("aws_lakeformation_lf_tag_expression", name)
    {
    }

    /// <summary>
    /// The ID of the Data Catalog.
    /// </summary>
    [TerraformProperty("catalog_id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> CatalogId { get; set; }

    /// <summary>
    /// A description of the LF-Tag Expression.
    /// </summary>
    [TerraformProperty("description")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Description { get; set; }

    /// <summary>
    /// The name of the LF-Tag Expression.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Name { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformProperty("region")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Region { get; set; }

    /// <summary>
    /// Block for expression.
    /// Nesting mode: set
    /// </summary>
    [TerraformProperty("expression")]
    public partial TerraformSet<TerraformBlock<AwsLakeformationLfTagExpressionExpressionBlock>>? Expression { get; set; }

}

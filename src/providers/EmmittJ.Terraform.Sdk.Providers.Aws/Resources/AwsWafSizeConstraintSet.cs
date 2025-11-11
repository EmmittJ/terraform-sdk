using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for size_constraints in .
/// Nesting mode: set
/// </summary>
public partial class AwsWafSizeConstraintSetSizeConstraintsBlock : TerraformBlockBase
{
    /// <summary>
    /// The comparison_operator attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ComparisonOperator is required")]
    [TerraformProperty("comparison_operator")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> ComparisonOperator { get; set; }

    /// <summary>
    /// The size attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Size is required")]
    [TerraformProperty("size")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<double> Size { get; set; }

    /// <summary>
    /// The text_transformation attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TextTransformation is required")]
    [TerraformProperty("text_transformation")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> TextTransformation { get; set; }

}

/// <summary>
/// Manages a aws_waf_size_constraint_set resource.
/// </summary>
public partial class AwsWafSizeConstraintSet : TerraformResource
{
    public AwsWafSizeConstraintSet(string name) : base("aws_waf_size_constraint_set", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Name { get; set; }

    /// <summary>
    /// Block for size_constraints.
    /// Nesting mode: set
    /// </summary>
    [TerraformProperty("size_constraints")]
    public partial TerraformSet<TerraformBlock<AwsWafSizeConstraintSetSizeConstraintsBlock>>? SizeConstraints { get; set; }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformProperty("arn")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Arn { get; }

}

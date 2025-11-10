using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for byte_match_tuples in .
/// Nesting mode: set
/// </summary>
public class AwsWafByteMatchSetByteMatchTuplesBlock : ITerraformBlock
{
    /// <summary>
    /// The positional_constraint attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PositionalConstraint is required")]
    [TerraformPropertyName("positional_constraint")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> PositionalConstraint { get; set; }

    /// <summary>
    /// The target_string attribute.
    /// </summary>
    [TerraformPropertyName("target_string")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? TargetString { get; set; }

    /// <summary>
    /// The text_transformation attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TextTransformation is required")]
    [TerraformPropertyName("text_transformation")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> TextTransformation { get; set; }

}

/// <summary>
/// Manages a aws_waf_byte_match_set resource.
/// </summary>
public class AwsWafByteMatchSet : TerraformResource
{
    public AwsWafByteMatchSet(string name) : base("aws_waf_byte_match_set", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Name { get; set; }

    /// <summary>
    /// Block for byte_match_tuples.
    /// Nesting mode: set
    /// </summary>
    [TerraformPropertyName("byte_match_tuples")]
    public TerraformSet<TerraformBlock<AwsWafByteMatchSetByteMatchTuplesBlock>>? ByteMatchTuples { get; set; } = new();

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformPropertyName("arn")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Arn => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "arn");

}

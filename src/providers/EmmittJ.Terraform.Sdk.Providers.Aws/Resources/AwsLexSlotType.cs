using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for enumeration_value in .
/// Nesting mode: set
/// </summary>
public class AwsLexSlotTypeEnumerationValueBlock : ITerraformBlock
{
    /// <summary>
    /// The synonyms attribute.
    /// </summary>
    [TerraformPropertyName("synonyms")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<HashSet<TerraformProperty<string>>>? Synonyms { get; set; }

    /// <summary>
    /// The value attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Value is required")]
    [TerraformPropertyName("value")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Value { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AwsLexSlotTypeTimeoutsBlock : ITerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformPropertyName("create")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformPropertyName("delete")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Delete { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformPropertyName("update")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Update { get; set; }

}

/// <summary>
/// Manages a aws_lex_slot_type resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AwsLexSlotType : TerraformResource
{
    public AwsLexSlotType(string name) : base("aws_lex_slot_type", name)
    {
    }

    /// <summary>
    /// The create_version attribute.
    /// </summary>
    [TerraformPropertyName("create_version")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? CreateVersion { get; set; }

    /// <summary>
    /// The description attribute.
    /// </summary>
    [TerraformPropertyName("description")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Description { get; set; }

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
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Region { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "region");

    /// <summary>
    /// The value_selection_strategy attribute.
    /// </summary>
    [TerraformPropertyName("value_selection_strategy")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? ValueSelectionStrategy { get; set; }

    /// <summary>
    /// Block for enumeration_value.
    /// Nesting mode: set
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "EnumerationValue is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 EnumerationValue block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(10000, ErrorMessage = "Maximum 10000 EnumerationValue block(s) allowed")]
    [TerraformPropertyName("enumeration_value")]
    public TerraformSet<TerraformBlock<AwsLexSlotTypeEnumerationValueBlock>>? EnumerationValue { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AwsLexSlotTypeTimeoutsBlock>? Timeouts { get; set; } = new();

    /// <summary>
    /// The checksum attribute.
    /// </summary>
    [TerraformPropertyName("checksum")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Checksum => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "checksum");

    /// <summary>
    /// The created_date attribute.
    /// </summary>
    [TerraformPropertyName("created_date")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> CreatedDate => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "created_date");

    /// <summary>
    /// The last_updated_date attribute.
    /// </summary>
    [TerraformPropertyName("last_updated_date")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> LastUpdatedDate => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "last_updated_date");

    /// <summary>
    /// The version attribute.
    /// </summary>
    [TerraformPropertyName("version")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Version => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "version");

}

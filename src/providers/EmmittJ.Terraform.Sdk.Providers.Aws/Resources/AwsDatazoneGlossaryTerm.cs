using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for term_relations in .
/// Nesting mode: list
/// </summary>
public class AwsDatazoneGlossaryTermTermRelationsBlock : ITerraformBlock
{
    /// <summary>
    /// The classifies attribute.
    /// </summary>
    [TerraformPropertyName("classifies")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<HashSet<TerraformProperty<string>>>? Classifies { get; set; }

    /// <summary>
    /// The is_a attribute.
    /// </summary>
    [TerraformPropertyName("is_a")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<HashSet<TerraformProperty<string>>>? IsA { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AwsDatazoneGlossaryTermTimeoutsBlock : ITerraformBlock
{
    /// <summary>
    /// A string that can be [parsed as a duration](https://pkg.go.dev/time#ParseDuration) consisting of numbers and unit suffixes, such as &amp;quot;30s&amp;quot; or &amp;quot;2h45m&amp;quot;. Valid time units are &amp;quot;s&amp;quot; (seconds), &amp;quot;m&amp;quot; (minutes), &amp;quot;h&amp;quot; (hours).
    /// </summary>
    [TerraformPropertyName("create")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Create { get; set; }

}

/// <summary>
/// Manages a aws_datazone_glossary_term resource.
/// </summary>
public class AwsDatazoneGlossaryTerm : TerraformResource
{
    public AwsDatazoneGlossaryTerm(string name) : base("aws_datazone_glossary_term", name)
    {
    }

    /// <summary>
    /// The domain_identifier attribute.
    /// </summary>
    [TerraformPropertyName("domain_identifier")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? DomainIdentifier { get; set; }

    /// <summary>
    /// The glossary_identifier attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "GlossaryIdentifier is required")]
    [TerraformPropertyName("glossary_identifier")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> GlossaryIdentifier { get; set; }

    /// <summary>
    /// The long_description attribute.
    /// </summary>
    [TerraformPropertyName("long_description")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? LongDescription { get; set; }

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
    /// The short_description attribute.
    /// </summary>
    [TerraformPropertyName("short_description")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? ShortDescription { get; set; }

    /// <summary>
    /// The status attribute.
    /// </summary>
    [TerraformPropertyName("status")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Status { get; set; }

    /// <summary>
    /// Block for term_relations.
    /// Nesting mode: list
    /// </summary>
    [TerraformPropertyName("term_relations")]
    public TerraformList<TerraformBlock<AwsDatazoneGlossaryTermTermRelationsBlock>>? TermRelations { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AwsDatazoneGlossaryTermTimeoutsBlock>? Timeouts { get; set; } = new();

    /// <summary>
    /// The created_at attribute.
    /// </summary>
    [TerraformPropertyName("created_at")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> CreatedAt => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "created_at");

    /// <summary>
    /// The created_by attribute.
    /// </summary>
    [TerraformPropertyName("created_by")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> CreatedBy => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "created_by");

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Id => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

}

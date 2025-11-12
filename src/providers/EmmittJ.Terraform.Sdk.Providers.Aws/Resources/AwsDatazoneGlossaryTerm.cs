using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for term_relations in .
/// Nesting mode: list
/// </summary>
public partial class AwsDatazoneGlossaryTermTermRelationsBlock() : TerraformBlock("term_relations")
{
    /// <summary>
    /// The classifies attribute.
    /// </summary>
    [TerraformProperty("classifies")]
    // Optional argument - source generator will implement get/set
    public partial TerraformSet<string>? Classifies { get; set; }

    /// <summary>
    /// The is_a attribute.
    /// </summary>
    [TerraformProperty("is_a")]
    // Optional argument - source generator will implement get/set
    public partial TerraformSet<string>? IsA { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AwsDatazoneGlossaryTermTimeoutsBlock() : TerraformBlock("timeouts")
{
    /// <summary>
    /// A string that can be [parsed as a duration](https://pkg.go.dev/time#ParseDuration) consisting of numbers and unit suffixes, such as &amp;quot;30s&amp;quot; or &amp;quot;2h45m&amp;quot;. Valid time units are &amp;quot;s&amp;quot; (seconds), &amp;quot;m&amp;quot; (minutes), &amp;quot;h&amp;quot; (hours).
    /// </summary>
    [TerraformProperty("create")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Create { get; set; }

}

/// <summary>
/// Manages a aws_datazone_glossary_term resource.
/// </summary>
public partial class AwsDatazoneGlossaryTerm : TerraformResource
{
    public AwsDatazoneGlossaryTerm(string name) : base("aws_datazone_glossary_term", name)
    {
    }

    /// <summary>
    /// The domain_identifier attribute.
    /// </summary>
    [TerraformProperty("domain_identifier")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? DomainIdentifier { get; set; }

    /// <summary>
    /// The glossary_identifier attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "GlossaryIdentifier is required")]
    [TerraformProperty("glossary_identifier")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> GlossaryIdentifier { get; set; }

    /// <summary>
    /// The long_description attribute.
    /// </summary>
    [TerraformProperty("long_description")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? LongDescription { get; set; }

    /// <summary>
    /// The name attribute.
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
    /// The short_description attribute.
    /// </summary>
    [TerraformProperty("short_description")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? ShortDescription { get; set; }

    /// <summary>
    /// The status attribute.
    /// </summary>
    [TerraformProperty("status")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Status { get; set; }

    /// <summary>
    /// Block for term_relations.
    /// Nesting mode: list
    /// </summary>
    [TerraformProperty("term_relations")]
    public TerraformList<AwsDatazoneGlossaryTermTermRelationsBlock> TermRelations { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public AwsDatazoneGlossaryTermTimeoutsBlock Timeouts { get; set; } = new();

    /// <summary>
    /// The created_at attribute.
    /// </summary>
    [TerraformProperty("created_at")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> CreatedAt { get; }

    /// <summary>
    /// The created_by attribute.
    /// </summary>
    [TerraformProperty("created_by")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> CreatedBy { get; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Id { get; }

}

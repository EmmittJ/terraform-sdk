using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AwsDatazoneProjectTimeoutsBlock() : TerraformBlock("timeouts")
{
    /// <summary>
    /// A string that can be [parsed as a duration](https://pkg.go.dev/time#ParseDuration) consisting of numbers and unit suffixes, such as &amp;quot;30s&amp;quot; or &amp;quot;2h45m&amp;quot;. Valid time units are &amp;quot;s&amp;quot; (seconds), &amp;quot;m&amp;quot; (minutes), &amp;quot;h&amp;quot; (hours).
    /// </summary>
    [TerraformProperty("create")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Create { get; set; }

    /// <summary>
    /// A string that can be [parsed as a duration](https://pkg.go.dev/time#ParseDuration) consisting of numbers and unit suffixes, such as &amp;quot;30s&amp;quot; or &amp;quot;2h45m&amp;quot;. Valid time units are &amp;quot;s&amp;quot; (seconds), &amp;quot;m&amp;quot; (minutes), &amp;quot;h&amp;quot; (hours). Setting a timeout for a Delete operation is only applicable if changes are saved into state before the destroy operation occurs.
    /// </summary>
    [TerraformProperty("delete")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Delete { get; set; }

}

/// <summary>
/// Manages a aws_datazone_project resource.
/// </summary>
public partial class AwsDatazoneProject : TerraformResource
{
    public AwsDatazoneProject(string name) : base("aws_datazone_project", name)
    {
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    [TerraformProperty("description")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Description { get; set; }

    /// <summary>
    /// The domain_identifier attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DomainIdentifier is required")]
    [TerraformProperty("domain_identifier")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> DomainIdentifier { get; set; }

    /// <summary>
    /// The glossary_terms attribute.
    /// </summary>
    [TerraformProperty("glossary_terms")]
    // Optional argument - source generator will implement get/set
    public partial TerraformList<string>? GlossaryTerms { get; set; }

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
    /// The skip_deletion_check attribute.
    /// </summary>
    [TerraformProperty("skip_deletion_check")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? SkipDeletionCheck { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public AwsDatazoneProjectTimeoutsBlock Timeouts { get; set; } = new();

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
    /// The failure_reasons attribute.
    /// </summary>
    [TerraformProperty("failure_reasons")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<object> FailureReasons { get; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Id { get; }

    /// <summary>
    /// The last_updated_at attribute.
    /// </summary>
    [TerraformProperty("last_updated_at")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> LastUpdatedAt { get; }

    /// <summary>
    /// The project_status attribute.
    /// </summary>
    [TerraformProperty("project_status")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> ProjectStatus { get; }

}

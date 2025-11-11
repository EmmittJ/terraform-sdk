using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for action in .
/// Nesting mode: list
/// </summary>
public class AwsSsmincidentsResponsePlanActionBlock
{
}

/// <summary>
/// Block type for incident_template in .
/// Nesting mode: list
/// </summary>
public class AwsSsmincidentsResponsePlanIncidentTemplateBlock
{
    /// <summary>
    /// The dedupe_string attribute.
    /// </summary>
    [TerraformPropertyName("dedupe_string")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? DedupeString { get; set; }

    /// <summary>
    /// The impact attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Impact is required")]
    [TerraformPropertyName("impact")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<double> Impact { get; set; }

    /// <summary>
    /// The incident_tags attribute.
    /// </summary>
    [TerraformPropertyName("incident_tags")]
    // Optional argument - user may or may not set a value
    public TerraformMap<string>? IncidentTags { get; set; }

    /// <summary>
    /// The summary attribute.
    /// </summary>
    [TerraformPropertyName("summary")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Summary { get; set; }

    /// <summary>
    /// The title attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Title is required")]
    [TerraformPropertyName("title")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Title { get; set; }

}

/// <summary>
/// Block type for integration in .
/// Nesting mode: list
/// </summary>
public class AwsSsmincidentsResponsePlanIntegrationBlock
{
}

/// <summary>
/// Manages a aws_ssmincidents_response_plan resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AwsSsmincidentsResponsePlan : TerraformResource
{
    public AwsSsmincidentsResponsePlan(string name) : base("aws_ssmincidents_response_plan", name)
    {
    }

    /// <summary>
    /// The chat_channel attribute.
    /// </summary>
    [TerraformPropertyName("chat_channel")]
    // Optional argument - user may or may not set a value
    public TerraformSet<string>? ChatChannel { get; set; }

    /// <summary>
    /// The display_name attribute.
    /// </summary>
    [TerraformPropertyName("display_name")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? DisplayName { get; set; }

    /// <summary>
    /// The engagements attribute.
    /// </summary>
    [TerraformPropertyName("engagements")]
    // Optional argument - user may or may not set a value
    public TerraformSet<string>? Engagements { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Id { get; set; } = default!;

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Name { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Region { get; set; } = default!;

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformPropertyName("tags")]
    // Optional argument - user may or may not set a value
    public TerraformMap<string>? Tags { get; set; }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    [TerraformPropertyName("tags_all")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformMap<string> TagsAll { get; set; } = default!;

    /// <summary>
    /// Block for action.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Action block(s) allowed")]
    [TerraformPropertyName("action")]
    public TerraformList<TerraformBlock<AwsSsmincidentsResponsePlanActionBlock>>? Action { get; set; }

    /// <summary>
    /// Block for incident_template.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "IncidentTemplate is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 IncidentTemplate block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 IncidentTemplate block(s) allowed")]
    [TerraformPropertyName("incident_template")]
    public TerraformList<TerraformBlock<AwsSsmincidentsResponsePlanIncidentTemplateBlock>>? IncidentTemplate { get; set; }

    /// <summary>
    /// Block for integration.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Integration block(s) allowed")]
    [TerraformPropertyName("integration")]
    public TerraformList<TerraformBlock<AwsSsmincidentsResponsePlanIntegrationBlock>>? Integration { get; set; }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformPropertyName("arn")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Arn => new TerraformReference(this, "arn");

}

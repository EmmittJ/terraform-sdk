using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for action in .
/// Nesting mode: list
/// </summary>
public partial class AwsSsmincidentsResponsePlanActionBlock : TerraformBlockBase
{
}

/// <summary>
/// Block type for incident_template in .
/// Nesting mode: list
/// </summary>
public partial class AwsSsmincidentsResponsePlanIncidentTemplateBlock : TerraformBlockBase
{
    /// <summary>
    /// The dedupe_string attribute.
    /// </summary>
    [TerraformProperty("dedupe_string")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? DedupeString { get; set; }

    /// <summary>
    /// The impact attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Impact is required")]
    [TerraformProperty("impact")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<double> Impact { get; set; }

    /// <summary>
    /// The incident_tags attribute.
    /// </summary>
    [TerraformProperty("incident_tags")]
    // Optional argument - source generator will implement get/set
    public TerraformMap<string>? IncidentTags { get; set; }

    /// <summary>
    /// The summary attribute.
    /// </summary>
    [TerraformProperty("summary")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Summary { get; set; }

    /// <summary>
    /// The title attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Title is required")]
    [TerraformProperty("title")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Title { get; set; }

}

/// <summary>
/// Block type for integration in .
/// Nesting mode: list
/// </summary>
public partial class AwsSsmincidentsResponsePlanIntegrationBlock : TerraformBlockBase
{
}

/// <summary>
/// Manages a aws_ssmincidents_response_plan resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class AwsSsmincidentsResponsePlan : TerraformResource
{
    public AwsSsmincidentsResponsePlan(string name) : base("aws_ssmincidents_response_plan", name)
    {
    }

    /// <summary>
    /// The chat_channel attribute.
    /// </summary>
    [TerraformProperty("chat_channel")]
    // Optional argument - source generator will implement get/set
    public TerraformSet<string>? ChatChannel { get; set; }

    /// <summary>
    /// The display_name attribute.
    /// </summary>
    [TerraformProperty("display_name")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? DisplayName { get; set; }

    /// <summary>
    /// The engagements attribute.
    /// </summary>
    [TerraformProperty("engagements")]
    // Optional argument - source generator will implement get/set
    public TerraformSet<string>? Engagements { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Name { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformProperty("region")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Region { get; set; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformProperty("tags")]
    // Optional argument - source generator will implement get/set
    public TerraformMap<string>? Tags { get; set; }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    [TerraformProperty("tags_all")]
    // Optional+Computed - source generator will implement get/set
    public TerraformMap<string> TagsAll { get; set; }

    /// <summary>
    /// Block for action.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Action block(s) allowed")]
    [TerraformProperty("action")]
    public TerraformList<TerraformBlock<AwsSsmincidentsResponsePlanActionBlock>>? Action { get; set; }

    /// <summary>
    /// Block for incident_template.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "IncidentTemplate is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 IncidentTemplate block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 IncidentTemplate block(s) allowed")]
    [TerraformProperty("incident_template")]
    public TerraformList<TerraformBlock<AwsSsmincidentsResponsePlanIncidentTemplateBlock>>? IncidentTemplate { get; set; }

    /// <summary>
    /// Block for integration.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Integration block(s) allowed")]
    [TerraformProperty("integration")]
    public TerraformList<TerraformBlock<AwsSsmincidentsResponsePlanIntegrationBlock>>? Integration { get; set; }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformProperty("arn")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Arn { get; }

}

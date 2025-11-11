using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for control_mapping_sources in .
/// Nesting mode: set
/// </summary>
public partial class AwsAuditmanagerControlControlMappingSourcesBlock : TerraformBlockBase
{
    /// <summary>
    /// The source_description attribute.
    /// </summary>
    [TerraformProperty("source_description")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? SourceDescription { get; set; }

    /// <summary>
    /// The source_frequency attribute.
    /// </summary>
    [TerraformProperty("source_frequency")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? SourceFrequency { get; set; }


    /// <summary>
    /// The source_keyword attribute.
    /// </summary>
    [TerraformProperty("source_keyword")]
    // Optional+Computed - source generator will implement get/set
    public TerraformList<object> SourceKeyword { get; set; }

    /// <summary>
    /// The source_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SourceName is required")]
    [TerraformProperty("source_name")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> SourceName { get; set; }

    /// <summary>
    /// The source_set_up_option attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SourceSetUpOption is required")]
    [TerraformProperty("source_set_up_option")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> SourceSetUpOption { get; set; }

    /// <summary>
    /// The source_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SourceType is required")]
    [TerraformProperty("source_type")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> SourceType { get; set; }

    /// <summary>
    /// The troubleshooting_text attribute.
    /// </summary>
    [TerraformProperty("troubleshooting_text")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? TroubleshootingText { get; set; }

}

/// <summary>
/// Manages a aws_auditmanager_control resource.
/// </summary>
public partial class AwsAuditmanagerControl : TerraformResource
{
    public AwsAuditmanagerControl(string name) : base("aws_auditmanager_control", name)
    {
    }

    /// <summary>
    /// The action_plan_instructions attribute.
    /// </summary>
    [TerraformProperty("action_plan_instructions")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? ActionPlanInstructions { get; set; }

    /// <summary>
    /// The action_plan_title attribute.
    /// </summary>
    [TerraformProperty("action_plan_title")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? ActionPlanTitle { get; set; }

    /// <summary>
    /// The description attribute.
    /// </summary>
    [TerraformProperty("description")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Description { get; set; }

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
    /// The testing_information attribute.
    /// </summary>
    [TerraformProperty("testing_information")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? TestingInformation { get; set; }

    /// <summary>
    /// Block for control_mapping_sources.
    /// Nesting mode: set
    /// </summary>
    [TerraformProperty("control_mapping_sources")]
    public TerraformSet<TerraformBlock<AwsAuditmanagerControlControlMappingSourcesBlock>>? ControlMappingSources { get; set; }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformProperty("arn")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Arn { get; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Id { get; }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    [TerraformProperty("tags_all")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformMap<string> TagsAll { get; }

    /// <summary>
    /// The type attribute.
    /// </summary>
    [TerraformProperty("type")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Type { get; }

}

using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for control_mapping_sources in .
/// Nesting mode: set
/// </summary>
public class AwsAuditmanagerControlControlMappingSourcesBlock : ITerraformBlock
{
    /// <summary>
    /// The source_description attribute.
    /// </summary>
    [TerraformPropertyName("source_description")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? SourceDescription { get; set; }

    /// <summary>
    /// The source_frequency attribute.
    /// </summary>
    [TerraformPropertyName("source_frequency")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? SourceFrequency { get; set; }

    /// <summary>
    /// The source_id attribute.
    /// </summary>
    [TerraformPropertyName("source_id")]
    // Computed attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> SourceId => new TerraformReferenceProperty<TerraformProperty<string>>("", "source_id");

    /// <summary>
    /// The source_keyword attribute.
    /// </summary>
    [TerraformPropertyName("source_keyword")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<List<TerraformProperty<object>>> SourceKeyword { get; set; } = new TerraformReferenceProperty<List<TerraformProperty<object>>>("", "source_keyword");

    /// <summary>
    /// The source_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SourceName is required")]
    [TerraformPropertyName("source_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> SourceName { get; set; }

    /// <summary>
    /// The source_set_up_option attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SourceSetUpOption is required")]
    [TerraformPropertyName("source_set_up_option")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> SourceSetUpOption { get; set; }

    /// <summary>
    /// The source_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SourceType is required")]
    [TerraformPropertyName("source_type")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> SourceType { get; set; }

    /// <summary>
    /// The troubleshooting_text attribute.
    /// </summary>
    [TerraformPropertyName("troubleshooting_text")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? TroubleshootingText { get; set; }

}

/// <summary>
/// Manages a aws_auditmanager_control resource.
/// </summary>
public class AwsAuditmanagerControl : TerraformResource
{
    public AwsAuditmanagerControl(string name) : base("aws_auditmanager_control", name)
    {
    }

    /// <summary>
    /// The action_plan_instructions attribute.
    /// </summary>
    [TerraformPropertyName("action_plan_instructions")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? ActionPlanInstructions { get; set; }

    /// <summary>
    /// The action_plan_title attribute.
    /// </summary>
    [TerraformPropertyName("action_plan_title")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? ActionPlanTitle { get; set; }

    /// <summary>
    /// The description attribute.
    /// </summary>
    [TerraformPropertyName("description")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Description { get; set; }

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
    /// The tags attribute.
    /// </summary>
    [TerraformPropertyName("tags")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>>? Tags { get; set; }

    /// <summary>
    /// The testing_information attribute.
    /// </summary>
    [TerraformPropertyName("testing_information")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? TestingInformation { get; set; }

    /// <summary>
    /// Block for control_mapping_sources.
    /// Nesting mode: set
    /// </summary>
    [TerraformPropertyName("control_mapping_sources")]
    public TerraformSet<TerraformBlock<AwsAuditmanagerControlControlMappingSourcesBlock>>? ControlMappingSources { get; set; } = new();

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformPropertyName("arn")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Arn => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "arn");

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Id => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    [TerraformPropertyName("tags_all")]
    // Output-only attribute - read-only reference
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>> TagsAll => new TerraformReferenceProperty<Dictionary<string, TerraformProperty<string>>>(ResourceAddress, "tags_all");

    /// <summary>
    /// The type attribute.
    /// </summary>
    [TerraformPropertyName("type")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Type => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "type");

}

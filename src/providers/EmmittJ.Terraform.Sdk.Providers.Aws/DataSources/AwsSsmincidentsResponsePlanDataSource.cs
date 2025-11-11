using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_ssmincidents_response_plan.
/// </summary>
public class AwsSsmincidentsResponsePlanDataSource : TerraformDataSource
{
    public AwsSsmincidentsResponsePlanDataSource(string name) : base("aws_ssmincidents_response_plan", name)
    {
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Arn is required")]
    [TerraformPropertyName("arn")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Arn { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Id { get; set; } = default!;

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
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformMap<string> Tags { get; set; } = default!;

    /// <summary>
    /// The action attribute.
    /// </summary>
    [TerraformPropertyName("action")]
    // Output-only attribute - read-only reference
    public TerraformList<object> Action => new TerraformReference(this, "action");

    /// <summary>
    /// The chat_channel attribute.
    /// </summary>
    [TerraformPropertyName("chat_channel")]
    // Output-only attribute - read-only reference
    public TerraformSet<string> ChatChannel => new TerraformReference(this, "chat_channel");

    /// <summary>
    /// The display_name attribute.
    /// </summary>
    [TerraformPropertyName("display_name")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> DisplayName => new TerraformReference(this, "display_name");

    /// <summary>
    /// The engagements attribute.
    /// </summary>
    [TerraformPropertyName("engagements")]
    // Output-only attribute - read-only reference
    public TerraformSet<string> Engagements => new TerraformReference(this, "engagements");

    /// <summary>
    /// The incident_template attribute.
    /// </summary>
    [TerraformPropertyName("incident_template")]
    // Output-only attribute - read-only reference
    public TerraformList<object> IncidentTemplate => new TerraformReference(this, "incident_template");

    /// <summary>
    /// The integration attribute.
    /// </summary>
    [TerraformPropertyName("integration")]
    // Output-only attribute - read-only reference
    public TerraformList<object> Integration => new TerraformReference(this, "integration");

    /// <summary>
    /// The name attribute.
    /// </summary>
    [TerraformPropertyName("name")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Name => new TerraformReference(this, "name");

}

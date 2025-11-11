using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_ssmincidents_response_plan.
/// </summary>
public partial class AwsSsmincidentsResponsePlanDataSource : TerraformDataSource
{
    public AwsSsmincidentsResponsePlanDataSource(string name) : base("aws_ssmincidents_response_plan", name)
    {
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Arn is required")]
    [TerraformProperty("arn")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Arn { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformProperty("region")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Region { get; set; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformProperty("tags")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformMap<string> Tags { get; set; }

    /// <summary>
    /// The action attribute.
    /// </summary>
    [TerraformProperty("action")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<object> Action { get; }

    /// <summary>
    /// The chat_channel attribute.
    /// </summary>
    [TerraformProperty("chat_channel")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformSet<string> ChatChannel { get; }

    /// <summary>
    /// The display_name attribute.
    /// </summary>
    [TerraformProperty("display_name")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> DisplayName { get; }

    /// <summary>
    /// The engagements attribute.
    /// </summary>
    [TerraformProperty("engagements")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformSet<string> Engagements { get; }

    /// <summary>
    /// The incident_template attribute.
    /// </summary>
    [TerraformProperty("incident_template")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<object> IncidentTemplate { get; }

    /// <summary>
    /// The integration attribute.
    /// </summary>
    [TerraformProperty("integration")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<object> Integration { get; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [TerraformProperty("name")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Name { get; }

}

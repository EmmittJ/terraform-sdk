using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_ssmcontacts_rotation.
/// </summary>
public partial class AwsSsmcontactsRotationDataSource : TerraformDataSource
{
    public AwsSsmcontactsRotationDataSource(string name) : base("aws_ssmcontacts_rotation", name)
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
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformProperty("region")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Region { get; set; }

    /// <summary>
    /// The contact_ids attribute.
    /// </summary>
    [TerraformProperty("contact_ids")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<string> ContactIds { get; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Id { get; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [TerraformProperty("name")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Name { get; }

    /// <summary>
    /// The recurrence attribute.
    /// </summary>
    [TerraformProperty("recurrence")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<object> Recurrence { get; }

    /// <summary>
    /// The start_time attribute.
    /// </summary>
    [TerraformProperty("start_time")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> StartTime { get; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformProperty("tags")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformMap<string> Tags { get; }

    /// <summary>
    /// The time_zone_id attribute.
    /// </summary>
    [TerraformProperty("time_zone_id")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> TimeZoneId { get; }

}

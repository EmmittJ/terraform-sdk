using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_ssmcontacts_rotation.
/// </summary>
public class AwsSsmcontactsRotationDataSource : TerraformDataSource
{
    public AwsSsmcontactsRotationDataSource(string name) : base("aws_ssmcontacts_rotation", name)
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
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Region { get; set; } = default!;

    /// <summary>
    /// The contact_ids attribute.
    /// </summary>
    [TerraformPropertyName("contact_ids")]
    // Output-only attribute - read-only reference
    public TerraformList<string> ContactIds => new TerraformReference(this, "contact_ids");

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Id => new TerraformReference(this, "id");

    /// <summary>
    /// The name attribute.
    /// </summary>
    [TerraformPropertyName("name")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Name => new TerraformReference(this, "name");

    /// <summary>
    /// The recurrence attribute.
    /// </summary>
    [TerraformPropertyName("recurrence")]
    // Output-only attribute - read-only reference
    public TerraformList<object> Recurrence => new TerraformReference(this, "recurrence");

    /// <summary>
    /// The start_time attribute.
    /// </summary>
    [TerraformPropertyName("start_time")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> StartTime => new TerraformReference(this, "start_time");

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformPropertyName("tags")]
    // Output-only attribute - read-only reference
    public TerraformMap<string> Tags => new TerraformReference(this, "tags");

    /// <summary>
    /// The time_zone_id attribute.
    /// </summary>
    [TerraformPropertyName("time_zone_id")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> TimeZoneId => new TerraformReference(this, "time_zone_id");

}

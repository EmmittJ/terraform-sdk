using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for notification_settings in .
/// Nesting mode: set
/// </summary>
public partial class AwsRolesanywhereTrustAnchorNotificationSettingsBlock : TerraformBlockBase
{
    /// <summary>
    /// The channel attribute.
    /// </summary>
    [TerraformProperty("channel")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Channel { get; set; }


    /// <summary>
    /// The enabled attribute.
    /// </summary>
    [TerraformProperty("enabled")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<bool> Enabled { get; set; }

    /// <summary>
    /// The event attribute.
    /// </summary>
    [TerraformProperty("event")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Event { get; set; }

    /// <summary>
    /// The threshold attribute.
    /// </summary>
    [TerraformProperty("threshold")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<double> Threshold { get; set; }

}

/// <summary>
/// Block type for source in .
/// Nesting mode: list
/// </summary>
public partial class AwsRolesanywhereTrustAnchorSourceBlock : TerraformBlockBase
{
    /// <summary>
    /// The source_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SourceType is required")]
    [TerraformProperty("source_type")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> SourceType { get; set; }

}

/// <summary>
/// Manages a aws_rolesanywhere_trust_anchor resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class AwsRolesanywhereTrustAnchor : TerraformResource
{
    public AwsRolesanywhereTrustAnchor(string name) : base("aws_rolesanywhere_trust_anchor", name)
    {
    }

    /// <summary>
    /// The enabled attribute.
    /// </summary>
    [TerraformProperty("enabled")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<bool> Enabled { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformProperty("tags")]
    // Optional argument - source generator will implement get/set
    public partial TerraformMap<string>? Tags { get; set; }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    [TerraformProperty("tags_all")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformMap<string> TagsAll { get; set; }

    /// <summary>
    /// Block for notification_settings.
    /// Nesting mode: set
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(50, ErrorMessage = "Maximum 50 NotificationSettings block(s) allowed")]
    [TerraformProperty("notification_settings")]
    public partial TerraformSet<TerraformBlock<AwsRolesanywhereTrustAnchorNotificationSettingsBlock>>? NotificationSettings { get; set; }

    /// <summary>
    /// Block for source.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Source is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Source block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Source block(s) allowed")]
    [TerraformProperty("source")]
    public partial TerraformList<TerraformBlock<AwsRolesanywhereTrustAnchorSourceBlock>>? Source { get; set; }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformProperty("arn")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Arn { get; }

}

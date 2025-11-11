using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for emergency_contact in .
/// Nesting mode: list
/// </summary>
public class AwsShieldProactiveEngagementEmergencyContactBlock
{
    /// <summary>
    /// The contact_notes attribute.
    /// </summary>
    [TerraformPropertyName("contact_notes")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? ContactNotes { get; set; }

    /// <summary>
    /// The email_address attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "EmailAddress is required")]
    [TerraformPropertyName("email_address")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> EmailAddress { get; set; }

    /// <summary>
    /// The phone_number attribute.
    /// </summary>
    [TerraformPropertyName("phone_number")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? PhoneNumber { get; set; }

}

/// <summary>
/// Manages a aws_shield_proactive_engagement resource.
/// </summary>
public class AwsShieldProactiveEngagement : TerraformResource
{
    public AwsShieldProactiveEngagement(string name) : base("aws_shield_proactive_engagement", name)
    {
    }

    /// <summary>
    /// The enabled attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Enabled is required")]
    [TerraformPropertyName("enabled")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<bool> Enabled { get; set; }

    /// <summary>
    /// Block for emergency_contact.
    /// Nesting mode: list
    /// </summary>
    [TerraformPropertyName("emergency_contact")]
    public TerraformList<TerraformBlock<AwsShieldProactiveEngagementEmergencyContactBlock>>? EmergencyContact { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Id => new TerraformReference(this, "id");

}

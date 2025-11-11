using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for emergency_contact in .
/// Nesting mode: list
/// </summary>
public partial class AwsShieldProactiveEngagementEmergencyContactBlock : TerraformBlockBase
{
    /// <summary>
    /// The contact_notes attribute.
    /// </summary>
    [TerraformProperty("contact_notes")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? ContactNotes { get; set; }

    /// <summary>
    /// The email_address attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "EmailAddress is required")]
    [TerraformProperty("email_address")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> EmailAddress { get; set; }

    /// <summary>
    /// The phone_number attribute.
    /// </summary>
    [TerraformProperty("phone_number")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? PhoneNumber { get; set; }

}

/// <summary>
/// Manages a aws_shield_proactive_engagement resource.
/// </summary>
public partial class AwsShieldProactiveEngagement : TerraformResource
{
    public AwsShieldProactiveEngagement(string name) : base("aws_shield_proactive_engagement", name)
    {
    }

    /// <summary>
    /// The enabled attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Enabled is required")]
    [TerraformProperty("enabled")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<bool> Enabled { get; set; }

    /// <summary>
    /// Block for emergency_contact.
    /// Nesting mode: list
    /// </summary>
    [TerraformProperty("emergency_contact")]
    public partial TerraformList<TerraformBlock<AwsShieldProactiveEngagementEmergencyContactBlock>>? EmergencyContact { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Id { get; }

}

using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for emergency_contact in AwsShieldProactiveEngagement.
/// Nesting mode: list
/// </summary>
public class AwsShieldProactiveEngagementEmergencyContactBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "emergency_contact";

    /// <summary>
    /// The contact_notes attribute.
    /// </summary>
    public TerraformValue<string>? ContactNotes
    {
        get => GetArgument<TerraformValue<string>>("contact_notes");
        set => SetArgument("contact_notes", value);
    }

    /// <summary>
    /// The email_address attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "EmailAddress is required")]
    public required TerraformValue<string> EmailAddress
    {
        get => GetArgument<TerraformValue<string>>("email_address");
        set => SetArgument("email_address", value);
    }

    /// <summary>
    /// The phone_number attribute.
    /// </summary>
    public TerraformValue<string>? PhoneNumber
    {
        get => GetArgument<TerraformValue<string>>("phone_number");
        set => SetArgument("phone_number", value);
    }

}


/// <summary>
/// Represents a aws_shield_proactive_engagement Terraform resource.
/// Manages a aws_shield_proactive_engagement resource.
/// </summary>
public partial class AwsShieldProactiveEngagement(string name) : TerraformResource("aws_shield_proactive_engagement", name)
{
    /// <summary>
    /// The enabled attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Enabled is required")]
    public required TerraformValue<bool> Enabled
    {
        get => GetArgument<TerraformValue<bool>>("enabled");
        set => SetArgument("enabled", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
        => AsReference("id");

    /// <summary>
    /// EmergencyContact block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsShieldProactiveEngagementEmergencyContactBlock>? EmergencyContact
    {
        get => GetArgument<TerraformList<AwsShieldProactiveEngagementEmergencyContactBlock>>("emergency_contact");
        set => SetArgument("emergency_contact", value);
    }

}

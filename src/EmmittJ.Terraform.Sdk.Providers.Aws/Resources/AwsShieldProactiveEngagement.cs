using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for emergency_contact in .
/// Nesting mode: list
/// </summary>
public class AwsShieldProactiveEngagementEmergencyContactBlock : TerraformBlock
{
    /// <summary>
    /// The contact_notes attribute.
    /// </summary>
    public TerraformProperty<string>? ContactNotes
    {
        get => GetProperty<TerraformProperty<string>>("contact_notes");
        set => WithProperty("contact_notes", value);
    }

    /// <summary>
    /// The email_address attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "EmailAddress is required")]
    public required TerraformProperty<string> EmailAddress
    {
        get => GetProperty<TerraformProperty<string>>("email_address");
        set => WithProperty("email_address", value);
    }

    /// <summary>
    /// The phone_number attribute.
    /// </summary>
    public TerraformProperty<string>? PhoneNumber
    {
        get => GetProperty<TerraformProperty<string>>("phone_number");
        set => WithProperty("phone_number", value);
    }

}

/// <summary>
/// Manages a aws_shield_proactive_engagement resource.
/// </summary>
public class AwsShieldProactiveEngagement : TerraformResource
{
    public AwsShieldProactiveEngagement(string name) : base("aws_shield_proactive_engagement", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("id");
    }

    /// <summary>
    /// The enabled attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Enabled is required")]
    public required TerraformProperty<bool> Enabled
    {
        get => GetProperty<TerraformProperty<bool>>("enabled");
        set => this.WithProperty("enabled", value);
    }

    /// <summary>
    /// Block for emergency_contact.
    /// Nesting mode: list
    /// </summary>
    public List<AwsShieldProactiveEngagementEmergencyContactBlock>? EmergencyContact
    {
        get => GetProperty<List<AwsShieldProactiveEngagementEmergencyContactBlock>>("emergency_contact");
        set => this.WithProperty("emergency_contact", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformExpression Id => this["id"];

}

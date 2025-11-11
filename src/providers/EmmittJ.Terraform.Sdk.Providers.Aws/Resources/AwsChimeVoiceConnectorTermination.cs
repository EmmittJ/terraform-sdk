using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_chime_voice_connector_termination resource.
/// </summary>
public class AwsChimeVoiceConnectorTermination : TerraformResource
{
    public AwsChimeVoiceConnectorTermination(string name) : base("aws_chime_voice_connector_termination", name)
    {
    }

    /// <summary>
    /// The calling_regions attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CallingRegions is required")]
    [TerraformPropertyName("calling_regions")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformSet<string> CallingRegions { get; set; }

    /// <summary>
    /// The cidr_allow_list attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CidrAllowList is required")]
    [TerraformPropertyName("cidr_allow_list")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformSet<string> CidrAllowList { get; set; }

    /// <summary>
    /// The cps_limit attribute.
    /// </summary>
    [TerraformPropertyName("cps_limit")]
    // Optional argument - user may or may not set a value
    public TerraformValue<double>? CpsLimit { get; set; }

    /// <summary>
    /// The default_phone_number attribute.
    /// </summary>
    [TerraformPropertyName("default_phone_number")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? DefaultPhoneNumber { get; set; }

    /// <summary>
    /// The disabled attribute.
    /// </summary>
    [TerraformPropertyName("disabled")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? Disabled { get; set; }

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
    /// The voice_connector_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "VoiceConnectorId is required")]
    [TerraformPropertyName("voice_connector_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> VoiceConnectorId { get; set; }

}

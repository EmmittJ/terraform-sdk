using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_chime_voice_connector_termination resource.
/// </summary>
public partial class AwsChimeVoiceConnectorTermination : TerraformResource
{
    public AwsChimeVoiceConnectorTermination(string name) : base("aws_chime_voice_connector_termination", name)
    {
    }

    /// <summary>
    /// The calling_regions attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CallingRegions is required")]
    [TerraformProperty("calling_regions")]
    // Required argument - source generator will implement get/set
    public required TerraformSet<string> CallingRegions { get; set; }

    /// <summary>
    /// The cidr_allow_list attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CidrAllowList is required")]
    [TerraformProperty("cidr_allow_list")]
    // Required argument - source generator will implement get/set
    public required TerraformSet<string> CidrAllowList { get; set; }

    /// <summary>
    /// The cps_limit attribute.
    /// </summary>
    [TerraformProperty("cps_limit")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<double>? CpsLimit { get; set; }

    /// <summary>
    /// The default_phone_number attribute.
    /// </summary>
    [TerraformProperty("default_phone_number")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? DefaultPhoneNumber { get; set; }

    /// <summary>
    /// The disabled attribute.
    /// </summary>
    [TerraformProperty("disabled")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<bool>? Disabled { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Id { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformProperty("region")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Region { get; set; }

    /// <summary>
    /// The voice_connector_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "VoiceConnectorId is required")]
    [TerraformProperty("voice_connector_id")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> VoiceConnectorId { get; set; }

}

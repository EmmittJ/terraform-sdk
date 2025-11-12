using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for voice_connector in .
/// Nesting mode: list
/// </summary>
public partial class AwsChimesdkvoiceGlobalSettingsVoiceConnectorBlock() : TerraformBlock("voice_connector")
{
    /// <summary>
    /// The cdr_bucket attribute.
    /// </summary>
    [TerraformProperty("cdr_bucket")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? CdrBucket { get; set; }

}

/// <summary>
/// Manages a aws_chimesdkvoice_global_settings resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class AwsChimesdkvoiceGlobalSettings : TerraformResource
{
    public AwsChimesdkvoiceGlobalSettings(string name) : base("aws_chimesdkvoice_global_settings", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// Block for voice_connector.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "VoiceConnector is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 VoiceConnector block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 VoiceConnector block(s) allowed")]
    [TerraformProperty("voice_connector")]
    public required TerraformList<AwsChimesdkvoiceGlobalSettingsVoiceConnectorBlock> VoiceConnector { get; set; } = new();

}

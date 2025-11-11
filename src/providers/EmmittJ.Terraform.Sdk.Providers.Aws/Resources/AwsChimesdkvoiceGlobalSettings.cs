using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for voice_connector in .
/// Nesting mode: list
/// </summary>
public class AwsChimesdkvoiceGlobalSettingsVoiceConnectorBlock
{
    /// <summary>
    /// The cdr_bucket attribute.
    /// </summary>
    [TerraformPropertyName("cdr_bucket")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? CdrBucket { get; set; }

}

/// <summary>
/// Manages a aws_chimesdkvoice_global_settings resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AwsChimesdkvoiceGlobalSettings : TerraformResource
{
    public AwsChimesdkvoiceGlobalSettings(string name) : base("aws_chimesdkvoice_global_settings", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Id { get; set; } = default!;

    /// <summary>
    /// Block for voice_connector.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "VoiceConnector is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 VoiceConnector block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 VoiceConnector block(s) allowed")]
    [TerraformPropertyName("voice_connector")]
    public TerraformList<TerraformBlock<AwsChimesdkvoiceGlobalSettingsVoiceConnectorBlock>>? VoiceConnector { get; set; }

}

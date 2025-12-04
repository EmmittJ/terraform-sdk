using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for voice_connector in AwsChimesdkvoiceGlobalSettings.
/// Nesting mode: list
/// </summary>
public class AwsChimesdkvoiceGlobalSettingsVoiceConnectorBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "voice_connector";

    /// <summary>
    /// The cdr_bucket attribute.
    /// </summary>
    public TerraformValue<string>? CdrBucket
    {
        get => GetArgument<TerraformValue<string>>("cdr_bucket");
        set => SetArgument("cdr_bucket", value);
    }

}


/// <summary>
/// Represents a aws_chimesdkvoice_global_settings Terraform resource.
/// Manages a aws_chimesdkvoice_global_settings resource.
/// </summary>
public partial class AwsChimesdkvoiceGlobalSettings(string name) : TerraformResource("aws_chimesdkvoice_global_settings", name)
{
    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => GetArgument<TerraformValue<string>>("id") ?? AsReference("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// VoiceConnector block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "VoiceConnector is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 VoiceConnector block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 VoiceConnector block(s) allowed")]
    public required TerraformList<AwsChimesdkvoiceGlobalSettingsVoiceConnectorBlock> VoiceConnector
    {
        get => GetRequiredArgument<TerraformList<AwsChimesdkvoiceGlobalSettingsVoiceConnectorBlock>>("voice_connector");
        set => SetArgument("voice_connector", value);
    }

}

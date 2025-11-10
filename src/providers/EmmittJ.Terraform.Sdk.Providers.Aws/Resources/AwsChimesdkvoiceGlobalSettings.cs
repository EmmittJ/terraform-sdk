using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for voice_connector in .
/// Nesting mode: list
/// </summary>
public class AwsChimesdkvoiceGlobalSettingsVoiceConnectorBlock : TerraformBlock
{
    /// <summary>
    /// The cdr_bucket attribute.
    /// </summary>
    public TerraformProperty<string>? CdrBucket
    {
        set => SetProperty("cdr_bucket", value);
    }

}

/// <summary>
/// Manages a aws_chimesdkvoice_global_settings resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AwsChimesdkvoiceGlobalSettings : TerraformResource
{
    public AwsChimesdkvoiceGlobalSettings(string name) : base("aws_chimesdkvoice_global_settings", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("id");
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string> Id
    {
        get => GetRequiredOutput<TerraformProperty<string>>("id");
        set => SetProperty("id", value);
    }

    /// <summary>
    /// Block for voice_connector.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "VoiceConnector is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 VoiceConnector block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 VoiceConnector block(s) allowed")]
    public List<AwsChimesdkvoiceGlobalSettingsVoiceConnectorBlock>? VoiceConnector
    {
        set => SetProperty("voice_connector", value);
    }

}

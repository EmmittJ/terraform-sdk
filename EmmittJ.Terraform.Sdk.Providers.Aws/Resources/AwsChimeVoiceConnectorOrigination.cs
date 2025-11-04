using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_chime_voice_connector_origination resource.
/// </summary>
public class AwsChimeVoiceConnectorOrigination : TerraformResource
{
    public AwsChimeVoiceConnectorOrigination(string name) : base("aws_chime_voice_connector_origination", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
    }

    /// <summary>
    /// The disabled attribute.
    /// </summary>
    public bool? Disabled
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("disabled")?.Value;
        set => this.WithProperty("disabled", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public string? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id")?.Value;
        set => this.WithProperty("id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The voice_connector_id attribute.
    /// </summary>
    public string? VoiceConnectorId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("voice_connector_id")?.Value;
        set => this.WithProperty("voice_connector_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

}

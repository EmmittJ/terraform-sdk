using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Manages a azurerm_bot_channel_direct_line_speech resource.
/// </summary>
public class AzurermBotChannelDirectLineSpeech : TerraformResource
{
    public AzurermBotChannelDirectLineSpeech(string name) : base("azurerm_bot_channel_direct_line_speech", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
    }

    /// <summary>
    /// The bot_name attribute.
    /// </summary>
    public string? BotName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("bot_name")?.Value;
        set => this.WithProperty("bot_name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The cognitive_account_id attribute.
    /// </summary>
    public string? CognitiveAccountId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("cognitive_account_id")?.Value;
        set => this.WithProperty("cognitive_account_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The cognitive_service_access_key attribute.
    /// </summary>
    public string? CognitiveServiceAccessKey
    {
        get => GetProperty<TerraformLiteralProperty<string>>("cognitive_service_access_key")?.Value;
        set => this.WithProperty("cognitive_service_access_key", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The cognitive_service_location attribute.
    /// </summary>
    public string? CognitiveServiceLocation
    {
        get => GetProperty<TerraformLiteralProperty<string>>("cognitive_service_location")?.Value;
        set => this.WithProperty("cognitive_service_location", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The custom_speech_model_id attribute.
    /// </summary>
    public string? CustomSpeechModelId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("custom_speech_model_id")?.Value;
        set => this.WithProperty("custom_speech_model_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The custom_voice_deployment_id attribute.
    /// </summary>
    public string? CustomVoiceDeploymentId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("custom_voice_deployment_id")?.Value;
        set => this.WithProperty("custom_voice_deployment_id", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The location attribute.
    /// </summary>
    public string? Location
    {
        get => GetProperty<TerraformLiteralProperty<string>>("location")?.Value;
        set => this.WithProperty("location", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    public string? ResourceGroupName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("resource_group_name")?.Value;
        set => this.WithProperty("resource_group_name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

}

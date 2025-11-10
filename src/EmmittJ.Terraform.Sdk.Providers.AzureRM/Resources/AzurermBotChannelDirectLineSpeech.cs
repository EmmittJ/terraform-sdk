using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermBotChannelDirectLineSpeechTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformProperty<string>? Create
    {
        get => GetProperty<TerraformProperty<string>>("create");
        set => WithProperty("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        get => GetProperty<TerraformProperty<string>>("delete");
        set => WithProperty("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformProperty<string>? Read
    {
        get => GetProperty<TerraformProperty<string>>("read");
        set => WithProperty("read", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformProperty<string>? Update
    {
        get => GetProperty<TerraformProperty<string>>("update");
        set => WithProperty("update", value);
    }

}

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
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "BotName is required")]
    public required TerraformProperty<string> BotName
    {
        get => GetProperty<TerraformProperty<string>>("bot_name");
        set => this.WithProperty("bot_name", value);
    }

    /// <summary>
    /// The cognitive_account_id attribute.
    /// </summary>
    public TerraformProperty<string>? CognitiveAccountId
    {
        get => GetProperty<TerraformProperty<string>>("cognitive_account_id");
        set => this.WithProperty("cognitive_account_id", value);
    }

    /// <summary>
    /// The cognitive_service_access_key attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CognitiveServiceAccessKey is required")]
    public required TerraformProperty<string> CognitiveServiceAccessKey
    {
        get => GetProperty<TerraformProperty<string>>("cognitive_service_access_key");
        set => this.WithProperty("cognitive_service_access_key", value);
    }

    /// <summary>
    /// The cognitive_service_location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CognitiveServiceLocation is required")]
    public required TerraformProperty<string> CognitiveServiceLocation
    {
        get => GetProperty<TerraformProperty<string>>("cognitive_service_location");
        set => this.WithProperty("cognitive_service_location", value);
    }

    /// <summary>
    /// The custom_speech_model_id attribute.
    /// </summary>
    public TerraformProperty<string>? CustomSpeechModelId
    {
        get => GetProperty<TerraformProperty<string>>("custom_speech_model_id");
        set => this.WithProperty("custom_speech_model_id", value);
    }

    /// <summary>
    /// The custom_voice_deployment_id attribute.
    /// </summary>
    public TerraformProperty<string>? CustomVoiceDeploymentId
    {
        get => GetProperty<TerraformProperty<string>>("custom_voice_deployment_id");
        set => this.WithProperty("custom_voice_deployment_id", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string>? Id
    {
        get => GetProperty<TerraformProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// The location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformProperty<string> Location
    {
        get => GetProperty<TerraformProperty<string>>("location");
        set => this.WithProperty("location", value);
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    public required TerraformProperty<string> ResourceGroupName
    {
        get => GetProperty<TerraformProperty<string>>("resource_group_name");
        set => this.WithProperty("resource_group_name", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermBotChannelDirectLineSpeechTimeoutsBlock? Timeouts
    {
        get => GetProperty<AzurermBotChannelDirectLineSpeechTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
    }

}

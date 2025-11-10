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
        set => SetProperty("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        set => SetProperty("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformProperty<string>? Read
    {
        set => SetProperty("read", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformProperty<string>? Update
    {
        set => SetProperty("update", value);
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
        SetOutput("bot_name");
        SetOutput("cognitive_account_id");
        SetOutput("cognitive_service_access_key");
        SetOutput("cognitive_service_location");
        SetOutput("custom_speech_model_id");
        SetOutput("custom_voice_deployment_id");
        SetOutput("id");
        SetOutput("location");
        SetOutput("resource_group_name");
    }

    /// <summary>
    /// The bot_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "BotName is required")]
    public required TerraformProperty<string> BotName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("bot_name");
        set => SetProperty("bot_name", value);
    }

    /// <summary>
    /// The cognitive_account_id attribute.
    /// </summary>
    public TerraformProperty<string> CognitiveAccountId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("cognitive_account_id");
        set => SetProperty("cognitive_account_id", value);
    }

    /// <summary>
    /// The cognitive_service_access_key attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CognitiveServiceAccessKey is required")]
    public required TerraformProperty<string> CognitiveServiceAccessKey
    {
        get => GetRequiredOutput<TerraformProperty<string>>("cognitive_service_access_key");
        set => SetProperty("cognitive_service_access_key", value);
    }

    /// <summary>
    /// The cognitive_service_location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CognitiveServiceLocation is required")]
    public required TerraformProperty<string> CognitiveServiceLocation
    {
        get => GetRequiredOutput<TerraformProperty<string>>("cognitive_service_location");
        set => SetProperty("cognitive_service_location", value);
    }

    /// <summary>
    /// The custom_speech_model_id attribute.
    /// </summary>
    public TerraformProperty<string> CustomSpeechModelId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("custom_speech_model_id");
        set => SetProperty("custom_speech_model_id", value);
    }

    /// <summary>
    /// The custom_voice_deployment_id attribute.
    /// </summary>
    public TerraformProperty<string> CustomVoiceDeploymentId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("custom_voice_deployment_id");
        set => SetProperty("custom_voice_deployment_id", value);
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
    /// The location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformProperty<string> Location
    {
        get => GetRequiredOutput<TerraformProperty<string>>("location");
        set => SetProperty("location", value);
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    public required TerraformProperty<string> ResourceGroupName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("resource_group_name");
        set => SetProperty("resource_group_name", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermBotChannelDirectLineSpeechTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

}

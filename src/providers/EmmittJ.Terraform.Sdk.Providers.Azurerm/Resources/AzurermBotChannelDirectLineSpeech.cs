using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for timeouts in AzurermBotChannelDirectLineSpeech.
/// Nesting mode: single
/// </summary>
public class AzurermBotChannelDirectLineSpeechTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "timeouts";

    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformValue<string>? Create
    {
        get => new TerraformReference<string>(this, "create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformValue<string>? Delete
    {
        get => new TerraformReference<string>(this, "delete");
        set => SetArgument("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformValue<string>? Read
    {
        get => new TerraformReference<string>(this, "read");
        set => SetArgument("read", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformValue<string>? Update
    {
        get => new TerraformReference<string>(this, "update");
        set => SetArgument("update", value);
    }

}


/// <summary>
/// Represents a azurerm_bot_channel_direct_line_speech Terraform resource.
/// Manages a azurerm_bot_channel_direct_line_speech resource.
/// </summary>
public partial class AzurermBotChannelDirectLineSpeech(string name) : TerraformResource("azurerm_bot_channel_direct_line_speech", name)
{
    /// <summary>
    /// The bot_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "BotName is required")]
    public required TerraformValue<string> BotName
    {
        get => new TerraformReference<string>(this, "bot_name");
        set => SetArgument("bot_name", value);
    }

    /// <summary>
    /// The cognitive_account_id attribute.
    /// </summary>
    public TerraformValue<string>? CognitiveAccountId
    {
        get => new TerraformReference<string>(this, "cognitive_account_id");
        set => SetArgument("cognitive_account_id", value);
    }

    /// <summary>
    /// The cognitive_service_access_key attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CognitiveServiceAccessKey is required")]
    public required TerraformValue<string> CognitiveServiceAccessKey
    {
        get => new TerraformReference<string>(this, "cognitive_service_access_key");
        set => SetArgument("cognitive_service_access_key", value);
    }

    /// <summary>
    /// The cognitive_service_location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CognitiveServiceLocation is required")]
    public required TerraformValue<string> CognitiveServiceLocation
    {
        get => new TerraformReference<string>(this, "cognitive_service_location");
        set => SetArgument("cognitive_service_location", value);
    }

    /// <summary>
    /// The custom_speech_model_id attribute.
    /// </summary>
    public TerraformValue<string>? CustomSpeechModelId
    {
        get => new TerraformReference<string>(this, "custom_speech_model_id");
        set => SetArgument("custom_speech_model_id", value);
    }

    /// <summary>
    /// The custom_voice_deployment_id attribute.
    /// </summary>
    public TerraformValue<string>? CustomVoiceDeploymentId
    {
        get => new TerraformReference<string>(this, "custom_voice_deployment_id");
        set => SetArgument("custom_voice_deployment_id", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformValue<string> Location
    {
        get => new TerraformReference<string>(this, "location");
        set => SetArgument("location", value);
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    public required TerraformValue<string> ResourceGroupName
    {
        get => new TerraformReference<string>(this, "resource_group_name");
        set => SetArgument("resource_group_name", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermBotChannelDirectLineSpeechTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermBotChannelDirectLineSpeechTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}

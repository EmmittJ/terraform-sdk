using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Manages a azurerm_bot_channel_ms_teams resource.
/// </summary>
public class AzurermBotChannelMsTeams : TerraformResource
{
    public AzurermBotChannelMsTeams(string name) : base("azurerm_bot_channel_ms_teams", name)
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
    /// The calling_enabled attribute.
    /// </summary>
    public bool? CallingEnabled
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("calling_enabled")?.Value;
        set => this.WithProperty("calling_enabled", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The calling_web_hook attribute.
    /// </summary>
    public string? CallingWebHook
    {
        get => GetProperty<TerraformLiteralProperty<string>>("calling_web_hook")?.Value;
        set => this.WithProperty("calling_web_hook", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The deployment_environment attribute.
    /// </summary>
    public string? DeploymentEnvironment
    {
        get => GetProperty<TerraformLiteralProperty<string>>("deployment_environment")?.Value;
        set => this.WithProperty("deployment_environment", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The enable_calling attribute.
    /// </summary>
    [Obsolete("This property is deprecated.")]
    public bool? EnableCalling
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("enable_calling")?.Value;
        set => this.WithProperty("enable_calling", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
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

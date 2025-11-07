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
    public TerraformLiteralProperty<string>? BotName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("bot_name");
        set => this.WithProperty("bot_name", value);
    }

    /// <summary>
    /// The calling_enabled attribute.
    /// </summary>
    public TerraformLiteralProperty<bool>? CallingEnabled
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("calling_enabled");
        set => this.WithProperty("calling_enabled", value);
    }

    /// <summary>
    /// The calling_web_hook attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? CallingWebHook
    {
        get => GetProperty<TerraformLiteralProperty<string>>("calling_web_hook");
        set => this.WithProperty("calling_web_hook", value);
    }

    /// <summary>
    /// The deployment_environment attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? DeploymentEnvironment
    {
        get => GetProperty<TerraformLiteralProperty<string>>("deployment_environment");
        set => this.WithProperty("deployment_environment", value);
    }

    /// <summary>
    /// The enable_calling attribute.
    /// </summary>
    [Obsolete("This property is deprecated.")]
    public TerraformLiteralProperty<bool>? EnableCalling
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("enable_calling");
        set => this.WithProperty("enable_calling", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// The location attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Location
    {
        get => GetProperty<TerraformLiteralProperty<string>>("location");
        set => this.WithProperty("location", value);
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? ResourceGroupName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("resource_group_name");
        set => this.WithProperty("resource_group_name", value);
    }

}

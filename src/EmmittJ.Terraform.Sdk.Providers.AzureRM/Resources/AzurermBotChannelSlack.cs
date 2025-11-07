using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Manages a azurerm_bot_channel_slack resource.
/// </summary>
public class AzurermBotChannelSlack : TerraformResource
{
    public AzurermBotChannelSlack(string name) : base("azurerm_bot_channel_slack", name)
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
    /// The client_id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? ClientId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("client_id");
        set => this.WithProperty("client_id", value);
    }

    /// <summary>
    /// The client_secret attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? ClientSecret
    {
        get => GetProperty<TerraformLiteralProperty<string>>("client_secret");
        set => this.WithProperty("client_secret", value);
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
    /// The landing_page_url attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? LandingPageUrl
    {
        get => GetProperty<TerraformLiteralProperty<string>>("landing_page_url");
        set => this.WithProperty("landing_page_url", value);
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

    /// <summary>
    /// The signing_secret attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? SigningSecret
    {
        get => GetProperty<TerraformLiteralProperty<string>>("signing_secret");
        set => this.WithProperty("signing_secret", value);
    }

    /// <summary>
    /// The verification_token attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? VerificationToken
    {
        get => GetProperty<TerraformLiteralProperty<string>>("verification_token");
        set => this.WithProperty("verification_token", value);
    }

}

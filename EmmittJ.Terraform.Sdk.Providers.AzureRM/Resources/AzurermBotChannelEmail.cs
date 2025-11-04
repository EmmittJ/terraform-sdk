using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Manages a azurerm_bot_channel_email resource.
/// </summary>
public class AzurermBotChannelEmail : TerraformResource
{
    public AzurermBotChannelEmail(string name) : base("azurerm_bot_channel_email", name)
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
    /// The email_address attribute.
    /// </summary>
    public string? EmailAddress
    {
        get => GetProperty<TerraformLiteralProperty<string>>("email_address")?.Value;
        set => this.WithProperty("email_address", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The email_password attribute.
    /// </summary>
    public string? EmailPassword
    {
        get => GetProperty<TerraformLiteralProperty<string>>("email_password")?.Value;
        set => this.WithProperty("email_password", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The magic_code attribute.
    /// </summary>
    public string? MagicCode
    {
        get => GetProperty<TerraformLiteralProperty<string>>("magic_code")?.Value;
        set => this.WithProperty("magic_code", value == null ? null : new TerraformLiteralProperty<string>(value));
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

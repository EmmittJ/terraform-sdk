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
    public TerraformLiteralProperty<string>? BotName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("bot_name");
        set => this.WithProperty("bot_name", value);
    }

    /// <summary>
    /// The email_address attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? EmailAddress
    {
        get => GetProperty<TerraformLiteralProperty<string>>("email_address");
        set => this.WithProperty("email_address", value);
    }

    /// <summary>
    /// The email_password attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? EmailPassword
    {
        get => GetProperty<TerraformLiteralProperty<string>>("email_password");
        set => this.WithProperty("email_password", value);
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
    /// The magic_code attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? MagicCode
    {
        get => GetProperty<TerraformLiteralProperty<string>>("magic_code");
        set => this.WithProperty("magic_code", value);
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

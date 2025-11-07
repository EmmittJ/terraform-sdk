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
    public TerraformProperty<string>? BotName
    {
        get => GetProperty<TerraformProperty<string>>("bot_name");
        set => this.WithProperty("bot_name", value);
    }

    /// <summary>
    /// The email_address attribute.
    /// </summary>
    public TerraformProperty<string>? EmailAddress
    {
        get => GetProperty<TerraformProperty<string>>("email_address");
        set => this.WithProperty("email_address", value);
    }

    /// <summary>
    /// The email_password attribute.
    /// </summary>
    public TerraformProperty<string>? EmailPassword
    {
        get => GetProperty<TerraformProperty<string>>("email_password");
        set => this.WithProperty("email_password", value);
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
    public TerraformProperty<string>? Location
    {
        get => GetProperty<TerraformProperty<string>>("location");
        set => this.WithProperty("location", value);
    }

    /// <summary>
    /// The magic_code attribute.
    /// </summary>
    public TerraformProperty<string>? MagicCode
    {
        get => GetProperty<TerraformProperty<string>>("magic_code");
        set => this.WithProperty("magic_code", value);
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    public TerraformProperty<string>? ResourceGroupName
    {
        get => GetProperty<TerraformProperty<string>>("resource_group_name");
        set => this.WithProperty("resource_group_name", value);
    }

}

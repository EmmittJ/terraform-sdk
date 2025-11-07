using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Manages a azurerm_bot_channel_sms resource.
/// </summary>
public class AzurermBotChannelSms : TerraformResource
{
    public AzurermBotChannelSms(string name) : base("azurerm_bot_channel_sms", name)
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
    /// The phone_number attribute.
    /// </summary>
    public TerraformProperty<string>? PhoneNumber
    {
        get => GetProperty<TerraformProperty<string>>("phone_number");
        set => this.WithProperty("phone_number", value);
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    public TerraformProperty<string>? ResourceGroupName
    {
        get => GetProperty<TerraformProperty<string>>("resource_group_name");
        set => this.WithProperty("resource_group_name", value);
    }

    /// <summary>
    /// The sms_channel_account_security_id attribute.
    /// </summary>
    public TerraformProperty<string>? SmsChannelAccountSecurityId
    {
        get => GetProperty<TerraformProperty<string>>("sms_channel_account_security_id");
        set => this.WithProperty("sms_channel_account_security_id", value);
    }

    /// <summary>
    /// The sms_channel_auth_token attribute.
    /// </summary>
    public TerraformProperty<string>? SmsChannelAuthToken
    {
        get => GetProperty<TerraformProperty<string>>("sms_channel_auth_token");
        set => this.WithProperty("sms_channel_auth_token", value);
    }

}

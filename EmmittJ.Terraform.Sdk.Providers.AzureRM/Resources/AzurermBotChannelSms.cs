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
    public string? BotName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("bot_name")?.Value;
        set => this.WithProperty("bot_name", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The phone_number attribute.
    /// </summary>
    public string? PhoneNumber
    {
        get => GetProperty<TerraformLiteralProperty<string>>("phone_number")?.Value;
        set => this.WithProperty("phone_number", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    public string? ResourceGroupName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("resource_group_name")?.Value;
        set => this.WithProperty("resource_group_name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The sms_channel_account_security_id attribute.
    /// </summary>
    public string? SmsChannelAccountSecurityId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("sms_channel_account_security_id")?.Value;
        set => this.WithProperty("sms_channel_account_security_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The sms_channel_auth_token attribute.
    /// </summary>
    public string? SmsChannelAuthToken
    {
        get => GetProperty<TerraformLiteralProperty<string>>("sms_channel_auth_token")?.Value;
        set => this.WithProperty("sms_channel_auth_token", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

}

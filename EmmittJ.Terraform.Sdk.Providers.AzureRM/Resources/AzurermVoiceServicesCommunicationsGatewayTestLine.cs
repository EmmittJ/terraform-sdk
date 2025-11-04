using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Manages a azurerm_voice_services_communications_gateway_test_line resource.
/// </summary>
public class AzurermVoiceServicesCommunicationsGatewayTestLine : TerraformResource
{
    public AzurermVoiceServicesCommunicationsGatewayTestLine(string name) : base("azurerm_voice_services_communications_gateway_test_line", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
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
    /// The name attribute.
    /// </summary>
    public string? Name
    {
        get => GetProperty<TerraformLiteralProperty<string>>("name")?.Value;
        set => this.WithProperty("name", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The purpose attribute.
    /// </summary>
    public string? Purpose
    {
        get => GetProperty<TerraformLiteralProperty<string>>("purpose")?.Value;
        set => this.WithProperty("purpose", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, string>? Tags
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("tags")?.Value;
        set => this.WithProperty("tags", value == null ? null : new TerraformLiteralProperty<Dictionary<string, string>>(value));
    }

    /// <summary>
    /// The voice_services_communications_gateway_id attribute.
    /// </summary>
    public string? VoiceServicesCommunicationsGatewayId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("voice_services_communications_gateway_id")?.Value;
        set => this.WithProperty("voice_services_communications_gateway_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

}

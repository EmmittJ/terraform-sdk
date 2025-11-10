using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermVoiceServicesCommunicationsGatewayTestLineTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformProperty<string>? Create
    {
        get => GetProperty<TerraformProperty<string>>("create");
        set => WithProperty("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        get => GetProperty<TerraformProperty<string>>("delete");
        set => WithProperty("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformProperty<string>? Read
    {
        get => GetProperty<TerraformProperty<string>>("read");
        set => WithProperty("read", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformProperty<string>? Update
    {
        get => GetProperty<TerraformProperty<string>>("update");
        set => WithProperty("update", value);
    }

}

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
    public TerraformProperty<string>? Id
    {
        get => GetProperty<TerraformProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// The location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformProperty<string> Location
    {
        get => GetProperty<TerraformProperty<string>>("location");
        set => this.WithProperty("location", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// The phone_number attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PhoneNumber is required")]
    public required TerraformProperty<string> PhoneNumber
    {
        get => GetProperty<TerraformProperty<string>>("phone_number");
        set => this.WithProperty("phone_number", value);
    }

    /// <summary>
    /// The purpose attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Purpose is required")]
    public required TerraformProperty<string> Purpose
    {
        get => GetProperty<TerraformProperty<string>>("purpose");
        set => this.WithProperty("purpose", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? Tags
    {
        get => GetProperty<Dictionary<string, TerraformProperty<string>>>("tags");
        set => this.WithProperty("tags", value);
    }

    /// <summary>
    /// The voice_services_communications_gateway_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "VoiceServicesCommunicationsGatewayId is required")]
    public required TerraformProperty<string> VoiceServicesCommunicationsGatewayId
    {
        get => GetProperty<TerraformProperty<string>>("voice_services_communications_gateway_id");
        set => this.WithProperty("voice_services_communications_gateway_id", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermVoiceServicesCommunicationsGatewayTestLineTimeoutsBlock? Timeouts
    {
        get => GetProperty<AzurermVoiceServicesCommunicationsGatewayTestLineTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
    }

}

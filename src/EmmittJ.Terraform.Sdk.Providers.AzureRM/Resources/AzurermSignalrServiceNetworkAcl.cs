using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Manages a azurerm_signalr_service_network_acl resource.
/// </summary>
public class AzurermSignalrServiceNetworkAcl : TerraformResource
{
    public AzurermSignalrServiceNetworkAcl(string name) : base("azurerm_signalr_service_network_acl", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
    }

    /// <summary>
    /// The default_action attribute.
    /// </summary>
    public string? DefaultAction
    {
        get => GetProperty<TerraformLiteralProperty<string>>("default_action")?.Value;
        set => this.WithProperty("default_action", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The signalr_service_id attribute.
    /// </summary>
    public string? SignalrServiceId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("signalr_service_id")?.Value;
        set => this.WithProperty("signalr_service_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

}

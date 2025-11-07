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
    public TerraformProperty<string>? DefaultAction
    {
        get => GetProperty<TerraformProperty<string>>("default_action");
        set => this.WithProperty("default_action", value);
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
    /// The signalr_service_id attribute.
    /// </summary>
    public TerraformProperty<string>? SignalrServiceId
    {
        get => GetProperty<TerraformProperty<string>>("signalr_service_id");
        set => this.WithProperty("signalr_service_id", value);
    }

}

using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Manages a azurerm_app_service_slot_custom_hostname_binding resource.
/// </summary>
public class AzurermAppServiceSlotCustomHostnameBinding : TerraformResource
{
    public AzurermAppServiceSlotCustomHostnameBinding(string name) : base("azurerm_app_service_slot_custom_hostname_binding", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("virtual_ip");
    }

    /// <summary>
    /// The app_service_slot_id attribute.
    /// </summary>
    public TerraformProperty<string>? AppServiceSlotId
    {
        get => GetProperty<TerraformProperty<string>>("app_service_slot_id");
        set => this.WithProperty("app_service_slot_id", value);
    }

    /// <summary>
    /// The hostname attribute.
    /// </summary>
    public TerraformProperty<string>? Hostname
    {
        get => GetProperty<TerraformProperty<string>>("hostname");
        set => this.WithProperty("hostname", value);
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
    /// The ssl_state attribute.
    /// </summary>
    public TerraformProperty<string>? SslState
    {
        get => GetProperty<TerraformProperty<string>>("ssl_state");
        set => this.WithProperty("ssl_state", value);
    }

    /// <summary>
    /// The thumbprint attribute.
    /// </summary>
    public TerraformProperty<string>? Thumbprint
    {
        get => GetProperty<TerraformProperty<string>>("thumbprint");
        set => this.WithProperty("thumbprint", value);
    }

    /// <summary>
    /// The virtual_ip attribute.
    /// </summary>
    public TerraformExpression VirtualIp => this["virtual_ip"];

}

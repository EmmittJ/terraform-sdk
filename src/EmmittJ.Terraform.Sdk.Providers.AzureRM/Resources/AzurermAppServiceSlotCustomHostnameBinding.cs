using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermAppServiceSlotCustomHostnameBindingTimeoutsBlock : TerraformBlock
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

}

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
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AppServiceSlotId is required")]
    public required TerraformProperty<string> AppServiceSlotId
    {
        get => GetProperty<TerraformProperty<string>>("app_service_slot_id");
        set => this.WithProperty("app_service_slot_id", value);
    }

    /// <summary>
    /// The hostname attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Hostname is required")]
    public required TerraformProperty<string> Hostname
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
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermAppServiceSlotCustomHostnameBindingTimeoutsBlock? Timeouts
    {
        get => GetProperty<AzurermAppServiceSlotCustomHostnameBindingTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
    }

    /// <summary>
    /// The virtual_ip attribute.
    /// </summary>
    public TerraformExpression VirtualIp => this["virtual_ip"];

}

using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermAppServiceCustomHostnameBindingTimeoutsBlock : TerraformBlock
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
/// Manages a azurerm_app_service_custom_hostname_binding resource.
/// </summary>
public class AzurermAppServiceCustomHostnameBinding : TerraformResource
{
    public AzurermAppServiceCustomHostnameBinding(string name) : base("azurerm_app_service_custom_hostname_binding", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.WithOutput("virtual_ip");
    }

    /// <summary>
    /// The app_service_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AppServiceName is required")]
    public required TerraformProperty<string> AppServiceName
    {
        get => GetRequiredProperty<TerraformProperty<string>>("app_service_name");
        set => this.WithProperty("app_service_name", value);
    }

    /// <summary>
    /// The hostname attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Hostname is required")]
    public required TerraformProperty<string> Hostname
    {
        get => GetRequiredProperty<TerraformProperty<string>>("hostname");
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
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    public required TerraformProperty<string> ResourceGroupName
    {
        get => GetRequiredProperty<TerraformProperty<string>>("resource_group_name");
        set => this.WithProperty("resource_group_name", value);
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
    public AzurermAppServiceCustomHostnameBindingTimeoutsBlock? Timeouts
    {
        get => GetProperty<AzurermAppServiceCustomHostnameBindingTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
    }

    /// <summary>
    /// The virtual_ip attribute.
    /// </summary>
    public TerraformExpression VirtualIp => this["virtual_ip"];

}

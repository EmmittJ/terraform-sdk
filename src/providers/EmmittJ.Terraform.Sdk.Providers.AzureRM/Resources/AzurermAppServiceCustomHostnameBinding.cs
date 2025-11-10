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
        set => SetProperty("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        set => SetProperty("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformProperty<string>? Read
    {
        set => SetProperty("read", value);
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
        SetOutput("virtual_ip");
        SetOutput("app_service_name");
        SetOutput("hostname");
        SetOutput("id");
        SetOutput("resource_group_name");
        SetOutput("ssl_state");
        SetOutput("thumbprint");
    }

    /// <summary>
    /// The app_service_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AppServiceName is required")]
    public required TerraformProperty<string> AppServiceName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("app_service_name");
        set => SetProperty("app_service_name", value);
    }

    /// <summary>
    /// The hostname attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Hostname is required")]
    public required TerraformProperty<string> Hostname
    {
        get => GetRequiredOutput<TerraformProperty<string>>("hostname");
        set => SetProperty("hostname", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string> Id
    {
        get => GetRequiredOutput<TerraformProperty<string>>("id");
        set => SetProperty("id", value);
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    public required TerraformProperty<string> ResourceGroupName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("resource_group_name");
        set => SetProperty("resource_group_name", value);
    }

    /// <summary>
    /// The ssl_state attribute.
    /// </summary>
    public TerraformProperty<string> SslState
    {
        get => GetRequiredOutput<TerraformProperty<string>>("ssl_state");
        set => SetProperty("ssl_state", value);
    }

    /// <summary>
    /// The thumbprint attribute.
    /// </summary>
    public TerraformProperty<string> Thumbprint
    {
        get => GetRequiredOutput<TerraformProperty<string>>("thumbprint");
        set => SetProperty("thumbprint", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermAppServiceCustomHostnameBindingTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

    /// <summary>
    /// The virtual_ip attribute.
    /// </summary>
    public TerraformExpression VirtualIp => this["virtual_ip"];

}

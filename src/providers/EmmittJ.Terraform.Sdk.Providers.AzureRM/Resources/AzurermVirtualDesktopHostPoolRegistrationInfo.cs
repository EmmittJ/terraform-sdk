using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermVirtualDesktopHostPoolRegistrationInfoTimeoutsBlock : TerraformBlock
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

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformProperty<string>? Update
    {
        set => SetProperty("update", value);
    }

}

/// <summary>
/// Manages a azurerm_virtual_desktop_host_pool_registration_info resource.
/// </summary>
public class AzurermVirtualDesktopHostPoolRegistrationInfo : TerraformResource
{
    public AzurermVirtualDesktopHostPoolRegistrationInfo(string name) : base("azurerm_virtual_desktop_host_pool_registration_info", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("token");
        SetOutput("expiration_date");
        SetOutput("hostpool_id");
        SetOutput("id");
    }

    /// <summary>
    /// The expiration_date attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ExpirationDate is required")]
    public required TerraformProperty<string> ExpirationDate
    {
        get => GetRequiredOutput<TerraformProperty<string>>("expiration_date");
        set => SetProperty("expiration_date", value);
    }

    /// <summary>
    /// The hostpool_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "HostpoolId is required")]
    public required TerraformProperty<string> HostpoolId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("hostpool_id");
        set => SetProperty("hostpool_id", value);
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
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermVirtualDesktopHostPoolRegistrationInfoTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

    /// <summary>
    /// The token attribute.
    /// </summary>
    public TerraformExpression Token => this["token"];

}

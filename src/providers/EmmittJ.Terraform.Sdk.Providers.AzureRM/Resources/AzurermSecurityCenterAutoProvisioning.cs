using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermSecurityCenterAutoProvisioningTimeoutsBlock : TerraformBlock
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
/// Manages a azurerm_security_center_auto_provisioning resource.
/// </summary>
[Obsolete("This resource is deprecated.")]
public class AzurermSecurityCenterAutoProvisioning : TerraformResource
{
    public AzurermSecurityCenterAutoProvisioning(string name) : base("azurerm_security_center_auto_provisioning", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("auto_provision");
        SetOutput("id");
    }

    /// <summary>
    /// The auto_provision attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AutoProvision is required")]
    public required TerraformProperty<string> AutoProvision
    {
        get => GetRequiredOutput<TerraformProperty<string>>("auto_provision");
        set => SetProperty("auto_provision", value);
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
    public AzurermSecurityCenterAutoProvisioningTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

}

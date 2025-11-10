using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermDedicatedHostTimeoutsBlock : TerraformBlock
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
/// Manages a azurerm_dedicated_host resource.
/// </summary>
public class AzurermDedicatedHost : TerraformResource
{
    public AzurermDedicatedHost(string name) : base("azurerm_dedicated_host", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("auto_replace_on_failure");
        SetOutput("dedicated_host_group_id");
        SetOutput("id");
        SetOutput("license_type");
        SetOutput("location");
        SetOutput("name");
        SetOutput("platform_fault_domain");
        SetOutput("sku_name");
        SetOutput("tags");
    }

    /// <summary>
    /// The auto_replace_on_failure attribute.
    /// </summary>
    public TerraformProperty<bool> AutoReplaceOnFailure
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("auto_replace_on_failure");
        set => SetProperty("auto_replace_on_failure", value);
    }

    /// <summary>
    /// The dedicated_host_group_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DedicatedHostGroupId is required")]
    public required TerraformProperty<string> DedicatedHostGroupId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("dedicated_host_group_id");
        set => SetProperty("dedicated_host_group_id", value);
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
    /// The license_type attribute.
    /// </summary>
    public TerraformProperty<string> LicenseType
    {
        get => GetRequiredOutput<TerraformProperty<string>>("license_type");
        set => SetProperty("license_type", value);
    }

    /// <summary>
    /// The location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformProperty<string> Location
    {
        get => GetRequiredOutput<TerraformProperty<string>>("location");
        set => SetProperty("location", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetRequiredOutput<TerraformProperty<string>>("name");
        set => SetProperty("name", value);
    }

    /// <summary>
    /// The platform_fault_domain attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PlatformFaultDomain is required")]
    public required TerraformProperty<double> PlatformFaultDomain
    {
        get => GetRequiredOutput<TerraformProperty<double>>("platform_fault_domain");
        set => SetProperty("platform_fault_domain", value);
    }

    /// <summary>
    /// The sku_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SkuName is required")]
    public required TerraformProperty<string> SkuName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("sku_name");
        set => SetProperty("sku_name", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>> Tags
    {
        get => GetRequiredOutput<Dictionary<string, TerraformProperty<string>>>("tags");
        set => SetProperty("tags", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermDedicatedHostTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

}

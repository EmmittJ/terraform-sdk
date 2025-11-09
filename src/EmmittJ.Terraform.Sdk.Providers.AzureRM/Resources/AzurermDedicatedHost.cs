using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

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
    }

    /// <summary>
    /// The auto_replace_on_failure attribute.
    /// </summary>
    public TerraformProperty<bool>? AutoReplaceOnFailure
    {
        get => GetProperty<TerraformProperty<bool>>("auto_replace_on_failure");
        set => this.WithProperty("auto_replace_on_failure", value);
    }

    /// <summary>
    /// The dedicated_host_group_id attribute.
    /// </summary>
    public TerraformProperty<string>? DedicatedHostGroupId
    {
        get => GetProperty<TerraformProperty<string>>("dedicated_host_group_id");
        set => this.WithProperty("dedicated_host_group_id", value);
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
    /// The license_type attribute.
    /// </summary>
    public TerraformProperty<string>? LicenseType
    {
        get => GetProperty<TerraformProperty<string>>("license_type");
        set => this.WithProperty("license_type", value);
    }

    /// <summary>
    /// The location attribute.
    /// </summary>
    public TerraformProperty<string>? Location
    {
        get => GetProperty<TerraformProperty<string>>("location");
        set => this.WithProperty("location", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    public TerraformProperty<string>? Name
    {
        get => GetProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// The platform_fault_domain attribute.
    /// </summary>
    public TerraformProperty<double>? PlatformFaultDomain
    {
        get => GetProperty<TerraformProperty<double>>("platform_fault_domain");
        set => this.WithProperty("platform_fault_domain", value);
    }

    /// <summary>
    /// The sku_name attribute.
    /// </summary>
    public TerraformProperty<string>? SkuName
    {
        get => GetProperty<TerraformProperty<string>>("sku_name");
        set => this.WithProperty("sku_name", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMapProperty<string>? Tags
    {
        get => GetProperty<TerraformMapProperty<string>>("tags");
        set => this.WithProperty("tags", value);
    }

}

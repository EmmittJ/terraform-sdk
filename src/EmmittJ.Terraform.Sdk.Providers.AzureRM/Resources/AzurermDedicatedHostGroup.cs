using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Manages a azurerm_dedicated_host_group resource.
/// </summary>
public class AzurermDedicatedHostGroup : TerraformResource
{
    public AzurermDedicatedHostGroup(string name) : base("azurerm_dedicated_host_group", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
    }

    /// <summary>
    /// The automatic_placement_enabled attribute.
    /// </summary>
    public bool? AutomaticPlacementEnabled
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("automatic_placement_enabled")?.Value;
        set => this.WithProperty("automatic_placement_enabled", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
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
    /// The location attribute.
    /// </summary>
    public string? Location
    {
        get => GetProperty<TerraformLiteralProperty<string>>("location")?.Value;
        set => this.WithProperty("location", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    public string? Name
    {
        get => GetProperty<TerraformLiteralProperty<string>>("name")?.Value;
        set => this.WithProperty("name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The platform_fault_domain_count attribute.
    /// </summary>
    public double? PlatformFaultDomainCount
    {
        get => GetProperty<TerraformLiteralProperty<double>>("platform_fault_domain_count")?.Value;
        set => this.WithProperty("platform_fault_domain_count", value == null ? null : new TerraformLiteralProperty<double>(value.Value));
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    public string? ResourceGroupName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("resource_group_name")?.Value;
        set => this.WithProperty("resource_group_name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, string>? Tags
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("tags")?.Value;
        set => this.WithProperty("tags", value == null ? null : new TerraformLiteralProperty<Dictionary<string, string>>(value));
    }

    /// <summary>
    /// The zone attribute.
    /// </summary>
    public string? Zone
    {
        get => GetProperty<TerraformLiteralProperty<string>>("zone")?.Value;
        set => this.WithProperty("zone", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

}

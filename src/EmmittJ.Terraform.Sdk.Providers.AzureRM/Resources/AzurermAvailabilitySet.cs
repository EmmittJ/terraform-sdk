using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Manages a azurerm_availability_set resource.
/// </summary>
public class AzurermAvailabilitySet : TerraformResource
{
    public AzurermAvailabilitySet(string name) : base("azurerm_availability_set", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
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
    /// The managed attribute.
    /// </summary>
    public bool? Managed
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("managed")?.Value;
        set => this.WithProperty("managed", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
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
    /// The platform_update_domain_count attribute.
    /// </summary>
    public double? PlatformUpdateDomainCount
    {
        get => GetProperty<TerraformLiteralProperty<double>>("platform_update_domain_count")?.Value;
        set => this.WithProperty("platform_update_domain_count", value == null ? null : new TerraformLiteralProperty<double>(value.Value));
    }

    /// <summary>
    /// The proximity_placement_group_id attribute.
    /// </summary>
    public string? ProximityPlacementGroupId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("proximity_placement_group_id")?.Value;
        set => this.WithProperty("proximity_placement_group_id", value == null ? null : new TerraformLiteralProperty<string>(value));
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

}

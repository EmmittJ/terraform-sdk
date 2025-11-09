using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Manages a azurerm_mobile_network_slice resource.
/// </summary>
public class AzurermMobileNetworkSlice : TerraformResource
{
    public AzurermMobileNetworkSlice(string name) : base("azurerm_mobile_network_slice", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformProperty<string>? Description
    {
        get => GetProperty<TerraformProperty<string>>("description");
        set => this.WithProperty("description", value);
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
    /// The location attribute.
    /// </summary>
    public TerraformProperty<string>? Location
    {
        get => GetProperty<TerraformProperty<string>>("location");
        set => this.WithProperty("location", value);
    }

    /// <summary>
    /// The mobile_network_id attribute.
    /// </summary>
    public TerraformProperty<string>? MobileNetworkId
    {
        get => GetProperty<TerraformProperty<string>>("mobile_network_id");
        set => this.WithProperty("mobile_network_id", value);
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
    /// The slice_differentiator attribute.
    /// </summary>
    public TerraformProperty<string>? SliceDifferentiator
    {
        get => GetProperty<TerraformProperty<string>>("slice_differentiator");
        set => this.WithProperty("slice_differentiator", value);
    }

    /// <summary>
    /// The slice_service_type attribute.
    /// </summary>
    public TerraformProperty<double>? SliceServiceType
    {
        get => GetProperty<TerraformProperty<double>>("slice_service_type");
        set => this.WithProperty("slice_service_type", value);
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

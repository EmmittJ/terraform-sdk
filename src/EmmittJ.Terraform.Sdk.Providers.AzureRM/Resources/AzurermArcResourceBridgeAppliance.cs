using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Manages a azurerm_arc_resource_bridge_appliance resource.
/// </summary>
public class AzurermArcResourceBridgeAppliance : TerraformResource
{
    public AzurermArcResourceBridgeAppliance(string name) : base("azurerm_arc_resource_bridge_appliance", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
    }

    /// <summary>
    /// The distro attribute.
    /// </summary>
    public TerraformProperty<string>? Distro
    {
        get => GetProperty<TerraformProperty<string>>("distro");
        set => this.WithProperty("distro", value);
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
    /// The infrastructure_provider attribute.
    /// </summary>
    public TerraformProperty<string>? InfrastructureProvider
    {
        get => GetProperty<TerraformProperty<string>>("infrastructure_provider");
        set => this.WithProperty("infrastructure_provider", value);
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
    /// The public_key_base64 attribute.
    /// </summary>
    public TerraformProperty<string>? PublicKeyBase64
    {
        get => GetProperty<TerraformProperty<string>>("public_key_base64");
        set => this.WithProperty("public_key_base64", value);
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    public TerraformProperty<string>? ResourceGroupName
    {
        get => GetProperty<TerraformProperty<string>>("resource_group_name");
        set => this.WithProperty("resource_group_name", value);
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

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
    public TerraformLiteralProperty<string>? Distro
    {
        get => GetProperty<TerraformLiteralProperty<string>>("distro");
        set => this.WithProperty("distro", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// The infrastructure_provider attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? InfrastructureProvider
    {
        get => GetProperty<TerraformLiteralProperty<string>>("infrastructure_provider");
        set => this.WithProperty("infrastructure_provider", value);
    }

    /// <summary>
    /// The location attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Location
    {
        get => GetProperty<TerraformLiteralProperty<string>>("location");
        set => this.WithProperty("location", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Name
    {
        get => GetProperty<TerraformLiteralProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// The public_key_base64 attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? PublicKeyBase64
    {
        get => GetProperty<TerraformLiteralProperty<string>>("public_key_base64");
        set => this.WithProperty("public_key_base64", value);
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? ResourceGroupName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("resource_group_name");
        set => this.WithProperty("resource_group_name", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformLiteralProperty<Dictionary<string, string>>? Tags
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("tags");
        set => this.WithProperty("tags", value);
    }

}

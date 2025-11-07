using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Manages a azurerm_network_manager_static_member resource.
/// </summary>
public class AzurermNetworkManagerStaticMember : TerraformResource
{
    public AzurermNetworkManagerStaticMember(string name) : base("azurerm_network_manager_static_member", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("region");
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
    /// The name attribute.
    /// </summary>
    public TerraformProperty<string>? Name
    {
        get => GetProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// The network_group_id attribute.
    /// </summary>
    public TerraformProperty<string>? NetworkGroupId
    {
        get => GetProperty<TerraformProperty<string>>("network_group_id");
        set => this.WithProperty("network_group_id", value);
    }

    /// <summary>
    /// The target_virtual_network_id attribute.
    /// </summary>
    public TerraformProperty<string>? TargetVirtualNetworkId
    {
        get => GetProperty<TerraformProperty<string>>("target_virtual_network_id");
        set => this.WithProperty("target_virtual_network_id", value);
    }

    /// <summary>
    /// The region attribute.
    /// </summary>
    public TerraformExpression Region => this["region"];

}

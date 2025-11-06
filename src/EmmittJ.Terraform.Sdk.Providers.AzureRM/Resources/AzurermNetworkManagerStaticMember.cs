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
    public string? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id")?.Value;
        set => this.WithProperty("id", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The network_group_id attribute.
    /// </summary>
    public string? NetworkGroupId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("network_group_id")?.Value;
        set => this.WithProperty("network_group_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The target_virtual_network_id attribute.
    /// </summary>
    public string? TargetVirtualNetworkId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("target_virtual_network_id")?.Value;
        set => this.WithProperty("target_virtual_network_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The region attribute.
    /// </summary>
    public TerraformExpression Region => this["region"];

}

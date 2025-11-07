using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Manages a azurerm_dev_center_attached_network resource.
/// </summary>
public class AzurermDevCenterAttachedNetwork : TerraformResource
{
    public AzurermDevCenterAttachedNetwork(string name) : base("azurerm_dev_center_attached_network", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
    }

    /// <summary>
    /// The dev_center_id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? DevCenterId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("dev_center_id");
        set => this.WithProperty("dev_center_id", value);
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
    /// The name attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Name
    {
        get => GetProperty<TerraformLiteralProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// The network_connection_id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? NetworkConnectionId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("network_connection_id");
        set => this.WithProperty("network_connection_id", value);
    }

}

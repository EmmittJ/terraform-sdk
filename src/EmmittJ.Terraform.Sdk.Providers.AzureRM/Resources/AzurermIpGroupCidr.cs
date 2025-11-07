using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Manages a azurerm_ip_group_cidr resource.
/// </summary>
public class AzurermIpGroupCidr : TerraformResource
{
    public AzurermIpGroupCidr(string name) : base("azurerm_ip_group_cidr", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
    }

    /// <summary>
    /// The cidr attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Cidr
    {
        get => GetProperty<TerraformLiteralProperty<string>>("cidr");
        set => this.WithProperty("cidr", value);
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
    /// The ip_group_id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? IpGroupId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("ip_group_id");
        set => this.WithProperty("ip_group_id", value);
    }

}

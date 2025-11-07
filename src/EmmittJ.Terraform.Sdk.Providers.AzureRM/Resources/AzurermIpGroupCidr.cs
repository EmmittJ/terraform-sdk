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
    public TerraformProperty<string>? Cidr
    {
        get => GetProperty<TerraformProperty<string>>("cidr");
        set => this.WithProperty("cidr", value);
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
    /// The ip_group_id attribute.
    /// </summary>
    public TerraformProperty<string>? IpGroupId
    {
        get => GetProperty<TerraformProperty<string>>("ip_group_id");
        set => this.WithProperty("ip_group_id", value);
    }

}

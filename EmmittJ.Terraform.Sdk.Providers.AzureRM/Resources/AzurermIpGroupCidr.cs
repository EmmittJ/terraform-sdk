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
    public string? Cidr
    {
        get => GetProperty<TerraformLiteralProperty<string>>("cidr")?.Value;
        set => this.WithProperty("cidr", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The ip_group_id attribute.
    /// </summary>
    public string? IpGroupId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("ip_group_id")?.Value;
        set => this.WithProperty("ip_group_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

}

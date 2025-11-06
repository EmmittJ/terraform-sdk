using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Manages a azurerm_virtual_hub_ip resource.
/// </summary>
public class AzurermVirtualHubIp : TerraformResource
{
    public AzurermVirtualHubIp(string name) : base("azurerm_virtual_hub_ip", name)
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
    /// The name attribute.
    /// </summary>
    public string? Name
    {
        get => GetProperty<TerraformLiteralProperty<string>>("name")?.Value;
        set => this.WithProperty("name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The private_ip_address attribute.
    /// </summary>
    public string? PrivateIpAddress
    {
        get => GetProperty<TerraformLiteralProperty<string>>("private_ip_address")?.Value;
        set => this.WithProperty("private_ip_address", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The private_ip_allocation_method attribute.
    /// </summary>
    public string? PrivateIpAllocationMethod
    {
        get => GetProperty<TerraformLiteralProperty<string>>("private_ip_allocation_method")?.Value;
        set => this.WithProperty("private_ip_allocation_method", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The public_ip_address_id attribute.
    /// </summary>
    public string? PublicIpAddressId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("public_ip_address_id")?.Value;
        set => this.WithProperty("public_ip_address_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The subnet_id attribute.
    /// </summary>
    public string? SubnetId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("subnet_id")?.Value;
        set => this.WithProperty("subnet_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The virtual_hub_id attribute.
    /// </summary>
    public string? VirtualHubId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("virtual_hub_id")?.Value;
        set => this.WithProperty("virtual_hub_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

}

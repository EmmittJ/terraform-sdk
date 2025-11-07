using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Manages a azurerm_spring_cloud_gateway_custom_domain resource.
/// </summary>
public class AzurermSpringCloudGatewayCustomDomain : TerraformResource
{
    public AzurermSpringCloudGatewayCustomDomain(string name) : base("azurerm_spring_cloud_gateway_custom_domain", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
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
    /// The spring_cloud_gateway_id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? SpringCloudGatewayId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("spring_cloud_gateway_id");
        set => this.WithProperty("spring_cloud_gateway_id", value);
    }

    /// <summary>
    /// The thumbprint attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Thumbprint
    {
        get => GetProperty<TerraformLiteralProperty<string>>("thumbprint");
        set => this.WithProperty("thumbprint", value);
    }

}

using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Manages a azurerm_spring_cloud_api_portal_custom_domain resource.
/// </summary>
public class AzurermSpringCloudApiPortalCustomDomain : TerraformResource
{
    public AzurermSpringCloudApiPortalCustomDomain(string name) : base("azurerm_spring_cloud_api_portal_custom_domain", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
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
    /// The spring_cloud_api_portal_id attribute.
    /// </summary>
    public TerraformProperty<string>? SpringCloudApiPortalId
    {
        get => GetProperty<TerraformProperty<string>>("spring_cloud_api_portal_id");
        set => this.WithProperty("spring_cloud_api_portal_id", value);
    }

    /// <summary>
    /// The thumbprint attribute.
    /// </summary>
    public TerraformProperty<string>? Thumbprint
    {
        get => GetProperty<TerraformProperty<string>>("thumbprint");
        set => this.WithProperty("thumbprint", value);
    }

}

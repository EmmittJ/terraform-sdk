using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Manages a azurerm_spring_cloud_dev_tool_portal resource.
/// </summary>
public class AzurermSpringCloudDevToolPortal : TerraformResource
{
    public AzurermSpringCloudDevToolPortal(string name) : base("azurerm_spring_cloud_dev_tool_portal", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
    }

    /// <summary>
    /// The application_accelerator_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? ApplicationAcceleratorEnabled
    {
        get => GetProperty<TerraformProperty<bool>>("application_accelerator_enabled");
        set => this.WithProperty("application_accelerator_enabled", value);
    }

    /// <summary>
    /// The application_live_view_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? ApplicationLiveViewEnabled
    {
        get => GetProperty<TerraformProperty<bool>>("application_live_view_enabled");
        set => this.WithProperty("application_live_view_enabled", value);
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
    /// The public_network_access_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? PublicNetworkAccessEnabled
    {
        get => GetProperty<TerraformProperty<bool>>("public_network_access_enabled");
        set => this.WithProperty("public_network_access_enabled", value);
    }

    /// <summary>
    /// The spring_cloud_service_id attribute.
    /// </summary>
    public TerraformProperty<string>? SpringCloudServiceId
    {
        get => GetProperty<TerraformProperty<string>>("spring_cloud_service_id");
        set => this.WithProperty("spring_cloud_service_id", value);
    }

}

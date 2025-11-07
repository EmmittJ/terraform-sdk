using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Manages a azurerm_spring_cloud_api_portal resource.
/// </summary>
public class AzurermSpringCloudApiPortal : TerraformResource
{
    public AzurermSpringCloudApiPortal(string name) : base("azurerm_spring_cloud_api_portal", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("url");
    }

    /// <summary>
    /// The api_try_out_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? ApiTryOutEnabled
    {
        get => GetProperty<TerraformProperty<bool>>("api_try_out_enabled");
        set => this.WithProperty("api_try_out_enabled", value);
    }

    /// <summary>
    /// The gateway_ids attribute.
    /// </summary>
    public TerraformProperty<HashSet<string>>? GatewayIds
    {
        get => GetProperty<TerraformProperty<HashSet<string>>>("gateway_ids");
        set => this.WithProperty("gateway_ids", value);
    }

    /// <summary>
    /// The https_only_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? HttpsOnlyEnabled
    {
        get => GetProperty<TerraformProperty<bool>>("https_only_enabled");
        set => this.WithProperty("https_only_enabled", value);
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
    /// The instance_count attribute.
    /// </summary>
    public TerraformProperty<double>? InstanceCount
    {
        get => GetProperty<TerraformProperty<double>>("instance_count");
        set => this.WithProperty("instance_count", value);
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

    /// <summary>
    /// The url attribute.
    /// </summary>
    public TerraformExpression Url => this["url"];

}

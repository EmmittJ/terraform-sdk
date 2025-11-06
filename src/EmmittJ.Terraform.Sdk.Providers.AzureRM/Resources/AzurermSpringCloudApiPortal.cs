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
    public bool? ApiTryOutEnabled
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("api_try_out_enabled")?.Value;
        set => this.WithProperty("api_try_out_enabled", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The gateway_ids attribute.
    /// </summary>
    public HashSet<string>? GatewayIds
    {
        get => GetProperty<TerraformLiteralProperty<HashSet<string>>>("gateway_ids")?.Value;
        set => this.WithProperty("gateway_ids", value == null ? null : new TerraformLiteralProperty<HashSet<string>>(value));
    }

    /// <summary>
    /// The https_only_enabled attribute.
    /// </summary>
    public bool? HttpsOnlyEnabled
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("https_only_enabled")?.Value;
        set => this.WithProperty("https_only_enabled", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
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
    /// The instance_count attribute.
    /// </summary>
    public double? InstanceCount
    {
        get => GetProperty<TerraformLiteralProperty<double>>("instance_count")?.Value;
        set => this.WithProperty("instance_count", value == null ? null : new TerraformLiteralProperty<double>(value.Value));
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
    /// The public_network_access_enabled attribute.
    /// </summary>
    public bool? PublicNetworkAccessEnabled
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("public_network_access_enabled")?.Value;
        set => this.WithProperty("public_network_access_enabled", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The spring_cloud_service_id attribute.
    /// </summary>
    public string? SpringCloudServiceId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("spring_cloud_service_id")?.Value;
        set => this.WithProperty("spring_cloud_service_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The url attribute.
    /// </summary>
    public TerraformExpression Url => this["url"];

}

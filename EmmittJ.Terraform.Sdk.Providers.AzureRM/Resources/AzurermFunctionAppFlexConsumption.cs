using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Manages a azurerm_function_app_flex_consumption resource.
/// </summary>
public class AzurermFunctionAppFlexConsumption : TerraformResource
{
    public AzurermFunctionAppFlexConsumption(string name) : base("azurerm_function_app_flex_consumption", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("custom_domain_verification_id");
        this.DeclareOutput("default_hostname");
        this.DeclareOutput("hosting_environment_id");
        this.DeclareOutput("kind");
        this.DeclareOutput("outbound_ip_address_list");
        this.DeclareOutput("outbound_ip_addresses");
        this.DeclareOutput("possible_outbound_ip_address_list");
        this.DeclareOutput("possible_outbound_ip_addresses");
        this.DeclareOutput("site_credential");
    }

    /// <summary>
    /// A map of key-value pairs for [App Settings](https://docs.microsoft.com/en-us/azure/azure-functions/functions-app-settings) and custom values.
    /// </summary>
    public Dictionary<string, string>? AppSettings
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("app_settings")?.Value;
        set => this.WithProperty("app_settings", value == null ? null : new TerraformLiteralProperty<Dictionary<string, string>>(value));
    }

    /// <summary>
    /// Should the function app use Client Certificates
    /// </summary>
    public bool? ClientCertificateEnabled
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("client_certificate_enabled")?.Value;
        set => this.WithProperty("client_certificate_enabled", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// Paths to exclude when using client certificates, separated by ;
    /// </summary>
    public string? ClientCertificateExclusionPaths
    {
        get => GetProperty<TerraformLiteralProperty<string>>("client_certificate_exclusion_paths")?.Value;
        set => this.WithProperty("client_certificate_exclusion_paths", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The mode of the Function App&#39;s client certificates requirement for incoming requests. Possible values are `Required`, `Optional`, and `OptionalInteractiveUser` 
    /// </summary>
    public string? ClientCertificateMode
    {
        get => GetProperty<TerraformLiteralProperty<string>>("client_certificate_mode")?.Value;
        set => this.WithProperty("client_certificate_mode", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// Is the Function App enabled.
    /// </summary>
    public bool? Enabled
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("enabled")?.Value;
        set => this.WithProperty("enabled", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The http_concurrency attribute.
    /// </summary>
    public double? HttpConcurrency
    {
        get => GetProperty<TerraformLiteralProperty<double>>("http_concurrency")?.Value;
        set => this.WithProperty("http_concurrency", value == null ? null : new TerraformLiteralProperty<double>(value.Value));
    }

    /// <summary>
    /// Can the Function App only be accessed via HTTPS?
    /// </summary>
    public bool? HttpsOnly
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("https_only")?.Value;
        set => this.WithProperty("https_only", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
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
    /// The instance_memory_in_mb attribute.
    /// </summary>
    public double? InstanceMemoryInMb
    {
        get => GetProperty<TerraformLiteralProperty<double>>("instance_memory_in_mb")?.Value;
        set => this.WithProperty("instance_memory_in_mb", value == null ? null : new TerraformLiteralProperty<double>(value.Value));
    }

    /// <summary>
    /// The location attribute.
    /// </summary>
    public string? Location
    {
        get => GetProperty<TerraformLiteralProperty<string>>("location")?.Value;
        set => this.WithProperty("location", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The maximum_instance_count attribute.
    /// </summary>
    public double? MaximumInstanceCount
    {
        get => GetProperty<TerraformLiteralProperty<double>>("maximum_instance_count")?.Value;
        set => this.WithProperty("maximum_instance_count", value == null ? null : new TerraformLiteralProperty<double>(value.Value));
    }

    /// <summary>
    /// Specifies the name of the Function App.
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
    /// The resource_group_name attribute.
    /// </summary>
    public string? ResourceGroupName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("resource_group_name")?.Value;
        set => this.WithProperty("resource_group_name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The runtime_name attribute.
    /// </summary>
    public string? RuntimeName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("runtime_name")?.Value;
        set => this.WithProperty("runtime_name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The runtime_version attribute.
    /// </summary>
    public string? RuntimeVersion
    {
        get => GetProperty<TerraformLiteralProperty<string>>("runtime_version")?.Value;
        set => this.WithProperty("runtime_version", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The ID of the App Service Plan within which to create this Function App
    /// </summary>
    public string? ServicePlanId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("service_plan_id")?.Value;
        set => this.WithProperty("service_plan_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The storage_access_key attribute.
    /// </summary>
    public string? StorageAccessKey
    {
        get => GetProperty<TerraformLiteralProperty<string>>("storage_access_key")?.Value;
        set => this.WithProperty("storage_access_key", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The storage_authentication_type attribute.
    /// </summary>
    public string? StorageAuthenticationType
    {
        get => GetProperty<TerraformLiteralProperty<string>>("storage_authentication_type")?.Value;
        set => this.WithProperty("storage_authentication_type", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The endpoint of the storage container where the function app&#39;s code is hosted.
    /// </summary>
    public string? StorageContainerEndpoint
    {
        get => GetProperty<TerraformLiteralProperty<string>>("storage_container_endpoint")?.Value;
        set => this.WithProperty("storage_container_endpoint", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The type of the storage container where the function app&#39;s code is hosted. Only `blobContainer` is supported currently.
    /// </summary>
    public string? StorageContainerType
    {
        get => GetProperty<TerraformLiteralProperty<string>>("storage_container_type")?.Value;
        set => this.WithProperty("storage_container_type", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The storage_user_assigned_identity_id attribute.
    /// </summary>
    public string? StorageUserAssignedIdentityId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("storage_user_assigned_identity_id")?.Value;
        set => this.WithProperty("storage_user_assigned_identity_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, string>? Tags
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("tags")?.Value;
        set => this.WithProperty("tags", value == null ? null : new TerraformLiteralProperty<Dictionary<string, string>>(value));
    }

    /// <summary>
    /// The virtual_network_subnet_id attribute.
    /// </summary>
    public string? VirtualNetworkSubnetId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("virtual_network_subnet_id")?.Value;
        set => this.WithProperty("virtual_network_subnet_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The webdeploy_publish_basic_authentication_enabled attribute.
    /// </summary>
    public bool? WebdeployPublishBasicAuthenticationEnabled
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("webdeploy_publish_basic_authentication_enabled")?.Value;
        set => this.WithProperty("webdeploy_publish_basic_authentication_enabled", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The local path and filename of the Zip packaged application to deploy to this Function App. **Note:** Using this value requires either `WEBSITE_RUN_FROM_PACKAGE=1` or `SCM_DO_BUILD_DURING_DEPLOYMENT=true` to be set on the App in `app_settings`.
    /// </summary>
    public string? ZipDeployFile
    {
        get => GetProperty<TerraformLiteralProperty<string>>("zip_deploy_file")?.Value;
        set => this.WithProperty("zip_deploy_file", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The custom_domain_verification_id attribute.
    /// </summary>
    public TerraformExpression CustomDomainVerificationId => this["custom_domain_verification_id"];

    /// <summary>
    /// The default_hostname attribute.
    /// </summary>
    public TerraformExpression DefaultHostname => this["default_hostname"];

    /// <summary>
    /// The hosting_environment_id attribute.
    /// </summary>
    public TerraformExpression HostingEnvironmentId => this["hosting_environment_id"];

    /// <summary>
    /// The kind attribute.
    /// </summary>
    public TerraformExpression Kind => this["kind"];

    /// <summary>
    /// The outbound_ip_address_list attribute.
    /// </summary>
    public TerraformExpression OutboundIpAddressList => this["outbound_ip_address_list"];

    /// <summary>
    /// The outbound_ip_addresses attribute.
    /// </summary>
    public TerraformExpression OutboundIpAddresses => this["outbound_ip_addresses"];

    /// <summary>
    /// The possible_outbound_ip_address_list attribute.
    /// </summary>
    public TerraformExpression PossibleOutboundIpAddressList => this["possible_outbound_ip_address_list"];

    /// <summary>
    /// The possible_outbound_ip_addresses attribute.
    /// </summary>
    public TerraformExpression PossibleOutboundIpAddresses => this["possible_outbound_ip_addresses"];

    /// <summary>
    /// The site_credential attribute.
    /// </summary>
    public TerraformExpression SiteCredential => this["site_credential"];

}

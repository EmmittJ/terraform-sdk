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
    public TerraformProperty<Dictionary<string, string>>? AppSettings
    {
        get => GetProperty<TerraformProperty<Dictionary<string, string>>>("app_settings");
        set => this.WithProperty("app_settings", value);
    }

    /// <summary>
    /// Should the function app use Client Certificates
    /// </summary>
    public TerraformProperty<bool>? ClientCertificateEnabled
    {
        get => GetProperty<TerraformProperty<bool>>("client_certificate_enabled");
        set => this.WithProperty("client_certificate_enabled", value);
    }

    /// <summary>
    /// Paths to exclude when using client certificates, separated by ;
    /// </summary>
    public TerraformProperty<string>? ClientCertificateExclusionPaths
    {
        get => GetProperty<TerraformProperty<string>>("client_certificate_exclusion_paths");
        set => this.WithProperty("client_certificate_exclusion_paths", value);
    }

    /// <summary>
    /// The mode of the Function App&#39;s client certificates requirement for incoming requests. Possible values are `Required`, `Optional`, and `OptionalInteractiveUser` 
    /// </summary>
    public TerraformProperty<string>? ClientCertificateMode
    {
        get => GetProperty<TerraformProperty<string>>("client_certificate_mode");
        set => this.WithProperty("client_certificate_mode", value);
    }

    /// <summary>
    /// Is the Function App enabled.
    /// </summary>
    public TerraformProperty<bool>? Enabled
    {
        get => GetProperty<TerraformProperty<bool>>("enabled");
        set => this.WithProperty("enabled", value);
    }

    /// <summary>
    /// The http_concurrency attribute.
    /// </summary>
    public TerraformProperty<double>? HttpConcurrency
    {
        get => GetProperty<TerraformProperty<double>>("http_concurrency");
        set => this.WithProperty("http_concurrency", value);
    }

    /// <summary>
    /// Can the Function App only be accessed via HTTPS?
    /// </summary>
    public TerraformProperty<bool>? HttpsOnly
    {
        get => GetProperty<TerraformProperty<bool>>("https_only");
        set => this.WithProperty("https_only", value);
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
    /// The instance_memory_in_mb attribute.
    /// </summary>
    public TerraformProperty<double>? InstanceMemoryInMb
    {
        get => GetProperty<TerraformProperty<double>>("instance_memory_in_mb");
        set => this.WithProperty("instance_memory_in_mb", value);
    }

    /// <summary>
    /// The location attribute.
    /// </summary>
    public TerraformProperty<string>? Location
    {
        get => GetProperty<TerraformProperty<string>>("location");
        set => this.WithProperty("location", value);
    }

    /// <summary>
    /// The maximum_instance_count attribute.
    /// </summary>
    public TerraformProperty<double>? MaximumInstanceCount
    {
        get => GetProperty<TerraformProperty<double>>("maximum_instance_count");
        set => this.WithProperty("maximum_instance_count", value);
    }

    /// <summary>
    /// Specifies the name of the Function App.
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
    /// The resource_group_name attribute.
    /// </summary>
    public TerraformProperty<string>? ResourceGroupName
    {
        get => GetProperty<TerraformProperty<string>>("resource_group_name");
        set => this.WithProperty("resource_group_name", value);
    }

    /// <summary>
    /// The runtime_name attribute.
    /// </summary>
    public TerraformProperty<string>? RuntimeName
    {
        get => GetProperty<TerraformProperty<string>>("runtime_name");
        set => this.WithProperty("runtime_name", value);
    }

    /// <summary>
    /// The runtime_version attribute.
    /// </summary>
    public TerraformProperty<string>? RuntimeVersion
    {
        get => GetProperty<TerraformProperty<string>>("runtime_version");
        set => this.WithProperty("runtime_version", value);
    }

    /// <summary>
    /// The ID of the App Service Plan within which to create this Function App
    /// </summary>
    public TerraformProperty<string>? ServicePlanId
    {
        get => GetProperty<TerraformProperty<string>>("service_plan_id");
        set => this.WithProperty("service_plan_id", value);
    }

    /// <summary>
    /// The storage_access_key attribute.
    /// </summary>
    public TerraformProperty<string>? StorageAccessKey
    {
        get => GetProperty<TerraformProperty<string>>("storage_access_key");
        set => this.WithProperty("storage_access_key", value);
    }

    /// <summary>
    /// The storage_authentication_type attribute.
    /// </summary>
    public TerraformProperty<string>? StorageAuthenticationType
    {
        get => GetProperty<TerraformProperty<string>>("storage_authentication_type");
        set => this.WithProperty("storage_authentication_type", value);
    }

    /// <summary>
    /// The endpoint of the storage container where the function app&#39;s code is hosted.
    /// </summary>
    public TerraformProperty<string>? StorageContainerEndpoint
    {
        get => GetProperty<TerraformProperty<string>>("storage_container_endpoint");
        set => this.WithProperty("storage_container_endpoint", value);
    }

    /// <summary>
    /// The type of the storage container where the function app&#39;s code is hosted. Only `blobContainer` is supported currently.
    /// </summary>
    public TerraformProperty<string>? StorageContainerType
    {
        get => GetProperty<TerraformProperty<string>>("storage_container_type");
        set => this.WithProperty("storage_container_type", value);
    }

    /// <summary>
    /// The storage_user_assigned_identity_id attribute.
    /// </summary>
    public TerraformProperty<string>? StorageUserAssignedIdentityId
    {
        get => GetProperty<TerraformProperty<string>>("storage_user_assigned_identity_id");
        set => this.WithProperty("storage_user_assigned_identity_id", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformProperty<Dictionary<string, string>>? Tags
    {
        get => GetProperty<TerraformProperty<Dictionary<string, string>>>("tags");
        set => this.WithProperty("tags", value);
    }

    /// <summary>
    /// The virtual_network_subnet_id attribute.
    /// </summary>
    public TerraformProperty<string>? VirtualNetworkSubnetId
    {
        get => GetProperty<TerraformProperty<string>>("virtual_network_subnet_id");
        set => this.WithProperty("virtual_network_subnet_id", value);
    }

    /// <summary>
    /// The webdeploy_publish_basic_authentication_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? WebdeployPublishBasicAuthenticationEnabled
    {
        get => GetProperty<TerraformProperty<bool>>("webdeploy_publish_basic_authentication_enabled");
        set => this.WithProperty("webdeploy_publish_basic_authentication_enabled", value);
    }

    /// <summary>
    /// The local path and filename of the Zip packaged application to deploy to this Function App. **Note:** Using this value requires either `WEBSITE_RUN_FROM_PACKAGE=1` or `SCM_DO_BUILD_DURING_DEPLOYMENT=true` to be set on the App in `app_settings`.
    /// </summary>
    public TerraformProperty<string>? ZipDeployFile
    {
        get => GetProperty<TerraformProperty<string>>("zip_deploy_file");
        set => this.WithProperty("zip_deploy_file", value);
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

using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Manages a azurerm_cognitive_account resource.
/// </summary>
public class AzurermCognitiveAccount : TerraformResource
{
    public AzurermCognitiveAccount(string name) : base("azurerm_cognitive_account", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("endpoint");
        this.DeclareOutput("primary_access_key");
        this.DeclareOutput("secondary_access_key");
    }

    /// <summary>
    /// The custom_question_answering_search_service_id attribute.
    /// </summary>
    public TerraformProperty<string>? CustomQuestionAnsweringSearchServiceId
    {
        get => GetProperty<TerraformProperty<string>>("custom_question_answering_search_service_id");
        set => this.WithProperty("custom_question_answering_search_service_id", value);
    }

    /// <summary>
    /// The custom_question_answering_search_service_key attribute.
    /// </summary>
    public TerraformProperty<string>? CustomQuestionAnsweringSearchServiceKey
    {
        get => GetProperty<TerraformProperty<string>>("custom_question_answering_search_service_key");
        set => this.WithProperty("custom_question_answering_search_service_key", value);
    }

    /// <summary>
    /// The custom_subdomain_name attribute.
    /// </summary>
    public TerraformProperty<string>? CustomSubdomainName
    {
        get => GetProperty<TerraformProperty<string>>("custom_subdomain_name");
        set => this.WithProperty("custom_subdomain_name", value);
    }

    /// <summary>
    /// The dynamic_throttling_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? DynamicThrottlingEnabled
    {
        get => GetProperty<TerraformProperty<bool>>("dynamic_throttling_enabled");
        set => this.WithProperty("dynamic_throttling_enabled", value);
    }

    /// <summary>
    /// The fqdns attribute.
    /// </summary>
    public TerraformProperty<List<string>>? Fqdns
    {
        get => GetProperty<TerraformProperty<List<string>>>("fqdns");
        set => this.WithProperty("fqdns", value);
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
    /// The kind attribute.
    /// </summary>
    public TerraformProperty<string>? Kind
    {
        get => GetProperty<TerraformProperty<string>>("kind");
        set => this.WithProperty("kind", value);
    }

    /// <summary>
    /// The local_auth_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? LocalAuthEnabled
    {
        get => GetProperty<TerraformProperty<bool>>("local_auth_enabled");
        set => this.WithProperty("local_auth_enabled", value);
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
    /// The metrics_advisor_aad_client_id attribute.
    /// </summary>
    public TerraformProperty<string>? MetricsAdvisorAadClientId
    {
        get => GetProperty<TerraformProperty<string>>("metrics_advisor_aad_client_id");
        set => this.WithProperty("metrics_advisor_aad_client_id", value);
    }

    /// <summary>
    /// The metrics_advisor_aad_tenant_id attribute.
    /// </summary>
    public TerraformProperty<string>? MetricsAdvisorAadTenantId
    {
        get => GetProperty<TerraformProperty<string>>("metrics_advisor_aad_tenant_id");
        set => this.WithProperty("metrics_advisor_aad_tenant_id", value);
    }

    /// <summary>
    /// The metrics_advisor_super_user_name attribute.
    /// </summary>
    public TerraformProperty<string>? MetricsAdvisorSuperUserName
    {
        get => GetProperty<TerraformProperty<string>>("metrics_advisor_super_user_name");
        set => this.WithProperty("metrics_advisor_super_user_name", value);
    }

    /// <summary>
    /// The metrics_advisor_website_name attribute.
    /// </summary>
    public TerraformProperty<string>? MetricsAdvisorWebsiteName
    {
        get => GetProperty<TerraformProperty<string>>("metrics_advisor_website_name");
        set => this.WithProperty("metrics_advisor_website_name", value);
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
    /// The outbound_network_access_restricted attribute.
    /// </summary>
    public TerraformProperty<bool>? OutboundNetworkAccessRestricted
    {
        get => GetProperty<TerraformProperty<bool>>("outbound_network_access_restricted");
        set => this.WithProperty("outbound_network_access_restricted", value);
    }

    /// <summary>
    /// The project_management_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? ProjectManagementEnabled
    {
        get => GetProperty<TerraformProperty<bool>>("project_management_enabled");
        set => this.WithProperty("project_management_enabled", value);
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
    /// The qna_runtime_endpoint attribute.
    /// </summary>
    public TerraformProperty<string>? QnaRuntimeEndpoint
    {
        get => GetProperty<TerraformProperty<string>>("qna_runtime_endpoint");
        set => this.WithProperty("qna_runtime_endpoint", value);
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
    /// The sku_name attribute.
    /// </summary>
    public TerraformProperty<string>? SkuName
    {
        get => GetProperty<TerraformProperty<string>>("sku_name");
        set => this.WithProperty("sku_name", value);
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
    /// The endpoint attribute.
    /// </summary>
    public TerraformExpression Endpoint => this["endpoint"];

    /// <summary>
    /// The primary_access_key attribute.
    /// </summary>
    public TerraformExpression PrimaryAccessKey => this["primary_access_key"];

    /// <summary>
    /// The secondary_access_key attribute.
    /// </summary>
    public TerraformExpression SecondaryAccessKey => this["secondary_access_key"];

}

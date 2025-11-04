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
    public string? CustomQuestionAnsweringSearchServiceId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("custom_question_answering_search_service_id")?.Value;
        set => this.WithProperty("custom_question_answering_search_service_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The custom_question_answering_search_service_key attribute.
    /// </summary>
    public string? CustomQuestionAnsweringSearchServiceKey
    {
        get => GetProperty<TerraformLiteralProperty<string>>("custom_question_answering_search_service_key")?.Value;
        set => this.WithProperty("custom_question_answering_search_service_key", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The custom_subdomain_name attribute.
    /// </summary>
    public string? CustomSubdomainName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("custom_subdomain_name")?.Value;
        set => this.WithProperty("custom_subdomain_name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The dynamic_throttling_enabled attribute.
    /// </summary>
    public bool? DynamicThrottlingEnabled
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("dynamic_throttling_enabled")?.Value;
        set => this.WithProperty("dynamic_throttling_enabled", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The fqdns attribute.
    /// </summary>
    public List<string>? Fqdns
    {
        get => GetProperty<TerraformLiteralProperty<List<string>>>("fqdns")?.Value;
        set => this.WithProperty("fqdns", value == null ? null : new TerraformLiteralProperty<List<string>>(value));
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
    /// The kind attribute.
    /// </summary>
    public string? Kind
    {
        get => GetProperty<TerraformLiteralProperty<string>>("kind")?.Value;
        set => this.WithProperty("kind", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The local_auth_enabled attribute.
    /// </summary>
    public bool? LocalAuthEnabled
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("local_auth_enabled")?.Value;
        set => this.WithProperty("local_auth_enabled", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
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
    /// The metrics_advisor_aad_client_id attribute.
    /// </summary>
    public string? MetricsAdvisorAadClientId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("metrics_advisor_aad_client_id")?.Value;
        set => this.WithProperty("metrics_advisor_aad_client_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The metrics_advisor_aad_tenant_id attribute.
    /// </summary>
    public string? MetricsAdvisorAadTenantId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("metrics_advisor_aad_tenant_id")?.Value;
        set => this.WithProperty("metrics_advisor_aad_tenant_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The metrics_advisor_super_user_name attribute.
    /// </summary>
    public string? MetricsAdvisorSuperUserName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("metrics_advisor_super_user_name")?.Value;
        set => this.WithProperty("metrics_advisor_super_user_name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The metrics_advisor_website_name attribute.
    /// </summary>
    public string? MetricsAdvisorWebsiteName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("metrics_advisor_website_name")?.Value;
        set => this.WithProperty("metrics_advisor_website_name", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The outbound_network_access_restricted attribute.
    /// </summary>
    public bool? OutboundNetworkAccessRestricted
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("outbound_network_access_restricted")?.Value;
        set => this.WithProperty("outbound_network_access_restricted", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The project_management_enabled attribute.
    /// </summary>
    public bool? ProjectManagementEnabled
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("project_management_enabled")?.Value;
        set => this.WithProperty("project_management_enabled", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
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
    /// The qna_runtime_endpoint attribute.
    /// </summary>
    public string? QnaRuntimeEndpoint
    {
        get => GetProperty<TerraformLiteralProperty<string>>("qna_runtime_endpoint")?.Value;
        set => this.WithProperty("qna_runtime_endpoint", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The sku_name attribute.
    /// </summary>
    public string? SkuName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("sku_name")?.Value;
        set => this.WithProperty("sku_name", value == null ? null : new TerraformLiteralProperty<string>(value));
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

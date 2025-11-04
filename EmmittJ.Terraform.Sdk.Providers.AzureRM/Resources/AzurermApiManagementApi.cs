using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Manages a azurerm_api_management_api resource.
/// </summary>
public class AzurermApiManagementApi : TerraformResource
{
    public AzurermApiManagementApi(string name) : base("azurerm_api_management_api", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("is_current");
        this.DeclareOutput("is_online");
    }

    /// <summary>
    /// The api_management_name attribute.
    /// </summary>
    public string? ApiManagementName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("api_management_name")?.Value;
        set => this.WithProperty("api_management_name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The api_type attribute.
    /// </summary>
    public string? ApiType
    {
        get => GetProperty<TerraformLiteralProperty<string>>("api_type")?.Value;
        set => this.WithProperty("api_type", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    public string? Description
    {
        get => GetProperty<TerraformLiteralProperty<string>>("description")?.Value;
        set => this.WithProperty("description", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The display_name attribute.
    /// </summary>
    public string? DisplayName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("display_name")?.Value;
        set => this.WithProperty("display_name", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The path attribute.
    /// </summary>
    public string? Path
    {
        get => GetProperty<TerraformLiteralProperty<string>>("path")?.Value;
        set => this.WithProperty("path", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The protocols attribute.
    /// </summary>
    public HashSet<string>? Protocols
    {
        get => GetProperty<TerraformLiteralProperty<HashSet<string>>>("protocols")?.Value;
        set => this.WithProperty("protocols", value == null ? null : new TerraformLiteralProperty<HashSet<string>>(value));
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
    /// The revision attribute.
    /// </summary>
    public string? Revision
    {
        get => GetProperty<TerraformLiteralProperty<string>>("revision")?.Value;
        set => this.WithProperty("revision", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The revision_description attribute.
    /// </summary>
    public string? RevisionDescription
    {
        get => GetProperty<TerraformLiteralProperty<string>>("revision_description")?.Value;
        set => this.WithProperty("revision_description", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The service_url attribute.
    /// </summary>
    public string? ServiceUrl
    {
        get => GetProperty<TerraformLiteralProperty<string>>("service_url")?.Value;
        set => this.WithProperty("service_url", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The source_api_id attribute.
    /// </summary>
    public string? SourceApiId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("source_api_id")?.Value;
        set => this.WithProperty("source_api_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The subscription_required attribute.
    /// </summary>
    public bool? SubscriptionRequired
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("subscription_required")?.Value;
        set => this.WithProperty("subscription_required", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The terms_of_service_url attribute.
    /// </summary>
    public string? TermsOfServiceUrl
    {
        get => GetProperty<TerraformLiteralProperty<string>>("terms_of_service_url")?.Value;
        set => this.WithProperty("terms_of_service_url", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The version attribute.
    /// </summary>
    public string? Version
    {
        get => GetProperty<TerraformLiteralProperty<string>>("version")?.Value;
        set => this.WithProperty("version", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The version_description attribute.
    /// </summary>
    public string? VersionDescription
    {
        get => GetProperty<TerraformLiteralProperty<string>>("version_description")?.Value;
        set => this.WithProperty("version_description", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The version_set_id attribute.
    /// </summary>
    public string? VersionSetId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("version_set_id")?.Value;
        set => this.WithProperty("version_set_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The is_current attribute.
    /// </summary>
    public TerraformExpression IsCurrent => this["is_current"];

    /// <summary>
    /// The is_online attribute.
    /// </summary>
    public TerraformExpression IsOnline => this["is_online"];

}

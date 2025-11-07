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
    public TerraformProperty<string>? ApiManagementName
    {
        get => GetProperty<TerraformProperty<string>>("api_management_name");
        set => this.WithProperty("api_management_name", value);
    }

    /// <summary>
    /// The api_type attribute.
    /// </summary>
    public TerraformProperty<string>? ApiType
    {
        get => GetProperty<TerraformProperty<string>>("api_type");
        set => this.WithProperty("api_type", value);
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformProperty<string>? Description
    {
        get => GetProperty<TerraformProperty<string>>("description");
        set => this.WithProperty("description", value);
    }

    /// <summary>
    /// The display_name attribute.
    /// </summary>
    public TerraformProperty<string>? DisplayName
    {
        get => GetProperty<TerraformProperty<string>>("display_name");
        set => this.WithProperty("display_name", value);
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
    /// The path attribute.
    /// </summary>
    public TerraformProperty<string>? Path
    {
        get => GetProperty<TerraformProperty<string>>("path");
        set => this.WithProperty("path", value);
    }

    /// <summary>
    /// The protocols attribute.
    /// </summary>
    public TerraformProperty<HashSet<string>>? Protocols
    {
        get => GetProperty<TerraformProperty<HashSet<string>>>("protocols");
        set => this.WithProperty("protocols", value);
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
    /// The revision attribute.
    /// </summary>
    public TerraformProperty<string>? Revision
    {
        get => GetProperty<TerraformProperty<string>>("revision");
        set => this.WithProperty("revision", value);
    }

    /// <summary>
    /// The revision_description attribute.
    /// </summary>
    public TerraformProperty<string>? RevisionDescription
    {
        get => GetProperty<TerraformProperty<string>>("revision_description");
        set => this.WithProperty("revision_description", value);
    }

    /// <summary>
    /// The service_url attribute.
    /// </summary>
    public TerraformProperty<string>? ServiceUrl
    {
        get => GetProperty<TerraformProperty<string>>("service_url");
        set => this.WithProperty("service_url", value);
    }

    /// <summary>
    /// The source_api_id attribute.
    /// </summary>
    public TerraformProperty<string>? SourceApiId
    {
        get => GetProperty<TerraformProperty<string>>("source_api_id");
        set => this.WithProperty("source_api_id", value);
    }

    /// <summary>
    /// The subscription_required attribute.
    /// </summary>
    public TerraformProperty<bool>? SubscriptionRequired
    {
        get => GetProperty<TerraformProperty<bool>>("subscription_required");
        set => this.WithProperty("subscription_required", value);
    }

    /// <summary>
    /// The terms_of_service_url attribute.
    /// </summary>
    public TerraformProperty<string>? TermsOfServiceUrl
    {
        get => GetProperty<TerraformProperty<string>>("terms_of_service_url");
        set => this.WithProperty("terms_of_service_url", value);
    }

    /// <summary>
    /// The version attribute.
    /// </summary>
    public TerraformProperty<string>? Version
    {
        get => GetProperty<TerraformProperty<string>>("version");
        set => this.WithProperty("version", value);
    }

    /// <summary>
    /// The version_description attribute.
    /// </summary>
    public TerraformProperty<string>? VersionDescription
    {
        get => GetProperty<TerraformProperty<string>>("version_description");
        set => this.WithProperty("version_description", value);
    }

    /// <summary>
    /// The version_set_id attribute.
    /// </summary>
    public TerraformProperty<string>? VersionSetId
    {
        get => GetProperty<TerraformProperty<string>>("version_set_id");
        set => this.WithProperty("version_set_id", value);
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

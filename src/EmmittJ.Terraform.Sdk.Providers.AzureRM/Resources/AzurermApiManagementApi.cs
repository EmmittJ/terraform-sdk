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
    public TerraformLiteralProperty<string>? ApiManagementName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("api_management_name");
        set => this.WithProperty("api_management_name", value);
    }

    /// <summary>
    /// The api_type attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? ApiType
    {
        get => GetProperty<TerraformLiteralProperty<string>>("api_type");
        set => this.WithProperty("api_type", value);
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Description
    {
        get => GetProperty<TerraformLiteralProperty<string>>("description");
        set => this.WithProperty("description", value);
    }

    /// <summary>
    /// The display_name attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? DisplayName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("display_name");
        set => this.WithProperty("display_name", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Name
    {
        get => GetProperty<TerraformLiteralProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// The path attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Path
    {
        get => GetProperty<TerraformLiteralProperty<string>>("path");
        set => this.WithProperty("path", value);
    }

    /// <summary>
    /// The protocols attribute.
    /// </summary>
    public TerraformLiteralProperty<HashSet<string>>? Protocols
    {
        get => GetProperty<TerraformLiteralProperty<HashSet<string>>>("protocols");
        set => this.WithProperty("protocols", value);
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? ResourceGroupName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("resource_group_name");
        set => this.WithProperty("resource_group_name", value);
    }

    /// <summary>
    /// The revision attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Revision
    {
        get => GetProperty<TerraformLiteralProperty<string>>("revision");
        set => this.WithProperty("revision", value);
    }

    /// <summary>
    /// The revision_description attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? RevisionDescription
    {
        get => GetProperty<TerraformLiteralProperty<string>>("revision_description");
        set => this.WithProperty("revision_description", value);
    }

    /// <summary>
    /// The service_url attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? ServiceUrl
    {
        get => GetProperty<TerraformLiteralProperty<string>>("service_url");
        set => this.WithProperty("service_url", value);
    }

    /// <summary>
    /// The source_api_id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? SourceApiId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("source_api_id");
        set => this.WithProperty("source_api_id", value);
    }

    /// <summary>
    /// The subscription_required attribute.
    /// </summary>
    public TerraformLiteralProperty<bool>? SubscriptionRequired
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("subscription_required");
        set => this.WithProperty("subscription_required", value);
    }

    /// <summary>
    /// The terms_of_service_url attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? TermsOfServiceUrl
    {
        get => GetProperty<TerraformLiteralProperty<string>>("terms_of_service_url");
        set => this.WithProperty("terms_of_service_url", value);
    }

    /// <summary>
    /// The version attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Version
    {
        get => GetProperty<TerraformLiteralProperty<string>>("version");
        set => this.WithProperty("version", value);
    }

    /// <summary>
    /// The version_description attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? VersionDescription
    {
        get => GetProperty<TerraformLiteralProperty<string>>("version_description");
        set => this.WithProperty("version_description", value);
    }

    /// <summary>
    /// The version_set_id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? VersionSetId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("version_set_id");
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

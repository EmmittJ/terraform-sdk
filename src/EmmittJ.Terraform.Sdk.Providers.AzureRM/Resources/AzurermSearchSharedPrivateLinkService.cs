using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Manages a azurerm_search_shared_private_link_service resource.
/// </summary>
public class AzurermSearchSharedPrivateLinkService : TerraformResource
{
    public AzurermSearchSharedPrivateLinkService(string name) : base("azurerm_search_shared_private_link_service", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("status");
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
    /// The request_message attribute.
    /// </summary>
    public string? RequestMessage
    {
        get => GetProperty<TerraformLiteralProperty<string>>("request_message")?.Value;
        set => this.WithProperty("request_message", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The search_service_id attribute.
    /// </summary>
    public string? SearchServiceId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("search_service_id")?.Value;
        set => this.WithProperty("search_service_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The subresource_name attribute.
    /// </summary>
    public string? SubresourceName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("subresource_name")?.Value;
        set => this.WithProperty("subresource_name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The target_resource_id attribute.
    /// </summary>
    public string? TargetResourceId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("target_resource_id")?.Value;
        set => this.WithProperty("target_resource_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The status attribute.
    /// </summary>
    public TerraformExpression Status => this["status"];

}

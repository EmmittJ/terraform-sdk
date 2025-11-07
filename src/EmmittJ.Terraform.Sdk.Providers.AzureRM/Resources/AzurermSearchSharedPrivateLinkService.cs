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
    /// The request_message attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? RequestMessage
    {
        get => GetProperty<TerraformLiteralProperty<string>>("request_message");
        set => this.WithProperty("request_message", value);
    }

    /// <summary>
    /// The search_service_id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? SearchServiceId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("search_service_id");
        set => this.WithProperty("search_service_id", value);
    }

    /// <summary>
    /// The subresource_name attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? SubresourceName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("subresource_name");
        set => this.WithProperty("subresource_name", value);
    }

    /// <summary>
    /// The target_resource_id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? TargetResourceId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("target_resource_id");
        set => this.WithProperty("target_resource_id", value);
    }

    /// <summary>
    /// The status attribute.
    /// </summary>
    public TerraformExpression Status => this["status"];

}

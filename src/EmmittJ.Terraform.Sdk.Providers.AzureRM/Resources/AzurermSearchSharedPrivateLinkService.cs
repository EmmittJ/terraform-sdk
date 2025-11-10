using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermSearchSharedPrivateLinkServiceTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformProperty<string>? Create
    {
        get => GetProperty<TerraformProperty<string>>("create");
        set => WithProperty("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        get => GetProperty<TerraformProperty<string>>("delete");
        set => WithProperty("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformProperty<string>? Read
    {
        get => GetProperty<TerraformProperty<string>>("read");
        set => WithProperty("read", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformProperty<string>? Update
    {
        get => GetProperty<TerraformProperty<string>>("update");
        set => WithProperty("update", value);
    }

}

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
    public TerraformProperty<string>? Id
    {
        get => GetProperty<TerraformProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// The request_message attribute.
    /// </summary>
    public TerraformProperty<string>? RequestMessage
    {
        get => GetProperty<TerraformProperty<string>>("request_message");
        set => this.WithProperty("request_message", value);
    }

    /// <summary>
    /// The search_service_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SearchServiceId is required")]
    public required TerraformProperty<string> SearchServiceId
    {
        get => GetProperty<TerraformProperty<string>>("search_service_id");
        set => this.WithProperty("search_service_id", value);
    }

    /// <summary>
    /// The subresource_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SubresourceName is required")]
    public required TerraformProperty<string> SubresourceName
    {
        get => GetProperty<TerraformProperty<string>>("subresource_name");
        set => this.WithProperty("subresource_name", value);
    }

    /// <summary>
    /// The target_resource_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TargetResourceId is required")]
    public required TerraformProperty<string> TargetResourceId
    {
        get => GetProperty<TerraformProperty<string>>("target_resource_id");
        set => this.WithProperty("target_resource_id", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermSearchSharedPrivateLinkServiceTimeoutsBlock? Timeouts
    {
        get => GetProperty<AzurermSearchSharedPrivateLinkServiceTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
    }

    /// <summary>
    /// The status attribute.
    /// </summary>
    public TerraformExpression Status => this["status"];

}

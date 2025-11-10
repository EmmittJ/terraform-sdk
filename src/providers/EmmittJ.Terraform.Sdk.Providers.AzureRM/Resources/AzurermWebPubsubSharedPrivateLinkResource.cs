using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermWebPubsubSharedPrivateLinkResourceTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformProperty<string>? Create
    {
        set => SetProperty("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        set => SetProperty("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformProperty<string>? Read
    {
        set => SetProperty("read", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformProperty<string>? Update
    {
        set => SetProperty("update", value);
    }

}

/// <summary>
/// Manages a azurerm_web_pubsub_shared_private_link_resource resource.
/// </summary>
public class AzurermWebPubsubSharedPrivateLinkResource : TerraformResource
{
    public AzurermWebPubsubSharedPrivateLinkResource(string name) : base("azurerm_web_pubsub_shared_private_link_resource", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("status");
        SetOutput("id");
        SetOutput("name");
        SetOutput("request_message");
        SetOutput("subresource_name");
        SetOutput("target_resource_id");
        SetOutput("web_pubsub_id");
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string> Id
    {
        get => GetRequiredOutput<TerraformProperty<string>>("id");
        set => SetProperty("id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetRequiredOutput<TerraformProperty<string>>("name");
        set => SetProperty("name", value);
    }

    /// <summary>
    /// The request_message attribute.
    /// </summary>
    public TerraformProperty<string> RequestMessage
    {
        get => GetRequiredOutput<TerraformProperty<string>>("request_message");
        set => SetProperty("request_message", value);
    }

    /// <summary>
    /// The subresource_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SubresourceName is required")]
    public required TerraformProperty<string> SubresourceName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("subresource_name");
        set => SetProperty("subresource_name", value);
    }

    /// <summary>
    /// The target_resource_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TargetResourceId is required")]
    public required TerraformProperty<string> TargetResourceId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("target_resource_id");
        set => SetProperty("target_resource_id", value);
    }

    /// <summary>
    /// The web_pubsub_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "WebPubsubId is required")]
    public required TerraformProperty<string> WebPubsubId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("web_pubsub_id");
        set => SetProperty("web_pubsub_id", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermWebPubsubSharedPrivateLinkResourceTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

    /// <summary>
    /// The status attribute.
    /// </summary>
    public TerraformExpression Status => this["status"];

}

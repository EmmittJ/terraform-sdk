using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for timeouts in AzurermWebPubsubSharedPrivateLinkResource.
/// Nesting mode: single
/// </summary>
public class AzurermWebPubsubSharedPrivateLinkResourceTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "timeouts";

    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformValue<string>? Create
    {
        get => GetArgument<TerraformValue<string>>("create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformValue<string>? Delete
    {
        get => GetArgument<TerraformValue<string>>("delete");
        set => SetArgument("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformValue<string>? Read
    {
        get => GetArgument<TerraformValue<string>>("read");
        set => SetArgument("read", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformValue<string>? Update
    {
        get => GetArgument<TerraformValue<string>>("update");
        set => SetArgument("update", value);
    }

}


/// <summary>
/// Represents a azurerm_web_pubsub_shared_private_link_resource Terraform resource.
/// Manages a azurerm_web_pubsub_shared_private_link_resource resource.
/// </summary>
public partial class AzurermWebPubsubSharedPrivateLinkResource(string name) : TerraformResource("azurerm_web_pubsub_shared_private_link_resource", name)
{
    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string>? Id
    {
        get => GetArgument<TerraformValue<string>>("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The request_message attribute.
    /// </summary>
    public TerraformValue<string>? RequestMessage
    {
        get => GetArgument<TerraformValue<string>>("request_message");
        set => SetArgument("request_message", value);
    }

    /// <summary>
    /// The subresource_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SubresourceName is required")]
    public required TerraformValue<string> SubresourceName
    {
        get => GetArgument<TerraformValue<string>>("subresource_name");
        set => SetArgument("subresource_name", value);
    }

    /// <summary>
    /// The target_resource_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TargetResourceId is required")]
    public required TerraformValue<string> TargetResourceId
    {
        get => GetArgument<TerraformValue<string>>("target_resource_id");
        set => SetArgument("target_resource_id", value);
    }

    /// <summary>
    /// The web_pubsub_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "WebPubsubId is required")]
    public required TerraformValue<string> WebPubsubId
    {
        get => GetArgument<TerraformValue<string>>("web_pubsub_id");
        set => SetArgument("web_pubsub_id", value);
    }

    /// <summary>
    /// The status attribute.
    /// </summary>
    public TerraformValue<string> Status
        => AsReference("status");

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermWebPubsubSharedPrivateLinkResourceTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermWebPubsubSharedPrivateLinkResourceTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}

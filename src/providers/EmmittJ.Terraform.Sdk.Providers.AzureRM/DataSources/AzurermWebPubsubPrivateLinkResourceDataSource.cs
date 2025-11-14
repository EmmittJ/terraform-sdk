using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

// Resources, Data Sources, Ephemeral Resources, Blocks: Getter ALWAYS returns a reference
// This is the key to natural Terraform syntax
// When you access rg.Name, you get azurerm_resource_group.rg.name (a reference)
// The value that was SET is only used during serialization

// Providers: Getter returns stored value
// Providers are not referenced in HCL
// Use required getter if property is required or non-nullable

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermWebPubsubPrivateLinkResourceDataSourceTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "timeouts";

    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformArgument("read")]
    public TerraformValue<string>? Read
    {
        get => new TerraformReference<string>(this, "read");
        set => SetArgument("read", value);
    }

}

/// <summary>
/// Retrieves information about a azurerm_web_pubsub_private_link_resource.
/// </summary>
public class AzurermWebPubsubPrivateLinkResourceDataSource : TerraformDataSource
{
    public AzurermWebPubsubPrivateLinkResourceDataSource(string name) : base("azurerm_web_pubsub_private_link_resource", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformArgument("id")]
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The web_pubsub_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "WebPubsubId is required")]
    [TerraformArgument("web_pubsub_id")]
    public required TerraformValue<string> WebPubsubId
    {
        get => new TerraformReference<string>(this, "web_pubsub_id");
        set => SetArgument("web_pubsub_id", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformArgument("timeouts")]
    public AzurermWebPubsubPrivateLinkResourceDataSourceTimeoutsBlock Timeouts { get; set; } = new();

    /// <summary>
    /// The shared_private_link_resource_types attribute.
    /// </summary>
    [TerraformArgument("shared_private_link_resource_types")]
    public TerraformList<object> SharedPrivateLinkResourceTypes
    {
        get => TerraformList<object>.Lazy(ctx => new TerraformReference<TerraformList<object>>(this, "shared_private_link_resource_types").ResolveNodes(ctx));
    }

}

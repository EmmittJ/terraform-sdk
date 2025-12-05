using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for timeouts in AzurermWebPubsubPrivateLinkResourceDataSource.
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
    public TerraformValue<string>? Read
    {
        get => GetArgument<TerraformValue<string>>("read");
        set => SetArgument("read", value);
    }

}


/// <summary>
/// Represents a azurerm_web_pubsub_private_link_resource Terraform data source.
/// Retrieves information about a azurerm_web_pubsub_private_link_resource.
/// </summary>
public partial class AzurermWebPubsubPrivateLinkResourceDataSource(string name) : TerraformDataSource("azurerm_web_pubsub_private_link_resource", name)
{
    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => GetArgument<TerraformValue<string>>("id") ?? CreateReference("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The web_pubsub_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "WebPubsubId is required")]
    public required TerraformValue<string> WebPubsubId
    {
        get => GetRequiredArgument<TerraformValue<string>>("web_pubsub_id");
        set => SetArgument("web_pubsub_id", value);
    }

    /// <summary>
    /// The shared_private_link_resource_types attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> SharedPrivateLinkResourceTypes
        => CreateReference("shared_private_link_resource_types");

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermWebPubsubPrivateLinkResourceDataSourceTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermWebPubsubPrivateLinkResourceDataSourceTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}

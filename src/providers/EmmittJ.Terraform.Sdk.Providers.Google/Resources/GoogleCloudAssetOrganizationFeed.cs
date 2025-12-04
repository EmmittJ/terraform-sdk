using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for condition in GoogleCloudAssetOrganizationFeed.
/// Nesting mode: list
/// </summary>
public class GoogleCloudAssetOrganizationFeedConditionBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "condition";

    /// <summary>
    /// Description of the expression. This is a longer text which describes the expression,
    /// e.g. when hovered over it in a UI.
    /// </summary>
    public TerraformValue<string>? Description
    {
        get => GetArgument<TerraformValue<string>>("description");
        set => SetArgument("description", value);
    }

    /// <summary>
    /// Textual representation of an expression in Common Expression Language syntax.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Expression is required")]
    public required TerraformValue<string> Expression
    {
        get => GetArgument<TerraformValue<string>>("expression");
        set => SetArgument("expression", value);
    }

    /// <summary>
    /// String indicating the location of the expression for error reporting, e.g. a file
    /// name and a position in the file.
    /// </summary>
    public TerraformValue<string>? Location
    {
        get => GetArgument<TerraformValue<string>>("location");
        set => SetArgument("location", value);
    }

    /// <summary>
    /// Title for the expression, i.e. a short string describing its purpose.
    /// This can be used e.g. in UIs which allow to enter the expression.
    /// </summary>
    public TerraformValue<string>? Title
    {
        get => GetArgument<TerraformValue<string>>("title");
        set => SetArgument("title", value);
    }

}


/// <summary>
/// Block type for feed_output_config in GoogleCloudAssetOrganizationFeed.
/// Nesting mode: list
/// </summary>
public class GoogleCloudAssetOrganizationFeedFeedOutputConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "feed_output_config";

    /// <summary>
    /// PubsubDestination block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PubsubDestination is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 PubsubDestination block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 PubsubDestination block(s) allowed")]
    public required TerraformList<GoogleCloudAssetOrganizationFeedFeedOutputConfigBlockPubsubDestinationBlock> PubsubDestination
    {
        get => GetRequiredArgument<TerraformList<GoogleCloudAssetOrganizationFeedFeedOutputConfigBlockPubsubDestinationBlock>>("pubsub_destination");
        set => SetArgument("pubsub_destination", value);
    }

}

/// <summary>
/// Block type for pubsub_destination in GoogleCloudAssetOrganizationFeedFeedOutputConfigBlock.
/// Nesting mode: list
/// </summary>
public class GoogleCloudAssetOrganizationFeedFeedOutputConfigBlockPubsubDestinationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "pubsub_destination";

    /// <summary>
    /// Destination on Cloud Pubsub topic.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Topic is required")]
    public required TerraformValue<string> Topic
    {
        get => GetArgument<TerraformValue<string>>("topic");
        set => SetArgument("topic", value);
    }

}


/// <summary>
/// Block type for timeouts in GoogleCloudAssetOrganizationFeed.
/// Nesting mode: single
/// </summary>
public class GoogleCloudAssetOrganizationFeedTimeoutsBlock : TerraformBlock
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
    /// The update attribute.
    /// </summary>
    public TerraformValue<string>? Update
    {
        get => GetArgument<TerraformValue<string>>("update");
        set => SetArgument("update", value);
    }

}


/// <summary>
/// Represents a google_cloud_asset_organization_feed Terraform resource.
/// Manages a google_cloud_asset_organization_feed resource.
/// </summary>
public partial class GoogleCloudAssetOrganizationFeed(string name) : TerraformResource("google_cloud_asset_organization_feed", name)
{
    /// <summary>
    /// A list of the full names of the assets to receive updates. You must specify either or both of
    /// assetNames and assetTypes. Only asset updates matching specified assetNames and assetTypes are
    /// exported to the feed. For example: //compute.googleapis.com/projects/my_project_123/zones/zone1/instances/instance1.
    /// See https://cloud.google.com/apis/design/resourceNames#fullResourceName for more info.
    /// </summary>
    public TerraformList<string>? AssetNames
    {
        get => GetArgument<TerraformList<string>>("asset_names");
        set => SetArgument("asset_names", value);
    }

    /// <summary>
    /// A list of types of the assets to receive updates. You must specify either or both of assetNames
    /// and assetTypes. Only asset updates matching specified assetNames and assetTypes are exported to
    /// the feed. For example: &amp;quot;compute.googleapis.com/Disk&amp;quot;
    /// See https://cloud.google.com/asset-inventory/docs/supported-asset-types for a list of all
    /// supported asset types.
    /// </summary>
    public TerraformList<string>? AssetTypes
    {
        get => GetArgument<TerraformList<string>>("asset_types");
        set => SetArgument("asset_types", value);
    }

    /// <summary>
    /// The project whose identity will be used when sending messages to the
    /// destination pubsub topic. It also specifies the project for API
    /// enablement check, quota, and billing.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "BillingProject is required")]
    public required TerraformValue<string> BillingProject
    {
        get => GetArgument<TerraformValue<string>>("billing_project");
        set => SetArgument("billing_project", value);
    }

    /// <summary>
    /// Asset content type. If not specified, no content but the asset name and type will be returned. Possible values: [&amp;quot;CONTENT_TYPE_UNSPECIFIED&amp;quot;, &amp;quot;RESOURCE&amp;quot;, &amp;quot;IAM_POLICY&amp;quot;, &amp;quot;ORG_POLICY&amp;quot;, &amp;quot;OS_INVENTORY&amp;quot;, &amp;quot;ACCESS_POLICY&amp;quot;]
    /// </summary>
    public TerraformValue<string>? ContentType
    {
        get => GetArgument<TerraformValue<string>>("content_type");
        set => SetArgument("content_type", value);
    }

    /// <summary>
    /// This is the client-assigned asset feed identifier and it needs to be unique under a specific parent.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "FeedId is required")]
    public required TerraformValue<string> FeedId
    {
        get => GetArgument<TerraformValue<string>>("feed_id");
        set => SetArgument("feed_id", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string>? Id
    {
        get => GetArgument<TerraformValue<string>>("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The organization this feed should be created in.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "OrgId is required")]
    public required TerraformValue<string> OrgId
    {
        get => GetArgument<TerraformValue<string>>("org_id");
        set => SetArgument("org_id", value);
    }

    /// <summary>
    /// The format will be organizations/{organization_number}/feeds/{client-assigned_feed_identifier}.
    /// </summary>
    public TerraformValue<string> Name
        => AsReference("name");

    /// <summary>
    /// Condition block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Condition block(s) allowed")]
    public TerraformList<GoogleCloudAssetOrganizationFeedConditionBlock>? Condition
    {
        get => GetArgument<TerraformList<GoogleCloudAssetOrganizationFeedConditionBlock>>("condition");
        set => SetArgument("condition", value);
    }

    /// <summary>
    /// FeedOutputConfig block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "FeedOutputConfig is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 FeedOutputConfig block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 FeedOutputConfig block(s) allowed")]
    public required TerraformList<GoogleCloudAssetOrganizationFeedFeedOutputConfigBlock> FeedOutputConfig
    {
        get => GetRequiredArgument<TerraformList<GoogleCloudAssetOrganizationFeedFeedOutputConfigBlock>>("feed_output_config");
        set => SetArgument("feed_output_config", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public GoogleCloudAssetOrganizationFeedTimeoutsBlock? Timeouts
    {
        get => GetArgument<GoogleCloudAssetOrganizationFeedTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}

using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for condition in .
/// Nesting mode: list
/// </summary>
public class GoogleCloudAssetFolderFeedConditionBlock : TerraformBlock
{
    /// <summary>
    /// Description of the expression. This is a longer text which describes the expression,
    /// e.g. when hovered over it in a UI.
    /// </summary>
    public TerraformProperty<string>? Description
    {
        get => GetProperty<TerraformProperty<string>>("description");
        set => WithProperty("description", value);
    }

    /// <summary>
    /// Textual representation of an expression in Common Expression Language syntax.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Expression is required")]
    public required TerraformProperty<string> Expression
    {
        get => GetRequiredProperty<TerraformProperty<string>>("expression");
        set => WithProperty("expression", value);
    }

    /// <summary>
    /// String indicating the location of the expression for error reporting, e.g. a file
    /// name and a position in the file.
    /// </summary>
    public TerraformProperty<string>? Location
    {
        get => GetProperty<TerraformProperty<string>>("location");
        set => WithProperty("location", value);
    }

    /// <summary>
    /// Title for the expression, i.e. a short string describing its purpose.
    /// This can be used e.g. in UIs which allow to enter the expression.
    /// </summary>
    public TerraformProperty<string>? Title
    {
        get => GetProperty<TerraformProperty<string>>("title");
        set => WithProperty("title", value);
    }

}

/// <summary>
/// Block type for feed_output_config in .
/// Nesting mode: list
/// </summary>
public class GoogleCloudAssetFolderFeedFeedOutputConfigBlock : TerraformBlock
{
}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class GoogleCloudAssetFolderFeedTimeoutsBlock : TerraformBlock
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
    /// The update attribute.
    /// </summary>
    public TerraformProperty<string>? Update
    {
        get => GetProperty<TerraformProperty<string>>("update");
        set => WithProperty("update", value);
    }

}

/// <summary>
/// Manages a google_cloud_asset_folder_feed resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class GoogleCloudAssetFolderFeed : TerraformResource
{
    public GoogleCloudAssetFolderFeed(string name) : base("google_cloud_asset_folder_feed", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.WithOutput("folder_id");
        this.WithOutput("name");
    }

    /// <summary>
    /// A list of the full names of the assets to receive updates. You must specify either or both of
    /// assetNames and assetTypes. Only asset updates matching specified assetNames and assetTypes are
    /// exported to the feed. For example: //compute.googleapis.com/projects/my_project_123/zones/zone1/instances/instance1.
    /// See https://cloud.google.com/apis/design/resourceNames#fullResourceName for more info.
    /// </summary>
    public List<TerraformProperty<string>>? AssetNames
    {
        get => GetProperty<List<TerraformProperty<string>>>("asset_names");
        set => this.WithProperty("asset_names", value);
    }

    /// <summary>
    /// A list of types of the assets to receive updates. You must specify either or both of assetNames
    /// and assetTypes. Only asset updates matching specified assetNames and assetTypes are exported to
    /// the feed. For example: &amp;quot;compute.googleapis.com/Disk&amp;quot;
    /// See https://cloud.google.com/asset-inventory/docs/supported-asset-types for a list of all
    /// supported asset types.
    /// </summary>
    public List<TerraformProperty<string>>? AssetTypes
    {
        get => GetProperty<List<TerraformProperty<string>>>("asset_types");
        set => this.WithProperty("asset_types", value);
    }

    /// <summary>
    /// The project whose identity will be used when sending messages to the
    /// destination pubsub topic. It also specifies the project for API
    /// enablement check, quota, and billing.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "BillingProject is required")]
    public required TerraformProperty<string> BillingProject
    {
        get => GetRequiredProperty<TerraformProperty<string>>("billing_project");
        set => this.WithProperty("billing_project", value);
    }

    /// <summary>
    /// Asset content type. If not specified, no content but the asset name and type will be returned. Possible values: [&amp;quot;CONTENT_TYPE_UNSPECIFIED&amp;quot;, &amp;quot;RESOURCE&amp;quot;, &amp;quot;IAM_POLICY&amp;quot;, &amp;quot;ORG_POLICY&amp;quot;, &amp;quot;OS_INVENTORY&amp;quot;, &amp;quot;ACCESS_POLICY&amp;quot;]
    /// </summary>
    public TerraformProperty<string>? ContentType
    {
        get => GetProperty<TerraformProperty<string>>("content_type");
        set => this.WithProperty("content_type", value);
    }

    /// <summary>
    /// This is the client-assigned asset feed identifier and it needs to be unique under a specific parent.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "FeedId is required")]
    public required TerraformProperty<string> FeedId
    {
        get => GetRequiredProperty<TerraformProperty<string>>("feed_id");
        set => this.WithProperty("feed_id", value);
    }

    /// <summary>
    /// The folder this feed should be created in.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Folder is required")]
    public required TerraformProperty<string> Folder
    {
        get => GetRequiredProperty<TerraformProperty<string>>("folder");
        set => this.WithProperty("folder", value);
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
    /// Block for condition.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Condition block(s) allowed")]
    public List<GoogleCloudAssetFolderFeedConditionBlock>? Condition
    {
        get => GetProperty<List<GoogleCloudAssetFolderFeedConditionBlock>>("condition");
        set => this.WithProperty("condition", value);
    }

    /// <summary>
    /// Block for feed_output_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 FeedOutputConfig block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 FeedOutputConfig block(s) allowed")]
    public List<GoogleCloudAssetFolderFeedFeedOutputConfigBlock>? FeedOutputConfig
    {
        get => GetProperty<List<GoogleCloudAssetFolderFeedFeedOutputConfigBlock>>("feed_output_config");
        set => this.WithProperty("feed_output_config", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public GoogleCloudAssetFolderFeedTimeoutsBlock? Timeouts
    {
        get => GetProperty<GoogleCloudAssetFolderFeedTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
    }

    /// <summary>
    /// The ID of the folder where this feed has been created. Both [FOLDER_NUMBER]
    /// and folders/[FOLDER_NUMBER] are accepted.
    /// </summary>
    public TerraformExpression FolderId => this["folder_id"];

    /// <summary>
    /// The format will be folders/{folder_number}/feeds/{client-assigned_feed_identifier}.
    /// </summary>
    public TerraformExpression Name => this["name"];

}

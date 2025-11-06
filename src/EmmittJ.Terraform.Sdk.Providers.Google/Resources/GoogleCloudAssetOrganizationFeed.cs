using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Manages a google_cloud_asset_organization_feed resource.
/// </summary>
public class GoogleCloudAssetOrganizationFeed : TerraformResource
{
    public GoogleCloudAssetOrganizationFeed(string name) : base("google_cloud_asset_organization_feed", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("name");
    }

    /// <summary>
    /// A list of the full names of the assets to receive updates. You must specify either or both of
    /// assetNames and assetTypes. Only asset updates matching specified assetNames and assetTypes are
    /// exported to the feed. For example: //compute.googleapis.com/projects/my_project_123/zones/zone1/instances/instance1.
    /// See https://cloud.google.com/apis/design/resourceNames#fullResourceName for more info.
    /// </summary>
    public List<string>? AssetNames
    {
        get => GetProperty<TerraformLiteralProperty<List<string>>>("asset_names")?.Value;
        set => this.WithProperty("asset_names", value == null ? null : new TerraformLiteralProperty<List<string>>(value));
    }

    /// <summary>
    /// A list of types of the assets to receive updates. You must specify either or both of assetNames
    /// and assetTypes. Only asset updates matching specified assetNames and assetTypes are exported to
    /// the feed. For example: &amp;quot;compute.googleapis.com/Disk&amp;quot;
    /// See https://cloud.google.com/asset-inventory/docs/supported-asset-types for a list of all
    /// supported asset types.
    /// </summary>
    public List<string>? AssetTypes
    {
        get => GetProperty<TerraformLiteralProperty<List<string>>>("asset_types")?.Value;
        set => this.WithProperty("asset_types", value == null ? null : new TerraformLiteralProperty<List<string>>(value));
    }

    /// <summary>
    /// The project whose identity will be used when sending messages to the
    /// destination pubsub topic. It also specifies the project for API
    /// enablement check, quota, and billing.
    /// </summary>
    public string? BillingProject
    {
        get => GetProperty<TerraformLiteralProperty<string>>("billing_project")?.Value;
        set => this.WithProperty("billing_project", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// Asset content type. If not specified, no content but the asset name and type will be returned. Possible values: [&amp;quot;CONTENT_TYPE_UNSPECIFIED&amp;quot;, &amp;quot;RESOURCE&amp;quot;, &amp;quot;IAM_POLICY&amp;quot;, &amp;quot;ORG_POLICY&amp;quot;, &amp;quot;OS_INVENTORY&amp;quot;, &amp;quot;ACCESS_POLICY&amp;quot;]
    /// </summary>
    public string? ContentType
    {
        get => GetProperty<TerraformLiteralProperty<string>>("content_type")?.Value;
        set => this.WithProperty("content_type", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// This is the client-assigned asset feed identifier and it needs to be unique under a specific parent.
    /// </summary>
    public string? FeedId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("feed_id")?.Value;
        set => this.WithProperty("feed_id", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The organization this feed should be created in.
    /// </summary>
    public string? OrgId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("org_id")?.Value;
        set => this.WithProperty("org_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The format will be organizations/{organization_number}/feeds/{client-assigned_feed_identifier}.
    /// </summary>
    public TerraformExpression Name => this["name"];

}

using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Manages a google_bigquery_analytics_hub_listing_subscription resource.
/// </summary>
public class GoogleBigqueryAnalyticsHubListingSubscription : TerraformResource
{
    public GoogleBigqueryAnalyticsHubListingSubscription(string name) : base("google_bigquery_analytics_hub_listing_subscription", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("commercial_info");
        this.DeclareOutput("creation_time");
        this.DeclareOutput("last_modify_time");
        this.DeclareOutput("linked_dataset_map");
        this.DeclareOutput("linked_resources");
        this.DeclareOutput("log_linked_dataset_query_user_email");
        this.DeclareOutput("name");
        this.DeclareOutput("organization_display_name");
        this.DeclareOutput("organization_id");
        this.DeclareOutput("resource_type");
        this.DeclareOutput("state");
        this.DeclareOutput("subscriber_contact");
        this.DeclareOutput("subscription_id");
    }

    /// <summary>
    /// The ID of the data exchange. Must contain only Unicode letters, numbers (0-9), underscores (_). Should not use characters that require URL-escaping, or characters outside of ASCII, spaces.
    /// </summary>
    public TerraformLiteralProperty<string>? DataExchangeId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("data_exchange_id");
        set => this.WithProperty("data_exchange_id", value);
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
    /// The ID of the listing. Must contain only Unicode letters, numbers (0-9), underscores (_). Should not use characters that require URL-escaping, or characters outside of ASCII, spaces.
    /// </summary>
    public TerraformLiteralProperty<string>? ListingId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("listing_id");
        set => this.WithProperty("listing_id", value);
    }

    /// <summary>
    /// The name of the location of the data exchange. Distinct from the location of the destination data set.
    /// </summary>
    public TerraformLiteralProperty<string>? Location
    {
        get => GetProperty<TerraformLiteralProperty<string>>("location");
        set => this.WithProperty("location", value);
    }

    /// <summary>
    /// The project attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Project
    {
        get => GetProperty<TerraformLiteralProperty<string>>("project");
        set => this.WithProperty("project", value);
    }

    /// <summary>
    /// Commercial info metadata for this subscription. This is set if this is a commercial subscription i.e. if this subscription was created from subscribing to a commercial listing.
    /// </summary>
    public TerraformExpression CommercialInfo => this["commercial_info"];

    /// <summary>
    /// Timestamp when the subscription was created.
    /// </summary>
    public TerraformExpression CreationTime => this["creation_time"];

    /// <summary>
    /// Timestamp when the subscription was last modified.
    /// </summary>
    public TerraformExpression LastModifyTime => this["last_modify_time"];

    /// <summary>
    /// Output only. Map of listing resource names to associated linked resource,
    /// e.g. projects/123/locations/US/dataExchanges/456/listings/789 -&amp;gt; projects/123/datasets/my_dataset
    /// </summary>
    public TerraformExpression LinkedDatasetMap => this["linked_dataset_map"];

    /// <summary>
    /// Output only. Linked resources created in the subscription. Only contains values if state = STATE_ACTIVE.
    /// </summary>
    public TerraformExpression LinkedResources => this["linked_resources"];

    /// <summary>
    /// Output only. By default, false. If true, the Subscriber agreed to the email sharing mandate that is enabled for Listing.
    /// </summary>
    public TerraformExpression LogLinkedDatasetQueryUserEmail => this["log_linked_dataset_query_user_email"];

    /// <summary>
    /// The resource name of the subscription. e.g. &amp;quot;projects/myproject/locations/US/subscriptions/123&amp;quot;
    /// </summary>
    public TerraformExpression Name => this["name"];

    /// <summary>
    /// Display name of the project of this subscription.
    /// </summary>
    public TerraformExpression OrganizationDisplayName => this["organization_display_name"];

    /// <summary>
    /// Organization of the project this subscription belongs to.
    /// </summary>
    public TerraformExpression OrganizationId => this["organization_id"];

    /// <summary>
    /// Listing shared asset type.
    /// </summary>
    public TerraformExpression ResourceType => this["resource_type"];

    /// <summary>
    /// Current state of the subscription.
    /// </summary>
    public TerraformExpression State => this["state"];

    /// <summary>
    /// Email of the subscriber.
    /// </summary>
    public TerraformExpression SubscriberContact => this["subscriber_contact"];

    /// <summary>
    /// The subscription id used to reference the subscription.
    /// </summary>
    public TerraformExpression SubscriptionId => this["subscription_id"];

}

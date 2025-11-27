using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Represents a google_bigquery_analytics_hub_listing_iam_policy Terraform data source.
/// Retrieves information about a google_bigquery_analytics_hub_listing_iam_policy.
/// </summary>
public partial class GoogleBigqueryAnalyticsHubListingIamPolicyDataSource(string name) : TerraformDataSource("google_bigquery_analytics_hub_listing_iam_policy", name)
{
    /// <summary>
    /// The data_exchange_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DataExchangeId is required")]
    public required TerraformValue<string> DataExchangeId
    {
        get => new TerraformReference<string>(this, "data_exchange_id");
        set => SetArgument("data_exchange_id", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The listing_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ListingId is required")]
    public required TerraformValue<string> ListingId
    {
        get => new TerraformReference<string>(this, "listing_id");
        set => SetArgument("listing_id", value);
    }

    /// <summary>
    /// The location attribute.
    /// </summary>
    public TerraformValue<string> Location
    {
        get => new TerraformReference<string>(this, "location");
        set => SetArgument("location", value);
    }

    /// <summary>
    /// The project attribute.
    /// </summary>
    public TerraformValue<string> Project
    {
        get => new TerraformReference<string>(this, "project");
        set => SetArgument("project", value);
    }

    /// <summary>
    /// The etag attribute.
    /// </summary>
    public TerraformValue<string> Etag
    {
        get => new TerraformReference<string>(this, "etag");
    }

    /// <summary>
    /// The policy_data attribute.
    /// </summary>
    public TerraformValue<string> PolicyData
    {
        get => new TerraformReference<string>(this, "policy_data");
    }

}

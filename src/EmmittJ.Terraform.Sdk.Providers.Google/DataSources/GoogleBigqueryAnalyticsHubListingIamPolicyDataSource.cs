using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Retrieves information about a google_bigquery_analytics_hub_listing_iam_policy.
/// </summary>
public class GoogleBigqueryAnalyticsHubListingIamPolicyDataSource : TerraformDataSource
{
    public GoogleBigqueryAnalyticsHubListingIamPolicyDataSource(string name) : base("google_bigquery_analytics_hub_listing_iam_policy", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("etag");
        this.DeclareOutput("policy_data");
    }

    /// <summary>
    /// The data_exchange_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DataExchangeId is required")]
    public required TerraformProperty<string> DataExchangeId
    {
        get => GetProperty<TerraformProperty<string>>("data_exchange_id");
        set => this.WithProperty("data_exchange_id", value);
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
    /// The listing_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ListingId is required")]
    public required TerraformProperty<string> ListingId
    {
        get => GetProperty<TerraformProperty<string>>("listing_id");
        set => this.WithProperty("listing_id", value);
    }

    /// <summary>
    /// The location attribute.
    /// </summary>
    public TerraformProperty<string>? Location
    {
        get => GetProperty<TerraformProperty<string>>("location");
        set => this.WithProperty("location", value);
    }

    /// <summary>
    /// The project attribute.
    /// </summary>
    public TerraformProperty<string>? Project
    {
        get => GetProperty<TerraformProperty<string>>("project");
        set => this.WithProperty("project", value);
    }

    /// <summary>
    /// The etag attribute.
    /// </summary>
    public TerraformExpression Etag => this["etag"];

    /// <summary>
    /// The policy_data attribute.
    /// </summary>
    public TerraformExpression PolicyData => this["policy_data"];

}

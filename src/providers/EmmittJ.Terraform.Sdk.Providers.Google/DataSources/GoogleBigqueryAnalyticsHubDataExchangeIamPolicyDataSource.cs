using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Represents a google_bigquery_analytics_hub_data_exchange_iam_policy Terraform data source.
/// Retrieves information about a google_bigquery_analytics_hub_data_exchange_iam_policy.
/// </summary>
public partial class GoogleBigqueryAnalyticsHubDataExchangeIamPolicyDataSource(string name) : TerraformDataSource("google_bigquery_analytics_hub_data_exchange_iam_policy", name)
{
    /// <summary>
    /// The data_exchange_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DataExchangeId is required")]
    public required TerraformValue<string> DataExchangeId
    {
        get => GetArgument<TerraformValue<string>>("data_exchange_id");
        set => SetArgument("data_exchange_id", value);
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
    /// The location attribute.
    /// </summary>
    public TerraformValue<string>? Location
    {
        get => GetArgument<TerraformValue<string>>("location");
        set => SetArgument("location", value);
    }

    /// <summary>
    /// The project attribute.
    /// </summary>
    public TerraformValue<string>? Project
    {
        get => GetArgument<TerraformValue<string>>("project");
        set => SetArgument("project", value);
    }

    /// <summary>
    /// The etag attribute.
    /// </summary>
    public TerraformValue<string> Etag
        => AsReference("etag");

    /// <summary>
    /// The policy_data attribute.
    /// </summary>
    public TerraformValue<string> PolicyData
        => AsReference("policy_data");

}

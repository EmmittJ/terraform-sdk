using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Represents a google_bigquery_datapolicyv2_data_policy_iam_policy Terraform resource.
/// Manages a google_bigquery_datapolicyv2_data_policy_iam_policy resource.
/// </summary>
public partial class GoogleBigqueryDatapolicyv2DataPolicyIamPolicy(string name) : TerraformResource("google_bigquery_datapolicyv2_data_policy_iam_policy", name)
{
    /// <summary>
    /// The data_policy_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DataPolicyId is required")]
    public required TerraformValue<string> DataPolicyId
    {
        get => GetArgument<TerraformValue<string>>("data_policy_id");
        set => SetArgument("data_policy_id", value);
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
    /// The policy_data attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PolicyData is required")]
    public required TerraformValue<string> PolicyData
    {
        get => GetArgument<TerraformValue<string>>("policy_data");
        set => SetArgument("policy_data", value);
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

}

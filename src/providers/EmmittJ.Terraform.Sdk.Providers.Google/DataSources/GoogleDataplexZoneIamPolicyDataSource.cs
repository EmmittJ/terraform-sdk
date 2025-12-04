using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Represents a google_dataplex_zone_iam_policy Terraform data source.
/// Retrieves information about a google_dataplex_zone_iam_policy.
/// </summary>
public partial class GoogleDataplexZoneIamPolicyDataSource(string name) : TerraformDataSource("google_dataplex_zone_iam_policy", name)
{
    /// <summary>
    /// The dataplex_zone attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DataplexZone is required")]
    public required TerraformValue<string> DataplexZone
    {
        get => GetArgument<TerraformValue<string>>("dataplex_zone");
        set => SetArgument("dataplex_zone", value);
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
    /// The lake attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Lake is required")]
    public required TerraformValue<string> Lake
    {
        get => GetArgument<TerraformValue<string>>("lake");
        set => SetArgument("lake", value);
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

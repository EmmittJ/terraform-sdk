using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Represents a google_dataplex_asset_iam_policy Terraform data source.
/// Retrieves information about a google_dataplex_asset_iam_policy.
/// </summary>
public partial class GoogleDataplexAssetIamPolicyDataSource(string name) : TerraformDataSource("google_dataplex_asset_iam_policy", name)
{
    /// <summary>
    /// The asset attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Asset is required")]
    public required TerraformValue<string> Asset
    {
        get => new TerraformReference<string>(this, "asset");
        set => SetArgument("asset", value);
    }

    /// <summary>
    /// The dataplex_zone attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DataplexZone is required")]
    public required TerraformValue<string> DataplexZone
    {
        get => new TerraformReference<string>(this, "dataplex_zone");
        set => SetArgument("dataplex_zone", value);
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
    /// The lake attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Lake is required")]
    public required TerraformValue<string> Lake
    {
        get => new TerraformReference<string>(this, "lake");
        set => SetArgument("lake", value);
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

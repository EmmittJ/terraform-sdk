using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Represents a google_dataplex_data_quality_rules Terraform data source.
/// Retrieves information about a google_dataplex_data_quality_rules.
/// </summary>
public partial class GoogleDataplexDataQualityRulesDataSource(string name) : TerraformDataSource("google_dataplex_data_quality_rules", name)
{
    /// <summary>
    /// The data_scan_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DataScanId is required")]
    public required TerraformValue<string> DataScanId
    {
        get => GetRequiredArgument<TerraformValue<string>>("data_scan_id");
        set => SetArgument("data_scan_id", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => GetArgument<TerraformValue<string>>("id") ?? CreateReference("id");
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
    /// The rules attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> Rules
        => CreateReference("rules");

}

using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Represents a google_bigquery_datasets Terraform data source.
/// Retrieves information about a google_bigquery_datasets.
/// </summary>
public partial class GoogleBigqueryDatasetsDataSource(string name) : TerraformDataSource("google_bigquery_datasets", name)
{
    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => GetArgument<TerraformValue<string>>("id") ?? CreateReference("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The ID of the project in which the datasets are located. If it is not provided, the provider project is used.
    /// </summary>
    public TerraformValue<string>? Project
    {
        get => GetArgument<TerraformValue<string>>("project");
        set => SetArgument("project", value);
    }

    /// <summary>
    /// The datasets attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> Datasets
        => CreateReference("datasets");

}

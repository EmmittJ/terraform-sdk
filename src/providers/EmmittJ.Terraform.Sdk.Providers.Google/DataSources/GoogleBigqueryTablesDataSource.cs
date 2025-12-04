using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Represents a google_bigquery_tables Terraform data source.
/// Retrieves information about a google_bigquery_tables.
/// </summary>
public partial class GoogleBigqueryTablesDataSource(string name) : TerraformDataSource("google_bigquery_tables", name)
{
    /// <summary>
    /// The ID of the dataset containing the tables.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DatasetId is required")]
    public required TerraformValue<string> DatasetId
    {
        get => GetArgument<TerraformValue<string>>("dataset_id");
        set => SetArgument("dataset_id", value);
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
    /// The ID of the project in which the dataset is located. If it is not provided, the provider project is used.
    /// </summary>
    public TerraformValue<string>? Project
    {
        get => GetArgument<TerraformValue<string>>("project");
        set => SetArgument("project", value);
    }

    /// <summary>
    /// The tables attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> Tables
        => AsReference("tables");

}

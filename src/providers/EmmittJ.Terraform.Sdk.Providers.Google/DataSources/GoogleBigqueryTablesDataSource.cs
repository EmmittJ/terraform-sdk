using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Retrieves information about a google_bigquery_tables.
/// </summary>
public class GoogleBigqueryTablesDataSource : TerraformDataSource
{
    public GoogleBigqueryTablesDataSource(string name) : base("google_bigquery_tables", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("tables");
        SetOutput("dataset_id");
        SetOutput("id");
        SetOutput("project");
    }

    /// <summary>
    /// The ID of the dataset containing the tables.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DatasetId is required")]
    public required TerraformProperty<string> DatasetId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("dataset_id");
        set => SetProperty("dataset_id", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string> Id
    {
        get => GetRequiredOutput<TerraformProperty<string>>("id");
        set => SetProperty("id", value);
    }

    /// <summary>
    /// The ID of the project in which the dataset is located. If it is not provided, the provider project is used.
    /// </summary>
    public TerraformProperty<string> Project
    {
        get => GetRequiredOutput<TerraformProperty<string>>("project");
        set => SetProperty("project", value);
    }

    /// <summary>
    /// The tables attribute.
    /// </summary>
    public TerraformExpression Tables => this["tables"];

}

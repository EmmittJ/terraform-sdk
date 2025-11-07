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
        this.DeclareOutput("tables");
    }

    /// <summary>
    /// The ID of the dataset containing the tables.
    /// </summary>
    public TerraformLiteralProperty<string>? DatasetId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("dataset_id");
        set => this.WithProperty("dataset_id", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// The ID of the project in which the dataset is located. If it is not provided, the provider project is used.
    /// </summary>
    public TerraformLiteralProperty<string>? Project
    {
        get => GetProperty<TerraformLiteralProperty<string>>("project");
        set => this.WithProperty("project", value);
    }

    /// <summary>
    /// The tables attribute.
    /// </summary>
    public TerraformExpression Tables => this["tables"];

}

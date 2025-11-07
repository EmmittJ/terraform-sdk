using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Retrieves information about a google_bigquery_datasets.
/// </summary>
public class GoogleBigqueryDatasetsDataSource : TerraformDataSource
{
    public GoogleBigqueryDatasetsDataSource(string name) : base("google_bigquery_datasets", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("datasets");
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
    /// The ID of the project in which the datasets are located. If it is not provided, the provider project is used.
    /// </summary>
    public TerraformLiteralProperty<string>? Project
    {
        get => GetProperty<TerraformLiteralProperty<string>>("project");
        set => this.WithProperty("project", value);
    }

    /// <summary>
    /// The datasets attribute.
    /// </summary>
    public TerraformExpression Datasets => this["datasets"];

}

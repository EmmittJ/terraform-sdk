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
        SetOutput("datasets");
        SetOutput("id");
        SetOutput("project");
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
    /// The ID of the project in which the datasets are located. If it is not provided, the provider project is used.
    /// </summary>
    public TerraformProperty<string> Project
    {
        get => GetRequiredOutput<TerraformProperty<string>>("project");
        set => SetProperty("project", value);
    }

    /// <summary>
    /// The datasets attribute.
    /// </summary>
    public TerraformExpression Datasets => this["datasets"];

}

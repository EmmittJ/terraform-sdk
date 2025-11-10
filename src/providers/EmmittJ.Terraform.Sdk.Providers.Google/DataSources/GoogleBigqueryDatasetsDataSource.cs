using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Retrieves information about a google_bigquery_datasets.
/// </summary>
public class GoogleBigqueryDatasetsDataSource : TerraformDataSource
{
    public GoogleBigqueryDatasetsDataSource(string name) : base("google_bigquery_datasets", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// The ID of the project in which the datasets are located. If it is not provided, the provider project is used.
    /// </summary>
    [TerraformPropertyName("project")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Project { get; set; }

    /// <summary>
    /// The datasets attribute.
    /// </summary>
    [TerraformPropertyName("datasets")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> Datasets => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "datasets");

}

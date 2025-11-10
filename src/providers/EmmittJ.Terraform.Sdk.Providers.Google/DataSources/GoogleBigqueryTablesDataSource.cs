using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Retrieves information about a google_bigquery_tables.
/// </summary>
public class GoogleBigqueryTablesDataSource : TerraformDataSource
{
    public GoogleBigqueryTablesDataSource(string name) : base("google_bigquery_tables", name)
    {
    }

    /// <summary>
    /// The ID of the dataset containing the tables.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DatasetId is required")]
    [TerraformPropertyName("dataset_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> DatasetId { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// The ID of the project in which the dataset is located. If it is not provided, the provider project is used.
    /// </summary>
    [TerraformPropertyName("project")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Project { get; set; }

    /// <summary>
    /// The tables attribute.
    /// </summary>
    [TerraformPropertyName("tables")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> Tables => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "tables");

}

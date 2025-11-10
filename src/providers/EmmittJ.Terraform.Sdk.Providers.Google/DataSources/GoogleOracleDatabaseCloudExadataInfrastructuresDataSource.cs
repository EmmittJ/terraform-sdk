using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Retrieves information about a google_oracle_database_cloud_exadata_infrastructures.
/// </summary>
public class GoogleOracleDatabaseCloudExadataInfrastructuresDataSource : TerraformDataSource
{
    public GoogleOracleDatabaseCloudExadataInfrastructuresDataSource(string name) : base("google_oracle_database_cloud_exadata_infrastructures", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// location
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    [TerraformPropertyName("location")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Location { get; set; }

    /// <summary>
    /// The ID of the project in which the dataset is located. If it is not provided, the provider project is used.
    /// </summary>
    [TerraformPropertyName("project")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Project { get; set; }

    /// <summary>
    /// The cloud_exadata_infrastructures attribute.
    /// </summary>
    [TerraformPropertyName("cloud_exadata_infrastructures")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> CloudExadataInfrastructures => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "cloud_exadata_infrastructures");

}

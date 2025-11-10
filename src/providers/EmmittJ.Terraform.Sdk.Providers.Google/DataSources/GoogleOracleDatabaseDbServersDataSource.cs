using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Retrieves information about a google_oracle_database_db_servers.
/// </summary>
public class GoogleOracleDatabaseDbServersDataSource : TerraformDataSource
{
    public GoogleOracleDatabaseDbServersDataSource(string name) : base("google_oracle_database_db_servers", name)
    {
    }

    /// <summary>
    /// exadata
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CloudExadataInfrastructure is required")]
    [TerraformPropertyName("cloud_exadata_infrastructure")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> CloudExadataInfrastructure { get; set; }

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
    /// The db_servers attribute.
    /// </summary>
    [TerraformPropertyName("db_servers")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> DbServers => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "db_servers");

}

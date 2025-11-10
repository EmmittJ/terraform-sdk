using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Retrieves information about a google_sql_databases.
/// </summary>
public class GoogleSqlDatabasesDataSource : TerraformDataSource
{
    public GoogleSqlDatabasesDataSource(string name) : base("google_sql_databases", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// The name of the Cloud SQL database instance in which the database belongs.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Instance is required")]
    [TerraformPropertyName("instance")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Instance { get; set; }

    /// <summary>
    /// Project ID of the project that contains the instance.
    /// </summary>
    [TerraformPropertyName("project")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Project { get; set; }

    /// <summary>
    /// The databases attribute.
    /// </summary>
    [TerraformPropertyName("databases")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> Databases => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "databases");

}

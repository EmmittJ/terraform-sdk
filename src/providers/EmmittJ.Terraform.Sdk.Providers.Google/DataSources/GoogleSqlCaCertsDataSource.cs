using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Retrieves information about a google_sql_ca_certs.
/// </summary>
public class GoogleSqlCaCertsDataSource : TerraformDataSource
{
    public GoogleSqlCaCertsDataSource(string name) : base("google_sql_ca_certs", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// The instance attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Instance is required")]
    [TerraformPropertyName("instance")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Instance { get; set; }

    /// <summary>
    /// The project attribute.
    /// </summary>
    [TerraformPropertyName("project")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Project { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "project");

    /// <summary>
    /// The active_version attribute.
    /// </summary>
    [TerraformPropertyName("active_version")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> ActiveVersion => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "active_version");

    /// <summary>
    /// The certs attribute.
    /// </summary>
    [TerraformPropertyName("certs")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> Certs => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "certs");

}

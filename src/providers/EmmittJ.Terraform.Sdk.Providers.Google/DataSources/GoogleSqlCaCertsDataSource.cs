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
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Id { get; set; } = default!;

    /// <summary>
    /// The instance attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Instance is required")]
    [TerraformPropertyName("instance")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Instance { get; set; }

    /// <summary>
    /// The project attribute.
    /// </summary>
    [TerraformPropertyName("project")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Project { get; set; } = default!;

    /// <summary>
    /// The active_version attribute.
    /// </summary>
    [TerraformPropertyName("active_version")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> ActiveVersion => new TerraformReference(this, "active_version");

    /// <summary>
    /// The certs attribute.
    /// </summary>
    [TerraformPropertyName("certs")]
    // Output-only attribute - read-only reference
    public TerraformList<object> Certs => new TerraformReference(this, "certs");

}

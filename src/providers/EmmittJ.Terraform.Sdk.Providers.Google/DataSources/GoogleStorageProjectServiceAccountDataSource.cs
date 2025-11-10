using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Retrieves information about a google_storage_project_service_account.
/// </summary>
public class GoogleStorageProjectServiceAccountDataSource : TerraformDataSource
{
    public GoogleStorageProjectServiceAccountDataSource(string name) : base("google_storage_project_service_account", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// The project attribute.
    /// </summary>
    [TerraformPropertyName("project")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Project { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "project");

    /// <summary>
    /// The user_project attribute.
    /// </summary>
    [TerraformPropertyName("user_project")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? UserProject { get; set; }

    /// <summary>
    /// The email_address attribute.
    /// </summary>
    [TerraformPropertyName("email_address")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> EmailAddress => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "email_address");

    /// <summary>
    /// The member attribute.
    /// </summary>
    [TerraformPropertyName("member")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Member => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "member");

}

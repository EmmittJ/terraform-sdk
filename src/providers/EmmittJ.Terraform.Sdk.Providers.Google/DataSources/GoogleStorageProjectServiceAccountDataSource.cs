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
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Id { get; set; } = default!;

    /// <summary>
    /// The project attribute.
    /// </summary>
    [TerraformPropertyName("project")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Project { get; set; } = default!;

    /// <summary>
    /// The user_project attribute.
    /// </summary>
    [TerraformPropertyName("user_project")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? UserProject { get; set; }

    /// <summary>
    /// The email_address attribute.
    /// </summary>
    [TerraformPropertyName("email_address")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> EmailAddress => new TerraformReference(this, "email_address");

    /// <summary>
    /// The member attribute.
    /// </summary>
    [TerraformPropertyName("member")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Member => new TerraformReference(this, "member");

}

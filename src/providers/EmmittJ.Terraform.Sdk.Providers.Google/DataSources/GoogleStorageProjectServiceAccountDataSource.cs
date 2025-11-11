using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Retrieves information about a google_storage_project_service_account.
/// </summary>
public partial class GoogleStorageProjectServiceAccountDataSource : TerraformDataSource
{
    public GoogleStorageProjectServiceAccountDataSource(string name) : base("google_storage_project_service_account", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The project attribute.
    /// </summary>
    [TerraformProperty("project")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Project { get; set; }

    /// <summary>
    /// The user_project attribute.
    /// </summary>
    [TerraformProperty("user_project")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? UserProject { get; set; }

    /// <summary>
    /// The email_address attribute.
    /// </summary>
    [TerraformProperty("email_address")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> EmailAddress { get; }

    /// <summary>
    /// The member attribute.
    /// </summary>
    [TerraformProperty("member")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Member { get; }

}

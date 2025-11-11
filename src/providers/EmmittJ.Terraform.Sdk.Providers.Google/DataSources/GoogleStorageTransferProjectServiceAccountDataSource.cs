using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Retrieves information about a google_storage_transfer_project_service_account.
/// </summary>
public partial class GoogleStorageTransferProjectServiceAccountDataSource : TerraformDataSource
{
    public GoogleStorageTransferProjectServiceAccountDataSource(string name) : base("google_storage_transfer_project_service_account", name)
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
    /// The email attribute.
    /// </summary>
    [TerraformProperty("email")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Email { get; }

    /// <summary>
    /// The member attribute.
    /// </summary>
    [TerraformProperty("member")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Member { get; }

    /// <summary>
    /// The subject_id attribute.
    /// </summary>
    [TerraformProperty("subject_id")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> SubjectId { get; }

}

using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Retrieves information about a google_storage_buckets.
/// </summary>
public partial class GoogleStorageBucketsDataSource : TerraformDataSource
{
    public GoogleStorageBucketsDataSource(string name) : base("google_storage_buckets", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The prefix attribute.
    /// </summary>
    [TerraformProperty("prefix")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Prefix { get; set; }

    /// <summary>
    /// The project attribute.
    /// </summary>
    [TerraformProperty("project")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Project { get; set; }

    /// <summary>
    /// The buckets attribute.
    /// </summary>
    [TerraformProperty("buckets")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformList<object> Buckets { get; }

}

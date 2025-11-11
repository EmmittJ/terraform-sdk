using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Retrieves information about a google_cloud_quotas_quota_infos.
/// </summary>
public class GoogleCloudQuotasQuotaInfosDataSource : TerraformDataSource
{
    public GoogleCloudQuotasQuotaInfosDataSource(string name) : base("google_cloud_quotas_quota_infos", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Id { get; set; } = default!;

    /// <summary>
    /// The parent attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Parent is required")]
    [TerraformPropertyName("parent")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Parent { get; set; }

    /// <summary>
    /// The service attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Service is required")]
    [TerraformPropertyName("service")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Service { get; set; }

    /// <summary>
    /// The quota_infos attribute.
    /// </summary>
    [TerraformPropertyName("quota_infos")]
    // Output-only attribute - read-only reference
    public TerraformList<object> QuotaInfos => new TerraformReference(this, "quota_infos");

}

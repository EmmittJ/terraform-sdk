using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_iam_access_keys.
/// </summary>
public partial class AwsIamAccessKeysDataSource : TerraformDataSource
{
    public AwsIamAccessKeysDataSource(string name) : base("aws_iam_access_keys", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The user attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "User is required")]
    [TerraformProperty("user")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> User { get; set; }

    /// <summary>
    /// The access_keys attribute.
    /// </summary>
    [TerraformProperty("access_keys")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformSet<object> AccessKeys { get; }

}

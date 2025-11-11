using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_redshiftserverless_credentials.
/// </summary>
public partial class AwsRedshiftserverlessCredentialsDataSource : TerraformDataSource
{
    public AwsRedshiftserverlessCredentialsDataSource(string name) : base("aws_redshiftserverless_credentials", name)
    {
    }

    /// <summary>
    /// The db_name attribute.
    /// </summary>
    [TerraformProperty("db_name")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? DbName { get; set; }

    /// <summary>
    /// The duration_seconds attribute.
    /// </summary>
    [TerraformProperty("duration_seconds")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<double>? DurationSeconds { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformProperty("region")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Region { get; set; }

    /// <summary>
    /// The workgroup_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "WorkgroupName is required")]
    [TerraformProperty("workgroup_name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> WorkgroupName { get; set; }

    /// <summary>
    /// The db_password attribute.
    /// </summary>
    [TerraformProperty("db_password")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> DbPassword { get; }

    /// <summary>
    /// The db_user attribute.
    /// </summary>
    [TerraformProperty("db_user")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> DbUser { get; }

    /// <summary>
    /// The expiration attribute.
    /// </summary>
    [TerraformProperty("expiration")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Expiration { get; }

}

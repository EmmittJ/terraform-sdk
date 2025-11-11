using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_redshiftserverless_credentials.
/// </summary>
public class AwsRedshiftserverlessCredentialsDataSource : TerraformDataSource
{
    public AwsRedshiftserverlessCredentialsDataSource(string name) : base("aws_redshiftserverless_credentials", name)
    {
    }

    /// <summary>
    /// The db_name attribute.
    /// </summary>
    [TerraformPropertyName("db_name")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? DbName { get; set; }

    /// <summary>
    /// The duration_seconds attribute.
    /// </summary>
    [TerraformPropertyName("duration_seconds")]
    // Optional argument - user may or may not set a value
    public TerraformValue<double>? DurationSeconds { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Id { get; set; } = default!;

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Region { get; set; } = default!;

    /// <summary>
    /// The workgroup_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "WorkgroupName is required")]
    [TerraformPropertyName("workgroup_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> WorkgroupName { get; set; }

    /// <summary>
    /// The db_password attribute.
    /// </summary>
    [TerraformPropertyName("db_password")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> DbPassword => new TerraformReference(this, "db_password");

    /// <summary>
    /// The db_user attribute.
    /// </summary>
    [TerraformPropertyName("db_user")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> DbUser => new TerraformReference(this, "db_user");

    /// <summary>
    /// The expiration attribute.
    /// </summary>
    [TerraformPropertyName("expiration")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Expiration => new TerraformReference(this, "expiration");

}

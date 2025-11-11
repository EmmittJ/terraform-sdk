using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_workspaces_bundle.
/// </summary>
public class AwsWorkspacesBundleDataSource : TerraformDataSource
{
    public AwsWorkspacesBundleDataSource(string name) : base("aws_workspaces_bundle", name)
    {
    }

    /// <summary>
    /// The bundle_id attribute.
    /// </summary>
    [TerraformPropertyName("bundle_id")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? BundleId { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Id { get; set; } = default!;

    /// <summary>
    /// The name attribute.
    /// </summary>
    [TerraformPropertyName("name")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Name { get; set; }

    /// <summary>
    /// The owner attribute.
    /// </summary>
    [TerraformPropertyName("owner")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Owner { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Region { get; set; } = default!;

    /// <summary>
    /// The compute_type attribute.
    /// </summary>
    [TerraformPropertyName("compute_type")]
    // Output-only attribute - read-only reference
    public TerraformList<object> ComputeType => new TerraformReference(this, "compute_type");

    /// <summary>
    /// The description attribute.
    /// </summary>
    [TerraformPropertyName("description")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Description => new TerraformReference(this, "description");

    /// <summary>
    /// The root_storage attribute.
    /// </summary>
    [TerraformPropertyName("root_storage")]
    // Output-only attribute - read-only reference
    public TerraformList<object> RootStorage => new TerraformReference(this, "root_storage");

    /// <summary>
    /// The user_storage attribute.
    /// </summary>
    [TerraformPropertyName("user_storage")]
    // Output-only attribute - read-only reference
    public TerraformList<object> UserStorage => new TerraformReference(this, "user_storage");

}

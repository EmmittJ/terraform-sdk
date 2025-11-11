using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_workspaces_bundle.
/// </summary>
public partial class AwsWorkspacesBundleDataSource : TerraformDataSource
{
    public AwsWorkspacesBundleDataSource(string name) : base("aws_workspaces_bundle", name)
    {
    }

    /// <summary>
    /// The bundle_id attribute.
    /// </summary>
    [TerraformProperty("bundle_id")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? BundleId { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [TerraformProperty("name")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Name { get; set; }

    /// <summary>
    /// The owner attribute.
    /// </summary>
    [TerraformProperty("owner")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Owner { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformProperty("region")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Region { get; set; }

    /// <summary>
    /// The compute_type attribute.
    /// </summary>
    [TerraformProperty("compute_type")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformList<object> ComputeType { get; }

    /// <summary>
    /// The description attribute.
    /// </summary>
    [TerraformProperty("description")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Description { get; }

    /// <summary>
    /// The root_storage attribute.
    /// </summary>
    [TerraformProperty("root_storage")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformList<object> RootStorage { get; }

    /// <summary>
    /// The user_storage attribute.
    /// </summary>
    [TerraformProperty("user_storage")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformList<object> UserStorage { get; }

}

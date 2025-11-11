using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_eks_addon.
/// </summary>
public class AwsEksAddonDataSource : TerraformDataSource
{
    public AwsEksAddonDataSource(string name) : base("aws_eks_addon", name)
    {
    }

    /// <summary>
    /// The addon_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AddonName is required")]
    [TerraformPropertyName("addon_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> AddonName { get; set; }

    /// <summary>
    /// The cluster_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ClusterName is required")]
    [TerraformPropertyName("cluster_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> ClusterName { get; set; }

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
    /// The tags attribute.
    /// </summary>
    [TerraformPropertyName("tags")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformMap<string> Tags { get; set; } = default!;

    /// <summary>
    /// The addon_version attribute.
    /// </summary>
    [TerraformPropertyName("addon_version")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> AddonVersion => new TerraformReference(this, "addon_version");

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformPropertyName("arn")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Arn => new TerraformReference(this, "arn");

    /// <summary>
    /// The configuration_values attribute.
    /// </summary>
    [TerraformPropertyName("configuration_values")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> ConfigurationValues => new TerraformReference(this, "configuration_values");

    /// <summary>
    /// The created_at attribute.
    /// </summary>
    [TerraformPropertyName("created_at")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> CreatedAt => new TerraformReference(this, "created_at");

    /// <summary>
    /// The modified_at attribute.
    /// </summary>
    [TerraformPropertyName("modified_at")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> ModifiedAt => new TerraformReference(this, "modified_at");

    /// <summary>
    /// The pod_identity_association attribute.
    /// </summary>
    [TerraformPropertyName("pod_identity_association")]
    // Output-only attribute - read-only reference
    public TerraformSet<object> PodIdentityAssociation => new TerraformReference(this, "pod_identity_association");

    /// <summary>
    /// The service_account_role_arn attribute.
    /// </summary>
    [TerraformPropertyName("service_account_role_arn")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> ServiceAccountRoleArn => new TerraformReference(this, "service_account_role_arn");

}

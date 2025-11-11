using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_eks_addon.
/// </summary>
public partial class AwsEksAddonDataSource : TerraformDataSource
{
    public AwsEksAddonDataSource(string name) : base("aws_eks_addon", name)
    {
    }

    /// <summary>
    /// The addon_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AddonName is required")]
    [TerraformProperty("addon_name")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> AddonName { get; set; }

    /// <summary>
    /// The cluster_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ClusterName is required")]
    [TerraformProperty("cluster_name")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> ClusterName { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Id { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformProperty("region")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Region { get; set; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformProperty("tags")]
    // Optional+Computed - source generator will implement get/set
    public TerraformMap<string> Tags { get; set; }

    /// <summary>
    /// The addon_version attribute.
    /// </summary>
    [TerraformProperty("addon_version")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> AddonVersion { get; }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformProperty("arn")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Arn { get; }

    /// <summary>
    /// The configuration_values attribute.
    /// </summary>
    [TerraformProperty("configuration_values")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> ConfigurationValues { get; }

    /// <summary>
    /// The created_at attribute.
    /// </summary>
    [TerraformProperty("created_at")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> CreatedAt { get; }

    /// <summary>
    /// The modified_at attribute.
    /// </summary>
    [TerraformProperty("modified_at")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> ModifiedAt { get; }

    /// <summary>
    /// The pod_identity_association attribute.
    /// </summary>
    [TerraformProperty("pod_identity_association")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformSet<object> PodIdentityAssociation { get; }

    /// <summary>
    /// The service_account_role_arn attribute.
    /// </summary>
    [TerraformProperty("service_account_role_arn")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> ServiceAccountRoleArn { get; }

}

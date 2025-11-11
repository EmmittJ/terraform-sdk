using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for pod_identity_association in .
/// Nesting mode: set
/// </summary>
public partial class AwsEksAddonPodIdentityAssociationBlock : TerraformBlockBase
{
    /// <summary>
    /// The role_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RoleArn is required")]
    [TerraformProperty("role_arn")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> RoleArn { get; set; }

    /// <summary>
    /// The service_account attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ServiceAccount is required")]
    [TerraformProperty("service_account")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> ServiceAccount { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AwsEksAddonTimeoutsBlock : TerraformBlockBase
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformProperty("create")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformProperty("delete")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Delete { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformProperty("update")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Update { get; set; }

}

/// <summary>
/// Manages a aws_eks_addon resource.
/// </summary>
public partial class AwsEksAddon : TerraformResource
{
    public AwsEksAddon(string name) : base("aws_eks_addon", name)
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
    /// The addon_version attribute.
    /// </summary>
    [TerraformProperty("addon_version")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> AddonVersion { get; set; }

    /// <summary>
    /// The cluster_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ClusterName is required")]
    [TerraformProperty("cluster_name")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> ClusterName { get; set; }

    /// <summary>
    /// The configuration_values attribute.
    /// </summary>
    [TerraformProperty("configuration_values")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> ConfigurationValues { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The preserve attribute.
    /// </summary>
    [TerraformProperty("preserve")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<bool>? Preserve { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformProperty("region")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Region { get; set; }

    /// <summary>
    /// The resolve_conflicts_on_create attribute.
    /// </summary>
    [TerraformProperty("resolve_conflicts_on_create")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? ResolveConflictsOnCreate { get; set; }

    /// <summary>
    /// The resolve_conflicts_on_update attribute.
    /// </summary>
    [TerraformProperty("resolve_conflicts_on_update")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? ResolveConflictsOnUpdate { get; set; }

    /// <summary>
    /// The service_account_role_arn attribute.
    /// </summary>
    [TerraformProperty("service_account_role_arn")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? ServiceAccountRoleArn { get; set; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformProperty("tags")]
    // Optional argument - source generator will implement get/set
    public TerraformMap<string>? Tags { get; set; }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    [TerraformProperty("tags_all")]
    // Optional+Computed - source generator will implement get/set
    public TerraformMap<string> TagsAll { get; set; }

    /// <summary>
    /// Block for pod_identity_association.
    /// Nesting mode: set
    /// </summary>
    [TerraformProperty("pod_identity_association")]
    public TerraformSet<TerraformBlock<AwsEksAddonPodIdentityAssociationBlock>>? PodIdentityAssociation { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public TerraformBlock<AwsEksAddonTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformProperty("arn")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Arn { get; }

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

}

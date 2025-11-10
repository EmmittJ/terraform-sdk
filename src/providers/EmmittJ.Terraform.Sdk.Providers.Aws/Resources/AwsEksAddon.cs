using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for pod_identity_association in .
/// Nesting mode: set
/// </summary>
public class AwsEksAddonPodIdentityAssociationBlock : ITerraformBlock
{
    /// <summary>
    /// The role_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RoleArn is required")]
    [TerraformPropertyName("role_arn")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> RoleArn { get; set; }

    /// <summary>
    /// The service_account attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ServiceAccount is required")]
    [TerraformPropertyName("service_account")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> ServiceAccount { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AwsEksAddonTimeoutsBlock : ITerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformPropertyName("create")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformPropertyName("delete")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Delete { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformPropertyName("update")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Update { get; set; }

}

/// <summary>
/// Manages a aws_eks_addon resource.
/// </summary>
public class AwsEksAddon : TerraformResource
{
    public AwsEksAddon(string name) : base("aws_eks_addon", name)
    {
    }

    /// <summary>
    /// The addon_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AddonName is required")]
    [TerraformPropertyName("addon_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> AddonName { get; set; }

    /// <summary>
    /// The addon_version attribute.
    /// </summary>
    [TerraformPropertyName("addon_version")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> AddonVersion { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "addon_version");

    /// <summary>
    /// The cluster_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ClusterName is required")]
    [TerraformPropertyName("cluster_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> ClusterName { get; set; }

    /// <summary>
    /// The configuration_values attribute.
    /// </summary>
    [TerraformPropertyName("configuration_values")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> ConfigurationValues { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "configuration_values");

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// The preserve attribute.
    /// </summary>
    [TerraformPropertyName("preserve")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? Preserve { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Region { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "region");

    /// <summary>
    /// The resolve_conflicts_on_create attribute.
    /// </summary>
    [TerraformPropertyName("resolve_conflicts_on_create")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? ResolveConflictsOnCreate { get; set; }

    /// <summary>
    /// The resolve_conflicts_on_update attribute.
    /// </summary>
    [TerraformPropertyName("resolve_conflicts_on_update")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? ResolveConflictsOnUpdate { get; set; }

    /// <summary>
    /// The service_account_role_arn attribute.
    /// </summary>
    [TerraformPropertyName("service_account_role_arn")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? ServiceAccountRoleArn { get; set; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformPropertyName("tags")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>>? Tags { get; set; }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    [TerraformPropertyName("tags_all")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>> TagsAll { get; set; } = new TerraformReferenceProperty<Dictionary<string, TerraformProperty<string>>>(ResourceAddress, "tags_all");

    /// <summary>
    /// Block for pod_identity_association.
    /// Nesting mode: set
    /// </summary>
    [TerraformPropertyName("pod_identity_association")]
    public TerraformSet<TerraformBlock<AwsEksAddonPodIdentityAssociationBlock>>? PodIdentityAssociation { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AwsEksAddonTimeoutsBlock>? Timeouts { get; set; } = new();

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformPropertyName("arn")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Arn => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "arn");

    /// <summary>
    /// The created_at attribute.
    /// </summary>
    [TerraformPropertyName("created_at")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> CreatedAt => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "created_at");

    /// <summary>
    /// The modified_at attribute.
    /// </summary>
    [TerraformPropertyName("modified_at")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> ModifiedAt => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "modified_at");

}

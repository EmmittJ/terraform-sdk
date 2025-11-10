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
    public required TerraformProperty<TerraformProperty<string>> AddonName { get; set; }

    /// <summary>
    /// The cluster_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ClusterName is required")]
    [TerraformPropertyName("cluster_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> ClusterName { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Region { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "region");

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformPropertyName("tags")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>> Tags { get; set; } = new TerraformReferenceProperty<Dictionary<string, TerraformProperty<string>>>(ResourceAddress, "tags");

    /// <summary>
    /// The addon_version attribute.
    /// </summary>
    [TerraformPropertyName("addon_version")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> AddonVersion => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "addon_version");

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformPropertyName("arn")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Arn => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "arn");

    /// <summary>
    /// The configuration_values attribute.
    /// </summary>
    [TerraformPropertyName("configuration_values")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> ConfigurationValues => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "configuration_values");

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

    /// <summary>
    /// The pod_identity_association attribute.
    /// </summary>
    [TerraformPropertyName("pod_identity_association")]
    // Output-only attribute - read-only reference
    public TerraformProperty<HashSet<TerraformProperty<object>>> PodIdentityAssociation => new TerraformReferenceProperty<HashSet<TerraformProperty<object>>>(ResourceAddress, "pod_identity_association");

    /// <summary>
    /// The service_account_role_arn attribute.
    /// </summary>
    [TerraformPropertyName("service_account_role_arn")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> ServiceAccountRoleArn => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "service_account_role_arn");

}

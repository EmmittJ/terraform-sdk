using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_eks_pod_identity_association resource.
/// </summary>
public partial class AwsEksPodIdentityAssociation : TerraformResource
{
    public AwsEksPodIdentityAssociation(string name) : base("aws_eks_pod_identity_association", name)
    {
    }

    /// <summary>
    /// The cluster_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ClusterName is required")]
    [TerraformProperty("cluster_name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> ClusterName { get; set; }

    /// <summary>
    /// The disable_session_tags attribute.
    /// </summary>
    [TerraformProperty("disable_session_tags")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<bool> DisableSessionTags { get; set; }

    /// <summary>
    /// The namespace attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Namespace is required")]
    [TerraformProperty("namespace")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Namespace { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformProperty("region")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Region { get; set; }

    /// <summary>
    /// The role_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RoleArn is required")]
    [TerraformProperty("role_arn")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> RoleArn { get; set; }

    /// <summary>
    /// The service_account attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ServiceAccount is required")]
    [TerraformProperty("service_account")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> ServiceAccount { get; set; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformProperty("tags")]
    // Optional argument - source generator will implement get/set
    public partial TerraformMap<string>? Tags { get; set; }

    /// <summary>
    /// The target_role_arn attribute.
    /// </summary>
    [TerraformProperty("target_role_arn")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? TargetRoleArn { get; set; }

    /// <summary>
    /// The association_arn attribute.
    /// </summary>
    [TerraformProperty("association_arn")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> AssociationArn { get; }

    /// <summary>
    /// The association_id attribute.
    /// </summary>
    [TerraformProperty("association_id")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> AssociationId { get; }

    /// <summary>
    /// The external_id attribute.
    /// </summary>
    [TerraformProperty("external_id")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> ExternalId { get; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Id { get; }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    [TerraformProperty("tags_all")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformMap<string> TagsAll { get; }

}

using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for access_scope in .
/// Nesting mode: list
/// </summary>
public partial class AwsEksAccessPolicyAssociationAccessScopeBlock() : TerraformBlock("access_scope")
{
    /// <summary>
    /// The namespaces attribute.
    /// </summary>
    [TerraformProperty("namespaces")]
    // Optional argument - source generator will implement get/set
    public partial TerraformSet<string>? Namespaces { get; set; }

    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    [TerraformProperty("type")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Type { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AwsEksAccessPolicyAssociationTimeoutsBlock() : TerraformBlock("timeouts")
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformProperty("create")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformProperty("delete")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Delete { get; set; }

}

/// <summary>
/// Manages a aws_eks_access_policy_association resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class AwsEksAccessPolicyAssociation : TerraformResource
{
    public AwsEksAccessPolicyAssociation(string name) : base("aws_eks_access_policy_association", name)
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
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The policy_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PolicyArn is required")]
    [TerraformProperty("policy_arn")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> PolicyArn { get; set; }

    /// <summary>
    /// The principal_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PrincipalArn is required")]
    [TerraformProperty("principal_arn")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> PrincipalArn { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformProperty("region")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Region { get; set; }

    /// <summary>
    /// Block for access_scope.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AccessScope is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 AccessScope block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AccessScope block(s) allowed")]
    [TerraformProperty("access_scope")]
    public required TerraformList<AwsEksAccessPolicyAssociationAccessScopeBlock> AccessScope { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public AwsEksAccessPolicyAssociationTimeoutsBlock Timeouts { get; set; } = new();

    /// <summary>
    /// The associated_at attribute.
    /// </summary>
    [TerraformProperty("associated_at")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> AssociatedAt { get; }

    /// <summary>
    /// The modified_at attribute.
    /// </summary>
    [TerraformProperty("modified_at")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> ModifiedAt { get; }

}

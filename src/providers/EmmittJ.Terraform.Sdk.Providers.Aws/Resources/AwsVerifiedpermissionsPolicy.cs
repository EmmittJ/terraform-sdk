using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for definition in .
/// Nesting mode: list
/// </summary>
public partial class AwsVerifiedpermissionsPolicyDefinitionBlock() : TerraformBlock("definition")
{
}

/// <summary>
/// Manages a aws_verifiedpermissions_policy resource.
/// </summary>
public partial class AwsVerifiedpermissionsPolicy : TerraformResource
{
    public AwsVerifiedpermissionsPolicy(string name) : base("aws_verifiedpermissions_policy", name)
    {
    }

    /// <summary>
    /// The policy_store_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PolicyStoreId is required")]
    [TerraformProperty("policy_store_id")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> PolicyStoreId { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformProperty("region")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Region { get; set; }

    /// <summary>
    /// Block for definition.
    /// Nesting mode: list
    /// </summary>
    [TerraformProperty("definition")]
    public TerraformList<AwsVerifiedpermissionsPolicyDefinitionBlock> Definition { get; set; } = new();

    /// <summary>
    /// The created_date attribute.
    /// </summary>
    [TerraformProperty("created_date")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> CreatedDate { get; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Id { get; }

    /// <summary>
    /// The policy_id attribute.
    /// </summary>
    [TerraformProperty("policy_id")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> PolicyId { get; }

}

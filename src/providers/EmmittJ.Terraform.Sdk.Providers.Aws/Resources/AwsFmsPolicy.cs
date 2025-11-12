using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for exclude_map in .
/// Nesting mode: list
/// </summary>
public partial class AwsFmsPolicyExcludeMapBlock() : TerraformBlock("exclude_map")
{
    /// <summary>
    /// The account attribute.
    /// </summary>
    [TerraformProperty("account")]
    // Optional argument - source generator will implement get/set
    public partial TerraformSet<string>? Account { get; set; }

    /// <summary>
    /// The orgunit attribute.
    /// </summary>
    [TerraformProperty("orgunit")]
    // Optional argument - source generator will implement get/set
    public partial TerraformSet<string>? Orgunit { get; set; }

}

/// <summary>
/// Block type for include_map in .
/// Nesting mode: list
/// </summary>
public partial class AwsFmsPolicyIncludeMapBlock() : TerraformBlock("include_map")
{
    /// <summary>
    /// The account attribute.
    /// </summary>
    [TerraformProperty("account")]
    // Optional argument - source generator will implement get/set
    public partial TerraformSet<string>? Account { get; set; }

    /// <summary>
    /// The orgunit attribute.
    /// </summary>
    [TerraformProperty("orgunit")]
    // Optional argument - source generator will implement get/set
    public partial TerraformSet<string>? Orgunit { get; set; }

}

/// <summary>
/// Block type for security_service_policy_data in .
/// Nesting mode: list
/// </summary>
public partial class AwsFmsPolicySecurityServicePolicyDataBlock() : TerraformBlock("security_service_policy_data")
{
    /// <summary>
    /// The managed_service_data attribute.
    /// </summary>
    [TerraformProperty("managed_service_data")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? ManagedServiceData { get; set; }

    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    [TerraformProperty("type")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Type { get; set; }

}

/// <summary>
/// Manages a aws_fms_policy resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class AwsFmsPolicy : TerraformResource
{
    public AwsFmsPolicy(string name) : base("aws_fms_policy", name)
    {
    }

    /// <summary>
    /// The delete_all_policy_resources attribute.
    /// </summary>
    [TerraformProperty("delete_all_policy_resources")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? DeleteAllPolicyResources { get; set; }

    /// <summary>
    /// The delete_unused_fm_managed_resources attribute.
    /// </summary>
    [TerraformProperty("delete_unused_fm_managed_resources")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? DeleteUnusedFmManagedResources { get; set; }

    /// <summary>
    /// The description attribute.
    /// </summary>
    [TerraformProperty("description")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Description { get; set; }

    /// <summary>
    /// The exclude_resource_tags attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ExcludeResourceTags is required")]
    [TerraformProperty("exclude_resource_tags")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<bool> ExcludeResourceTags { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Name { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformProperty("region")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Region { get; set; }

    /// <summary>
    /// The remediation_enabled attribute.
    /// </summary>
    [TerraformProperty("remediation_enabled")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? RemediationEnabled { get; set; }

    /// <summary>
    /// The resource_set_ids attribute.
    /// </summary>
    [TerraformProperty("resource_set_ids")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformSet<string> ResourceSetIds { get; set; }

    /// <summary>
    /// The resource_tag_logical_operator attribute.
    /// </summary>
    [TerraformProperty("resource_tag_logical_operator")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> ResourceTagLogicalOperator { get; set; }

    /// <summary>
    /// The resource_tags attribute.
    /// </summary>
    [TerraformProperty("resource_tags")]
    // Optional argument - source generator will implement get/set
    public partial TerraformMap<string>? ResourceTags { get; set; }

    /// <summary>
    /// The resource_type attribute.
    /// </summary>
    [TerraformProperty("resource_type")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> ResourceType { get; set; }

    /// <summary>
    /// The resource_type_list attribute.
    /// </summary>
    [TerraformProperty("resource_type_list")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformSet<string> ResourceTypeList { get; set; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformProperty("tags")]
    // Optional argument - source generator will implement get/set
    public partial TerraformMap<string>? Tags { get; set; }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    [TerraformProperty("tags_all")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformMap<string> TagsAll { get; set; }

    /// <summary>
    /// Block for exclude_map.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ExcludeMap block(s) allowed")]
    [TerraformProperty("exclude_map")]
    public TerraformList<AwsFmsPolicyExcludeMapBlock> ExcludeMap { get; set; } = new();

    /// <summary>
    /// Block for include_map.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 IncludeMap block(s) allowed")]
    [TerraformProperty("include_map")]
    public TerraformList<AwsFmsPolicyIncludeMapBlock> IncludeMap { get; set; } = new();

    /// <summary>
    /// Block for security_service_policy_data.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SecurityServicePolicyData is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 SecurityServicePolicyData block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SecurityServicePolicyData block(s) allowed")]
    [TerraformProperty("security_service_policy_data")]
    public required TerraformList<AwsFmsPolicySecurityServicePolicyDataBlock> SecurityServicePolicyData { get; set; } = new();

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformProperty("arn")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Arn { get; }

    /// <summary>
    /// The policy_update_token attribute.
    /// </summary>
    [TerraformProperty("policy_update_token")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> PolicyUpdateToken { get; }

}

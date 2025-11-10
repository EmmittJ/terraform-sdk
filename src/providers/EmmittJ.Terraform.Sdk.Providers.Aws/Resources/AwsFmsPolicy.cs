using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for exclude_map in .
/// Nesting mode: list
/// </summary>
public class AwsFmsPolicyExcludeMapBlock : ITerraformBlock
{
    /// <summary>
    /// The account attribute.
    /// </summary>
    [TerraformPropertyName("account")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<HashSet<TerraformProperty<string>>>? Account { get; set; }

    /// <summary>
    /// The orgunit attribute.
    /// </summary>
    [TerraformPropertyName("orgunit")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<HashSet<TerraformProperty<string>>>? Orgunit { get; set; }

}

/// <summary>
/// Block type for include_map in .
/// Nesting mode: list
/// </summary>
public class AwsFmsPolicyIncludeMapBlock : ITerraformBlock
{
    /// <summary>
    /// The account attribute.
    /// </summary>
    [TerraformPropertyName("account")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<HashSet<TerraformProperty<string>>>? Account { get; set; }

    /// <summary>
    /// The orgunit attribute.
    /// </summary>
    [TerraformPropertyName("orgunit")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<HashSet<TerraformProperty<string>>>? Orgunit { get; set; }

}

/// <summary>
/// Block type for security_service_policy_data in .
/// Nesting mode: list
/// </summary>
public class AwsFmsPolicySecurityServicePolicyDataBlock : ITerraformBlock
{
    /// <summary>
    /// The managed_service_data attribute.
    /// </summary>
    [TerraformPropertyName("managed_service_data")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? ManagedServiceData { get; set; }

    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    [TerraformPropertyName("type")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Type { get; set; }

}

/// <summary>
/// Manages a aws_fms_policy resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AwsFmsPolicy : TerraformResource
{
    public AwsFmsPolicy(string name) : base("aws_fms_policy", name)
    {
    }

    /// <summary>
    /// The delete_all_policy_resources attribute.
    /// </summary>
    [TerraformPropertyName("delete_all_policy_resources")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? DeleteAllPolicyResources { get; set; }

    /// <summary>
    /// The delete_unused_fm_managed_resources attribute.
    /// </summary>
    [TerraformPropertyName("delete_unused_fm_managed_resources")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? DeleteUnusedFmManagedResources { get; set; }

    /// <summary>
    /// The description attribute.
    /// </summary>
    [TerraformPropertyName("description")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Description { get; set; }

    /// <summary>
    /// The exclude_resource_tags attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ExcludeResourceTags is required")]
    [TerraformPropertyName("exclude_resource_tags")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<bool>> ExcludeResourceTags { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Name { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Region { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "region");

    /// <summary>
    /// The remediation_enabled attribute.
    /// </summary>
    [TerraformPropertyName("remediation_enabled")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<bool>>? RemediationEnabled { get; set; }

    /// <summary>
    /// The resource_set_ids attribute.
    /// </summary>
    [TerraformPropertyName("resource_set_ids")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<HashSet<TerraformProperty<string>>> ResourceSetIds { get; set; } = new TerraformReferenceProperty<HashSet<TerraformProperty<string>>>(ResourceAddress, "resource_set_ids");

    /// <summary>
    /// The resource_tag_logical_operator attribute.
    /// </summary>
    [TerraformPropertyName("resource_tag_logical_operator")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> ResourceTagLogicalOperator { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "resource_tag_logical_operator");

    /// <summary>
    /// The resource_tags attribute.
    /// </summary>
    [TerraformPropertyName("resource_tags")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>>? ResourceTags { get; set; }

    /// <summary>
    /// The resource_type attribute.
    /// </summary>
    [TerraformPropertyName("resource_type")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> ResourceType { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "resource_type");

    /// <summary>
    /// The resource_type_list attribute.
    /// </summary>
    [TerraformPropertyName("resource_type_list")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<HashSet<TerraformProperty<string>>> ResourceTypeList { get; set; } = new TerraformReferenceProperty<HashSet<TerraformProperty<string>>>(ResourceAddress, "resource_type_list");

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
    /// Block for exclude_map.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ExcludeMap block(s) allowed")]
    [TerraformPropertyName("exclude_map")]
    public TerraformList<TerraformBlock<AwsFmsPolicyExcludeMapBlock>>? ExcludeMap { get; set; } = new();

    /// <summary>
    /// Block for include_map.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 IncludeMap block(s) allowed")]
    [TerraformPropertyName("include_map")]
    public TerraformList<TerraformBlock<AwsFmsPolicyIncludeMapBlock>>? IncludeMap { get; set; } = new();

    /// <summary>
    /// Block for security_service_policy_data.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SecurityServicePolicyData is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 SecurityServicePolicyData block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SecurityServicePolicyData block(s) allowed")]
    [TerraformPropertyName("security_service_policy_data")]
    public TerraformList<TerraformBlock<AwsFmsPolicySecurityServicePolicyDataBlock>>? SecurityServicePolicyData { get; set; } = new();

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformPropertyName("arn")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Arn => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "arn");

    /// <summary>
    /// The policy_update_token attribute.
    /// </summary>
    [TerraformPropertyName("policy_update_token")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> PolicyUpdateToken => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "policy_update_token");

}

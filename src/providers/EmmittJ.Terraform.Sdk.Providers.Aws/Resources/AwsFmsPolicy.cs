using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for exclude_map in .
/// Nesting mode: list
/// </summary>
public class AwsFmsPolicyExcludeMapBlock : TerraformBlock
{
    /// <summary>
    /// The account attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>>? Account
    {
        get => GetProperty<HashSet<TerraformProperty<string>>>("account");
        set => WithProperty("account", value);
    }

    /// <summary>
    /// The orgunit attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>>? Orgunit
    {
        get => GetProperty<HashSet<TerraformProperty<string>>>("orgunit");
        set => WithProperty("orgunit", value);
    }

}

/// <summary>
/// Block type for include_map in .
/// Nesting mode: list
/// </summary>
public class AwsFmsPolicyIncludeMapBlock : TerraformBlock
{
    /// <summary>
    /// The account attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>>? Account
    {
        get => GetProperty<HashSet<TerraformProperty<string>>>("account");
        set => WithProperty("account", value);
    }

    /// <summary>
    /// The orgunit attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>>? Orgunit
    {
        get => GetProperty<HashSet<TerraformProperty<string>>>("orgunit");
        set => WithProperty("orgunit", value);
    }

}

/// <summary>
/// Block type for security_service_policy_data in .
/// Nesting mode: list
/// </summary>
public class AwsFmsPolicySecurityServicePolicyDataBlock : TerraformBlock
{
    /// <summary>
    /// The managed_service_data attribute.
    /// </summary>
    public TerraformProperty<string>? ManagedServiceData
    {
        get => GetProperty<TerraformProperty<string>>("managed_service_data");
        set => WithProperty("managed_service_data", value);
    }

    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    public required TerraformProperty<string> Type
    {
        get => GetRequiredProperty<TerraformProperty<string>>("type");
        set => WithProperty("type", value);
    }

}

/// <summary>
/// Manages a aws_fms_policy resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AwsFmsPolicy : TerraformResource
{
    public AwsFmsPolicy(string name) : base("aws_fms_policy", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("arn");
        this.DeclareOutput("policy_update_token");
    }

    /// <summary>
    /// The delete_all_policy_resources attribute.
    /// </summary>
    public TerraformProperty<bool>? DeleteAllPolicyResources
    {
        get => GetProperty<TerraformProperty<bool>>("delete_all_policy_resources");
        set => this.WithProperty("delete_all_policy_resources", value);
    }

    /// <summary>
    /// The delete_unused_fm_managed_resources attribute.
    /// </summary>
    public TerraformProperty<bool>? DeleteUnusedFmManagedResources
    {
        get => GetProperty<TerraformProperty<bool>>("delete_unused_fm_managed_resources");
        set => this.WithProperty("delete_unused_fm_managed_resources", value);
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformProperty<string>? Description
    {
        get => GetProperty<TerraformProperty<string>>("description");
        set => this.WithProperty("description", value);
    }

    /// <summary>
    /// The exclude_resource_tags attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ExcludeResourceTags is required")]
    public required TerraformProperty<bool> ExcludeResourceTags
    {
        get => GetRequiredProperty<TerraformProperty<bool>>("exclude_resource_tags");
        set => this.WithProperty("exclude_resource_tags", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string>? Id
    {
        get => GetProperty<TerraformProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetRequiredProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformProperty<string>? Region
    {
        get => GetProperty<TerraformProperty<string>>("region");
        set => this.WithProperty("region", value);
    }

    /// <summary>
    /// The remediation_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? RemediationEnabled
    {
        get => GetProperty<TerraformProperty<bool>>("remediation_enabled");
        set => this.WithProperty("remediation_enabled", value);
    }

    /// <summary>
    /// The resource_set_ids attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>>? ResourceSetIds
    {
        get => GetProperty<HashSet<TerraformProperty<string>>>("resource_set_ids");
        set => this.WithProperty("resource_set_ids", value);
    }

    /// <summary>
    /// The resource_tag_logical_operator attribute.
    /// </summary>
    public TerraformProperty<string>? ResourceTagLogicalOperator
    {
        get => GetProperty<TerraformProperty<string>>("resource_tag_logical_operator");
        set => this.WithProperty("resource_tag_logical_operator", value);
    }

    /// <summary>
    /// The resource_tags attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? ResourceTags
    {
        get => GetProperty<Dictionary<string, TerraformProperty<string>>>("resource_tags");
        set => this.WithProperty("resource_tags", value);
    }

    /// <summary>
    /// The resource_type attribute.
    /// </summary>
    public TerraformProperty<string>? ResourceType
    {
        get => GetProperty<TerraformProperty<string>>("resource_type");
        set => this.WithProperty("resource_type", value);
    }

    /// <summary>
    /// The resource_type_list attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>>? ResourceTypeList
    {
        get => GetProperty<HashSet<TerraformProperty<string>>>("resource_type_list");
        set => this.WithProperty("resource_type_list", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? Tags
    {
        get => GetProperty<Dictionary<string, TerraformProperty<string>>>("tags");
        set => this.WithProperty("tags", value);
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? TagsAll
    {
        get => GetProperty<Dictionary<string, TerraformProperty<string>>>("tags_all");
        set => this.WithProperty("tags_all", value);
    }

    /// <summary>
    /// Block for exclude_map.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ExcludeMap block(s) allowed")]
    public List<AwsFmsPolicyExcludeMapBlock>? ExcludeMap
    {
        get => GetProperty<List<AwsFmsPolicyExcludeMapBlock>>("exclude_map");
        set => this.WithProperty("exclude_map", value);
    }

    /// <summary>
    /// Block for include_map.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 IncludeMap block(s) allowed")]
    public List<AwsFmsPolicyIncludeMapBlock>? IncludeMap
    {
        get => GetProperty<List<AwsFmsPolicyIncludeMapBlock>>("include_map");
        set => this.WithProperty("include_map", value);
    }

    /// <summary>
    /// Block for security_service_policy_data.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 SecurityServicePolicyData block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SecurityServicePolicyData block(s) allowed")]
    public List<AwsFmsPolicySecurityServicePolicyDataBlock>? SecurityServicePolicyData
    {
        get => GetProperty<List<AwsFmsPolicySecurityServicePolicyDataBlock>>("security_service_policy_data");
        set => this.WithProperty("security_service_policy_data", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

    /// <summary>
    /// The policy_update_token attribute.
    /// </summary>
    public TerraformExpression PolicyUpdateToken => this["policy_update_token"];

}

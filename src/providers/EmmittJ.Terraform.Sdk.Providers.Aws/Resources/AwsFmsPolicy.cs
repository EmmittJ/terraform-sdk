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
        set => SetProperty("account", value);
    }

    /// <summary>
    /// The orgunit attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>>? Orgunit
    {
        set => SetProperty("orgunit", value);
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
        set => SetProperty("account", value);
    }

    /// <summary>
    /// The orgunit attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>>? Orgunit
    {
        set => SetProperty("orgunit", value);
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
        set => SetProperty("managed_service_data", value);
    }

    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    public required TerraformProperty<string> Type
    {
        set => SetProperty("type", value);
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
        SetOutput("arn");
        SetOutput("policy_update_token");
        SetOutput("delete_all_policy_resources");
        SetOutput("delete_unused_fm_managed_resources");
        SetOutput("description");
        SetOutput("exclude_resource_tags");
        SetOutput("id");
        SetOutput("name");
        SetOutput("region");
        SetOutput("remediation_enabled");
        SetOutput("resource_set_ids");
        SetOutput("resource_tag_logical_operator");
        SetOutput("resource_tags");
        SetOutput("resource_type");
        SetOutput("resource_type_list");
        SetOutput("tags");
        SetOutput("tags_all");
    }

    /// <summary>
    /// The delete_all_policy_resources attribute.
    /// </summary>
    public TerraformProperty<bool> DeleteAllPolicyResources
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("delete_all_policy_resources");
        set => SetProperty("delete_all_policy_resources", value);
    }

    /// <summary>
    /// The delete_unused_fm_managed_resources attribute.
    /// </summary>
    public TerraformProperty<bool> DeleteUnusedFmManagedResources
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("delete_unused_fm_managed_resources");
        set => SetProperty("delete_unused_fm_managed_resources", value);
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformProperty<string> Description
    {
        get => GetRequiredOutput<TerraformProperty<string>>("description");
        set => SetProperty("description", value);
    }

    /// <summary>
    /// The exclude_resource_tags attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ExcludeResourceTags is required")]
    public required TerraformProperty<bool> ExcludeResourceTags
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("exclude_resource_tags");
        set => SetProperty("exclude_resource_tags", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string> Id
    {
        get => GetRequiredOutput<TerraformProperty<string>>("id");
        set => SetProperty("id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetRequiredOutput<TerraformProperty<string>>("name");
        set => SetProperty("name", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformProperty<string> Region
    {
        get => GetRequiredOutput<TerraformProperty<string>>("region");
        set => SetProperty("region", value);
    }

    /// <summary>
    /// The remediation_enabled attribute.
    /// </summary>
    public TerraformProperty<bool> RemediationEnabled
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("remediation_enabled");
        set => SetProperty("remediation_enabled", value);
    }

    /// <summary>
    /// The resource_set_ids attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>> ResourceSetIds
    {
        get => GetRequiredOutput<HashSet<TerraformProperty<string>>>("resource_set_ids");
        set => SetProperty("resource_set_ids", value);
    }

    /// <summary>
    /// The resource_tag_logical_operator attribute.
    /// </summary>
    public TerraformProperty<string> ResourceTagLogicalOperator
    {
        get => GetRequiredOutput<TerraformProperty<string>>("resource_tag_logical_operator");
        set => SetProperty("resource_tag_logical_operator", value);
    }

    /// <summary>
    /// The resource_tags attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>> ResourceTags
    {
        get => GetRequiredOutput<Dictionary<string, TerraformProperty<string>>>("resource_tags");
        set => SetProperty("resource_tags", value);
    }

    /// <summary>
    /// The resource_type attribute.
    /// </summary>
    public TerraformProperty<string> ResourceType
    {
        get => GetRequiredOutput<TerraformProperty<string>>("resource_type");
        set => SetProperty("resource_type", value);
    }

    /// <summary>
    /// The resource_type_list attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>> ResourceTypeList
    {
        get => GetRequiredOutput<HashSet<TerraformProperty<string>>>("resource_type_list");
        set => SetProperty("resource_type_list", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>> Tags
    {
        get => GetRequiredOutput<Dictionary<string, TerraformProperty<string>>>("tags");
        set => SetProperty("tags", value);
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>> TagsAll
    {
        get => GetRequiredOutput<Dictionary<string, TerraformProperty<string>>>("tags_all");
        set => SetProperty("tags_all", value);
    }

    /// <summary>
    /// Block for exclude_map.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ExcludeMap block(s) allowed")]
    public List<AwsFmsPolicyExcludeMapBlock>? ExcludeMap
    {
        set => SetProperty("exclude_map", value);
    }

    /// <summary>
    /// Block for include_map.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 IncludeMap block(s) allowed")]
    public List<AwsFmsPolicyIncludeMapBlock>? IncludeMap
    {
        set => SetProperty("include_map", value);
    }

    /// <summary>
    /// Block for security_service_policy_data.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SecurityServicePolicyData is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 SecurityServicePolicyData block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 SecurityServicePolicyData block(s) allowed")]
    public List<AwsFmsPolicySecurityServicePolicyDataBlock>? SecurityServicePolicyData
    {
        set => SetProperty("security_service_policy_data", value);
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

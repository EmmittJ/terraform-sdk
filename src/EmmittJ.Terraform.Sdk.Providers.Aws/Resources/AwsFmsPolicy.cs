using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_fms_policy resource.
/// </summary>
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
    public TerraformProperty<bool>? ExcludeResourceTags
    {
        get => GetProperty<TerraformProperty<bool>>("exclude_resource_tags");
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
    public TerraformProperty<string>? Name
    {
        get => GetProperty<TerraformProperty<string>>("name");
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
    public TerraformProperty<HashSet<string>>? ResourceSetIds
    {
        get => GetProperty<TerraformProperty<HashSet<string>>>("resource_set_ids");
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
    public TerraformMapProperty<string>? ResourceTags
    {
        get => GetProperty<TerraformMapProperty<string>>("resource_tags");
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
    public TerraformProperty<HashSet<string>>? ResourceTypeList
    {
        get => GetProperty<TerraformProperty<HashSet<string>>>("resource_type_list");
        set => this.WithProperty("resource_type_list", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMapProperty<string>? Tags
    {
        get => GetProperty<TerraformMapProperty<string>>("tags");
        set => this.WithProperty("tags", value);
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public TerraformMapProperty<string>? TagsAll
    {
        get => GetProperty<TerraformMapProperty<string>>("tags_all");
        set => this.WithProperty("tags_all", value);
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

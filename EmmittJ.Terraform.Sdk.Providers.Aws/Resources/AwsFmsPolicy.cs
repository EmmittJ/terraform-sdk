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
    public bool? DeleteAllPolicyResources
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("delete_all_policy_resources")?.Value;
        set => this.WithProperty("delete_all_policy_resources", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The delete_unused_fm_managed_resources attribute.
    /// </summary>
    public bool? DeleteUnusedFmManagedResources
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("delete_unused_fm_managed_resources")?.Value;
        set => this.WithProperty("delete_unused_fm_managed_resources", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    public string? Description
    {
        get => GetProperty<TerraformLiteralProperty<string>>("description")?.Value;
        set => this.WithProperty("description", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The exclude_resource_tags attribute.
    /// </summary>
    public bool? ExcludeResourceTags
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("exclude_resource_tags")?.Value;
        set => this.WithProperty("exclude_resource_tags", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public string? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id")?.Value;
        set => this.WithProperty("id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    public string? Name
    {
        get => GetProperty<TerraformLiteralProperty<string>>("name")?.Value;
        set => this.WithProperty("name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The remediation_enabled attribute.
    /// </summary>
    public bool? RemediationEnabled
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("remediation_enabled")?.Value;
        set => this.WithProperty("remediation_enabled", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The resource_set_ids attribute.
    /// </summary>
    public HashSet<string>? ResourceSetIds
    {
        get => GetProperty<TerraformLiteralProperty<HashSet<string>>>("resource_set_ids")?.Value;
        set => this.WithProperty("resource_set_ids", value == null ? null : new TerraformLiteralProperty<HashSet<string>>(value));
    }

    /// <summary>
    /// The resource_tags attribute.
    /// </summary>
    public Dictionary<string, string>? ResourceTags
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("resource_tags")?.Value;
        set => this.WithProperty("resource_tags", value == null ? null : new TerraformLiteralProperty<Dictionary<string, string>>(value));
    }

    /// <summary>
    /// The resource_type attribute.
    /// </summary>
    public string? ResourceType
    {
        get => GetProperty<TerraformLiteralProperty<string>>("resource_type")?.Value;
        set => this.WithProperty("resource_type", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The resource_type_list attribute.
    /// </summary>
    public HashSet<string>? ResourceTypeList
    {
        get => GetProperty<TerraformLiteralProperty<HashSet<string>>>("resource_type_list")?.Value;
        set => this.WithProperty("resource_type_list", value == null ? null : new TerraformLiteralProperty<HashSet<string>>(value));
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, string>? Tags
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("tags")?.Value;
        set => this.WithProperty("tags", value == null ? null : new TerraformLiteralProperty<Dictionary<string, string>>(value));
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public Dictionary<string, string>? TagsAll
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("tags_all")?.Value;
        set => this.WithProperty("tags_all", value == null ? null : new TerraformLiteralProperty<Dictionary<string, string>>(value));
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

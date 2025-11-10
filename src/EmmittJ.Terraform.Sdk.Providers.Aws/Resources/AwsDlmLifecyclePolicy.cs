using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for policy_details in .
/// Nesting mode: list
/// </summary>
public class AwsDlmLifecyclePolicyPolicyDetailsBlock : TerraformBlock
{
    /// <summary>
    /// The copy_tags attribute.
    /// </summary>
    public TerraformProperty<bool>? CopyTags
    {
        get => GetProperty<TerraformProperty<bool>>("copy_tags");
        set => WithProperty("copy_tags", value);
    }

    /// <summary>
    /// The create_interval attribute.
    /// </summary>
    public TerraformProperty<double>? CreateInterval
    {
        get => GetProperty<TerraformProperty<double>>("create_interval");
        set => WithProperty("create_interval", value);
    }

    /// <summary>
    /// The extend_deletion attribute.
    /// </summary>
    public TerraformProperty<bool>? ExtendDeletion
    {
        get => GetProperty<TerraformProperty<bool>>("extend_deletion");
        set => WithProperty("extend_deletion", value);
    }

    /// <summary>
    /// The policy_language attribute.
    /// </summary>
    public TerraformProperty<string>? PolicyLanguage
    {
        get => GetProperty<TerraformProperty<string>>("policy_language");
        set => WithProperty("policy_language", value);
    }

    /// <summary>
    /// The policy_type attribute.
    /// </summary>
    public TerraformProperty<string>? PolicyType
    {
        get => GetProperty<TerraformProperty<string>>("policy_type");
        set => WithProperty("policy_type", value);
    }

    /// <summary>
    /// The resource_locations attribute.
    /// </summary>
    public List<TerraformProperty<string>>? ResourceLocations
    {
        get => GetProperty<List<TerraformProperty<string>>>("resource_locations");
        set => WithProperty("resource_locations", value);
    }

    /// <summary>
    /// The resource_type attribute.
    /// </summary>
    public TerraformProperty<string>? ResourceType
    {
        get => GetProperty<TerraformProperty<string>>("resource_type");
        set => WithProperty("resource_type", value);
    }

    /// <summary>
    /// The resource_types attribute.
    /// </summary>
    public List<TerraformProperty<string>>? ResourceTypes
    {
        get => GetProperty<List<TerraformProperty<string>>>("resource_types");
        set => WithProperty("resource_types", value);
    }

    /// <summary>
    /// The retain_interval attribute.
    /// </summary>
    public TerraformProperty<double>? RetainInterval
    {
        get => GetProperty<TerraformProperty<double>>("retain_interval");
        set => WithProperty("retain_interval", value);
    }

    /// <summary>
    /// The target_tags attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? TargetTags
    {
        get => GetProperty<Dictionary<string, TerraformProperty<string>>>("target_tags");
        set => WithProperty("target_tags", value);
    }

}

/// <summary>
/// Manages a aws_dlm_lifecycle_policy resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AwsDlmLifecyclePolicy : TerraformResource
{
    public AwsDlmLifecyclePolicy(string name) : base("aws_dlm_lifecycle_policy", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("arn");
    }

    /// <summary>
    /// The default_policy attribute.
    /// </summary>
    public TerraformProperty<string>? DefaultPolicy
    {
        get => GetProperty<TerraformProperty<string>>("default_policy");
        set => this.WithProperty("default_policy", value);
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Description is required")]
    public required TerraformProperty<string> Description
    {
        get => GetProperty<TerraformProperty<string>>("description");
        set => this.WithProperty("description", value);
    }

    /// <summary>
    /// The execution_role_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ExecutionRoleArn is required")]
    public required TerraformProperty<string> ExecutionRoleArn
    {
        get => GetProperty<TerraformProperty<string>>("execution_role_arn");
        set => this.WithProperty("execution_role_arn", value);
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
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformProperty<string>? Region
    {
        get => GetProperty<TerraformProperty<string>>("region");
        set => this.WithProperty("region", value);
    }

    /// <summary>
    /// The state attribute.
    /// </summary>
    public TerraformProperty<string>? State
    {
        get => GetProperty<TerraformProperty<string>>("state");
        set => this.WithProperty("state", value);
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
    /// Block for policy_details.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 PolicyDetails block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 PolicyDetails block(s) allowed")]
    public List<AwsDlmLifecyclePolicyPolicyDetailsBlock>? PolicyDetails
    {
        get => GetProperty<List<AwsDlmLifecyclePolicyPolicyDetailsBlock>>("policy_details");
        set => this.WithProperty("policy_details", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

}

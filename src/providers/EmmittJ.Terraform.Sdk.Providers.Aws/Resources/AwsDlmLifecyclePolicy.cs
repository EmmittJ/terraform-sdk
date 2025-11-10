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
        set => SetProperty("copy_tags", value);
    }

    /// <summary>
    /// The create_interval attribute.
    /// </summary>
    public TerraformProperty<double>? CreateInterval
    {
        set => SetProperty("create_interval", value);
    }

    /// <summary>
    /// The extend_deletion attribute.
    /// </summary>
    public TerraformProperty<bool>? ExtendDeletion
    {
        set => SetProperty("extend_deletion", value);
    }

    /// <summary>
    /// The policy_language attribute.
    /// </summary>
    public TerraformProperty<string>? PolicyLanguage
    {
        set => SetProperty("policy_language", value);
    }

    /// <summary>
    /// The policy_type attribute.
    /// </summary>
    public TerraformProperty<string>? PolicyType
    {
        set => SetProperty("policy_type", value);
    }

    /// <summary>
    /// The resource_locations attribute.
    /// </summary>
    public List<TerraformProperty<string>>? ResourceLocations
    {
        set => SetProperty("resource_locations", value);
    }

    /// <summary>
    /// The resource_type attribute.
    /// </summary>
    public TerraformProperty<string>? ResourceType
    {
        set => SetProperty("resource_type", value);
    }

    /// <summary>
    /// The resource_types attribute.
    /// </summary>
    public List<TerraformProperty<string>>? ResourceTypes
    {
        set => SetProperty("resource_types", value);
    }

    /// <summary>
    /// The retain_interval attribute.
    /// </summary>
    public TerraformProperty<double>? RetainInterval
    {
        set => SetProperty("retain_interval", value);
    }

    /// <summary>
    /// The target_tags attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? TargetTags
    {
        set => SetProperty("target_tags", value);
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
        SetOutput("arn");
        SetOutput("default_policy");
        SetOutput("description");
        SetOutput("execution_role_arn");
        SetOutput("id");
        SetOutput("region");
        SetOutput("state");
        SetOutput("tags");
        SetOutput("tags_all");
    }

    /// <summary>
    /// The default_policy attribute.
    /// </summary>
    public TerraformProperty<string> DefaultPolicy
    {
        get => GetRequiredOutput<TerraformProperty<string>>("default_policy");
        set => SetProperty("default_policy", value);
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Description is required")]
    public required TerraformProperty<string> Description
    {
        get => GetRequiredOutput<TerraformProperty<string>>("description");
        set => SetProperty("description", value);
    }

    /// <summary>
    /// The execution_role_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ExecutionRoleArn is required")]
    public required TerraformProperty<string> ExecutionRoleArn
    {
        get => GetRequiredOutput<TerraformProperty<string>>("execution_role_arn");
        set => SetProperty("execution_role_arn", value);
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
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformProperty<string> Region
    {
        get => GetRequiredOutput<TerraformProperty<string>>("region");
        set => SetProperty("region", value);
    }

    /// <summary>
    /// The state attribute.
    /// </summary>
    public TerraformProperty<string> State
    {
        get => GetRequiredOutput<TerraformProperty<string>>("state");
        set => SetProperty("state", value);
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
    /// Block for policy_details.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PolicyDetails is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 PolicyDetails block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 PolicyDetails block(s) allowed")]
    public List<AwsDlmLifecyclePolicyPolicyDetailsBlock>? PolicyDetails
    {
        set => SetProperty("policy_details", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

}

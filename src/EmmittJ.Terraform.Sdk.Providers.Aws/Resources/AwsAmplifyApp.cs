using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for auto_branch_creation_config in .
/// Nesting mode: list
/// </summary>
public class AwsAmplifyAppAutoBranchCreationConfigBlock : TerraformBlock
{
    /// <summary>
    /// The basic_auth_credentials attribute.
    /// </summary>
    public TerraformProperty<string>? BasicAuthCredentials
    {
        get => GetProperty<TerraformProperty<string>>("basic_auth_credentials");
        set => WithProperty("basic_auth_credentials", value);
    }

    /// <summary>
    /// The build_spec attribute.
    /// </summary>
    public TerraformProperty<string>? BuildSpec
    {
        get => GetProperty<TerraformProperty<string>>("build_spec");
        set => WithProperty("build_spec", value);
    }

    /// <summary>
    /// The enable_auto_build attribute.
    /// </summary>
    public TerraformProperty<bool>? EnableAutoBuild
    {
        get => GetProperty<TerraformProperty<bool>>("enable_auto_build");
        set => WithProperty("enable_auto_build", value);
    }

    /// <summary>
    /// The enable_basic_auth attribute.
    /// </summary>
    public TerraformProperty<bool>? EnableBasicAuth
    {
        get => GetProperty<TerraformProperty<bool>>("enable_basic_auth");
        set => WithProperty("enable_basic_auth", value);
    }

    /// <summary>
    /// The enable_performance_mode attribute.
    /// </summary>
    public TerraformProperty<bool>? EnablePerformanceMode
    {
        get => GetProperty<TerraformProperty<bool>>("enable_performance_mode");
        set => WithProperty("enable_performance_mode", value);
    }

    /// <summary>
    /// The enable_pull_request_preview attribute.
    /// </summary>
    public TerraformProperty<bool>? EnablePullRequestPreview
    {
        get => GetProperty<TerraformProperty<bool>>("enable_pull_request_preview");
        set => WithProperty("enable_pull_request_preview", value);
    }

    /// <summary>
    /// The environment_variables attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? EnvironmentVariables
    {
        get => GetProperty<Dictionary<string, TerraformProperty<string>>>("environment_variables");
        set => WithProperty("environment_variables", value);
    }

    /// <summary>
    /// The framework attribute.
    /// </summary>
    public TerraformProperty<string>? Framework
    {
        get => GetProperty<TerraformProperty<string>>("framework");
        set => WithProperty("framework", value);
    }

    /// <summary>
    /// The pull_request_environment_name attribute.
    /// </summary>
    public TerraformProperty<string>? PullRequestEnvironmentName
    {
        get => GetProperty<TerraformProperty<string>>("pull_request_environment_name");
        set => WithProperty("pull_request_environment_name", value);
    }

    /// <summary>
    /// The stage attribute.
    /// </summary>
    public TerraformProperty<string>? Stage
    {
        get => GetProperty<TerraformProperty<string>>("stage");
        set => WithProperty("stage", value);
    }

}

/// <summary>
/// Block type for cache_config in .
/// Nesting mode: list
/// </summary>
public class AwsAmplifyAppCacheConfigBlock : TerraformBlock
{
    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    public required TerraformProperty<string> Type
    {
        get => GetProperty<TerraformProperty<string>>("type");
        set => WithProperty("type", value);
    }

}

/// <summary>
/// Block type for custom_rule in .
/// Nesting mode: list
/// </summary>
public class AwsAmplifyAppCustomRuleBlock : TerraformBlock
{
    /// <summary>
    /// The condition attribute.
    /// </summary>
    public TerraformProperty<string>? Condition
    {
        get => GetProperty<TerraformProperty<string>>("condition");
        set => WithProperty("condition", value);
    }

    /// <summary>
    /// The source attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Source is required")]
    public required TerraformProperty<string> Source
    {
        get => GetProperty<TerraformProperty<string>>("source");
        set => WithProperty("source", value);
    }

    /// <summary>
    /// The status attribute.
    /// </summary>
    public TerraformProperty<string>? Status
    {
        get => GetProperty<TerraformProperty<string>>("status");
        set => WithProperty("status", value);
    }

    /// <summary>
    /// The target attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Target is required")]
    public required TerraformProperty<string> Target
    {
        get => GetProperty<TerraformProperty<string>>("target");
        set => WithProperty("target", value);
    }

}

/// <summary>
/// Block type for job_config in .
/// Nesting mode: list
/// </summary>
public class AwsAmplifyAppJobConfigBlock : TerraformBlock
{
    /// <summary>
    /// The build_compute_type attribute.
    /// </summary>
    public TerraformProperty<string>? BuildComputeType
    {
        get => GetProperty<TerraformProperty<string>>("build_compute_type");
        set => WithProperty("build_compute_type", value);
    }

}

/// <summary>
/// Manages a aws_amplify_app resource.
/// </summary>
public class AwsAmplifyApp : TerraformResource
{
    public AwsAmplifyApp(string name) : base("aws_amplify_app", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("arn");
        this.DeclareOutput("default_domain");
        this.DeclareOutput("production_branch");
    }

    /// <summary>
    /// The access_token attribute.
    /// </summary>
    public TerraformProperty<string>? AccessToken
    {
        get => GetProperty<TerraformProperty<string>>("access_token");
        set => this.WithProperty("access_token", value);
    }

    /// <summary>
    /// The auto_branch_creation_patterns attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>>? AutoBranchCreationPatterns
    {
        get => GetProperty<HashSet<TerraformProperty<string>>>("auto_branch_creation_patterns");
        set => this.WithProperty("auto_branch_creation_patterns", value);
    }

    /// <summary>
    /// The basic_auth_credentials attribute.
    /// </summary>
    public TerraformProperty<string>? BasicAuthCredentials
    {
        get => GetProperty<TerraformProperty<string>>("basic_auth_credentials");
        set => this.WithProperty("basic_auth_credentials", value);
    }

    /// <summary>
    /// The build_spec attribute.
    /// </summary>
    public TerraformProperty<string>? BuildSpec
    {
        get => GetProperty<TerraformProperty<string>>("build_spec");
        set => this.WithProperty("build_spec", value);
    }

    /// <summary>
    /// The compute_role_arn attribute.
    /// </summary>
    public TerraformProperty<string>? ComputeRoleArn
    {
        get => GetProperty<TerraformProperty<string>>("compute_role_arn");
        set => this.WithProperty("compute_role_arn", value);
    }

    /// <summary>
    /// The custom_headers attribute.
    /// </summary>
    public TerraformProperty<string>? CustomHeaders
    {
        get => GetProperty<TerraformProperty<string>>("custom_headers");
        set => this.WithProperty("custom_headers", value);
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
    /// The enable_auto_branch_creation attribute.
    /// </summary>
    public TerraformProperty<bool>? EnableAutoBranchCreation
    {
        get => GetProperty<TerraformProperty<bool>>("enable_auto_branch_creation");
        set => this.WithProperty("enable_auto_branch_creation", value);
    }

    /// <summary>
    /// The enable_basic_auth attribute.
    /// </summary>
    public TerraformProperty<bool>? EnableBasicAuth
    {
        get => GetProperty<TerraformProperty<bool>>("enable_basic_auth");
        set => this.WithProperty("enable_basic_auth", value);
    }

    /// <summary>
    /// The enable_branch_auto_build attribute.
    /// </summary>
    public TerraformProperty<bool>? EnableBranchAutoBuild
    {
        get => GetProperty<TerraformProperty<bool>>("enable_branch_auto_build");
        set => this.WithProperty("enable_branch_auto_build", value);
    }

    /// <summary>
    /// The enable_branch_auto_deletion attribute.
    /// </summary>
    public TerraformProperty<bool>? EnableBranchAutoDeletion
    {
        get => GetProperty<TerraformProperty<bool>>("enable_branch_auto_deletion");
        set => this.WithProperty("enable_branch_auto_deletion", value);
    }

    /// <summary>
    /// The environment_variables attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? EnvironmentVariables
    {
        get => GetProperty<Dictionary<string, TerraformProperty<string>>>("environment_variables");
        set => this.WithProperty("environment_variables", value);
    }

    /// <summary>
    /// The iam_service_role_arn attribute.
    /// </summary>
    public TerraformProperty<string>? IamServiceRoleArn
    {
        get => GetProperty<TerraformProperty<string>>("iam_service_role_arn");
        set => this.WithProperty("iam_service_role_arn", value);
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
        get => GetProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// The oauth_token attribute.
    /// </summary>
    public TerraformProperty<string>? OauthToken
    {
        get => GetProperty<TerraformProperty<string>>("oauth_token");
        set => this.WithProperty("oauth_token", value);
    }

    /// <summary>
    /// The platform attribute.
    /// </summary>
    public TerraformProperty<string>? Platform
    {
        get => GetProperty<TerraformProperty<string>>("platform");
        set => this.WithProperty("platform", value);
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
    /// The repository attribute.
    /// </summary>
    public TerraformProperty<string>? Repository
    {
        get => GetProperty<TerraformProperty<string>>("repository");
        set => this.WithProperty("repository", value);
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
    /// Block for auto_branch_creation_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AutoBranchCreationConfig block(s) allowed")]
    public List<AwsAmplifyAppAutoBranchCreationConfigBlock>? AutoBranchCreationConfig
    {
        get => GetProperty<List<AwsAmplifyAppAutoBranchCreationConfigBlock>>("auto_branch_creation_config");
        set => this.WithProperty("auto_branch_creation_config", value);
    }

    /// <summary>
    /// Block for cache_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 CacheConfig block(s) allowed")]
    public List<AwsAmplifyAppCacheConfigBlock>? CacheConfig
    {
        get => GetProperty<List<AwsAmplifyAppCacheConfigBlock>>("cache_config");
        set => this.WithProperty("cache_config", value);
    }

    /// <summary>
    /// Block for custom_rule.
    /// Nesting mode: list
    /// </summary>
    public List<AwsAmplifyAppCustomRuleBlock>? CustomRule
    {
        get => GetProperty<List<AwsAmplifyAppCustomRuleBlock>>("custom_rule");
        set => this.WithProperty("custom_rule", value);
    }

    /// <summary>
    /// Block for job_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 JobConfig block(s) allowed")]
    public List<AwsAmplifyAppJobConfigBlock>? JobConfig
    {
        get => GetProperty<List<AwsAmplifyAppJobConfigBlock>>("job_config");
        set => this.WithProperty("job_config", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

    /// <summary>
    /// The default_domain attribute.
    /// </summary>
    public TerraformExpression DefaultDomain => this["default_domain"];

    /// <summary>
    /// The production_branch attribute.
    /// </summary>
    public TerraformExpression ProductionBranch => this["production_branch"];

}

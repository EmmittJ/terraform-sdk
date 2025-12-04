using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for auto_branch_creation_config in AwsAmplifyApp.
/// Nesting mode: list
/// </summary>
public class AwsAmplifyAppAutoBranchCreationConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "auto_branch_creation_config";

    /// <summary>
    /// The basic_auth_credentials attribute.
    /// </summary>
    public TerraformValue<string>? BasicAuthCredentials
    {
        get => GetArgument<TerraformValue<string>>("basic_auth_credentials");
        set => SetArgument("basic_auth_credentials", value);
    }

    /// <summary>
    /// The build_spec attribute.
    /// </summary>
    public TerraformValue<string>? BuildSpec
    {
        get => GetArgument<TerraformValue<string>>("build_spec");
        set => SetArgument("build_spec", value);
    }

    /// <summary>
    /// The enable_auto_build attribute.
    /// </summary>
    public TerraformValue<bool>? EnableAutoBuild
    {
        get => GetArgument<TerraformValue<bool>>("enable_auto_build");
        set => SetArgument("enable_auto_build", value);
    }

    /// <summary>
    /// The enable_basic_auth attribute.
    /// </summary>
    public TerraformValue<bool>? EnableBasicAuth
    {
        get => GetArgument<TerraformValue<bool>>("enable_basic_auth");
        set => SetArgument("enable_basic_auth", value);
    }

    /// <summary>
    /// The enable_performance_mode attribute.
    /// </summary>
    public TerraformValue<bool>? EnablePerformanceMode
    {
        get => GetArgument<TerraformValue<bool>>("enable_performance_mode");
        set => SetArgument("enable_performance_mode", value);
    }

    /// <summary>
    /// The enable_pull_request_preview attribute.
    /// </summary>
    public TerraformValue<bool>? EnablePullRequestPreview
    {
        get => GetArgument<TerraformValue<bool>>("enable_pull_request_preview");
        set => SetArgument("enable_pull_request_preview", value);
    }

    /// <summary>
    /// The environment_variables attribute.
    /// </summary>
    public TerraformMap<string>? EnvironmentVariables
    {
        get => GetArgument<TerraformMap<string>>("environment_variables");
        set => SetArgument("environment_variables", value);
    }

    /// <summary>
    /// The framework attribute.
    /// </summary>
    public TerraformValue<string>? Framework
    {
        get => GetArgument<TerraformValue<string>>("framework");
        set => SetArgument("framework", value);
    }

    /// <summary>
    /// The pull_request_environment_name attribute.
    /// </summary>
    public TerraformValue<string>? PullRequestEnvironmentName
    {
        get => GetArgument<TerraformValue<string>>("pull_request_environment_name");
        set => SetArgument("pull_request_environment_name", value);
    }

    /// <summary>
    /// The stage attribute.
    /// </summary>
    public TerraformValue<string>? Stage
    {
        get => GetArgument<TerraformValue<string>>("stage");
        set => SetArgument("stage", value);
    }

}


/// <summary>
/// Block type for cache_config in AwsAmplifyApp.
/// Nesting mode: list
/// </summary>
public class AwsAmplifyAppCacheConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "cache_config";

    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    public required TerraformValue<string> Type
    {
        get => GetArgument<TerraformValue<string>>("type");
        set => SetArgument("type", value);
    }

}


/// <summary>
/// Block type for custom_rule in AwsAmplifyApp.
/// Nesting mode: list
/// </summary>
public class AwsAmplifyAppCustomRuleBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "custom_rule";

    /// <summary>
    /// The condition attribute.
    /// </summary>
    public TerraformValue<string>? Condition
    {
        get => GetArgument<TerraformValue<string>>("condition");
        set => SetArgument("condition", value);
    }

    /// <summary>
    /// The source attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Source is required")]
    public required TerraformValue<string> Source
    {
        get => GetArgument<TerraformValue<string>>("source");
        set => SetArgument("source", value);
    }

    /// <summary>
    /// The status attribute.
    /// </summary>
    public TerraformValue<string>? Status
    {
        get => GetArgument<TerraformValue<string>>("status");
        set => SetArgument("status", value);
    }

    /// <summary>
    /// The target attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Target is required")]
    public required TerraformValue<string> Target
    {
        get => GetArgument<TerraformValue<string>>("target");
        set => SetArgument("target", value);
    }

}


/// <summary>
/// Block type for job_config in AwsAmplifyApp.
/// Nesting mode: list
/// </summary>
public class AwsAmplifyAppJobConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "job_config";

    /// <summary>
    /// The build_compute_type attribute.
    /// </summary>
    public TerraformValue<string>? BuildComputeType
    {
        get => GetArgument<TerraformValue<string>>("build_compute_type");
        set => SetArgument("build_compute_type", value);
    }

}


/// <summary>
/// Represents a aws_amplify_app Terraform resource.
/// Manages a aws_amplify_app resource.
/// </summary>
public partial class AwsAmplifyApp(string name) : TerraformResource("aws_amplify_app", name)
{
    /// <summary>
    /// The access_token attribute.
    /// </summary>
    public TerraformValue<string>? AccessToken
    {
        get => GetArgument<TerraformValue<string>>("access_token");
        set => SetArgument("access_token", value);
    }

    /// <summary>
    /// The auto_branch_creation_patterns attribute.
    /// </summary>
    public TerraformSet<string>? AutoBranchCreationPatterns
    {
        get => GetArgument<TerraformSet<string>>("auto_branch_creation_patterns");
        set => SetArgument("auto_branch_creation_patterns", value);
    }

    /// <summary>
    /// The basic_auth_credentials attribute.
    /// </summary>
    public TerraformValue<string>? BasicAuthCredentials
    {
        get => GetArgument<TerraformValue<string>>("basic_auth_credentials");
        set => SetArgument("basic_auth_credentials", value);
    }

    /// <summary>
    /// The build_spec attribute.
    /// </summary>
    public TerraformValue<string>? BuildSpec
    {
        get => GetArgument<TerraformValue<string>>("build_spec");
        set => SetArgument("build_spec", value);
    }

    /// <summary>
    /// The compute_role_arn attribute.
    /// </summary>
    public TerraformValue<string>? ComputeRoleArn
    {
        get => GetArgument<TerraformValue<string>>("compute_role_arn");
        set => SetArgument("compute_role_arn", value);
    }

    /// <summary>
    /// The custom_headers attribute.
    /// </summary>
    public TerraformValue<string>? CustomHeaders
    {
        get => GetArgument<TerraformValue<string>>("custom_headers");
        set => SetArgument("custom_headers", value);
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformValue<string>? Description
    {
        get => GetArgument<TerraformValue<string>>("description");
        set => SetArgument("description", value);
    }

    /// <summary>
    /// The enable_auto_branch_creation attribute.
    /// </summary>
    public TerraformValue<bool>? EnableAutoBranchCreation
    {
        get => GetArgument<TerraformValue<bool>>("enable_auto_branch_creation");
        set => SetArgument("enable_auto_branch_creation", value);
    }

    /// <summary>
    /// The enable_basic_auth attribute.
    /// </summary>
    public TerraformValue<bool>? EnableBasicAuth
    {
        get => GetArgument<TerraformValue<bool>>("enable_basic_auth");
        set => SetArgument("enable_basic_auth", value);
    }

    /// <summary>
    /// The enable_branch_auto_build attribute.
    /// </summary>
    public TerraformValue<bool>? EnableBranchAutoBuild
    {
        get => GetArgument<TerraformValue<bool>>("enable_branch_auto_build");
        set => SetArgument("enable_branch_auto_build", value);
    }

    /// <summary>
    /// The enable_branch_auto_deletion attribute.
    /// </summary>
    public TerraformValue<bool>? EnableBranchAutoDeletion
    {
        get => GetArgument<TerraformValue<bool>>("enable_branch_auto_deletion");
        set => SetArgument("enable_branch_auto_deletion", value);
    }

    /// <summary>
    /// The environment_variables attribute.
    /// </summary>
    public TerraformMap<string>? EnvironmentVariables
    {
        get => GetArgument<TerraformMap<string>>("environment_variables");
        set => SetArgument("environment_variables", value);
    }

    /// <summary>
    /// The iam_service_role_arn attribute.
    /// </summary>
    public TerraformValue<string>? IamServiceRoleArn
    {
        get => GetArgument<TerraformValue<string>>("iam_service_role_arn");
        set => SetArgument("iam_service_role_arn", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string>? Id
    {
        get => GetArgument<TerraformValue<string>>("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The oauth_token attribute.
    /// </summary>
    public TerraformValue<string>? OauthToken
    {
        get => GetArgument<TerraformValue<string>>("oauth_token");
        set => SetArgument("oauth_token", value);
    }

    /// <summary>
    /// The platform attribute.
    /// </summary>
    public TerraformValue<string>? Platform
    {
        get => GetArgument<TerraformValue<string>>("platform");
        set => SetArgument("platform", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string>? Region
    {
        get => GetArgument<TerraformValue<string>>("region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// The repository attribute.
    /// </summary>
    public TerraformValue<string>? Repository
    {
        get => GetArgument<TerraformValue<string>>("repository");
        set => SetArgument("repository", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string>? Tags
    {
        get => GetArgument<TerraformMap<string>>("tags");
        set => SetArgument("tags", value);
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public TerraformMap<string>? TagsAll
    {
        get => GetArgument<TerraformMap<string>>("tags_all");
        set => SetArgument("tags_all", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
        => AsReference("arn");

    /// <summary>
    /// The default_domain attribute.
    /// </summary>
    public TerraformValue<string> DefaultDomain
        => AsReference("default_domain");

    /// <summary>
    /// The production_branch attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> ProductionBranch
        => AsReference("production_branch");

    /// <summary>
    /// AutoBranchCreationConfig block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AutoBranchCreationConfig block(s) allowed")]
    public TerraformList<AwsAmplifyAppAutoBranchCreationConfigBlock>? AutoBranchCreationConfig
    {
        get => GetArgument<TerraformList<AwsAmplifyAppAutoBranchCreationConfigBlock>>("auto_branch_creation_config");
        set => SetArgument("auto_branch_creation_config", value);
    }

    /// <summary>
    /// CacheConfig block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 CacheConfig block(s) allowed")]
    public TerraformList<AwsAmplifyAppCacheConfigBlock>? CacheConfig
    {
        get => GetArgument<TerraformList<AwsAmplifyAppCacheConfigBlock>>("cache_config");
        set => SetArgument("cache_config", value);
    }

    /// <summary>
    /// CustomRule block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsAmplifyAppCustomRuleBlock>? CustomRule
    {
        get => GetArgument<TerraformList<AwsAmplifyAppCustomRuleBlock>>("custom_rule");
        set => SetArgument("custom_rule", value);
    }

    /// <summary>
    /// JobConfig block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 JobConfig block(s) allowed")]
    public TerraformList<AwsAmplifyAppJobConfigBlock>? JobConfig
    {
        get => GetArgument<TerraformList<AwsAmplifyAppJobConfigBlock>>("job_config");
        set => SetArgument("job_config", value);
    }

}

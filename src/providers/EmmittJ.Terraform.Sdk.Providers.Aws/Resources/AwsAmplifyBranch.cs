using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Represents a aws_amplify_branch Terraform resource.
/// Manages a aws_amplify_branch resource.
/// </summary>
public partial class AwsAmplifyBranch(string name) : TerraformResource("aws_amplify_branch", name)
{
    /// <summary>
    /// The app_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AppId is required")]
    public required TerraformValue<string> AppId
    {
        get => GetRequiredArgument<TerraformValue<string>>("app_id");
        set => SetArgument("app_id", value);
    }

    /// <summary>
    /// The backend_environment_arn attribute.
    /// </summary>
    public TerraformValue<string>? BackendEnvironmentArn
    {
        get => GetArgument<TerraformValue<string>>("backend_environment_arn");
        set => SetArgument("backend_environment_arn", value);
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
    /// The branch_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "BranchName is required")]
    public required TerraformValue<string> BranchName
    {
        get => GetRequiredArgument<TerraformValue<string>>("branch_name");
        set => SetArgument("branch_name", value);
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
    /// The display_name attribute.
    /// </summary>
    public TerraformValue<string> DisplayName
    {
        get => GetArgument<TerraformValue<string>>("display_name") ?? CreateReference("display_name");
        set => SetArgument("display_name", value);
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
    /// The enable_notification attribute.
    /// </summary>
    public TerraformValue<bool>? EnableNotification
    {
        get => GetArgument<TerraformValue<bool>>("enable_notification");
        set => SetArgument("enable_notification", value);
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
    /// The enable_skew_protection attribute.
    /// </summary>
    public TerraformValue<bool>? EnableSkewProtection
    {
        get => GetArgument<TerraformValue<bool>>("enable_skew_protection");
        set => SetArgument("enable_skew_protection", value);
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
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => GetArgument<TerraformValue<string>>("id") ?? CreateReference("id");
        set => SetArgument("id", value);
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
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string> Region
    {
        get => GetArgument<TerraformValue<string>>("region") ?? CreateReference("region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// The stage attribute.
    /// </summary>
    public TerraformValue<string>? Stage
    {
        get => GetArgument<TerraformValue<string>>("stage");
        set => SetArgument("stage", value);
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
    public TerraformMap<string> TagsAll
    {
        get => GetArgument<TerraformMap<string>>("tags_all") ?? CreateReference("tags_all");
        set => SetArgument("tags_all", value);
    }

    /// <summary>
    /// The ttl attribute.
    /// </summary>
    public TerraformValue<string>? Ttl
    {
        get => GetArgument<TerraformValue<string>>("ttl");
        set => SetArgument("ttl", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
        => CreateReference("arn");

    /// <summary>
    /// The associated_resources attribute.
    /// </summary>
    public TerraformList<string> AssociatedResources
        => CreateReference("associated_resources");

    /// <summary>
    /// The custom_domains attribute.
    /// </summary>
    public TerraformList<string> CustomDomains
        => CreateReference("custom_domains");

    /// <summary>
    /// The destination_branch attribute.
    /// </summary>
    public TerraformValue<string> DestinationBranch
        => CreateReference("destination_branch");

    /// <summary>
    /// The source_branch attribute.
    /// </summary>
    public TerraformValue<string> SourceBranch
        => CreateReference("source_branch");

}

using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_amplify_branch resource.
/// </summary>
public class AwsAmplifyBranch : TerraformResource
{
    public AwsAmplifyBranch(string name) : base("aws_amplify_branch", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("arn");
        this.DeclareOutput("associated_resources");
        this.DeclareOutput("custom_domains");
        this.DeclareOutput("destination_branch");
        this.DeclareOutput("source_branch");
    }

    /// <summary>
    /// The app_id attribute.
    /// </summary>
    public string? AppId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("app_id")?.Value;
        set => this.WithProperty("app_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The backend_environment_arn attribute.
    /// </summary>
    public string? BackendEnvironmentArn
    {
        get => GetProperty<TerraformLiteralProperty<string>>("backend_environment_arn")?.Value;
        set => this.WithProperty("backend_environment_arn", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The basic_auth_credentials attribute.
    /// </summary>
    public string? BasicAuthCredentials
    {
        get => GetProperty<TerraformLiteralProperty<string>>("basic_auth_credentials")?.Value;
        set => this.WithProperty("basic_auth_credentials", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The branch_name attribute.
    /// </summary>
    public string? BranchName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("branch_name")?.Value;
        set => this.WithProperty("branch_name", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The display_name attribute.
    /// </summary>
    public string? DisplayName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("display_name")?.Value;
        set => this.WithProperty("display_name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The enable_auto_build attribute.
    /// </summary>
    public bool? EnableAutoBuild
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("enable_auto_build")?.Value;
        set => this.WithProperty("enable_auto_build", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The enable_basic_auth attribute.
    /// </summary>
    public bool? EnableBasicAuth
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("enable_basic_auth")?.Value;
        set => this.WithProperty("enable_basic_auth", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The enable_notification attribute.
    /// </summary>
    public bool? EnableNotification
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("enable_notification")?.Value;
        set => this.WithProperty("enable_notification", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The enable_performance_mode attribute.
    /// </summary>
    public bool? EnablePerformanceMode
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("enable_performance_mode")?.Value;
        set => this.WithProperty("enable_performance_mode", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The enable_pull_request_preview attribute.
    /// </summary>
    public bool? EnablePullRequestPreview
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("enable_pull_request_preview")?.Value;
        set => this.WithProperty("enable_pull_request_preview", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The enable_skew_protection attribute.
    /// </summary>
    public bool? EnableSkewProtection
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("enable_skew_protection")?.Value;
        set => this.WithProperty("enable_skew_protection", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The environment_variables attribute.
    /// </summary>
    public Dictionary<string, string>? EnvironmentVariables
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("environment_variables")?.Value;
        set => this.WithProperty("environment_variables", value == null ? null : new TerraformLiteralProperty<Dictionary<string, string>>(value));
    }

    /// <summary>
    /// The framework attribute.
    /// </summary>
    public string? Framework
    {
        get => GetProperty<TerraformLiteralProperty<string>>("framework")?.Value;
        set => this.WithProperty("framework", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The pull_request_environment_name attribute.
    /// </summary>
    public string? PullRequestEnvironmentName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("pull_request_environment_name")?.Value;
        set => this.WithProperty("pull_request_environment_name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public string? Region
    {
        get => GetProperty<TerraformLiteralProperty<string>>("region")?.Value;
        set => this.WithProperty("region", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The stage attribute.
    /// </summary>
    public string? Stage
    {
        get => GetProperty<TerraformLiteralProperty<string>>("stage")?.Value;
        set => this.WithProperty("stage", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The ttl attribute.
    /// </summary>
    public string? Ttl
    {
        get => GetProperty<TerraformLiteralProperty<string>>("ttl")?.Value;
        set => this.WithProperty("ttl", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

    /// <summary>
    /// The associated_resources attribute.
    /// </summary>
    public TerraformExpression AssociatedResources => this["associated_resources"];

    /// <summary>
    /// The custom_domains attribute.
    /// </summary>
    public TerraformExpression CustomDomains => this["custom_domains"];

    /// <summary>
    /// The destination_branch attribute.
    /// </summary>
    public TerraformExpression DestinationBranch => this["destination_branch"];

    /// <summary>
    /// The source_branch attribute.
    /// </summary>
    public TerraformExpression SourceBranch => this["source_branch"];

}

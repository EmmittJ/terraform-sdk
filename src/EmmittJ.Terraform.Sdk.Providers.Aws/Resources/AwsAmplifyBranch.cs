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
    public TerraformProperty<string>? AppId
    {
        get => GetProperty<TerraformProperty<string>>("app_id");
        set => this.WithProperty("app_id", value);
    }

    /// <summary>
    /// The backend_environment_arn attribute.
    /// </summary>
    public TerraformProperty<string>? BackendEnvironmentArn
    {
        get => GetProperty<TerraformProperty<string>>("backend_environment_arn");
        set => this.WithProperty("backend_environment_arn", value);
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
    /// The branch_name attribute.
    /// </summary>
    public TerraformProperty<string>? BranchName
    {
        get => GetProperty<TerraformProperty<string>>("branch_name");
        set => this.WithProperty("branch_name", value);
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
    /// The display_name attribute.
    /// </summary>
    public TerraformProperty<string>? DisplayName
    {
        get => GetProperty<TerraformProperty<string>>("display_name");
        set => this.WithProperty("display_name", value);
    }

    /// <summary>
    /// The enable_auto_build attribute.
    /// </summary>
    public TerraformProperty<bool>? EnableAutoBuild
    {
        get => GetProperty<TerraformProperty<bool>>("enable_auto_build");
        set => this.WithProperty("enable_auto_build", value);
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
    /// The enable_notification attribute.
    /// </summary>
    public TerraformProperty<bool>? EnableNotification
    {
        get => GetProperty<TerraformProperty<bool>>("enable_notification");
        set => this.WithProperty("enable_notification", value);
    }

    /// <summary>
    /// The enable_performance_mode attribute.
    /// </summary>
    public TerraformProperty<bool>? EnablePerformanceMode
    {
        get => GetProperty<TerraformProperty<bool>>("enable_performance_mode");
        set => this.WithProperty("enable_performance_mode", value);
    }

    /// <summary>
    /// The enable_pull_request_preview attribute.
    /// </summary>
    public TerraformProperty<bool>? EnablePullRequestPreview
    {
        get => GetProperty<TerraformProperty<bool>>("enable_pull_request_preview");
        set => this.WithProperty("enable_pull_request_preview", value);
    }

    /// <summary>
    /// The enable_skew_protection attribute.
    /// </summary>
    public TerraformProperty<bool>? EnableSkewProtection
    {
        get => GetProperty<TerraformProperty<bool>>("enable_skew_protection");
        set => this.WithProperty("enable_skew_protection", value);
    }

    /// <summary>
    /// The environment_variables attribute.
    /// </summary>
    public TerraformProperty<Dictionary<string, string>>? EnvironmentVariables
    {
        get => GetProperty<TerraformProperty<Dictionary<string, string>>>("environment_variables");
        set => this.WithProperty("environment_variables", value);
    }

    /// <summary>
    /// The framework attribute.
    /// </summary>
    public TerraformProperty<string>? Framework
    {
        get => GetProperty<TerraformProperty<string>>("framework");
        set => this.WithProperty("framework", value);
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
    /// The pull_request_environment_name attribute.
    /// </summary>
    public TerraformProperty<string>? PullRequestEnvironmentName
    {
        get => GetProperty<TerraformProperty<string>>("pull_request_environment_name");
        set => this.WithProperty("pull_request_environment_name", value);
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
    /// The stage attribute.
    /// </summary>
    public TerraformProperty<string>? Stage
    {
        get => GetProperty<TerraformProperty<string>>("stage");
        set => this.WithProperty("stage", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformProperty<Dictionary<string, string>>? Tags
    {
        get => GetProperty<TerraformProperty<Dictionary<string, string>>>("tags");
        set => this.WithProperty("tags", value);
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public TerraformProperty<Dictionary<string, string>>? TagsAll
    {
        get => GetProperty<TerraformProperty<Dictionary<string, string>>>("tags_all");
        set => this.WithProperty("tags_all", value);
    }

    /// <summary>
    /// The ttl attribute.
    /// </summary>
    public TerraformProperty<string>? Ttl
    {
        get => GetProperty<TerraformProperty<string>>("ttl");
        set => this.WithProperty("ttl", value);
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

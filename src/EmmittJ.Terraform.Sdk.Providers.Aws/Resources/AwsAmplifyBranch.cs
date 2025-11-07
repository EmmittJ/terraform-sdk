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
    public TerraformLiteralProperty<string>? AppId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("app_id");
        set => this.WithProperty("app_id", value);
    }

    /// <summary>
    /// The backend_environment_arn attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? BackendEnvironmentArn
    {
        get => GetProperty<TerraformLiteralProperty<string>>("backend_environment_arn");
        set => this.WithProperty("backend_environment_arn", value);
    }

    /// <summary>
    /// The basic_auth_credentials attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? BasicAuthCredentials
    {
        get => GetProperty<TerraformLiteralProperty<string>>("basic_auth_credentials");
        set => this.WithProperty("basic_auth_credentials", value);
    }

    /// <summary>
    /// The branch_name attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? BranchName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("branch_name");
        set => this.WithProperty("branch_name", value);
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Description
    {
        get => GetProperty<TerraformLiteralProperty<string>>("description");
        set => this.WithProperty("description", value);
    }

    /// <summary>
    /// The display_name attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? DisplayName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("display_name");
        set => this.WithProperty("display_name", value);
    }

    /// <summary>
    /// The enable_auto_build attribute.
    /// </summary>
    public TerraformLiteralProperty<bool>? EnableAutoBuild
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("enable_auto_build");
        set => this.WithProperty("enable_auto_build", value);
    }

    /// <summary>
    /// The enable_basic_auth attribute.
    /// </summary>
    public TerraformLiteralProperty<bool>? EnableBasicAuth
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("enable_basic_auth");
        set => this.WithProperty("enable_basic_auth", value);
    }

    /// <summary>
    /// The enable_notification attribute.
    /// </summary>
    public TerraformLiteralProperty<bool>? EnableNotification
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("enable_notification");
        set => this.WithProperty("enable_notification", value);
    }

    /// <summary>
    /// The enable_performance_mode attribute.
    /// </summary>
    public TerraformLiteralProperty<bool>? EnablePerformanceMode
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("enable_performance_mode");
        set => this.WithProperty("enable_performance_mode", value);
    }

    /// <summary>
    /// The enable_pull_request_preview attribute.
    /// </summary>
    public TerraformLiteralProperty<bool>? EnablePullRequestPreview
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("enable_pull_request_preview");
        set => this.WithProperty("enable_pull_request_preview", value);
    }

    /// <summary>
    /// The enable_skew_protection attribute.
    /// </summary>
    public TerraformLiteralProperty<bool>? EnableSkewProtection
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("enable_skew_protection");
        set => this.WithProperty("enable_skew_protection", value);
    }

    /// <summary>
    /// The environment_variables attribute.
    /// </summary>
    public TerraformLiteralProperty<Dictionary<string, string>>? EnvironmentVariables
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("environment_variables");
        set => this.WithProperty("environment_variables", value);
    }

    /// <summary>
    /// The framework attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Framework
    {
        get => GetProperty<TerraformLiteralProperty<string>>("framework");
        set => this.WithProperty("framework", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// The pull_request_environment_name attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? PullRequestEnvironmentName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("pull_request_environment_name");
        set => this.WithProperty("pull_request_environment_name", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformLiteralProperty<string>? Region
    {
        get => GetProperty<TerraformLiteralProperty<string>>("region");
        set => this.WithProperty("region", value);
    }

    /// <summary>
    /// The stage attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Stage
    {
        get => GetProperty<TerraformLiteralProperty<string>>("stage");
        set => this.WithProperty("stage", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformLiteralProperty<Dictionary<string, string>>? Tags
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("tags");
        set => this.WithProperty("tags", value);
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public TerraformLiteralProperty<Dictionary<string, string>>? TagsAll
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("tags_all");
        set => this.WithProperty("tags_all", value);
    }

    /// <summary>
    /// The ttl attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Ttl
    {
        get => GetProperty<TerraformLiteralProperty<string>>("ttl");
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

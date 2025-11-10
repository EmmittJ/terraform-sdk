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
        SetOutput("arn");
        SetOutput("associated_resources");
        SetOutput("custom_domains");
        SetOutput("destination_branch");
        SetOutput("source_branch");
        SetOutput("app_id");
        SetOutput("backend_environment_arn");
        SetOutput("basic_auth_credentials");
        SetOutput("branch_name");
        SetOutput("description");
        SetOutput("display_name");
        SetOutput("enable_auto_build");
        SetOutput("enable_basic_auth");
        SetOutput("enable_notification");
        SetOutput("enable_performance_mode");
        SetOutput("enable_pull_request_preview");
        SetOutput("enable_skew_protection");
        SetOutput("environment_variables");
        SetOutput("framework");
        SetOutput("id");
        SetOutput("pull_request_environment_name");
        SetOutput("region");
        SetOutput("stage");
        SetOutput("tags");
        SetOutput("tags_all");
        SetOutput("ttl");
    }

    /// <summary>
    /// The app_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AppId is required")]
    public required TerraformProperty<string> AppId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("app_id");
        set => SetProperty("app_id", value);
    }

    /// <summary>
    /// The backend_environment_arn attribute.
    /// </summary>
    public TerraformProperty<string> BackendEnvironmentArn
    {
        get => GetRequiredOutput<TerraformProperty<string>>("backend_environment_arn");
        set => SetProperty("backend_environment_arn", value);
    }

    /// <summary>
    /// The basic_auth_credentials attribute.
    /// </summary>
    public TerraformProperty<string> BasicAuthCredentials
    {
        get => GetRequiredOutput<TerraformProperty<string>>("basic_auth_credentials");
        set => SetProperty("basic_auth_credentials", value);
    }

    /// <summary>
    /// The branch_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "BranchName is required")]
    public required TerraformProperty<string> BranchName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("branch_name");
        set => SetProperty("branch_name", value);
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformProperty<string> Description
    {
        get => GetRequiredOutput<TerraformProperty<string>>("description");
        set => SetProperty("description", value);
    }

    /// <summary>
    /// The display_name attribute.
    /// </summary>
    public TerraformProperty<string> DisplayName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("display_name");
        set => SetProperty("display_name", value);
    }

    /// <summary>
    /// The enable_auto_build attribute.
    /// </summary>
    public TerraformProperty<bool> EnableAutoBuild
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("enable_auto_build");
        set => SetProperty("enable_auto_build", value);
    }

    /// <summary>
    /// The enable_basic_auth attribute.
    /// </summary>
    public TerraformProperty<bool> EnableBasicAuth
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("enable_basic_auth");
        set => SetProperty("enable_basic_auth", value);
    }

    /// <summary>
    /// The enable_notification attribute.
    /// </summary>
    public TerraformProperty<bool> EnableNotification
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("enable_notification");
        set => SetProperty("enable_notification", value);
    }

    /// <summary>
    /// The enable_performance_mode attribute.
    /// </summary>
    public TerraformProperty<bool> EnablePerformanceMode
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("enable_performance_mode");
        set => SetProperty("enable_performance_mode", value);
    }

    /// <summary>
    /// The enable_pull_request_preview attribute.
    /// </summary>
    public TerraformProperty<bool> EnablePullRequestPreview
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("enable_pull_request_preview");
        set => SetProperty("enable_pull_request_preview", value);
    }

    /// <summary>
    /// The enable_skew_protection attribute.
    /// </summary>
    public TerraformProperty<bool> EnableSkewProtection
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("enable_skew_protection");
        set => SetProperty("enable_skew_protection", value);
    }

    /// <summary>
    /// The environment_variables attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>> EnvironmentVariables
    {
        get => GetRequiredOutput<Dictionary<string, TerraformProperty<string>>>("environment_variables");
        set => SetProperty("environment_variables", value);
    }

    /// <summary>
    /// The framework attribute.
    /// </summary>
    public TerraformProperty<string> Framework
    {
        get => GetRequiredOutput<TerraformProperty<string>>("framework");
        set => SetProperty("framework", value);
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
    /// The pull_request_environment_name attribute.
    /// </summary>
    public TerraformProperty<string> PullRequestEnvironmentName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("pull_request_environment_name");
        set => SetProperty("pull_request_environment_name", value);
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
    /// The stage attribute.
    /// </summary>
    public TerraformProperty<string> Stage
    {
        get => GetRequiredOutput<TerraformProperty<string>>("stage");
        set => SetProperty("stage", value);
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
    /// The ttl attribute.
    /// </summary>
    public TerraformProperty<string> Ttl
    {
        get => GetRequiredOutput<TerraformProperty<string>>("ttl");
        set => SetProperty("ttl", value);
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

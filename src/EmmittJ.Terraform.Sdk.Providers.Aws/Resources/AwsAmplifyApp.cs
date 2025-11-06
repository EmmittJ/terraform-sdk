using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

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
    public string? AccessToken
    {
        get => GetProperty<TerraformLiteralProperty<string>>("access_token")?.Value;
        set => this.WithProperty("access_token", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The auto_branch_creation_patterns attribute.
    /// </summary>
    public HashSet<string>? AutoBranchCreationPatterns
    {
        get => GetProperty<TerraformLiteralProperty<HashSet<string>>>("auto_branch_creation_patterns")?.Value;
        set => this.WithProperty("auto_branch_creation_patterns", value == null ? null : new TerraformLiteralProperty<HashSet<string>>(value));
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
    /// The build_spec attribute.
    /// </summary>
    public string? BuildSpec
    {
        get => GetProperty<TerraformLiteralProperty<string>>("build_spec")?.Value;
        set => this.WithProperty("build_spec", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The compute_role_arn attribute.
    /// </summary>
    public string? ComputeRoleArn
    {
        get => GetProperty<TerraformLiteralProperty<string>>("compute_role_arn")?.Value;
        set => this.WithProperty("compute_role_arn", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The custom_headers attribute.
    /// </summary>
    public string? CustomHeaders
    {
        get => GetProperty<TerraformLiteralProperty<string>>("custom_headers")?.Value;
        set => this.WithProperty("custom_headers", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The enable_auto_branch_creation attribute.
    /// </summary>
    public bool? EnableAutoBranchCreation
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("enable_auto_branch_creation")?.Value;
        set => this.WithProperty("enable_auto_branch_creation", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
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
    /// The enable_branch_auto_build attribute.
    /// </summary>
    public bool? EnableBranchAutoBuild
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("enable_branch_auto_build")?.Value;
        set => this.WithProperty("enable_branch_auto_build", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The enable_branch_auto_deletion attribute.
    /// </summary>
    public bool? EnableBranchAutoDeletion
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("enable_branch_auto_deletion")?.Value;
        set => this.WithProperty("enable_branch_auto_deletion", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
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
    /// The iam_service_role_arn attribute.
    /// </summary>
    public string? IamServiceRoleArn
    {
        get => GetProperty<TerraformLiteralProperty<string>>("iam_service_role_arn")?.Value;
        set => this.WithProperty("iam_service_role_arn", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The oauth_token attribute.
    /// </summary>
    public string? OauthToken
    {
        get => GetProperty<TerraformLiteralProperty<string>>("oauth_token")?.Value;
        set => this.WithProperty("oauth_token", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The platform attribute.
    /// </summary>
    public string? Platform
    {
        get => GetProperty<TerraformLiteralProperty<string>>("platform")?.Value;
        set => this.WithProperty("platform", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The repository attribute.
    /// </summary>
    public string? Repository
    {
        get => GetProperty<TerraformLiteralProperty<string>>("repository")?.Value;
        set => this.WithProperty("repository", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The default_domain attribute.
    /// </summary>
    public TerraformExpression DefaultDomain => this["default_domain"];

    /// <summary>
    /// The production_branch attribute.
    /// </summary>
    public TerraformExpression ProductionBranch => this["production_branch"];

}

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
    public TerraformLiteralProperty<string>? AccessToken
    {
        get => GetProperty<TerraformLiteralProperty<string>>("access_token");
        set => this.WithProperty("access_token", value);
    }

    /// <summary>
    /// The auto_branch_creation_patterns attribute.
    /// </summary>
    public TerraformLiteralProperty<HashSet<string>>? AutoBranchCreationPatterns
    {
        get => GetProperty<TerraformLiteralProperty<HashSet<string>>>("auto_branch_creation_patterns");
        set => this.WithProperty("auto_branch_creation_patterns", value);
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
    /// The build_spec attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? BuildSpec
    {
        get => GetProperty<TerraformLiteralProperty<string>>("build_spec");
        set => this.WithProperty("build_spec", value);
    }

    /// <summary>
    /// The compute_role_arn attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? ComputeRoleArn
    {
        get => GetProperty<TerraformLiteralProperty<string>>("compute_role_arn");
        set => this.WithProperty("compute_role_arn", value);
    }

    /// <summary>
    /// The custom_headers attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? CustomHeaders
    {
        get => GetProperty<TerraformLiteralProperty<string>>("custom_headers");
        set => this.WithProperty("custom_headers", value);
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
    /// The enable_auto_branch_creation attribute.
    /// </summary>
    public TerraformLiteralProperty<bool>? EnableAutoBranchCreation
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("enable_auto_branch_creation");
        set => this.WithProperty("enable_auto_branch_creation", value);
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
    /// The enable_branch_auto_build attribute.
    /// </summary>
    public TerraformLiteralProperty<bool>? EnableBranchAutoBuild
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("enable_branch_auto_build");
        set => this.WithProperty("enable_branch_auto_build", value);
    }

    /// <summary>
    /// The enable_branch_auto_deletion attribute.
    /// </summary>
    public TerraformLiteralProperty<bool>? EnableBranchAutoDeletion
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("enable_branch_auto_deletion");
        set => this.WithProperty("enable_branch_auto_deletion", value);
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
    /// The iam_service_role_arn attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? IamServiceRoleArn
    {
        get => GetProperty<TerraformLiteralProperty<string>>("iam_service_role_arn");
        set => this.WithProperty("iam_service_role_arn", value);
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
    /// The name attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Name
    {
        get => GetProperty<TerraformLiteralProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// The oauth_token attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? OauthToken
    {
        get => GetProperty<TerraformLiteralProperty<string>>("oauth_token");
        set => this.WithProperty("oauth_token", value);
    }

    /// <summary>
    /// The platform attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Platform
    {
        get => GetProperty<TerraformLiteralProperty<string>>("platform");
        set => this.WithProperty("platform", value);
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
    /// The repository attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Repository
    {
        get => GetProperty<TerraformLiteralProperty<string>>("repository");
        set => this.WithProperty("repository", value);
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

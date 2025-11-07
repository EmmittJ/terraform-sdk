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
    public TerraformProperty<string>? AccessToken
    {
        get => GetProperty<TerraformProperty<string>>("access_token");
        set => this.WithProperty("access_token", value);
    }

    /// <summary>
    /// The auto_branch_creation_patterns attribute.
    /// </summary>
    public TerraformProperty<HashSet<string>>? AutoBranchCreationPatterns
    {
        get => GetProperty<TerraformProperty<HashSet<string>>>("auto_branch_creation_patterns");
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
    public TerraformProperty<Dictionary<string, string>>? EnvironmentVariables
    {
        get => GetProperty<TerraformProperty<Dictionary<string, string>>>("environment_variables");
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
    public TerraformProperty<string>? Name
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

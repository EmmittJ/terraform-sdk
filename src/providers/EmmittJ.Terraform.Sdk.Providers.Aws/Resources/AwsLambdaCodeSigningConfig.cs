using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for allowed_publishers in .
/// Nesting mode: list
/// </summary>
public class AwsLambdaCodeSigningConfigAllowedPublishersBlock : TerraformBlock
{
    /// <summary>
    /// The signing_profile_version_arns attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SigningProfileVersionArns is required")]
    public HashSet<TerraformProperty<string>>? SigningProfileVersionArns
    {
        set => SetProperty("signing_profile_version_arns", value);
    }

}

/// <summary>
/// Block type for policies in .
/// Nesting mode: list
/// </summary>
public class AwsLambdaCodeSigningConfigPoliciesBlock : TerraformBlock
{
    /// <summary>
    /// The untrusted_artifact_on_deployment attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "UntrustedArtifactOnDeployment is required")]
    public required TerraformProperty<string> UntrustedArtifactOnDeployment
    {
        set => SetProperty("untrusted_artifact_on_deployment", value);
    }

}

/// <summary>
/// Manages a aws_lambda_code_signing_config resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AwsLambdaCodeSigningConfig : TerraformResource
{
    public AwsLambdaCodeSigningConfig(string name) : base("aws_lambda_code_signing_config", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("arn");
        SetOutput("config_id");
        SetOutput("last_modified");
        SetOutput("description");
        SetOutput("id");
        SetOutput("region");
        SetOutput("tags");
        SetOutput("tags_all");
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
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string> Id
    {
        get => GetRequiredOutput<TerraformProperty<string>>("id");
        set => SetProperty("id", value);
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
    /// Block for allowed_publishers.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AllowedPublishers is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 AllowedPublishers block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AllowedPublishers block(s) allowed")]
    public List<AwsLambdaCodeSigningConfigAllowedPublishersBlock>? AllowedPublishers
    {
        set => SetProperty("allowed_publishers", value);
    }

    /// <summary>
    /// Block for policies.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Policies block(s) allowed")]
    public List<AwsLambdaCodeSigningConfigPoliciesBlock>? Policies
    {
        set => SetProperty("policies", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

    /// <summary>
    /// The config_id attribute.
    /// </summary>
    public TerraformExpression ConfigId => this["config_id"];

    /// <summary>
    /// The last_modified attribute.
    /// </summary>
    public TerraformExpression LastModified => this["last_modified"];

}

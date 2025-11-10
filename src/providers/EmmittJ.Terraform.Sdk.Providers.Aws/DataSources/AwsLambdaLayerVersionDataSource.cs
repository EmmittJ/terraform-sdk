using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_lambda_layer_version.
/// </summary>
public class AwsLambdaLayerVersionDataSource : TerraformDataSource
{
    public AwsLambdaLayerVersionDataSource(string name) : base("aws_lambda_layer_version", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("arn");
        SetOutput("code_sha256");
        SetOutput("compatible_architectures");
        SetOutput("compatible_runtimes");
        SetOutput("created_date");
        SetOutput("description");
        SetOutput("layer_arn");
        SetOutput("license_info");
        SetOutput("signing_job_arn");
        SetOutput("signing_profile_version_arn");
        SetOutput("source_code_hash");
        SetOutput("source_code_size");
        SetOutput("compatible_architecture");
        SetOutput("compatible_runtime");
        SetOutput("id");
        SetOutput("layer_name");
        SetOutput("region");
        SetOutput("version");
    }

    /// <summary>
    /// The compatible_architecture attribute.
    /// </summary>
    public TerraformProperty<string> CompatibleArchitecture
    {
        get => GetRequiredOutput<TerraformProperty<string>>("compatible_architecture");
        set => SetProperty("compatible_architecture", value);
    }

    /// <summary>
    /// The compatible_runtime attribute.
    /// </summary>
    public TerraformProperty<string> CompatibleRuntime
    {
        get => GetRequiredOutput<TerraformProperty<string>>("compatible_runtime");
        set => SetProperty("compatible_runtime", value);
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
    /// The layer_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "LayerName is required")]
    public required TerraformProperty<string> LayerName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("layer_name");
        set => SetProperty("layer_name", value);
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
    /// The version attribute.
    /// </summary>
    public TerraformProperty<double> Version
    {
        get => GetRequiredOutput<TerraformProperty<double>>("version");
        set => SetProperty("version", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

    /// <summary>
    /// The code_sha256 attribute.
    /// </summary>
    public TerraformExpression CodeSha256 => this["code_sha256"];

    /// <summary>
    /// The compatible_architectures attribute.
    /// </summary>
    public TerraformExpression CompatibleArchitectures => this["compatible_architectures"];

    /// <summary>
    /// The compatible_runtimes attribute.
    /// </summary>
    public TerraformExpression CompatibleRuntimes => this["compatible_runtimes"];

    /// <summary>
    /// The created_date attribute.
    /// </summary>
    public TerraformExpression CreatedDate => this["created_date"];

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformExpression Description => this["description"];

    /// <summary>
    /// The layer_arn attribute.
    /// </summary>
    public TerraformExpression LayerArn => this["layer_arn"];

    /// <summary>
    /// The license_info attribute.
    /// </summary>
    public TerraformExpression LicenseInfo => this["license_info"];

    /// <summary>
    /// The signing_job_arn attribute.
    /// </summary>
    public TerraformExpression SigningJobArn => this["signing_job_arn"];

    /// <summary>
    /// The signing_profile_version_arn attribute.
    /// </summary>
    public TerraformExpression SigningProfileVersionArn => this["signing_profile_version_arn"];

    /// <summary>
    /// The source_code_hash attribute.
    /// </summary>
    public TerraformExpression SourceCodeHash => this["source_code_hash"];

    /// <summary>
    /// The source_code_size attribute.
    /// </summary>
    public TerraformExpression SourceCodeSize => this["source_code_size"];

}

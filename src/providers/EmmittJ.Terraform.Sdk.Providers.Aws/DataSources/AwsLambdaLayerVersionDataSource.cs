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
        this.WithOutput("arn");
        this.WithOutput("code_sha256");
        this.WithOutput("compatible_architectures");
        this.WithOutput("compatible_runtimes");
        this.WithOutput("created_date");
        this.WithOutput("description");
        this.WithOutput("layer_arn");
        this.WithOutput("license_info");
        this.WithOutput("signing_job_arn");
        this.WithOutput("signing_profile_version_arn");
        this.WithOutput("source_code_hash");
        this.WithOutput("source_code_size");
    }

    /// <summary>
    /// The compatible_architecture attribute.
    /// </summary>
    public TerraformProperty<string>? CompatibleArchitecture
    {
        get => GetProperty<TerraformProperty<string>>("compatible_architecture");
        set => this.WithProperty("compatible_architecture", value);
    }

    /// <summary>
    /// The compatible_runtime attribute.
    /// </summary>
    public TerraformProperty<string>? CompatibleRuntime
    {
        get => GetProperty<TerraformProperty<string>>("compatible_runtime");
        set => this.WithProperty("compatible_runtime", value);
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
    /// The layer_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "LayerName is required")]
    public required TerraformProperty<string> LayerName
    {
        get => GetRequiredProperty<TerraformProperty<string>>("layer_name");
        set => this.WithProperty("layer_name", value);
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
    /// The version attribute.
    /// </summary>
    public TerraformProperty<double>? Version
    {
        get => GetProperty<TerraformProperty<double>>("version");
        set => this.WithProperty("version", value);
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

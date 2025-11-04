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
        this.DeclareOutput("arn");
        this.DeclareOutput("code_sha256");
        this.DeclareOutput("compatible_architectures");
        this.DeclareOutput("compatible_runtimes");
        this.DeclareOutput("created_date");
        this.DeclareOutput("description");
        this.DeclareOutput("layer_arn");
        this.DeclareOutput("license_info");
        this.DeclareOutput("signing_job_arn");
        this.DeclareOutput("signing_profile_version_arn");
        this.DeclareOutput("source_code_hash");
        this.DeclareOutput("source_code_size");
    }

    /// <summary>
    /// The compatible_architecture attribute.
    /// </summary>
    public string? CompatibleArchitecture
    {
        get => GetProperty<TerraformLiteralProperty<string>>("compatible_architecture")?.Value;
        set => this.WithProperty("compatible_architecture", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The compatible_runtime attribute.
    /// </summary>
    public string? CompatibleRuntime
    {
        get => GetProperty<TerraformLiteralProperty<string>>("compatible_runtime")?.Value;
        set => this.WithProperty("compatible_runtime", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The layer_name attribute.
    /// </summary>
    public string? LayerName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("layer_name")?.Value;
        set => this.WithProperty("layer_name", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The version attribute.
    /// </summary>
    public double? Version
    {
        get => GetProperty<TerraformLiteralProperty<double>>("version")?.Value;
        set => this.WithProperty("version", value == null ? null : new TerraformLiteralProperty<double>(value.Value));
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

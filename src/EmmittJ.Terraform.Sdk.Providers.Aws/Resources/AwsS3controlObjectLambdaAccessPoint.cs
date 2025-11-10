using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for configuration in .
/// Nesting mode: list
/// </summary>
public class AwsS3controlObjectLambdaAccessPointConfigurationBlock : TerraformBlock
{
    /// <summary>
    /// The allowed_features attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>>? AllowedFeatures
    {
        get => GetProperty<HashSet<TerraformProperty<string>>>("allowed_features");
        set => WithProperty("allowed_features", value);
    }

    /// <summary>
    /// The cloud_watch_metrics_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? CloudWatchMetricsEnabled
    {
        get => GetProperty<TerraformProperty<bool>>("cloud_watch_metrics_enabled");
        set => WithProperty("cloud_watch_metrics_enabled", value);
    }

    /// <summary>
    /// The supporting_access_point attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SupportingAccessPoint is required")]
    public required TerraformProperty<string> SupportingAccessPoint
    {
        get => GetRequiredProperty<TerraformProperty<string>>("supporting_access_point");
        set => WithProperty("supporting_access_point", value);
    }

}

/// <summary>
/// Manages a aws_s3control_object_lambda_access_point resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AwsS3controlObjectLambdaAccessPoint : TerraformResource
{
    public AwsS3controlObjectLambdaAccessPoint(string name) : base("aws_s3control_object_lambda_access_point", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("alias");
        this.DeclareOutput("arn");
    }

    /// <summary>
    /// The account_id attribute.
    /// </summary>
    public TerraformProperty<string>? AccountId
    {
        get => GetProperty<TerraformProperty<string>>("account_id");
        set => this.WithProperty("account_id", value);
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
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetRequiredProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
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
    /// Block for configuration.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Configuration block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Configuration block(s) allowed")]
    public List<AwsS3controlObjectLambdaAccessPointConfigurationBlock>? Configuration
    {
        get => GetProperty<List<AwsS3controlObjectLambdaAccessPointConfigurationBlock>>("configuration");
        set => this.WithProperty("configuration", value);
    }

    /// <summary>
    /// The alias attribute.
    /// </summary>
    public TerraformExpression Alias => this["alias"];

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

}

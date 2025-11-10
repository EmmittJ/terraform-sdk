using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_redshift_logging resource.
/// </summary>
public class AwsRedshiftLogging : TerraformResource
{
    public AwsRedshiftLogging(string name) : base("aws_redshift_logging", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("id");
        SetOutput("bucket_name");
        SetOutput("cluster_identifier");
        SetOutput("log_destination_type");
        SetOutput("log_exports");
        SetOutput("region");
        SetOutput("s3_key_prefix");
    }

    /// <summary>
    /// The bucket_name attribute.
    /// </summary>
    public TerraformProperty<string> BucketName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("bucket_name");
        set => SetProperty("bucket_name", value);
    }

    /// <summary>
    /// The cluster_identifier attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ClusterIdentifier is required")]
    public required TerraformProperty<string> ClusterIdentifier
    {
        get => GetRequiredOutput<TerraformProperty<string>>("cluster_identifier");
        set => SetProperty("cluster_identifier", value);
    }

    /// <summary>
    /// The log_destination_type attribute.
    /// </summary>
    public TerraformProperty<string> LogDestinationType
    {
        get => GetRequiredOutput<TerraformProperty<string>>("log_destination_type");
        set => SetProperty("log_destination_type", value);
    }

    /// <summary>
    /// The log_exports attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>> LogExports
    {
        get => GetRequiredOutput<HashSet<TerraformProperty<string>>>("log_exports");
        set => SetProperty("log_exports", value);
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
    /// The s3_key_prefix attribute.
    /// </summary>
    public TerraformProperty<string> S3KeyPrefix
    {
        get => GetRequiredOutput<TerraformProperty<string>>("s3_key_prefix");
        set => SetProperty("s3_key_prefix", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformExpression Id => this["id"];

}

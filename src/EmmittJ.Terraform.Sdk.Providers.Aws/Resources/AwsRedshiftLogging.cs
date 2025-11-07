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
        this.DeclareOutput("id");
    }

    /// <summary>
    /// The bucket_name attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? BucketName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("bucket_name");
        set => this.WithProperty("bucket_name", value);
    }

    /// <summary>
    /// The cluster_identifier attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? ClusterIdentifier
    {
        get => GetProperty<TerraformLiteralProperty<string>>("cluster_identifier");
        set => this.WithProperty("cluster_identifier", value);
    }

    /// <summary>
    /// The log_destination_type attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? LogDestinationType
    {
        get => GetProperty<TerraformLiteralProperty<string>>("log_destination_type");
        set => this.WithProperty("log_destination_type", value);
    }

    /// <summary>
    /// The log_exports attribute.
    /// </summary>
    public TerraformLiteralProperty<HashSet<string>>? LogExports
    {
        get => GetProperty<TerraformLiteralProperty<HashSet<string>>>("log_exports");
        set => this.WithProperty("log_exports", value);
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
    /// The s3_key_prefix attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? S3KeyPrefix
    {
        get => GetProperty<TerraformLiteralProperty<string>>("s3_key_prefix");
        set => this.WithProperty("s3_key_prefix", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformExpression Id => this["id"];

}

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
    public string? BucketName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("bucket_name")?.Value;
        set => this.WithProperty("bucket_name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The cluster_identifier attribute.
    /// </summary>
    public string? ClusterIdentifier
    {
        get => GetProperty<TerraformLiteralProperty<string>>("cluster_identifier")?.Value;
        set => this.WithProperty("cluster_identifier", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The log_destination_type attribute.
    /// </summary>
    public string? LogDestinationType
    {
        get => GetProperty<TerraformLiteralProperty<string>>("log_destination_type")?.Value;
        set => this.WithProperty("log_destination_type", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The log_exports attribute.
    /// </summary>
    public HashSet<string>? LogExports
    {
        get => GetProperty<TerraformLiteralProperty<HashSet<string>>>("log_exports")?.Value;
        set => this.WithProperty("log_exports", value == null ? null : new TerraformLiteralProperty<HashSet<string>>(value));
    }

    /// <summary>
    /// The s3_key_prefix attribute.
    /// </summary>
    public string? S3KeyPrefix
    {
        get => GetProperty<TerraformLiteralProperty<string>>("s3_key_prefix")?.Value;
        set => this.WithProperty("s3_key_prefix", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformExpression Id => this["id"];

}

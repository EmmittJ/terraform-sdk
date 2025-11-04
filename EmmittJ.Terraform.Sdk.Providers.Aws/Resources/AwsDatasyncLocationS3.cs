using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_datasync_location_s3 resource.
/// </summary>
public class AwsDatasyncLocationS3 : TerraformResource
{
    public AwsDatasyncLocationS3(string name) : base("aws_datasync_location_s3", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("arn");
        this.DeclareOutput("uri");
    }

    /// <summary>
    /// The agent_arns attribute.
    /// </summary>
    public HashSet<string>? AgentArns
    {
        get => GetProperty<TerraformLiteralProperty<HashSet<string>>>("agent_arns")?.Value;
        set => this.WithProperty("agent_arns", value == null ? null : new TerraformLiteralProperty<HashSet<string>>(value));
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
    /// The s3_bucket_arn attribute.
    /// </summary>
    public string? S3BucketArn
    {
        get => GetProperty<TerraformLiteralProperty<string>>("s3_bucket_arn")?.Value;
        set => this.WithProperty("s3_bucket_arn", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The s3_storage_class attribute.
    /// </summary>
    public string? S3StorageClass
    {
        get => GetProperty<TerraformLiteralProperty<string>>("s3_storage_class")?.Value;
        set => this.WithProperty("s3_storage_class", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The subdirectory attribute.
    /// </summary>
    public string? Subdirectory
    {
        get => GetProperty<TerraformLiteralProperty<string>>("subdirectory")?.Value;
        set => this.WithProperty("subdirectory", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, string>? Tags
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("tags")?.Value;
        set => this.WithProperty("tags", value == null ? null : new TerraformLiteralProperty<Dictionary<string, string>>(value));
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public Dictionary<string, string>? TagsAll
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("tags_all")?.Value;
        set => this.WithProperty("tags_all", value == null ? null : new TerraformLiteralProperty<Dictionary<string, string>>(value));
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

    /// <summary>
    /// The uri attribute.
    /// </summary>
    public TerraformExpression Uri => this["uri"];

}

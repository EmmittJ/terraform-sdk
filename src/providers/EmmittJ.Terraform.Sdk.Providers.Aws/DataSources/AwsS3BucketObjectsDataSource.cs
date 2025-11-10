using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_s3_bucket_objects.
/// </summary>
[Obsolete("This data source is deprecated.")]
public class AwsS3BucketObjectsDataSource : TerraformDataSource
{
    public AwsS3BucketObjectsDataSource(string name) : base("aws_s3_bucket_objects", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("common_prefixes");
        this.DeclareOutput("keys");
        this.DeclareOutput("owners");
    }

    /// <summary>
    /// The bucket attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Bucket is required")]
    [Obsolete("This property is deprecated.")]
    public required TerraformProperty<string> Bucket
    {
        get => GetRequiredProperty<TerraformProperty<string>>("bucket");
        set => this.WithProperty("bucket", value);
    }

    /// <summary>
    /// The delimiter attribute.
    /// </summary>
    public TerraformProperty<string>? Delimiter
    {
        get => GetProperty<TerraformProperty<string>>("delimiter");
        set => this.WithProperty("delimiter", value);
    }

    /// <summary>
    /// The encoding_type attribute.
    /// </summary>
    public TerraformProperty<string>? EncodingType
    {
        get => GetProperty<TerraformProperty<string>>("encoding_type");
        set => this.WithProperty("encoding_type", value);
    }

    /// <summary>
    /// The fetch_owner attribute.
    /// </summary>
    public TerraformProperty<bool>? FetchOwner
    {
        get => GetProperty<TerraformProperty<bool>>("fetch_owner");
        set => this.WithProperty("fetch_owner", value);
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
    /// The max_keys attribute.
    /// </summary>
    public TerraformProperty<double>? MaxKeys
    {
        get => GetProperty<TerraformProperty<double>>("max_keys");
        set => this.WithProperty("max_keys", value);
    }

    /// <summary>
    /// The prefix attribute.
    /// </summary>
    public TerraformProperty<string>? Prefix
    {
        get => GetProperty<TerraformProperty<string>>("prefix");
        set => this.WithProperty("prefix", value);
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
    /// The start_after attribute.
    /// </summary>
    public TerraformProperty<string>? StartAfter
    {
        get => GetProperty<TerraformProperty<string>>("start_after");
        set => this.WithProperty("start_after", value);
    }

    /// <summary>
    /// The common_prefixes attribute.
    /// </summary>
    public TerraformExpression CommonPrefixes => this["common_prefixes"];

    /// <summary>
    /// The keys attribute.
    /// </summary>
    public TerraformExpression Keys => this["keys"];

    /// <summary>
    /// The owners attribute.
    /// </summary>
    public TerraformExpression Owners => this["owners"];

}

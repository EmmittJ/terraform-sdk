using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_s3_objects.
/// </summary>
public class AwsS3ObjectsDataSource : TerraformDataSource
{
    public AwsS3ObjectsDataSource(string name) : base("aws_s3_objects", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("common_prefixes");
        this.DeclareOutput("keys");
        this.DeclareOutput("owners");
        this.DeclareOutput("request_charged");
    }

    /// <summary>
    /// The bucket attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Bucket
    {
        get => GetProperty<TerraformLiteralProperty<string>>("bucket");
        set => this.WithProperty("bucket", value);
    }

    /// <summary>
    /// The delimiter attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Delimiter
    {
        get => GetProperty<TerraformLiteralProperty<string>>("delimiter");
        set => this.WithProperty("delimiter", value);
    }

    /// <summary>
    /// The encoding_type attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? EncodingType
    {
        get => GetProperty<TerraformLiteralProperty<string>>("encoding_type");
        set => this.WithProperty("encoding_type", value);
    }

    /// <summary>
    /// The fetch_owner attribute.
    /// </summary>
    public TerraformLiteralProperty<bool>? FetchOwner
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("fetch_owner");
        set => this.WithProperty("fetch_owner", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// The max_keys attribute.
    /// </summary>
    public TerraformLiteralProperty<double>? MaxKeys
    {
        get => GetProperty<TerraformLiteralProperty<double>>("max_keys");
        set => this.WithProperty("max_keys", value);
    }

    /// <summary>
    /// The prefix attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Prefix
    {
        get => GetProperty<TerraformLiteralProperty<string>>("prefix");
        set => this.WithProperty("prefix", value);
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
    /// The request_payer attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? RequestPayer
    {
        get => GetProperty<TerraformLiteralProperty<string>>("request_payer");
        set => this.WithProperty("request_payer", value);
    }

    /// <summary>
    /// The start_after attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? StartAfter
    {
        get => GetProperty<TerraformLiteralProperty<string>>("start_after");
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

    /// <summary>
    /// The request_charged attribute.
    /// </summary>
    public TerraformExpression RequestCharged => this["request_charged"];

}

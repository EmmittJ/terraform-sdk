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
    public string? Bucket
    {
        get => GetProperty<TerraformLiteralProperty<string>>("bucket")?.Value;
        set => this.WithProperty("bucket", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The delimiter attribute.
    /// </summary>
    public string? Delimiter
    {
        get => GetProperty<TerraformLiteralProperty<string>>("delimiter")?.Value;
        set => this.WithProperty("delimiter", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The encoding_type attribute.
    /// </summary>
    public string? EncodingType
    {
        get => GetProperty<TerraformLiteralProperty<string>>("encoding_type")?.Value;
        set => this.WithProperty("encoding_type", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The fetch_owner attribute.
    /// </summary>
    public bool? FetchOwner
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("fetch_owner")?.Value;
        set => this.WithProperty("fetch_owner", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
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
    /// The max_keys attribute.
    /// </summary>
    public double? MaxKeys
    {
        get => GetProperty<TerraformLiteralProperty<double>>("max_keys")?.Value;
        set => this.WithProperty("max_keys", value == null ? null : new TerraformLiteralProperty<double>(value.Value));
    }

    /// <summary>
    /// The prefix attribute.
    /// </summary>
    public string? Prefix
    {
        get => GetProperty<TerraformLiteralProperty<string>>("prefix")?.Value;
        set => this.WithProperty("prefix", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The request_payer attribute.
    /// </summary>
    public string? RequestPayer
    {
        get => GetProperty<TerraformLiteralProperty<string>>("request_payer")?.Value;
        set => this.WithProperty("request_payer", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The start_after attribute.
    /// </summary>
    public string? StartAfter
    {
        get => GetProperty<TerraformLiteralProperty<string>>("start_after")?.Value;
        set => this.WithProperty("start_after", value == null ? null : new TerraformLiteralProperty<string>(value));
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

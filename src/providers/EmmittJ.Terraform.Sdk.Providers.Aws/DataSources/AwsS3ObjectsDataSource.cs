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
        SetOutput("common_prefixes");
        SetOutput("keys");
        SetOutput("owners");
        SetOutput("request_charged");
        SetOutput("bucket");
        SetOutput("delimiter");
        SetOutput("encoding_type");
        SetOutput("fetch_owner");
        SetOutput("id");
        SetOutput("max_keys");
        SetOutput("prefix");
        SetOutput("region");
        SetOutput("request_payer");
        SetOutput("start_after");
    }

    /// <summary>
    /// The bucket attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Bucket is required")]
    public required TerraformProperty<string> Bucket
    {
        get => GetRequiredOutput<TerraformProperty<string>>("bucket");
        set => SetProperty("bucket", value);
    }

    /// <summary>
    /// The delimiter attribute.
    /// </summary>
    public TerraformProperty<string> Delimiter
    {
        get => GetRequiredOutput<TerraformProperty<string>>("delimiter");
        set => SetProperty("delimiter", value);
    }

    /// <summary>
    /// The encoding_type attribute.
    /// </summary>
    public TerraformProperty<string> EncodingType
    {
        get => GetRequiredOutput<TerraformProperty<string>>("encoding_type");
        set => SetProperty("encoding_type", value);
    }

    /// <summary>
    /// The fetch_owner attribute.
    /// </summary>
    public TerraformProperty<bool> FetchOwner
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("fetch_owner");
        set => SetProperty("fetch_owner", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string> Id
    {
        get => GetRequiredOutput<TerraformProperty<string>>("id");
        set => SetProperty("id", value);
    }

    /// <summary>
    /// The max_keys attribute.
    /// </summary>
    public TerraformProperty<double> MaxKeys
    {
        get => GetRequiredOutput<TerraformProperty<double>>("max_keys");
        set => SetProperty("max_keys", value);
    }

    /// <summary>
    /// The prefix attribute.
    /// </summary>
    public TerraformProperty<string> Prefix
    {
        get => GetRequiredOutput<TerraformProperty<string>>("prefix");
        set => SetProperty("prefix", value);
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
    /// The request_payer attribute.
    /// </summary>
    public TerraformProperty<string> RequestPayer
    {
        get => GetRequiredOutput<TerraformProperty<string>>("request_payer");
        set => SetProperty("request_payer", value);
    }

    /// <summary>
    /// The start_after attribute.
    /// </summary>
    public TerraformProperty<string> StartAfter
    {
        get => GetRequiredOutput<TerraformProperty<string>>("start_after");
        set => SetProperty("start_after", value);
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

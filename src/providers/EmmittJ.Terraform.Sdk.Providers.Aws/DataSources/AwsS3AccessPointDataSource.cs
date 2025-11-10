using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_s3_access_point.
/// </summary>
public class AwsS3AccessPointDataSource : TerraformDataSource
{
    public AwsS3AccessPointDataSource(string name) : base("aws_s3_access_point", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("alias");
        SetOutput("arn");
        SetOutput("bucket");
        SetOutput("bucket_account_id");
        SetOutput("data_source_id");
        SetOutput("data_source_type");
        SetOutput("endpoints");
        SetOutput("network_origin");
        SetOutput("public_access_block_configuration");
        SetOutput("tags");
        SetOutput("vpc_configuration");
        SetOutput("account_id");
        SetOutput("name");
        SetOutput("region");
    }

    /// <summary>
    /// The account_id attribute.
    /// </summary>
    public TerraformProperty<string> AccountId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("account_id");
        set => SetProperty("account_id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetRequiredOutput<TerraformProperty<string>>("name");
        set => SetProperty("name", value);
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
    /// The alias attribute.
    /// </summary>
    public TerraformExpression Alias => this["alias"];

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

    /// <summary>
    /// The bucket attribute.
    /// </summary>
    public TerraformExpression Bucket => this["bucket"];

    /// <summary>
    /// The bucket_account_id attribute.
    /// </summary>
    public TerraformExpression BucketAccountId => this["bucket_account_id"];

    /// <summary>
    /// The data_source_id attribute.
    /// </summary>
    public TerraformExpression DataSourceId => this["data_source_id"];

    /// <summary>
    /// The data_source_type attribute.
    /// </summary>
    public TerraformExpression DataSourceType => this["data_source_type"];

    /// <summary>
    /// The endpoints attribute.
    /// </summary>
    public TerraformExpression Endpoints => this["endpoints"];

    /// <summary>
    /// The network_origin attribute.
    /// </summary>
    public TerraformExpression NetworkOrigin => this["network_origin"];

    /// <summary>
    /// The public_access_block_configuration attribute.
    /// </summary>
    public TerraformExpression PublicAccessBlockConfiguration => this["public_access_block_configuration"];

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformExpression Tags => this["tags"];

    /// <summary>
    /// The vpc_configuration attribute.
    /// </summary>
    public TerraformExpression VpcConfiguration => this["vpc_configuration"];

}

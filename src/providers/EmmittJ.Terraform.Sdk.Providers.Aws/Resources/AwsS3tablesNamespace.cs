using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_s3tables_namespace resource.
/// </summary>
public class AwsS3tablesNamespace : TerraformResource
{
    public AwsS3tablesNamespace(string name) : base("aws_s3tables_namespace", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.WithOutput("created_at");
        this.WithOutput("created_by");
        this.WithOutput("owner_account_id");
    }

    /// <summary>
    /// The namespace attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Namespace is required")]
    public required TerraformProperty<string> Namespace
    {
        get => GetRequiredProperty<TerraformProperty<string>>("namespace");
        set => this.WithProperty("namespace", value);
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
    /// The table_bucket_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TableBucketArn is required")]
    public required TerraformProperty<string> TableBucketArn
    {
        get => GetRequiredProperty<TerraformProperty<string>>("table_bucket_arn");
        set => this.WithProperty("table_bucket_arn", value);
    }

    /// <summary>
    /// The created_at attribute.
    /// </summary>
    public TerraformExpression CreatedAt => this["created_at"];

    /// <summary>
    /// The created_by attribute.
    /// </summary>
    public TerraformExpression CreatedBy => this["created_by"];

    /// <summary>
    /// The owner_account_id attribute.
    /// </summary>
    public TerraformExpression OwnerAccountId => this["owner_account_id"];

}

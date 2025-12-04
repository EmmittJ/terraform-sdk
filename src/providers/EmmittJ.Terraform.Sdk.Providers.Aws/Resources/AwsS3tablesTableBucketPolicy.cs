using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Represents a aws_s3tables_table_bucket_policy Terraform resource.
/// Manages a aws_s3tables_table_bucket_policy resource.
/// </summary>
public partial class AwsS3tablesTableBucketPolicy(string name) : TerraformResource("aws_s3tables_table_bucket_policy", name)
{
    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string>? Region
    {
        get => GetArgument<TerraformValue<string>>("region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// The resource_policy attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourcePolicy is required")]
    public required TerraformValue<string> ResourcePolicy
    {
        get => GetArgument<TerraformValue<string>>("resource_policy");
        set => SetArgument("resource_policy", value);
    }

    /// <summary>
    /// The table_bucket_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TableBucketArn is required")]
    public required TerraformValue<string> TableBucketArn
    {
        get => GetArgument<TerraformValue<string>>("table_bucket_arn");
        set => SetArgument("table_bucket_arn", value);
    }

}

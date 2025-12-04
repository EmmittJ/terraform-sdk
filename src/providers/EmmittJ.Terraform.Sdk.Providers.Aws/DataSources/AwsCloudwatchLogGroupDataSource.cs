using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Represents a aws_cloudwatch_log_group Terraform data source.
/// Retrieves information about a aws_cloudwatch_log_group.
/// </summary>
public partial class AwsCloudwatchLogGroupDataSource(string name) : TerraformDataSource("aws_cloudwatch_log_group", name)
{
    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string>? Id
    {
        get => GetArgument<TerraformValue<string>>("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string>? Region
    {
        get => GetArgument<TerraformValue<string>>("region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string>? Tags
    {
        get => GetArgument<TerraformMap<string>>("tags");
        set => SetArgument("tags", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
        => AsReference("arn");

    /// <summary>
    /// The creation_time attribute.
    /// </summary>
    public TerraformValue<double> CreationTime
        => AsReference("creation_time");

    /// <summary>
    /// The kms_key_id attribute.
    /// </summary>
    public TerraformValue<string> KmsKeyId
        => AsReference("kms_key_id");

    /// <summary>
    /// The log_group_class attribute.
    /// </summary>
    public TerraformValue<string> LogGroupClass
        => AsReference("log_group_class");

    /// <summary>
    /// The retention_in_days attribute.
    /// </summary>
    public TerraformValue<double> RetentionInDays
        => AsReference("retention_in_days");

}

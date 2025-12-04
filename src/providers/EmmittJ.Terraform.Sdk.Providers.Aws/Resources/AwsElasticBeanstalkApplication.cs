using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for appversion_lifecycle in AwsElasticBeanstalkApplication.
/// Nesting mode: list
/// </summary>
public class AwsElasticBeanstalkApplicationAppversionLifecycleBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "appversion_lifecycle";

    /// <summary>
    /// The delete_source_from_s3 attribute.
    /// </summary>
    public TerraformValue<bool>? DeleteSourceFromS3
    {
        get => GetArgument<TerraformValue<bool>>("delete_source_from_s3");
        set => SetArgument("delete_source_from_s3", value);
    }

    /// <summary>
    /// The max_age_in_days attribute.
    /// </summary>
    public TerraformValue<double>? MaxAgeInDays
    {
        get => GetArgument<TerraformValue<double>>("max_age_in_days");
        set => SetArgument("max_age_in_days", value);
    }

    /// <summary>
    /// The max_count attribute.
    /// </summary>
    public TerraformValue<double>? MaxCount
    {
        get => GetArgument<TerraformValue<double>>("max_count");
        set => SetArgument("max_count", value);
    }

    /// <summary>
    /// The service_role attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ServiceRole is required")]
    public required TerraformValue<string> ServiceRole
    {
        get => GetArgument<TerraformValue<string>>("service_role");
        set => SetArgument("service_role", value);
    }

}


/// <summary>
/// Represents a aws_elastic_beanstalk_application Terraform resource.
/// Manages a aws_elastic_beanstalk_application resource.
/// </summary>
public partial class AwsElasticBeanstalkApplication(string name) : TerraformResource("aws_elastic_beanstalk_application", name)
{
    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformValue<string>? Description
    {
        get => GetArgument<TerraformValue<string>>("description");
        set => SetArgument("description", value);
    }

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
    /// The tags_all attribute.
    /// </summary>
    public TerraformMap<string>? TagsAll
    {
        get => GetArgument<TerraformMap<string>>("tags_all");
        set => SetArgument("tags_all", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
        => AsReference("arn");

    /// <summary>
    /// AppversionLifecycle block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AppversionLifecycle block(s) allowed")]
    public TerraformList<AwsElasticBeanstalkApplicationAppversionLifecycleBlock>? AppversionLifecycle
    {
        get => GetArgument<TerraformList<AwsElasticBeanstalkApplicationAppversionLifecycleBlock>>("appversion_lifecycle");
        set => SetArgument("appversion_lifecycle", value);
    }

}

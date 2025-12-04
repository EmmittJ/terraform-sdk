using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Represents a aws_guardduty_detector Terraform data source.
/// Retrieves information about a aws_guardduty_detector.
/// </summary>
public partial class AwsGuarddutyDetectorDataSource(string name) : TerraformDataSource("aws_guardduty_detector", name)
{
    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => GetArgument<TerraformValue<string>>("id") ?? AsReference("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string> Region
    {
        get => GetArgument<TerraformValue<string>>("region") ?? AsReference("region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string> Tags
    {
        get => GetArgument<TerraformMap<string>>("tags") ?? AsReference("tags");
        set => SetArgument("tags", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
        => AsReference("arn");

    /// <summary>
    /// The features attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> Features
        => AsReference("features");

    /// <summary>
    /// The finding_publishing_frequency attribute.
    /// </summary>
    public TerraformValue<string> FindingPublishingFrequency
        => AsReference("finding_publishing_frequency");

    /// <summary>
    /// The service_role_arn attribute.
    /// </summary>
    public TerraformValue<string> ServiceRoleArn
        => AsReference("service_role_arn");

    /// <summary>
    /// The status attribute.
    /// </summary>
    public TerraformValue<string> Status
        => AsReference("status");

}

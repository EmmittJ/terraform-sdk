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
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string> Region
    {
        get => new TerraformReference<string>(this, "region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string> Tags
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "tags").ResolveNodes(ctx));
        set => SetArgument("tags", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
    {
        get => new TerraformReference<string>(this, "arn");
    }

    /// <summary>
    /// The features attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> Features
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "features").ResolveNodes(ctx));
    }

    /// <summary>
    /// The finding_publishing_frequency attribute.
    /// </summary>
    public TerraformValue<string> FindingPublishingFrequency
    {
        get => new TerraformReference<string>(this, "finding_publishing_frequency");
    }

    /// <summary>
    /// The service_role_arn attribute.
    /// </summary>
    public TerraformValue<string> ServiceRoleArn
    {
        get => new TerraformReference<string>(this, "service_role_arn");
    }

    /// <summary>
    /// The status attribute.
    /// </summary>
    public TerraformValue<string> Status
    {
        get => new TerraformReference<string>(this, "status");
    }

}

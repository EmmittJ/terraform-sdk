using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for openzfs_configuration in .
/// Nesting mode: list
/// </summary>
public class AwsFsxS3AccessPointAttachmentOpenzfsConfigurationBlock : TerraformBlock
{
    /// <summary>
    /// The volume_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "VolumeId is required")]
    public required TerraformProperty<string> VolumeId
    {
        set => SetProperty("volume_id", value);
    }

}

/// <summary>
/// Block type for s3_access_point in .
/// Nesting mode: list
/// </summary>
public class AwsFsxS3AccessPointAttachmentS3AccessPointBlock : TerraformBlock
{
    /// <summary>
    /// The policy attribute.
    /// </summary>
    public TerraformProperty<string>? Policy
    {
        set => SetProperty("policy", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AwsFsxS3AccessPointAttachmentTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// A string that can be [parsed as a duration](https://pkg.go.dev/time#ParseDuration) consisting of numbers and unit suffixes, such as &amp;quot;30s&amp;quot; or &amp;quot;2h45m&amp;quot;. Valid time units are &amp;quot;s&amp;quot; (seconds), &amp;quot;m&amp;quot; (minutes), &amp;quot;h&amp;quot; (hours).
    /// </summary>
    public TerraformProperty<string>? Create
    {
        set => SetProperty("create", value);
    }

    /// <summary>
    /// A string that can be [parsed as a duration](https://pkg.go.dev/time#ParseDuration) consisting of numbers and unit suffixes, such as &amp;quot;30s&amp;quot; or &amp;quot;2h45m&amp;quot;. Valid time units are &amp;quot;s&amp;quot; (seconds), &amp;quot;m&amp;quot; (minutes), &amp;quot;h&amp;quot; (hours). Setting a timeout for a Delete operation is only applicable if changes are saved into state before the destroy operation occurs.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        set => SetProperty("delete", value);
    }

}

/// <summary>
/// Manages a aws_fsx_s3_access_point_attachment resource.
/// </summary>
public class AwsFsxS3AccessPointAttachment : TerraformResource
{
    public AwsFsxS3AccessPointAttachment(string name) : base("aws_fsx_s3_access_point_attachment", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("s3_access_point_alias");
        SetOutput("s3_access_point_arn");
        SetOutput("name");
        SetOutput("region");
        SetOutput("type");
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
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    public required TerraformProperty<string> Type
    {
        get => GetRequiredOutput<TerraformProperty<string>>("type");
        set => SetProperty("type", value);
    }

    /// <summary>
    /// Block for openzfs_configuration.
    /// Nesting mode: list
    /// </summary>
    public List<AwsFsxS3AccessPointAttachmentOpenzfsConfigurationBlock>? OpenzfsConfiguration
    {
        set => SetProperty("openzfs_configuration", value);
    }

    /// <summary>
    /// Block for s3_access_point.
    /// Nesting mode: list
    /// </summary>
    public List<AwsFsxS3AccessPointAttachmentS3AccessPointBlock>? S3AccessPoint
    {
        set => SetProperty("s3_access_point", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AwsFsxS3AccessPointAttachmentTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

    /// <summary>
    /// The s3_access_point_alias attribute.
    /// </summary>
    public TerraformExpression S3AccessPointAlias => this["s3_access_point_alias"];

    /// <summary>
    /// The s3_access_point_arn attribute.
    /// </summary>
    public TerraformExpression S3AccessPointArn => this["s3_access_point_arn"];

}

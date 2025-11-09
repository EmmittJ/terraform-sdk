using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_workspacesweb_user_access_logging_settings resource.
/// </summary>
public class AwsWorkspaceswebUserAccessLoggingSettings : TerraformResource
{
    public AwsWorkspaceswebUserAccessLoggingSettings(string name) : base("aws_workspacesweb_user_access_logging_settings", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("associated_portal_arns");
        this.DeclareOutput("tags_all");
        this.DeclareOutput("user_access_logging_settings_arn");
    }

    /// <summary>
    /// The kinesis_stream_arn attribute.
    /// </summary>
    public TerraformProperty<string>? KinesisStreamArn
    {
        get => GetProperty<TerraformProperty<string>>("kinesis_stream_arn");
        set => this.WithProperty("kinesis_stream_arn", value);
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
    /// The tags attribute.
    /// </summary>
    public TerraformMapProperty<string>? Tags
    {
        get => GetProperty<TerraformMapProperty<string>>("tags");
        set => this.WithProperty("tags", value);
    }

    /// <summary>
    /// The associated_portal_arns attribute.
    /// </summary>
    public TerraformExpression AssociatedPortalArns => this["associated_portal_arns"];

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public TerraformExpression TagsAll => this["tags_all"];

    /// <summary>
    /// The user_access_logging_settings_arn attribute.
    /// </summary>
    public TerraformExpression UserAccessLoggingSettingsArn => this["user_access_logging_settings_arn"];

}

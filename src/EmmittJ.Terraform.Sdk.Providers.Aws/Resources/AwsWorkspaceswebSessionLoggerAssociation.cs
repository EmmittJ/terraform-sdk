using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_workspacesweb_session_logger_association resource.
/// </summary>
public class AwsWorkspaceswebSessionLoggerAssociation : TerraformResource
{
    public AwsWorkspaceswebSessionLoggerAssociation(string name) : base("aws_workspacesweb_session_logger_association", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
    }

    /// <summary>
    /// The portal_arn attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? PortalArn
    {
        get => GetProperty<TerraformLiteralProperty<string>>("portal_arn");
        set => this.WithProperty("portal_arn", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformLiteralProperty<string>? Region
    {
        get => GetProperty<TerraformLiteralProperty<string>>("region");
        set => this.WithProperty("region", value);
    }

    /// <summary>
    /// The session_logger_arn attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? SessionLoggerArn
    {
        get => GetProperty<TerraformLiteralProperty<string>>("session_logger_arn");
        set => this.WithProperty("session_logger_arn", value);
    }

}

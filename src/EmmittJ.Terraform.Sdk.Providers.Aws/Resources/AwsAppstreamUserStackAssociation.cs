using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_appstream_user_stack_association resource.
/// </summary>
public class AwsAppstreamUserStackAssociation : TerraformResource
{
    public AwsAppstreamUserStackAssociation(string name) : base("aws_appstream_user_stack_association", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
    }

    /// <summary>
    /// The authentication_type attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? AuthenticationType
    {
        get => GetProperty<TerraformLiteralProperty<string>>("authentication_type");
        set => this.WithProperty("authentication_type", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id");
        set => this.WithProperty("id", value);
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
    /// The send_email_notification attribute.
    /// </summary>
    public TerraformLiteralProperty<bool>? SendEmailNotification
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("send_email_notification");
        set => this.WithProperty("send_email_notification", value);
    }

    /// <summary>
    /// The stack_name attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? StackName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("stack_name");
        set => this.WithProperty("stack_name", value);
    }

    /// <summary>
    /// The user_name attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? UserName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("user_name");
        set => this.WithProperty("user_name", value);
    }

}

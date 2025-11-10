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
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AuthenticationType is required")]
    public required TerraformProperty<string> AuthenticationType
    {
        get => GetProperty<TerraformProperty<string>>("authentication_type");
        set => this.WithProperty("authentication_type", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string>? Id
    {
        get => GetProperty<TerraformProperty<string>>("id");
        set => this.WithProperty("id", value);
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
    /// The send_email_notification attribute.
    /// </summary>
    public TerraformProperty<bool>? SendEmailNotification
    {
        get => GetProperty<TerraformProperty<bool>>("send_email_notification");
        set => this.WithProperty("send_email_notification", value);
    }

    /// <summary>
    /// The stack_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "StackName is required")]
    public required TerraformProperty<string> StackName
    {
        get => GetProperty<TerraformProperty<string>>("stack_name");
        set => this.WithProperty("stack_name", value);
    }

    /// <summary>
    /// The user_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "UserName is required")]
    public required TerraformProperty<string> UserName
    {
        get => GetProperty<TerraformProperty<string>>("user_name");
        set => this.WithProperty("user_name", value);
    }

}

using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Represents a aws_ssoadmin_application Terraform data source.
/// Retrieves information about a aws_ssoadmin_application.
/// </summary>
public partial class AwsSsoadminApplicationDataSource(string name) : TerraformDataSource("aws_ssoadmin_application", name)
{
    /// <summary>
    /// The application_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ApplicationArn is required")]
    public required TerraformValue<string> ApplicationArn
    {
        get => GetArgument<TerraformValue<string>>("application_arn");
        set => SetArgument("application_arn", value);
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
    /// The application_account attribute.
    /// </summary>
    public TerraformValue<string> ApplicationAccount
        => AsReference("application_account");

    /// <summary>
    /// The application_provider_arn attribute.
    /// </summary>
    public TerraformValue<string> ApplicationProviderArn
        => AsReference("application_provider_arn");

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformValue<string> Description
        => AsReference("description");

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
        => AsReference("id");

    /// <summary>
    /// The instance_arn attribute.
    /// </summary>
    public TerraformValue<string> InstanceArn
        => AsReference("instance_arn");

    /// <summary>
    /// The name attribute.
    /// </summary>
    public TerraformValue<string> Name
        => AsReference("name");

    /// <summary>
    /// The portal_options attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> PortalOptions
        => AsReference("portal_options");

    /// <summary>
    /// The status attribute.
    /// </summary>
    public TerraformValue<string> Status
        => AsReference("status");

}

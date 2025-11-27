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
        get => new TerraformReference<string>(this, "application_arn");
        set => SetArgument("application_arn", value);
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
    /// The application_account attribute.
    /// </summary>
    public TerraformValue<string> ApplicationAccount
    {
        get => new TerraformReference<string>(this, "application_account");
    }

    /// <summary>
    /// The application_provider_arn attribute.
    /// </summary>
    public TerraformValue<string> ApplicationProviderArn
    {
        get => new TerraformReference<string>(this, "application_provider_arn");
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformValue<string> Description
    {
        get => new TerraformReference<string>(this, "description");
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
    }

    /// <summary>
    /// The instance_arn attribute.
    /// </summary>
    public TerraformValue<string> InstanceArn
    {
        get => new TerraformReference<string>(this, "instance_arn");
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    public TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
    }

    /// <summary>
    /// The portal_options attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> PortalOptions
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "portal_options").ResolveNodes(ctx));
    }

    /// <summary>
    /// The status attribute.
    /// </summary>
    public TerraformValue<string> Status
    {
        get => new TerraformReference<string>(this, "status");
    }

}

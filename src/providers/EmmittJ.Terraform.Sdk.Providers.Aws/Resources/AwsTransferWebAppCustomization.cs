using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Represents a aws_transfer_web_app_customization Terraform resource.
/// Manages a aws_transfer_web_app_customization resource.
/// </summary>
public partial class AwsTransferWebAppCustomization(string name) : TerraformResource("aws_transfer_web_app_customization", name)
{
    /// <summary>
    /// The favicon_file attribute.
    /// </summary>
    public TerraformValue<string> FaviconFile
    {
        get => GetArgument<TerraformValue<string>>("favicon_file") ?? CreateReference("favicon_file");
        set => SetArgument("favicon_file", value);
    }

    /// <summary>
    /// The logo_file attribute.
    /// </summary>
    public TerraformValue<string> LogoFile
    {
        get => GetArgument<TerraformValue<string>>("logo_file") ?? CreateReference("logo_file");
        set => SetArgument("logo_file", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string> Region
    {
        get => GetArgument<TerraformValue<string>>("region") ?? CreateReference("region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// The title attribute.
    /// </summary>
    public TerraformValue<string>? Title
    {
        get => GetArgument<TerraformValue<string>>("title");
        set => SetArgument("title", value);
    }

    /// <summary>
    /// The web_app_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "WebAppId is required")]
    public required TerraformValue<string> WebAppId
    {
        get => GetRequiredArgument<TerraformValue<string>>("web_app_id");
        set => SetArgument("web_app_id", value);
    }

}

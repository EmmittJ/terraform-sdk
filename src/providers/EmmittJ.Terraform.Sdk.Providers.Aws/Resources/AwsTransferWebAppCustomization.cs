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
        get => new TerraformReference<string>(this, "favicon_file");
        set => SetArgument("favicon_file", value);
    }

    /// <summary>
    /// The logo_file attribute.
    /// </summary>
    public TerraformValue<string> LogoFile
    {
        get => new TerraformReference<string>(this, "logo_file");
        set => SetArgument("logo_file", value);
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
    /// The title attribute.
    /// </summary>
    public TerraformValue<string>? Title
    {
        get => new TerraformReference<string>(this, "title");
        set => SetArgument("title", value);
    }

    /// <summary>
    /// The web_app_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "WebAppId is required")]
    public required TerraformValue<string> WebAppId
    {
        get => new TerraformReference<string>(this, "web_app_id");
        set => SetArgument("web_app_id", value);
    }

}

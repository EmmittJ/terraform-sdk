using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_transfer_web_app_customization resource.
/// </summary>
public class AwsTransferWebAppCustomization : TerraformResource
{
    public AwsTransferWebAppCustomization(string name) : base("aws_transfer_web_app_customization", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("favicon_file");
        SetOutput("logo_file");
        SetOutput("region");
        SetOutput("title");
        SetOutput("web_app_id");
    }

    /// <summary>
    /// The favicon_file attribute.
    /// </summary>
    public TerraformProperty<string> FaviconFile
    {
        get => GetRequiredOutput<TerraformProperty<string>>("favicon_file");
        set => SetProperty("favicon_file", value);
    }

    /// <summary>
    /// The logo_file attribute.
    /// </summary>
    public TerraformProperty<string> LogoFile
    {
        get => GetRequiredOutput<TerraformProperty<string>>("logo_file");
        set => SetProperty("logo_file", value);
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
    /// The title attribute.
    /// </summary>
    public TerraformProperty<string> Title
    {
        get => GetRequiredOutput<TerraformProperty<string>>("title");
        set => SetProperty("title", value);
    }

    /// <summary>
    /// The web_app_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "WebAppId is required")]
    public required TerraformProperty<string> WebAppId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("web_app_id");
        set => SetProperty("web_app_id", value);
    }

}

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
    }

    /// <summary>
    /// The favicon_file attribute.
    /// </summary>
    public TerraformProperty<string>? FaviconFile
    {
        get => GetProperty<TerraformProperty<string>>("favicon_file");
        set => this.WithProperty("favicon_file", value);
    }

    /// <summary>
    /// The logo_file attribute.
    /// </summary>
    public TerraformProperty<string>? LogoFile
    {
        get => GetProperty<TerraformProperty<string>>("logo_file");
        set => this.WithProperty("logo_file", value);
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
    /// The title attribute.
    /// </summary>
    public TerraformProperty<string>? Title
    {
        get => GetProperty<TerraformProperty<string>>("title");
        set => this.WithProperty("title", value);
    }

    /// <summary>
    /// The web_app_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "WebAppId is required")]
    public required TerraformProperty<string> WebAppId
    {
        get => GetRequiredProperty<TerraformProperty<string>>("web_app_id");
        set => this.WithProperty("web_app_id", value);
    }

}

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
    public string? FaviconFile
    {
        get => GetProperty<TerraformLiteralProperty<string>>("favicon_file")?.Value;
        set => this.WithProperty("favicon_file", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The logo_file attribute.
    /// </summary>
    public string? LogoFile
    {
        get => GetProperty<TerraformLiteralProperty<string>>("logo_file")?.Value;
        set => this.WithProperty("logo_file", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public string? Region
    {
        get => GetProperty<TerraformLiteralProperty<string>>("region")?.Value;
        set => this.WithProperty("region", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The title attribute.
    /// </summary>
    public string? Title
    {
        get => GetProperty<TerraformLiteralProperty<string>>("title")?.Value;
        set => this.WithProperty("title", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The web_app_id attribute.
    /// </summary>
    public string? WebAppId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("web_app_id")?.Value;
        set => this.WithProperty("web_app_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

}

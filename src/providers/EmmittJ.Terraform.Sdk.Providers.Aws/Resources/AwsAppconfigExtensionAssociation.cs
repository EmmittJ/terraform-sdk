using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_appconfig_extension_association resource.
/// </summary>
public class AwsAppconfigExtensionAssociation : TerraformResource
{
    public AwsAppconfigExtensionAssociation(string name) : base("aws_appconfig_extension_association", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("arn");
        SetOutput("extension_version");
        SetOutput("extension_arn");
        SetOutput("id");
        SetOutput("parameters");
        SetOutput("region");
        SetOutput("resource_arn");
    }

    /// <summary>
    /// The extension_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ExtensionArn is required")]
    public required TerraformProperty<string> ExtensionArn
    {
        get => GetRequiredOutput<TerraformProperty<string>>("extension_arn");
        set => SetProperty("extension_arn", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string> Id
    {
        get => GetRequiredOutput<TerraformProperty<string>>("id");
        set => SetProperty("id", value);
    }

    /// <summary>
    /// The parameters attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>> Parameters
    {
        get => GetRequiredOutput<Dictionary<string, TerraformProperty<string>>>("parameters");
        set => SetProperty("parameters", value);
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
    /// The resource_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceArn is required")]
    public required TerraformProperty<string> ResourceArn
    {
        get => GetRequiredOutput<TerraformProperty<string>>("resource_arn");
        set => SetProperty("resource_arn", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

    /// <summary>
    /// The extension_version attribute.
    /// </summary>
    public TerraformExpression ExtensionVersion => this["extension_version"];

}

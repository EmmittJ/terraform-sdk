using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_sagemaker_image_version resource.
/// </summary>
public class AwsSagemakerImageVersion : TerraformResource
{
    public AwsSagemakerImageVersion(string name) : base("aws_sagemaker_image_version", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("arn");
        SetOutput("container_image");
        SetOutput("image_arn");
        SetOutput("version");
        SetOutput("aliases");
        SetOutput("base_image");
        SetOutput("horovod");
        SetOutput("id");
        SetOutput("image_name");
        SetOutput("job_type");
        SetOutput("ml_framework");
        SetOutput("processor");
        SetOutput("programming_lang");
        SetOutput("region");
        SetOutput("release_notes");
        SetOutput("vendor_guidance");
    }

    /// <summary>
    /// The aliases attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>> Aliases
    {
        get => GetRequiredOutput<HashSet<TerraformProperty<string>>>("aliases");
        set => SetProperty("aliases", value);
    }

    /// <summary>
    /// The base_image attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "BaseImage is required")]
    public required TerraformProperty<string> BaseImage
    {
        get => GetRequiredOutput<TerraformProperty<string>>("base_image");
        set => SetProperty("base_image", value);
    }

    /// <summary>
    /// The horovod attribute.
    /// </summary>
    public TerraformProperty<bool> Horovod
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("horovod");
        set => SetProperty("horovod", value);
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
    /// The image_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ImageName is required")]
    public required TerraformProperty<string> ImageName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("image_name");
        set => SetProperty("image_name", value);
    }

    /// <summary>
    /// The job_type attribute.
    /// </summary>
    public TerraformProperty<string> JobType
    {
        get => GetRequiredOutput<TerraformProperty<string>>("job_type");
        set => SetProperty("job_type", value);
    }

    /// <summary>
    /// The ml_framework attribute.
    /// </summary>
    public TerraformProperty<string> MlFramework
    {
        get => GetRequiredOutput<TerraformProperty<string>>("ml_framework");
        set => SetProperty("ml_framework", value);
    }

    /// <summary>
    /// The processor attribute.
    /// </summary>
    public TerraformProperty<string> Processor
    {
        get => GetRequiredOutput<TerraformProperty<string>>("processor");
        set => SetProperty("processor", value);
    }

    /// <summary>
    /// The programming_lang attribute.
    /// </summary>
    public TerraformProperty<string> ProgrammingLang
    {
        get => GetRequiredOutput<TerraformProperty<string>>("programming_lang");
        set => SetProperty("programming_lang", value);
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
    /// The release_notes attribute.
    /// </summary>
    public TerraformProperty<string> ReleaseNotes
    {
        get => GetRequiredOutput<TerraformProperty<string>>("release_notes");
        set => SetProperty("release_notes", value);
    }

    /// <summary>
    /// The vendor_guidance attribute.
    /// </summary>
    public TerraformProperty<string> VendorGuidance
    {
        get => GetRequiredOutput<TerraformProperty<string>>("vendor_guidance");
        set => SetProperty("vendor_guidance", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

    /// <summary>
    /// The container_image attribute.
    /// </summary>
    public TerraformExpression ContainerImage => this["container_image"];

    /// <summary>
    /// The image_arn attribute.
    /// </summary>
    public TerraformExpression ImageArn => this["image_arn"];

    /// <summary>
    /// The version attribute.
    /// </summary>
    public TerraformExpression Version => this["version"];

}

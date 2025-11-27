using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Represents a aws_sagemaker_image_version Terraform resource.
/// Manages a aws_sagemaker_image_version resource.
/// </summary>
public partial class AwsSagemakerImageVersion(string name) : TerraformResource("aws_sagemaker_image_version", name)
{
    /// <summary>
    /// The aliases attribute.
    /// </summary>
    public TerraformSet<string>? Aliases
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "aliases").ResolveNodes(ctx));
        set => SetArgument("aliases", value);
    }

    /// <summary>
    /// The base_image attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "BaseImage is required")]
    public required TerraformValue<string> BaseImage
    {
        get => new TerraformReference<string>(this, "base_image");
        set => SetArgument("base_image", value);
    }

    /// <summary>
    /// The horovod attribute.
    /// </summary>
    public TerraformValue<bool>? Horovod
    {
        get => new TerraformReference<bool>(this, "horovod");
        set => SetArgument("horovod", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The image_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ImageName is required")]
    public required TerraformValue<string> ImageName
    {
        get => new TerraformReference<string>(this, "image_name");
        set => SetArgument("image_name", value);
    }

    /// <summary>
    /// The job_type attribute.
    /// </summary>
    public TerraformValue<string>? JobType
    {
        get => new TerraformReference<string>(this, "job_type");
        set => SetArgument("job_type", value);
    }

    /// <summary>
    /// The ml_framework attribute.
    /// </summary>
    public TerraformValue<string>? MlFramework
    {
        get => new TerraformReference<string>(this, "ml_framework");
        set => SetArgument("ml_framework", value);
    }

    /// <summary>
    /// The processor attribute.
    /// </summary>
    public TerraformValue<string>? Processor
    {
        get => new TerraformReference<string>(this, "processor");
        set => SetArgument("processor", value);
    }

    /// <summary>
    /// The programming_lang attribute.
    /// </summary>
    public TerraformValue<string>? ProgrammingLang
    {
        get => new TerraformReference<string>(this, "programming_lang");
        set => SetArgument("programming_lang", value);
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
    /// The release_notes attribute.
    /// </summary>
    public TerraformValue<string>? ReleaseNotes
    {
        get => new TerraformReference<string>(this, "release_notes");
        set => SetArgument("release_notes", value);
    }

    /// <summary>
    /// The vendor_guidance attribute.
    /// </summary>
    public TerraformValue<string>? VendorGuidance
    {
        get => new TerraformReference<string>(this, "vendor_guidance");
        set => SetArgument("vendor_guidance", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
    {
        get => new TerraformReference<string>(this, "arn");
    }

    /// <summary>
    /// The container_image attribute.
    /// </summary>
    public TerraformValue<string> ContainerImage
    {
        get => new TerraformReference<string>(this, "container_image");
    }

    /// <summary>
    /// The image_arn attribute.
    /// </summary>
    public TerraformValue<string> ImageArn
    {
        get => new TerraformReference<string>(this, "image_arn");
    }

    /// <summary>
    /// The version attribute.
    /// </summary>
    public TerraformValue<double> Version
    {
        get => new TerraformReference<double>(this, "version");
    }

}

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
        this.DeclareOutput("arn");
        this.DeclareOutput("container_image");
        this.DeclareOutput("image_arn");
        this.DeclareOutput("version");
    }

    /// <summary>
    /// The aliases attribute.
    /// </summary>
    public TerraformProperty<HashSet<string>>? Aliases
    {
        get => GetProperty<TerraformProperty<HashSet<string>>>("aliases");
        set => this.WithProperty("aliases", value);
    }

    /// <summary>
    /// The base_image attribute.
    /// </summary>
    public TerraformProperty<string>? BaseImage
    {
        get => GetProperty<TerraformProperty<string>>("base_image");
        set => this.WithProperty("base_image", value);
    }

    /// <summary>
    /// The horovod attribute.
    /// </summary>
    public TerraformProperty<bool>? Horovod
    {
        get => GetProperty<TerraformProperty<bool>>("horovod");
        set => this.WithProperty("horovod", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string>? Id
    {
        get => GetProperty<TerraformProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// The image_name attribute.
    /// </summary>
    public TerraformProperty<string>? ImageName
    {
        get => GetProperty<TerraformProperty<string>>("image_name");
        set => this.WithProperty("image_name", value);
    }

    /// <summary>
    /// The job_type attribute.
    /// </summary>
    public TerraformProperty<string>? JobType
    {
        get => GetProperty<TerraformProperty<string>>("job_type");
        set => this.WithProperty("job_type", value);
    }

    /// <summary>
    /// The ml_framework attribute.
    /// </summary>
    public TerraformProperty<string>? MlFramework
    {
        get => GetProperty<TerraformProperty<string>>("ml_framework");
        set => this.WithProperty("ml_framework", value);
    }

    /// <summary>
    /// The processor attribute.
    /// </summary>
    public TerraformProperty<string>? Processor
    {
        get => GetProperty<TerraformProperty<string>>("processor");
        set => this.WithProperty("processor", value);
    }

    /// <summary>
    /// The programming_lang attribute.
    /// </summary>
    public TerraformProperty<string>? ProgrammingLang
    {
        get => GetProperty<TerraformProperty<string>>("programming_lang");
        set => this.WithProperty("programming_lang", value);
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
    /// The release_notes attribute.
    /// </summary>
    public TerraformProperty<string>? ReleaseNotes
    {
        get => GetProperty<TerraformProperty<string>>("release_notes");
        set => this.WithProperty("release_notes", value);
    }

    /// <summary>
    /// The vendor_guidance attribute.
    /// </summary>
    public TerraformProperty<string>? VendorGuidance
    {
        get => GetProperty<TerraformProperty<string>>("vendor_guidance");
        set => this.WithProperty("vendor_guidance", value);
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

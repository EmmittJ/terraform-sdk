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
    /// The base_image attribute.
    /// </summary>
    public string? BaseImage
    {
        get => GetProperty<TerraformLiteralProperty<string>>("base_image")?.Value;
        set => this.WithProperty("base_image", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The horovod attribute.
    /// </summary>
    public bool? Horovod
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("horovod")?.Value;
        set => this.WithProperty("horovod", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public string? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id")?.Value;
        set => this.WithProperty("id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The image_name attribute.
    /// </summary>
    public string? ImageName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("image_name")?.Value;
        set => this.WithProperty("image_name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The job_type attribute.
    /// </summary>
    public string? JobType
    {
        get => GetProperty<TerraformLiteralProperty<string>>("job_type")?.Value;
        set => this.WithProperty("job_type", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The ml_framework attribute.
    /// </summary>
    public string? MlFramework
    {
        get => GetProperty<TerraformLiteralProperty<string>>("ml_framework")?.Value;
        set => this.WithProperty("ml_framework", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The processor attribute.
    /// </summary>
    public string? Processor
    {
        get => GetProperty<TerraformLiteralProperty<string>>("processor")?.Value;
        set => this.WithProperty("processor", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The programming_lang attribute.
    /// </summary>
    public string? ProgrammingLang
    {
        get => GetProperty<TerraformLiteralProperty<string>>("programming_lang")?.Value;
        set => this.WithProperty("programming_lang", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The release_notes attribute.
    /// </summary>
    public string? ReleaseNotes
    {
        get => GetProperty<TerraformLiteralProperty<string>>("release_notes")?.Value;
        set => this.WithProperty("release_notes", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The vendor_guidance attribute.
    /// </summary>
    public string? VendorGuidance
    {
        get => GetProperty<TerraformLiteralProperty<string>>("vendor_guidance")?.Value;
        set => this.WithProperty("vendor_guidance", value == null ? null : new TerraformLiteralProperty<string>(value));
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

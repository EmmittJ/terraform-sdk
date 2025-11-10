using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_devicefarm_upload resource.
/// </summary>
public class AwsDevicefarmUpload : TerraformResource
{
    public AwsDevicefarmUpload(string name) : base("aws_devicefarm_upload", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("arn");
        this.DeclareOutput("category");
        this.DeclareOutput("metadata");
        this.DeclareOutput("url");
    }

    /// <summary>
    /// The content_type attribute.
    /// </summary>
    public TerraformProperty<string>? ContentType
    {
        get => GetProperty<TerraformProperty<string>>("content_type");
        set => this.WithProperty("content_type", value);
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
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// The project_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ProjectArn is required")]
    public required TerraformProperty<string> ProjectArn
    {
        get => GetProperty<TerraformProperty<string>>("project_arn");
        set => this.WithProperty("project_arn", value);
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
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    public required TerraformProperty<string> Type
    {
        get => GetProperty<TerraformProperty<string>>("type");
        set => this.WithProperty("type", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

    /// <summary>
    /// The category attribute.
    /// </summary>
    public TerraformExpression Category => this["category"];

    /// <summary>
    /// The metadata attribute.
    /// </summary>
    public TerraformExpression Metadata => this["metadata"];

    /// <summary>
    /// The url attribute.
    /// </summary>
    public TerraformExpression Url => this["url"];

}
